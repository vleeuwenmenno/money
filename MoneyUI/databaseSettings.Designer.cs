namespace MoneyUI
{
    partial class databaseSettings
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
            this.webDavSettingsPanel = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.linkTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.passwordTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.usernameTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.darkThemeChk = new MaterialSkin.Controls.MaterialCheckBox();
            this.syncWebDav = new MaterialSkin.Controls.MaterialCheckBox();
            this.dbNameTxtSett = new MaterialSkin.Controls.MaterialLabel();
            this.dbNameTxtBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.saveBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.webDavSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelBtn.Depth = 0;
            this.cancelBtn.Icon = null;
            this.cancelBtn.Location = new System.Drawing.Point(311, 469);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Primary = false;
            this.cancelBtn.Size = new System.Drawing.Size(73, 36);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // webDavSettingsPanel
            // 
            this.webDavSettingsPanel.Controls.Add(this.materialLabel2);
            this.webDavSettingsPanel.Controls.Add(this.materialLabel4);
            this.webDavSettingsPanel.Controls.Add(this.linkTxt);
            this.webDavSettingsPanel.Controls.Add(this.passwordTxt);
            this.webDavSettingsPanel.Controls.Add(this.usernameTxt);
            this.webDavSettingsPanel.Controls.Add(this.materialLabel3);
            this.webDavSettingsPanel.Enabled = false;
            this.webDavSettingsPanel.Location = new System.Drawing.Point(42, 217);
            this.webDavSettingsPanel.Name = "webDavSettingsPanel";
            this.webDavSettingsPanel.Size = new System.Drawing.Size(342, 183);
            this.webDavSettingsPanel.TabIndex = 11;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(3, 11);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(95, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "WebDav Link";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(3, 118);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(75, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Password";
            // 
            // linkTxt
            // 
            this.linkTxt.Depth = 0;
            this.linkTxt.Hint = "";
            this.linkTxt.Location = new System.Drawing.Point(7, 33);
            this.linkTxt.MaxLength = 32767;
            this.linkTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.linkTxt.Name = "linkTxt";
            this.linkTxt.PasswordChar = '\0';
            this.linkTxt.SelectedText = "";
            this.linkTxt.SelectionLength = 0;
            this.linkTxt.SelectionStart = 0;
            this.linkTxt.Size = new System.Drawing.Size(332, 23);
            this.linkTxt.TabIndex = 3;
            this.linkTxt.TabStop = false;
            this.linkTxt.UseSystemPasswordChar = false;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Depth = 0;
            this.passwordTxt.Hint = "";
            this.passwordTxt.Location = new System.Drawing.Point(7, 146);
            this.passwordTxt.MaxLength = 32767;
            this.passwordTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.SelectionLength = 0;
            this.passwordTxt.SelectionStart = 0;
            this.passwordTxt.Size = new System.Drawing.Size(255, 23);
            this.passwordTxt.TabIndex = 5;
            this.passwordTxt.TabStop = false;
            this.passwordTxt.UseSystemPasswordChar = false;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Depth = 0;
            this.usernameTxt.Hint = "";
            this.usernameTxt.Location = new System.Drawing.Point(7, 92);
            this.usernameTxt.MaxLength = 32767;
            this.usernameTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PasswordChar = '\0';
            this.usernameTxt.SelectedText = "";
            this.usernameTxt.SelectionLength = 0;
            this.usernameTxt.SelectionStart = 0;
            this.usernameTxt.Size = new System.Drawing.Size(255, 23);
            this.usernameTxt.TabIndex = 4;
            this.usernameTxt.TabStop = false;
            this.usernameTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 70);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(77, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Username";
            // 
            // darkThemeChk
            // 
            this.darkThemeChk.AutoSize = true;
            this.darkThemeChk.Depth = 0;
            this.darkThemeChk.Font = new System.Drawing.Font("Roboto", 10F);
            this.darkThemeChk.Location = new System.Drawing.Point(42, 154);
            this.darkThemeChk.Margin = new System.Windows.Forms.Padding(0);
            this.darkThemeChk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.darkThemeChk.MouseState = MaterialSkin.MouseState.HOVER;
            this.darkThemeChk.Name = "darkThemeChk";
            this.darkThemeChk.Ripple = true;
            this.darkThemeChk.Size = new System.Drawing.Size(101, 30);
            this.darkThemeChk.TabIndex = 1;
            this.darkThemeChk.Text = "Dark theme";
            this.darkThemeChk.UseVisualStyleBackColor = true;
            this.darkThemeChk.CheckedChanged += new System.EventHandler(this.syncWebDav_CheckedChanged);
            // 
            // syncWebDav
            // 
            this.syncWebDav.AutoSize = true;
            this.syncWebDav.Depth = 0;
            this.syncWebDav.Font = new System.Drawing.Font("Roboto", 10F);
            this.syncWebDav.Location = new System.Drawing.Point(42, 184);
            this.syncWebDav.Margin = new System.Windows.Forms.Padding(0);
            this.syncWebDav.MouseLocation = new System.Drawing.Point(-1, -1);
            this.syncWebDav.MouseState = MaterialSkin.MouseState.HOVER;
            this.syncWebDav.Name = "syncWebDav";
            this.syncWebDav.Ripple = true;
            this.syncWebDav.Size = new System.Drawing.Size(143, 30);
            this.syncWebDav.TabIndex = 2;
            this.syncWebDav.Text = "Sync with WebDav";
            this.syncWebDav.UseVisualStyleBackColor = true;
            this.syncWebDav.CheckedChanged += new System.EventHandler(this.syncWebDav_CheckedChanged);
            // 
            // dbNameTxtSett
            // 
            this.dbNameTxtSett.AutoSize = true;
            this.dbNameTxtSett.Depth = 0;
            this.dbNameTxtSett.Font = new System.Drawing.Font("Roboto", 11F);
            this.dbNameTxtSett.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dbNameTxtSett.Location = new System.Drawing.Point(44, 99);
            this.dbNameTxtSett.MouseState = MaterialSkin.MouseState.HOVER;
            this.dbNameTxtSett.Name = "dbNameTxtSett";
            this.dbNameTxtSett.Size = new System.Drawing.Size(74, 19);
            this.dbNameTxtSett.TabIndex = 7;
            this.dbNameTxtSett.Text = "Full name";
            // 
            // dbNameTxtBox
            // 
            this.dbNameTxtBox.Depth = 0;
            this.dbNameTxtBox.Hint = "";
            this.dbNameTxtBox.Location = new System.Drawing.Point(47, 120);
            this.dbNameTxtBox.MaxLength = 32767;
            this.dbNameTxtBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.dbNameTxtBox.Name = "dbNameTxtBox";
            this.dbNameTxtBox.PasswordChar = '\0';
            this.dbNameTxtBox.SelectedText = "";
            this.dbNameTxtBox.SelectionLength = 0;
            this.dbNameTxtBox.SelectionStart = 0;
            this.dbNameTxtBox.Size = new System.Drawing.Size(257, 23);
            this.dbNameTxtBox.TabIndex = 0;
            this.dbNameTxtBox.TabStop = false;
            this.dbNameTxtBox.UseSystemPasswordChar = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.AutoSize = true;
            this.saveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveBtn.Depth = 0;
            this.saveBtn.Icon = null;
            this.saveBtn.Location = new System.Drawing.Point(249, 469);
            this.saveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Primary = true;
            this.saveBtn.Size = new System.Drawing.Size(55, 36);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_ClickAsync);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 64);
            this.progressBar.MarqueeAnimationSpeed = 20;
            this.progressBar.Maximum = 200;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(411, 2);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 12;
            this.progressBar.Visible = false;
            // 
            // databaseSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 531);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.webDavSettingsPanel);
            this.Controls.Add(this.dbNameTxtSett);
            this.Controls.Add(this.darkThemeChk);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.syncWebDav);
            this.Controls.Add(this.dbNameTxtBox);
            this.Name = "databaseSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database Settings";
            this.Load += new System.EventHandler(this.databaseSettings_Load);
            this.webDavSettingsPanel.ResumeLayout(false);
            this.webDavSettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel webDavSettingsPanel;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField linkTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField usernameTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCheckBox syncWebDav;
        private MaterialSkin.Controls.MaterialLabel dbNameTxtSett;
        private MaterialSkin.Controls.MaterialSingleLineTextField dbNameTxtBox;
        private MaterialSkin.Controls.MaterialFlatButton cancelBtn;
        private MaterialSkin.Controls.MaterialRaisedButton saveBtn;
        private MaterialSkin.Controls.MaterialCheckBox darkThemeChk;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}