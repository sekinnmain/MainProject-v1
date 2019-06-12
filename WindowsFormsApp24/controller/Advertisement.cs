using System;




namespace main
{


    /// <summary>
    /// This class creates Ads to be promote and send by email to restaurant's clients.
    /// Instances creted with this class will Queue by MailingList and send by Mailer classes.
    /// </summary>
    public class Advertisement
    {
        public Advertisement()
        {
            //
            // TODO: Add constructor logic here
            //
            Active = false;
        }
        public string CompanyName { get; set; }
        public string ImgPath { get; set; }
        public string AdBody { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public float Price { get; set; }
        public string Url { get; set; }
        public MailingList MailingList {get; set;}

        public void DisableAd()
        {
            Active = false;
        }
        public void EnableAd()
        {
            Active = true;
        }
        public string GetStatus()
        {
            return Active.ToString();
        }
        public override string ToString()
        {
            return CompanyName;
        }
    }



}
