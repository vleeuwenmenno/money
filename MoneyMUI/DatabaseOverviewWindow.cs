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
    class DatabaseOverviewWindow : Window
    {
        public Database db;

        public string dbPath;

        public DateTime monthToDisplay = DateTime.Now;

        //TODO: public accountOverview ao;

        [UI] private TreeView accountList = null;
        [UI] private ListStore accountListStore = null;

        [UI] private Button monthBackwardBtn = null;
        [UI] private Button monthForwardBtn = null;
        [UI] private Button addAccountBtn = null;
        [UI] private Button syncBtn = null;
        [UI] private Button settingsBtn = null;

        [UI] private Label currentMonthLabel = null;

        [UI] private ProgressBar syncProgressBar = null;

        public DatabaseOverviewWindow(Database db, string dbPath) : this(new Builder("DatabaseOverviewWindow.glade")) 
        { 
            this.db = db;
            this.dbPath = dbPath;

            if (db.syncWebDav)
                syncBtn.Visible = true;

            UpdateUI();
        }

        private DatabaseOverviewWindow(Builder builder) : base(builder.GetObject("DatabaseOverviewWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;

            monthBackwardBtn.Clicked += monthBackwardBtn_Clicked;
            monthForwardBtn.Clicked += monthForwardBtn_Clicked;
            settingsBtn.Clicked += settingsBtn_Clicked;
            syncBtn.Clicked += syncBtn_Clicked;
            addAccountBtn.Clicked += addAccountBtn_Clicked;
            accountList.ButtonPressEvent += new ButtonPressEventHandler(accountList_ButtonPress);

            PrepareTreeView();
            this.Resize(300, 500);
            accountListStore.AppendValues("", "");
        }

         [GLib.ConnectBeforeAttribute]
        private void accountList_ButtonPress(object o, ButtonPressEventArgs e)
        {
            if (e.Event.Button == 3)
            {
                Menu m = new Menu();
                MenuItem deleteItem = new MenuItem("Edit");
                deleteItem.ButtonPressEvent += new ButtonPressEventHandler(accountList_EditBtnPress);
                m.Add(deleteItem);
                m.ShowAll();
                m.Popup();
            }
            else if(((Gdk.EventButton)e.Event).Type == Gdk.EventType.ButtonPress)
            {
                Gtk.TreeIter selected;
                if (accountList.Selection.GetSelected(out selected)) {
                    int account = (int)accountListStore.GetValue(selected, 2);
                    
                }
            }
        }

        private void accountList_EditBtnPress(object o, ButtonPressEventArgs args)
        {
            Gtk.TreeIter selected;
            if (accountList.Selection.GetSelected(out selected)) {
                int account = (int)accountListStore.GetValue(selected, 2);
                AccountSettingsWindow asw = new AccountSettingsWindow(db, dbPath, account, this);
                asw.Show();
            }
        }

        private void addAccountBtn_Clicked(object sender, EventArgs e)
        {
            AccountSettingsWindow asw = new AccountSettingsWindow(db, dbPath, 0, this);
            asw.Show();
        }

        private void syncBtn_Clicked(object sender, EventArgs e)
        {
            runSync();
        }

        public void runSync()
        {
            syncProgressBar.Visible = true;
            syncProgressBar.PulseStep = 0.1;
            syncProgressBar.Pulse();

            IWebDavClient _client = new WebDavClient();
            var clientParams = new WebDavClientParams
            {
                BaseAddress = new Uri(db.webDavHost),
                Credentials = new NetworkCredential(db.webDavUsername, db.webDavPass)
            };
            _client = new WebDavClient(clientParams);

            Thread t = new Thread(async () => {

                Gtk.Application.Invoke(delegate {
                    syncProgressBar.Pulse();
                });

                var result = await _client.Propfind(db.webDavHost + "/Money");
                if (result.IsSuccessful)
                {
                    Gtk.Application.Invoke(delegate {
                        syncProgressBar.Pulse();
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
                            syncProgressBar.Pulse();
                        });

                        //Let's grab the online version
                        var resultInner = await _client.GetRawFile(db.webDavHost + "/Money/database.mdb");

                        StreamReader reader = new StreamReader(resultInner.Stream);
                        string json = reader.ReadToEnd();
                        Database oDb = JsonConvert.DeserializeObject<Database>(json);

                        //Check if modDateTime is newer than current database
                        //if so replace local with online
                        if (oDb.modDateTime != db.modDateTime)
                        {
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
                                    syncProgressBar.Pulse();
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
                        }
                        Gtk.Application.Invoke(delegate {
                            db.Save(dbPath);
                        });
                    }
                    else
                    {
                        Gtk.Application.Invoke(delegate {
                            syncProgressBar.Pulse();
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
                            });
                        }
                    }
                }
                else if (result.StatusCode == 404)
                {
                    Gtk.Application.Invoke(delegate {
                        syncProgressBar.Pulse();
                    });

                    var resultInner = await _client.Mkcol("Money");

                    if (resultInner.IsSuccessful)
                    {
                        resultInner = await _client.PutFile(db.webDavHost + "/Money/database.mdb", File.OpenRead(dbPath));

                        Gtk.Application.Invoke(delegate {
                            syncProgressBar.Pulse();
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
                    syncProgressBar.Pulse();
                    syncProgressBar.Visible = false;
                });
            });

            t.Start();
        }

        public void PrepareTreeView()
        {
            // Create a column
            Gtk.TreeViewColumn acName = new Gtk.TreeViewColumn ();
            acName.Title = "Account";
    
            // Create a column
            Gtk.TreeViewColumn acBalance = new Gtk.TreeViewColumn ();
            acBalance.Title = "Balance";
   
            accountList.AppendColumn (acName);
            accountList.AppendColumn (acBalance);

            // Create the text cell that will display the artist name
            CellRendererText acNameCell = new CellRendererText ();
            acName.PackStart (acNameCell, true);
            
            // Do the same for the song title column
            CellRendererText acBalanceCell = new CellRendererText ();
            acBalance.PackStart (acBalanceCell, true);

            // Tell the Cell Renderers which items in the model to display
            acName.AddAttribute (acNameCell, "text", 0);
            acBalance.AddAttribute (acBalanceCell, "text", 1);
        }

        public void UpdateUI()
        {
            //Update month selector label
            currentMonthLabel.Text = monthToDisplay.ToString("MMMM yyyy");

            //Set the database name as the window title
            this.Title = db.name;

            //Update the account list
            this.accountListStore = new ListStore(typeof(string), typeof(string), typeof(int));
            this.accountList.Model = this.accountListStore;

            for (int i = 0; i < db.accounts.Count; i++)
            {
                Account ac = db.accounts[i];
                string s = ac.accountName + Environment.NewLine;

                if (Tools.GetCardType(ac.accountNumber.Trim().Replace("-", "")) != CardType.Unknown)
                    s += (Creditcard.MaskDigits(ac.accountNumber));
                else
                    s += (ac.accountNumber);

                this.accountListStore.AppendValues(s, ac.currencyISO4217 + " " + String.Format("{0:n}", ac.currentBalance), i);
            }
        }

        #region Click events

        private void settingsBtn_Clicked(object sender, EventArgs e)
        {
            DatabaseSettingsWindow swi = new DatabaseSettingsWindow(db, dbPath);
            swi.Show();
        }

        private void monthForwardBtn_Clicked(object sender, EventArgs e)
        {
            monthToDisplay = monthToDisplay.AddMonths(1);
            UpdateUI();
        }

        private void monthBackwardBtn_Clicked(object sender, EventArgs e)
        {
            monthToDisplay = monthToDisplay.AddMonths(-1);
            UpdateUI();
        }

        #endregion

        private void Window_DeleteEvent(object o, DeleteEventArgs args)
        {
            Application.Quit();
        }
    }
}
