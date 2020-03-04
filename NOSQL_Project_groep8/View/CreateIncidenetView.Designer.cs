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
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
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
            this.label2.Location = new System.Drawing.Point(76, 89);
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
            this.label3.Location = new System.Drawing.Point(76, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Status";
            // 
            // Deadline
            // 
            this.Deadline.AutoSize = true;
            this.Deadline.Location = new System.Drawing.Point(76, 145);
            this.Deadline.Name = "Deadline";
            this.Deadline.Size = new System.Drawing.Size(49, 13);
            this.Deadline.TabIndex = 18;
            this.Deadline.Text = "Deadline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Subject";
            // 
            // dtpDeadlineDate
            // 
            this.dtpDeadlineDate.Location = new System.Drawing.Point(188, 139);
            this.dtpDeadlineDate.Name = "dtpDeadlineDate";
            this.dtpDeadlineDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDeadlineDate.TabIndex = 15;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(188, 113);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(145, 20);
            this.txtSubject.TabIndex = 14;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(188, 165);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(145, 21);
            this.cbStatus.TabIndex = 23;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(188, 219);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(145, 21);
            this.cbPriority.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Priority";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(188, 192);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(145, 21);
            this.cbType.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(188, 246);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(145, 20);
            this.txtLocation.TabIndex = 28;
            // 
            // CreateIncidenetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLocation;
    }
}
