namespace FootballClubMS.Applications
{
    partial class Player
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
            this.btnLogOut = new MetroFramework.Controls.MetroButton();
            this.btnChangePassword = new MetroFramework.Controls.MetroButton();
            this.txtNewPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtOldPassword = new MetroFramework.Controls.MetroTextBox();
            this.lblPlayerValidity = new MetroFramework.Controls.MetroLabel();
            this.lblPlayerPositon = new MetroFramework.Controls.MetroLabel();
            this.lblPlayerEmail = new MetroFramework.Controls.MetroLabel();
            this.lblPlayerId = new MetroFramework.Controls.MetroLabel();
            this.lblPlayerName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lblPlayerFee = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(403, 72);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 30);
            this.btnLogOut.TabIndex = 34;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseSelectable = true;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(279, 386);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(75, 23);
            this.btnChangePassword.TabIndex = 33;
            this.btnChangePassword.Text = "Change";
            this.btnChangePassword.UseSelectable = true;
            this.btnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // txtNewPassword
            // 
            // 
            // 
            // 
            this.txtNewPassword.CustomButton.Image = null;
            this.txtNewPassword.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtNewPassword.CustomButton.Name = "";
            this.txtNewPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPassword.CustomButton.TabIndex = 1;
            this.txtNewPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPassword.CustomButton.UseSelectable = true;
            this.txtNewPassword.CustomButton.Visible = false;
            this.txtNewPassword.Lines = new string[0];
            this.txtNewPassword.Location = new System.Drawing.Point(177, 351);
            this.txtNewPassword.MaxLength = 32767;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '\0';
            this.txtNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.SelectionLength = 0;
            this.txtNewPassword.SelectionStart = 0;
            this.txtNewPassword.ShortcutsEnabled = true;
            this.txtNewPassword.Size = new System.Drawing.Size(167, 23);
            this.txtNewPassword.TabIndex = 32;
            this.txtNewPassword.UseSelectable = true;
            this.txtNewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOldPassword
            // 
            // 
            // 
            // 
            this.txtOldPassword.CustomButton.Image = null;
            this.txtOldPassword.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txtOldPassword.CustomButton.Name = "";
            this.txtOldPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOldPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOldPassword.CustomButton.TabIndex = 1;
            this.txtOldPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOldPassword.CustomButton.UseSelectable = true;
            this.txtOldPassword.CustomButton.Visible = false;
            this.txtOldPassword.Lines = new string[0];
            this.txtOldPassword.Location = new System.Drawing.Point(177, 322);
            this.txtOldPassword.MaxLength = 32767;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '\0';
            this.txtOldPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOldPassword.SelectedText = "";
            this.txtOldPassword.SelectionLength = 0;
            this.txtOldPassword.SelectionStart = 0;
            this.txtOldPassword.ShortcutsEnabled = true;
            this.txtOldPassword.Size = new System.Drawing.Size(167, 23);
            this.txtOldPassword.TabIndex = 31;
            this.txtOldPassword.UseSelectable = true;
            this.txtOldPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOldPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPlayerValidity
            // 
            this.lblPlayerValidity.AutoSize = true;
            this.lblPlayerValidity.Location = new System.Drawing.Point(130, 208);
            this.lblPlayerValidity.Name = "lblPlayerValidity";
            this.lblPlayerValidity.Size = new System.Drawing.Size(83, 19);
            this.lblPlayerValidity.TabIndex = 30;
            this.lblPlayerValidity.Text = "metroLabel9";
            // 
            // lblPlayerPositon
            // 
            this.lblPlayerPositon.AutoSize = true;
            this.lblPlayerPositon.Location = new System.Drawing.Point(130, 174);
            this.lblPlayerPositon.Name = "lblPlayerPositon";
            this.lblPlayerPositon.Size = new System.Drawing.Size(88, 19);
            this.lblPlayerPositon.TabIndex = 29;
            this.lblPlayerPositon.Text = "metroLabel10";
            // 
            // lblPlayerEmail
            // 
            this.lblPlayerEmail.AutoSize = true;
            this.lblPlayerEmail.Location = new System.Drawing.Point(130, 142);
            this.lblPlayerEmail.Name = "lblPlayerEmail";
            this.lblPlayerEmail.Size = new System.Drawing.Size(86, 19);
            this.lblPlayerEmail.TabIndex = 28;
            this.lblPlayerEmail.Text = "metroLabel11";
            // 
            // lblPlayerId
            // 
            this.lblPlayerId.AutoSize = true;
            this.lblPlayerId.Location = new System.Drawing.Point(130, 105);
            this.lblPlayerId.Name = "lblPlayerId";
            this.lblPlayerId.Size = new System.Drawing.Size(88, 19);
            this.lblPlayerId.TabIndex = 27;
            this.lblPlayerId.Text = "metroLabel12";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(130, 72);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(88, 19);
            this.lblPlayerName.TabIndex = 26;
            this.lblPlayerName.Text = "metroLabel13";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(19, 351);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(127, 19);
            this.metroLabel7.TabIndex = 25;
            this.metroLabel7.Text = "Enter New Password";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(19, 322);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(123, 19);
            this.metroLabel8.TabIndex = 24;
            this.metroLabel8.Text = "Enter Old Password";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(19, 283);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(161, 25);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Change Password";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 208);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(96, 19);
            this.metroLabel6.TabIndex = 22;
            this.metroLabel6.Text = "Validation Date";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 174);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Position";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 142);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Email";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 105);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(21, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "ID";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Name";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(23, 241);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(75, 19);
            this.metroLabel9.TabIndex = 35;
            this.metroLabel9.Text = "Weekly Fee";
            // 
            // lblPlayerFee
            // 
            this.lblPlayerFee.AutoSize = true;
            this.lblPlayerFee.Location = new System.Drawing.Point(133, 241);
            this.lblPlayerFee.Name = "lblPlayerFee";
            this.lblPlayerFee.Size = new System.Drawing.Size(83, 19);
            this.lblPlayerFee.TabIndex = 36;
            this.lblPlayerFee.Text = "metroLabel9";
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.lblPlayerFee);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.lblPlayerValidity);
            this.Controls.Add(this.lblPlayerPositon);
            this.Controls.Add(this.lblPlayerEmail);
            this.Controls.Add(this.lblPlayerId);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Player";
            this.Text = "Player Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Player_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLogOut;
        private MetroFramework.Controls.MetroButton btnChangePassword;
        private MetroFramework.Controls.MetroTextBox txtNewPassword;
        private MetroFramework.Controls.MetroTextBox txtOldPassword;
        private MetroFramework.Controls.MetroLabel lblPlayerValidity;
        private MetroFramework.Controls.MetroLabel lblPlayerPositon;
        private MetroFramework.Controls.MetroLabel lblPlayerEmail;
        private MetroFramework.Controls.MetroLabel lblPlayerId;
        private MetroFramework.Controls.MetroLabel lblPlayerName;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel lblPlayerFee;
    }
}