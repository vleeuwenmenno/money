using MaterialSkin.Controls;
using MaterialSkin;
using System;
using Money;
using System.Net;
using System.Threading;
using WebDav;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

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
                        if (oDb.modDateTime < db.modDateTime)
                        {
                            File.WriteAllText(dbPath, json);

                            db = null;
                            oDb = null;

                            db = new Database(dbPath);
                        }
                        else
                        //Else upload local to online
                        {
                            //First delete the online version
                            var resultInnerInner = await _client.Delete(db.webDavHost + "/Money/database.mdb");

                            if (resultInnerInner.IsSuccessful)
                            {
                                var resultInnerInnerInner = await _client.PutFile(db.webDavHost + "/Money/database.mdb", File.OpenRead(dbPath));

                                if (resultInnerInnerInner.IsSuccessful)
                                {
                                    MessageBox.Show("Failed to upload database. Sync error " + resultInnerInner.StatusCode + " (" + resultInnerInner.Description + ")", resultInnerInner.Description, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                                MessageBox.Show("Failed to delete out-of-sync online database. Sync error " + resultInnerInner.StatusCode + " (" + resultInnerInner.Description + ")", resultInnerInner.Description, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        db.Save(dbPath);
                        Invoke((MethodInvoker)delegate {
                            this.Close();
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
                                this.Close();
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
                                this.Close();
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
                    this.Focus();
                });
            });

            t.Start();
        }

        private void saveBtn_ClickAsync(object sender, EventArgs e)
        {
            db.name = dbNameTxtBox.Text;
            db.syncWebDav = syncWebDav.Checked;
            db.darkTheme = darkThemeChk.Checked;

            if (db.syncWebDav)
            {
                db.webDavUsername = usernameTxt.Text;
                db.webDavHost = linkTxt.Text;
                db.webDavPass = passwordTxt.Text;

                progressBar.Visible = true;
                this.Enabled = false;

                runSync();
            }
            else
            {
                db.webDavUsername = "";
                db.webDavHost = "";
                db.webDavPass = "";

                db.Save(dbPath);
                this.Close();
            }
        }
    }
}
