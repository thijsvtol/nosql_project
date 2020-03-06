using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;
using NOSQL_Project_groep8.Service;
using NOSQL_Project_groep8.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOSQL_Project_groep8.Controller
{
    class ResetPasswordController
    {
        private static KeyRepository KeyRepository = new KeyRepository();
        private static KeyService keyService = new KeyService();
        private static UserRepository UserRepository = new UserRepository();
        string Key;
        ResetPasswordView UC;

        public ResetPasswordController(ResetPasswordView uc)
        {
            UC = uc;
        }

        public string GenerateKey()
        {
            int length = 24;

            // creating a StringBuilder object()
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }

        public void SentMail(string email)
        {
            try
            {
                if (validdate(email))
                {
                    string key = GenerateKey();
                    //check email for existing;;
                    var keymodel = KeyRepository.GetKeyByEmail(email);
                    if (keymodel != null)
                    {
                        keymodel.Key = key;
                        keyService.UpdateKey(keymodel);
                    }
                    else
                    {
                        keyService.SetKey(key, email);
                    }
                    EmailController emailController = new EmailController();
                    emailController.SendMail("ResetKey", email, "Your reset key is: " + key);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public bool validdate(string email)
        {
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
            return true;
        }

        public void CheckKey(string key)
        {
            KeyModel keyModel = KeyRepository.GetKey(key);
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

        public void ChangePassword(string password, string rePassword, string email)
        {
            if (rePassword == password)
            {

                UserModel user = UserRepository.GetUserPasswordByEmail(email);

                user.Password = password;
                UserRepository.ChangePassword(user);

                keyService.DeleteKey(Key);
                UC.HidePanels("pCheckKey");
                UC.GoToLogin();
            }
        }
    }
}
