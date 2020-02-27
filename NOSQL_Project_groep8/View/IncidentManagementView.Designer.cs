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
            // IncidentManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnCreateIncident);
            this.Controls.Add(this.lbIncidentManagement);
            this.Name = "IncidentManagementView";
            this.Size = new System.Drawing.Size(968, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateIncident;
        private System.Windows.Forms.Label lbIncidentManagement;
    }
}
