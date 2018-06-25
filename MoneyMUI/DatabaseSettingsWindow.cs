using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using Gtk;
using Money;
using Newtonsoft.Json;
using WebDav;
using UI = Gtk.Builder.ObjectAttribute;

namespace MoneyUUI
{
    class DatabaseSettingsWindow : Window
    {
        public Database db;

        public string dbPath;

        [UI] private Entry databaseNameEntry = null;
        [UI] private Entry syncHostEntry = null;
        [UI] private Entry syncUserEntry = null;
        [UI] private Entry syncPassEntry = null;

        [UI] private Label syncHostLabel = null;
        [UI] private Label syncUserLabel = null;
        [UI] private Label syncPassLabel = null;

        [UI] private CheckButton useSyncCheck = null;

        [UI] private Button saveBtn = null;
        [UI] private Button cancelBtn = null;

        [UI] private ProgressBar progressBar = null;

        public DatabaseSettingsWindow(Database db, string dbPath) : this(new Builder("DatabaseSettingsWindow.glade")) 
        { 
            this.db = db;
            this.dbPath = dbPath;

            databaseNameEntry.Text = db.name;

            if (db.syncWebDav)
                useSyncCheck.Active = true;

            syncHostEntry.Text = db.webDavHost;
            syncUserEntry.Text = db.webDavUsername;
            syncPassEntry.Text = db.webDavPass;
        }

