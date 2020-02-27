using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOSQL_Project_groep8.Repositories;


namespace NOSQL_Project_groep8.Controller
{
    class DashboardIncidentsController
    {
        private static DashboardIncidentsRepository repository = new DashboardIncidentsRepository();
        public int openIncidents = repository.CountOpenIncidents();

        public int CalculatePercentOpenIncidents()
        {
            int percents = 0;
            int openIncidents = repository.CountOpenIncidents();
            int closedIncidents = repository.CountClosedIncidentsBeforeDealine();
            percents = GetTotal() / openIncidents * 100;
            return percents;
        }

        public string GetTextForCircle()
        {
            return GetTotal().ToString() + "/" + openIncidents.ToString();
        }

        private int GetTotal()
        {
            int openIncidents = repository.CountOpenIncidents();
            int closedIncidents = repository.CountClosedIncidentsBeforeDealine();
            return openIncidents + closedIncidents;
        }
    }
}
