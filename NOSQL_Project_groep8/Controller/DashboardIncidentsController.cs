using System;
using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;


namespace NOSQL_Project_groep8.Controller
{
    class DashboardIncidentsController
    {
        private static IncidentRepository Repository = new IncidentRepository();
        private UserModel User;
        private bool HasAdminRights = false;
        private int OpenIncidents;

        //Get open incidents
        public int CalculatePercentOpenIncidents()
        {
            OpenIncidents = Repository.CountOpenIncidents(User.UserId, HasAdminRights);
            if (OpenIncidents > 0)
            {
                int total = GetTotal();
                double percents = (double)OpenIncidents / total * 100;
                return Convert.ToInt32(percents);
            }
            return 0;
        }

        public string GetTextForCircle1()
        {
            return OpenIncidents.ToString() + "/" + GetTotal().ToString();
        }

        public int GetPastDeadlineIncidents()
        {
            return Repository.CountPastDeadlineIncidents(User.UserId, HasAdminRights);
        }

        //Get number of all incidents
        private int GetTotal()
        {
            int closedIncidents = Repository.CountClosedIncidentsBeforeDealine(User.UserId, HasAdminRights);
            return OpenIncidents + closedIncidents;
        }

        public void SetCurrentUser(UserModel user)
        {
            User = user;
            if (User.TypeOfUser == "Servicedesk")
                HasAdminRights = true;
        }
    }
}
