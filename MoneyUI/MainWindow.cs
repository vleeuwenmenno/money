using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace MoneyUUI
{
    class MainWindow : Window
    {
        [UI] private Button exitBtn = null;
        [UI] private Button browseBtn = null;
        [UI] private Button addDatabaseBtn = null;

        [UI] private TreeView recentDbList = null;
        private ListStore recentDbListStore = null;

        public MainWindow() : this(new Builder("StartupWindow.glade")) { }

        private MainWindow(Builder builder) : base(builder.GetObject("StartupWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            exitBtn.Clicked += exitBtn_Clicked;

            PrepareTreeView();
            recentDbListStore.AppendValues("Menno van Leeuwen", "LOC");
            recentDbListStore.AppendValues("Menno van Leeuwen", "LOC");
            recentDbListStore.AppendValues("Menno van Leeuwen", "LOC");
        }

        public void PrepareTreeView()
        {
            // Create a column for the artist name
            Gtk.TreeViewColumn dbName = new Gtk.TreeViewColumn ();
            dbName.Title = "Database Name";
    
            // Create a column for the song title
            Gtk.TreeViewColumn dbLocation = new Gtk.TreeViewColumn ();
            dbLocation.Title = "Song Title";
    
            // Add the columns to the TreeView
            recentDbList.AppendColumn (dbName);
            recentDbList.AppendColumn (dbLocation);
    
            // Create a model that will hold two strings - Artist Name and Song Title
            recentDbListStore = new ListStore (typeof (string), typeof (string));
    
    
            // Assign the model to the TreeView
            recentDbList.Model = recentDbListStore;

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
