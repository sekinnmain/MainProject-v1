using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main.yonor;

namespace MAIN_GUI_Mangaer_window.ma_views
{
    public partial class create_ad : Form
    {

        Advertisement myAd = new Advertisement();

        public create_ad()
        {
            InitializeComponent();
        }
        
        
        public void adCreation()
        {
            myAd.Active = checkBox1AdState.Checked;
            myAd.AdBody = textBox2AdDescription.Text;
            myAd.CompanyName = textBox1AdName.Text;
            myAd.CreationDate = DateTime.Now;
            myAd.ExpirationDate = dateTimePicker1ExpDate.Value;
            myAd.Url = textBox5AdURL.Text;
            myAd.Price = Convert.ToInt32(textBox4AdPrice.Text);
            ma_controller.XmlParser.XmlParserAds(myAd);
        }
        private void Button2AdCreate_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to create this AD?", "MAIN - Create ad",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question,
   MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {

                adCreation();
                AdCreatedMsg(myAd.CompanyName);
                this.Close();
               
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                // image file path  
                myAd.ImgPath = open.FileName;
                label8AdImgLoaded.Text = "* Image Loaded *";

            }
        }

        private void Button3AdCancel_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Close ad creation?", "MAIN - Close ad creation",
  MessageBoxButtons.YesNo, MessageBoxIcon.Question,
  MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {

                this.Close();

            }
        }

        private void Create_ad_Load(object sender, EventArgs e)
        {

        }
        private void AdCreatedMsg(string myCrtAd)
        {
            MessageBox.Show($"Ad {myCrtAd} was successfully created", "Ad Creation",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
