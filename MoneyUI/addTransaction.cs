using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Money;
using ComboxExtended;
using System.IO;
using MoneyUI;

namespace MoneyUI
{
    public partial class addTransaction : MaterialForm
    {
        public Database db;
        public int ac;
        public string dbPath;

        public addTransaction(Database db, int account, string dbPath)
        {
            InitializeComponent();

            this.db = db;
            this.dbPath = dbPath;
            this.ac = account;

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            if (db.darkTheme)
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            else
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey400, Primary.BlueGrey600,
                Primary.BlueGrey600, Accent.LightBlue700,
                TextShade.WHITE
            );
        }

        private void addTransaction_Load(object sender, EventArgs e)
        {
            string s = db.accounts[ac].type;
            ComboBoxItem iteme = new ComboBoxItem(db.accounts[ac].accountName, Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/icons/" + s.ToLower() + ".png"));
            transactionAccountE.SelectedIndex = transactionAccountE.Items.Add(iteme);

            ComboBoxItem itemi = new ComboBoxItem(db.accounts[ac].accountName, Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/icons/" + s.ToLower() + ".png"));
            transactionAccountI.SelectedIndex = transactionAccountI.Items.Add(itemi);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payeeSelectBtn_Click(object sender, EventArgs e)
        {
            payeeSelector psel = new payeeSelector(db, ac, dbPath);
            psel.ShowDialog();

            transactionPayeeI.Text = psel.returnVal;
            transactionPayeeE.Text = psel.returnVal;
        }

        private void addTransactionBtn_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction();

            t.id = Guid.NewGuid();

            if (db.accounts[db.AccountIdFromName(transactionAccountE.Text)].transactions == null)
                db.accounts[db.AccountIdFromName(transactionAccountE.Text)].transactions = new List<Transaction>();

            if (materialTabControl1.SelectedTab.Text == "Expense")
            {
                t.amount = transactionAmountE.Value;
                t.desc = transactionDescE.Text;
                t.payee = transactionPayeeE.Text;
                t.dateTime = transactionDateE.Value;
                t.type = TransactionType.Expense;
            }
            else
            {
                t.amount = transactionAmountI.Value;
                t.desc = transactionDescI.Text;
                t.payee = transactionPayeeI.Text;
                t.dateTime = transactionDateI.Value;
                t.type = TransactionType.Income;
            }

            t.status = TransactionStatus.Scheduled;

            if (t.dateTime.Date == DateTime.Now.Date)
            {
                DialogResult res = MessageBox.Show("Transaction date is today, do you want to execute this transaction now? Clicking `No` will set the status to: `OnHold`", "Execute transaction now?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (res == DialogResult.Yes)
                    t.status = TransactionStatus.Completed;
                else if (res == DialogResult.No)
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

                t.intern = flip.id;
                flip.intern = t.id;

                if (db.accounts[db.AccountIdFromName(payee)].transactions == null)
                    db.accounts[db.AccountIdFromName(payee)].transactions = new List<Transaction>();

                db.accounts[db.AccountIdFromName(payee)].transactions.Add(flip);
            }

            db.accounts[db.AccountIdFromName(transactionAccountI.Text)].transactions.Add(t);
            db.Save(dbPath);
            this.Close();
        }

        private void transactionAmountE_ValueChanged(object sender, EventArgs e)
        {
            if (transactionAmountE.Value > 0)
            {
                transactionAmountE.Value = transactionAmountE.Value * -1;
            }
        }
    }
}
