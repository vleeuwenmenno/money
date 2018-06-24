using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Money;
using Newtonsoft.Json;
using WebDav;

namespace MoneyUI
{
    public partial class databaseOverview : MaterialForm
    {
        public Database db;
        public string dbPath;

        public DateTime monthToDisplay = DateTime.Now;

        public accountOverview ao;

        public databaseOverview(Database db, string dbPath)
        {
            InitializeComponent();

            this.db = db;
            this.dbPath = dbPath;

            ao = new accountOverview(db, 0, dbPath, this);

            UpdateGUI();
        }

        private void databaseOverview_LocationChanged(object sender, EventArgs e)
        {
            ao.Location = new Point(this.Location.X + 300, this.Location.Y);
        }

        private void UpdateGUI()
        {
            accountListView.Items.Clear();
            monthLabel.Text = monthToDisplay.ToString("MMMM yyyy");

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
                ListViewItem item = new ListViewItem(ac.accountName, ac.type);
                string s = ac.accountName + Environment.NewLine;

                if (Tools.GetCardType(ac.accountNumber.Trim().Replace("-", "")) != CardType.Unknown)
                {
                    s += (Creditcard.MaskDigits(ac.accountNumber));
                }
                else if (Tools.ValidateIBAN(ac.accountNumber))
                    s += (Regex.Replace(ac.accountNumber, ".{4}", "$0 ").Trim());
                else
                    s += (ac.accountNumber);

                item.Text = s;

                item.SubItems.Add(ac.currencyISO4217 + " " + String.Format("{0:n}", ac.currentBalance));
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

            UpdateGUI();
        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            newAccount dbs = new newAccount(db, dbPath);
            dbs.ShowDialog();

            foreach (Account ac in db.accounts)
                ac.RecalculateBalance();

            UpdateGUI();
        }

        private void accountListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (accountListView.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    if (accountListView.SelectedItems.Count > 0)
                        contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (accountListView.SelectedItems.Count > 0)
            {
                newAccount nac = new newAccount(db, db.accounts.IndexOf((Account)accountListView.SelectedItems[0].Tag), dbPath);
                nac.ShowDialog();

                foreach (Account ac in db.accounts)
                    ac.RecalculateBalance();

                UpdateGUI();
            }
        }

        private void databaseOverview_Load(object sender, EventArgs e)
        {
            //Set current month label
            monthLabel.Text = monthToDisplay.ToString("MMMM yyyy");

            //Check if syncing is enabled if so show the button
            if (db.syncWebDav)
            {
                syncBtn.Visible = true;
            }

            ao.Show();
            ao.Location = new Point(this.Location.X + 300, this.Location.Y);
        }

        private void databaseOverview_FormClosing(object sender, FormClosingEventArgs e)
        {
            ao.Close();
        }

        private void uiChecker_Tick(object sender, EventArgs e)
        {
            if (ao.shouldUpdate)
            {
                UpdateGUI();
                ao.shouldUpdate = false;
            }
        }

