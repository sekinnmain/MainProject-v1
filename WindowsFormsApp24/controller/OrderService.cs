
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using NewUsers;
using Main;
/*  IdOrder: int.Random
+User : user
+Dish[] : dish
+Customer: customer
-Pay : pay
+Timer: timer
SeatOrGo:bool

--
+OrderService(IdOrder int.Random, User user, Dish[] dish, Customer customer, Pay pay, Table int, Timer timer, SearOrGo bool, IfMemberShip)
+OpenMenu()
+SeatOrGo() :bool
+IfMemberShip() :bool
+CallToEmploye()
+EditDish()
<<properties>>
*/
namespace main
{
    public class OrderService
    {

        public int IdOrder;
        public User user;
        public List<Dish> dishes;
        public Pay pay;
        public Stopwatch timer;
        public string SeatOrGo;
        public int TableBnum;
        public double price;
        public Feedback feedback;
        public string Nots;

        public OrderService()
        {
            Random r = new Random();
            this.IdOrder = r.Next();
            this.TableBnum = r.Next();
            this.timer = new Stopwatch();
            timer.Start();
        }
        public OrderService(User user, List<Dish> dish, Pay pay, string SeatOrGo, double Price,Feedback feedback,string Nots)/*בנאי להזמנה מהמסעדב*/
        {
            Random r = new Random();
            this.IdOrder = r.Next();
            this.user = user;
            this.dishes = dish;
            this.pay = pay;
            this.SeatOrGo = SeatOrGo;
            this.TableBnum = r.Next(1,40);
            this.timer = new Stopwatch();
            this.feedback = feedback;
            timer.Start();//הפעלת הטיימר
            this.price = Price;
            this.Nots = Nots;


        }

        public OrderService(User user, List<Dish> dish, Pay pay,  string SeatOrGo)
        {
            this.user = user;
            this.dishes = dish;
            this.pay = pay;
            this.SeatOrGo = SeatOrGo;
            this.timer = new Stopwatch();
            timer.Start();//הפעלת הטיימר

        }

        public void InviteTable(DateTime date, DateTime time)
        {
            /*, עוברת על הרשימה של מאגר השולחנות ובודקת 
             * האם קיים בשירות עובד שולחן 
             * פעיל מהמאגר הנ"ל במידה ולא מוסיפה רשומה חדשה מעבירה את התאריך , משריינת את מספר השולחן ושמה '-' בשאר העמודות במידה וכן ת
             *  */
        }

        public User UserP { get { return this.user; } set { this.user = value; } }
        public int IdOrderP() { return this.IdOrder; }
        public Pay PayP { get { return this.pay; } set { this.pay = value; } }
        public Stopwatch TimerP() { return this.timer; }
        public string SeatOrGoP { get { return this.SeatOrGo; } set { this.SeatOrGo = value; } }
        public int TableBnumP { get { return this.TableBnum; } set { this.TableBnum = value; } }
        public double PriceP { get { return this.price; } set { this.price = value; } }


        public string  dishNameFromOrder()
        {
            string dishNames = " ";
            foreach (Dish  d in dishes)
            {
                dishNames += " "+d.DishName;
            }
            return dishNames;
        }
        public string Nots1()
        {
            return Nots;
        }





    }
}
