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
using NOSQL_Project_groep8.View;
using NOSQL_Project_groep8.Model;

namespace NOSQL_Project_groep8
{
    public partial class Index : Form
    {
        IndexController IndexController = new IndexController();
        UserManagementView User = new UserManagementView();

        public Index()
        {
            InitializeComponent();
            menuDashboard.Enabled = false;
            menuIncidentManagement.Enabled = false;
            menuUserManagement.Enabled = false;
            menuImport.Enabled = false;
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

        public void SetCurrentUser(UserModel user)
        {
            IndexController.CurrentUser = user;
        }

        public UserModel GetCurrentUser()
        {
            return IndexController.CurrentUser;
        }

        public DashboardIncidentsView GetDashboard()
        {
            return UCdashboardIncidentsView;
        }

        public void EnableButtons()
        {
            menuDashboard.Enabled = true;
            menuIncidentManagement.Enabled = true;
            menuUserManagement.Enabled = true;
            menuImport.Enabled = true;
        }

        public void refreshLv(string whichView)
        {
            HideViews(whichView);
            if (whichView == "UCincidentManagementView")
            {
                UCincidentManagementView.refreshingLv();
            }
            else if (whichView == "UCuserManagementView")
            {
                //update iets
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        ///                                      EVENTS                                        ///
        //////////////////////////////////////////////////////////////////////////////////////////

        private void menuDashboard_Click(object sender, EventArgs e)
        {
            HideViews("UCdashboardIncidentsView");
            UCdashboardIncidentsView.UpdateDashboard();
        }

        private void menuIncidentManagement_Click(object sender, EventArgs e)
        {
            HideViews("UCincidentManagementView");
            UCincidentManagementView.refreshingLv();
        }

        private void menuUserManagement_Click(object sender, EventArgs e)
        {
            HideViews("UCuserManagementView");
            UCuserManagementView.RefreshingLv();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            HideViews("UCimportView");
        }
    }
}
