using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using NewUsers;
using System.Xml.XPath;
using System.IO;


namespace main
{
    public class XmlLoader
    {
        public static bool CheckIfUserNameExist(string VipCustomerName)
        {
            foreach (XElement xe in (XDocument.Load(XmlParser.xmlVipUsers).XPathSelectElements("//VIPCustomer")))
            {
                if (xe.Element("UserName").Value.Equals(VipCustomerName))
                {
                    return true;
                }
            }
            return false;

        }

        public static bool CheckIfVipCustomerExist(string username , string password)
        {
            foreach (XElement xe in (XDocument.Load(XmlParser.xmlVipUsers).XPathSelectElements("//VIPCustomer")))
            {
                if (xe.Element("UserName").Value.Equals(username)&& xe.Element("PassWord").Value.Equals(password))
                {
                    return true;
                }
            }
            return false;

        }

        public static bool CheckIfManagerExist(string username, string password)
        {
            foreach (XElement xe in (XDocument.Load(XmlParser.xmlVipUsers).XPathSelectElements("//VIPCustomer")))
            {
                if (xe.Element("UserName").Value.Equals(username) && xe.Element("PassWord").Value.Equals(password))
                {
                    return true;
                }
            }
            return false;

        }
    }
    

}
