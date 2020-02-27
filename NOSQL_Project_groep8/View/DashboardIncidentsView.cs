using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOSQL_Project_groep8.View
{
    public partial class DashboardIncidentsView : UserControl
    {

        public DashboardIncidentsView()
        {
            InitializeComponent();
        }

        private void btnShowListDashboard_Click(object sender, EventArgs e)
        {
            //Werkt niet --> clickable van UC naar form
            Index index = new Index();
            index.HideViews("UCincidentManagementView");
        }
    }
}
