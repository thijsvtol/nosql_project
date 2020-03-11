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
        private static IncidentRepository repository = new IncidentRepository();
        private int openIncidents = repository.CountOpenIncidents();

        public int CalculatePercentOpenIncidents()
        {
            int total = GetTotal();
            double percents = (double)openIncidents / total * 100;
            return Convert.ToInt32(percents);
        }

        public string GetTextForCircle1()
        {
            return openIncidents.ToString() +"/"+ GetTotal().ToString();
        }

        public int GetPastDeadlineIncidents()
        {
            return repository.CountPastDeadlineIncidents();
        }

        private int GetTotal()
        {
            int openIncidents = repository.CountOpenIncidents();
            int closedIncidents = repository.CountClosedIncidentsBeforeDealine();
            return openIncidents + closedIncidents;
        }
    }
}
