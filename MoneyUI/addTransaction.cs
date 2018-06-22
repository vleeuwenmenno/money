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
            foreach (Account ac in db.accounts)
            {
                transactionAccount.Items.Add(new ComboBoxItem(ac.accountName, new Bitmap(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/icons/" + ac.cardType + ".png")));
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
