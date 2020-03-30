using System;
using System.Collections.Generic;
using System.Linq;
using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Service;
using NOSQL_Project_groep8.Repositories;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace NOSQL_Project_groep8.Controller
{
    class AddUserController
    {
        private UserService UserService = new UserService();
        private UserRepository UserRepository = new UserRepository();
        private LocationRepository LocationRepository = new LocationRepository();
        private List<string> ErrorList = new List<string>();

        //Add a new user from Create User
        public bool AddUser(bool checkBox, UserModel user)
        {
            //Validate user by all the fields
            ValidateInput(user);
            if (ErrorList.Count == 0)
            {
                //Try to insert user in DB
                try
                {
                    InsertUser(user, checkBox);
                }
                catch (Exception e)
                {
                    ErrorList.Add("Could not insert the user into the database:\r\n" + e.Message);
                }
            }

            //If there are errors, show them
            if (ErrorList.Count == 0)
            {
                MessageBox.Show("User added to the database!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                DisplayErrors();
                return false;
            }
        }

        private void ValidateInput(UserModel user)
        {
            //Clear list
            ErrorList.Clear();
            //Check if all fiels are not empty
            if (ValidateInputFields(user))
            {
                ErrorList.Add("Please fill in all fields.\r\n");
            }
            //Check if user already excists
            if (UserRepository.CountExcistingUsers(user.Username, user.Email) != 0)
            {
                ErrorList.Add("Email or Username allready exists!");
            }
            //Check password strength
            if (!IsValidPassword(user.Password))
            {
                ErrorList.Add("Your password must contain:\r\n1. At least 1 upper case letter\r\n2. At least 1 number\r\n3. Password must be at least 8 characters long");
            }
            //Check email
            if (ValidateEmail(user.Email))
            {
                ErrorList.Add("Emailaddress has an invalid input.");
            }
        }

        public bool ValidateEmail(string email)
        {
            if (!new EmailAddressAttribute().IsValid(email))
                return true;
            else
                return false;
        }

        private void InsertUser(UserModel user, bool sendEmail)
        {
            //Add user by service
            user.UserId = UserRepository.AutoIncredement();
            UserService.InsertUser(user);

            //Check checkbox
            if (sendEmail)
            {
                //Send mail
                EmailController email = new EmailController();
                string subject = "Your account has been added to NoDesk: TGG";
                string toMail = user.Email;
                string body = "Dear " + user.FirstName + ",\r\n\r\nYour username is: " + user.Username + "\r\nYour password: "+user.Password + "\r\n\r\nYours sincerly,\r\n\r\nNoDesk";
                email.SendMail(subject,toMail,body);
            }
        }

        private void DisplayErrors()
        {
            //Dislplay all errors to a message box
            string errorOutput = "";
            foreach (string item in ErrorList)
            {
                errorOutput += "• " + item + "\r\n";
            }
            MessageBox.Show(errorOutput, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            List<bool> ls = new List<bool>
            {
                string.IsNullOrEmpty(user.FirstName),
                string.IsNullOrEmpty(user.LastName),
                string.IsNullOrEmpty(user.Email),
                string.IsNullOrEmpty(user.Phonenumber),
                string.IsNullOrEmpty(user.Username),
                string.IsNullOrEmpty(user.Password)
            };

            return ls.Any(a => a.Equals(true));
        }

        public bool CheckComboboxes(ComboBox type, ComboBox location)
        {
            //Check if all ComboBoxes are filled in
            if (type.SelectedItem == null || location.SelectedItem == null)
            {
                ErrorList.Add("Please select an item in all comboboxes.\r\n");
                DisplayErrors();
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<LocationModel> GetLocations()
        {
            return LocationRepository.GetAllLocations();
        }

        public UserModel GetUserById(int userId)
        {
            UserModel user = UserRepository.GetUserByID(userId);
            return user;
        }

        public void UpdateUser(UserModel user)
        {
            UserService.UpdateUser(user);
        }
    }
}
