namespace NOSQL_Project_groep8.View
{
    partial class CreateIncidenetView
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
            this.lblCreateIncidentHeader = new System.Windows.Forms.Label();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddIncident = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Deadline = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDeadlineDate = new System.Windows.Forms.DateTimePicker();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCreateIncidentHeader
            // 
            this.lblCreateIncidentHeader.AutoSize = true;
            this.lblCreateIncidentHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateIncidentHeader.Location = new System.Drawing.Point(16, 15);
            this.lblCreateIncidentHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateIncidentHeader.Name = "lblCreateIncidentHeader";
            this.lblCreateIncidentHeader.Size = new System.Drawing.Size(242, 34);
            this.lblCreateIncidentHeader.TabIndex = 1;
            this.lblCreateIncidentHeader.Text = "Create Incident";
            // 
            // cbUsers
            // 
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(188, 86);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(145, 21);
            this.cbUsers.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "User";
            // 
            // btnAddIncident
            // 
            this.btnAddIncident.Location = new System.Drawing.Point(113, 349);
            this.btnAddIncident.Name = "btnAddIncident";
            this.btnAddIncident.Size = new System.Drawing.Size(75, 23);
            this.btnAddIncident.TabIndex = 20;
            this.btnAddIncident.Text = "Save Incident";
            this.btnAddIncident.UseVisualStyleBackColor = true;
            this.btnAddIncident.Click += new System.EventHandler(this.btnAddIncident_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Status";
            // 
            // Deadline
            // 
            this.Deadline.AutoSize = true;
            this.Deadline.Location = new System.Drawing.Point(76, 192);
            this.Deadline.Name = "Deadline";
            this.Deadline.Size = new System.Drawing.Size(49, 13);
            this.Deadline.TabIndex = 18;
            this.Deadline.Text = "Deadline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Subject";
            // 
            // dtpDeadlineDate
            // 
            this.dtpDeadlineDate.Location = new System.Drawing.Point(188, 192);
            this.dtpDeadlineDate.Name = "dtpDeadlineDate";
            this.dtpDeadlineDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDeadlineDate.TabIndex = 15;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(188, 128);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(145, 20);
            this.txtSubject.TabIndex = 14;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(188, 252);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(145, 21);
            this.cbStatus.TabIndex = 23;
            // 
            // CreateIncidenetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddIncident);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Deadline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDeadlineDate);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblCreateIncidentHeader);
            this.Name = "CreateIncidenetView";
            this.Size = new System.Drawing.Size(968, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateIncidentHeader;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddIncident;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Deadline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDeadlineDate;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}
