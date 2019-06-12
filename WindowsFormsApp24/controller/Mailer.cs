using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Xml.Linq;
using System.Xml.XPath;
using MAIN_GUI_Mangaer_window.ma_controller;
using Nustache.Core;
using NewUsers;


namespace Main.yonor
{
    /// <summary>
    /// Summary description for Smtp
    /// </summary>


    public static class Mailer
    {

        public static int smtpPortSrv { get; set; }
        public static string smtpHost { get; set; }
        public static string smtpUser { get; set; }
        public static string smtpPassSrv { get; set; }
        public static string recieptEmail { get; set; }
        public static MailMessage message = new MailMessage();
        public static SmtpClient smtp = new SmtpClient();
        
        public static void EmailAd(Advertisement adToEmail)
        {

            using (StreamReader reader = File.OpenText(XmlParser.adTemp)) // Path to your 
            {
                try
                {

                    message.From = new MailAddress("main-delivery@yonor.me");
                    message.Subject = "Test";
                    message.IsBodyHtml = true; //to make message body as html  
                    string templateHtml = reader.ReadToEnd();
                    message.Body = Render.StringToString(templateHtml, adToEmail); 

                }
                catch (Exception) { }
            }
            LoadClientAndSendEmail();

        }
        public static void TestConection(string emailToTest)
        {

            message.From = new MailAddress("main-delivery@main.com");
            message.To.Add(new MailAddress($"{emailToTest}"));
            message.Subject = "Test";
            message.IsBodyHtml = false; //to make message body as html  
            message.Body = "Connection Successful";
            LoadClientAndSendEmail();

           
        }

        public static bool EmailPassword(string userEmailRecover)
        {
            bool passSent = false;
            foreach (XElement xe in (XDocument.Load(XmlParser.xmlUsers).XPathSelectElements($"//RegisteredUser")))
            {
                if (xe.Element("Email").Value.Equals(userEmailRecover))
                {
                    using (StreamReader reader = File.OpenText(XmlParser.recoverTempl)) // Path to your 
                    {
                        try
                        {
                            VipCustomer recoUser = new VipCustomer();
                            recoUser.FirstName = xe.Element("FirstName").Value;
                            recoUser.Email = xe.Element("Email").Value;
                            recoUser.PassWord = xe.Element("PassWord").Value;
                            message.From = new MailAddress("main-delivery@main.com");
                            message.To.Add(new MailAddress($"{recoUser.Email}"));
                            message.Subject = $"Password recovery for {recoUser.FirstName}";
                            message.IsBodyHtml = true; //to make message body as html  
                            string templateHtml = reader.ReadToEnd();
                            message.Body = Render.StringToString(templateHtml, recoUser);
                            passSent = true;
                            return passSent;

                        }
                        catch (Exception) { }
                    }
                }
            }
            return passSent;

           
        }
        public static void addRecipientsToAd(string Email)
        {
            message.To.Add(new MailAddress($"{Email}"));

        }

        public static void SendEmail()
        {
            smtp.Send(message);

        }
        public static void LoadClientAndSendEmail()
        {
            smtp.Port = 25;
            smtp.Host = "smtp.g-cloud.co.il"; //for gmail host  
                                              //smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("yizrael","YI$123456");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            SendEmail();
        }

    }

}
