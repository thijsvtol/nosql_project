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
        DashboardIncidentsController controller = new DashboardIncidentsController();

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
            circleDiagramUnresolvedIncidents.Text = controller.GetTextForCircle();
            circleDiagramUnresolvedIncidents.Update();

            //Circle2
            circleDiagramPastIncidents.Value = 0;
            circleDiagramPastIncidents.Update();
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        ///                                      EVENTS                                        ///
        //////////////////////////////////////////////////////////////////////////////////////////
        
        private void btnShowListDashboard_Click(object sender, EventArgs e)
        {
            //Werkt niet --> clickable van UC naar form
            Index index = new Index();
            index.HideViews("UCincidentManagementView");
        }
    }
}
