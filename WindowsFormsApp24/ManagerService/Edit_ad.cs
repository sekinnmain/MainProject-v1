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
    public partial class Edit_ad : Form
    {
        Advertisement myAdToEdit;
        public Edit_ad()
        {
            
            InitializeComponent();
        }
        
        public void loadValuesItemToEdit()
        {
            //textBox1EditAdName.Text = main_manager_wnd.
        }
        private void Button2EditAdCreate_Click(object sender, EventArgs e)
        {
           
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
            textBox1EditAdName.Text = main_manager_wnd.AdSelectedToEdit;
        }
    }
}
