using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NOSQL_Project_groep8.Controller
{
    class EmailController
    {
        public void SendMail(string subject, string toMail, string body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.strato.com");

            mail.From = new MailAddress("test@speedskatingphotos.nl");
            mail.To.Add(toMail);
            mail.Subject = subject;
            mail.Body = body;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("test@speedskatingphotos.nl", "Welkom01!1");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }
    }
}
