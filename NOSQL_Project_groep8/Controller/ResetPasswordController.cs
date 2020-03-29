using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;
using NOSQL_Project_groep8.Service;
using NOSQL_Project_groep8.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOSQL_Project_groep8.Controller
{
    class ResetPasswordController
    {
        private static KeyRepository KeyRepository = new KeyRepository();
        private static KeyService keyService = new KeyService();
        private static UserService UserService = new UserService();
        private static UserRepository UserRepository = new UserRepository();
        private string Key;
        private ResetPasswordView UC;

        public ResetPasswordController(ResetPasswordView uc)
        {
            UC = uc;
        }

        /// <summary>
        /// generate key when user is authorized
        /// </summary>
        /// <returns></returns>
        public string GenerateKey()
        {
            int length = 24;

            // creating a StringBuilder object()
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            //makes a random key of 24 letters
            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }

        /// <summary>
        /// check if all info was correct and send mail to the email
        /// </summary>
        /// <param name="email"></param>
        /// <param name="favColor"></param>
        public void CheckUserinfo(string email,string favColor)
        {
            try
            {
                //if email and favcolor is correct
                if (validdate(email, favColor))
                {
                    string key = GenerateKey();
                    //check email for existing;;
                    var keymodel = KeyRepository.CheckKeyExistByEmail(email);
                    if (keymodel != null)
                    {
                        keymodel.Key = key;
                        keyService.UpdateKey(keymodel);
                    }
                    else
                    {
                        keyService.SetKey(key, email);
                    }
                    //send mail to the given email
                    EmailController emailController = new EmailController();
                    emailController.SendMail("ResetKey", email, "Your reset key is: " + key);
                    MessageBox.Show("Email send");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// checks if the email and favorite color are correct
        /// </summary>
        /// <param name="email"></param>
        /// <param name="favColor"></param>
        /// <returns></returns>
        public bool validdate(string email, string favColor)
        {
            //validate on email and check if fav color was correct
            if (!email.Contains('@'))
            {
                MessageBox.Show("'" + email + "' is not an valid Email address");
                return false;
            }
            else if (UserRepository.GetUserPasswordByEmail(email) == null)
            {
                MessageBox.Show("'" + email + "' was not found in our database \nno email was send");
                return false;
            }
            else if(!UserRepository.CheckFavColor(favColor, email))
            {
                MessageBox.Show("'" + favColor + "' was not your favorite color\nno email was send");
                return false;
            }
            return true;
        }

        /// <summary>
        /// checks if key is correct
        /// </summary>
        /// <param name="key"></param>
        public void CheckKey(string key, string email)
        {
            //checks if key exist for the user and if correct for the username
            KeyModel keyModel = KeyRepository.GetKey(key, email);
            if (keyModel != null)
            {
                Key = key;
                UC.HidePanels("pResetKey");
            }
            else
            {
                MessageBox.Show("key was not correct");
            }
        }

        /// <summary>
        /// change passord
        /// </summary>
        /// <param name="password"></param>
        /// <param name="rePassword"></param>
        /// <param name="email"></param>
        public void ChangePassword(string password, string rePassword, string email)
        {
            //if password is equal to the other
            if (rePassword == password && IsValidPassword(password))
            {
                //get the user that needs to be edited
                UserModel user = UserRepository.GetUserPasswordByEmail(email);
                user.Password = password;
                UserService.ChangePassword(user);

                //delete the used key
                keyService.DeleteKey(Key);
                UC.HidePanels("pCheckKey");
                UC.GoToLogin();
            }
            else
            {
                MessageBox.Show("password dit not have at least a number, uppercase and a minumum of 8 characters");
            }
        }

        /// <summary>
        /// validate the password
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        private bool IsValidPassword(string plainText)
        {
            //At least a number, uppercase and minimum of 8 characters
            Regex regex = new Regex(@"((?=.*\d)(?=.*[A-Z]).{8,50})");
            Match match = regex.Match(plainText);
            return match.Success;
        }
    }
}
