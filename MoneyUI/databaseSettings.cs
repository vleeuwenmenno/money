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

namespace MoneyUI
{
    public partial class databaseSettings : MaterialForm
    {
        public Database db;
        public string dbPath;

        public databaseSettings(Database db, string dbPath)
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

        private void databaseSettings_Load(object sender, EventArgs e)
        {
            dbNameTxtBox.Text = db.name;

            if (db.syncWebDav)
                syncWebDav.Checked = true;

            linkTxt.Text = db.webDavHost;
            usernameTxt.Text = db.webDavUsername;
            passwordTxt.Text = db.webDavPass;
            darkThemeChk.Checked = db.darkTheme;
        }

        private void syncWebDav_CheckedChanged(object sender, EventArgs e)
        {
            if (syncWebDav.Checked)
                webDavSettingsPanel.Enabled = true;
            else
                webDavSettingsPanel.Enabled = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            db.name = dbNameTxtBox.Text;
            db.syncWebDav = syncWebDav.Checked;
            db.darkTheme = darkThemeChk.Checked;

            if (db.syncWebDav)
            {
                db.webDavUsername = usernameTxt.Text;
                db.webDavHost = linkTxt.Text;
                db.webDavPass = passwordTxt.Text;
            }
            else
            {
                db.webDavUsername = "";
                db.webDavHost = "";
                db.webDavPass = "";
            }

            db.Save(dbPath);
            this.Close();
        }
    }
}
