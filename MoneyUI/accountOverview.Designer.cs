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
            this.accountOverviewTabs = new MaterialSkin.Controls.MaterialTabControl();
            this.overviewTab = new System.Windows.Forms.TabPage();
            this.expectedEndBalance = new MaterialSkin.Controls.MaterialLabel();
            this.expectedEndBalanceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.transactionHistoryTab = new System.Windows.Forms.TabPage();
            this.transactionHistory = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addTransactionBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.schTransactionTab = new System.Windows.Forms.TabPage();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.transactionsScheduled = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currentBalance = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.acNumLabel = new MaterialSkin.Controls.MaterialLabel();
            this.uiChecker = new System.Windows.Forms.Timer(this.components);
            this.transactionHistoryContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.accountOverviewTabs.SuspendLayout();
            this.overviewTab.SuspendLayout();
            this.transactionHistoryTab.SuspendLayout();
            this.schTransactionTab.SuspendLayout();
            this.transactionHistoryContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountOverviewTabs
            // 
            this.accountOverviewTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountOverviewTabs.Controls.Add(this.overviewTab);
            this.accountOverviewTabs.Controls.Add(this.transactionHistoryTab);
            this.accountOverviewTabs.Controls.Add(this.schTransactionTab);
            this.accountOverviewTabs.Depth = 0;
            this.accountOverviewTabs.Location = new System.Drawing.Point(-1, 110);
            this.accountOverviewTabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.accountOverviewTabs.Name = "accountOverviewTabs";
            this.accountOverviewTabs.SelectedIndex = 0;
            this.accountOverviewTabs.Size = new System.Drawing.Size(1050, 489);
            this.accountOverviewTabs.TabIndex = 0;
            // 
            // overviewTab
            // 
            this.overviewTab.Controls.Add(this.expectedEndBalance);
            this.overviewTab.Controls.Add(this.expectedEndBalanceLabel);
            this.overviewTab.Location = new System.Drawing.Point(4, 22);
            this.overviewTab.Name = "overviewTab";
            this.overviewTab.Padding = new System.Windows.Forms.Padding(3);
            this.overviewTab.Size = new System.Drawing.Size(1042, 463);
            this.overviewTab.TabIndex = 1;
            this.overviewTab.Text = "Overview";
            this.overviewTab.UseVisualStyleBackColor = true;
            // 
            // expectedEndBalance
            // 
            this.expectedEndBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.expectedEndBalance.AutoSize = true;
            this.expectedEndBalance.Depth = 0;
            this.expectedEndBalance.Font = new System.Drawing.Font("Roboto", 11F);
            this.expectedEndBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expectedEndBalance.Location = new System.Drawing.Point(169, 12);
            this.expectedEndBalance.MouseState = MaterialSkin.MouseState.HOVER;
            this.expectedEndBalance.Name = "expectedEndBalance";
            this.expectedEndBalance.Size = new System.Drawing.Size(57, 19);
            this.expectedEndBalance.TabIndex = 3;
            this.expectedEndBalance.Text = "€ 20.32";
            // 
            // expectedEndBalanceLabel
            // 
            this.expectedEndBalanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.expectedEndBalanceLabel.AutoSize = true;
            this.expectedEndBalanceLabel.Depth = 0;
            this.expectedEndBalanceLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.expectedEndBalanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expectedEndBalanceLabel.Location = new System.Drawing.Point(9, 12);
            this.expectedEndBalanceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.expectedEndBalanceLabel.Name = "expectedEndBalanceLabel";
            this.expectedEndBalanceLabel.Size = new System.Drawing.Size(154, 19);
            this.expectedEndBalanceLabel.TabIndex = 2;
            this.expectedEndBalanceLabel.Text = "Expected end-balance";
            // 
            // transactionHistoryTab
            // 
            this.transactionHistoryTab.Controls.Add(this.transactionHistory);
            this.transactionHistoryTab.Controls.Add(this.addTransactionBtn);
            this.transactionHistoryTab.Controls.Add(this.materialLabel3);
            this.transactionHistoryTab.Location = new System.Drawing.Point(4, 22);
            this.transactionHistoryTab.Name = "transactionHistoryTab";
            this.transactionHistoryTab.Size = new System.Drawing.Size(1042, 463);
            this.transactionHistoryTab.TabIndex = 2;
            this.transactionHistoryTab.Text = "Transactions";
            this.transactionHistoryTab.UseVisualStyleBackColor = true;
            // 
            // transactionHistory
            // 
            this.transactionHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader17});
            this.transactionHistory.Depth = 0;
            this.transactionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.transactionHistory.FullRowSelect = true;
            this.transactionHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.transactionHistory.Location = new System.Drawing.Point(0, 22);
            this.transactionHistory.MouseLocation = new System.Drawing.Point(-1, -1);
            this.transactionHistory.MouseState = MaterialSkin.MouseState.OUT;
            this.transactionHistory.Name = "transactionHistory";
            this.transactionHistory.OwnerDraw = true;
            this.transactionHistory.Scrollable = false;
            this.transactionHistory.Size = new System.Drawing.Size(1042, 342);
            this.transactionHistory.TabIndex = 7;
            this.transactionHistory.UseCompatibleStateImageBehavior = false;
            this.transactionHistory.View = System.Windows.Forms.View.Details;
            this.transactionHistory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.transactionHistory_MouseClick);
            this.transactionHistory.Resize += new System.EventHandler(this.materialListView2_Resize);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Description";
            this.columnHeader7.Width = 320;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Date";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Payee";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Amount";
            this.columnHeader17.Width = 132;
            // 
            // addTransactionBtn
            // 
            this.addTransactionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addTransactionBtn.AutoSize = true;
            this.addTransactionBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addTransactionBtn.Depth = 0;
            this.addTransactionBtn.Icon = null;
            this.addTransactionBtn.Location = new System.Drawing.Point(890, 420);
            this.addTransactionBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addTransactionBtn.Name = "addTransactionBtn";
            this.addTransactionBtn.Primary = true;
            this.addTransactionBtn.Size = new System.Drawing.Size(145, 36);
            this.addTransactionBtn.TabIndex = 2;
            this.addTransactionBtn.Text = "Add Transaction";
            this.addTransactionBtn.UseVisualStyleBackColor = true;
            this.addTransactionBtn.Click += new System.EventHandler(this.addTransactionBtn_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(9, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(139, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Transaction history";
            // 
            // schTransactionTab
            // 
            this.schTransactionTab.Controls.Add(this.materialRaisedButton2);
            this.schTransactionTab.Controls.Add(this.materialLabel4);
            this.schTransactionTab.Controls.Add(this.transactionsScheduled);
            this.schTransactionTab.Location = new System.Drawing.Point(4, 22);
            this.schTransactionTab.Name = "schTransactionTab";
            this.schTransactionTab.Size = new System.Drawing.Size(1042, 463);
            this.schTransactionTab.TabIndex = 3;
            this.schTransactionTab.Text = "Scheduled Transactions";
            this.schTransactionTab.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(890, 420);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(145, 36);
            this.materialRaisedButton2.TabIndex = 5;
            this.materialRaisedButton2.Text = "Add Transaction";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(9, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(166, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Scheduled transactions";
            // 
            // transactionsScheduled
            // 
            this.transactionsScheduled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionsScheduled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionsScheduled.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader15});
            this.transactionsScheduled.Depth = 0;
            this.transactionsScheduled.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.transactionsScheduled.FullRowSelect = true;
            this.transactionsScheduled.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.transactionsScheduled.Location = new System.Drawing.Point(0, 22);
            this.transactionsScheduled.MouseLocation = new System.Drawing.Point(-1, -1);
            this.transactionsScheduled.MouseState = MaterialSkin.MouseState.OUT;
            this.transactionsScheduled.Name = "transactionsScheduled";
            this.transactionsScheduled.OwnerDraw = true;
            this.transactionsScheduled.Scrollable = false;
            this.transactionsScheduled.Size = new System.Drawing.Size(1042, 392);
            this.transactionsScheduled.TabIndex = 6;
            this.transactionsScheduled.UseCompatibleStateImageBehavior = false;
            this.transactionsScheduled.View = System.Windows.Forms.View.Details;
            this.transactionsScheduled.Resize += new System.EventHandler(this.materialListView3_Resize);
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Status";
            this.columnHeader16.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Description";
            this.columnHeader11.Width = 320;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Date";
            this.columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Payee";
            this.columnHeader13.Width = 150;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Amount";
            this.columnHeader15.Width = 132;
            // 
            // currentBalance
            // 
            this.currentBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentBalance.AutoSize = true;
            this.currentBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.currentBalance.Depth = 0;
            this.currentBalance.Font = new System.Drawing.Font("Roboto", 11F);
            this.currentBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.currentBalance.Location = new System.Drawing.Point(997, 54);
            this.currentBalance.MouseState = MaterialSkin.MouseState.HOVER;
            this.currentBalance.Name = "currentBalance";
            this.currentBalance.Size = new System.Drawing.Size(49, 19);
            this.currentBalance.TabIndex = 3;
            this.currentBalance.Text = "€ 0.00";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.accountOverviewTabs;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1050, 40);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // acNumLabel
            // 
            this.acNumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.acNumLabel.AutoSize = true;
            this.acNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.acNumLabel.Depth = 0;
            this.acNumLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.acNumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.acNumLabel.Location = new System.Drawing.Point(897, 33);
            this.acNumLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.acNumLabel.Name = "acNumLabel";
            this.acNumLabel.Size = new System.Drawing.Size(149, 19);
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
            this.transactionHistoryContextMenu.Size = new System.Drawing.Size(181, 120);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.executeToolStripMenuItem.Text = "Execute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.executeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // skipToolStripMenuItem
            // 
            this.skipToolStripMenuItem.Name = "skipToolStripMenuItem";
            this.skipToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.skipToolStripMenuItem.Text = "Skip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // accountOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.currentBalance);
            this.Controls.Add(this.acNumLabel);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.accountOverviewTabs);
            this.Name = "accountOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.accountOverview_Load);
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

        private MaterialSkin.Controls.MaterialTabControl accountOverviewTabs;
        private System.Windows.Forms.TabPage overviewTab;
        private System.Windows.Forms.TabPage transactionHistoryTab;
        private System.Windows.Forms.TabPage schTransactionTab;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel expectedEndBalance;
        private MaterialSkin.Controls.MaterialLabel currentBalance;
        private MaterialSkin.Controls.MaterialLabel expectedEndBalanceLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton addTransactionBtn;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialListView transactionsScheduled;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private MaterialSkin.Controls.MaterialListView transactionHistory;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private MaterialSkin.Controls.MaterialLabel acNumLabel;
        private System.Windows.Forms.Timer uiChecker;
        private System.Windows.Forms.ContextMenuStrip transactionHistoryContextMenu;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skipToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}