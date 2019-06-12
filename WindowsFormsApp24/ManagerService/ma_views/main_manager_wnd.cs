using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Controls;
using Main.yonor;
using Main;
using System.IO;
using System.Xml.Linq;
using System.Xml.XPath;

namespace MAIN_GUI_Mangaer_window
{
    public partial class main_manager_wnd : Form
    {
       
        public main_manager_wnd()
        {
            loadDefaultsData();
            //comboBoxLoad();
            InitializeComponent();
           
        }

        DataTable dt = new DataTable();
        StockManagement mst = new StockManagement();
        MailingList adsCampeingToAllCustomers = new MailingList(false);
        //static List<Advertisement> myAds = new List<Advertisement>();
        public static string AdSelectedToEdit;
        //public static bool adsCampeignEnable { get; set; }
        //public static void addToAdsArray(Advertisement myAdToAdd)
        //{
        //    myAds.Add(myAdToAdd);
        //}

        //public static Advertisement RetMyAdFromArr(string adName)
        //{
        //    foreach (Advertisement item in myAds)
        //    {
        //        if(item.CompanyName.Equals(adName))
        //        {
        //            return item;
        //        }
        //    }
        //    Advertisement emptyAd = new Advertisement();
        //  //  emptyAd.CompanyName = "null";
        //    return emptyAd;
        //}



        public void loadDefaultsData()
        {
            mst.pulletStock = 14;
            mst.sodaStock = 11;
            mst.steakStock = 22;
            mst.waterStock = 13;
            mst.burgetStock = 12;
            mst.colaStock = 12;
            dtColumns = "Item";
            dtColumns = "Amount";
            addRows("Hamburger", mst.burgetStock);
            addRows("Pullet", mst.pulletStock);
            addRows("Steak", mst.steakStock);
            addRows("Water", mst.waterStock);
            addRows("Soda", mst.sodaStock);
            addRows("Cola", mst.colaStock);
            dt.AcceptChanges();
         
        }

        string dtColumns
        {

            set
            {
                dt.Columns.Add(value);
            }
            get
            {
                return dt.Columns.ToString();
            }
            
        }

        public void addRows(string name, int amount)
        {
            dt.Rows.Add(name, amount);
            Console.WriteLine($"{name} , {amount} added. <<< DEBUGGING");
        }
        

