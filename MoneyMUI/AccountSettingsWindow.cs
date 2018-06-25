using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        List<KeyValuePair<string, string>> history;

        [UI] private Button cancelBtn = null;
        [UI] private Button acceptBtn = null;

        [UI] private Entry accountNameEntry = null;
        [UI] private Entry accountNumberEntry = null;
        [UI] private Entry accountInitialBalanceEntry = null;

        [UI] private ComboBox accountTypeCombo = null;
        [UI] private ComboBox accountCurrencyCombo = null;

        [UI] private Label addAccountLabel = null;

        public AccountSettingsWindow(Database db, string dbPath, int account, Window parent) : this(new Builder("AccountSettingsWindow.glade")) 
        {
            this.db = db;
            this.dbPath = dbPath;
            this.parent = parent;

            this.Title = "Edit Account";

            accountNameEntry.Text = db.accounts[account].accountName;
            accountNumberEntry.Text = db.accounts[account].accountNumber;

            accountInitialBalanceEntry.Text = db.accounts[account].initialBalance.ToString();
            accountInitialBalanceEntry.Sensitive = false;

            //TODO: Currency & type initialization

            this.Resize(680, 320);
        }

        private AccountSettingsWindow(Builder builder) : base(builder.GetObject("AccountSettingsWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            this.Close();
            parent.Show();
        }
    }
}
