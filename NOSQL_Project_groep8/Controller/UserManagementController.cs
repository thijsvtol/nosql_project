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
        private static UserService UserService = new UserService();


        public List<UserModel> GetAllUsers()
        {
            List<UserModel> users = UserRepository.GetAllUsers();
            List<IncidentModel> incidents = IncidentRepository.GetAllIncidents();
        }
        public void ChangeRole(UserModel user)
        {
            if (user.TypeOfUser == "Servicedesk")
            {
                user.TypeOfUser = "Employee";
                UserService.ChangeRole(user);
            }
            else if (user.TypeOfUser == "Employee")
            {
                user.TypeOfUser = "Servicedesk";
                UserService.ChangeRole(user);
            }

        }

        public void DeleteUser(UserModel user)
        {
            UserService.DeleteUser(user);
        }
    }
}
