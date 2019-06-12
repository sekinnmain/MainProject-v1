using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml.XPath;
using WindowsFormsApp24;
using Main;
using NewUsers;
using MAIN_GUI_Mangaer_window.ma_controller;

namespace main
{
    public partial class Menu : Form


    {
        List<Panel> listpanel = new List<Panel>();
        List<Button> listupbutton = new List<Button>();
        Regex regexCn = new Regex("[0-9][0-9][0-9][0-9]");
        Regex regexEd = new Regex("[0-9][0-9]['/'][0-9][0-9]");
        Regex regexEd2 = new Regex("[0][0]['/'][0][0]");
        Regex regex3d = new Regex("[0-9][0-9][0-9]");
        int count = 0;
        int CheckCardNumber1;
        int CheckExpirationdate1;
        int Check3digit1;
        int numIteractionButtonsMain = 1;
        int numIteractionButtonOrdersMain = 1;
        int numIteractionLabelsMain = 1;//Part of integration yo0x
        int numIteractionButtonsDessert = 1;
        int numIteractionButtonsDrink = 1;
        int numIteractionButtonsAppetizer = 1;
        OrderService myorder = new OrderService();      
        Pay pay = new Pay();
        Feedback fb = new Feedback();
        Dish myDish = new Dish();
        List<Dish> dishes = new List<Dish>();
        double TotalCost;
        string nots;
        User user = new User();

        public Menu()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            #region panel's




            listpanel.Add(ChooseDish_panel);
            listpanel.Add(EditDish_panel);
            listpanel.Add(Pay_pnl);
            listpanel.Add(feedback_pnl);
            listpanel.Add(end_pnl);
            for (int i = 1; i < 5; i++)
            {
                listpanel[i].Visible = false;
            }
            listpanel[count].Visible = true;

            listupbutton.Add(ChooseDish_btn);
            listupbutton.Add(EditDish_btn);
            listupbutton.Add(Pay_btn);
            listupbutton.Add(FeedBack_btn);
            listupbutton.Add(finish_btn);
            listupbutton[count].Enabled = true;
            for (int i = 1; i < 4; i++)
            {
                listupbutton[i].Enabled = false;
            }
            Previous_Choose_btn.Enabled = false;
            #endregion
            LoadDishesButtonsInSections(); //Integration



        }


        private void Next_Choose_btn_Click(object sender, EventArgs e)
        {
            count++;
            Previous_Choose_btn.Enabled = true;
            Previous_Pay_btn.Enabled = true;
            PayCheck();
            listupbutton[count].Enabled = true;
            listupbutton[count - 1].Enabled = false;
            listpanel[count].Visible = true;
            DisheMenu_tab.Visible = false;
            NextPreviouscheck();
            ChooseEditMenuCheck();
            EditCheck();
            CreateFeedBack();


        }

        private void Previous_Choose_btn_Click(object sender, EventArgs e)
        {
            count--;
            listpanel[count].Visible = true;
            listupbutton[count].Enabled = true;
            listpanel[count + 1].Visible = false;/*כל פעם שעובר פאנל פאנל אחד מוצג , ואחד נעלם*/
            listupbutton[count + 1].Enabled = false;/*כל פעם שעובר פאנל כפתור אחד מוצג , ואחד נעלם*/
            NextPreviouscheck();
            ChooseEditMenuCheck();
            EditCheck();
            CreateFeedBack();
            

        }

        private void NextPreviouscheck()/*גורמת לכפתור ה"קודם" להיות אפורה בהתחלה, וגורמת לכפתור ה"הבא" להיות בפאנל האחרון אפור*/
        {
            if (count == 4 || count == 2)
            {
                Next_Choose_btn.Enabled = false;
            }
            else
            {
                Next_Choose_btn.Enabled = true;
            }
        }


        private void ChooseEditMenuCheck()/*בודקת האם הגעת לעריכת מנה או בחירת מנה*/
        {
            if (count == 0)
            {
                listpanel[count].Visible = true;
                listpanel[count].Visible = true;
                DisheMenu_tab.Visible = true;
                Previous_Choose_btn.Enabled = false;
                DishInfo_pnl.Visible = true;
            }
        }

        private void EditCheck()
        {
            if (count == 1)
            {
                EditDish_panel.Visible = true;
                EditDish_btn.Visible = true;
                DishInfo_pnl.Visible = false;

            }
        }

