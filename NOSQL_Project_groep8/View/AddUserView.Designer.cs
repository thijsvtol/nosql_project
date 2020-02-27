namespace NOSQL_Project_groep8.View
{
    partial class AddUserView
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
            this.lblAddUserHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddUserHeader
            // 
            this.lblAddUserHeader.AutoSize = true;
            this.lblAddUserHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUserHeader.Location = new System.Drawing.Point(16, 15);
            this.lblAddUserHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddUserHeader.Name = "lblAddUserHeader";
            this.lblAddUserHeader.Size = new System.Drawing.Size(153, 34);
            this.lblAddUserHeader.TabIndex = 1;
            this.lblAddUserHeader.Text = "Add User";
            // 
            // AddUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lblAddUserHeader);
            this.Name = "AddUserView";
            this.Size = new System.Drawing.Size(968, 523);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddUserHeader;
    }
}
