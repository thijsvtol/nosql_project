using System;
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
            int pastDeadlines = DashboardController.GetPastDeadlineIncidents();
            if (pastDeadlines <= 10)
                circleDiagramPastIncidents.Value = pastDeadlines * 10;
            else
                circleDiagramPastIncidents.Value = 100;
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
            parent.RefreshLv("UCincidentManagementView");
        }
    }
}