        private void PayCheck()
        {
            if (count == 2)
            {
                if ((MessageBox.Show("This is the last time to edit before the pay, are you sure u want to continue?", "Pre-payment Notice",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    //getTotalCost();
                    get_total_price_lbl.Text = TotalCost.ToString() + " ILS";
                    Previous_Choose_btn.Enabled = false;

                }

            }
        }

        //public void getTotalCost()
        //{
        //    foreach (Dish d in this.dishes)
        //    {
        //        this.TotalCost += d.DishPrice;
        //    }
        //}


        #region Creation's
        private void CreateFeedBack()
        {
            if (count == 4)
            {
                int rate = Convert.ToInt32(fb_rate.Value);
                string desc = fb_description.Text;
                fb_commant_lbl.Visible = false;
                rate_lbl.Visible = false;
                Feedback feedback = new Feedback(desc, rate);
                this.fb = feedback;

            }
            else if (count == 3)
            {
                ok_paynum_lbl.Visible = false;
                Previous_Choose_btn.Enabled = false;
            }
        }





        #endregion Creation's


        private void paynow_btn_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(String.Format("You're sure your details are correct and you want to make a payment of {0} ILS ?",this.TotalCost), "Pre-payment Notice",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                CheckCardNumber();
                CheckExpirationdate();
                Check3digit();
                CreatePay();

            }

        }

        #region PayPnl


        private void CheckCardNumber()
        {

            if (this.regexCn.IsMatch(textPay1.Text) &&
                this.regexCn.IsMatch(textPay2.Text) &&
                this.regexCn.IsMatch(textPay3.Text) &&
                this.regexCn.IsMatch(textPay4.Text))
            {
                ok_cardnumber_lbl.Visible = true;
                cnWrong_lbl.Visible = false;
                this.CheckCardNumber1 = 1;
            }
            else
            {
                cnWrong_lbl.Visible = true;
                ok_cardnumber_lbl.Visible = false;
                this.CheckCardNumber1 = 0;
            }
        }

        private void CheckExpirationdate()
        {

            if (this.regexEd.IsMatch(edText.Text) && edText.Text != "00/00")
            {
                ok_ed_lbl.Visible = true;
                ed_worng_lbl.Visible = false;
                this.CheckExpirationdate1 = 1;

            }
            else
            {
                ed_worng_lbl.Visible = true;
                ok_ed_lbl.Visible = false;
                this.CheckExpirationdate1 = 0;
            }
        }


        private void Check3digit()
        {

            if (this.regex3d.IsMatch(digitext3.Text))
            {
                ok_3digit_lbl.Visible = true;
                digit_worng_lbl.Visible = false;
                this.Check3digit1 = 1;
            }
            else
            {
                digit_worng_lbl.Visible = true;
                ok_3digit_lbl.Visible = false;
                this.Check3digit1 = 0;
            }
        }
        private void CreatePay()
        {
            if (CheckCardNumber1 == 1 && CheckExpirationdate1 == 1 && Check3digit1 == 1)
            {
                string CreditCardNum = (textPay1.Text + textPay2.Text + textPay3.Text + textPay4.Text);
                ok_paynum_lbl.BringToFront();
                ok_paynum_lbl.Visible = true;
                wrong_paynow_lbl.Visible = false;
                Next_Choose_btn.Enabled = true;
                textPay1.Enabled = false;
                textPay2.Enabled = false;
                textPay3.Enabled = false;
                textPay4.Enabled = false;
                edText.Enabled = false;
                digitext3.Enabled = false;
                this.pay.creditCardNumber = CreditCardNum;
                this.pay.threeDigit = digitext3.Text;
                this.pay.expirationDate = edText.Text;
                myorder.pay = this.pay;

            }
            else
            {
                ok_paynum_lbl.Visible = false;

            }


        }
        #endregion

        private void Call_Service_Choose_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Call was sent please wait", "Employee's order");
        }

