namespace NOSQL_Project_groep8.View
{
    partial class DashboardIncidentsView
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
            this.borderUnresolvedIncidents = new System.Windows.Forms.Panel();
            this.boxUnresolvedIncidents = new System.Windows.Forms.Panel();
            this.lblDashboardUnresolvedIncidentsHeader = new System.Windows.Forms.Label();
            this.lblDashboardUnresolvedIncidentsSubtitle = new System.Windows.Forms.Label();
            this.circleDiagramUnresolvedIncidents = new CircularProgressBar.CircularProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDashboardIncidentsPastHeader = new System.Windows.Forms.Label();
            this.lblDashboardIncidentsPastSubtitle = new System.Windows.Forms.Label();
            this.circleDiagramPastIncidents = new CircularProgressBar.CircularProgressBar();
            this.btnShowListDashboard = new System.Windows.Forms.Button();
            this.lbDashboardHeader = new System.Windows.Forms.Label();
            this.borderUnresolvedIncidents.SuspendLayout();
            this.boxUnresolvedIncidents.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderUnresolvedIncidents
            // 
            this.borderUnresolvedIncidents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(154)))), ((int)(((byte)(35)))));
            this.borderUnresolvedIncidents.Controls.Add(this.boxUnresolvedIncidents);
            this.borderUnresolvedIncidents.Location = new System.Drawing.Point(95, 106);
            this.borderUnresolvedIncidents.Name = "borderUnresolvedIncidents";
            this.borderUnresolvedIncidents.Size = new System.Drawing.Size(387, 401);
            this.borderUnresolvedIncidents.TabIndex = 21;
            // 
            // boxUnresolvedIncidents
            // 
            this.boxUnresolvedIncidents.BackColor = System.Drawing.SystemColors.Window;
            this.boxUnresolvedIncidents.Controls.Add(this.lblDashboardUnresolvedIncidentsHeader);
            this.boxUnresolvedIncidents.Controls.Add(this.lblDashboardUnresolvedIncidentsSubtitle);
            this.boxUnresolvedIncidents.Controls.Add(this.circleDiagramUnresolvedIncidents);
            this.boxUnresolvedIncidents.Location = new System.Drawing.Point(4, 4);
            this.boxUnresolvedIncidents.Name = "boxUnresolvedIncidents";
            this.boxUnresolvedIncidents.Size = new System.Drawing.Size(380, 394);
            this.boxUnresolvedIncidents.TabIndex = 0;
            // 
            // lblDashboardUnresolvedIncidentsHeader
            // 
            this.lblDashboardUnresolvedIncidentsHeader.BackColor = System.Drawing.SystemColors.Window;
            this.lblDashboardUnresolvedIncidentsHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardUnresolvedIncidentsHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblDashboardUnresolvedIncidentsHeader.Location = new System.Drawing.Point(3, 29);
            this.lblDashboardUnresolvedIncidentsHeader.Name = "lblDashboardUnresolvedIncidentsHeader";
            this.lblDashboardUnresolvedIncidentsHeader.Size = new System.Drawing.Size(374, 24);
            this.lblDashboardUnresolvedIncidentsHeader.TabIndex = 3;
            this.lblDashboardUnresolvedIncidentsHeader.Text = "Unresolved incidents";
            this.lblDashboardUnresolvedIncidentsHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDashboardUnresolvedIncidentsSubtitle
            // 
            this.lblDashboardUnresolvedIncidentsSubtitle.BackColor = System.Drawing.SystemColors.Window;
            this.lblDashboardUnresolvedIncidentsSubtitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardUnresolvedIncidentsSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblDashboardUnresolvedIncidentsSubtitle.Location = new System.Drawing.Point(3, 64);
            this.lblDashboardUnresolvedIncidentsSubtitle.Name = "lblDashboardUnresolvedIncidentsSubtitle";
            this.lblDashboardUnresolvedIncidentsSubtitle.Size = new System.Drawing.Size(374, 18);
            this.lblDashboardUnresolvedIncidentsSubtitle.TabIndex = 4;
            this.lblDashboardUnresolvedIncidentsSubtitle.Text = "All tickets currently open";
            this.lblDashboardUnresolvedIncidentsSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // circleDiagramUnresolvedIncidents
            // 
            this.circleDiagramUnresolvedIncidents.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circleDiagramUnresolvedIncidents.AnimationSpeed = 500;
            this.circleDiagramUnresolvedIncidents.BackColor = System.Drawing.SystemColors.Window;
            this.circleDiagramUnresolvedIncidents.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleDiagramUnresolvedIncidents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.circleDiagramUnresolvedIncidents.InnerColor = System.Drawing.Color.White;
            this.circleDiagramUnresolvedIncidents.InnerMargin = 2;
            this.circleDiagramUnresolvedIncidents.InnerWidth = -1;
            this.circleDiagramUnresolvedIncidents.Location = new System.Drawing.Point(65, 120);
            this.circleDiagramUnresolvedIncidents.Margin = new System.Windows.Forms.Padding(0);
            this.circleDiagramUnresolvedIncidents.MarqueeAnimationSpeed = 2000;
            this.circleDiagramUnresolvedIncidents.Name = "circleDiagramUnresolvedIncidents";
            this.circleDiagramUnresolvedIncidents.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.circleDiagramUnresolvedIncidents.OuterMargin = -40;
            this.circleDiagramUnresolvedIncidents.OuterWidth = 40;
            this.circleDiagramUnresolvedIncidents.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(154)))), ((int)(((byte)(35)))));
            this.circleDiagramUnresolvedIncidents.ProgressWidth = 40;
            this.circleDiagramUnresolvedIncidents.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circleDiagramUnresolvedIncidents.Size = new System.Drawing.Size(250, 250);
            this.circleDiagramUnresolvedIncidents.StartAngle = 270;
            this.circleDiagramUnresolvedIncidents.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleDiagramUnresolvedIncidents.SubscriptMargin = new System.Windows.Forms.Padding(10, -40, 0, 0);
            this.circleDiagramUnresolvedIncidents.SubscriptText = "";
            this.circleDiagramUnresolvedIncidents.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleDiagramUnresolvedIncidents.SuperscriptMargin = new System.Windows.Forms.Padding(10, 40, 0, 0);
            this.circleDiagramUnresolvedIncidents.SuperscriptText = "";
            this.circleDiagramUnresolvedIncidents.TabIndex = 0;
            this.circleDiagramUnresolvedIncidents.Text = "1/2";
            this.circleDiagramUnresolvedIncidents.TextMargin = new System.Windows.Forms.Padding(0);
            this.circleDiagramUnresolvedIncidents.Value = 68;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(504, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 401);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.lblDashboardIncidentsPastHeader);
            this.panel2.Controls.Add(this.lblDashboardIncidentsPastSubtitle);
            this.panel2.Controls.Add(this.circleDiagramPastIncidents);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 394);
            this.panel2.TabIndex = 0;
            // 
            // lblDashboardIncidentsPastHeader
            // 
            this.lblDashboardIncidentsPastHeader.BackColor = System.Drawing.SystemColors.Window;
            this.lblDashboardIncidentsPastHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardIncidentsPastHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblDashboardIncidentsPastHeader.Location = new System.Drawing.Point(3, 29);
            this.lblDashboardIncidentsPastHeader.Name = "lblDashboardIncidentsPastHeader";
            this.lblDashboardIncidentsPastHeader.Size = new System.Drawing.Size(374, 24);
            this.lblDashboardIncidentsPastHeader.TabIndex = 3;
            this.lblDashboardIncidentsPastHeader.Text = "Incidents past deadline";
            this.lblDashboardIncidentsPastHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDashboardIncidentsPastSubtitle
            // 
            this.lblDashboardIncidentsPastSubtitle.BackColor = System.Drawing.SystemColors.Window;
            this.lblDashboardIncidentsPastSubtitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardIncidentsPastSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblDashboardIncidentsPastSubtitle.Location = new System.Drawing.Point(3, 64);
            this.lblDashboardIncidentsPastSubtitle.Name = "lblDashboardIncidentsPastSubtitle";
            this.lblDashboardIncidentsPastSubtitle.Size = new System.Drawing.Size(374, 18);
            this.lblDashboardIncidentsPastSubtitle.TabIndex = 4;
            this.lblDashboardIncidentsPastSubtitle.Text = "These tickets need your immediate attention";
            this.lblDashboardIncidentsPastSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // circleDiagramPastIncidents
            // 
            this.circleDiagramPastIncidents.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circleDiagramPastIncidents.AnimationSpeed = 500;
            this.circleDiagramPastIncidents.BackColor = System.Drawing.SystemColors.Window;
            this.circleDiagramPastIncidents.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleDiagramPastIncidents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.circleDiagramPastIncidents.InnerColor = System.Drawing.Color.White;
            this.circleDiagramPastIncidents.InnerMargin = 2;
            this.circleDiagramPastIncidents.InnerWidth = -1;
            this.circleDiagramPastIncidents.Location = new System.Drawing.Point(65, 120);
            this.circleDiagramPastIncidents.Margin = new System.Windows.Forms.Padding(0);
            this.circleDiagramPastIncidents.MarqueeAnimationSpeed = 2000;
            this.circleDiagramPastIncidents.Name = "circleDiagramPastIncidents";
            this.circleDiagramPastIncidents.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.circleDiagramPastIncidents.OuterMargin = -40;
            this.circleDiagramPastIncidents.OuterWidth = 40;
            this.circleDiagramPastIncidents.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(27)))));
            this.circleDiagramPastIncidents.ProgressWidth = 40;
            this.circleDiagramPastIncidents.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circleDiagramPastIncidents.Size = new System.Drawing.Size(250, 250);
            this.circleDiagramPastIncidents.StartAngle = 270;
            this.circleDiagramPastIncidents.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleDiagramPastIncidents.SubscriptMargin = new System.Windows.Forms.Padding(10, -40, 0, 0);
            this.circleDiagramPastIncidents.SubscriptText = "";
            this.circleDiagramPastIncidents.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleDiagramPastIncidents.SuperscriptMargin = new System.Windows.Forms.Padding(10, 40, 0, 0);
            this.circleDiagramPastIncidents.SuperscriptText = "";
            this.circleDiagramPastIncidents.TabIndex = 1;
            this.circleDiagramPastIncidents.Text = "0";
            this.circleDiagramPastIncidents.TextMargin = new System.Windows.Forms.Padding(0);
            this.circleDiagramPastIncidents.Value = 68;
            // 
            // btnShowListDashboard
            // 
            this.btnShowListDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(155)))), ((int)(((byte)(213)))));
            this.btnShowListDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowListDashboard.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowListDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowListDashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowListDashboard.ForeColor = System.Drawing.SystemColors.Window;
            this.btnShowListDashboard.Location = new System.Drawing.Point(785, 55);
            this.btnShowListDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowListDashboard.Name = "btnShowListDashboard";
            this.btnShowListDashboard.Size = new System.Drawing.Size(152, 46);
            this.btnShowListDashboard.TabIndex = 19;
            this.btnShowListDashboard.Text = "SHOW LIST";
            this.btnShowListDashboard.UseVisualStyleBackColor = false;
            this.btnShowListDashboard.Click += new System.EventHandler(this.btnShowListDashboard_Click);
            // 
            // lbDashboardHeader
            // 
            this.lbDashboardHeader.AutoSize = true;
            this.lbDashboardHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDashboardHeader.Location = new System.Drawing.Point(16, 15);
            this.lbDashboardHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDashboardHeader.Name = "lbDashboardHeader";
            this.lbDashboardHeader.Size = new System.Drawing.Size(270, 34);
            this.lbDashboardHeader.TabIndex = 18;
            this.lbDashboardHeader.Text = "Current incidents";
            // 
            // DashboardIncidentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.borderUnresolvedIncidents);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShowListDashboard);
            this.Controls.Add(this.lbDashboardHeader);
            this.Name = "DashboardIncidentsView";
            this.Size = new System.Drawing.Size(968, 523);
            this.Load += new System.EventHandler(this.DashboardIncidentsView_Load);
            this.borderUnresolvedIncidents.ResumeLayout(false);
            this.boxUnresolvedIncidents.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel borderUnresolvedIncidents;
        private System.Windows.Forms.Panel boxUnresolvedIncidents;
        private System.Windows.Forms.Label lblDashboardUnresolvedIncidentsHeader;
        private System.Windows.Forms.Label lblDashboardUnresolvedIncidentsSubtitle;
        private CircularProgressBar.CircularProgressBar circleDiagramUnresolvedIncidents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDashboardIncidentsPastHeader;
        private System.Windows.Forms.Label lblDashboardIncidentsPastSubtitle;
        private CircularProgressBar.CircularProgressBar circleDiagramPastIncidents;
        private System.Windows.Forms.Button btnShowListDashboard;
        private System.Windows.Forms.Label lbDashboardHeader;
    }
}
