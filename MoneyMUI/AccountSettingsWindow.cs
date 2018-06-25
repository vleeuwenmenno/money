using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Timers;
using Gtk;
using Money;
using Newtonsoft.Json;
using UI = Gtk.Builder.ObjectAttribute;

namespace MoneyUUI
{    
    class AccountSettingsWindow : Window
    {
        public Database db;
        public string dbPath;
        public int ac;
        public Window parent;
        public bool editMode = false;

        List<KeyValuePair<string, string>> history;

        [UI] private Button cancelBtn = null;
        [UI] private Button acceptBtn = null;
        [UI] private Button deleteAccountBtn = null;

        [UI] private Entry accountNameEntry = null;
        [UI] private Entry accountNumberEntry = null;
        [UI] private Entry accountInitialBalanceEntry = null;

        [UI] private ComboBox accountTypeCombo = null;
        [UI] private ComboBox accountCurrencyCombo = null;

        [UI] private Label addAccountLabel = null;

        [UI] private ProgressBar currencyLoaderBar = null;

        public AccountSettingsWindow(Database db, string dbPath, Window parent) : this(new Builder("AccountSettingsWindow.glade")) 
        {
            this.db = db;
            this.dbPath = dbPath;
            this.parent = parent;

            this.Resize(680, 320);
            SetupUI(false);
        }

        public AccountSettingsWindow(Database db, string dbPath, int account, Window parent) : this(new Builder("AccountSettingsWindow.glade")) 
        {
            this.db = db;
            this.dbPath = dbPath;
            this.parent = parent;
            this.ac = account;

            this.Title = "Edit Account";

            accountNameEntry.Text = db.accounts[account].accountName;
            accountNumberEntry.Text = db.accounts[account].accountNumber;

            accountInitialBalanceEntry.Text = db.accounts[account].initialBalance.ToString();
            accountInitialBalanceEntry.Sensitive = false;

            //TODO: Currency & type initialization            

            this.Resize(680, 320);
            SetupUI(true);
        }

        private void cancelBtn_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private AccountSettingsWindow(Builder builder) : base(builder.GetObject("AccountSettingsWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;

            cancelBtn.Clicked += cancelBtn_Clicked;
            acceptBtn.Clicked += AcceptBtn_Clicked;
            deleteAccountBtn.Clicked += DeleteAccountBtn_Clicked;
        }

        private void DeleteAccountBtn_Clicked(object sender, EventArgs e)
        {
            string msg = "Are you sure you want to remove this account?? All transactions associated with this account will be deleted as well! (Excluding linked transactions)";
            MessageDialog msgdiag = new MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.YesNo, false, msg);
            ResponseType resp = (ResponseType)msgdiag.Run();
            msgdiag.Destroy();

            if (resp == ResponseType.Yes)
            {
                db.accounts.RemoveAt(ac);
                db.Save(dbPath);

                ((DatabaseOverviewWindow)parent).updateUi = true;
                this.Close();
            }
        }

