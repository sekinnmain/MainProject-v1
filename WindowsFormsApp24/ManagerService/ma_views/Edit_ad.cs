using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;
using Main.yonor;

namespace MAIN_GUI_Mangaer_window.ma_views
{
    public partial class Edit_ad : Form
    {
        Advertisement myAdToEdit = new Advertisement();
        string myAdEditName;
        public Edit_ad(string myAdToEdit)
        {
            myAdEditName = myAdToEdit;
            InitializeComponent();
            bindDataToAd();
        }
        

        public void bindDataToAd()
        {
            foreach (XElement xe in (XDocument.Load(ma_controller.XmlParser.xmlAds).XPathSelectElements("//Ad")))
            {
                if (xe.Element("CompanyName").Value.Equals(myAdEditName))
                {
                    //AddButtonToCategoryAppetizer(xe.Element("Name").Value);
                    //comboBox1DishTypeEdit.SelectedIndex = 0;
                    //                    comboBox1DishTypeEdit.SelectedItem = xe.Element("Type").Value;
                    textBox1EditAdCompanyName.Text = xe.Element("CompanyName").Value;
                    textBox4EditAdPrice.Text = xe.Element("Price").Value;
                    textBox5EditAdURL.Text = xe.Element("URL").Value;
                    DateTime adExpTime = DateTime.Parse(xe.Element("ExpirationDate").Value);
                    DateTime adCrTime = DateTime.Parse(xe.Element("CreationDate").Value);

                    dateTimePicker1ExpDateEdit.Value = adExpTime;
                    textBox2EditAdDescription.Text = xe.Element("AdBody").Value;
                   
                }
            }
        }
        private void SetValuesToAdInstance()
        {
            myAdToEdit.CompanyName = textBox1EditAdCompanyName.Text;
            myAdToEdit.AdBody = textBox2EditAdDescription.Text;
            myAdToEdit.Price = Convert.ToInt32(textBox4EditAdPrice.Text);
            myAdToEdit.Url = textBox5EditAdURL.Text;
            myAdToEdit.ExpirationDate = dateTimePicker1ExpDateEdit.Value;

        }

        private void WriteInstanceToXml()
        {

            var doc = XElement.Load(ma_controller.XmlParser.xmlAds);

            var adEdition = doc.XPathSelectElements("//Ad").Where(c => c.Element("CompanyName").Value == myAdEditName).Single();
            adEdition.SetElementValue("CompanyName", myAdToEdit.CompanyName);
            adEdition.SetElementValue("Price", myAdToEdit.Price);
            adEdition.SetElementValue("Active", myAdToEdit.Active);
            adEdition.SetElementValue("AdBody", myAdToEdit.AdBody);
            adEdition.SetElementValue("Image", myAdToEdit.ImgPath);
            adEdition.SetElementValue("ExpirationDate", myAdToEdit.ExpirationDate);
            adEdition.SetElementValue("URL", myAdToEdit.Url);
            doc.Save(ma_controller.XmlParser.xmlAds);
            MessageBox.Show($"Your {myAdToEdit.CompanyName} Ad has been edited.", "Edit Ad!");

        }

        public void loadValuesItemToEdit()
        {
            //textBox1EditAdName.Text = main_manager_wnd.
        }
        private void Button2EditAdCreate_Click(object sender, EventArgs e)
        {
            SetValuesToAdInstance();
            WriteInstanceToXml();
            this.Close();
        }

        private void Button3EditAdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1EditAdName_TextChanged(object sender, EventArgs e)
        {

        }
        public void LoadAdToEdit()
        {
            //textBox1EditAdCompanyName.Text = main_manager_wnd.AdSelectedToEdit;
        }

        private void Edit_ad_Load(object sender, EventArgs e)
        {

        }

        private void Button1EditBrowseAdImage_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                // image file path  
                myAdToEdit.ImgPath = open.FileName;
                label8AdEditImgLoaded.Text = "* Image Loaded *";

            }
        }
    }
}
