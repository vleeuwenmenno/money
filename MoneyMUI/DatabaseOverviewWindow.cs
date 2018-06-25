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

        public bool updateUi = false;

        private AccountOverviewWindow aow;

        [UI] private TreeView accountList = null;
        [UI] private ListStore accountListStore = null;

        [UI] private Button addAccountBtn = null;
        [UI] private Button syncBtn = null;
        [UI] private Button settingsBtn = null;
        [UI] private Button monthBackwardPopOverBtn = null;
        [UI] private Button monthForwardPopOverBtn = null;

        [UI] private Label currentDatePopOverLabel = null;

        [UI] private Button currentMonthLabel = null;

        [UI] private ProgressBar syncProgressBar = null;

        [UI] private PopoverMenu datePickerPopOver = null;

        [UI] private Box datePickerBox = null;

        public DatabaseOverviewWindow(Database db, string dbPath) : this(new Builder("DatabaseOverviewWindow.glade")) 
        { 
            this.db = db;
            this.dbPath = dbPath;

            if (db.syncWebDav)
                syncBtn.Visible = true;

            UpdateUI();

            System.Timers.Timer uiUpdateCheck = new System.Timers.Timer(200);
            uiUpdateCheck.Elapsed += (delegate {
                if (updateUi)
                {
                    updateUi = false;
                    UpdateUI();
                }
            });
            uiUpdateCheck.Start();

            aow = new AccountOverviewWindow(db, dbPath, 0, this);
            aow.Show();

            this.SetPosition(WindowPosition.Center);
        }

        private DatabaseOverviewWindow(Builder builder) : base(builder.GetObject("DatabaseOverviewWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;

            settingsBtn.Clicked += settingsBtn_Clicked;
            syncBtn.Clicked += syncBtn_Clicked;
            addAccountBtn.Clicked += addAccountBtn_Clicked;
            accountList.ButtonPressEvent += new ButtonPressEventHandler(accountList_ButtonPress);
            currentMonthLabel.Clicked += CurrentMonthLabel_Clicked;
            monthForwardPopOverBtn.Clicked += MonthForwardPopOverBtn_Clicked;
            monthBackwardPopOverBtn.Clicked += MonthBackwardPopOverBtn_Clicked;

            PrepareTreeView();
            this.Resize(396, 512);
            accountListStore.AppendValues("", "");
        }

        private void MonthBackwardPopOverBtn_Clicked(object sender, EventArgs e)
        {
            monthToDisplay = monthToDisplay.AddMonths(-1);
            DateTime t = monthToDisplay;
            DateTime l = new DateTime(t.Year, t.Month, 1);

            updateUi = true;
            aow.updateUi = true;
            currentDatePopOverLabel.Text = monthToDisplay.ToString("dd MMM yyyy");

            UpdatePopOver(l);
        }

        private void MonthForwardPopOverBtn_Clicked(object sender, EventArgs e)
        {
            monthToDisplay = monthToDisplay.AddMonths(1);
            DateTime t = monthToDisplay;
            DateTime l = new DateTime(t.Year, t.Month, 1);

            updateUi = true;
            aow.updateUi = true;
            currentDatePopOverLabel.Text = monthToDisplay.ToString("dd MMM yyyy");

            UpdatePopOver(l);
        }

        private void CurrentMonthLabel_Clicked(object sender, EventArgs e)
        {
            DateTime t = monthToDisplay;
            DateTime l = new DateTime(t.Year, t.Month, 1);

            currentDatePopOverLabel.Text = monthToDisplay.ToString("dd MMM yyyy");

            datePickerBox.SetSizeRequest(128, 128);
            UpdatePopOver(l);

            datePickerPopOver.ShowAll();
            datePickerPopOver.Popup();
        }

        private void UpdatePopOver(DateTime l)
        {
            while (true)
            {
                if (l.DayOfWeek != DayOfWeek.Monday)
                    l = l.AddDays(-1);
                else
                    break;
            }

            foreach (Widget w in datePickerBox.AllChildren)
                w.Destroy();

            for (int r = 0; r < 6; r++)
            {
                Box b = new Box(Orientation.Horizontal, 0);
                b.Expand = true;
                for (int c = 0; c < 7; c++)
                {
                    Button button = new Button();
                    button.Label = l.Day.ToString();

                    if (new DateTime(l.Year, l.Month, 1) != new DateTime(monthToDisplay.Year, monthToDisplay.Month, 1))
                        button.Sensitive = false;

                    button.Clicked += (delegate (object o, EventArgs ee) {
                        monthToDisplay = new DateTime(monthToDisplay.Year, monthToDisplay.Month, int.Parse(((Button)o).Label));
                        currentDatePopOverLabel.Text = monthToDisplay.ToString("dd MMM yyyy");
                    });

                    b.Add(button);
                    l = l.AddDays(1);
                }

                datePickerBox.Add(b);
            }

            datePickerPopOver.ShowAll();
            datePickerPopOver.Popup();
        }

        [GLib.ConnectBeforeAttribute]
        private void accountList_ButtonPress(object o, ButtonPressEventArgs e)
        {
            if (e.Event.Button == 3)
            {
                Menu m = new Menu();

                MenuItem openItem = new MenuItem("Open");
                openItem.ButtonPressEvent += new ButtonPressEventHandler(delegate (object oo, ButtonPressEventArgs args) {
                    Gtk.TreeIter selected;
                    if (accountList.Selection.GetSelected(out selected))
                    {
                        int account = (int)accountListStore.GetValue(selected, 2);
                        aow.ac = account;
                        aow.updateUi = true;
                    }
                });

                MenuItem editItem = new MenuItem("Edit");
                editItem.ButtonPressEvent += new ButtonPressEventHandler(accountList_EditBtnPress);

                m.Add(openItem);
                m.Add(editItem);
                m.ShowAll();
                m.Popup();
            }
            else if(((Gdk.EventButton)e.Event).Type == Gdk.EventType.DoubleButtonPress)
            {
                Gtk.TreeIter selected;
                if (accountList.Selection.GetSelected(out selected)) {
                    int account = (int)accountListStore.GetValue(selected, 2);
                    aow.ac = account;
                    aow.updateUi = true;
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

        public void runSync()
        {
            syncProgressBar.Visible = true;

            IWebDavClient _client = new WebDavClient();
            var clientParams = new WebDavClientParams
            {
                BaseAddress = new Uri(db.webDavHost),
                Credentials = new NetworkCredential(db.webDavUsername, db.webDavPass)
            };
            _client = new WebDavClient(clientParams);

            Thread t = new Thread(async () => {

                System.Timers.Timer ti = new System.Timers.Timer(200);
                ti.Elapsed += (delegate {
                    syncProgressBar.Pulse();
                });
                ti.Start();

                var result = await _client.Propfind(db.webDavHost + "/Money");
                if (result.IsSuccessful)
                {
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
                    var resultInner = await _client.Mkcol("Money");

                    if (resultInner.IsSuccessful)
                    {
                        resultInner = await _client.PutFile(db.webDavHost + "/Money/database.mdb", File.OpenRead(dbPath));
                        
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

                ti.Stop();

                Gtk.Application.Invoke(delegate {
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
            acName.Expand = true;
    
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
            currentMonthLabel.Label = monthToDisplay.ToString("MMMM yyyy");

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

                this.accountListStore.AppendValues(s, ac.currencyISO4217 + " " + Convert.ToDecimal(ac.currentBalance).ToString("#,##0.00"), i);
            }
        }

        #region Click events

        private void settingsBtn_Clicked(object sender, EventArgs e)
        {
            DatabaseSettingsWindow swi = new DatabaseSettingsWindow(db, dbPath);
            swi.Show();
        }

        private void addAccountBtn_Clicked(object sender, EventArgs e)
        {
            AccountSettingsWindow asw = new AccountSettingsWindow(db, dbPath, this);
            asw.Show();
        }

        private void syncBtn_Clicked(object sender, EventArgs e)
        {
            runSync();
        }

        #endregion

        private void Window_DeleteEvent(object o, DeleteEventArgs args)
        {
            Application.Quit();
        }
    }
}
