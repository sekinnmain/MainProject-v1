using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace main
{
    public partial class create_ad : Form
    {
        public create_ad()
        {
            InitializeComponent();
        }
        Advertisement myAd = new Advertisement();
        
        
        public void adCreation()
        {
            myAd.Active = checkBox1AdState.Checked;
            myAd.AdBody = textBox2AdDescription.Text;
            myAd.CompanyName = textBox1AdName.Text;
            myAd.CreationDate = DateTime.Now;
            myAd.ExpirationDate = dateTimePicker1ExpDate.Value;
            main_manager_wnd.addToAdsArray(myAd);
        }
        private void Button2AdCreate_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to create this AD?", "MAIN - Create ad",
   MessageBoxButtons.YesNo, MessageBoxIcon.Question,
   MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {

                adCreation();
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
            if ((MessageBox.Show("Close ad cretion?", "MAIN - Close ad cretion",
  MessageBoxButtons.YesNo, MessageBoxIcon.Question,
  MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {

                this.Close();

            }
        }
    }
}
