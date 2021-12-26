using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "admin")
            {
                AdminMenuForm form = new AdminMenuForm();
                form.Show();

                Close();
            }
            else
                MessageBox.Show("Incorrect password");
        }
    }
}
