﻿using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;
using NOSQL_Project_groep8.Service;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NOSQL_Project_groep8.Controller
{
    public class CreateIncidentController
    {
        private static UserRepository UserRepository = new UserRepository();
        private static IncidentRepository IncidentRepository = new IncidentRepository();
        private static IncidentService IncidentService = new IncidentService();
        private static LocationRepository LocationRepository = new LocationRepository();

        /// <summary>
        ///  Get all users
        /// </summary>
        /// <returns></returns>
        public List<UserModel> GetUsers()
        {
            return UserRepository.GetAllUsers();
        }

        /// <summary>
        /// Saves the incident
        /// </summary>
        /// <param name="index"></param>
        /// <param name="incident"></param>
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
                index.RefreshLv("UCincidentManagementView");
                return true;
            }
        }

        /// <summary>
        ///  Get status
        /// </summary>
        /// <returns></returns>
        public List<string> GetStatus()
        {
            var dataSource = new List<string>
            {
                "open",
                "closed"
            };
            return dataSource;
        }

        /// <summary>
        /// Get the Types
        /// </summary>
        /// <returns></returns>
        public List<string> GetType()
        {
            var type = new List<string>
            {
                "Software",
                "Hardware",
                "Service"
            };
            return type;
        }

        /// <summary>
        /// Get the priorities
        /// </summary>
        /// <returns></returns>
        public List<string> GetPriority()
        {
            var priority = new List<string>
            {
                "Low",
                "Normal",
                "High"
            };
            return priority;
        }

        /// <summary>
        /// Get the Dealine Dates
        /// </summary>
        /// <returns></returns>
        public List<ComboboxItem> GetDeadlineDates()
        {
            var deadlineDays = new List<ComboboxItem>
            {
                new ComboboxItem() { Text = "7 days", Value = 7, Type = "day" },
                new ComboboxItem() { Text = "14 days", Value = 14, Type = "day" },
                new ComboboxItem() { Text = "26 days", Value = 26, Type = "day" },
                new ComboboxItem() { Text = "6 months", Value = 6, Type = "month" }
            };
            return deadlineDays;
        }

        /// <summary>
        /// Get the locations
        /// </summary>
        /// <returns></returns>
        public List<LocationModel> GetLocation()
        {
            return LocationRepository.GetAllLocations();
        }
    }
}