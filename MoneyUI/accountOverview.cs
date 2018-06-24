using System;
using Money;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace MoneyUI
{
    public partial class accountOverview : Form
    {
        public Database db;

        public int ac;
        private int vac = 99999;

        public string dbPath;

        public bool shouldUpdate = false;
        public bool shouldUpdateHere = false;

        public databaseOverview parent;
        private ListViewItem transactionHistoryItem;

        private ListViewItem GetItemFromPoint(ListView listView, Point mousePosition)
        {
            // translate the mouse position from screen coordinates to 
            // client coordinates within the given ListView
            Point localPoint = listView.PointToClient(mousePosition);
            return listView.GetItemAt(localPoint.X, localPoint.Y);
        }

        public accountOverview(Database db, int account, string dbPath, databaseOverview parent)
        {
            InitializeComponent();
            this.parent = parent;

            this.db = db;
            this.dbPath = dbPath;
            this.ac = account;
        }

        private void accountOverview_Load(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        public void UpdateGUI()
        {
            if (db.accounts.Count > 0)
            {
                //Update labels
                this.Text = db.accounts[ac].accountName + " overview";
                currentBalance.Text = db.accounts[ac].currencyISO4217 + " " + String.Format("{0:n}", db.accounts[ac].currentBalance);

                expectedEndBalanceLabel.Text = "End-balance at " + DateTime.DaysInMonth(parent.monthToDisplay.Year, parent.monthToDisplay.Month) + " " + parent.monthToDisplay.ToString("MMMM yyyy");
                expectedEndBalance.Text = db.accounts[ac].currencyISO4217 + " " + String.Format("{0:n}", db.accounts[ac].currentBalance); //TODO: Calculate this

                if (Tools.GetCardType(db.accounts[ac].accountNumber.Trim().Replace("-", "")) != CardType.Unknown)
                {
                    acNumLabel.Text = (Creditcard.MaskDigits(db.accounts[ac].accountNumber));
                }
                else
                    acNumLabel.Text = (db.accounts[ac].accountNumber);

                //Move labels to make sure they fit inside the form (Because we updated the text)
                acNumLabel.Location = new System.Drawing.Point(this.Size.Width - acNumLabel.Size.Width - 24, acNumLabel.Location.Y);
                currentBalance.Location = new System.Drawing.Point(this.Size.Width - currentBalance.Size.Width - 24, currentBalance.Location.Y);

                //Populate transaction history list
                transactionHistory.Items.Clear();
                if (db.accounts[ac].transactions != null)
                    foreach (Transaction t in db.accounts[ac].transactions)
                    {
                        if (t.dateTime.Year == parent.monthToDisplay.Year)
                            if (t.dateTime.Month == parent.monthToDisplay.Month)
                            {
                                ListViewItem item = new ListViewItem(t.status.ToString()); //status

                                item.Tag = t.id;
                                item.SubItems.Add(t.desc); //desc
                                item.SubItems.Add(t.dateTime.ToString("dd-MM-yyyy")); //date
                                item.SubItems.Add(t.payee); //payee

                                if (t.currencyISO4217 != db.accounts[ac].currencyISO4217)
                                    item.SubItems.Add(db.accounts[ac].currencyISO4217 + " " + Math.Round(Tools.ConvertCurrency(t.exchangeSnapshot, t.currencyISO4217, db.accounts[ac].currencyISO4217, t.amount), 2) + "(" + t.currencyISO4217 + " " + String.Format("{0:n}", t.amount) + ")"); //amount
                                else
                                    item.SubItems.Add(t.currencyISO4217 + " " + String.Format("{0:n}", t.amount)); //amount

                                transactionHistory.Items.Add(item);
                            }
                    }
                
                transactionsScheduled_Resize(transactionsScheduled, null);
                transactionHistory_Resize(transactionHistory, null);
                shouldUpdate = true;
            }
        }

        #region Resize handlers

        private void transactionsScheduled_Resize(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;
            int x = lv.Width / 17 == 0 ? 1 : lv.Width / 17;
            lv.Columns[0].Width = x * 6;
            lv.Columns[1].Width = x * 2;
            lv.Columns[2].Width = x * 3;
            lv.Columns[3].Width = int.Parse(Math.Round(x * 4f, 0).ToString());
            lv.Columns[4].Width = int.Parse(Math.Round(x * 2.2f, 0).ToString());
        }

        private void transactionHistory_Resize(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;
            int x = lv.Width / 14 == 0 ? 1 : lv.Width / 14;
            lv.Columns[0].Width = x * 2;
            lv.Columns[1].Width = x * 6;
            lv.Columns[2].Width = x * 2;
            lv.Columns[3].Width = x * 2;
            lv.Columns[4].Width = x * 2;
        }

        #endregion

        #region Click handlers

        private void addTransactionBtn_Click(object sender, EventArgs e)
        {
            addTransaction atr = new addTransaction(db, ac, dbPath);
            atr.ShowDialog();

            //We finished adding a transaction so let's update the balance and UI
            foreach (Account ac in db.accounts)
                ac.RecalculateBalance();

            UpdateGUI();
        }

        private void transactionHistory_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (transactionHistory.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    // call it like this:
                    transactionHistoryItem = GetItemFromPoint(transactionHistory, Cursor.Position);

                    if (transactionHistoryItem.Text == "OnHold")
                        executeToolStripMenuItem.Enabled = true;
                    else
                        executeToolStripMenuItem.Enabled = false;

                    if (transactionHistoryItem.Text == "Scheduled")
                    {
                        executeToolStripMenuItem.Enabled = true;
                        skipToolStripMenuItem.Enabled = true;
                    }
                    else
                        skipToolStripMenuItem.Enabled = false;

                    transactionHistoryContextMenu.Show(Cursor.Position);
                }
            }
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < db.accounts[ac].transactions.Count; i++)
            {
                Transaction t = db.accounts[ac].transactions[i];
                if (t.id == ((Guid)transactionHistoryItem.Tag))
                {
                    t.status = TransactionStatus.Completed;

                    if (t.intern != Guid.Empty)
                    {
                        int account = 0;
                        Transaction internT = null;
                        foreach (Account a in db.accounts)
                        {
                            if (a.GetTransaction(t.intern) != null)
                            {
                                internT = a.GetTransaction(t.intern);
                                break;
                            }
                            account++;
                        }
                        internT.status = TransactionStatus.Completed;
                    }

                    foreach (Account ac in db.accounts)
                        ac.RecalculateBalance();

                    UpdateGUI();
                    db.Save(dbPath);
                    return;
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to delete this transaction?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                for (int i = 0; i < db.accounts[ac].transactions.Count; i++)
                {
                    Transaction t = db.accounts[ac].transactions[i];
                    if (t.id == ((Guid)transactionHistoryItem.Tag))
                    {
                        if (t.intern != Guid.Empty)
                        {
                            r = MessageBox.Show("The payee in this transaction is internal, do you want to delete the payee transaction too?", "Delete linked transaction?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (r == DialogResult.Yes)
                            {
                                int account = 0;
                                Transaction internT = null;
                                foreach (Account a in db.accounts)
                                {
                                    if (a.GetTransaction(t.intern) != null)
                                    {
                                        internT = a.GetTransaction(t.intern);
                                        break;
                                    }
                                    account++;
                                }

                                if (internT != null)
                                    db.accounts[account].transactions.Remove(internT);
                                else
                                    MessageBox.Show("Linked transaction could not be found, it's probably already gone.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (r == DialogResult.No)
                            {
                                int account = 0;
                                Transaction internT = null;
                                foreach (Account a in db.accounts)
                                {
                                    if (a.GetTransaction(t.intern) != null)
                                    {
                                        internT = a.GetTransaction(t.intern);
                                        break;
                                    }
                                    account++;
                                }
                                internT.intern = Guid.Empty;
                            }
                        }

                        db.accounts[ac].transactions.Remove(t);

                        foreach (Account ac in db.accounts)
                            ac.RecalculateBalance();

                        UpdateGUI();
                        db.Save(dbPath);
                        return;
                    }
                }
            }
        }

        private void skipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < db.accounts[ac].transactions.Count; i++)
            {
                Transaction t = db.accounts[ac].transactions[i];
                if (t.id == ((Guid)transactionHistoryItem.Tag))
                {
                    t.status = TransactionStatus.Skipped;

                    if (t.intern != Guid.Empty)
                    {
                        int account = 0;
                        Transaction internT = null;
                        foreach (Account a in db.accounts)
                        {
                            if (a.GetTransaction(t.intern) != null)
                            {
                                internT = a.GetTransaction(t.intern);
                                break;
                            }
                            account++;
                        }
                        internT.status = TransactionStatus.Skipped;
                    }

                    foreach (Account ac in db.accounts)
                        ac.RecalculateBalance();

                    UpdateGUI();
                    db.Save(dbPath);
                    return;
                }
            }
        }

        #endregion

        private void uiChecker_Tick(object sender, EventArgs e)
        {
            if (ac != vac || shouldUpdateHere)
            {
                vac = ac;
                UpdateGUI();
                shouldUpdateHere = false;
            }
        }

        private void accountOverview_TextChanged(object sender, EventArgs e)
        {
            accountNameLabel.Text = this.Text;
        }
    }
}
