using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;
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
        private static UserRepository UserRepository = new UserRepository();
        string Email;
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
                string key = GenerateKey();

                KeyRepository.SetKey(key, email);
                Email = email;
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("your_email_address@gmail.com");
                mail.To.Add(email);
                mail.Subject = "ResetKey";
                mail.Body = "Your reset key is: " + key;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");

                UC.HidePanels("pCheckKey");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        public void ChangePassword(string password)
        {
            UsersModel user = UserRepository.GetUserPasswordByEmail(Email);

            user.Password = password;
            UserRepository.ChangePassword(user);

            KeyRepository.DeleteKey(Key);
        }
    }
}
