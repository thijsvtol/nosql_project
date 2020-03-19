namespace NOSQL_Project_groep8.View
{
    partial class ImportView
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
            this.fdImport = new System.Windows.Forms.OpenFileDialog();
            this.lblImport = new System.Windows.Forms.Label();
            this.lblChooseTable = new System.Windows.Forms.Label();
            this.rbIncident = new System.Windows.Forms.RadioButton();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblSelectFile = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fdImport
            // 
            this.fdImport.FileName = "file";
            this.fdImport.Filter = "CSV Files (*.csv)|*.csv";
            // 
            // lblImport
            // 
            this.lblImport.AutoSize = true;
            this.lblImport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImport.Location = new System.Drawing.Point(16, 15);
            this.lblImport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(112, 34);
            this.lblImport.TabIndex = 21;
            this.lblImport.Text = "Import";
            // 
            // lblChooseTable
            // 
            this.lblChooseTable.AutoSize = true;
            this.lblChooseTable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseTable.Location = new System.Drawing.Point(18, 91);
            this.lblChooseTable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChooseTable.Name = "lblChooseTable";
            this.lblChooseTable.Size = new System.Drawing.Size(326, 18);
            this.lblChooseTable.TabIndex = 22;
            this.lblChooseTable.Text = "Choose a datatable for import data (.CSV file)";
            // 
            // rbIncident
            // 
            this.rbIncident.AutoSize = true;
            this.rbIncident.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIncident.Location = new System.Drawing.Point(22, 126);
            this.rbIncident.Name = "rbIncident";
            this.rbIncident.Size = new System.Drawing.Size(87, 22);
            this.rbIncident.TabIndex = 23;
            this.rbIncident.TabStop = true;
            this.rbIncident.Text = "Incidents";
            this.rbIncident.UseVisualStyleBackColor = true;
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUser.Location = new System.Drawing.Point(22, 149);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(67, 22);
            this.rbUser.TabIndex = 24;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "Users";
            this.rbUser.UseVisualStyleBackColor = true;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(104, 196);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(114, 31);
            this.btnSelectFile.TabIndex = 25;
            this.btnSelectFile.Text = "Select CSV file";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.AutoSize = true;
            this.lblSelectFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectFile.Location = new System.Drawing.Point(19, 201);
            this.lblSelectFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(80, 18);
            this.lblSelectFile.TabIndex = 26;
            this.lblSelectFile.Text = "Select file:";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(22, 267);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 27;
            this.btnUpload.Text = "Upload File";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // ImportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblSelectFile);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.rbUser);
            this.Controls.Add(this.rbIncident);
            this.Controls.Add(this.lblChooseTable);
            this.Controls.Add(this.lblImport);
            this.Name = "ImportView";
            this.Size = new System.Drawing.Size(968, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fdImport;
        private System.Windows.Forms.Label lblImport;
        private System.Windows.Forms.Label lblChooseTable;
        private System.Windows.Forms.RadioButton rbIncident;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lblSelectFile;
        private System.Windows.Forms.Button btnUpload;
    }
}
