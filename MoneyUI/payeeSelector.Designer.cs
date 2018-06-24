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
            this.components = new System.ComponentModel.Container();
            this.addBtn = new System.Windows.Forms.Button();
            this.payeeTxtBox = new System.Windows.Forms.TextBox();
            this.materialContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payeeList = new System.Windows.Forms.ListView();
            this.payeeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.AutoSize = true;
            this.addBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBtn.Location = new System.Drawing.Point(275, 12);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(36, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // payeeTxtBox
            // 
            this.payeeTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payeeTxtBox.Location = new System.Drawing.Point(12, 12);
            this.payeeTxtBox.Name = "payeeTxtBox";
            this.payeeTxtBox.Size = new System.Drawing.Size(256, 20);
            this.payeeTxtBox.TabIndex = 2;
            this.payeeTxtBox.TabStop = false;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // payeeList
            // 
            this.payeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payeeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.payeeColumn});
            this.payeeList.Location = new System.Drawing.Point(0, 44);
            this.payeeList.Name = "payeeList";
            this.payeeList.Size = new System.Drawing.Size(324, 406);
            this.payeeList.TabIndex = 3;
            this.payeeList.UseCompatibleStateImageBehavior = false;
            this.payeeList.View = System.Windows.Forms.View.Details;
            this.payeeList.DoubleClick += new System.EventHandler(this.payeeList_DoubleClick);
            this.payeeList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.payeeList_MouseClick);
            // 
            // payeeColumn
            // 
            this.payeeColumn.Text = "Payee";
            this.payeeColumn.Width = 320;
            // 
            // payeeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 450);
            this.Controls.Add(this.payeeList);
            this.Controls.Add(this.payeeTxtBox);
            this.Controls.Add(this.addBtn);
            this.Name = "payeeSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Payee";
            this.Load += new System.EventHandler(this.payeeSelector_Load);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox payeeTxtBox;
        private System.Windows.Forms.ContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ListView payeeList;
        private System.Windows.Forms.ColumnHeader payeeColumn;
    }
}