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
using System.Text.RegularExpressions;
using MAIN_GUI_Mangaer_window.ma_controller;

namespace Login_Screen
{
    public partial class SignUp : Form
    {
        DataTable dt = new DataTable("dt");
        Regex PhoneNumberReg = new Regex("[0-9][0-9][0-9][0-9][0-9][0-9][0-9]");
        

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

        

        private void RegisterPhone1TextBox_TextChanged(object sender, EventArgs e)
        {
            RegisterPhone1TextBox.MaxLength = 7;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            UnSuccesEmailCheckLabel.Visible = true;
            UnSuccesFirstNameCheckLabel.Visible = true;
            UnSuccesLastNameCheckLabel.Visible = true;
            UnSuccesPassWordCheckLabel.Visible = true;
            UnSuccesPhoneCheckLabel.Visible = true;
            UnSuccesStreetCheckLabel.Visible = true;
            UnSuccesUserNameCheckLabel.Visible = true;
            UnSuccesVerifyPassWordCheckLabel.Visible = true;
            if (AviableUserNameName1.Visible == true)
            {
                SuccesUserNameCheckLabel.Visible = true;
                UnSuccesUserNameCheckLabel.Visible = false;
            }
            if (RegisterPassWord1TextBox.Text.Length <= 14 && RegisterPassWord1TextBox.Text.Length >= 4)
            {
                SuccesPassWordCheckLabel.Visible = true;
                UnSuccesPassWordCheckLabel.Visible = false;
                
            }
            if (VerfyPassWordTextBox.Text == RegisterPassWord1TextBox.Text)
            {
                SuccesVerifyPassWordCheckLabel.Visible = true;
                UnSuccesVerifyPassWordCheckLabel.Visible = false;

            }
            if (RegisterEmail1TextBox.Text.Length >= 4 && RegisterEmail1TextBox.Text.Length <= 14 && RegisterEmail1ComboBox.Text != "")
            {
                SuccesEmailCheckLabel.Visible = true;
                UnSuccesEmailCheckLabel.Visible = false;
            }
            if (PhoneNumberReg.IsMatch(RegisterPhone1TextBox.Text) && RegisterPhone1ComboBox.Text != "")
            {
                SuccesPhoneCheckLabel.Visible = true;
                UnSuccesPhoneCheckLabel.Visible = false;
            }
            if (RegisterStreet1TextBox.Text != "")
            {
                SuccesStreetCheckLabel.Visible = true;
                UnSuccesStreetCheckLabel.Visible = false;
            }
            if (textBox1.Text != "")
            {
                SuccesFirstNameCheckLabel.Visible = true;
                UnSuccesFirstNameCheckLabel.Visible = false;
            }
            if (textBox2.Text != "")
            {
                SuccesLastNameCheckLabel.Visible = true;
                UnSuccesLastNameCheckLabel.Visible = false;
            }
            if (SuccesEmailCheckLabel.Visible == true && SuccesFirstNameCheckLabel.Visible == true && SuccesLastNameCheckLabel.Visible == true && SuccesPassWordCheckLabel.Visible == true && SuccesPhoneCheckLabel.Visible == true && SuccesStreetCheckLabel.Visible == true && SuccesUserNameCheckLabel.Visible == true && SuccesVerifyPassWordCheckLabel.Visible == true )
           {
                VipCustomer vip = new VipCustomer();
                vip.FirstName = textBox1.Text;
                vip.LastName = textBox2.Text;
                vip.UserName = RegisterUserName1TextBox.Text;
                vip.PassWord = RegisterPassWord1TextBox.Text;
                vip.Email = RegisterEmail1TextBox.Text + "@" + RegisterEmail1ComboBox.Text;
                vip.Address = RegisterStreet1TextBox.Text;
                vip.PhoneNumber = RegisterPhone1ComboBox.Text + RegisterPhone1TextBox.Text;
                vip.userType = "Vipuser";

                XmlParser.XmlParserVipCustomer(vip);

                MessageBox.Show("Successfully Registered", "WOOHOO");

                this.Close();

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
