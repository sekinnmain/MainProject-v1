using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Linq;
using System.Xml.XPath;
using MAIN_GUI_Mangaer_window.ma_controller;
using MAIN_GUI_Mangaer_window;

namespace Main.yonor
{
    /// <summary>
    /// Summary description for MailingList
    /// </summary>
    /// 
    public class MailingList
    {
        //private VipCustomer[] Subscribers;
        //private Advertisement[] Ads;
        private const int INTERVAL = 30000;
        private Queue<Advertisement> Ads = new Queue<Advertisement>();
        //private Queue<string> customersEmails = new Queue<string>();
        Advertisement adToSend = new Advertisement();
        //private readonly object lockThis = new object();

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool scheduleState { get; set; }
        public int DispacherFrecuency { get; set; }

        public MailingList(bool enbleAdsCampegin)
        {
            scheduleState = enbleAdsCampegin;
            LoadCusomersEmails();
            LoadValidAds();
            new Timer(StartMailing, null, 0, INTERVAL);
        }
        public void StartMailing(object o)
        {

            //foreach (string email in customersEmails)
            //{
            //    customersEmails.Dequeue();
            //}

            if (scheduleState)
            {
                Mailer.EmailAd(Ads.Dequeue());

            }

        }

       

        private void LoadCusomersEmails()
        {

            foreach (XElement xe in (XDocument.Load(XmlParser.xmlUsers).XPathSelectElements("//RegisteredUser")))
            {

                Mailer.addRecipientsToAd(xe.Element("Email").Value);

                //customersEmails.Enqueue(xe.Element("Email").Value);

            }
        }
        private void LoadValidAds()
        {
            foreach (XElement xe in (XDocument.Load(XmlParser.xmlAds).XPathSelectElements("//Ad")))
            {
                if (xe.Element("Active").Value.Equals("1"))
                {
                    adToSend.CompanyName = xe.Element("CompanyName").Value;
                    adToSend.Url = xe.Element("URL").Value;
                    //DateTime adExpTime = DateTime.Parse(xe.Element("ExpirationDate").Value);
                    adToSend.AdBody = xe.Element("AdBody").Value;
                    Ads.Enqueue(adToSend);
                }

            }
        }







    }

}
