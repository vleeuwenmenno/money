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
    class AddTransactionWindow : Dialog
    {
        public Database db;
        public string dbPath;
        public int ac;

        [UI] private PopoverMenu datePickerPopOver = null;

        [UI] private Label accountLabelI = null;
        [UI] private ComboBox currencyComboI = null;
        [UI] private Entry amountI = null;
        [UI] private Entry descI = null;
        [UI] private ComboBox catI = null;
        [UI] private Button catBtnI = null;
        [UI] private ComboBox payeeI = null;
        [UI] private Button payeeBtnI = null;
        [UI] private Button dateI = null;

        [UI] private Label accountLabelE = null;
        [UI] private ComboBox currencyComboE = null;
        [UI] private Entry amountE = null;
        [UI] private Entry descE = null;
        [UI] private ComboBox catE = null;
        [UI] private Button catBtnE = null;
        [UI] private ComboBox payeeE = null;
        [UI] private Button payeeBtnE = null;
        [UI] private Button dateE = null;

        [UI] private Button addBtn = null;
        [UI] private Button cancelBtn = null;

        [UI] private Notebook tabControl = null;

        [UI] private ProgressBar loaderProgress = null;

        private DateTime transactionDateI = DateTime.Now;
        private DateTime transactionDateE = DateTime.Now;


        public AddTransactionWindow(Database db, string dbPath, int account) : this(new Builder("AddTransactionWindow.glade"))
        {
            this.db = db;
            this.dbPath = dbPath;
            this.ac = account;

            this.Resize(256, 512);

            loaderProgress.Visible = true;
            tabControl.Sensitive = false;

            System.Timers.Timer ti = new System.Timers.Timer(200);
            ti.Elapsed += (delegate {
                loaderProgress.Pulse();
            });
            ti.Start();

            Thread loader = new Thread(delegate () {
                //Let's gather the exchange rate
                List<string> currencies = Tools.ExchangeRateSnapshot().Keys.ToList();
                currencies.Sort();

                //Let's add the currencies list to the combobox
                ListStore curencyDataSource = new ListStore(typeof(string));

                foreach (string s in currencies)
                    curencyDataSource.AppendValues(s);

                CellRendererText text = new Gtk.CellRendererText();

                //Add for expenses
                currencyComboE.Clear();
                currencyComboE.Model = curencyDataSource;
                currencyComboE.PackStart(text, false);
                currencyComboE.AddAttribute(text, "text", 0);

                //Add for incomes
                currencyComboI.Clear();
                currencyComboI.Model = curencyDataSource;
                currencyComboI.PackStart(text, false);
                currencyComboI.AddAttribute(text, "text", 0);

                //Select the default currency for both combos
                int rows = currencies.IndexOf(db.accounts[ac].currencyISO4217);
                TreeIter iters;

                currencyComboI.Model.IterNthChild(out iters, rows);
                currencyComboI.SetActiveIter(iters);

                currencyComboE.Model.IterNthChild(out iters, rows);
                currencyComboE.SetActiveIter(iters);

                //Setup UI
                accountLabelE.Text = db.accounts[ac].accountName;
                accountLabelI.Text = db.accounts[ac].accountName;

                //Enable the UI and hide the loader
                loaderProgress.Visible = false;
                tabControl.Sensitive = true;
                ti.Stop();
            });
            loader.Start();
        }

        private AddTransactionWindow(Builder builder) : base(builder.GetObject("addTransactionWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            cancelBtn.Clicked += CancelBtn_Clicked;
            addBtn.Clicked += AddBtn_Clicked;

            payeeBtnE.Clicked += payeeBtn_Clicked;
            payeeBtnI.Clicked += payeeBtn_Clicked;
        }

        private void payeeBtn_Clicked(object sender, EventArgs e)
        {
            this.Sensitive = false;
            ManagePayeeWindow mpw = new ManagePayeeWindow(db, dbPath, ac);
            mpw.TransientFor = this;
            mpw.Run();

            mpw.Destroy();
            mpw = null;

            this.Sensitive = true;
        }

        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            Transaction t = new Transaction();

            t.id = Guid.NewGuid();
            t.exchangeSnapshot = Tools.ExchangeRateSnapshot();

            if (db.accounts[ac].transactions == null)
                db.accounts[ac].transactions = new List<Transaction>();

            if (tabControl.CurrentPage == 1)
            {
                t.amount = decimal.Parse(amountE.Text);
                t.desc = descE.Text;

                TreeIter tree;
                payeeE.GetActiveIter(out tree);
                String selectedText = (String)payeeE.Model.GetValue(tree, 0);
                t.payee = selectedText;

                t.dateTime = transactionDateE;
                t.type = TransactionType.Expense;

                currencyComboE.GetActiveIter(out tree);
                selectedText = (String)currencyComboE.Model.GetValue(tree, 0);
                t.currencyISO4217 = selectedText;
            }
            else
            {
                t.amount = decimal.Parse(amountI.Text);
                t.desc = descI.Text;

                TreeIter tree;
                payeeI.GetActiveIter(out tree);
                String selectedText = (String)payeeI.Model.GetValue(tree, 0);
                t.payee = selectedText;

                t.dateTime = transactionDateI;
                t.type = TransactionType.Income;

                currencyComboI.GetActiveIter(out tree);
                selectedText = (String)currencyComboI.Model.GetValue(tree, 0);
                t.currencyISO4217 = selectedText;
            }

            t.status = TransactionStatus.Scheduled;

            if (t.dateTime.Date == DateTime.Now.Date)
            {
                string msg = "Transaction date is today, do you want to execute this transaction now? Clicking `No` will set the status to: `OnHold`";
                MessageDialog msgdiag = new MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.YesNo, false, msg);
                ResponseType r = (ResponseType)msgdiag.Run();
                msgdiag.Destroy();

                if (r == ResponseType.Yes)
                    t.status = TransactionStatus.Completed;
                else if (r == ResponseType.No)
                    t.status = TransactionStatus.OnHold;
                else
                    return;
            }

            if (t.payee.StartsWith("[Internal]"))
            {
                string payee = t.payee.Replace("[Internal]", "");

                Transaction flip = new Transaction();

                flip.id = Guid.NewGuid();
                flip.amount = t.amount * -1;
                flip.desc = t.desc;
                flip.payee = t.payee;
                flip.dateTime = t.dateTime;
                flip.type = t.type;
                flip.status = t.status;
                flip.exchangeSnapshot = t.exchangeSnapshot;
                flip.currencyISO4217 = t.currencyISO4217;

                t.intern = flip.id;
                flip.intern = t.id;

                if (db.accounts[db.AccountIdFromName(payee)].transactions == null)
                    db.accounts[db.AccountIdFromName(payee)].transactions = new List<Transaction>();

                db.accounts[db.AccountIdFromName(payee)].transactions.Add(flip);
            }

            db.accounts[ac].transactions.Add(t);
            db.Save(dbPath);
            this.Destroy();
        }

        private void CancelBtn_Clicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            this.Destroy();
            a.RetVal = null;
        }
    }
}
