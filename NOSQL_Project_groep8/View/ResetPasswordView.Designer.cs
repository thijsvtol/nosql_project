namespace NOSQL_Project_groep8.View
{
    partial class ResetPasswordView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtResetKey = new System.Windows.Forms.TextBox();
            this.pSendEmail = new System.Windows.Forms.Panel();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pCheckKey = new System.Windows.Forms.Panel();
            this.btnCheckKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pResetKey = new System.Windows.Forms.Panel();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReEnterPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFavColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKeyEmail = new System.Windows.Forms.TextBox();
            this.pSendEmail.SuspendLayout();
            this.pCheckKey.SuspendLayout();
            this.pResetKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 36);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 20);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtResetKey
            // 
            this.txtResetKey.Location = new System.Drawing.Point(80, 52);
            this.txtResetKey.Name = "txtResetKey";
            this.txtResetKey.Size = new System.Drawing.Size(166, 20);
            this.txtResetKey.TabIndex = 1;
            // 
            // pSendEmail
            // 
            this.pSendEmail.Controls.Add(this.label6);
            this.pSendEmail.Controls.Add(this.txtFavColor);
            this.pSendEmail.Controls.Add(this.btnSendEmail);
            this.pSendEmail.Controls.Add(this.label1);
            this.pSendEmail.Controls.Add(this.txtEmail);
            this.pSendEmail.Location = new System.Drawing.Point(0, 54);
            this.pSendEmail.Name = "pSendEmail";
            this.pSendEmail.Size = new System.Drawing.Size(316, 154);
            this.pSendEmail.TabIndex = 2;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSendEmail.FlatAppearance.BorderSize = 0;
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSendEmail.Location = new System.Drawing.Point(165, 100);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(133, 47);
            this.btnSendEmail.TabIndex = 2;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // pCheckKey
            // 
            this.pCheckKey.Controls.Add(this.label7);
            this.pCheckKey.Controls.Add(this.txtKeyEmail);
            this.pCheckKey.Controls.Add(this.btnCheckKey);
            this.pCheckKey.Controls.Add(this.label2);
            this.pCheckKey.Controls.Add(this.txtResetKey);
            this.pCheckKey.Location = new System.Drawing.Point(0, 233);
            this.pCheckKey.Name = "pCheckKey";
            this.pCheckKey.Size = new System.Drawing.Size(316, 241);
            this.pCheckKey.TabIndex = 2;
            // 
            // btnCheckKey
            // 
            this.btnCheckKey.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCheckKey.FlatAppearance.BorderSize = 0;
            this.btnCheckKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckKey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheckKey.Location = new System.Drawing.Point(165, 107);
            this.btnCheckKey.Name = "btnCheckKey";
            this.btnCheckKey.Size = new System.Drawing.Size(133, 49);
            this.btnCheckKey.TabIndex = 3;
            this.btnCheckKey.Text = "Check ResetKey";
            this.btnCheckKey.UseVisualStyleBackColor = false;
            this.btnCheckKey.Click += new System.EventHandler(this.btnCheckKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resetkey:";
            // 
            // pResetKey
            // 
            this.pResetKey.Controls.Add(this.btnResetPassword);
            this.pResetKey.Controls.Add(this.label4);
            this.pResetKey.Controls.Add(this.txtReEnterPassword);
            this.pResetKey.Controls.Add(this.label3);
            this.pResetKey.Controls.Add(this.txtPassword);
            this.pResetKey.Location = new System.Drawing.Point(1, 233);
            this.pResetKey.Name = "pResetKey";
            this.pResetKey.Size = new System.Drawing.Size(315, 211);
            this.pResetKey.TabIndex = 1;
            this.pResetKey.Visible = false;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResetPassword.Location = new System.Drawing.Point(164, 132);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(133, 46);
            this.btnResetPassword.TabIndex = 4;
            this.btnResetPassword.Text = "Change Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "reenter Password";
            // 
            // txtReEnterPassword
            // 
            this.txtReEnterPassword.Location = new System.Drawing.Point(114, 81);
            this.txtReEnterPassword.Name = "txtReEnterPassword";
            this.txtReEnterPassword.Size = new System.Drawing.Size(131, 20);
            this.txtReEnterPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "new Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(114, 41);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(131, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Uw favorite kleur:";
            // 
            // txtFavColor
            // 
            this.txtFavColor.Location = new System.Drawing.Point(122, 63);
            this.txtFavColor.Name = "txtFavColor";
            this.txtFavColor.Size = new System.Drawing.Size(166, 20);
            this.txtFavColor.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email:";
            // 
            // txtKeyEmail
            // 
            this.txtKeyEmail.Location = new System.Drawing.Point(80, 26);
            this.txtKeyEmail.Name = "txtKeyEmail";
            this.txtKeyEmail.Size = new System.Drawing.Size(166, 20);
            this.txtKeyEmail.TabIndex = 6;
            // 
            // ResetPasswordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pSendEmail);
            this.Controls.Add(this.pResetKey);
            this.Controls.Add(this.pCheckKey);
            this.Name = "ResetPasswordView";
            this.Size = new System.Drawing.Size(318, 477);
            this.pSendEmail.ResumeLayout(false);
            this.pSendEmail.PerformLayout();
            this.pCheckKey.ResumeLayout(false);
            this.pCheckKey.PerformLayout();
            this.pResetKey.ResumeLayout(false);
            this.pResetKey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtResetKey;
        private System.Windows.Forms.Panel pSendEmail;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pCheckKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pResetKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReEnterPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCheckKey;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFavColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKeyEmail;
    }
}