        private void accountListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accountListView.SelectedItems.Count > 0)
                ao.ac = db.accounts.IndexOf((Account)accountListView.SelectedItems[0].Tag);
        }

        private void monthLabel_Click(object sender, EventArgs e)
        {
            monthToDisplay = DateTime.Now;
            UpdateGUI();
            ao.shouldUpdateHere = true;
        }

        private void monthBackBtn_Click(object sender, EventArgs e)
        {
            monthToDisplay = monthToDisplay.AddMonths(-1);
            UpdateGUI();
            ao.shouldUpdateHere = true;
        }

        private void monthForwardBtn_Click(object sender, EventArgs e)
        {
            monthToDisplay = monthToDisplay.AddMonths(1);
            UpdateGUI();
            ao.shouldUpdateHere = true;
        }

        private void syncBtn_Click(object sender, EventArgs e)
        {
            syncBtn.Text = "...";
            syncBtn.Enabled = false;
            progressBar.Visible = true;

            runSync();
        }

        public void runSync()
        {
            IWebDavClient _client = new WebDavClient();
            var clientParams = new WebDavClientParams
            {
                BaseAddress = new Uri(db.webDavHost),
                Credentials = new NetworkCredential(db.webDavUsername, db.webDavPass)
            };
            _client = new WebDavClient(clientParams);

            Thread t = new Thread(async () => {
                var result = await _client.Propfind(db.webDavHost + "/Money");
                if (result.IsSuccessful)
                {
                    bool containsDb = false;
                    foreach (var res in result.Resources)
                    {
                        if (res.Uri.EndsWith("database.mdb")) //Check if we have the database online
                        {
                            containsDb = true;
                            break;
                        }
                    }

                    if (containsDb)
                    {
                        //Let's grab the online version
                        var resultInner = await _client.GetRawFile(db.webDavHost + "/Money/database.mdb");

                        StreamReader reader = new StreamReader(resultInner.Stream);
                        string json = reader.ReadToEnd();
                        Database oDb = JsonConvert.DeserializeObject<Database>(json);

                        //Check if modDateTime is newer than current database
                        //if so replace local with online
                        if (oDb.modDateTime > db.modDateTime)
                        {
                            File.WriteAllText(dbPath, json);

                            db = null;
                            oDb = null;

                            db = new Database(dbPath);

                            Invoke((MethodInvoker)delegate {
                                //Reload the account overview window
                                ao.Close();
                                ao = new accountOverview(db, 0, dbPath, this);
                                ao.Show();

                                UpdateGUI();

                                progressBar.Visible = false;
                                this.Enabled = true;
                                syncBtn.Text = "Sync";
                                syncBtn.Enabled = true;
                                this.Focus();
                            });
                        }
                        else
                        //Else upload local to online
                        {
                            //First delete the online version
                            var resultInnerInner = await _client.Delete(db.webDavHost + "/Money/database.mdb");

                            if(resultInnerInner.IsSuccessful)
                            {
                                var resultInnerInnerInner = await _client.PutFile(db.webDavHost + "/Money/database.mdb", File.OpenRead(dbPath));
                                
                                if (!resultInnerInnerInner.IsSuccessful)
                                {
                                    MessageBox.Show("Failed to upload database. Sync error " + resultInnerInner.StatusCode + " (" + resultInnerInner.Description + ")", resultInnerInner.Description, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    Invoke((MethodInvoker)delegate {
                                        UpdateGUI();

                                        progressBar.Visible = false;
                                        this.Enabled = true;
                                        syncBtn.Text = "Sync";
                                        syncBtn.Enabled = true;
                                        this.Focus();
                                    });
                                }

                            }
                            else
                                MessageBox.Show("Failed to delete out-of-sync online database. Sync error " + resultInnerInner.StatusCode + " (" + resultInnerInner.Description + ")", resultInnerInner.Description, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        db.Save(dbPath);
                        Invoke((MethodInvoker)delegate {
                            progressBar.Visible = false;
                            this.Enabled = true;
                            syncBtn.Text = "Sync";
                            syncBtn.Enabled = true;
                            this.Focus();
                        });
                    }
                    else
                    {
                        var resultInner = await _client.PutFile(db.webDavHost + "/Money/database.mdb", File.OpenRead(dbPath));

                        if (!resultInner.IsSuccessful)
                            MessageBox.Show("Error " + resultInner.StatusCode + " (" + resultInner.Description + ")", resultInner.Description, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            db.Save(dbPath);
                            Invoke((MethodInvoker)delegate {
                                progressBar.Visible = false;
                                this.Enabled = true;
                                syncBtn.Text = "Sync";
                                syncBtn.Enabled = true;
                                this.Focus();
                            });
                        }
                    }
                }
                else if (result.StatusCode == 404)
                {
                    var resultInner = await _client.Mkcol("Money");

                    if (resultInner.IsSuccessful)
                    {
                        resultInner = await _client.PutFile(db.webDavHost + "/Money/database.mdb", File.OpenRead(dbPath));

                        if (!resultInner.IsSuccessful)
                            MessageBox.Show("Error " + resultInner.StatusCode + " (" + resultInner.Description + ")", result.Description, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            db.Save(dbPath);
                            Invoke((MethodInvoker)delegate {
                                progressBar.Visible = false;
                                this.Enabled = true;
                                syncBtn.Text = "Sync";
                                syncBtn.Enabled = true;
                                this.Focus();
                            });
                        }
                    }
                    else
                        MessageBox.Show("Error " + resultInner.StatusCode + " (" + resultInner.Description + ")", result.Description, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Error " + result.StatusCode + " (" + result.Description + ")", result.Description, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Invoke((MethodInvoker)delegate {
                    progressBar.Visible = false;
                    this.Enabled = true;
                    syncBtn.Text = "Sync";
                    syncBtn.Enabled = true;
                    this.Focus();
                });
            });

            t.Start();
        }
    }
}
