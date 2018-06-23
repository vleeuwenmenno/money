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
using MaterialSkin;
using MaterialSkin.Controls;
using Money;
using ComboxExtended;
using System.IO;
using System.Text.RegularExpressions;

namespace MoneyUI
{
    public partial class newAccount : MaterialForm
    {
        public Database db;
        public string dbPath;
        public int ac;

        public newAccount(Database db, string dbPath)
        {
            InitializeComponent();

            this.db = db;
            this.dbPath = dbPath;

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
            currencyTxt.Text = db.accounts[account].currencyChar.ToString();

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
            
            string[] currencySymbols = { "€ (EUR)", "$ (USD)", "£ (GBP)", "฿ (THB)" };
            foreach (string c in currencySymbols)
                currencyTxt.Items.Add(c);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            if (this.Text != "Add account")
            {
                db.accounts[ac].accountName = accountNameTxt.Text;
                db.accounts[ac].accountNumber = accountNumberTxt.Text;
                db.accounts[ac].initialBalance = initialBalance.Value;
                db.accounts[ac].currencyChar = char.Parse(currencyTxt.Text.Substring(0, 1));
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
                ac.currencyChar = char.Parse(currencyTxt.Text.Substring(0, 1));
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
