using System;
using System.Net.Mail;
using System.Net.Mime;

namespace main
{
    /// <summary>
    /// Summary description for Smtp
    /// </summary>


    public class Mailer
    {

        private int SmtpSrvPort = 445;
        private string SmtpUser;
        private string SmtpPass;
        private string SmtpHost;
        MailMessage mail = new MailMessage("DONT-REPLY@me.com", "user@hotmail.com");
        SmtpClient client = new SmtpClient();

        public Mailer()
        {
            //
            // TODO: Add constructor logic here
            //
            
            client.Port = SmtpSrvPort;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = SmtpHost;
            mail.Subject = "this is a test email.";
            mail.Body = "this is my test email body";
            
        }

        public void SendEmail()
        {
            client.Send(mail);
        }
    }

}
