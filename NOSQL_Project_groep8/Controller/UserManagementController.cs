using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;
using NOSQL_Project_groep8.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSQL_Project_groep8.Controller
{
    public class UserManagementController
    {
        private static UserRepository UserRepository = new UserRepository();
        private static IncidentRepository IncidentRepository = new IncidentRepository();
        private static IncidentService IncidentService = new IncidentService();


        public List<UserModel> GetAllUsers()
        {
            List<UserModel> users = UserRepository.GetAllUsers();
            List<IncidentModel> incidents = IncidentRepository.GetAllIncidents();

            foreach (var incident in incidents)
            {
                foreach (var user in users)
                {
                    if(user.UserId == incident.User)
                    {
                        user.NumberOfTickets++;
                    }
                }
            }
            return users;
        }
    }
}
