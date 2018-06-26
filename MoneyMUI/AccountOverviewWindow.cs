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
    class AccountOverviewWindow : Window
    {
        public Database db;
        public string dbPath;
        public int ac;
        public DatabaseOverviewWindow parent;

        public bool updateUi = false;

        [UI] private Label windowTitleBigLabel = null;
        [UI] private Label accountNumberLabel = null;
        [UI] private Label accountBalanceLabel = null;
        [UI] private Label endBalanceDateLabel = null;
        [UI] private Label endBalanceLabel = null;

        [UI] private TreeView transactionList = null;
        [UI] private TreeView scheduledTransactionList = null;

        [UI] private ListStore transactionListStore = null;
        [UI] private ListStore scheduledTransactionListStore = null;

        [UI] private Button addTransactionBtn = null;
        [UI] private Button addSchTransactionBtn = null;

        public AccountOverviewWindow(Database db, string dbPath, int account, DatabaseOverviewWindow parent) : this(new Builder("AccountOverviewWindow.glade")) 
        {
            this.db = db;
            this.dbPath = dbPath;
            this.parent = parent;
            this.ac = account;

            parent.GetSize(out int w, out int h);
            this.Resize(800, h);

            PrepareTransactionList();
            PrepareScheduledTransactionList();

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
        }

        public void PrepareScheduledTransactionList()
        {
            // Create a column for the artist name
            TreeViewColumn trDesc = new TreeViewColumn();
            trDesc.Title = "Description";
            trDesc.Expand = true;

            TreeViewColumn trDate = new TreeViewColumn();
            trDate.Title = "Start Date";

            TreeViewColumn trRepeat = new TreeViewColumn();
            trRepeat.Title = "Repeat";

            TreeViewColumn trPayee = new TreeViewColumn();
            trPayee.Title = "Payee";
            trPayee.Expand = true;

            TreeViewColumn trAmount = new TreeViewColumn();
            trAmount.Title = "Amount";

            // Add the columns to the TreeView
            scheduledTransactionList.AppendColumn(trDesc);
            scheduledTransactionList.AppendColumn(trDate);
            scheduledTransactionList.AppendColumn(trRepeat);
            scheduledTransactionList.AppendColumn(trPayee);
            scheduledTransactionList.AppendColumn(trAmount);

            // Create the text cell that will display the artist name
            CellRendererText trDescCell = new CellRendererText();
            trDesc.PackStart(trDescCell, true);

            CellRendererText trDateCell = new CellRendererText();
            trDate.PackStart(trDateCell, true);

            CellRendererText trRepeatCell = new CellRendererText();
            trRepeat.PackStart(trRepeatCell, true);

            CellRendererText trPayeeCell = new CellRendererText();
            trPayee.PackStart(trPayeeCell, true);

            CellRendererText trAmountCell = new CellRendererText();
            trAmount.PackStart(trAmountCell, true);

            // Tell the Cell Renderers which items in the model to display
            trDesc.AddAttribute(trDescCell, "text", 0);
            trDate.AddAttribute(trDateCell, "text", 1);
            trRepeat.AddAttribute(trRepeatCell, "text", 2);
            trPayee.AddAttribute(trPayeeCell, "text", 3);
            trAmount.AddAttribute(trAmountCell, "text", 4);
        }

        public void PrepareTransactionList()
        {
            // Create a column for the artist name
            TreeViewColumn trStatus = new TreeViewColumn();
            trStatus.Title = "Status";
            trStatus.FixedWidth = 100;

            TreeViewColumn trDesc = new TreeViewColumn();
            trDesc.Title = "Description";
            trDesc.Expand = true;

            TreeViewColumn trDate = new TreeViewColumn();
            trDate.Title = "Date";

            TreeViewColumn trPayee = new TreeViewColumn();
            trPayee.Title = "Payee";
            trPayee.Expand = true;

            TreeViewColumn trAmount = new TreeViewColumn();
            trAmount.Title = "Amount";
            trAmount.MinWidth = 128;

            // Add the columns to the TreeView
            transactionList.AppendColumn(trStatus);
            transactionList.AppendColumn(trDesc);
            transactionList.AppendColumn(trDate);
            transactionList.AppendColumn(trPayee);
            transactionList.AppendColumn(trAmount);

            // Create the text cell that will display the artist name
            CellRendererText trStatusCell = new CellRendererText();
            trStatus.PackStart(trStatusCell, true);

            CellRendererText trDescCell = new CellRendererText();
            trDesc.PackStart(trDescCell, true);

            CellRendererText trDateCell = new CellRendererText();
            trDate.PackStart(trDateCell, true);

            CellRendererText trPayeeCell = new CellRendererText();
            trPayee.PackStart(trPayeeCell, true);

            CellRendererText trAmountCell = new CellRendererText();
            trAmount.PackStart(trAmountCell, true);

            // Tell the Cell Renderers which items in the model to display
            trStatus.AddAttribute(trStatusCell, "text", 0);
            trDesc.AddAttribute(trDescCell, "text", 1);
            trDate.AddAttribute(trDateCell, "text", 2);
            trPayee.AddAttribute(trPayeeCell, "text", 3);
            trAmount.AddAttribute(trAmountCell, "text", 4);
        }

        private void UpdateUI()
        {
            //Update labels
            windowTitleBigLabel.Text = db.accounts[ac].accountName;
            accountBalanceLabel.Text = db.accounts[ac].currencyISO4217 + " " + Convert.ToDecimal(db.accounts[ac].currentBalance).ToString("#,##0.00");

            if (Tools.GetCardType(db.accounts[ac].accountNumber.Trim().Replace("-", "")) != CardType.Unknown)
            {
                accountNumberLabel.Text = (Creditcard.MaskDigits(db.accounts[ac].accountNumber));
            }
            else
                accountNumberLabel.Text = (db.accounts[ac].accountNumber);

            //Update transactions list
            transactionListStore.Clear();
            if (db.accounts[ac].transactions != null)
                foreach (Transaction t in db.accounts[ac].transactions)
                {
                    if (t.dateTime.Year == parent.monthToDisplay.Year)
                        if (t.dateTime.Month == parent.monthToDisplay.Month)
                        {
                            string amount = "";
                            if (t.currencyISO4217 != db.accounts[ac].currencyISO4217)
                                amount = (db.accounts[ac].currencyISO4217 + " " + Math.Round(Tools.ConvertCurrency(t.exchangeSnapshot, t.currencyISO4217, db.accounts[ac].currencyISO4217, t.amount), 2) + "(" + t.currencyISO4217 + " " + String.Format("{0:n}", t.amount) + ")"); //amount
                            else
                                amount = (t.currencyISO4217 + " " + String.Format("{0:n}", t.amount)); //amount

                            transactionListStore.AppendValues(t.status.ToString(),
                                t.desc,
                                t.dateTime.ToString("dd-MM-yyyy"),
                                t.payee, 
                                amount,
                                t.id.ToString());
                        }
                }
        }

        private AccountOverviewWindow(Builder builder) : base(builder.GetObject("AccountOverviewWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            transactionList.ButtonPressEvent += new ButtonPressEventHandler(transactionList_ButtonPress);
        }

        [GLib.ConnectBeforeAttribute]
        private void transactionList_ButtonPress(object o, ButtonPressEventArgs e)
        {
            if (e.Event.Button == 3)
            {
                Gtk.TreeIter selected;
                if (transactionList.Selection.GetSelected(out selected))
                {
                    string transactionStatus = (string)transactionListStore.GetValue(selected, 0);
                    Guid transactionGuid = Guid.Parse((string)transactionListStore.GetValue(selected, 5));

                    Menu m = new Menu();

                    MenuItem executeItem = new MenuItem("Execute");
                    executeItem.ButtonPressEvent += new ButtonPressEventHandler(delegate (object sender, ButtonPressEventArgs ee)
                    {
                        for (int i = 0; i < db.accounts[ac].transactions.Count; i++)
                        {
                            Transaction t = db.accounts[ac].transactions[i];
                            if (t.id == transactionGuid)
                            {
                                t.status = TransactionStatus.Completed;

                                if (t.intern != Guid.Empty)
                                {
                                    int account = 0;
                                    Transaction internT = null;
                                    foreach (Account a in db.accounts)
                                    {
                                        if (a.GetTransaction(t.intern) != null)
                                        {
                                            internT = a.GetTransaction(t.intern);
                                            break;
                                        }
                                        account++;
                                    }
                                    internT.status = TransactionStatus.Completed;
                                }

                                foreach (Account ac in db.accounts)
                                    ac.RecalculateBalance();

                                UpdateUI();
                                parent.updateUi = true;
                                db.Save(dbPath);
                                return;
                            }
                        }
                    });

                    MenuItem skipItem = new MenuItem("Skip");
                    skipItem.ButtonPressEvent += new ButtonPressEventHandler(delegate (object sender, ButtonPressEventArgs ee)
                    {
                        for (int i = 0; i < db.accounts[ac].transactions.Count; i++)
                        {
                            Transaction t = db.accounts[ac].transactions[i];
                            if (t.id == transactionGuid)
                            {
                                t.status = TransactionStatus.Skipped;

                                if (t.intern != Guid.Empty)
                                {
                                    int account = 0;
                                    Transaction internT = null;
                                    foreach (Account a in db.accounts)
                                    {
                                        if (a.GetTransaction(t.intern) != null)
                                        {
                                            internT = a.GetTransaction(t.intern);
                                            break;
                                        }
                                        account++;
                                    }
                                    internT.status = TransactionStatus.Skipped;
                                }

                                foreach (Account ac in db.accounts)
                                    ac.RecalculateBalance();

                                UpdateUI();
                                parent.updateUi = true;
                                db.Save(dbPath);
                                return;
                            }
                        }
                    });

                    SeparatorMenuItem s = new SeparatorMenuItem();

                    MenuItem editItem = new MenuItem("Edit");
                    editItem.ButtonPressEvent += new ButtonPressEventHandler(delegate (object sender, ButtonPressEventArgs ee)
                    {
                        //TODO: Make this work
                    });

                    MenuItem deleteItem = new MenuItem("Delete");
                    deleteItem.ButtonPressEvent += new ButtonPressEventHandler(delegate (object sender, ButtonPressEventArgs ee)
                    {
                        string msg = "Are you sure you want to delete this transaction?";
                        MessageDialog msgdiag = new MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.YesNo, false, msg);
                        ResponseType r = (ResponseType)msgdiag.Run();
                        msgdiag.Destroy();

                        if (r == ResponseType.Yes)
                        {
                            for (int i = 0; i < db.accounts[ac].transactions.Count; i++)
                            {
                                Transaction t = db.accounts[ac].transactions[i];
                                if (t.id == transactionGuid)
                                {
                                    if (t.intern != Guid.Empty)
                                    {
                                        msg = "The payee in this transaction is internal, do you want to delete the payee transaction too?";
                                        msgdiag = new MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.YesNo, false, msg);
                                        r = (ResponseType)msgdiag.Run();
                                        msgdiag.Destroy();

                                        if (r == ResponseType.Yes)
                                        {
                                            int account = 0;
                                            Transaction internT = null;
                                            foreach (Account a in db.accounts)
                                            {
                                                if (a.GetTransaction(t.intern) != null)
                                                {
                                                    internT = a.GetTransaction(t.intern);
                                                    break;
                                                }
                                                account++;
                                            }

                                            if (internT != null)
                                                db.accounts[account].transactions.Remove(internT);
                                            else
                                            {
                                                msg = "Linked transaction could not be found, it's probably already gone.";
                                                msgdiag = new MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.YesNo, false, msg);
                                                r = (ResponseType)msgdiag.Run();
                                                msgdiag.Destroy();
                                            }
                                        }
                                        else if (r == ResponseType.No)
                                        {
                                            int account = 0;
                                            Transaction internT = null;
                                            foreach (Account a in db.accounts)
                                            {
                                                if (a.GetTransaction(t.intern) != null)
                                                {
                                                    internT = a.GetTransaction(t.intern);
                                                    break;
                                                }
                                                account++;
                                            }
                                            internT.intern = Guid.Empty;
                                        }
                                    }

                                    db.accounts[ac].transactions.Remove(t);

                                    foreach (Account ac in db.accounts)
                                        ac.RecalculateBalance();

                                    UpdateUI();
                                    parent.updateUi = true;
                                    db.Save(dbPath);
                                    return;
                                }
                            }
                        }
                    });

                    executeItem.Sensitive = false;
                    skipItem.Sensitive = false;

                    if (transactionStatus == "OnHold")
                        executeItem.Sensitive = true;
                    else
                        executeItem.Sensitive = false;

                    if (transactionStatus == "Scheduled")
                    {
                        executeItem.Sensitive = true;
                        skipItem.Sensitive = true;
                    }
                    else
                        skipItem.Sensitive = false;

                    m.Add(executeItem);
                    m.Add(skipItem);
                    m.Add(s);
                    m.Add(editItem);
                    m.Add(deleteItem);

                    m.ShowAll();
                    m.Popup();
                }
            }
            else if (((Gdk.EventButton)e.Event).Type == Gdk.EventType.TwoButtonPress)
            {
                
            }
        }


        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        { }
    }
}
