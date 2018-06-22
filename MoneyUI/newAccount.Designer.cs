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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.continueBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cancelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.currencyTxt = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.accountNameTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.initialBalance = new System.Windows.Forms.NumericUpDown();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.accountNumberLabel = new MaterialSkin.Controls.MaterialLabel();
            this.accountNumberTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.accountTypeCombo = new ComboxExtended.ImagedComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.initialBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(24, 72);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(136, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Add a new account";
            // 
            // continueBtn
            // 
            this.continueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.continueBtn.AutoSize = true;
            this.continueBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.continueBtn.Depth = 0;
            this.continueBtn.Icon = null;
            this.continueBtn.Location = new System.Drawing.Point(364, 277);
            this.continueBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Primary = true;
            this.continueBtn.Size = new System.Drawing.Size(88, 36);
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
            this.cancelBtn.Depth = 0;
            this.cancelBtn.Icon = null;
            this.cancelBtn.Location = new System.Drawing.Point(459, 277);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Primary = false;
            this.cancelBtn.Size = new System.Drawing.Size(73, 36);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // currencyTxt
            // 
            this.currencyTxt.FormattingEnabled = true;
            this.currencyTxt.Location = new System.Drawing.Point(259, 175);
            this.currencyTxt.Name = "currencyTxt";
            this.currencyTxt.Size = new System.Drawing.Size(200, 21);
            this.currencyTxt.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(255, 153);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Currency";
            // 
            // accountNameTxt
            // 
            this.accountNameTxt.Depth = 0;
            this.accountNameTxt.Hint = "";
            this.accountNameTxt.Location = new System.Drawing.Point(39, 113);
            this.accountNameTxt.MaxLength = 32767;
            this.accountNameTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.accountNameTxt.Name = "accountNameTxt";
            this.accountNameTxt.PasswordChar = '\0';
            this.accountNameTxt.SelectedText = "";
            this.accountNameTxt.SelectionLength = 0;
            this.accountNameTxt.SelectionStart = 0;
            this.accountNameTxt.Size = new System.Drawing.Size(200, 23);
            this.accountNameTxt.TabIndex = 0;
            this.accountNameTxt.TabStop = false;
            this.accountNameTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(35, 91);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(106, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Account name";
            // 
            // initialBalance
            // 
            this.initialBalance.DecimalPlaces = 2;
            this.initialBalance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.initialBalance.Location = new System.Drawing.Point(39, 209);
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
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(35, 187);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(102, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Initial balance";
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Depth = 0;
            this.accountNumberLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.accountNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.accountNumberLabel.Location = new System.Drawing.Point(35, 139);
            this.accountNumberLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(119, 19);
            this.accountNumberLabel.TabIndex = 4;
            this.accountNumberLabel.Text = "Account number";
            // 
            // accountNumberTxt
            // 
            this.accountNumberTxt.Depth = 0;
            this.accountNumberTxt.Hint = "";
            this.accountNumberTxt.Location = new System.Drawing.Point(39, 161);
            this.accountNumberTxt.MaxLength = 32767;
            this.accountNumberTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.accountNumberTxt.Name = "accountNumberTxt";
            this.accountNumberTxt.PasswordChar = '\0';
            this.accountNumberTxt.SelectedText = "";
            this.accountNumberTxt.SelectionLength = 0;
            this.accountNumberTxt.SelectionStart = 0;
            this.accountNumberTxt.Size = new System.Drawing.Size(200, 23);
            this.accountNumberTxt.TabIndex = 1;
            this.accountNumberTxt.TabStop = false;
            this.accountNumberTxt.UseSystemPasswordChar = false;
            this.accountNumberTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.accountNumberTxt_KeyUp);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(255, 91);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(97, 19);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Account type";
            // 
            // accountTypeCombo
            // 
            this.accountTypeCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.accountTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountTypeCombo.FormattingEnabled = true;
            this.accountTypeCombo.ItemHeight = 32;
            this.accountTypeCombo.Location = new System.Drawing.Point(258, 112);
            this.accountTypeCombo.Name = "accountTypeCombo";
            this.accountTypeCombo.Size = new System.Drawing.Size(200, 38);
            this.accountTypeCombo.TabIndex = 6;
            // 
            // newAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 328);
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

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton continueBtn;
        private MaterialSkin.Controls.MaterialFlatButton cancelBtn;
        private System.Windows.Forms.ComboBox currencyTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField accountNameTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.NumericUpDown initialBalance;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel accountNumberLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField accountNumberTxt;
        private ComboxExtended.ImagedComboBox accountTypeCombo;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}