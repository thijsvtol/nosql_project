using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;


namespace NOSQL_Project_groep8.Controller
{
    class DashboardIncidentsController
    {
        private static IncidentRepository repository = new IncidentRepository();
        private UserModel User;
        private bool hasAdminRights = false;
        private int openIncidents;

        public int CalculatePercentOpenIncidents()
        {
            openIncidents = repository.CountOpenIncidents(User.UserId, hasAdminRights);
            if (openIncidents > 0)
            {
                int total = GetTotal();
                double percents = (double)openIncidents / total * 100;
                return Convert.ToInt32(percents);
            }
            return 0;
        }

        public string GetTextForCircle1()
        {
            return openIncidents.ToString() + "/" + GetTotal().ToString();
        }

        public int GetPastDeadlineIncidents()
        {
            return repository.CountPastDeadlineIncidents(User.UserId, hasAdminRights);
        }

        private int GetTotal()
        {
            int closedIncidents = repository.CountClosedIncidentsBeforeDealine(User.UserId, hasAdminRights);
            return openIncidents + closedIncidents;
        }

        public void SetCurrentUser(UserModel user)
        {
            User = user;
            if (User.TypeOfUser == "Servicedesk")
                hasAdminRights = true;
        }
    }
}
