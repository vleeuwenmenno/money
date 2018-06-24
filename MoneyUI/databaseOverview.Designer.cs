using System;

namespace MoneyUI
{
    partial class databaseOverview
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
            this.addAccountBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiChecker = new System.Windows.Forms.Timer(this.components);
            this.monthBackBtn = new System.Windows.Forms.Button();
            this.monthForwardBtn = new System.Windows.Forms.Button();
            this.monthLabel = new System.Windows.Forms.Label();
            this.syncBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.accountListView = new System.Windows.Forms.ListView();
            this.accountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.balanceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addAccountBtn
            // 
            this.addAccountBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addAccountBtn.AutoSize = true;
            this.addAccountBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addAccountBtn.Location = new System.Drawing.Point(13, 423);
            this.addAccountBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addAccountBtn.Name = "addAccountBtn";
            this.addAccountBtn.Size = new System.Drawing.Size(78, 23);
            this.addAccountBtn.TabIndex = 1;
            this.addAccountBtn.Text = "Add account";
            this.addAccountBtn.UseVisualStyleBackColor = true;
            this.addAccountBtn.Click += new System.EventHandler(this.addAccountBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBtn.AutoSize = true;
            this.settingsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsBtn.Location = new System.Drawing.Point(224, 423);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(55, 23);
            this.settingsBtn.TabIndex = 1;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // uiChecker
            // 
            this.uiChecker.Enabled = true;
            this.uiChecker.Tick += new System.EventHandler(this.uiChecker_Tick);
            // 
            // monthBackBtn
            // 
            this.monthBackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.monthBackBtn.AutoSize = true;
            this.monthBackBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.monthBackBtn.BackColor = System.Drawing.SystemColors.Control;
            this.monthBackBtn.Location = new System.Drawing.Point(13, 388);
            this.monthBackBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.monthBackBtn.Name = "monthBackBtn";
            this.monthBackBtn.Size = new System.Drawing.Size(23, 23);
            this.monthBackBtn.TabIndex = 8;
            this.monthBackBtn.Text = "<";
            this.monthBackBtn.UseVisualStyleBackColor = false;
            this.monthBackBtn.Click += new System.EventHandler(this.monthBackBtn_Click);
            // 
            // monthForwardBtn
            // 
            this.monthForwardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.monthForwardBtn.AutoSize = true;
            this.monthForwardBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.monthForwardBtn.BackColor = System.Drawing.SystemColors.Control;
            this.monthForwardBtn.Location = new System.Drawing.Point(256, 388);
            this.monthForwardBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.monthForwardBtn.Name = "monthForwardBtn";
            this.monthForwardBtn.Size = new System.Drawing.Size(23, 23);
            this.monthForwardBtn.TabIndex = 7;
            this.monthForwardBtn.Text = ">";
            this.monthForwardBtn.UseVisualStyleBackColor = false;
            this.monthForwardBtn.Click += new System.EventHandler(this.monthForwardBtn_Click);
            // 
            // monthLabel
            // 
            this.monthLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.monthLabel.AutoSize = true;
            this.monthLabel.BackColor = System.Drawing.Color.Transparent;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.monthLabel.Location = new System.Drawing.Point(108, 391);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(84, 20);
            this.monthLabel.TabIndex = 6;
            this.monthLabel.Text = "June 2018";
            this.monthLabel.Click += new System.EventHandler(this.monthLabel_Click);
            // 
            // syncBtn
            // 
            this.syncBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.syncBtn.AutoSize = true;
            this.syncBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.syncBtn.Location = new System.Drawing.Point(175, 423);
            this.syncBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.syncBtn.Name = "syncBtn";
            this.syncBtn.Size = new System.Drawing.Size(41, 23);
            this.syncBtn.TabIndex = 9;
            this.syncBtn.Text = "Sync";
            this.syncBtn.UseVisualStyleBackColor = true;
            this.syncBtn.Visible = false;
            this.syncBtn.Click += new System.EventHandler(this.syncBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.MarqueeAnimationSpeed = 20;
            this.progressBar.Maximum = 200;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(292, 2);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 13;
            this.progressBar.Visible = false;
            // 
            // accountListView
            // 
            this.accountListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.accountColumn,
            this.balanceColumn});
            this.accountListView.FullRowSelect = true;
            this.accountListView.Location = new System.Drawing.Point(0, 0);
            this.accountListView.Name = "accountListView";
            this.accountListView.Size = new System.Drawing.Size(292, 379);
            this.accountListView.TabIndex = 14;
            this.accountListView.UseCompatibleStateImageBehavior = false;
            this.accountListView.View = System.Windows.Forms.View.Details;
            this.accountListView.SelectedIndexChanged += new System.EventHandler(this.accountListView_SelectedIndexChanged);
            this.accountListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.accountListView_MouseClick);
            // 
            // accountColumn
            // 
            this.accountColumn.Text = "Account";
            this.accountColumn.Width = 200;
            // 
            // balanceColumn
            // 
            this.balanceColumn.Text = "Balance";
            this.balanceColumn.Width = 88;
            // 
            // databaseOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 461);
            this.Controls.Add(this.accountListView);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.syncBtn);
            this.Controls.Add(this.monthBackBtn);
            this.Controls.Add(this.monthForwardBtn);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.addAccountBtn);
            this.Name = "databaseOverview";
            this.Text = "Database Overview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.databaseOverview_FormClosing);
            this.Load += new System.EventHandler(this.databaseOverview_Load);
            this.LocationChanged += new System.EventHandler(this.databaseOverview_LocationChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addAccountBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Timer uiChecker;
        private System.Windows.Forms.Button monthBackBtn;
        private System.Windows.Forms.Button monthForwardBtn;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Button syncBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListView accountListView;
        private System.Windows.Forms.ColumnHeader accountColumn;
        private System.Windows.Forms.ColumnHeader balanceColumn;
    }
}