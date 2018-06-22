namespace MoneyUI
{
    partial class addTransaction
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
            this.cancelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.addTransactionBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.transactionAmount = new System.Windows.Forms.NumericUpDown();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.transactionPayee = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.transactionDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.transactionDesc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.transactionDescLabel = new MaterialSkin.Controls.MaterialLabel();
            this.transactionAccount = new ComboxExtended.ImagedComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelBtn.Depth = 0;
            this.cancelBtn.Icon = null;
            this.cancelBtn.Location = new System.Drawing.Point(208, 399);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Primary = false;
            this.cancelBtn.Size = new System.Drawing.Size(73, 36);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addTransactionBtn
            // 
            this.addTransactionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addTransactionBtn.AutoSize = true;
            this.addTransactionBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addTransactionBtn.Depth = 0;
            this.addTransactionBtn.Icon = null;
            this.addTransactionBtn.Location = new System.Drawing.Point(12, 399);
            this.addTransactionBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addTransactionBtn.Name = "addTransactionBtn";
            this.addTransactionBtn.Primary = true;
            this.addTransactionBtn.Size = new System.Drawing.Size(145, 36);
            this.addTransactionBtn.TabIndex = 5;
            this.addTransactionBtn.Text = "Add Transaction";
            this.addTransactionBtn.UseVisualStyleBackColor = true;
            // 
            // transactionAmount
            // 
            this.transactionAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionAmount.DecimalPlaces = 2;
            this.transactionAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.transactionAmount.Location = new System.Drawing.Point(26, 170);
            this.transactionAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.transactionAmount.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.transactionAmount.Name = "transactionAmount";
            this.transactionAmount.Size = new System.Drawing.Size(238, 20);
            this.transactionAmount.TabIndex = 1;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(22, 79);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(65, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Account";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(22, 148);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(62, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Amount";
            // 
            // transactionPayee
            // 
            this.transactionPayee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionPayee.Depth = 0;
            this.transactionPayee.Hint = "";
            this.transactionPayee.Location = new System.Drawing.Point(26, 275);
            this.transactionPayee.MaxLength = 32767;
            this.transactionPayee.MouseState = MaterialSkin.MouseState.HOVER;
            this.transactionPayee.Name = "transactionPayee";
            this.transactionPayee.PasswordChar = '\0';
            this.transactionPayee.SelectedText = "";
            this.transactionPayee.SelectionLength = 0;
            this.transactionPayee.SelectionStart = 0;
            this.transactionPayee.Size = new System.Drawing.Size(238, 23);
            this.transactionPayee.TabIndex = 3;
            this.transactionPayee.TabStop = false;
            this.transactionPayee.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(22, 253);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Payee";
            // 
            // transactionDate
            // 
            this.transactionDate.Location = new System.Drawing.Point(26, 334);
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.Size = new System.Drawing.Size(238, 20);
            this.transactionDate.TabIndex = 4;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(25, 307);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(40, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Date";
            // 
            // transactionDesc
            // 
            this.transactionDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionDesc.Depth = 0;
            this.transactionDesc.Hint = "";
            this.transactionDesc.Location = new System.Drawing.Point(26, 221);
            this.transactionDesc.MaxLength = 32767;
            this.transactionDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.transactionDesc.Name = "transactionDesc";
            this.transactionDesc.PasswordChar = '\0';
            this.transactionDesc.SelectedText = "";
            this.transactionDesc.SelectionLength = 0;
            this.transactionDesc.SelectionStart = 0;
            this.transactionDesc.Size = new System.Drawing.Size(238, 23);
            this.transactionDesc.TabIndex = 2;
            this.transactionDesc.TabStop = false;
            this.transactionDesc.UseSystemPasswordChar = false;
            // 
            // transactionDescLabel
            // 
            this.transactionDescLabel.AutoSize = true;
            this.transactionDescLabel.Depth = 0;
            this.transactionDescLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.transactionDescLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.transactionDescLabel.Location = new System.Drawing.Point(22, 199);
            this.transactionDescLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.transactionDescLabel.Name = "transactionDescLabel";
            this.transactionDescLabel.Size = new System.Drawing.Size(86, 19);
            this.transactionDescLabel.TabIndex = 11;
            this.transactionDescLabel.Text = "Description";
            // 
            // transactionAccount
            // 
            this.transactionAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionAccount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.transactionAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transactionAccount.FormattingEnabled = true;
            this.transactionAccount.ItemHeight = 32;
            this.transactionAccount.Location = new System.Drawing.Point(26, 101);
            this.transactionAccount.Name = "transactionAccount";
            this.transactionAccount.Size = new System.Drawing.Size(238, 38);
            this.transactionAccount.TabIndex = 0;
            // 
            // addTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.transactionDesc);
            this.Controls.Add(this.transactionDescLabel);
            this.Controls.Add(this.transactionDate);
            this.Controls.Add(this.transactionPayee);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.transactionAccount);
            this.Controls.Add(this.transactionAmount);
            this.Controls.Add(this.addTransactionBtn);
            this.Controls.Add(this.cancelBtn);
            this.Name = "addTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Transaction";
            this.Load += new System.EventHandler(this.addTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton cancelBtn;
        private MaterialSkin.Controls.MaterialRaisedButton addTransactionBtn;
        private System.Windows.Forms.NumericUpDown transactionAmount;
        private ComboxExtended.ImagedComboBox transactionAccount;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField transactionPayee;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker transactionDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField transactionDesc;
        private MaterialSkin.Controls.MaterialLabel transactionDescLabel;
    }
}