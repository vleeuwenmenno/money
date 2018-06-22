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
            this.loadDbBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.newDbBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.startupExitBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.recentsList = new MaterialSkin.Controls.MaterialListView();
            this.dbName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightMouseMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // loadDbBtn
            // 
            this.loadDbBtn.AutoSize = true;
            this.loadDbBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadDbBtn.Depth = 0;
            this.loadDbBtn.Icon = null;
            this.loadDbBtn.Location = new System.Drawing.Point(105, 402);
            this.loadDbBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loadDbBtn.Name = "loadDbBtn";
            this.loadDbBtn.Primary = true;
            this.loadDbBtn.Size = new System.Drawing.Size(76, 36);
            this.loadDbBtn.TabIndex = 7;
            this.loadDbBtn.Text = "Browse";
            this.loadDbBtn.UseVisualStyleBackColor = true;
            this.loadDbBtn.Click += new System.EventHandler(this.loadDbBtn_Click);
            // 
            // newDbBtn
            // 
            this.newDbBtn.AutoSize = true;
            this.newDbBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newDbBtn.Depth = 0;
            this.newDbBtn.Icon = null;
            this.newDbBtn.Location = new System.Drawing.Point(187, 402);
            this.newDbBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.newDbBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.newDbBtn.Name = "newDbBtn";
            this.newDbBtn.Primary = false;
            this.newDbBtn.Size = new System.Drawing.Size(123, 36);
            this.newDbBtn.TabIndex = 7;
            this.newDbBtn.Text = "New Database";
            this.newDbBtn.UseVisualStyleBackColor = true;
            this.newDbBtn.Click += new System.EventHandler(this.newDbBtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(101, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Recents";
            // 
            // startupExitBtn
            // 
            this.startupExitBtn.AutoSize = true;
            this.startupExitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startupExitBtn.Depth = 0;
            this.startupExitBtn.Icon = null;
            this.startupExitBtn.Location = new System.Drawing.Point(664, 399);
            this.startupExitBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startupExitBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.startupExitBtn.Name = "startupExitBtn";
            this.startupExitBtn.Primary = false;
            this.startupExitBtn.Size = new System.Drawing.Size(50, 36);
            this.startupExitBtn.TabIndex = 4;
            this.startupExitBtn.Text = "Exit";
            this.startupExitBtn.UseVisualStyleBackColor = true;
            this.startupExitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // recentsList
            // 
            this.recentsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recentsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dbName,
            this.filePath});
            this.recentsList.Depth = 0;
            this.recentsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.recentsList.FullRowSelect = true;
            this.recentsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.recentsList.Location = new System.Drawing.Point(105, 110);
            this.recentsList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.recentsList.MouseState = MaterialSkin.MouseState.OUT;
            this.recentsList.Name = "recentsList";
            this.recentsList.OwnerDraw = true;
            this.recentsList.Size = new System.Drawing.Size(609, 280);
            this.recentsList.TabIndex = 5;
            this.recentsList.UseCompatibleStateImageBehavior = false;
            this.recentsList.View = System.Windows.Forms.View.Details;
            this.recentsList.DoubleClick += new System.EventHandler(this.recentsList_DoubleClick);
            this.recentsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.recentsList_MouseClick);
            // 
            // dbName
            // 
            this.dbName.Text = "Name";
            this.dbName.Width = 180;
            // 
            // filePath
            // 
            this.filePath.Text = "Location";
            this.filePath.Width = 429;
            // 
            // rightMouseMenu
            // 
            this.rightMouseMenu.Name = "rightMouseMenu";
            this.rightMouseMenu.Size = new System.Drawing.Size(181, 26);
            // 
            // startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadDbBtn);
            this.Controls.Add(this.newDbBtn);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.recentsList);
            this.Controls.Add(this.startupExitBtn);
            this.Name = "startup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money";
            this.Load += new System.EventHandler(this.startup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton newDbBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton startupExitBtn;
        private MaterialSkin.Controls.MaterialListView recentsList;
        private System.Windows.Forms.ColumnHeader dbName;
        private System.Windows.Forms.ColumnHeader filePath;
        private MaterialSkin.Controls.MaterialRaisedButton loadDbBtn;
        private System.Windows.Forms.ContextMenuStrip rightMouseMenu;
    }
}

