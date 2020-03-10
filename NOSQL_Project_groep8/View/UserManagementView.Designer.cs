namespace NOSQL_Project_groep8.View
{
    partial class UserManagementView
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
            System.Windows.Forms.ColumnHeader UserID;
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.lblUserManagementHeader = new System.Windows.Forms.Label();
            this.listViewUser = new System.Windows.Forms.ListView();
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tickets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtFilterEmail = new System.Windows.Forms.TextBox();
            UserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // UserID
            // 
            UserID.Text = "ID";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(242)))), ((int)(((byte)(4)))));
            this.btnAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.Location = new System.Drawing.Point(785, 55);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(152, 46);
            this.btnAddNewUser.TabIndex = 4;
            this.btnAddNewUser.Text = "+ ADD NEW USER";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // lblUserManagementHeader
            // 
            this.lblUserManagementHeader.AutoSize = true;
            this.lblUserManagementHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserManagementHeader.Location = new System.Drawing.Point(16, 15);
            this.lblUserManagementHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserManagementHeader.Name = "lblUserManagementHeader";
            this.lblUserManagementHeader.Size = new System.Drawing.Size(283, 34);
            this.lblUserManagementHeader.TabIndex = 3;
            this.lblUserManagementHeader.Text = "User Management";
            // 
            // listViewUser
            // 
            this.listViewUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            UserID,
            this.email,
            this.userFName,
            this.UserLName,
            this.tickets});
            this.listViewUser.HideSelection = false;
            this.listViewUser.Location = new System.Drawing.Point(22, 125);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(900, 367);
            this.listViewUser.TabIndex = 8;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.Details;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 339;
            // 
            // userFName
            // 
            this.userFName.Text = "First Name";
            this.userFName.Width = 213;
            // 
            // UserLName
            // 
            this.UserLName.Text = "Last Name";
            this.UserLName.Width = 147;
            // 
            // tickets
            // 
            this.tickets.Text = "# tickets";
            this.tickets.Width = 132;
            // 
            // txtFilterEmail
            // 
            this.txtFilterEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterEmail.Location = new System.Drawing.Point(22, 62);
            this.txtFilterEmail.Name = "txtFilterEmail";
            this.txtFilterEmail.Size = new System.Drawing.Size(277, 39);
            this.txtFilterEmail.TabIndex = 7;
            this.txtFilterEmail.Tag = "";
            this.txtFilterEmail.TextChanged += new System.EventHandler(this.txtFilterEmail_TextChanged);
            // 
            // UserManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.listViewUser);
            this.Controls.Add(this.txtFilterEmail);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.lblUserManagementHeader);
            this.Name = "UserManagementView";
            this.Size = new System.Drawing.Size(968, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label lblUserManagementHeader;
        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader userFName;
        private System.Windows.Forms.ColumnHeader UserLName;
        private System.Windows.Forms.ColumnHeader tickets;
        private System.Windows.Forms.TextBox txtFilterEmail;
    }
}
