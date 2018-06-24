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

        public DatabaseOverviewWindow(Database db, string dbPath) : this(new Builder("DatabaseOverviewWindow.glade")) 
        { 
            this.db = db;
            this.dbPath = dbPath;

            UpdateUI();
        }

        private DatabaseOverviewWindow(Builder builder) : base(builder.GetObject("DatabaseOverviewWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;

            monthBackwardBtn.Clicked += monthBackwardBtn_Clicked;
            monthForwardBtn.Clicked += monthForwardBtn_Clicked;

            PrepareTreeView();
            this.Resize(300, 500);
            accountListStore.AppendValues("", "");
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
            this.accountListStore = new ListStore(typeof(string), typeof(string));
            this.accountList.Model = this.accountListStore;

            for (int i = 0; i < db.accounts.Count; i++)
            {
                Account ac = db.accounts[i];
                string s = ac.accountName + Environment.NewLine;

                if (Tools.GetCardType(ac.accountNumber.Trim().Replace("-", "")) != CardType.Unknown)
                    s += (Creditcard.MaskDigits(ac.accountNumber));
                else
                    s += (ac.accountNumber);

                this.accountListStore.AppendValues(s, ac.currencyISO4217 + " " + String.Format("{0:n}", ac.currentBalance));
            }
        }

        #region Click events

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
