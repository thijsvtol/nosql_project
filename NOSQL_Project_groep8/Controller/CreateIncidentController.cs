using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;
using NOSQL_Project_groep8.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            return UserRepository.GetAllUsers();
        }

        public bool SaveIncident(Index index, IncidentModel incident)
        {
            //checks if the required fields are filled in
            if (string.IsNullOrEmpty(incident.Subject) || string.IsNullOrEmpty(incident.DateDeadline.ToString()) || string.IsNullOrEmpty(incident.Location) || string.IsNullOrEmpty(incident.Description))
            {
                MessageBox.Show("Please fill in all the details!", "Fill Forum Details!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                incident.IncidentId = IncidentRepository.AutoIncredement();
                IncidentService.SetNewIncident(incident);
                index.HideViews("UCincidentManagementView");
                MessageBox.Show("Incident was saved! You are being redirected to the overview.");
                index.refreshLv("UCincidentManagementView");
                return true;
            }
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