        private void TabControlUsers_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void TabCrontrolUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DgStockMagnt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }
        //>>>>>>>>>>>>>>>>>>>>>>>>>>STOCK>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        private void BtnUpdateStock_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to update the stock? this uperation cannot be undone.", "Updating Main stock",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question,
     MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {

                foreach (DataRow dr in dt.Rows) // search whole table
                {
                    if (dr["Item"].Equals("Hamburger")) // if id==2
                    {
                        dr["Amount"] = Decimal.ToInt32(numericUpDown1Burger.Value); //change the name
                                                    //break; break or not depending on you
                    }
                    else if (dr["Item"].Equals("Pullet")) // if id==2
                    {
                        dr["Amount"] = Decimal.ToInt32(numericUpDown3Pullet.Value); //change the name
                                                                                    //break; break or not depending on you
                    }
                    else if (dr["Item"].Equals("Steak")) // if id==2
                    {
                        dr["Amount"] = Decimal.ToInt32(numericUpDown2Steak.Value); //change the name
                                                                                    //break; break or not depending on you
                    }
                    else if (dr["Item"].Equals("Water")) // if id==2
                    {
                        dr["Amount"] = Decimal.ToInt32(numericUpDown5Water.Value); //change the name
                                                                                    //break; break or not depending on you
                    }
                    else if (dr["Item"].Equals("Soda")) // if id==2
                    {
                        dr["Amount"] = Decimal.ToInt32(numericUpDown4Soda.Value); //change the name
                                                                                    //break; break or not depending on you
                    }
                    else if (dr["Item"].Equals("Cola")) // if id==2
                    {
                        dr["Amount"] = Decimal.ToInt32(numericUpDown6Cola.Value); //change the name
                                                                                    //break; break or not depending on you
                    }
                }


                dt.AcceptChanges();
                updateData();
            }
        }
            
        private void updateData()
        {
            dt.GetChanges();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void Main_manager_wnd_Load(object sender, EventArgs e)
        {
            updateData();
            loadDishesComboEdit();
            loadUsersComboEdit();
            loadAdsComboEdit();
            LoadSmtpValues();

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you really want to exit?", "Exit MAIN app",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question,
     MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {


                Application.Exit();
            }
        }

        //>>>>>>>>>>>>>>>>>>>>>>>>>>Smtp>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        private void SetSmtpSettings()
        {

            var doc = XElement.Load(ma_controller.XmlParser.xmlSmtpSettings);

            var hostEdition = doc.XPathSelectElements("//Host").Where(c => c.Element("HostIP").Value == textBox1SmtpIp.Text).Single();
            hostEdition.SetElementValue("HostIP", textBox1SmtpIp.Text);
            hostEdition.SetElementValue("Port", textBox4SmtpPort.Text);
            hostEdition.SetElementValue("Username", textBox3SmtpUsername.Text);
            hostEdition.SetElementValue("Password", textBox2SmtpPassword.Text);
            doc.Save(ma_controller.XmlParser.xmlSmtpSettings);
            MessageBox.Show("Smtp settings have been set, please test your connection.", "Smtp settings");

        }

        public void LoadSmtpValues()
        {
            textBox2SmtpPassword.PasswordChar = '*';
            DataSet smtpLoadSe = new DataSet();
            smtpLoadSe.ReadXml(ma_controller.XmlParser.xmlSmtpSettings);
            textBox1SmtpIp.Text = smtpLoadSe.Tables[0].Rows[0][0].ToString();
            textBox4SmtpPort.Text = smtpLoadSe.Tables[0].Rows[0][1].ToString();
            textBox3SmtpUsername.Text = smtpLoadSe.Tables[0].Rows[0][2].ToString();
            textBox2SmtpPassword.Text = smtpLoadSe.Tables[0].Rows[0][3].ToString();

        }

        //>>>>>>>>>>>>>>>>>>>>>>>>>>ADS>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        public void loadAdsComboEdit()
        {
            DataSet adLoad = new DataSet();
            adLoad.ReadXml(ma_controller.XmlParser.xmlAds);
            comboBox8EditAds.DisplayMember = "CompanyName";
            comboBox8EditAds.DataSource = adLoad.Tables[0];

        }


        private void Button10CreateAds_Click(object sender, EventArgs e)
        {
      

        }
        private void Button9EditAds_Click(object sender, EventArgs e)
        {
           
        }

        //public void AdscomboBoxLoad()
        //{
        //    foreach (Advertisement ad in myAds)
        //    {
        //        if(!(comboBox8Edit.Items.Cast<ComboBoxItem>().Any(cbi => cbi.Content.Equals(ad.ToString()))));
        //        {
        //            comboBox8Edit.Items.Add(ad);

        //        }
        //    }
        //}
        private void ComboBox8Edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdSelectedToEdit = comboBox8EditAds.SelectedItem.ToString();
        }



        //>>>>>>>>>>>>>>>>>>>>>>>>>>DISHES>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        private void Button6DishCreate_Click(object sender, EventArgs e)
        {
            ma_views.CreateDish myDishToCreate = new ma_views.CreateDish();
            myDishToCreate.ShowDialog();
            loadDishesComboEdit();
        }

        public void loadDishesComboEdit()
        {
            DataSet DishLoad = new DataSet();
            DishLoad.ReadXml(ma_controller.XmlParser.xmlDishPath);
            comboBox6EditListDish.DisplayMember = "Name";
            comboBox6EditListDish.DataSource = DishLoad.Tables[0];
            
        }
        public void loadUsersComboEdit()
        {
        
            DataSet UserLoad = new DataSet();
            UserLoad.ReadXml(ma_controller.XmlParser.xmlUsers);
            comboBox2EditUserMainWnd.DisplayMember = "FirstName";
            comboBox2EditUserMainWnd.DataSource = UserLoad.Tables[0];
        }

        private void Button8DishEdit_Click(object sender, EventArgs e)
        {
            ma_views.Edit_Dish myDishEdit = new ma_views.Edit_Dish(comboBox6EditListDish.Text);
            myDishEdit.ShowDialog();
            loadDishesComboEdit();

        }

        private void TabMenuMgmt_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox6EditListDish_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabPage1Dishes_Click(object sender, EventArgs e)
        {

        }

        private void Button1CreateUserMainForm_Click(object sender, EventArgs e)
        {
            ma_views.CreateUser myNewUser = new ma_views.CreateUser();
            myNewUser.ShowDialog();
            loadUsersComboEdit();
        }

        private void Button2EditUserMainForm_Click(object sender, EventArgs e)
        {
            ma_views.EditUser myUserToEdit = new ma_views.EditUser(comboBox2EditUserMainWnd.SelectedIndex, comboBox2EditUserMainWnd.Text);
            myUserToEdit.ShowDialog();
            loadUsersComboEdit();
        }

        private void Button12smtpSetCreds_Click(object sender, EventArgs e)
        {
            SetSmtpSettings();
            LoadSmtpValues();
        }

        private void Button9EditAds_Click_1(object sender, EventArgs e)
        {
            ma_views.Edit_ad formEditMyAd = new ma_views.Edit_ad(comboBox8EditAds.Text);
            formEditMyAd.ShowDialog();
        }

        private void Button10CreateAds_Click_1(object sender, EventArgs e)
        {
            ma_views.create_ad myAdCreation = new ma_views.create_ad();
            myAdCreation.ShowDialog();
            loadAdsComboEdit();
            //AdscomboBoxLoad();
        }
        
        private void Button1SmtpTestConn_Click(object sender, EventArgs e)
        {
            Mailer.TestConection($"{textBox5SmtpTestEmail.Text}");

            //Advertisement newAd = new Advertisement();
            //newAd.AdBody = "Body Body";
            //newAd.CompanyName = "TEsstC ompany";
            //Mailer.EmailAd(newAd);
            //Mailer.EmailPassword("info@pentest.co.il");
            //Mailer.LoadClientAndSendEmail();
            MessageBox.Show("Message sent.", "Password recovery");

        }

        private void CheckBox1OnOffCampaign_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1OnOffCampaign.Checked == true)
            {
                adsCampeingToAllCustomers.scheduleState = true;
                label3StatusMailingList.Text = "Sending Ads every 10 min to customers";
            }
            else
            {
                adsCampeingToAllCustomers.scheduleState = false;
                label3StatusMailingList.Text = "Currently not sending ads.";

            }
        }
    }
}
