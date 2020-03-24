using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NOSQL_Project_groep8.Controller;

namespace NOSQL_Project_groep8.View
{
    public partial class ImportView : UserControl
    {
        private ImportController import = new ImportController();
        private string file;

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
                file = fdImport.FileName;
                import.SetFile(file);
                lblSelectedFile.Text = "Selected file: " + file;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //Check if file is selected
            if (file != null)
            {
                //Check which RadioButton is selected
                if (rbUser.Checked)
                {
                    import.InsertUsers();
                }
                else if (rbIncident.Checked)
                {
                    import.InsertIncidents();
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
