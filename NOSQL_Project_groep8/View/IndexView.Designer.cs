namespace NOSQL_Project_groep8
{
    partial class Index
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.menuUserManagement = new System.Windows.Forms.Button();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.menuIncidentManagement = new System.Windows.Forms.Button();
            this.menuDashboard = new System.Windows.Forms.Button();
            this.lblHeader1 = new System.Windows.Forms.Label();
            this.HeaderLogo = new System.Windows.Forms.PictureBox();
            this.UCincidentManagementView = new NOSQL_Project_groep8.View.IncidentManagementView();
            this.UCcreateIncidenetView = new NOSQL_Project_groep8.View.CreateIncidenetView();
            this.UCdashboardIncidentsView = new NOSQL_Project_groep8.View.DashboardIncidentsView();
            this.UCaddUserView = new NOSQL_Project_groep8.View.AddUserView();
            this.UCloginView = new NOSQL_Project_groep8.View.LoginView();
            this.UCuserManagementView = new NOSQL_Project_groep8.View.UserManagementView();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.menuUserManagement);
            this.pnlHeader.Controls.Add(this.lblHeader2);
            this.pnlHeader.Controls.Add(this.menuIncidentManagement);
            this.pnlHeader.Controls.Add(this.menuDashboard);
            this.pnlHeader.Controls.Add(this.lblHeader1);
            this.pnlHeader.Controls.Add(this.HeaderLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(968, 112);
            this.pnlHeader.TabIndex = 1;
            // 
            // menuUserManagement
            // 
            this.menuUserManagement.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menuUserManagement.BackColor = System.Drawing.SystemColors.Window;
            this.menuUserManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuUserManagement.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.menuUserManagement.FlatAppearance.BorderSize = 2;
            this.menuUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuUserManagement.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuUserManagement.Location = new System.Drawing.Point(646, 79);
            this.menuUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.menuUserManagement.Name = "menuUserManagement";
            this.menuUserManagement.Size = new System.Drawing.Size(322, 32);
            this.menuUserManagement.TabIndex = 4;
            this.menuUserManagement.Text = "User Management";
            this.menuUserManagement.UseVisualStyleBackColor = false;
            this.menuUserManagement.Click += new System.EventHandler(this.menuUserManagement_Click);
            // 
            // lblHeader2
            // 
            this.lblHeader2.AutoSize = true;
            this.lblHeader2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader2.Location = new System.Drawing.Point(718, 47);
            this.lblHeader2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(251, 19);
            this.lblHeader2.TabIndex = 2;
            this.lblHeader2.Text = "Licensed to: The Garden Group ";
            this.lblHeader2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // menuIncidentManagement
            // 
            this.menuIncidentManagement.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menuIncidentManagement.BackColor = System.Drawing.SystemColors.Window;
            this.menuIncidentManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuIncidentManagement.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.menuIncidentManagement.FlatAppearance.BorderSize = 2;
            this.menuIncidentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuIncidentManagement.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuIncidentManagement.Location = new System.Drawing.Point(320, 79);
            this.menuIncidentManagement.Margin = new System.Windows.Forms.Padding(2);
            this.menuIncidentManagement.Name = "menuIncidentManagement";
            this.menuIncidentManagement.Size = new System.Drawing.Size(327, 32);
            this.menuIncidentManagement.TabIndex = 3;
            this.menuIncidentManagement.Text = "Incident Management";
            this.menuIncidentManagement.UseVisualStyleBackColor = false;
            this.menuIncidentManagement.Click += new System.EventHandler(this.menuIncidentManagement_Click);
            // 
            // menuDashboard
            // 
            this.menuDashboard.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menuDashboard.BackColor = System.Drawing.SystemColors.Window;
            this.menuDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuDashboard.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.menuDashboard.FlatAppearance.BorderSize = 2;
            this.menuDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuDashboard.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuDashboard.Location = new System.Drawing.Point(-1, 79);
            this.menuDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.menuDashboard.Name = "menuDashboard";
            this.menuDashboard.Size = new System.Drawing.Size(322, 32);
            this.menuDashboard.TabIndex = 2;
            this.menuDashboard.Text = "Dashboard";
            this.menuDashboard.UseVisualStyleBackColor = false;
            this.menuDashboard.Click += new System.EventHandler(this.menuDashboard_Click);
            // 
            // lblHeader1
            // 
            this.lblHeader1.AutoSize = true;
            this.lblHeader1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader1.Location = new System.Drawing.Point(850, 7);
            this.lblHeader1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader1.Name = "lblHeader1";
            this.lblHeader1.Size = new System.Drawing.Size(116, 32);
            this.lblHeader1.TabIndex = 1;
            this.lblHeader1.Text = "NoDesk";
            this.lblHeader1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // HeaderLogo
            // 
            this.HeaderLogo.Image = global::NOSQL_Project_groep8.Properties.Resources.The_Garden_Group_LOGO;
            this.HeaderLogo.Location = new System.Drawing.Point(0, 0);
            this.HeaderLogo.Margin = new System.Windows.Forms.Padding(2);
            this.HeaderLogo.Name = "HeaderLogo";
            this.HeaderLogo.Size = new System.Drawing.Size(128, 81);
            this.HeaderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeaderLogo.TabIndex = 0;
            this.HeaderLogo.TabStop = false;
            // 
            // UCincidentManagementView
            // 
            this.UCincidentManagementView.BackColor = System.Drawing.SystemColors.Window;
            this.UCincidentManagementView.Location = new System.Drawing.Point(1, 118);
            this.UCincidentManagementView.Name = "UCincidentManagementView";
            this.UCincidentManagementView.Size = new System.Drawing.Size(968, 523);
            this.UCincidentManagementView.TabIndex = 7;
            this.UCincidentManagementView.Visible = false;
            // 
            // UCcreateIncidenetView
            // 
            this.UCcreateIncidenetView.BackColor = System.Drawing.SystemColors.Window;
            this.UCcreateIncidenetView.Location = new System.Drawing.Point(-1, 118);
            this.UCcreateIncidenetView.Name = "UCcreateIncidenetView";
            this.UCcreateIncidenetView.Size = new System.Drawing.Size(968, 523);
            this.UCcreateIncidenetView.TabIndex = 5;
            this.UCcreateIncidenetView.Visible = false;
            // 
            // UCdashboardIncidentsView
            // 
            this.UCdashboardIncidentsView.BackColor = System.Drawing.SystemColors.Window;
            this.UCdashboardIncidentsView.Location = new System.Drawing.Point(-1, 118);
            this.UCdashboardIncidentsView.Name = "UCdashboardIncidentsView";
            this.UCdashboardIncidentsView.Size = new System.Drawing.Size(968, 523);
            this.UCdashboardIncidentsView.TabIndex = 5;
            this.UCdashboardIncidentsView.Visible = false;
            // 
            // UCaddUserView
            // 
            this.UCaddUserView.BackColor = System.Drawing.SystemColors.Window;
            this.UCaddUserView.Location = new System.Drawing.Point(-1, 118);
            this.UCaddUserView.Name = "UCaddUserView";
            this.UCaddUserView.Size = new System.Drawing.Size(968, 523);
            this.UCaddUserView.TabIndex = 4;
            this.UCaddUserView.Visible = false;
            // 
            // UCloginView
            // 
            this.UCloginView.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UCloginView.Location = new System.Drawing.Point(308, 176);
            this.UCloginView.Name = "UCloginView";
            this.UCloginView.Size = new System.Drawing.Size(327, 437);
            this.UCloginView.TabIndex = 3;
            // 
            // UCuserManagementView
            // 
            this.UCuserManagementView.BackColor = System.Drawing.SystemColors.Window;
            this.UCuserManagementView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UCuserManagementView.Location = new System.Drawing.Point(0, 118);
            this.UCuserManagementView.Name = "UCuserManagementView";
            this.UCuserManagementView.Size = new System.Drawing.Size(968, 523);
            this.UCuserManagementView.TabIndex = 2;
            this.UCuserManagementView.Visible = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(968, 641);
            this.Controls.Add(this.UCincidentManagementView);
            this.Controls.Add(this.UCcreateIncidenetView);
            this.Controls.Add(this.UCdashboardIncidentsView);
            this.Controls.Add(this.UCaddUserView);
            this.Controls.Add(this.UCloginView);
            this.Controls.Add(this.UCuserManagementView);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Index";
            this.Text = "The Garden Group - NoDesk";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox HeaderLogo;
        private System.Windows.Forms.Label lblHeader1;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.Button menuDashboard;
        private System.Windows.Forms.Button menuIncidentManagement;
        private System.Windows.Forms.Button menuUserManagement;
        private View.UserManagementView UCuserManagementView;
        private View.LoginView UCloginView;
        private View.AddUserView UCaddUserView;
        private View.CreateIncidenetView UCcreateIncidenetView;
        private View.DashboardIncidentsView UCdashboardIncidentsView;
        private View.IncidentManagementView UCincidentManagementView;
    }
}

