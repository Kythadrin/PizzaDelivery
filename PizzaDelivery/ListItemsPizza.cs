using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class ListItemsPizza : UserControl
    {
        public ListItemsPizza()
        {
            InitializeComponent();
        }

        private Image _icon;
        private string _pizzaName;
        private string _price;

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBoxImage.Image = value; }
        }

        public string PizzaName
        {
            get { return _pizzaName; }
            set { _pizzaName = value; labelName.Text = value; }
        }

        public string Price
        {
            get { return _price; }
            set { _price = value; labelPrice.Text = value; }
        }

        public string Qty
        {
            get { return textBoxQty.Text; }
            set { textBoxQty.Text = value; }
        }

        public bool Check
        {
            get { return checkBox.Checked; }
            set { checkBox.Checked = value; }
        }

        public RadioButton GetSize()
        {
            return panelSize.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
        }

        public RadioButton GetCrust()
        {
            return panelCrust.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
        }

        private void textBoxQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }
    }
}
