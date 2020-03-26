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
using NOSQL_Project_groep8.Model;

namespace NOSQL_Project_groep8.View
{
    public partial class DashboardIncidentsView : UserControl
    {
        private DashboardIncidentsController DashboardController = new DashboardIncidentsController();
        private UserModel User;

        public DashboardIncidentsView()
        {
            InitializeComponent();
        }

        //Load dashboard after login
        public void LoadDashboard(UserModel user)
        {
            User = user;
            DashboardController.SetCurrentUser(User);
            PrepareDashboard();
            UpdateCircleDiagrams();
        }

        //Refresh dashboard
        public void UpdateDashboard()
        {
            LoadDashboard(User);
        }

        public void UpdateCircleDiagrams()
        {
            //Circle1
            circleDiagramUnresolvedIncidents.Value = DashboardController.CalculatePercentOpenIncidents();
            circleDiagramUnresolvedIncidents.Text = DashboardController.GetTextForCircle1();
            circleDiagramUnresolvedIncidents.Update();

            //Circle2
            circleDiagramPastIncidents.Value = DashboardController.GetPastDeadlineIncidents()*20;
            circleDiagramPastIncidents.Text = DashboardController.GetPastDeadlineIncidents().ToString();
            circleDiagramPastIncidents.Update();
        }

        private void PrepareDashboard()
        {
            if (User.TypeOfUser == "Employee")
            {
                //Show dashboard, only incidencts of the logged in user
                lbDashboardHeader.Text = "Welcome " + User.FirstName + ", your personal dashboard";
            }
            else
            {
                //Show dashboard with all the incidents
                lbDashboardHeader.Text = "Dashboard";
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        ///                                      EVENTS                                        ///
        //////////////////////////////////////////////////////////////////////////////////////////
        
        private void btnShowListDashboard_Click(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;
            parent.refreshLv("UCincidentManagementView");
        }
    }
}
