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
            return users;
        }


        public void ChangeRole(UserModel user)
        {
            if (user.TypeOfUser == "Servicedesk")
            {
                user.TypeOfUser = "Employee";
                UserRepository.ChangeRole(user);
            }
            else if (user.TypeOfUser == "Employee")
            {
                user.TypeOfUser = "Servicedesk";
                UserRepository.ChangeRole(user);
            }

        }

        public void DeleteUser(UserModel user)
        {
            UserRepository.DeleteUser(user);
        }
    }
}
