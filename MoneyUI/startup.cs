using MaterialSkin;
using MaterialSkin.Controls;
using Money;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyUI
{
    public partial class startup : MaterialForm
    {
        public Database db;
        public string dbPath;

        List<KeyValuePair<string, string>> history;

        public startup()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey400, Primary.BlueGrey600,
                Primary.BlueGrey600, Accent.LightBlue700,
                TextShade.WHITE
            );
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void newDbBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog svDialog = new SaveFileDialog();
            svDialog.Filter = "Money Datbase files *.mdb | *.mdb";

            DialogResult result = svDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                dbPath = svDialog.FileName;
                db = new Database();
                db.Save(dbPath);

                if (history.Contains(new KeyValuePair<string, string>(db.name, dbPath)))
                {
                    List<KeyValuePair<string, string>> historyCopy = new List<KeyValuePair<string, string>>(history);
                    historyCopy = historyCopy.ToList();
                    history = new List<KeyValuePair<string, string>>();

                    history.Add(historyCopy[historyCopy.IndexOf(new KeyValuePair<string, string>(db.name, dbPath))]);
                    historyCopy.Remove(new KeyValuePair<string, string>(db.name, dbPath));

                    history.AddRange(historyCopy);
                    File.WriteAllText(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/history.json", JsonConvert.SerializeObject(history, Formatting.Indented));
                }
                else
                {
                    history.Add(new KeyValuePair<string, string>(db.name, dbPath));
                    File.WriteAllText(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/history.json", JsonConvert.SerializeObject(history, Formatting.Indented));
                }

                this.Hide();
                databaseOverview dbo = new databaseOverview(db, dbPath);
                dbo.ShowDialog();
                this.Show();
            }
        }

        private void loadDbBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Filter = "Money Datbase files *.mdb | *.mdb";

            DialogResult result = ofDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                dbPath = ofDialog.FileName;
                db = new Database(dbPath);

                if (history.Contains(new KeyValuePair<string, string>(db.name, dbPath)))
                {
                    List<KeyValuePair<string, string>> historyCopy = new List<KeyValuePair<string, string>>(history);
                    historyCopy = historyCopy.ToList();
                    history = new List<KeyValuePair<string, string>>();
                    
                    history.Add(historyCopy[historyCopy.IndexOf(new KeyValuePair<string, string>(db.name, dbPath))]);
                    historyCopy.Remove(new KeyValuePair<string, string>(db.name, dbPath));

                    history.AddRange(historyCopy);
                    File.WriteAllText(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/history.json", JsonConvert.SerializeObject(history, Formatting.Indented));
                }
                else
                {
                    history.Add(new KeyValuePair<string, string>(db.name, dbPath));
                    File.WriteAllText(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/history.json", JsonConvert.SerializeObject(history, Formatting.Indented));
                }

                this.Hide();
                databaseOverview dbo = new databaseOverview(db, dbPath);
                dbo.ShowDialog();
                this.Show();
            }
        }

        private void startup_Load(object sender, EventArgs e)
        {
            history = new List<KeyValuePair<string, string>>();

            if (File.Exists(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/history.json"))
            {
                history = JsonConvert.DeserializeObject<List<KeyValuePair<string, string>>>(File.ReadAllText(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/history.json"));

                foreach (KeyValuePair<string, string> pair in history)
                {
                    ListViewItem item = new ListViewItem(pair.Key);
                    item.SubItems.Add(pair.Value);

                    recentsList.Items.Add(item);
                }
            }
        }

        private void recentsList_DoubleClick(object sender, EventArgs e)
        {
            dbPath = recentsList.SelectedItems[0].SubItems[1].Text;

            if (!File.Exists(dbPath))
            {
                DialogResult result = MessageBox.Show("The selected database could not be found, delete it from recents?", "Database not found", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    history.Remove(new KeyValuePair<string, string>(recentsList.SelectedItems[0].SubItems[0].Text, recentsList.SelectedItems[0].SubItems[1].Text));
                    File.WriteAllText(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/history.json", JsonConvert.SerializeObject(history, Formatting.Indented));
                }

                recentsList.Items.Clear();

                history = new List<KeyValuePair<string, string>>();

                if (File.Exists(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/history.json"))
                {
                    history = JsonConvert.DeserializeObject<List<KeyValuePair<string, string>>>(File.ReadAllText(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/history.json"));

                    foreach (KeyValuePair<string, string> pair in history)
                    {
                        ListViewItem item = new ListViewItem(pair.Key);
                        item.SubItems.Add(pair.Value);

                        recentsList.Items.Add(item);
                    }
                }

                return;
            }

            db = new Database(dbPath);

            if (history.Contains(new KeyValuePair<string, string>(db.name, dbPath)))
            {
                List<KeyValuePair<string, string>> historyCopy = new List<KeyValuePair<string, string>>(history);
                historyCopy = historyCopy.ToList();
                history = new List<KeyValuePair<string, string>>();

                history.Add(historyCopy[historyCopy.IndexOf(new KeyValuePair<string, string>(db.name, dbPath))]);
                historyCopy.Remove(new KeyValuePair<string, string>(db.name, dbPath));

                history.AddRange(historyCopy);
                File.WriteAllText(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/history.json", JsonConvert.SerializeObject(history, Formatting.Indented));
            }
            else
            {
                history.Add(new KeyValuePair<string, string>(db.name, dbPath));
                File.WriteAllText(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/history.json", JsonConvert.SerializeObject(history, Formatting.Indented));
            }

            this.Hide();
            databaseOverview dbo = new databaseOverview(db, dbPath);
            dbo.ShowDialog();
            this.Show();
        }

        private void recentsList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (recentsList.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    rightMouseMenu.Show(Cursor.Position);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
