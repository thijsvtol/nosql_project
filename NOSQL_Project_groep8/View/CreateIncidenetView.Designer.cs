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
            // CreateIncidenetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lblCreateIncidentHeader);
            this.Name = "CreateIncidenetView";
            this.Size = new System.Drawing.Size(968, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateIncidentHeader;
    }
}
