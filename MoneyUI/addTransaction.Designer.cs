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
            this.transactionAmountI = new System.Windows.Forms.NumericUpDown();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.transactionDateI = new System.Windows.Forms.DateTimePicker();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.transactionDescI = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.transactionDescLabel = new MaterialSkin.Controls.MaterialLabel();
            this.transactionAccountI = new ComboxExtended.ImagedComboBox();
            this.payeeSelectBtnI = new MaterialSkin.Controls.MaterialFlatButton();
            this.transactionPayeeI = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.transactionAmountE = new System.Windows.Forms.NumericUpDown();
            this.transactionDateE = new System.Windows.Forms.DateTimePicker();
            this.transactionPayeeE = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.transactionAccountE = new ComboxExtended.ImagedComboBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.transactionPayeeBtnE = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.transactionDescE = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.currencySelectorI = new System.Windows.Forms.ComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.currencySelectorE = new System.Windows.Forms.ComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmountI)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmountE)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelBtn.Depth = 0;
            this.cancelBtn.Icon = null;
            this.cancelBtn.Location = new System.Drawing.Point(208, 490);
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
            this.addTransactionBtn.Location = new System.Drawing.Point(12, 490);
            this.addTransactionBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addTransactionBtn.Name = "addTransactionBtn";
            this.addTransactionBtn.Primary = true;
            this.addTransactionBtn.Size = new System.Drawing.Size(145, 36);
            this.addTransactionBtn.TabIndex = 5;
            this.addTransactionBtn.Text = "Add Transaction";
            this.addTransactionBtn.UseVisualStyleBackColor = true;
            this.addTransactionBtn.Click += new System.EventHandler(this.addTransactionBtn_Click);
            // 
            // transactionAmountI
            // 
            this.transactionAmountI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionAmountI.DecimalPlaces = 2;
            this.transactionAmountI.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.transactionAmountI.Location = new System.Drawing.Point(10, 134);
            this.transactionAmountI.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.transactionAmountI.Name = "transactionAmountI";
            this.transactionAmountI.Size = new System.Drawing.Size(265, 20);
            this.transactionAmountI.TabIndex = 1;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 3);
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
            this.materialLabel1.Location = new System.Drawing.Point(6, 112);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(62, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Amount";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 205);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Payee";
            // 
            // transactionDateI
            // 
            this.transactionDateI.Location = new System.Drawing.Point(10, 273);
            this.transactionDateI.Name = "transactionDateI";
            this.transactionDateI.Size = new System.Drawing.Size(265, 20);
            this.transactionDateI.TabIndex = 4;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 251);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(40, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Date";
            // 
            // transactionDescI
            // 
            this.transactionDescI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionDescI.Depth = 0;
            this.transactionDescI.Hint = "";
            this.transactionDescI.Location = new System.Drawing.Point(10, 179);
            this.transactionDescI.MaxLength = 32767;
            this.transactionDescI.MouseState = MaterialSkin.MouseState.HOVER;
            this.transactionDescI.Name = "transactionDescI";
            this.transactionDescI.PasswordChar = '\0';
            this.transactionDescI.SelectedText = "";
            this.transactionDescI.SelectionLength = 0;
            this.transactionDescI.SelectionStart = 0;
            this.transactionDescI.Size = new System.Drawing.Size(265, 23);
            this.transactionDescI.TabIndex = 2;
            this.transactionDescI.TabStop = false;
            this.transactionDescI.UseSystemPasswordChar = false;
            // 
            // transactionDescLabel
            // 
            this.transactionDescLabel.AutoSize = true;
            this.transactionDescLabel.Depth = 0;
            this.transactionDescLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.transactionDescLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.transactionDescLabel.Location = new System.Drawing.Point(6, 157);
            this.transactionDescLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.transactionDescLabel.Name = "transactionDescLabel";
            this.transactionDescLabel.Size = new System.Drawing.Size(86, 19);
            this.transactionDescLabel.TabIndex = 11;
            this.transactionDescLabel.Text = "Description";
            // 
            // transactionAccountI
            // 
            this.transactionAccountI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionAccountI.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.transactionAccountI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transactionAccountI.Enabled = false;
            this.transactionAccountI.FormattingEnabled = true;
            this.transactionAccountI.ItemHeight = 32;
            this.transactionAccountI.Location = new System.Drawing.Point(10, 25);
            this.transactionAccountI.Name = "transactionAccountI";
            this.transactionAccountI.Size = new System.Drawing.Size(265, 38);
            this.transactionAccountI.TabIndex = 0;
            // 
            // payeeSelectBtnI
            // 
            this.payeeSelectBtnI.AutoSize = true;
            this.payeeSelectBtnI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.payeeSelectBtnI.Depth = 0;
            this.payeeSelectBtnI.Icon = null;
            this.payeeSelectBtnI.Location = new System.Drawing.Point(246, 216);
            this.payeeSelectBtnI.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.payeeSelectBtnI.MouseState = MaterialSkin.MouseState.HOVER;
            this.payeeSelectBtnI.Name = "payeeSelectBtnI";
            this.payeeSelectBtnI.Primary = false;
            this.payeeSelectBtnI.Size = new System.Drawing.Size(29, 36);
            this.payeeSelectBtnI.TabIndex = 12;
            this.payeeSelectBtnI.Text = "+";
            this.payeeSelectBtnI.UseVisualStyleBackColor = true;
            this.payeeSelectBtnI.Click += new System.EventHandler(this.payeeSelectBtn_Click);
            // 
            // transactionPayeeI
            // 
            this.transactionPayeeI.AutoSize = true;
            this.transactionPayeeI.Depth = 0;
            this.transactionPayeeI.Font = new System.Drawing.Font("Roboto", 11F);
            this.transactionPayeeI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.transactionPayeeI.Location = new System.Drawing.Point(19, 224);
            this.transactionPayeeI.MouseState = MaterialSkin.MouseState.HOVER;
            this.transactionPayeeI.Name = "transactionPayeeI";
            this.transactionPayeeI.Size = new System.Drawing.Size(133, 19);
            this.transactionPayeeI.TabIndex = 13;
            this.transactionPayeeI.Text = "No payee selected";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(295, 48);
            this.materialTabSelector1.TabIndex = 14;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(1, 118);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(293, 363);
            this.materialTabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.currencySelectorI);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.transactionAmountI);
            this.tabPage1.Controls.Add(this.transactionPayeeI);
            this.tabPage1.Controls.Add(this.transactionAccountI);
            this.tabPage1.Controls.Add(this.payeeSelectBtnI);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.transactionDescI);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.transactionDescLabel);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.transactionDateI);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(285, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Income";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.currencySelectorE);
            this.tabPage2.Controls.Add(this.materialLabel6);
            this.tabPage2.Controls.Add(this.materialLabel7);
            this.tabPage2.Controls.Add(this.transactionAmountE);
            this.tabPage2.Controls.Add(this.transactionDateE);
            this.tabPage2.Controls.Add(this.transactionPayeeE);
            this.tabPage2.Controls.Add(this.materialLabel11);
            this.tabPage2.Controls.Add(this.transactionAccountE);
            this.tabPage2.Controls.Add(this.materialLabel10);
            this.tabPage2.Controls.Add(this.transactionPayeeBtnE);
            this.tabPage2.Controls.Add(this.materialLabel9);
            this.tabPage2.Controls.Add(this.materialLabel8);
            this.tabPage2.Controls.Add(this.transactionDescE);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(285, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Expense";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(6, 3);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(65, 19);
            this.materialLabel6.TabIndex = 20;
            this.materialLabel6.Text = "Account";
            // 
            // transactionAmountE
            // 
            this.transactionAmountE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionAmountE.DecimalPlaces = 2;
            this.transactionAmountE.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.transactionAmountE.Location = new System.Drawing.Point(10, 134);
            this.transactionAmountE.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.transactionAmountE.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.transactionAmountE.Name = "transactionAmountE";
            this.transactionAmountE.Size = new System.Drawing.Size(265, 20);
            this.transactionAmountE.TabIndex = 17;
            this.transactionAmountE.ValueChanged += new System.EventHandler(this.transactionAmountE_ValueChanged);
            // 
            // transactionDateE
            // 
            this.transactionDateE.Location = new System.Drawing.Point(10, 273);
            this.transactionDateE.Name = "transactionDateE";
            this.transactionDateE.Size = new System.Drawing.Size(265, 20);
            this.transactionDateE.TabIndex = 19;
            // 
            // transactionPayeeE
            // 
            this.transactionPayeeE.AutoSize = true;
            this.transactionPayeeE.Depth = 0;
            this.transactionPayeeE.Font = new System.Drawing.Font("Roboto", 11F);
            this.transactionPayeeE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.transactionPayeeE.Location = new System.Drawing.Point(19, 224);
            this.transactionPayeeE.MouseState = MaterialSkin.MouseState.HOVER;
            this.transactionPayeeE.Name = "transactionPayeeE";
            this.transactionPayeeE.Size = new System.Drawing.Size(133, 19);
            this.transactionPayeeE.TabIndex = 26;
            this.transactionPayeeE.Text = "No payee selected";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(6, 251);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(40, 19);
            this.materialLabel11.TabIndex = 23;
            this.materialLabel11.Text = "Date";
            // 
            // transactionAccountE
            // 
            this.transactionAccountE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionAccountE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.transactionAccountE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transactionAccountE.Enabled = false;
            this.transactionAccountE.FormattingEnabled = true;
            this.transactionAccountE.ItemHeight = 32;
            this.transactionAccountE.Location = new System.Drawing.Point(10, 25);
            this.transactionAccountE.Name = "transactionAccountE";
            this.transactionAccountE.Size = new System.Drawing.Size(265, 38);
            this.transactionAccountE.TabIndex = 16;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(6, 157);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(86, 19);
            this.materialLabel10.TabIndex = 24;
            this.materialLabel10.Text = "Description";
            // 
            // transactionPayeeBtnE
            // 
            this.transactionPayeeBtnE.AutoSize = true;
            this.transactionPayeeBtnE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.transactionPayeeBtnE.Depth = 0;
            this.transactionPayeeBtnE.Icon = null;
            this.transactionPayeeBtnE.Location = new System.Drawing.Point(246, 216);
            this.transactionPayeeBtnE.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.transactionPayeeBtnE.MouseState = MaterialSkin.MouseState.HOVER;
            this.transactionPayeeBtnE.Name = "transactionPayeeBtnE";
            this.transactionPayeeBtnE.Primary = false;
            this.transactionPayeeBtnE.Size = new System.Drawing.Size(29, 36);
            this.transactionPayeeBtnE.TabIndex = 25;
            this.transactionPayeeBtnE.Text = "+";
            this.transactionPayeeBtnE.UseVisualStyleBackColor = true;
            this.transactionPayeeBtnE.Click += new System.EventHandler(this.payeeSelectBtn_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(6, 205);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(49, 19);
            this.materialLabel9.TabIndex = 22;
            this.materialLabel9.Text = "Payee";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(6, 112);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(62, 19);
            this.materialLabel8.TabIndex = 21;
            this.materialLabel8.Text = "Amount";
            // 
            // transactionDescE
            // 
            this.transactionDescE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionDescE.Depth = 0;
            this.transactionDescE.Hint = "";
            this.transactionDescE.Location = new System.Drawing.Point(10, 179);
            this.transactionDescE.MaxLength = 32767;
            this.transactionDescE.MouseState = MaterialSkin.MouseState.HOVER;
            this.transactionDescE.Name = "transactionDescE";
            this.transactionDescE.PasswordChar = '\0';
            this.transactionDescE.SelectedText = "";
            this.transactionDescE.SelectionLength = 0;
            this.transactionDescE.SelectionStart = 0;
            this.transactionDescE.Size = new System.Drawing.Size(265, 23);
            this.transactionDescE.TabIndex = 18;
            this.transactionDescE.TabStop = false;
            this.transactionDescE.UseSystemPasswordChar = false;
            // 
            // currencySelectorI
            // 
            this.currencySelectorI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currencySelectorI.FormattingEnabled = true;
            this.currencySelectorI.Location = new System.Drawing.Point(10, 88);
            this.currencySelectorI.Name = "currencySelectorI";
            this.currencySelectorI.Size = new System.Drawing.Size(265, 21);
            this.currencySelectorI.TabIndex = 14;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 66);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(68, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Currency";
            // 
            // currencySelectorE
            // 
            this.currencySelectorE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currencySelectorE.FormattingEnabled = true;
            this.currencySelectorE.Location = new System.Drawing.Point(10, 88);
            this.currencySelectorE.Name = "currencySelectorE";
            this.currencySelectorE.Size = new System.Drawing.Size(265, 21);
            this.currencySelectorE.TabIndex = 17;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(6, 66);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(68, 19);
            this.materialLabel7.TabIndex = 16;
            this.materialLabel7.Text = "Currency";
            // 
            // addTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 541);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.addTransactionBtn);
            this.Controls.Add(this.cancelBtn);
            this.Name = "addTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Transaction";
            this.Load += new System.EventHandler(this.addTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmountI)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmountE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton cancelBtn;
        private MaterialSkin.Controls.MaterialRaisedButton addTransactionBtn;
        private System.Windows.Forms.NumericUpDown transactionAmountI;
        private ComboxExtended.ImagedComboBox transactionAccountI;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker transactionDateI;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField transactionDescI;
        private MaterialSkin.Controls.MaterialLabel transactionDescLabel;
        private MaterialSkin.Controls.MaterialFlatButton payeeSelectBtnI;
        private MaterialSkin.Controls.MaterialLabel transactionPayeeI;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.NumericUpDown transactionAmountE;
        private System.Windows.Forms.DateTimePicker transactionDateE;
        private MaterialSkin.Controls.MaterialLabel transactionPayeeE;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private ComboxExtended.ImagedComboBox transactionAccountE;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialFlatButton transactionPayeeBtnE;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField transactionDescE;
        private System.Windows.Forms.ComboBox currencySelectorI;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ComboBox currencySelectorE;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
    }
}