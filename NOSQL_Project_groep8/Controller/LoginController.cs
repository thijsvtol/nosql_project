using NOSQL_Project_groep8.Model;
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
        private static UserRepository repository = new UserRepository();

        public UsersModel GetByUsername(string username)
        {
            UsersModel user = repository.GetUserPasswordByName(username);
            return user;
        }

        public void CheckLogin(Index index,string username, string password)
        {
            UsersModel userModel = GetByUsername(username);

            if (userModel != null && username == userModel.Username && userModel.Password == password)
            {
                

                index.HideViews("UCdashboardIncidentsView");
                index.SetCurrentUser(userModel);
                index.EnableButtons();
            }
            else
            {
                MessageBox.Show("Your password or username is wrong try again", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
