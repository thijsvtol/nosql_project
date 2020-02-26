using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NOSQL_Project_groep8.Controller;

namespace NOSQL_Project_groep8
{
    public partial class Index : Form
    {
        IndexController indexController = new IndexController();

        public Index()
        {
            InitializeComponent();
            //get sample data to label (label placed in header)
            lblSampleData.Text = indexController.GetSampleData();
        }

        //Hide all panels exept the header
        private void HidePanels()
        {
            foreach (var control in Controls)
            {
                if (control is Panel && ((Panel)control).Name != "pnlHeader")
                {
                    ((Panel)control).Visible = false;
                }
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        ///                                      EVENTS                                        ///
        //////////////////////////////////////////////////////////////////////////////////////////

        private void menuDashboard_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlDashboard.Visible = true;
        }

        private void menuIncidentManagement_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlIncidentManagement.Visible = true;
        }

        private void menuUserManagement_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlUserManagement.Visible = true;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlAddUser.Visible = true;
        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlCreateIncident.Visible = true;
        }

        private void btnShowListDashboard_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlIncidentManagement.Visible = true;
        }
    }
}
