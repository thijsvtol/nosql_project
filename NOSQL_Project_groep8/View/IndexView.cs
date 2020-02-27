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
        public void HideViews(string uc)
        {
            foreach (var control in Controls)
            {
                if (control is UserControl)
                {
                    if (((UserControl)control).Name == uc)
                    {
                        ((UserControl)control).Visible = true;
                    }
                    else
                    {
                        ((UserControl)control).Visible = false;
                    }
                }
                
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////
        ///                                      EVENTS                                        ///
        //////////////////////////////////////////////////////////////////////////////////////////

        private void menuDashboard_Click(object sender, EventArgs e)
        {
            HideViews("UCdashboardIncidentsView");
        }

        private void menuIncidentManagement_Click(object sender, EventArgs e)
        {
            HideViews("UCincidentManagementView");
        }

        private void menuUserManagement_Click(object sender, EventArgs e)
        {
            HideViews("UCuserManagementView");
        }
    }
}
