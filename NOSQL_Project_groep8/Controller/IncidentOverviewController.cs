<<<<<<< Updated upstream
<<<<<<< Updated upstream
﻿using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;
using NOSQL_Project_groep8.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSQL_Project_groep8.Controller
{
    public class IncidentOverviewController
    {

        private static UserRepository UserRepository = new UserRepository();
        private static IncidentRepository IncidentRepository = new IncidentRepository();
        private static IncidentService IncidentService = new IncidentService();


        public List<IncidentModel> GetIncidents()
        {
            List<IncidentModel> incidents = IncidentRepository.GetAllIncidents();
            return incidents;
        }
    }
}
=======
=======
>>>>>>> Stashed changes
﻿using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;
using NOSQL_Project_groep8.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSQL_Project_groep8.Controller
{
    public class IncidentOverviewController
    {

        private static UserRepository UserRepository = new UserRepository();
        private static IncidentRepository IncidentRepository = new IncidentRepository();
        private static IncidentService IncidentService = new IncidentService();


        public List<IncidentModel> GetIncidents()
        {
            List<UserModel> users = UserRepository.GetAllUsers();
            List<IncidentModel> incidents = IncidentRepository.GetAllIncidents();

            foreach (var incident in incidents)
            {
                foreach (var user in users)
                {
                    if (incident.User == user.UserId)
                    {
                        incident.UserEmail = user.Email;
                        incident.Username = user.FirstName + " " + user.LastName;
                    }
                }
            }

            return incidents;
        }
    }
}
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
