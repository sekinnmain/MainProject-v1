using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using main;

namespace main
{
    public class XmlParser
    {
        private static string AppPath => Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
        private static DirectoryInfo myDir = new DirectoryInfo(AppPath);
        private static string dataDir = myDir.Parent.Parent.FullName.ToString();
        public static string xmlDishPath = $"{dataDir}\\Data\\Dishes.xml";
        public static string xmlFeedBack = $"{dataDir}\\Data\\FeedBack.xml";
        public static string xmlVipUsers = $"{dataDir}\\Data\\VipUsers.xml";
        public static string xmlOrder = $"{dataDir}\\Data\\Orders.xml";

        //Dish myDish = new Dish();

        public static void XmlParserDish(Dish passDish)
        {
            XDocument doc = XDocument.Load(xmlDishPath);
            XElement school = doc.Element("Dishes");
            school.Add(new XElement("Dish",
                       new XElement("Name", passDish.DishName),
                       new XElement("Price", passDish.DishPrice),
                       new XElement("Size", passDish.DishSize),
                       new XElement("Description", passDish.DishDescription),
                       new XElement("Image", passDish.DishImage)));

            doc.Save(xmlDishPath);
        }

        public static void XmlParserVipCustomer(VipCustomer vip)
        {
            XDocument doc = XDocument.Load(xmlVipUsers);
            XElement school = doc.Element("VIPCustomers");
            school.Add(new XElement("VIPCustomer",
                       new XElement("FirstName", vip.FirstName),
                       new XElement("LastName", vip.LastName),
                       new XElement("UserName", vip.UserName),
                       new XElement("PassWord", vip.PassWord),
                       new XElement("Email", vip.Email),
                       new XElement("Adress", vip.adress),
                       new XElement("PhoneNumber", vip.PhoneNumber),
                       new XElement("CreditCard", vip.CreditCard)));

            doc.Save(xmlVipUsers);
        }
        public static void XmlParserOrder(OrderService myOrder)
        {
            XDocument doc = XDocument.Load(xmlOrder);
            XElement school = doc.Element("Orders");
            school.Add(new XElement("Order",
                       new XElement("IdOrder", myOrder.IdOrder),
                       new XElement("user", myOrder.user),
                       new XElement("dishes", myOrder.dishNameFromOrder()),
                       new XElement("TimeOrder", DateTime.Now),
                       new XElement("SeatOrGo", myOrder.SeatOrGo),
                       new XElement("TableBnum", myOrder.TableBnum),
                       new XElement("ClinetRequest", myOrder.Nots),
                       new XElement("Price", myOrder.price)));
                       

            doc.Save(xmlOrder);
        }




    }
}