        private void finish_end_btn_Click(object sender, EventArgs e)
        {
            /* OrderService(, List < Dish > dish,pay, get_seat_orGo_lbl.Text, double Price, fb)*/
            this.Close();
        }
        #region Integration with Manager Service
        private void LoadDishesButtonsInSections()
        {
            //DataSet DishLoad = new DataSet();
            //DishLoad.ReadXml(XmlParser.xmlDishPath);
            //for (int i = 1; i <= CountDishesInXml("//Dish", XmlParser.xmlDishPath); i++)
            //{

            //}
            //xpath //Type[text()="Main"]
            //foreach (XElement xe in (XDocument.Load(XmlParser.xmlDishPath).Descendants("Dish")))
            DishInfo_pnl.Visible = true;
            DishInfo_pnl.BringToFront();

            foreach (XElement xe in (XDocument.Load(XmlParser.xmlDishPath).XPathSelectElements("//Dish")))
            {
                if (xe.Element("Type").Value.Equals("Appetizer"))
                {
                    AddButtonToCategoryAppetizer(xe.Element("Name").Value);

                }
                else if (xe.Element("Type").Value.Equals("Main"))
                {
                    AddButtonToCategoryMain(xe.Element("Name").Value);
                }
                else if (xe.Element("Type").Value.Equals("Dessert"))
                {
                    AddButtonToCategoryDessert(xe.Element("Name").Value);
                }
                else if (xe.Element("Type").Value.Equals("Drink"))
                {
                    AddButtonToCategoryDrink(xe.Element("Name").Value);
                }
            }
        }




        public void AddButtonToCategoryAppetizer(string nameOfButton)
        {

            List<Button> buttons = new List<Button>();//Part of integration yo0x
            Button newButton = new Button();
            buttons.Add(newButton);
            this.Controls.Add(newButton);
            newButton.MouseHover += (s, e) => { ShowDishData(nameOfButton); };
            newButton.Click += (s, e) => { AddDishToOrder(nameOfButton); };
            groupBox1AppetizerDishes.Controls.Add(newButton);
            newButton.Top = numIteractionButtonsAppetizer * 40;
            newButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newButton.Left = 3;
            newButton.Text = nameOfButton;
            numIteractionButtonsAppetizer += 1;
            newButton.Height = 40;
            newButton.Width = 285;

            //return newButton;
        }
        public void AddButtonToCategoryMain(string nameOfButton)
        {

            List<Button> buttons = new List<Button>();//Part of integration yo0x
            Button newButton = new Button();
            buttons.Add(newButton);
            this.Controls.Add(newButton);
            newButton.MouseHover += (s, r) => { ShowDishData(nameOfButton); };
            newButton.Click += (s, e) => { AddDishToOrder(nameOfButton); };
            groupBox1MainButtons.Controls.Add(newButton);
            newButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newButton.Top = numIteractionButtonsMain * 40;
            newButton.Left = 3;
            newButton.Text = nameOfButton;
            numIteractionButtonsMain += 1;
            newButton.Height = 40;
            newButton.Width = 285;

            //return newButton;
        }
        public void AddButtonToCategoryDessert(string nameOfButton)
        {

            List<Button> buttons = new List<Button>();//Part of integration yo0x
            Button newButton = new Button();
            buttons.Add(newButton);
            this.Controls.Add(newButton);
            newButton.MouseHover += (s, r) => { ShowDishData(nameOfButton); };
            newButton.Click += (s, e) => { AddDishToOrder(nameOfButton); };
            groupBox1DessertButtons.Controls.Add(newButton);
            newButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newButton.Top = numIteractionButtonsDessert * 40;
            newButton.Left = 3;
            newButton.Text = nameOfButton;
            numIteractionButtonsDessert += 1;
            newButton.Height = 40;
            newButton.Width = 285;
            //return newButton;
        }
        public void AddButtonToCategoryDrink(string nameOfButton)
        {

            List<Button> buttons = new List<Button>();//Part of integration yo0x
            Button newButton = new Button();
            buttons.Add(newButton);
            this.Controls.Add(newButton);
            newButton.MouseHover += (s, r) => { ShowDishData(nameOfButton); };
            newButton.Click += (s, e) => { AddDishToOrder(nameOfButton); };
            groupBox1DrinkButtons.Controls.Add(newButton);
            //newButton.BackgroundImage = Image.FromFile("\\Resources\\MainCourseButton");
            newButton.Top = numIteractionButtonsDrink * 40;
            newButton.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newButton.Left = 3;
            newButton.Text = nameOfButton;
            numIteractionButtonsDrink += 1;
            newButton.Height = 40;
            newButton.Width = 285;
            //return newButton;
        }

