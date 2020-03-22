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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddIncident = new System.Windows.Forms.Button();
            this.Btn_cancelCreationIncident = new System.Windows.Forms.Button();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.dtp_dateTimeReported = new System.Windows.Forms.DateTimePicker();
            this.Lbl_description = new System.Windows.Forms.Label();
            this.Lbl_deadlineFollowup = new System.Windows.Forms.Label();
            this.Lbl_priority = new System.Windows.Forms.Label();
            this.Lbl_reportedByUser = new System.Windows.Forms.Label();
            this.Lbl_typeOfIncident = new System.Windows.Forms.Label();
            this.Lbl_subjectIcident = new System.Windows.Forms.Label();
            this.Lbl_dateTime = new System.Windows.Forms.Label();
            this.cb_deadlineFollowUp = new System.Windows.Forms.ComboBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
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
            this.cbUsers.Location = new System.Drawing.Point(208, 173);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(200, 21);
            this.cbUsers.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Status";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(208, 101);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(200, 20);
            this.txtSubject.TabIndex = 14;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(633, 101);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(200, 21);
            this.cbStatus.TabIndex = 23;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(208, 204);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(200, 21);
            this.cbPriority.TabIndex = 25;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(208, 136);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(200, 21);
            this.cbType.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Location";
            // 
            // btnAddIncident
            // 
            this.btnAddIncident.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIncident.ForeColor = System.Drawing.Color.White;
            this.btnAddIncident.Location = new System.Drawing.Point(507, 432);
            this.btnAddIncident.Name = "btnAddIncident";
            this.btnAddIncident.Size = new System.Drawing.Size(137, 41);
            this.btnAddIncident.TabIndex = 45;
            this.btnAddIncident.Text = "SUBMIT TICKET";
            this.btnAddIncident.UseVisualStyleBackColor = false;
            this.btnAddIncident.Click += new System.EventHandler(this.btnAddIncident_Click);
            // 
            // Btn_cancelCreationIncident
            // 
            this.Btn_cancelCreationIncident.BackColor = System.Drawing.Color.White;
            this.Btn_cancelCreationIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cancelCreationIncident.Location = new System.Drawing.Point(347, 432);
            this.Btn_cancelCreationIncident.Name = "Btn_cancelCreationIncident";
            this.Btn_cancelCreationIncident.Size = new System.Drawing.Size(137, 41);
            this.Btn_cancelCreationIncident.TabIndex = 44;
            this.Btn_cancelCreationIncident.Text = "CANCEL";
            this.Btn_cancelCreationIncident.UseVisualStyleBackColor = false;
            this.Btn_cancelCreationIncident.Click += new System.EventHandler(this.Btn_cancelCreationIncident_Click);
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(633, 136);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(292, 178);
            this.txt_description.TabIndex = 43;
            this.txt_description.Text = "";
            // 
            // dtp_dateTimeReported
            // 
            this.dtp_dateTimeReported.Location = new System.Drawing.Point(208, 70);
            this.dtp_dateTimeReported.Name = "dtp_dateTimeReported";
            this.dtp_dateTimeReported.Size = new System.Drawing.Size(200, 20);
            this.dtp_dateTimeReported.TabIndex = 37;
            // 
            // Lbl_description
            // 
            this.Lbl_description.AutoSize = true;
            this.Lbl_description.Location = new System.Drawing.Point(564, 139);
            this.Lbl_description.Name = "Lbl_description";
            this.Lbl_description.Size = new System.Drawing.Size(63, 13);
            this.Lbl_description.TabIndex = 36;
            this.Lbl_description.Text = "Description:";
            // 
            // Lbl_deadlineFollowup
            // 
            this.Lbl_deadlineFollowup.AutoSize = true;
            this.Lbl_deadlineFollowup.Location = new System.Drawing.Point(20, 238);
            this.Lbl_deadlineFollowup.Name = "Lbl_deadlineFollowup";
            this.Lbl_deadlineFollowup.Size = new System.Drawing.Size(102, 13);
            this.Lbl_deadlineFollowup.TabIndex = 35;
            this.Lbl_deadlineFollowup.Text = "Deadline/Follow up:";
            // 
            // Lbl_priority
            // 
            this.Lbl_priority.AutoSize = true;
            this.Lbl_priority.Location = new System.Drawing.Point(20, 207);
            this.Lbl_priority.Name = "Lbl_priority";
            this.Lbl_priority.Size = new System.Drawing.Size(41, 13);
            this.Lbl_priority.TabIndex = 34;
            this.Lbl_priority.Text = "Priority:";
            // 
            // Lbl_reportedByUser
            // 
            this.Lbl_reportedByUser.AutoSize = true;
            this.Lbl_reportedByUser.Location = new System.Drawing.Point(20, 173);
            this.Lbl_reportedByUser.Name = "Lbl_reportedByUser";
            this.Lbl_reportedByUser.Size = new System.Drawing.Size(91, 13);
            this.Lbl_reportedByUser.TabIndex = 33;
            this.Lbl_reportedByUser.Text = "Reported by user:";
            // 
            // Lbl_typeOfIncident
            // 
            this.Lbl_typeOfIncident.AutoSize = true;
            this.Lbl_typeOfIncident.Location = new System.Drawing.Point(20, 139);
            this.Lbl_typeOfIncident.Name = "Lbl_typeOfIncident";
            this.Lbl_typeOfIncident.Size = new System.Drawing.Size(86, 13);
            this.Lbl_typeOfIncident.TabIndex = 32;
            this.Lbl_typeOfIncident.Text = "Type of incident:";
            // 
            // Lbl_subjectIcident
            // 
            this.Lbl_subjectIcident.AutoSize = true;
            this.Lbl_subjectIcident.Location = new System.Drawing.Point(20, 108);
            this.Lbl_subjectIcident.Name = "Lbl_subjectIcident";
            this.Lbl_subjectIcident.Size = new System.Drawing.Size(95, 13);
            this.Lbl_subjectIcident.TabIndex = 31;
            this.Lbl_subjectIcident.Text = "Subject of incident";
            // 
            // Lbl_dateTime
            // 
            this.Lbl_dateTime.AutoSize = true;
            this.Lbl_dateTime.Location = new System.Drawing.Point(19, 76);
            this.Lbl_dateTime.Name = "Lbl_dateTime";
            this.Lbl_dateTime.Size = new System.Drawing.Size(103, 13);
            this.Lbl_dateTime.TabIndex = 30;
            this.Lbl_dateTime.Text = "Date/Time reported:";
            // 
            // cb_deadlineFollowUp
            // 
            this.cb_deadlineFollowUp.FormattingEnabled = true;
            this.cb_deadlineFollowUp.Location = new System.Drawing.Point(208, 238);
            this.cb_deadlineFollowUp.Name = "cb_deadlineFollowUp";
            this.cb_deadlineFollowUp.Size = new System.Drawing.Size(200, 21);
            this.cb_deadlineFollowUp.TabIndex = 46;
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(633, 73);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(200, 21);
            this.cbLocation.TabIndex = 47;
            // 
            // CreateIncidenetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.cb_deadlineFollowUp);
            this.Controls.Add(this.btnAddIncident);
            this.Controls.Add(this.Btn_cancelCreationIncident);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.dtp_dateTimeReported);
            this.Controls.Add(this.Lbl_description);
            this.Controls.Add(this.Lbl_deadlineFollowup);
            this.Controls.Add(this.Lbl_priority);
            this.Controls.Add(this.Lbl_reportedByUser);
            this.Controls.Add(this.Lbl_typeOfIncident);
            this.Controls.Add(this.Lbl_subjectIcident);
            this.Controls.Add(this.Lbl_dateTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbUsers);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddIncident;
        private System.Windows.Forms.Button Btn_cancelCreationIncident;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.DateTimePicker dtp_dateTimeReported;
        private System.Windows.Forms.Label Lbl_description;
        private System.Windows.Forms.Label Lbl_deadlineFollowup;
        private System.Windows.Forms.Label Lbl_priority;
        private System.Windows.Forms.Label Lbl_reportedByUser;
        private System.Windows.Forms.Label Lbl_typeOfIncident;
        private System.Windows.Forms.Label Lbl_subjectIcident;
        private System.Windows.Forms.Label Lbl_dateTime;
        private System.Windows.Forms.ComboBox cb_deadlineFollowUp;
        private System.Windows.Forms.ComboBox cbLocation;
    }
}
