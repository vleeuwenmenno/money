using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Gtk;
using Money;
using Newtonsoft.Json;
using UI = Gtk.Builder.ObjectAttribute;

namespace MoneyUUI
{
    class StartupWindow : Window
    {
        public Database db;
        public string dbPath;

        List<KeyValuePair<string, string>> history;

        [UI] private Button exitBtn = null;
        [UI] private Button browseBtn = null;
        [UI] private Button addDatabaseBtn = null;

        [UI] private TreeView recentDbList = null;
        [UI] private ListStore recentDbListStore = null;

        public StartupWindow() : this(new Builder("StartupWindow.glade")) 
        { }

        private StartupWindow(Builder builder) : base(builder.GetObject("StartupWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;

            exitBtn.Clicked += exitBtn_Clicked;
            browseBtn.Clicked += browseBtn_Clicked;
            addDatabaseBtn.Clicked += addDatabaseBtn_Clicked;

            PrepareTreeView();
            this.Resize(640, 350);

            history = new List<KeyValuePair<string, string>>();

            if (File.Exists(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/history.json"))
            {
                history = JsonConvert.DeserializeObject<List<KeyValuePair<string, string>>>(File.ReadAllText(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/history.json"));

                foreach (KeyValuePair<string, string> pair in history)
                {
                    recentDbListStore.AppendValues(pair.Key, pair.Value);
                }
            }
        }

        private void addDatabaseBtn_Clicked(object sender, EventArgs e)
        {
            FileChooserDialog svDialog = new FileChooserDialog("Choose the file to open",
            this,
            FileChooserAction.Save,
            "Cancel",ResponseType.Cancel,
            "Save",ResponseType.Accept);

            svDialog.Filter = new FileFilter();
            svDialog.Filter.Name = "Money Datbase files *.mdb";
            svDialog.Filter.AddPattern("*.mdb");
            svDialog.SelectMultiple = false;

            if (svDialog.Run() == (int)ResponseType.Accept) 
            {
                dbPath = svDialog.Filename + ".mdb";
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
                    File.WriteAllText(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/history.json", JsonConvert.SerializeObject(history, Formatting.Indented));
                }
                else
                {
                    history.Add(new KeyValuePair<string, string>(db.name, dbPath));
                    File.WriteAllText(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/history.json", JsonConvert.SerializeObject(history, Formatting.Indented));
                }

                this.Hide();
                DatabaseOverviewWindow dbo = new DatabaseOverviewWindow(db, dbPath);
                dbo.Show();
            }
        }

        private void browseBtn_Clicked(object sender, EventArgs e)
        {
            FileChooserDialog ofDialog = new FileChooserDialog("Choose the file to open",
            this,
            FileChooserAction.Open,
            "Cancel",ResponseType.Cancel,
            "Open",ResponseType.Accept);

            ofDialog.Filter = new FileFilter();
            ofDialog.Filter.Name = "Money Datbase files *.mdb";
            ofDialog.Filter.AddPattern("*.mdb");
            ofDialog.SelectMultiple = false;

            if (ofDialog.Run() == (int)ResponseType.Accept) 
            {
                dbPath = ofDialog.Filename;
                db = new Database(dbPath);

                if (history.Contains(new KeyValuePair<string, string>(db.name, dbPath)))
                {
                    List<KeyValuePair<string, string>> historyCopy = new List<KeyValuePair<string, string>>(history);
                    historyCopy = historyCopy.ToList();
                    history = new List<KeyValuePair<string, string>>();
                    
                    history.Add(historyCopy[historyCopy.IndexOf(new KeyValuePair<string, string>(db.name, dbPath))]);
                    historyCopy.Remove(new KeyValuePair<string, string>(db.name, dbPath));

                    history.AddRange(historyCopy);
                    File.WriteAllText(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/history.json", JsonConvert.SerializeObject(history, Formatting.Indented));
                }
                else
                {
                    history.Add(new KeyValuePair<string, string>(db.name, dbPath));
                    File.WriteAllText(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "/history.json", JsonConvert.SerializeObject(history, Formatting.Indented));
                }

                this.Hide();
                DatabaseOverviewWindow dbo = new DatabaseOverviewWindow(db, dbPath);
                dbo.Show();
            }
            ofDialog.Hide();
        }

        public void PrepareTreeView()
        {
            // Create a column for the artist name
            Gtk.TreeViewColumn dbName = new Gtk.TreeViewColumn ();
            dbName.Title = "Database Name";
    
            // Create a column for the song title
            Gtk.TreeViewColumn dbLocation = new Gtk.TreeViewColumn ();
            dbLocation.Title = "Location";
    
            // Add the columns to the TreeView
            recentDbList.AppendColumn (dbName);
            recentDbList.AppendColumn (dbLocation);

            // Create the text cell that will display the artist name
            Gtk.CellRendererText artistNameCell = new Gtk.CellRendererText ();
            
            // Add the cell to the column
            dbName.PackStart (artistNameCell, true);
            
            // Do the same for the song title column
            Gtk.CellRendererText songTitleCell = new Gtk.CellRendererText ();
            dbLocation.PackStart (songTitleCell, true);

            // Tell the Cell Renderers which items in the model to display
            dbName.AddAttribute (artistNameCell, "text", 0);
            dbLocation.AddAttribute (songTitleCell, "text", 1);
        }

        private void exitBtn_Clicked(object sender, EventArgs e)
        {
            Application.Quit();
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }
    }
}
