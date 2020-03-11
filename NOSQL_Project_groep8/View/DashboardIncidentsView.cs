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
    public partial class DashboardIncidentsView : UserControl
    {
        private DashboardIncidentsController controller = new DashboardIncidentsController();

        public DashboardIncidentsView()
        {
            InitializeComponent();
        }

        private void DashboardIncidentsView_Load(object sender, EventArgs e)
        {
            UpdateCircleDiagrams();
        }

        public void UpdateCircleDiagrams()
        {
            //Circle1
            circleDiagramUnresolvedIncidents.Value = controller.CalculatePercentOpenIncidents();
            circleDiagramUnresolvedIncidents.Text = controller.GetTextForCircle1();
            circleDiagramUnresolvedIncidents.Update();

            //Circle2
            circleDiagramPastIncidents.Value = controller.GetPastDeadlineIncidents()*20;
            circleDiagramPastIncidents.Text = controller.GetPastDeadlineIncidents().ToString();
            circleDiagramPastIncidents.Update();
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        ///                                      EVENTS                                        ///
        //////////////////////////////////////////////////////////////////////////////////////////
        
        private void btnShowListDashboard_Click(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;
            parent.HideViews("UCincidentManagementView");
        }
    }
}
