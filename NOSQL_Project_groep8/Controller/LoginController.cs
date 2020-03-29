using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.View;
using NOSQL_Project_groep8.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void CheckLogin(Index index, DashboardIncidentsView dashboard, string UserId, string password)
        {
            if (UserRepository.CheckUser(UserId, password))
            {
                UserModel user = UserRepository.GetUser(UserId);
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
