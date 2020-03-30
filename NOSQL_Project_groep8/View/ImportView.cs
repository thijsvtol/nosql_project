using System;
using System.Windows.Forms;
using NOSQL_Project_groep8.Controller;

namespace NOSQL_Project_groep8.View
{
    public partial class ImportView : UserControl
    {
        private ImportController Import = new ImportController();
        private string File;

        public ImportView()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        ///                                      EVENTS                                        ///
        //////////////////////////////////////////////////////////////////////////////////////////

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            //Set file in Stream Reader if file is selected
            if (fdImport.ShowDialog() == DialogResult.OK)
            {
                File = fdImport.FileName;
                Import.SetFile(File);
                lblSelectedFile.Text = "Selected file: " + File;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //Check if file is selected
            if (File != null)
            {
                //Check which RadioButton is selected
                if (rbUser.Checked)
                {
                    Import.InsertUsers();
                }
                else if (rbIncident.Checked)
                {
                    Import.InsertIncidents();
                }
                else
                {
                    MessageBox.Show("Please select a datatable to insert.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a file.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
