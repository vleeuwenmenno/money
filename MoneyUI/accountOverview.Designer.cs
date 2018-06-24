namespace MoneyUI
{
    partial class accountOverview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.accountOverviewTabs = new System.Windows.Forms.TabControl();
            this.overviewTab = new System.Windows.Forms.TabPage();
            this.expectedEndBalance = new System.Windows.Forms.Label();
            this.expectedEndBalanceLabel = new System.Windows.Forms.Label();
            this.transactionHistoryTab = new System.Windows.Forms.TabPage();
            this.transactionHistory = new System.Windows.Forms.ListView();
            this.statusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.payeeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addTransactionBtn = new System.Windows.Forms.Button();
            this.schTransactionTab = new System.Windows.Forms.TabPage();
            this.transactionsScheduled = new System.Windows.Forms.ListView();
            this.schDescColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schStartColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schRepeatColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schPayeeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schAmountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialRaisedButton2 = new System.Windows.Forms.Button();
            this.currentBalance = new System.Windows.Forms.Label();
            this.acNumLabel = new System.Windows.Forms.Label();
            this.uiChecker = new System.Windows.Forms.Timer(this.components);
            this.transactionHistoryContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.accountOverviewTabs.SuspendLayout();
            this.overviewTab.SuspendLayout();
            this.transactionHistoryTab.SuspendLayout();
            this.schTransactionTab.SuspendLayout();
            this.transactionHistoryContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountOverviewTabs
            // 
            this.accountOverviewTabs.Controls.Add(this.overviewTab);
            this.accountOverviewTabs.Controls.Add(this.transactionHistoryTab);
            this.accountOverviewTabs.Controls.Add(this.schTransactionTab);
            this.accountOverviewTabs.Location = new System.Drawing.Point(12, 32);
            this.accountOverviewTabs.Name = "accountOverviewTabs";
            this.accountOverviewTabs.SelectedIndex = 0;
            this.accountOverviewTabs.Size = new System.Drawing.Size(1026, 417);
            this.accountOverviewTabs.TabIndex = 0;
            // 
            // overviewTab
            // 
            this.overviewTab.Controls.Add(this.expectedEndBalance);
            this.overviewTab.Controls.Add(this.expectedEndBalanceLabel);
            this.overviewTab.Location = new System.Drawing.Point(4, 22);
            this.overviewTab.Name = "overviewTab";
            this.overviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.overviewTab.Size = new System.Drawing.Size(1018, 391);
            this.overviewTab.TabIndex = 1;
            this.overviewTab.Text = "Overview";
            this.overviewTab.UseVisualStyleBackColor = true;
            // 
            // expectedEndBalance
            // 
            this.expectedEndBalance.AutoSize = true;
            this.expectedEndBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.expectedEndBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expectedEndBalance.Location = new System.Drawing.Point(9, 24);
            this.expectedEndBalance.Name = "expectedEndBalance";
            this.expectedEndBalance.Size = new System.Drawing.Size(48, 18);
            this.expectedEndBalance.TabIndex = 3;
            this.expectedEndBalance.Text = "€ 0.00";
            // 
            // expectedEndBalanceLabel
            // 
            this.expectedEndBalanceLabel.AutoSize = true;
            this.expectedEndBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.expectedEndBalanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expectedEndBalanceLabel.Location = new System.Drawing.Point(9, 5);
            this.expectedEndBalanceLabel.Name = "expectedEndBalanceLabel";
            this.expectedEndBalanceLabel.Size = new System.Drawing.Size(153, 18);
            this.expectedEndBalanceLabel.TabIndex = 2;
            this.expectedEndBalanceLabel.Text = "Expected end-balance";
            // 
            // transactionHistoryTab
            // 
            this.transactionHistoryTab.Controls.Add(this.transactionHistory);
            this.transactionHistoryTab.Controls.Add(this.addTransactionBtn);
            this.transactionHistoryTab.Location = new System.Drawing.Point(4, 22);
            this.transactionHistoryTab.Name = "transactionHistoryTab";
            this.transactionHistoryTab.Size = new System.Drawing.Size(1018, 372);
            this.transactionHistoryTab.TabIndex = 2;
            this.transactionHistoryTab.Text = "Transactions";
            this.transactionHistoryTab.UseVisualStyleBackColor = true;
            // 
            // transactionHistory
            // 
            this.transactionHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.statusColumn,
            this.descColumn,
            this.dataColumn,
            this.payeeColumn,
            this.amountColumn});
            this.transactionHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.transactionHistory.FullRowSelect = true;
            this.transactionHistory.Location = new System.Drawing.Point(0, 0);
            this.transactionHistory.Name = "transactionHistory";
            this.transactionHistory.Size = new System.Drawing.Size(1018, 340);
            this.transactionHistory.TabIndex = 8;
            this.transactionHistory.UseCompatibleStateImageBehavior = false;
            this.transactionHistory.View = System.Windows.Forms.View.Details;
            this.transactionHistory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.transactionHistory_MouseClick);
            this.transactionHistory.Resize += new System.EventHandler(this.transactionHistory_Resize);
            // 
            // statusColumn
            // 
            this.statusColumn.Text = "Status";
            // 
            // descColumn
            // 
            this.descColumn.Text = "Descriptions";
            // 
            // dataColumn
            // 
            this.dataColumn.Text = "Date";
            // 
            // payeeColumn
            // 
            this.payeeColumn.Text = "Payee";
            // 
            // amountColumn
            // 
            this.amountColumn.Text = "Amount";
            // 
            // addTransactionBtn
            // 
            this.addTransactionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addTransactionBtn.AutoSize = true;
            this.addTransactionBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addTransactionBtn.Location = new System.Drawing.Point(920, 346);
            this.addTransactionBtn.Name = "addTransactionBtn";
            this.addTransactionBtn.Size = new System.Drawing.Size(95, 23);
            this.addTransactionBtn.TabIndex = 2;
            this.addTransactionBtn.Text = "Add Transaction";
            this.addTransactionBtn.UseVisualStyleBackColor = true;
            this.addTransactionBtn.Click += new System.EventHandler(this.addTransactionBtn_Click);
            // 
            // schTransactionTab
            // 
            this.schTransactionTab.Controls.Add(this.transactionsScheduled);
            this.schTransactionTab.Controls.Add(this.materialRaisedButton2);
            this.schTransactionTab.Location = new System.Drawing.Point(4, 22);
            this.schTransactionTab.Name = "schTransactionTab";
            this.schTransactionTab.Size = new System.Drawing.Size(1018, 372);
            this.schTransactionTab.TabIndex = 3;
            this.schTransactionTab.Text = "Scheduled Transactions";
            this.schTransactionTab.UseVisualStyleBackColor = true;
            // 
            // transactionsScheduled
            // 
            this.transactionsScheduled.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.transactionsScheduled.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.schDescColumn,
            this.schStartColumn,
            this.schRepeatColumn,
            this.schPayeeColumn,
            this.schAmountColumn});
            this.transactionsScheduled.Dock = System.Windows.Forms.DockStyle.Top;
            this.transactionsScheduled.FullRowSelect = true;
            this.transactionsScheduled.Location = new System.Drawing.Point(0, 0);
            this.transactionsScheduled.Name = "transactionsScheduled";
            this.transactionsScheduled.Size = new System.Drawing.Size(1018, 340);
            this.transactionsScheduled.TabIndex = 7;
            this.transactionsScheduled.UseCompatibleStateImageBehavior = false;
            this.transactionsScheduled.View = System.Windows.Forms.View.Details;
            this.transactionsScheduled.Resize += new System.EventHandler(this.transactionsScheduled_Resize);
            // 
            // schDescColumn
            // 
            this.schDescColumn.Text = "Description";
            // 
            // schStartColumn
            // 
            this.schStartColumn.Text = "Start date";
            // 
            // schRepeatColumn
            // 
            this.schRepeatColumn.Text = "Repeat";
            // 
            // schPayeeColumn
            // 
            this.schPayeeColumn.Text = "Payee";
            // 
            // schAmountColumn
            // 
            this.schAmountColumn.Text = "Amount";
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Location = new System.Drawing.Point(866, 346);
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Size = new System.Drawing.Size(149, 23);
            this.materialRaisedButton2.TabIndex = 5;
            this.materialRaisedButton2.Text = "Add Scheduled Transaction";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // currentBalance
            // 
            this.currentBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentBalance.AutoSize = true;
            this.currentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.currentBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.currentBalance.Location = new System.Drawing.Point(990, 30);
            this.currentBalance.Name = "currentBalance";
            this.currentBalance.Size = new System.Drawing.Size(48, 18);
            this.currentBalance.TabIndex = 3;
            this.currentBalance.Text = "€ 0.00";
            // 
            // acNumLabel
            // 
            this.acNumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.acNumLabel.AutoSize = true;
            this.acNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.acNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.acNumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.acNumLabel.Location = new System.Drawing.Point(890, 9);
            this.acNumLabel.Name = "acNumLabel";
            this.acNumLabel.Size = new System.Drawing.Size(148, 18);
            this.acNumLabel.TabIndex = 2;
            this.acNumLabel.Text = "0000 0000 0000 0000";
            // 
            // uiChecker
            // 
            this.uiChecker.Enabled = true;
            this.uiChecker.Tick += new System.EventHandler(this.uiChecker_Tick);
            // 
            // transactionHistoryContextMenu
            // 
            this.transactionHistoryContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executeToolStripMenuItem,
            this.skipToolStripMenuItem,
            this.toolStripSeparator1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.transactionHistoryContextMenu.Name = "transactionHistoryContextMenu";
            this.transactionHistoryContextMenu.Size = new System.Drawing.Size(115, 98);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.executeToolStripMenuItem.Text = "Execute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.executeToolStripMenuItem_Click);
            // 
            // skipToolStripMenuItem
            // 
            this.skipToolStripMenuItem.Name = "skipToolStripMenuItem";
            this.skipToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.skipToolStripMenuItem.Text = "Skip";
            this.skipToolStripMenuItem.Click += new System.EventHandler(this.skipToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameLabel.Location = new System.Drawing.Point(12, 9);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(147, 20);
            this.accountNameLabel.TabIndex = 4;
            this.accountNameLabel.Text = "accountNameLabel";
            // 
            // accountOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 461);
            this.Controls.Add(this.accountNameLabel);
            this.Controls.Add(this.currentBalance);
            this.Controls.Add(this.acNumLabel);
            this.Controls.Add(this.accountOverviewTabs);
            this.Name = "accountOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.accountOverview_Load);
            this.TextChanged += new System.EventHandler(this.accountOverview_TextChanged);
            this.accountOverviewTabs.ResumeLayout(false);
            this.overviewTab.ResumeLayout(false);
            this.overviewTab.PerformLayout();
            this.transactionHistoryTab.ResumeLayout(false);
            this.transactionHistoryTab.PerformLayout();
            this.schTransactionTab.ResumeLayout(false);
            this.schTransactionTab.PerformLayout();
            this.transactionHistoryContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl accountOverviewTabs;
        private System.Windows.Forms.TabPage overviewTab;
        private System.Windows.Forms.TabPage transactionHistoryTab;
        private System.Windows.Forms.TabPage schTransactionTab;
        private System.Windows.Forms.Label expectedEndBalance;
        private System.Windows.Forms.Label currentBalance;
        private System.Windows.Forms.Label expectedEndBalanceLabel;
        private System.Windows.Forms.Button addTransactionBtn;
        private System.Windows.Forms.Button materialRaisedButton2;
        private System.Windows.Forms.Label acNumLabel;
        private System.Windows.Forms.Timer uiChecker;
        private System.Windows.Forms.ContextMenuStrip transactionHistoryContextMenu;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skipToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ListView transactionHistory;
        private System.Windows.Forms.ColumnHeader descColumn;
        private System.Windows.Forms.ColumnHeader dataColumn;
        private System.Windows.Forms.ColumnHeader payeeColumn;
        private System.Windows.Forms.ColumnHeader amountColumn;
        private System.Windows.Forms.ColumnHeader statusColumn;
        private System.Windows.Forms.ListView transactionsScheduled;
        private System.Windows.Forms.ColumnHeader schDescColumn;
        private System.Windows.Forms.ColumnHeader schStartColumn;
        private System.Windows.Forms.ColumnHeader schRepeatColumn;
        private System.Windows.Forms.ColumnHeader schPayeeColumn;
        private System.Windows.Forms.ColumnHeader schAmountColumn;
        private System.Windows.Forms.Label accountNameLabel;
    }
}