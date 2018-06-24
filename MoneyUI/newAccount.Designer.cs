namespace MoneyUI
{
    partial class newAccount
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
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.currencyTxt = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new System.Windows.Forms.Label();
            this.accountNameTxt = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new System.Windows.Forms.Label();
            this.initialBalance = new System.Windows.Forms.NumericUpDown();
            this.materialLabel4 = new System.Windows.Forms.Label();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.accountNumberTxt = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new System.Windows.Forms.Label();
            this.accountTypeCombo = new ComboxExtended.ImagedComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.initialBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(26, 29);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(100, 13);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Add a new account";
            // 
            // continueBtn
            // 
            this.continueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.continueBtn.AutoSize = true;
            this.continueBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.continueBtn.Location = new System.Drawing.Point(378, 219);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(59, 23);
            this.continueBtn.TabIndex = 4;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelBtn.Location = new System.Drawing.Point(444, 219);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(50, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // currencyTxt
            // 
            this.currencyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyTxt.FormattingEnabled = true;
            this.currencyTxt.Location = new System.Drawing.Point(261, 132);
            this.currencyTxt.Name = "currencyTxt";
            this.currencyTxt.Size = new System.Drawing.Size(200, 21);
            this.currencyTxt.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(257, 110);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 13);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Currency";
            // 
            // accountNameTxt
            // 
            this.accountNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNameTxt.Location = new System.Drawing.Point(41, 70);
            this.accountNameTxt.Name = "accountNameTxt";
            this.accountNameTxt.Size = new System.Drawing.Size(200, 20);
            this.accountNameTxt.TabIndex = 0;
            this.accountNameTxt.TabStop = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(37, 48);
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(76, 13);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Account name";
            // 
            // initialBalance
            // 
            this.initialBalance.DecimalPlaces = 2;
            this.initialBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialBalance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.initialBalance.Location = new System.Drawing.Point(41, 166);
            this.initialBalance.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.initialBalance.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.initialBalance.Name = "initialBalance";
            this.initialBalance.Size = new System.Drawing.Size(200, 20);
            this.initialBalance.TabIndex = 3;
            this.initialBalance.ThousandsSeparator = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(37, 144);
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(72, 13);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Initial balance";
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.accountNumberLabel.Location = new System.Drawing.Point(37, 96);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(85, 13);
            this.accountNumberLabel.TabIndex = 4;
            this.accountNumberLabel.Text = "Account number";
            // 
            // accountNumberTxt
            // 
            this.accountNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberTxt.Location = new System.Drawing.Point(41, 118);
            this.accountNumberTxt.Name = "accountNumberTxt";
            this.accountNumberTxt.Size = new System.Drawing.Size(200, 20);
            this.accountNumberTxt.TabIndex = 1;
            this.accountNumberTxt.TabStop = false;
            this.accountNumberTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.accountNumberTxt_KeyUp);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(257, 48);
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(70, 13);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Account type";
            // 
            // accountTypeCombo
            // 
            this.accountTypeCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.accountTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountTypeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTypeCombo.FormattingEnabled = true;
            this.accountTypeCombo.ItemHeight = 32;
            this.accountTypeCombo.Location = new System.Drawing.Point(260, 69);
            this.accountTypeCombo.Name = "accountTypeCombo";
            this.accountTypeCombo.Size = new System.Drawing.Size(200, 38);
            this.accountTypeCombo.TabIndex = 6;
            // 
            // newAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 254);
            this.Controls.Add(this.accountTypeCombo);
            this.Controls.Add(this.initialBalance);
            this.Controls.Add(this.accountNumberTxt);
            this.Controls.Add(this.accountNameTxt);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.currencyTxt);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.materialLabel1);
            this.Name = "newAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add account";
            this.Load += new System.EventHandler(this.newAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.initialBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label materialLabel1;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox currencyTxt;
        private System.Windows.Forms.Label materialLabel2;
        private System.Windows.Forms.TextBox accountNameTxt;
        private System.Windows.Forms.Label materialLabel3;
        private System.Windows.Forms.NumericUpDown initialBalance;
        private System.Windows.Forms.Label materialLabel4;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.TextBox accountNumberTxt;
        private ComboxExtended.ImagedComboBox accountTypeCombo;
        private System.Windows.Forms.Label materialLabel6;
    }
}