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
            this.addAccountBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.exitBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.settingsBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.accountListView = new MaterialSkin.Controls.MaterialListView();
            this.accountName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accountBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiChecker = new System.Windows.Forms.Timer(this.components);
            this.monthBackBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.monthForwardBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.monthLabel = new MaterialSkin.Controls.MaterialLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addAccountBtn
            // 
            this.addAccountBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addAccountBtn.AutoSize = true;
            this.addAccountBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addAccountBtn.Depth = 0;
            this.addAccountBtn.Icon = null;
            this.addAccountBtn.Location = new System.Drawing.Point(13, 549);
            this.addAccountBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addAccountBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addAccountBtn.Name = "addAccountBtn";
            this.addAccountBtn.Primary = false;
            this.addAccountBtn.Size = new System.Drawing.Size(115, 36);
            this.addAccountBtn.TabIndex = 1;
            this.addAccountBtn.Text = "Add Account";
            this.addAccountBtn.UseVisualStyleBackColor = true;
            this.addAccountBtn.Click += new System.EventHandler(this.addAccountBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.AutoSize = true;
            this.exitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitBtn.Depth = 0;
            this.exitBtn.Icon = null;
            this.exitBtn.Location = new System.Drawing.Point(229, 549);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exitBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Primary = false;
            this.exitBtn.Size = new System.Drawing.Size(50, 36);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBtn.AutoSize = true;
            this.settingsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsBtn.Depth = 0;
            this.settingsBtn.Icon = null;
            this.settingsBtn.Location = new System.Drawing.Point(136, 549);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.settingsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Primary = false;
            this.settingsBtn.Size = new System.Drawing.Size(85, 36);
            this.settingsBtn.TabIndex = 1;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // accountListView
            // 
            this.accountListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.accountName,
            this.accountBalance});
            this.accountListView.Depth = 0;
            this.accountListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.accountListView.FullRowSelect = true;
            this.accountListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.accountListView.Location = new System.Drawing.Point(1, 67);
            this.accountListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.accountListView.MouseState = MaterialSkin.MouseState.OUT;
            this.accountListView.Name = "accountListView";
            this.accountListView.OwnerDraw = true;
            this.accountListView.Size = new System.Drawing.Size(290, 428);
            this.accountListView.TabIndex = 4;
            this.accountListView.UseCompatibleStateImageBehavior = false;
            this.accountListView.View = System.Windows.Forms.View.Details;
            this.accountListView.SelectedIndexChanged += new System.EventHandler(this.accountListView_SelectedIndexChanged);
            this.accountListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.accountListView_MouseClick);
            // 
            // accountName
            // 
            this.accountName.Text = "Account";
            this.accountName.Width = 170;
            // 
            // accountBalance
            // 
            this.accountBalance.Text = "Balance";
            this.accountBalance.Width = 120;
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
            this.monthBackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthBackBtn.AutoSize = true;
            this.monthBackBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.monthBackBtn.BackColor = System.Drawing.SystemColors.Control;
            this.monthBackBtn.Depth = 0;
            this.monthBackBtn.Icon = null;
            this.monthBackBtn.Location = new System.Drawing.Point(13, 504);
            this.monthBackBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.monthBackBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.monthBackBtn.Name = "monthBackBtn";
            this.monthBackBtn.Primary = false;
            this.monthBackBtn.Size = new System.Drawing.Size(28, 36);
            this.monthBackBtn.TabIndex = 8;
            this.monthBackBtn.Text = "<";
            this.monthBackBtn.UseVisualStyleBackColor = false;
            this.monthBackBtn.Click += new System.EventHandler(this.monthBackBtn_Click);
            // 
            // monthForwardBtn
            // 
            this.monthForwardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthForwardBtn.AutoSize = true;
            this.monthForwardBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.monthForwardBtn.BackColor = System.Drawing.SystemColors.Control;
            this.monthForwardBtn.Depth = 0;
            this.monthForwardBtn.Icon = null;
            this.monthForwardBtn.Location = new System.Drawing.Point(251, 504);
            this.monthForwardBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.monthForwardBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.monthForwardBtn.Name = "monthForwardBtn";
            this.monthForwardBtn.Primary = false;
            this.monthForwardBtn.Size = new System.Drawing.Size(28, 36);
            this.monthForwardBtn.TabIndex = 7;
            this.monthForwardBtn.Text = ">";
            this.monthForwardBtn.UseVisualStyleBackColor = false;
            this.monthForwardBtn.Click += new System.EventHandler(this.monthForwardBtn_Click);
            // 
            // monthLabel
            // 
            this.monthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthLabel.AutoSize = true;
            this.monthLabel.BackColor = System.Drawing.Color.Transparent;
            this.monthLabel.Depth = 0;
            this.monthLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.monthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.monthLabel.Location = new System.Drawing.Point(99, 512);
            this.monthLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(108, 19);
            this.monthLabel.TabIndex = 6;
            this.monthLabel.Text = "materialLabel2";
            this.monthLabel.Click += new System.EventHandler(this.monthLabel_Click);
            // 
            // databaseOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 600);
            this.Controls.Add(this.monthBackBtn);
            this.Controls.Add(this.monthForwardBtn);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.addAccountBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.accountListView);
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
        private MaterialSkin.Controls.MaterialFlatButton addAccountBtn;
        private MaterialSkin.Controls.MaterialFlatButton exitBtn;
        private MaterialSkin.Controls.MaterialFlatButton settingsBtn;
        private MaterialSkin.Controls.MaterialListView accountListView;
        private System.Windows.Forms.ColumnHeader accountName;
        private System.Windows.Forms.ColumnHeader accountBalance;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Timer uiChecker;
        private MaterialSkin.Controls.MaterialFlatButton monthBackBtn;
        private MaterialSkin.Controls.MaterialFlatButton monthForwardBtn;
        private MaterialSkin.Controls.MaterialLabel monthLabel;
    }
}