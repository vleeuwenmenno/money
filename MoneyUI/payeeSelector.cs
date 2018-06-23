using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Money;

namespace MoneyUI
{
    public partial class payeeSelector : MaterialForm
    {
        public Database db;
        public int ac;
        public string dbPath;
        public string returnVal = "";

        public payeeSelector(Database db, int account, string dbPath)
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

        private void payeeSelector_Load(object sender, EventArgs e)
        {
            if (db.payees == null)
                db.payees = new List<string>();

            foreach (string p in db.payees)
            {
                ListViewItem item = new ListViewItem(p, p, null);
                item.Tag = "";
                payeeList.Items.Add(item);
            }

            foreach (Account ac in db.accounts)
            {
                ListViewItem item = new ListViewItem("[Internal]" + ac.accountName, "[Internal]" + ac.accountName, null);
                item.Tag = "internal";
                payeeList.Items.Add(item);
            }
        }

        private void payeeList_Resize(object sender, EventArgs e)
        {
            ListView lv = ((ListView)sender);
            int x = lv.Width / 1 == 0 ? 1 : lv.Width / 1;
            lv.Columns[0].Width = x;
        }

        private void payeeList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (payeeList.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    if (payeeList.FocusedItem.Tag != "internal")
                        materialContextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            payeeList.Items.Add(payeeTxtBox.Text);
            payeeTxtBox.Text = "";
        }

        private void payeeList_DoubleClick(object sender, EventArgs e)
        {
            returnVal = payeeList.SelectedItems[0].SubItems[0].Text;
            db.payees = new List<string>();
            
            foreach (ListViewItem s in payeeList.Items)
            {
                if (s.Tag != "internal")
                    db.payees.Add(s.Text);
            }
            db.Save(dbPath);
            this.Close();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            payeeList.Items.RemoveByKey(payeeList.SelectedItems[0].SubItems[0].Text);
        }
    }
}
