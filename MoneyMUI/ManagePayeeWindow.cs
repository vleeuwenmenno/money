using Gtk;
using Money;
using System;
using System.Collections.Generic;
using System.Text;
using UI = Gtk.Builder.ObjectAttribute;

namespace MoneyUUI
{
    class ManagePayeeWindow : Dialog
    {

        public Database db;
        public string dbPath;
        public int ac;

        [UI] private Button closeBtn = null;

        public ManagePayeeWindow(Database db, string dbPath, int account) : this(new Builder("ManagePayeeWindow.glade"))
        {
            this.db = db;
            this.dbPath = dbPath;
            this.ac = account;

            this.Resize(256 + 32, 256 + 128);
            this.SetPosition(WindowPosition.CenterOnParent);
        }

        private ManagePayeeWindow(Builder builder) : base(builder.GetObject("ManagePayeeWindow").Handle)
        {
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;
            closeBtn.Clicked += CloseBtn_Clicked;
        }

        private void CloseBtn_Clicked(object sender, EventArgs e)
        {
            this.Destroy();
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            this.Destroy();
            a.RetVal = null;
        }
    }
}
