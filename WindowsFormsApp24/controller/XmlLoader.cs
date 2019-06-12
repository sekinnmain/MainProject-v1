using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using NewUsers;
using System.Xml.XPath;
using System.IO;
using MAIN_GUI_Mangaer_window.ma_controller;


namespace main
{
    public class XmlLoader
    {
        public static bool CheckIfUserNameExist(string VipCustomerName)
        {
            foreach (XElement xe in (XDocument.Load(XmlParser.xmlUsers).XPathSelectElements("//RegisteredUser")))
            {
                if (xe.Element("UserName").Value.Equals(VipCustomerName)&& xe.Element("Type").Value.Equals("Vipuser"))
                {
                    return true;
                }
            }
            return false;

        }

        public static bool CheckIfVipCustomerExist(string username , string password)
        {
            foreach (XElement xe in (XDocument.Load(XmlParser.xmlUsers).XPathSelectElements("//RegisteredUser")))
            {
                if (xe.Element("UserName").Value.Equals(username)&& xe.Element("PassWord").Value.Equals(password) && xe.Element("Type").Value.Equals("Vipuser"))
                {
                    return true;
                }
            }
            return false;

        }

        public static bool CheckIfManagerExist(string username, string password)
        {
            foreach (XElement xe in (XDocument.Load(XmlParser.xmlUsers).XPathSelectElements("//RegisteredUser")))
            {
                if (xe.Element("UserName").Value.Equals(username) && xe.Element("PassWord").Value.Equals(password) && xe.Element("Type").Value.Equals("Manager"))
                {
                    return true;
                }
            }
            return false;

        }
        public static bool CheckIfManagerType(string VipCustomerName)
        {
            foreach (XElement xe in (XDocument.Load(XmlParser.xmlUsers).XPathSelectElements("//RegisteredUser")))
            {
                if (xe.Element("Type").Value.Equals("Manager"))
                {
                    return true;
                }
            }
            return false;

        }
    }
    

}
