using System.Net.Mail;

namespace NOSQL_Project_groep8.Controller
{
    class EmailController
    {
        /// <summary>
        /// Send email by SMTP Client
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="toMail"></param>
        /// <param name="body"></param>
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
