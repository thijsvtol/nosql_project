using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Service;
using NOSQL_Project_groep8.Repositories;
using System.Windows.Forms;
using NOSQL_Project_groep8.View;

namespace NOSQL_Project_groep8.Controller
{
    class AddUserController
    {
        private UserService UserService = new UserService();
        private UserRepository repository = new UserRepository();

        public bool AddUser(bool checkBox, UserModel user)
        {
            //Check if all fiels are not empty
            if (user.FirstName == "" || user.LastName == "" || user.Email == "" || user.Phonenumber == "" || user.Username == "" || user.Password == "")
            {
                MessageBox.Show("Please fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                try
                {
                    //Add user by service
                    user.UserId = repository.AutoIncredement();
                    UserService.InsertUser(user);

                    //Check checkbox
                    if (checkBox)
                    {
                        //Send mail
                        SendMail();
                    }
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not insert the user into the database:\r\n"+e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool CheckComboboxes(ComboBox type, ComboBox location)
        {
            if(type.SelectedItem == null || location.SelectedItem == null)
            {
                MessageBox.Show("Please select an item in all the comboboxes!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void SendMail()
        {

        }
    }
}
