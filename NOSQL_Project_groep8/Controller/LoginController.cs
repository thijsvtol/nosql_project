﻿using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.View;
using NOSQL_Project_groep8.Repositories;
using System.Windows.Forms;

namespace NOSQL_Project_groep8.Controller
{
    class LoginController
    {
        private static UserRepository UserRepository = new UserRepository();

        /// <summary>
        /// Check if the user is the right user
        /// </summary>
        /// <param name="index"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void CheckLogin(Index index, DashboardIncidentsView dashboard, string username, string password)
        {
            //if there is a user with the username ande password
            if (UserRepository.CheckUser(username, password))
            {
                //set user as CurrentUser and go to the dashboard
                UserModel user = UserRepository.GetUser(username);
                index.HideViews("UCdashboardIncidentsView");
                index.SetCurrentUser(user);
                index.EnableButtons();
                dashboard.LoadDashboard(user);
            }
            else
            {
                MessageBox.Show("Your password or username is wrong try again", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
