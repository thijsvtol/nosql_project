using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Controller;

namespace NOSQL_Project_groep8.View
{
    public partial class IncidentManagementView : UserControl
    {
        IncidentOverviewController IncidentOverview = new IncidentOverviewController();

       
        private List<IncidentModel> GetAllIncidents()
        {

            return IncidentOverview.GetIncidents();

        }





        public IncidentManagementView()
        {
            InitializeComponent();

            List<IncidentModel> incidents = GetAllIncidents();
            foreach (IncidentModel incident in incidents)
            {
                ListViewItem item = new ListViewItem(incident.IncidentId.ToString());
                item.SubItems.Add(incident.Subject);
                item.SubItems.Add(incident.User.ToString());
                item.SubItems.Add(incident.DateCreated.ToString());
                item.SubItems.Add(incident.Status);
                lv_incidents.Items.Add(item);
            }

            









        }
            
        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;
            parent.HideViews("UCcreateIncidenetView");
        }

        
    }
}
