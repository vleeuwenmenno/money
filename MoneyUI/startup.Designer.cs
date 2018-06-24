namespace MoneyUI
{
    partial class startup
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
            this.loadDbBtn = new System.Windows.Forms.Button();
            this.newDbBtn = new System.Windows.Forms.Button();
            this.startupExitBtn = new System.Windows.Forms.Button();
            this.rightMouseMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentsList = new System.Windows.Forms.ListView();
            this.dbNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dbLocationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightMouseMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadDbBtn
            // 
            this.loadDbBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadDbBtn.AutoSize = true;
            this.loadDbBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadDbBtn.Location = new System.Drawing.Point(12, 280);
            this.loadDbBtn.Name = "loadDbBtn";
            this.loadDbBtn.Size = new System.Drawing.Size(52, 23);
            this.loadDbBtn.TabIndex = 7;
            this.loadDbBtn.Text = "Browse";
            this.loadDbBtn.UseVisualStyleBackColor = true;
            this.loadDbBtn.Click += new System.EventHandler(this.loadDbBtn_Click);
            // 
            // newDbBtn
            // 
            this.newDbBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newDbBtn.AutoSize = true;
            this.newDbBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newDbBtn.Location = new System.Drawing.Point(71, 280);
            this.newDbBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.newDbBtn.Name = "newDbBtn";
            this.newDbBtn.Size = new System.Drawing.Size(88, 23);
            this.newDbBtn.TabIndex = 7;
            this.newDbBtn.Text = "New Database";
            this.newDbBtn.UseVisualStyleBackColor = true;
            this.newDbBtn.Click += new System.EventHandler(this.newDbBtn_Click);
            // 
            // startupExitBtn
            // 
            this.startupExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startupExitBtn.AutoSize = true;
            this.startupExitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startupExitBtn.Location = new System.Drawing.Point(582, 280);
            this.startupExitBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startupExitBtn.Name = "startupExitBtn";
            this.startupExitBtn.Size = new System.Drawing.Size(34, 23);
            this.startupExitBtn.TabIndex = 4;
            this.startupExitBtn.Text = "Exit";
            this.startupExitBtn.UseVisualStyleBackColor = true;
            this.startupExitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // rightMouseMenu
            // 
            this.rightMouseMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.rightMouseMenu.Name = "rightMouseMenu";
            this.rightMouseMenu.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // recentsList
            // 
            this.recentsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recentsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dbNameColumn,
            this.dbLocationColumn});
            this.recentsList.FullRowSelect = true;
            this.recentsList.Location = new System.Drawing.Point(12, 12);
            this.recentsList.Name = "recentsList";
            this.recentsList.Size = new System.Drawing.Size(604, 259);
            this.recentsList.TabIndex = 8;
            this.recentsList.UseCompatibleStateImageBehavior = false;
            this.recentsList.View = System.Windows.Forms.View.Details;
            this.recentsList.DoubleClick += new System.EventHandler(this.recentsList_DoubleClick);
            this.recentsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.recentsList_MouseClick);
            // 
            // dbNameColumn
            // 
            this.dbNameColumn.Text = "Database name";
            this.dbNameColumn.Width = 240;
            // 
            // dbLocationColumn
            // 
            this.dbLocationColumn.Text = "File Location";
            this.dbLocationColumn.Width = 360;
            // 
            // startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 314);
            this.Controls.Add(this.recentsList);
            this.Controls.Add(this.loadDbBtn);
            this.Controls.Add(this.newDbBtn);
            this.Controls.Add(this.startupExitBtn);
            this.Name = "startup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money";
            this.Load += new System.EventHandler(this.startup_Load);
            this.rightMouseMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newDbBtn;
        private System.Windows.Forms.Button startupExitBtn;
        private System.Windows.Forms.Button loadDbBtn;
        private System.Windows.Forms.ContextMenuStrip rightMouseMenu;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ListView recentsList;
        private System.Windows.Forms.ColumnHeader dbNameColumn;
        private System.Windows.Forms.ColumnHeader dbLocationColumn;
    }
}

