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
using Main;

namespace MAIN_GUI_Mangaer_window.ma_views
{
    public partial class Edit_Dish : Form
    {
        Dish myDisToEdit = new Dish();
        string myDishToEditName;
        public Edit_Dish(string dishToEdit)
        {
            myDishToEditName = dishToEdit;
            InitializeComponent();
            BindDataEditDish(dishToEdit);
        }

        private void Edit_Dish_Load(object sender, EventArgs e)
        {
            LoadDefaultTypeForDish();
        }

        private void LoadDefaultTypeForDish()
        {
            comboBox1DishTypeEdit.Items.Add("Appetizer");
            comboBox1DishTypeEdit.Items.Add("Main");
            comboBox1DishTypeEdit.Items.Add("Dessert");
            comboBox1DishTypeEdit.Items.Add("Drink");
            comboBox1DishTypeEdit.SelectedIndex = 2;
        }
        private void BindDataEditDish(string myEditDish)
        {

            foreach (XElement xe in (XDocument.Load(ma_controller.XmlParser.xmlDishPath).XPathSelectElements("//Dish")))
            {
                if (xe.Element("Name").Value.Equals(myEditDish))
                {
                    //AddButtonToCategoryAppetizer(xe.Element("Name").Value);
                    //comboBox1DishTypeEdit.SelectedIndex = 0;
//                    comboBox1DishTypeEdit.SelectedItem = xe.Element("Type").Value;
                    textBox1EditDishName.Text = xe.Element("Name").Value;
                    numericUpDown2DishEditSize.Text = xe.Element("Size").Value;
                    numericUpDown1EditDishPrice.Text = xe.Element("Price").Value;
                    textBox4DishDescriptonEdit.Text = xe.Element("Description").Value;
                    label7PathToImgDishEdit.Text = "Image loaded at: " + xe.Element("Image").Value;
                }
            }


            //DataSet DishLoad = new DataSet();
            //DishLoad.ReadXml(ma_controller.XmlParser.xmlDishPath);

            //textBox1EditDishName.DataBindings.Add("Text", DishLoad.Tables[0], "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            ////comboBox1DishTypeEdit.DataBindings.Add("Text",DishLoad.Tables[])
        }

        private void Button1EditDishImage_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                // image file path  
                myDisToEdit.DishImage = open.FileName;
                label7PathToImgDishEdit.Text = $"* Image Loaded at: *{open.FileName}";

            }
        }

        private void Button2EditDish_Click(object sender, EventArgs e)
        {
            SetValuesToDishInstance();
            WriteInstanceToXml();
            this.Close();


        }
        private void SetValuesToDishInstance()
        {
            myDisToEdit.DishType = comboBox1DishTypeEdit.SelectedItem.ToString();
            myDisToEdit.DishName = textBox1EditDishName.Text;
            var priceDish = Convert.ToInt32(numericUpDown1EditDishPrice.Value);
            myDisToEdit.DishPrice = priceDish;
            var sizeDish = Convert.ToInt32(numericUpDown2DishEditSize.Value);
            myDisToEdit.DishSize = sizeDish;
            myDisToEdit.DishDescription = textBox4DishDescriptonEdit.Text;
        }
        private void WriteInstanceToXml()
        {

            var doc = XElement.Load(ma_controller.XmlParser.xmlDishPath);

            var dishEdition = doc.XPathSelectElements("//Dish").Where(c => c.Element("Name").Value == myDishToEditName).Single();
            dishEdition.SetElementValue("Name", myDisToEdit.DishName);

            dishEdition.SetElementValue("Price", myDisToEdit.DishPrice);
            dishEdition.SetElementValue("Size", myDisToEdit.DishSize);
            dishEdition.SetElementValue("Image", myDisToEdit.DishImage);
            dishEdition.SetElementValue("Type", myDisToEdit.DishType);
            dishEdition.SetElementValue("Description", myDisToEdit.DishDescription);
            //dishEdition.Element("balance").Value = "50";
            doc.Save(ma_controller.XmlParser.xmlDishPath);
            MessageBox.Show($"Your {myDisToEdit.DishName} dish has been edited.", "Edit created!");

        }
    }
}
