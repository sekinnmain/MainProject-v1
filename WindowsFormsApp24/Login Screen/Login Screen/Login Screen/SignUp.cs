using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewUsers;
using System.Xml.Linq;
using main;


namespace Login_Screen
{
    public partial class SignUp : Form
    {
        DataTable dt = new DataTable("dt");
        public SignUp()
        {
            InitializeComponent();

        }

        private void CheckButton1_MouseEnter(object sender, EventArgs e)
        {
            CheckButton1.BackColor = Color.DarkGreen;
        }

        private void CheckButton1_MouseLeave(object sender, EventArgs e)
        {
            CheckButton1.BackColor = Color.SeaGreen;
        }

        private void SignUpButton_MouseEnter(object sender, EventArgs e)
        {
            SignUpButton.BackColor = Color.DarkGreen;
        }

        private void SignUpButton_MouseLeave(object sender, EventArgs e)
        {
            SignUpButton.BackColor = Color.SeaGreen;
        }

        private void CheckButton1_Click(object sender, EventArgs e)
        {

            bool chk = XmlLoader.CheckIfUserNameExist(RegisterUserName1TextBox.Text);
            
            if (RegisterUserName1TextBox.Text.Length >= 4 && RegisterUserName1TextBox.Text.Length <= 14 && chk == false )
            {
                AviableUserNameName1.Visible = true;
                UnAviableUserNameLabel1.Visible = false;
            }
            else
            {
                UnAviableUserNameLabel1.Visible = true;
                AviableUserNameName1.Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 4)
            {
                textBox3.MaxLength = 4;
                textBox4.Enabled = true;
                textBox4.Select();

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 4)
            {
                textBox4.MaxLength = 4;
                textBox5.Enabled = true;
                textBox5.Select();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length == 4)
            {
                textBox5.MaxLength = 4;
                textBox6.MaxLength = 4;
                textBox6.Enabled = true;
                textBox6.Select();
            }
        }

        private void RegisterPhone1TextBox_TextChanged(object sender, EventArgs e)
        {
            RegisterPhone1TextBox.MaxLength = 7;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (AviableUserNameName1.Visible && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != ""
                && RegisterEmail1ComboBox.Text != "" && RegisterEmail1TextBox.Text != "" && RegisterPassWord1TextBox.Text != "" && RegisterPhone1ComboBox.Text != "" && RegisterPhone1TextBox.Text != "" && RegisterStreet1TextBox.Text != "")
            {
                VipCustomer vip = new VipCustomer();
                vip.FirstName = textBox1.Text;
                vip.LastName = textBox2.Text;
                vip.UserName = RegisterUserName1TextBox.Text;
                vip.PassWord = RegisterPassWord1TextBox.Text;
                vip.Email = RegisterEmail1TextBox.Text + "@" + RegisterEmail1ComboBox.Text;
                vip.adress = RegisterStreet1TextBox.Text;
                vip.PhoneNumber = RegisterPhone1ComboBox.Text + RegisterPhone1TextBox.Text;
                vip.CreditCard = textBox3.Text + textBox4.Text + textBox5.Text + textBox6.Text;
                XmlParser.XmlParserVipCustomer(vip);
                                
                MessageBox.Show("Succesfully Registered", "WOOHOO");
                
                this.Close();
               // LoginScreen.listsign.Clear();



            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
        }
    }
}
