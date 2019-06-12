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
    public partial class CreateDish : Form
    {
        Dish myDish = new Dish();
        

        public CreateDish()
        {
            InitializeComponent();
        }

        private void Button2Create_Click(object sender, EventArgs e)
        {
            myDish.DishName = textBox1CreateDishName.Text;
            myDish.DishDescription = textBox4DishDescripton.Text;
            var priceDish = Convert.ToInt32(numericUpDown1CreDishPrice.Value);
            myDish.DishPrice = priceDish;
            myDish.DishSize = Convert.ToInt32(numericUpDown2DishCreateSize.Value);
            myDish.DishType = comboBox1DishType.SelectedItem.ToString();
            WriteXmlFile xmlDish = new WriteXmlFile(myDish);
            xmlDish.XmlDishWrite();
            MessageBox.Show($"Your {myDish.DishName} dish has been created.","Dish created!" );
            this.Close();


        }

        private void Button1CraDishImage_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                // image file path  
                myDish.DishImage = open.FileName;
                label7PathToImgDish.Text = "* Image Loaded *";

            }
        }

        private void CreateDish_Load(object sender, EventArgs e)
        {
            comboBox1DishType.Items.Add("Appetizer");
            comboBox1DishType.Items.Add("Main");
            comboBox1DishType.Items.Add("Dessert");
            comboBox1DishType.Items.Add("Drink");
        }

        private void Button3Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
