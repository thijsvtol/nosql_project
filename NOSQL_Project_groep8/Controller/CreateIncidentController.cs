using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSQL_Project_groep8.Controller
{
    public class CreateIncidentController
    {
        private static UserRepository repository = new UserRepository();
        private static IncidentRepository IncidentRepository = new IncidentRepository();

        public List<UserModel> GetUsers()
        {
                List<UserModel> users = repository.GetAllUsers();
                return users;
        }

        public void SaveIncident(Index index, IncidentModel incident)
        {
            IncidentRepository.SetNewIncident(incident);
            index.HideViews("UCincidentManagementView");
        }
    }
}
