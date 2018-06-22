using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Money;

namespace MoneyUI
{
    public partial class databaseOverview : MaterialForm
    {
        public Database db;
        public string dbPath;

        public databaseOverview(Database db, string dbPath)
        {
            InitializeComponent();

            this.db = db;
            this.dbPath = dbPath;

            PopulateUI();
        }

        private void PopulateUI()
        {
            accountListView.Items.Clear();

            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(48, 64);

            //LOAD IMGS FROM FILE. SPECIFY YOUR PATH FOR IMAGES
            String[] paths = { };
            paths = Directory.GetFiles(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/icons");

            try
            {
                foreach (String path in paths)
                {
                    imgs.Images.Add(Path.GetFileNameWithoutExtension(path),Image.FromFile(path));
                }
            }
            catch (Exception e)
            { }

            //BIND IMGS TO LISTVIEW
            accountListView.SmallImageList = imgs;

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

            this.Text = db.name;

            foreach (Account ac in db.accounts)
            {
                ListViewItem item = new ListViewItem(ac.accountName, ac.cardType);

                if (Tools.GetCardType(ac.accountNumber.Trim().Replace("-", "")) != CardType.Unknown)
                {
                    item.SubItems.Add(Creditcard.MaskDigits(ac.accountNumber));
                }
                else if (Tools.ValidateIBAN(ac.accountNumber))
                    item.SubItems.Add(Regex.Replace(ac.accountNumber, ".{4}", "$0 ").Trim());
                else
                    item.SubItems.Add(ac.accountNumber);

                item.SubItems.Add(ac.currencyChar + " " + String.Format("{0:n}", ac.balance));
                item.Tag = ac;

                accountListView.Items.Add(item);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            databaseSettings dbs = new databaseSettings(db, dbPath);
            dbs.ShowDialog();

            PopulateUI();
        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            newAccount dbs = new newAccount(db, dbPath);
            dbs.ShowDialog();

            PopulateUI();
        }

        private void accountListView_DoubleClick(object sender, EventArgs e)
        {
            accountOverview aov = new accountOverview(db, db.accounts.IndexOf((Account)accountListView.SelectedItems[0].Tag), dbPath);

            aov.Show();
        }

        private void accountListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (accountListView.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newAccount nac = new newAccount(db, db.accounts.IndexOf((Account)accountListView.SelectedItems[0].Tag), dbPath);
            nac.ShowDialog();
            PopulateUI();
        }

        private void databaseOverview_Load(object sender, EventArgs e)
        {

        }
    }
}
