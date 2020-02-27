namespace NOSQL_Project_groep8.View
{
    partial class LoginView
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
            this.lblLoginHeader = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginHeader
            // 
            this.lblLoginHeader.AutoSize = true;
            this.lblLoginHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginHeader.Location = new System.Drawing.Point(14, 13);
            this.lblLoginHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginHeader.Name = "lblLoginHeader";
            this.lblLoginHeader.Size = new System.Drawing.Size(298, 68);
            this.lblLoginHeader.TabIndex = 1;
            this.lblLoginHeader.Text = "Login\r\n(header weg halen)";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(120, 214);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "button1";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLoginHeader);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(327, 437);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginHeader;
        private System.Windows.Forms.Button btnLogin;
    }
}