        private void AcceptBtn_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(accountNameEntry.Text))
            {
                string msg = "Cannot add account without account number! Please fill the account number input.";
                MessageDialog msgdiag = new MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, false, msg);
                ResponseType resp = (ResponseType)msgdiag.Run();
                msgdiag.Destroy();
                return;
            }

            
            foreach (Account ac in db.accounts)
            {
                if (!editMode)
                {
                    if (ac.accountNumber == accountNumberEntry.Text)
                    {
                        string msg = "There is already an account added with this account number! Make sure the account number is unique.";
                        MessageDialog msgdiag = new MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, false, msg);
                        ResponseType resp = (ResponseType)msgdiag.Run();
                        msgdiag.Destroy();
                        return;
                    }
                }
                else
                {
                    if (db.accounts[this.ac].accountNumber != accountNumberEntry.Text && ac.accountNumber == accountNumberEntry.Text)
                    {
                        string msg = "There is already an account added with this account number! Make sure the account number is unique.";
                        MessageDialog msgdiag = new MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, false, msg);
                        ResponseType resp = (ResponseType)msgdiag.Run();
                        msgdiag.Destroy();
                        return;
                    }
                }
            }

            if (editMode)
            {
                db.accounts[ac].accountName = accountNameEntry.Text;
                db.accounts[ac].accountNumber = accountNumberEntry.Text;

                bool initialBalanceOK = decimal.TryParse(accountInitialBalanceEntry.Text, out decimal initialBalance);

                if (initialBalanceOK)
                {
                    db.accounts[ac].initialBalance = initialBalance;
                }
                else
                {
                    MessageDialog msgdiag = new MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, false, "Invalid initial balance entered, please check the entered value.");
                    ResponseType resp = (ResponseType)msgdiag.Run();
                    msgdiag.Destroy();
                    return;
                }                

                TreeIter tree;
                accountCurrencyCombo.GetActiveIter(out tree);
                String selectedText = (String)accountCurrencyCombo.Model.GetValue(tree, 0);

                TreeIter treeTwo;
                accountTypeCombo.GetActiveIter(out tree);
                String selectedTextTwo = (String)accountTypeCombo.Model.GetValue(tree, 0);

                db.accounts[ac].currencyISO4217 = selectedText;
                db.accounts[ac].type = selectedTextTwo.ToLower();

                db.Save(dbPath);
                this.Close();
            }
            else
            {
                Account ac = new Account();

                ac.accountName = accountNameEntry.Text;
                ac.accountNumber = accountNumberEntry.Text;

                bool initialBalanceOK = decimal.TryParse(accountInitialBalanceEntry.Text, out decimal initialBalance);

                if (initialBalanceOK)
                {
                    ac.initialBalance = initialBalance;
                }
                else
                {
                    MessageDialog msgdiag = new MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, false, "Invalid initial balance entered, please check the entered value.");
                    ResponseType resp = (ResponseType)msgdiag.Run();
                    msgdiag.Destroy();
                    return;
                }

                TreeIter tree;
                accountCurrencyCombo.GetActiveIter(out tree);
                String selectedText = (String)accountCurrencyCombo.Model.GetValue(tree, 0);

                TreeIter treeTwo;
                accountTypeCombo.GetActiveIter(out tree);
                String selectedTextTwo = (String)accountTypeCombo.Model.GetValue(tree, 0);

                ac.currencyISO4217 = selectedText;
                ac.type = selectedTextTwo.ToLower();

                db.accounts.Add(ac);
                db.Save(dbPath);
                this.Close();
            }

            ((DatabaseOverviewWindow)parent).updateUi = true;
        }

        public void SetupUI(bool editMode)
        {
            this.editMode = editMode;

            if(editMode)
                addAccountLabel.Text = "Edit your existing account";

            currencyLoaderBar.Visible = true;

            System.Timers.Timer ti = new System.Timers.Timer(200);
            ti.Elapsed += (delegate {
                currencyLoaderBar.Pulse();
            });
            ti.Start();

            cancelBtn.Sensitive = false;
            acceptBtn.Sensitive = false;

            accountNameEntry.Sensitive = false;
            accountNumberEntry.Sensitive = false;
            accountInitialBalanceEntry.Sensitive = false;

            accountTypeCombo.Sensitive = false;
            accountCurrencyCombo.Sensitive = false;

            addAccountLabel.Sensitive = false;

            Thread t = new Thread(delegate () {

                //Let's gather the exchange rate
                List<string> currencies = Tools.ExchangeRateSnapshot().Keys.ToList();
                currencies.Sort();

                //Let's add the currencies list to the combobox
                ListStore curencyDataSource = new ListStore(typeof(string));

                foreach (string s in currencies)
                    curencyDataSource.AppendValues(s);

                accountCurrencyCombo.Clear();
                CellRendererText text = new Gtk.CellRendererText();
                accountCurrencyCombo.Model = curencyDataSource;
                accountCurrencyCombo.PackStart(text, false);
                accountCurrencyCombo.AddAttribute(text, "text", 0);

                //Lets add the types for account to the combobox
                ListStore typeDataStore = new ListStore(typeof(string));

                String[] paths = { };
                List<string> types = new List<string>();
                paths = Directory.GetFiles(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/icons");

                foreach (String path in paths)
                {
                    types.Add(Tools.FirstCharToUpper(System.IO.Path.GetFileNameWithoutExtension(path)));
                    typeDataStore.AppendValues(Tools.FirstCharToUpper(System.IO.Path.GetFileNameWithoutExtension(path)));
                }

                accountTypeCombo.Clear();
                CellRendererText texts = new Gtk.CellRendererText();
                accountTypeCombo.Model = typeDataStore;
                accountTypeCombo.PackStart(texts, false);
                accountTypeCombo.AddAttribute(texts, "text", 0);

                if (editMode)
                {
                    int row = types.IndexOf(Tools.FirstCharToUpper(db.accounts[ac].type));
                    TreeIter iter;
                    accountTypeCombo.Model.IterNthChild(out iter, row);
                    accountTypeCombo.SetActiveIter(iter);

                    int rows = currencies.IndexOf(db.accounts[ac].currencyISO4217);
                    TreeIter iters;
                    accountCurrencyCombo.Model.IterNthChild(out iters, rows);
                    accountCurrencyCombo.SetActiveIter(iters);
                }

                //Enable all controls
                cancelBtn.Sensitive = true;
                acceptBtn.Sensitive = true;

                accountNameEntry.Sensitive = true;
                accountNumberEntry.Sensitive = true;

                if(!editMode)
                    accountInitialBalanceEntry.Sensitive = true;

                accountTypeCombo.Sensitive = true;
                accountCurrencyCombo.Sensitive = true;

                addAccountLabel.Sensitive = true;
                currencyLoaderBar.Visible = false;

                if (editMode)
                    deleteAccountBtn.Visible = true;

                //Stop animator for progressbar
                ti.Stop();
            });
            t.Start();
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            parent.Show();
            this.Close();
        }
    }
}
