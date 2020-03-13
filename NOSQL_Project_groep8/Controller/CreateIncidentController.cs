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
        private static LocationRepository LocationRepository = new LocationRepository();

        public List<UserModel> GetUsers()
        {
            List<UserModel> users = UserRepository.GetAllUsers();
            return users;
        }

        public void SaveIncident(Index index, IncidentModel incident)
        {
            incident.IncidentId = IncidentRepository.AutoIncredement();
            IncidentService.SetNewIncident(incident);
            index.HideViews("UCincidentManagementView");
        }

        public List<string> GetStatus()
        {
            var dataSource = new List<string>();
            dataSource.Add("open");
            dataSource.Add("close");
            return dataSource;
        }

        public List<string> GetType()
        {
            var type = new List<string>();
            type.Add("Software");
            type.Add("Hardware");
            type.Add("Service");
            return type;
        }

        public List<string> GetPriority()
        {
            var priority = new List<string>();
            priority.Add("Low");
            priority.Add("Normal");
            priority.Add("High");
            return priority;
        }

        public List<ComboboxItem> GetDeadlineDates()
        {
            var deadlineDays = new List<ComboboxItem>();
            deadlineDays.Add(new ComboboxItem() { Text = "7 days", Value = 7, Type = "day" });
            deadlineDays.Add(new ComboboxItem() { Text = "14 days", Value = 14, Type = "day" });
            deadlineDays.Add(new ComboboxItem() { Text = "26 days", Value = 26, Type = "day" });
            deadlineDays.Add(new ComboboxItem() { Text = "6 months", Value = 6, Type = "month" });
            return deadlineDays;
        }

        public List<LocationModel> GetLocation()
        {
            return LocationRepository.GetAllLocations();
        }
    }
}