        public void ShowDishData(string dishName)
        {

            foreach (XElement xe in (XDocument.Load(XmlParser.xmlDishPath).XPathSelectElements("//Dish")))
            {
                if (xe.Element("Name").Value.Equals(dishName))
                {

                    label15DishName.Text = xe.Element("Name").Value;
                    label14DishSize.Text = xe.Element("Size").Value+ " CAL";
                    //label9DishPrice.Text = xe.Element("Price").Value;
                    get_price_dish_lbl.Text = xe.Element("Price").Value + " ILS";
                    textBox1DishDescription.Text = xe.Element("Description").Value;

                }
            }
        }



        private int CountDishesInXml(string xPathStr, string xmlPath)
        {
            return XDocument.Load(xmlPath).XPathSelectElements(xPathStr).Count();
        }

        private string GetNameDishesXml(string myXmlFile)
        {
            return XDocument.Load(myXmlFile).Root.Element("Dish").Element("Name").Value;
        }

        #endregion

        private void tabPage2_Click(object sender, EventArgs e)
        {
            DishInfo_pnl.BringToFront();
            DishInfo_pnl.Visible = true;
        }

        private void appetizer_tab_Click(object sender, EventArgs e)
        {
            DishInfo_pnl.BringToFront();
            DishInfo_pnl.Visible = true;
        }
        private void AddDishToOrder(string nameOfButton)
        {
            Dish myDish = new Dish();
            foreach (XElement xe in (XDocument.Load(XmlParser.xmlDishPath).XPathSelectElements("//Dish")))
            {
                if (xe.Element("Name").Value.Equals(nameOfButton))
                {
                    myDish.DishName = xe.Element("Name").Value;
                    myDish.DishSize = Convert.ToInt32(xe.Element("Size").Value);
                    myDish.DishPrice = Convert.ToInt32(xe.Element("Price").Value);
                    myDish.DishDescription = xe.Element("Description").Value;
                    if ((MessageBox.Show(String.Format("Add '{0}' to the order pack?", myDish.DishName), "Employee",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                    {
                        this.dishes.Add(myDish);
                        TotalCost += myDish.DishPrice;
                        AddLabelToOrderChoose(myDish);
                    }

                }
            }

        }

        public void AddLabelToOrderChoose(Dish myDish)
        {

            List<Label> Labels = new List<Label>();
            List<Button> buttons = new List<Button>();
            Label newLabel = new Label();
            Button newButton = new Button();
            Labels.Add(newLabel);
            Orders_GB.Controls.Add(newLabel);
            newLabel.Top = numIteractionLabelsMain * 20;
            newLabel.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newLabel.Left = 40;
            newLabel.Text = myDish.DishName;
            numIteractionLabelsMain += 1;
            newLabel.Height = 20;
            newLabel.Width = 150;
            newButton.Height = 1;
            buttons.Add(newButton);
            this.Controls.Add(newButton);
            Orders_GB.Controls.Add(newButton);
            newButton.Left = 10;
            newButton.BackColor= Color.Red;
            newButton.Top = numIteractionButtonOrdersMain * 20;
            numIteractionButtonOrdersMain += 1;
            newButton.Height = 10;
            newButton.Width = 20;
            newButton.Click += (s, e) => {
                this.TotalCost -= myDish.DishPrice;
                Orders_GB.Controls.Remove(newButton);
                Orders_GB.Controls.Remove(newLabel);
                this.dishes.Remove(myDish);
                numIteractionButtonOrdersMain -= 1;
                numIteractionLabelsMain -= 1;
               

            };
            //return newButton;
        }



        //return newLabel;


        private void save_changes_btn_Click(object sender, EventArgs e)
        {
            this.nots = richTextBox1.Text;
            MessageBox.Show("The Changes Saved", "Employee's order");
        }

        private void finish_end_btn_Click_1(object sender, EventArgs e)
        {
            //Pay pay = new Pay();
            //Feedback fb = new Feedback();
            //Dish myDish = new Dish();
            //List<Dish> dishes = new List<Dish>();
            //double TotalCost;
            //public OrderService(User user, List<Dish> dish, Pay pay, string SeatOrGo, double Price, Feedback feedback, string Nots)
            fb.customerFeedback = fb_description.Text;
            fb.rateFeedback = Convert.ToInt32(fb_rate.Value);
            myorder.dishes = this.dishes;
            myorder.user = user;
            myorder.price = this.TotalCost;
            myorder.feedback = this.fb;
            myorder.SeatOrGo = get_seat_orGo_lbl.Text;
            myorder.Nots = nots;
            XmlParser.XmlParserOrder(myorder);
            XmlParser.XmlParserFeedback(fb);
            this.Close();
        }
    }
}