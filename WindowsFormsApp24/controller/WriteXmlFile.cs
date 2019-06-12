using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using NewUsers;
using main;

namespace main
{
    public class WriteXmlFile
    {
        private Dish dsh = new Dish();
        VipCustomer vip = new VipCustomer();
        Employee emp = new Employee();
        ManagerUser mng = new ManagerUser();

        public WriteXmlFile(Dish myDish)
        {
            dsh = myDish;

        }
        public  WriteXmlFile(VipCustomer vipCustomer)
        {
            vip = vipCustomer;
        }
        public WriteXmlFile(Employee empUser)
        {
            emp = empUser;
        }
        public WriteXmlFile(ManagerUser mngUser)
        {
            mng = mngUser;
        }


        public void XmlDishWrite()
        {
            DataTable dt1 = new DataTable("Dishes");
            dt1.Columns.Add("Dish Name", typeof(string));
            dt1.Columns.Add("Dish Price", typeof(float));
            dt1.Columns.Add("size", typeof(float));
            dt1.Columns.Add("Image Path", typeof(string));
            dt1.Columns.Add("Dish description", typeof(string));
            dt1.Rows.Add(dsh.DishName, dsh.DishPrice, dsh.DishSize, dsh.DishDescription, dsh.DishImage);
            dt1.WriteXml(@"C:\Users\User\Desktop\MAIN project\Login Screen\Login Screen");
        }
        public void XmlVipWrite()
        {
            DataTable dt2 = new DataTable("Vip Customers");
            dt2.Columns.Add("First Name", typeof(string));
            dt2.Columns.Add("Last Name", typeof(string));
            dt2.Columns.Add("User Name", typeof(string));
            dt2.Columns.Add("Pass Word", typeof(string));
            dt2.Columns.Add("Email", typeof(string));
            dt2.Columns.Add("Adress", typeof(string));
            dt2.Columns.Add("Phone Number", typeof(string));
            dt2.Columns.Add("Credit Card", typeof(string));
            dt2.Rows.Add(vip.FirstName, vip.LastName, vip.UserName, vip.PassWord, vip.Email, vip.adress, vip.PhoneNumber, vip.CreditCard);
            dt2.WriteXml(@"C:\Users\User\Desktop\MAIN project\Login Screen\Login Screen");
        }
        public void XmlEmployeeWrite()
        {
            DataTable dt3 = new DataTable("Employees");
            dt3.Columns.Add("First Name", typeof(string));
            dt3.Columns.Add("Last Name", typeof(string));
            dt3.Columns.Add("ID", typeof(string));
            dt3.Columns.Add("Email", typeof(string));
            dt3.Columns.Add("Adress", typeof(string));
            dt3.Columns.Add("Phone Number", typeof(string));
            dt3.Columns.Add("Bank Account", typeof(string));
            dt3.Rows.Add(emp.FirstName, emp.LastName, emp.ID, emp.Email, emp.adress, emp.BankAccount);
            dt3.WriteXml(@"C:\Users\User\Desktop\MAIN project\Login Screen\Login Screen");
        }

    }
}
