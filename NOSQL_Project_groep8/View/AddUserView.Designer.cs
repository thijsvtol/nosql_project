namespace NOSQL_Project_groep8.View
{
    partial class AddUserView
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
            this.lblAddUserHeader = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.cbTypeEmployee = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhonenumber = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBoxAccept = new System.Windows.Forms.CheckBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblSendPassword = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddUserHeader
            // 
            this.lblAddUserHeader.AutoSize = true;
            this.lblAddUserHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUserHeader.Location = new System.Drawing.Point(16, 15);
            this.lblAddUserHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddUserHeader.Name = "lblAddUserHeader";
            this.lblAddUserHeader.Size = new System.Drawing.Size(153, 34);
            this.lblAddUserHeader.TabIndex = 1;
            this.lblAddUserHeader.Text = "Add User";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(271, 91);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(277, 25);
            this.tbFirstName.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(271, 131);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(277, 25);
            this.tbLastName.TabIndex = 3;
            // 
            // cbTypeEmployee
            // 
            this.cbTypeEmployee.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypeEmployee.FormattingEnabled = true;
            this.cbTypeEmployee.Items.AddRange(new object[] {
            "Employee",
            "Service desk employee"});
            this.cbTypeEmployee.Location = new System.Drawing.Point(271, 171);
            this.cbTypeEmployee.Name = "cbTypeEmployee";
            this.cbTypeEmployee.Size = new System.Drawing.Size(277, 28);
            this.cbTypeEmployee.TabIndex = 4;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(271, 211);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(277, 25);
            this.tbEmail.TabIndex = 5;
            // 
            // tbPhonenumber
            // 
            this.tbPhonenumber.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhonenumber.Location = new System.Drawing.Point(271, 251);
            this.tbPhonenumber.Name = "tbPhonenumber";
            this.tbPhonenumber.Size = new System.Drawing.Size(277, 25);
            this.tbPhonenumber.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Haarlem",
            "Amsterdam",
            "Knuppeldam",
            "Headquarters (HQ)"});
            this.comboBox1.Location = new System.Drawing.Point(271, 291);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // checkBoxAccept
            // 
            this.checkBoxAccept.AutoSize = true;
            this.checkBoxAccept.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAccept.Location = new System.Drawing.Point(271, 331);
            this.checkBoxAccept.Name = "checkBoxAccept";
            this.checkBoxAccept.Size = new System.Drawing.Size(277, 24);
            this.checkBoxAccept.TabIndex = 8;
            this.checkBoxAccept.Text = "yes, a password e-mail will be sent to the user";
            this.checkBoxAccept.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(119, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(146, 17);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "First name:";
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(119, 134);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(146, 17);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last name:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(119, 174);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(146, 18);
            this.lblEmployee.TabIndex = 11;
            this.lblEmployee.Text = "Type of user:";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(119, 214);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(146, 17);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "E-mail address:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(119, 254);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(146, 17);
            this.lblPhoneNumber.TabIndex = 13;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(119, 294);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(146, 18);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "Location/branch:";
            // 
            // lblSendPassword
            // 
            this.lblSendPassword.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendPassword.Location = new System.Drawing.Point(119, 332);
            this.lblSendPassword.Name = "lblSendPassword";
            this.lblSendPassword.Size = new System.Drawing.Size(146, 18);
            this.lblSendPassword.TabIndex = 15;
            this.lblSendPassword.Text = "Send password?";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(271, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 43);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(408, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "ADD USER";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AddUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSendPassword);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.checkBoxAccept);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbPhonenumber);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.cbTypeEmployee);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblAddUserHeader);
            this.Name = "AddUserView";
            this.Size = new System.Drawing.Size(968, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddUserHeader;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.ComboBox cbTypeEmployee;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhonenumber;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBoxAccept;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblSendPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
    }
}
