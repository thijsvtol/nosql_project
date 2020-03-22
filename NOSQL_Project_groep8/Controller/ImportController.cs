﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;
using NOSQL_Project_groep8.Service;
using System.Windows.Forms;

namespace NOSQL_Project_groep8.Controller
{
    class ImportController
    {
        private UserService userService = new UserService();
        private UserRepository userRepository = new UserRepository();
        private IncidentService incidentService = new IncidentService();
        private IncidentRepository incidentRepository = new IncidentRepository();
        private StreamReader sr;

        public void SetFile(string file)
        {
            sr = new StreamReader(file);
        }

        public void InsertUsers()
        {
            List<UserModel> users = new List<UserModel>();
            try
            {
                int ai = userRepository.AutoIncredement();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] split = line.Split(',',';');
                    UserModel user = FillUser(ai, split);
                    users.Add(user);
                    ai++;
                }
                userService.InsertMany(users);
                MessageBox.Show("inserted: " + users.Count + " rows succesfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception e)
            {
                ShowErrorLog(e);
            }
        }

        public void InsertIncidents()
        {
            List<IncidentModel> incidents = new List<IncidentModel>();
            try
            {
                int ai = incidentRepository.AutoIncredement();
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] split = line.Split(',', ';');
                    IncidentModel incident = FillIncident(ai, split);
                    incidents.Add(incident);
                    ai++;
                }
                incidentService.InsertMany(incidents);
                MessageBox.Show("inserted: " + incidents.Count + " rows succesfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                ShowErrorLog(e);
            }
        }

        private void ShowErrorLog(Exception e)
        {
            MessageBox.Show("An Error has shown up: " + e.Message + "\r\nStack and trace:\r\n" + e.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private UserModel FillUser(int ai, string[] split)
        {
            return new UserModel()
            {
                UserId = ai,
                Email = split[0],
                Username = split[1],
                Password = split[2],
                FirstName = split[3],
                LastName = split[4],
                Phonenumber = split[5],
                TypeOfUser = split[6],
                Location = split[7],
                FavColor = split[8]
            };
        }

        private IncidentModel FillIncident(int ai, string[] split)
        {
            return new IncidentModel()
            {
                IncidentId = ai,
                Subject = split[0],
                UserId = int.Parse(split[1]),
                DateCreated = DateTime.Parse(split[2]),
                DateDeadline = DateTime.Parse(split[3]),
                DateSolved = DateTime.Parse(split[4]),
                Status = split[5],
                Type = split[6],
                Priority = split[7],
                Location = split[8],
                Description = split[9],
                CreatedUserId = int.Parse(split[10])
            };
        }
    }
}
