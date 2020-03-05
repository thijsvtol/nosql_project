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
            this.pSendEmail.SuspendLayout();
            this.pCheckKey.SuspendLayout();
            this.pResetKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 45);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // txtResetKey
            // 
            this.txtResetKey.Location = new System.Drawing.Point(107, 33);
            this.txtResetKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResetKey.Name = "txtResetKey";
            this.txtResetKey.Size = new System.Drawing.Size(132, 22);
            this.txtResetKey.TabIndex = 1;
            // 
            // pSendEmail
            // 
            this.pSendEmail.Controls.Add(this.btnSendEmail);
            this.pSendEmail.Controls.Add(this.label1);
            this.pSendEmail.Controls.Add(this.txtEmail);
            this.pSendEmail.Location = new System.Drawing.Point(37, 51);
            this.pSendEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pSendEmail.Name = "pSendEmail";
            this.pSendEmail.Size = new System.Drawing.Size(421, 162);
            this.pSendEmail.TabIndex = 2;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(256, 100);
            this.btnSendEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(100, 28);
            this.btnSendEmail.TabIndex = 2;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // pCheckKey
            // 
            this.pCheckKey.Controls.Add(this.btnCheckKey);
            this.pCheckKey.Controls.Add(this.label2);
            this.pCheckKey.Controls.Add(this.txtResetKey);
            this.pCheckKey.Location = new System.Drawing.Point(37, 279);
            this.pCheckKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pCheckKey.Name = "pCheckKey";
            this.pCheckKey.Size = new System.Drawing.Size(421, 197);
            this.pCheckKey.TabIndex = 3;
            // 
            // btnCheckKey
            // 
            this.btnCheckKey.Location = new System.Drawing.Point(256, 132);
            this.btnCheckKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckKey.Name = "btnCheckKey";
            this.btnCheckKey.Size = new System.Drawing.Size(141, 28);
            this.btnCheckKey.TabIndex = 3;
            this.btnCheckKey.Text = "Check ResetKey";
            this.btnCheckKey.UseVisualStyleBackColor = true;
            this.btnCheckKey.Click += new System.EventHandler(this.btnCheckKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
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
            this.pResetKey.Location = new System.Drawing.Point(35, 278);
            this.pResetKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pResetKey.Name = "pResetKey";
            this.pResetKey.Size = new System.Drawing.Size(421, 197);
            this.pResetKey.TabIndex = 4;
            this.pResetKey.Visible = false;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(227, 129);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(141, 28);
            this.btnResetPassword.TabIndex = 4;
            this.btnResetPassword.Text = "Change Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "reenter Password";
            // 
            // txtReEnterPassword
            // 
            this.txtReEnterPassword.Location = new System.Drawing.Point(152, 94);
            this.txtReEnterPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReEnterPassword.Name = "txtReEnterPassword";
            this.txtReEnterPassword.Size = new System.Drawing.Size(132, 22);
            this.txtReEnterPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "new Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(152, 44);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(132, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // ResetPasswordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pSendEmail);
            this.Controls.Add(this.pResetKey);
            this.Controls.Add(this.pCheckKey);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ResetPasswordView";
            this.Size = new System.Drawing.Size(719, 587);
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
    }
}
