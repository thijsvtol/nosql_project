namespace NOSQL_Project_groep8.View
{
    partial class IncidentManagementView
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
            this.btnCreateIncident = new System.Windows.Forms.Button();
            this.lbIncidentManagement = new System.Windows.Forms.Label();
            this.lv_incidents = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_filterTickets = new System.Windows.Forms.TextBox();
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnCreateIncident
            // 
            this.btnCreateIncident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btnCreateIncident.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateIncident.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCreateIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateIncident.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateIncident.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCreateIncident.Location = new System.Drawing.Point(785, 55);
            this.btnCreateIncident.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateIncident.Name = "btnCreateIncident";
            this.btnCreateIncident.Size = new System.Drawing.Size(152, 46);
            this.btnCreateIncident.TabIndex = 21;
            this.btnCreateIncident.Text = "CREATE INCIDENT";
            this.btnCreateIncident.UseVisualStyleBackColor = false;
            this.btnCreateIncident.Click += new System.EventHandler(this.btnCreateIncident_Click);
            // 
            // lbIncidentManagement
            // 
            this.lbIncidentManagement.AutoSize = true;
            this.lbIncidentManagement.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIncidentManagement.Location = new System.Drawing.Point(16, 15);
            this.lbIncidentManagement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIncidentManagement.Name = "lbIncidentManagement";
            this.lbIncidentManagement.Size = new System.Drawing.Size(259, 34);
            this.lbIncidentManagement.TabIndex = 20;
            this.lbIncidentManagement.Text = "Overview tickets";
            // 
            // lv_incidents
            // 
            this.lv_incidents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Subject,
            this.Email,
            this.User,
            this.UserID,
            this.Date,
            this.Status});
            this.lv_incidents.HideSelection = false;
            this.lv_incidents.Location = new System.Drawing.Point(22, 120);
            this.lv_incidents.Name = "lv_incidents";
            this.lv_incidents.Size = new System.Drawing.Size(915, 383);
            this.lv_incidents.TabIndex = 23;
            this.lv_incidents.UseCompatibleStateImageBehavior = false;
            this.lv_incidents.View = System.Windows.Forms.View.Details;
            this.lv_incidents.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_incidents_ColumnClick);
            this.lv_incidents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_incidents_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 52;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 79;
            // 
            // User
            // 
            this.User.Text = "User";
            // 
            // UserID
            // 
            this.UserID.Text = "User ID";
            // 
            // Date
            // 
            this.Date.Text = "Date";
            // 
            // txt_filterTickets
            // 
            this.txt_filterTickets.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filterTickets.Location = new System.Drawing.Point(22, 55);
            this.txt_filterTickets.Name = "txt_filterTickets";
            this.txt_filterTickets.Size = new System.Drawing.Size(238, 46);
            this.txt_filterTickets.TabIndex = 24;
            this.txt_filterTickets.TextChanged += new System.EventHandler(this.txt_filterTickets_TextChanged);
            // 
            // Status
            // 
            this.Status.Text = "Status";
            // 
            // IncidentManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.txt_filterTickets);
            this.Controls.Add(this.lv_incidents);
            this.Controls.Add(this.btnCreateIncident);
            this.Controls.Add(this.lbIncidentManagement);
            this.Name = "IncidentManagementView";
            this.Size = new System.Drawing.Size(968, 523);
            this.Load += new System.EventHandler(this.IncidentManagementView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateIncident;
        private System.Windows.Forms.Label lbIncidentManagement;
        private System.Windows.Forms.ListView lv_incidents;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader UserID;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.TextBox txt_filterTickets;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader Status;
    }
}