        private DatabaseSettingsWindow(Builder builder) : base(builder.GetObject("DatabaseSettingsWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;

            cancelBtn.Clicked += cancelBtn_Clicked;
            saveBtn.Clicked += saveBtn_Clicked;
            useSyncCheck.Toggled += useSyncCheck_Toggled;
        }

        public void runSync()
        {
            saveBtn.Sensitive = false;
            progressBar.Visible = true;

            progressBar.PulseStep = 0.1;
            progressBar.Pulse();

            IWebDavClient _client = new WebDavClient();
            var clientParams = new WebDavClientParams
            {
                BaseAddress = new Uri(db.webDavHost),
                Credentials = new NetworkCredential(db.webDavUsername, db.webDavPass)
            };
            _client = new WebDavClient(clientParams);

            Thread t = new Thread(async () => {

                Gtk.Application.Invoke(delegate {
                    progressBar.Pulse();
                });

                var result = await _client.Propfind(db.webDavHost + "/Money");
                if (result.IsSuccessful)
                {
                    Gtk.Application.Invoke(delegate {
                        progressBar.Pulse();
                    });

                    bool containsDb = false;
                    foreach (var res in result.Resources)
                    {
                        if (res.Uri.EndsWith("database.mdb")) //Check if we have the database online
                        {
                            containsDb = true;
                            break;
                        }
                    }

                    if (containsDb)
                    {
                        Gtk.Application.Invoke(delegate {
                            progressBar.Pulse();
                        });

                        //Let's grab the online version
                        var resultInner = await _client.GetRawFile(db.webDavHost + "/Money/database.mdb");

                        StreamReader reader = new StreamReader(resultInner.Stream);
                        string json = reader.ReadToEnd();
                        Database oDb = JsonConvert.DeserializeObject<Database>(json);

                        //Check if modDateTime is newer than current database
                        //if so replace local with online
                        if (oDb.modDateTime < db.modDateTime)
                        {
                            File.WriteAllText(dbPath, json);

                            db = null;
                            oDb = null;

                            db = new Database(dbPath);
                        }
                        else
                        //Else upload local to online
                        {
                            Gtk.Application.Invoke(delegate {
                                progressBar.Pulse();
                            });

                            //First delete the online version
                            var resultInnerInner = await _client.Delete(db.webDavHost + "/Money/database.mdb");

                            if (resultInnerInner.IsSuccessful)
                            {
                                var resultInnerInnerInner = await _client.PutFile(db.webDavHost + "/Money/database.mdb", File.OpenRead(dbPath));

                                if (!resultInnerInnerInner.IsSuccessful)
                                {
                                    Gtk.Application.Invoke(delegate {
                                        new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, false, "Failed to upload database. Sync error " + resultInnerInner.StatusCode + " (" + resultInnerInner.Description + ")").Show();
                                    });
                                }
                            }
                            else
                            {
                                Gtk.Application.Invoke(delegate {
                                    new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, false, "Failed to delete out-of-sync online database. Sync error " + resultInnerInner.StatusCode + " (" + resultInnerInner.Description + ")").Show();
                                });
                            }
                        }
                        Gtk.Application.Invoke(delegate {
                            db.Save(dbPath);
                            this.Close();
                        });
                    }
                    else
                    {
                        Gtk.Application.Invoke(delegate {
                            progressBar.Pulse();
                        });

                        var resultInner = await _client.PutFile(db.webDavHost + "/Money/database.mdb", File.OpenRead(dbPath));

                        if (!resultInner.IsSuccessful)
                        {
                            Gtk.Application.Invoke(delegate {
                                new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, false, "Sync error " + resultInner.StatusCode + " (" + resultInner.Description + ")").Show();
                            });
                        }
                        else
                        {
                            Gtk.Application.Invoke(delegate {
                                db.Save(dbPath);
                                this.Close();
                            });
                        }
                    }
                }
                else if (result.StatusCode == 404)
                {
                    Gtk.Application.Invoke(delegate {
                        progressBar.Pulse();
                    });

                    var resultInner = await _client.Mkcol("Money");

                    if (resultInner.IsSuccessful)
                    {
                        resultInner = await _client.PutFile(db.webDavHost + "/Money/database.mdb", File.OpenRead(dbPath));

                        Gtk.Application.Invoke(delegate {
                            progressBar.Pulse();
                        });

                        if (!resultInner.IsSuccessful)
                        {
                            Gtk.Application.Invoke(delegate {
                                new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, false, "Sync error " + resultInner.StatusCode + " (" + resultInner.Description + ")").Show();
                            });
                        }
                        else
                        {
                            Gtk.Application.Invoke(delegate {
                                db.Save(dbPath);
                                this.Close();
                            });
                        }
                    }
                    else
                    {
                        Gtk.Application.Invoke(delegate {
                            new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, false, "Sync error " + resultInner.StatusCode + " (" + resultInner.Description + ")").Show();
                        });
                    }
                }
                else
                {
                    Gtk.Application.Invoke(delegate {
                        new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok, false, "Sync error " + result.StatusCode + " (" + result.Description + ")").Show();
                    });
                }
                
                Gtk.Application.Invoke(delegate {
                    progressBar.Pulse();
                    progressBar.Visible = false;
                    saveBtn.Sensitive = true;
                });
            });

            t.Start();
        }

        private void useSyncCheck_Toggled(object sender, EventArgs e)
        {
            if(useSyncCheck.Active)
            {
                syncUserEntry.Sensitive = true;
                syncHostEntry.Sensitive = true;
                syncPassEntry.Sensitive = true;

                syncUserLabel.Sensitive = true;
                syncHostLabel.Sensitive = true;
                syncPassLabel.Sensitive = true;
            }
            else
            {
                syncUserEntry.Sensitive = false;
                syncHostEntry.Sensitive = false;
                syncPassEntry.Sensitive = false;

                syncUserLabel.Sensitive = false;
                syncHostLabel.Sensitive = false;
                syncPassLabel.Sensitive = false;
            }
        }


        #region Click events

        private void cancelBtn_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Clicked(object sender, EventArgs e)
        {
            db.name = databaseNameEntry.Text;
            db.syncWebDav = useSyncCheck.Active;

            if (db.syncWebDav)
            {
                db.webDavUsername = syncUserEntry.Text;
                db.webDavHost = syncHostEntry.Text;
                db.webDavPass = syncPassEntry.Text;

                progressBar.Visible = true;
                saveBtn.Sensitive = false;

                runSync();
            }
            else
            {
                db.webDavUsername = "";
                db.webDavHost = "";
                db.webDavPass = "";

                db.Save(dbPath);
                this.Close();
            }
        }

        #endregion

        private void Window_DeleteEvent(object o, DeleteEventArgs args)
        {
            this.Close();
        }
    }
}
