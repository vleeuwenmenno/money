namespace MoneyUI
{
    partial class payeeSelector
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
            this.payeeList = new MaterialSkin.Controls.MaterialListView();
            this.addBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.payeeTxtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // payeeList
            // 
            this.payeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.payeeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.payeeList.Depth = 0;
            this.payeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.payeeList.FullRowSelect = true;
            this.payeeList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.payeeList.Location = new System.Drawing.Point(12, 125);
            this.payeeList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.payeeList.MouseState = MaterialSkin.MouseState.OUT;
            this.payeeList.Name = "payeeList";
            this.payeeList.OwnerDraw = true;
            this.payeeList.Size = new System.Drawing.Size(295, 313);
            this.payeeList.TabIndex = 0;
            this.payeeList.UseCompatibleStateImageBehavior = false;
            this.payeeList.View = System.Windows.Forms.View.Details;
            this.payeeList.DoubleClick += new System.EventHandler(this.payeeList_DoubleClick);
            this.payeeList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.payeeList_MouseClick);
            this.payeeList.Resize += new System.EventHandler(this.payeeList_Resize);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.AutoSize = true;
            this.addBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBtn.Depth = 0;
            this.addBtn.Icon = null;
            this.addBtn.Location = new System.Drawing.Point(259, 80);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addBtn.Name = "addBtn";
            this.addBtn.Primary = false;
            this.addBtn.Size = new System.Drawing.Size(48, 36);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // payeeTxtBox
            // 
            this.payeeTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payeeTxtBox.Depth = 0;
            this.payeeTxtBox.Hint = "";
            this.payeeTxtBox.Location = new System.Drawing.Point(12, 90);
            this.payeeTxtBox.MaxLength = 32767;
            this.payeeTxtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.payeeTxtBox.Name = "payeeTxtBox";
            this.payeeTxtBox.PasswordChar = '\0';
            this.payeeTxtBox.SelectedText = "";
            this.payeeTxtBox.SelectionLength = 0;
            this.payeeTxtBox.SelectionStart = 0;
            this.payeeTxtBox.Size = new System.Drawing.Size(240, 23);
            this.payeeTxtBox.TabIndex = 2;
            this.payeeTxtBox.TabStop = false;
            this.payeeTxtBox.UseSystemPasswordChar = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Payee";
            this.columnHeader1.Width = 295;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // payeeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.Controls.Add(this.payeeTxtBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.payeeList);
            this.Name = "payeeSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Payee";
            this.Load += new System.EventHandler(this.payeeSelector_Load);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView payeeList;
        private MaterialSkin.Controls.MaterialFlatButton addBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField payeeTxtBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}