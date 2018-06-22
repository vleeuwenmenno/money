using System;
using MaterialSkin.Controls;
using MaterialSkin;
using Money;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MoneyUI
{
    public partial class accountOverview : MaterialForm
    {
        public Database db;
        public int ac;
        public string dbPath;

        public accountOverview(Database db, int account, string dbPath)
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

        private void accountOverview_Load(object sender, EventArgs e)
        {
            this.Text = db.accounts[ac].accountName + " overview";
            currentBalance.Text = db.accounts[ac].currencyChar + " " + String.Format("{0:n}", db.accounts[ac].balance);

            if (Tools.GetCardType(db.accounts[ac].accountNumber.Trim().Replace("-", "")) != CardType.Unknown)
            {
                acNumLabel.Text = (Creditcard.MaskDigits(db.accounts[ac].accountNumber));
            }
            else if (Tools.ValidateIBAN(db.accounts[ac].accountNumber))
                acNumLabel.Text = (Regex.Replace(db.accounts[ac].accountNumber, ".{4}", "$0 ").Trim());
            else
                acNumLabel.Text = (db.accounts[ac].accountNumber);

            acNumLabel.Location = new System.Drawing.Point(this.Size.Width - acNumLabel.Size.Width - 8, acNumLabel.Location.Y);
            currentBalance.Location = new System.Drawing.Point(this.Size.Width - currentBalance.Size.Width - 8, currentBalance.Location.Y);
            expectedEndBalance.Location = new System.Drawing.Point(this.Size.Width - expectedEndBalance.Size.Width - 8, expectedEndBalance.Location.Y);
            expectedEndBalanceLabel.Location = new System.Drawing.Point(this.Size.Width - expectedEndBalanceLabel.Size.Width - 12 - expectedEndBalance.Size.Width, expectedEndBalanceLabel.Location.Y);
        }

        private void addTransactionBtn_Click(object sender, EventArgs e)
        {
            addTransaction atr = new addTransaction(db, ac, dbPath);
            atr.ShowDialog();
        }

        private void upcomingTransactions_Resize(object sender, EventArgs e)
        {
            SizeLastColumn((ListView)sender);
        }

        private void SizeLastColumn(ListView lv)
        {
            int x = lv.Width / 15 == 0 ? 1 : lv.Width / 15;
            lv.Columns[0].Width = x * 5;
            lv.Columns[1].Width = x * 3;
            lv.Columns[2].Width = int.Parse(Math.Round(x * 2.5f, 0).ToString());
            lv.Columns[3].Width = int.Parse(Math.Round(x * 2.5f, 0).ToString());
            lv.Columns[4].Width = int.Parse(Math.Round(x * 2.2f, 0).ToString());
        }

        private void SizeLastColumnEx(ListView lv)
        {
            int x = lv.Width / 17 == 0 ? 1 : lv.Width / 17;
            lv.Columns[0].Width = x * 2;
            lv.Columns[1].Width = x * 5;
            lv.Columns[2].Width = x * 3;
            lv.Columns[3].Width = int.Parse(Math.Round(x * 2.5f, 0).ToString());
            lv.Columns[4].Width = int.Parse(Math.Round(x * 2.5f, 0).ToString());
            lv.Columns[5].Width = int.Parse(Math.Round(x * 2.2f, 0).ToString());
        }

        private void materialListView2_Resize(object sender, EventArgs e)
        {
            SizeLastColumnEx((ListView)sender);
        }

        private void materialListView3_Resize(object sender, EventArgs e)
        {
            SizeLastColumnEx((ListView)sender);
        }
    }
}
