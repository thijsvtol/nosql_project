using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Service;
using NOSQL_Project_groep8.Repositories;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace NOSQL_Project_groep8.Controller
{
    class AddUserController
    {
        private UserService UserService = new UserService();
        private UserRepository repository = new UserRepository();

        public bool AddUser(bool checkBox, UserModel user)
        {
            //Check if all fiels are not empty
            if (ValidateInputFields(user))
            {
                MessageBox.Show("Please fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (IsValidPassword(user.Password))
                {
                    try
                    {
                        InsertUser(user, checkBox);
                        return true;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Could not insert the user into the database:\r\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Your password must contain:\r\n1. At least 1 upper case letter\r\n2. At least 1 number\r\n3. Password must be at least 8 characters long", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
        }

        private void InsertUser(UserModel user, bool sendEmail)
        {
            //Add user by service
            user.UserId = repository.AutoIncredement();
            UserService.InsertUser(user);

            //Check checkbox
            if (sendEmail)
            {
                //Send mail
                SendMail();
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

        private bool IsValidPassword(string plainText)
        {
            //At least a number, uppercase and minimum of 8 characters
            Regex regex = new Regex(@"((?=.*\d)(?=.*[A-Z]).{8,50})");
            Match match = regex.Match(plainText);
            return match.Success;
        }

        private bool ValidateInputFields(UserModel user)
        {
            List<bool> ls = new List<bool>();
            ls.Add(string.IsNullOrEmpty(user.FirstName));
            ls.Add(string.IsNullOrEmpty(user.LastName));
            ls.Add(string.IsNullOrEmpty(user.Email));
            ls.Add(string.IsNullOrEmpty(user.Phonenumber));
            ls.Add(string.IsNullOrEmpty(user.Username));
            ls.Add(string.IsNullOrEmpty(user.Password));

            return ls.Any(a => a.Equals(true));
        }
    }
}
