namespace ManagementStudio
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.logo = new System.Windows.Forms.PictureBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.serverNameLbl = new System.Windows.Forms.Label();
            this.authenticationTypeLbl = new System.Windows.Forms.Label();
            this.serverTypeComboBox = new System.Windows.Forms.ComboBox();
            this.serverNameCombo = new System.Windows.Forms.ComboBox();
            this.henticationCombo = new System.Windows.Forms.ComboBox();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(3, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(628, 115);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.typeLbl.Location = new System.Drawing.Point(12, 150);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(153, 29);
            this.typeLbl.TabIndex = 1;
            this.typeLbl.Text = "Server type:";
            // 
            // serverNameLbl
            // 
            this.serverNameLbl.AutoSize = true;
            this.serverNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.serverNameLbl.Location = new System.Drawing.Point(12, 191);
            this.serverNameLbl.Name = "serverNameLbl";
            this.serverNameLbl.Size = new System.Drawing.Size(168, 29);
            this.serverNameLbl.TabIndex = 2;
            this.serverNameLbl.Text = "Server name:";
            // 
            // authenticationTypeLbl
            // 
            this.authenticationTypeLbl.AutoSize = true;
            this.authenticationTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.authenticationTypeLbl.Location = new System.Drawing.Point(11, 234);
            this.authenticationTypeLbl.Name = "authenticationTypeLbl";
            this.authenticationTypeLbl.Size = new System.Drawing.Size(191, 29);
            this.authenticationTypeLbl.TabIndex = 3;
            this.authenticationTypeLbl.Text = "Authentication :";
            // 
            // serverTypeComboBox
            // 
            this.serverTypeComboBox.FormattingEnabled = true;
            this.serverTypeComboBox.Items.AddRange(new object[] {
            "Database Engine",
            "Analysis Services",
            "Reporting Services",
            "Integration Services",
            "Azure SSIS Integration Runtime"});
            this.serverTypeComboBox.Location = new System.Drawing.Point(208, 155);
            this.serverTypeComboBox.Name = "serverTypeComboBox";
            this.serverTypeComboBox.Size = new System.Drawing.Size(399, 24);
            this.serverTypeComboBox.TabIndex = 4;
            // 
            // serverNameCombo
            // 
            this.serverNameCombo.FormattingEnabled = true;
            this.serverNameCombo.Location = new System.Drawing.Point(208, 196);
            this.serverNameCombo.Name = "serverNameCombo";
            this.serverNameCombo.Size = new System.Drawing.Size(399, 24);
            this.serverNameCombo.TabIndex = 5;
            // 
            // henticationCombo
            // 
            this.henticationCombo.FormattingEnabled = true;
            this.henticationCombo.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.henticationCombo.Location = new System.Drawing.Point(208, 234);
            this.henticationCombo.Name = "henticationCombo";
            this.henticationCombo.Size = new System.Drawing.Size(399, 24);
            this.henticationCombo.TabIndex = 6;
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userNameLbl.Location = new System.Drawing.Point(34, 283);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(146, 29);
            this.userNameLbl.TabIndex = 7;
            this.userNameLbl.Text = "User name:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLbl.Location = new System.Drawing.Point(34, 324);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(135, 29);
            this.passwordLbl.TabIndex = 8;
            this.passwordLbl.Text = "Password:";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(258, 283);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(349, 22);
            this.userNameTxt.TabIndex = 9;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(258, 324);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(349, 22);
            this.passwordTxt.TabIndex = 10;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(130, 389);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(107, 23);
            this.connectButton.TabIndex = 11;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(258, 389);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(388, 389);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(107, 23);
            this.helpButton.TabIndex = 13;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 424);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.henticationCombo);
            this.Controls.Add(this.serverNameCombo);
            this.Controls.Add(this.serverTypeComboBox);
            this.Controls.Add(this.authenticationTypeLbl);
            this.Controls.Add(this.serverNameLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.logo);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label serverNameLbl;
        private System.Windows.Forms.Label authenticationTypeLbl;
        private System.Windows.Forms.ComboBox serverTypeComboBox;
        private System.Windows.Forms.ComboBox serverNameCombo;
        private System.Windows.Forms.ComboBox henticationCombo;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button helpButton;
    }
}