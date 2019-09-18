using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CoffeShop : Form
    {
        
        public CoffeShop()
        {
            InitializeComponent();
        }

        private void CoffeShop_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            List<string> names = new List<string> { };
            names.Add(customernameTextBox.Text);
            names.Add(contactTextBox.Text);
            names.Add(addressTextBox.Text);
            names.Add(orderComboBox.Text);
            names.Add(quantityTextBox.Text);
           
            string message = "";
            foreach (string name in names)
            {
                message += "Name" + name + " +contact" +address+" +Totalbill"+"\n";
            }
            MessageBox.Show(message);
        }

        private void showbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
