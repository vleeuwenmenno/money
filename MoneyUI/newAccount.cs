using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Money;
using ComboxExtended;
using System.IO;
using System.Text.RegularExpressions;

namespace MoneyUI
{
    public partial class newAccount : Form
    {
        public Database db;
        public string dbPath;
        public int ac;

        public newAccount(Database db, string dbPath)
        {
            InitializeComponent();

            this.db = db;
            this.dbPath = dbPath;
        }

        public newAccount(Database db, int account, string dbPath)
        {
            InitializeComponent();

            this.ac = account;
            this.db = db;
            this.dbPath = dbPath;

            this.Text = "Edit Account";

            accountNameTxt.Text = db.accounts[account].accountName;
            accountNumberTxt.Text = db.accounts[account].accountNumber;

            initialBalance.Value = db.accounts[account].initialBalance;
            initialBalance.Enabled = false;

            accountTypeCombo.Text = db.accounts[account].type;
            currencyTxt.Text = db.accounts[account].currencyISO4217;

            ComboBoxItem item = new ComboBoxItem(db.accounts[ac].type, Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/icons/" + db.accounts[ac].type.ToLower() + ".png"));
            accountTypeCombo.SelectedIndex = accountTypeCombo.Items.Add(item);
        }

        private void newAccount_Load(object sender, EventArgs e)
        {
            //LOAD IMGS FROM FILE. SPECIFY YOUR PATH FOR IMAGES
            String[] paths = { };
            paths = Directory.GetFiles(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/icons");

            try
            {
                foreach (String path in paths)
                {
                    accountTypeCombo.Items.Add(new ComboBoxItem(Tools.FirstCharToUpper(Path.GetFileNameWithoutExtension(path)), new Bitmap(path)));
                }
            }
            catch (Exception ex)
            { }
            
            foreach (KeyValuePair<string, decimal> c in Tools.ExchangeRateSnapshot())
                currencyTxt.Items.Add(c.Key);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(accountNumberTxt.Text))
            {
                MessageBox.Show("Cannot add account without account number! Please fill the account number input.", "No account number!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach(Account ac in db.accounts)
            {
                if (ac.accountNumber == accountNumberTxt.Text)
                {
                    MessageBox.Show("There is already an account added with this account number! Make sure the account number is unique.", "Account number not unique!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (this.Text != "Add account")
            {
                db.accounts[ac].accountName = accountNameTxt.Text;
                db.accounts[ac].accountNumber = accountNumberTxt.Text;
                db.accounts[ac].initialBalance = initialBalance.Value;
                db.accounts[ac].currencyISO4217 = currencyTxt.Text;
                db.accounts[ac].type = accountTypeCombo.Text.ToLower();

                db.Save(dbPath);
                this.Close();
            }
            else
            {
                Account ac = new Account();

                ac.accountName = accountNameTxt.Text;
                ac.accountNumber = accountNumberTxt.Text;
                ac.initialBalance = initialBalance.Value;
                ac.currencyISO4217 = currencyTxt.Text;
                ac.type = accountTypeCombo.Text.ToLower();

                db.accounts.Add(ac);
                db.Save(dbPath);
                this.Close();
            }
        }

        private void accountNumberTxt_KeyUp(object sender, KeyEventArgs e)
        {
            accountNumberTxt.Text = accountNumberTxt.Text.ToUpper();
            accountNumberTxt.Focus();
            accountNumberTxt.SelectionStart = accountNumberTxt.Text.Length;

            try
            {
                if (Tools.ValidateIBAN(accountNumberTxt.Text))
                {
                    accountNumberLabel.Text = "Account number (IBAN)";
                    accountNumberTxt.Text = Regex.Replace(accountNumberTxt.Text.Replace("-", "").Replace(" ", ""), ".{4}", "$0 ").Trim(); 
                }

                if (Tools.GetCardType(accountNumberTxt.Text.Replace("-", "").Replace(" ", "")) != CardType.Unknown)
                {
                    string s = Tools.FirstCharToUpper(Tools.GetCardType(accountNumberTxt.Text.Trim()).ToString().ToLower());
                    accountNumberTxt.Text = String.Format("{0:0000-0000-0000-0000}", (Int64.Parse(accountNumberTxt.Text.Trim())));
                    accountNumberLabel.Text = "Account number (Creditcard)";

                    ComboBoxItem item = new ComboBoxItem(s, Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/icons/" + s.ToLower() + ".png"));
                    accountTypeCombo.SelectedIndex = accountTypeCombo.Items.Add(item);
                }
            }
            catch (Exception ex) { accountNumberLabel.Text = "Account number"; }
        }
    }
}
