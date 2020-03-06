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
    public class CreateIncidentController
    {
        private static UserRepository UserRepository = new UserRepository();
        private static IncidentRepository IncidentRepository = new IncidentRepository();
        private static IncidentService IncidentService = new IncidentService();

        public List<UsersModel> GetUsers()
        {
                List<UsersModel> users = UserRepository.GetAllUsers();
                return users;
        }

        public void SaveIncident(Index index, IncidentsModel incident)
        {
            IncidentService.SetNewIncident(incident);
            index.HideViews("UCincidentManagementView");
        }
    }
}
