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
        private UserRepository UserRepository = new UserRepository();
        private IncidentService IncidentService = new IncidentService();
        private IncidentRepository IncidentRepository = new IncidentRepository();

        public List<UserModel> GetUsers()
        {
                List<UserModel> users = UserRepository.GetAllUsers();
                return users;
        }

        public void SaveIncident(Index index, IncidentModel incident)
        {
            incident.IncidentId = IncidentRepository.AutoIncredement();
            IncidentService.SetNewIncident(incident);
            index.refreshLv("UCincidentManagementView");
        }
        public void CancelIncident(Index index)
        {
            index.refreshLv("UCincidentManagementView");
        }
    }
}
