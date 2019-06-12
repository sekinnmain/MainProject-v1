using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using main;



namespace main
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
        static List<Advertisement> myAds = new List<Advertisement>();
        public static string AdSelectedToEdit;


        public static void addToAdsArray(Advertisement myAdToAdd)
        {
            myAds.Add(myAdToAdd);
        }

        public static Advertisement RetMyAdFromArr(string adName)
        {
            foreach (Advertisement item in myAds)
            {
                if(item.CompanyName.Equals(adName))
                {
                    return item;
                }
            }
            Advertisement emptyAd = new Advertisement();
          //  emptyAd.CompanyName = "null";
            return emptyAd;
        }

     

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

        private void Button10CreateAds_Click(object sender, EventArgs e)
        {
            create_ad myAdCreation = new create_ad();
            myAdCreation.ShowDialog();
           // comboBoxLoad();

        }
        private void Button9EditAds_Click(object sender, EventArgs e)
        {
            Edit_ad formEditMyAd = new Edit_ad();
            formEditMyAd.ShowDialog();
        }
      

        /*public void comboBoxLoad()
        {
            foreach (Advertisement ad in myAds)
            {
                if(!(comboBox8Edit.Items.Cast<ComboBoxItem>().Any(cbi => cbi.Content.Equals(ad.ToString()))));
                {
                    comboBox8Edit.Items.Add(ad);

                }
            }
        }*/
        private void ComboBox8Edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdSelectedToEdit = comboBox8Edit.SelectedItem.ToString();
        }

        private void Button6DishCreate_Click(object sender, EventArgs e)
        {
            CreateDish myDishToCreate = new CreateDish();
            myDishToCreate.ShowDialog();
        }

        //>>>>>>>>>>>>>>>>>>>>>>>>>>DISHES>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

    }
}
