using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PizzaDelivery.BLL;

namespace PizzaDelivery
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams CP = base.CreateParams;
                CP.ExStyle = CP.ExStyle | 0x02000000; 
                return CP;
            }
        }

        public void GenerateDynamicUserControl()
        {
            flowLayoutPanelPizzaList.Controls.Clear();

            ClassBLL objbll = new ClassBLL();

            DataTable dt = objbll.GetPizza();

            if(dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    ListItemsPizza[] listItems = new ListItemsPizza[dt.Rows.Count];

                    for(int i = 0; i < 1; i++)
                    {
                        foreach(DataRow row in dt.Rows)
                        {
                            listItems[i] = new ListItemsPizza();

                            MemoryStream ms = new MemoryStream((byte[])row["image"]);
                            listItems[i].Icon = new Bitmap(ms);

                            listItems[i].PizzaName = row["name"].ToString();
                            listItems[i].Price = row["price"].ToString();

                            flowLayoutPanelPizzaList.Controls.Add(listItems[i]);
                        }
                    }
                }
            }
        }

        private void buttonConfirmOrder_Click(object sender, EventArgs e)
        {
            if (checkBoxCoke.Checked == true && textBoxCokeQty.Text == "" ||
                checkBoxDietCoke.Checked == true && textBoxDietCokeQty.Text == "" ||
                checkBoxIcedTea.Checked == true && textBoxIcedTeaQty.Text == "" ||
                checkBoxGingerAle.Checked == true && textBoxGingerAleQty.Text == "" ||
                checkBoxSprite.Checked == true && textBoxSpriteQty.Text == "" ||
                checkBoxRootBeer.Checked == true && textBoxRootBeerQty.Text == "" ||
                checkBoxWater.Checked == true && textBoxWaterQty.Text == "")
                MessageBox.Show("Enter drink quantity!");
            else
            {
                foreach (ListItemsPizza control in flowLayoutPanelPizzaList.Controls)
                {
                    if (control.Check)
                    {
                        RadioButton rb = control.GetSize();
                        string size = rb.Text.Substring(0, 2);
                        string sizePrice = rb.Text.Substring(5, 4);

                        rb = control.GetCrust();
                        string crust = rb.Text + " crust";

                        ListViewItem item = new ListViewItem(crust + " " + size + "cm " + control.PizzaName + " Pizza");
                        item.SubItems.Add(control.Qty);
                        double price = Convert.ToInt32(control.Qty) * (Convert.ToDouble(sizePrice) + Convert.ToDouble(control.Price));
                        item.SubItems.Add(price.ToString("F"));
                        listViewOrderList.Items.Add(item);
                    }
                }

                //Drink Selection
                if (checkBoxCoke.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Coke - Can");
                    item.SubItems.Add(textBoxCokeQty.Text);
                    int qty = Convert.ToInt32(textBoxCokeQty.Text);
                    double cost = qty * 1.45;
                    string dCost = cost.ToString();
                    item.SubItems.Add(dCost);
                    listViewOrderList.Items.Add(item);
                }

                else textBoxCokeQty.Text = "";

                if (checkBoxDietCoke.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Diet Coke - Can");
                    item.SubItems.Add(textBoxDietCokeQty.Text);
                    int qty = Convert.ToInt32(textBoxDietCokeQty.Text);
                    double cost = qty * 1.45;
                    string dCost = cost.ToString();
                    item.SubItems.Add(dCost);
                    listViewOrderList.Items.Add(item);
                }

                else textBoxDietCokeQty.Text = "";

                if (checkBoxIcedTea.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Iced Tea - Can");
                    item.SubItems.Add(textBoxIcedTeaQty.Text);
                    int qty = Convert.ToInt32(textBoxIcedTeaQty.Text);
                    double cost = qty * 1.45;
                    string dCost = cost.ToString();
                    item.SubItems.Add(dCost);
                    listViewOrderList.Items.Add(item);
                }

                else textBoxIcedTeaQty.Text = "";

                if (checkBoxGingerAle.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Ginger Ale - Can");
                    item.SubItems.Add(textBoxGingerAleQty.Text);
                    int qty = Convert.ToInt32(textBoxGingerAleQty.Text);
                    double cost = qty * 1.45;
                    string dCost = cost.ToString();
                    item.SubItems.Add(dCost);
                    listViewOrderList.Items.Add(item);
                }

                else textBoxGingerAleQty.Text = "";

                if (checkBoxSprite.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sprite - Can");
                    item.SubItems.Add(textBoxSpriteQty.Text);
                    int qty = Convert.ToInt32(textBoxSpriteQty.Text);
                    double cost = qty * 1.45;
                    string dCost = cost.ToString();
                    item.SubItems.Add(dCost);
                    listViewOrderList.Items.Add(item);
                }

                else textBoxSpriteQty.Text = "";

                if (checkBoxRootBeer.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Root Beer - Can");
                    item.SubItems.Add(textBoxRootBeerQty.Text);
                    int qty = Convert.ToInt32(textBoxRootBeerQty.Text);
                    double cost = qty * 1.45;
                    string dCost = cost.ToString();
                    item.SubItems.Add(dCost);
                    listViewOrderList.Items.Add(item);
                }

                else textBoxRootBeerQty.Text = "";

                if (checkBoxWater.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Bottled Water");
                    item.SubItems.Add(textBoxWaterQty.Text);
                    int qty = Convert.ToInt32(textBoxWaterQty.Text);
                    double cost = qty * 1.25;
                    string dCost = cost.ToString();
                    item.SubItems.Add(dCost);
                    listViewOrderList.Items.Add(item);
                }

                else textBoxWaterQty.Text = "";

                //Other Items Selection
                if (checkBoxChickenWings.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Chicken Wings");
                    item.SubItems.Add("1");
                    item.SubItems.Add("3,00");
                    listViewOrderList.Items.Add(item);
                }

                if (checkBoxPoutine.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Poutine");
                    item.SubItems.Add("1");
                    item.SubItems.Add("3,00");
                    listViewOrderList.Items.Add(item);
                }

                if (checkBoxOnionRings.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Onion Rings");
                    item.SubItems.Add("1");
                    item.SubItems.Add("3,00");
                    listViewOrderList.Items.Add(item);
                }

                if (checkBoxCheesyGarlicBread.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Garlic Bread");
                    item.SubItems.Add("1");
                    item.SubItems.Add("3,00");
                    listViewOrderList.Items.Add(item);
                }

                if (checkBoxGarlicDip.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Garlic Dip");
                    item.SubItems.Add("1");
                    item.SubItems.Add("0,00");
                    listViewOrderList.Items.Add(item);
                }

                if (checkBoxBBQDip.Checked == true)
                {
                    ListViewItem item = new ListViewItem("BBQ Dip");
                    item.SubItems.Add("1");
                    item.SubItems.Add("0,00");
                    listViewOrderList.Items.Add(item);
                }

                if (checkBoxSourCreamDip.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Sour Cream Dip");
                    item.SubItems.Add("1");
                    item.SubItems.Add("0,00");
                    listViewOrderList.Items.Add(item);
                }


                double total = 0;
                foreach (ListViewItem item in listViewOrderList.Items)
                    total += Convert.ToDouble(item.SubItems[2].Text);

                double pvn = total * 0.22;
                double totaldue = pvn + total;
                string pvnDisplay = pvn.ToString("c2");
                string totalDisplay = totaldue.ToString("c2");
                string amountDisplay = total.ToString("c2");

                textBoxAmountBeforeTaxes.Text = amountDisplay;
                textBoxPVN.Text = pvnDisplay;
                textBoxTotalAmount.Text = totalDisplay;

                foreach (UserControl ctrl in flowLayoutPanelPizzaList.Controls)
                {
                    ResetUserControl(ctrl);
                }

                ResetGroupBox(groupBoxDrinks);
                ResetGroupBox(groupBoxOtherItems);

                tabControl.SelectTab("tabPageConfirmOrder");
            }
        }

        private void buttonOrderAgain_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tabPageSelectYourOrder");
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tabPageMakePayment");
            textBoxAmountDue.Text = textBoxTotalAmount.Text;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AutoScrollPosition = new Point(0, 0);

            GenerateDynamicUserControl();

            textBoxAmountBeforeTaxes.Enabled = false;
            textBoxPVN.Enabled = false;
            textBoxTotalAmount.Enabled = false;
            textBoxAmountDue.Enabled = false;
            textBoxChange.Enabled = false;

            comboBoxPaymentMethod.Items.Add("Cash");
            comboBoxPaymentMethod.Items.Add("Credit Card");
            comboBoxPaymentMethod.Items.Add("Debit Card");
            comboBoxPaymentMethod.Items.Add("Promo Card");

            buttonSubmitOrder.Enabled = false;
        }


        private void textBoxCokeQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxDietCokeQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxIcedTeaQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxGingerAleQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxSpriteQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxRootBeerQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxWaterQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonClearOrder_Click(object sender, EventArgs e)
        {
            listViewOrderList.Items.Clear();
            textBoxAmountBeforeTaxes.Text = "";
            textBoxPVN.Text = "";
            textBoxTotalAmount.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char q = e.KeyChar;
            if (!Char.IsDigit(q) && q != 8 && q != 44)
            {
                e.Handled = true;
            }
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tabPageConfirmOrder");
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "" 
                || textBoxAddress.Text == "" || textBoxPostalCode.Text == "" 
                || textBoxPhoneNr.Text == "" || textBoxEmail.Text == ""
                || textBoxAmountPaid.Text == "" || comboBoxPaymentMethod.Text == "")
                MessageBox.Show("Please fill in required fields");

            else
            {
                string money = textBoxAmountDue.Text;
                string paymoney = money.Substring(0, money.IndexOf(' '));
                double paymentDue = Convert.ToDouble(paymoney);
                double amountPaid = Convert.ToDouble(textBoxAmountPaid.Text);
                double change = amountPaid - paymentDue;
                textBoxChange.Text = change.ToString("c2");

                if (change < 0)
                    MessageBox.Show("Please refill your balance");

                else buttonSubmitOrder.Enabled = true;
            }
        }

        private void buttonSubmitOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Thanks for ordering at Pizza Delivery. Your ordered items will be ready and delivered in 30 minutes. Do you want to order some more?", "Exit", MessageBoxButtons.YesNo);

            string[] order = new string[listViewOrderList.Items.Count];

            for (int i = 0; i < listViewOrderList.Items.Count; i++)
            {
                string row = listViewOrderList.Items[i].Text + ":"
                    + listViewOrderList.Items[i].SubItems[1].Text + ":"
                    + listViewOrderList.Items[i].SubItems[2].Text + ";";


                order[i] = row;
            }

            string amount = textBoxAmountDue.Text;
            string date = DateTime.Now.ToString();
            string name = textBoxFirstName.Text.Trim() + " " + textBoxLastName.Text.Trim();
            string address = textBoxAddress.Text.Trim() + " " + textBoxPostalCode.Text;
            string phone = textBoxPhoneNr.Text;
            string email = textBoxEmail.Text.Trim();
            string payment_method = comboBoxPaymentMethod.Text;
            string card_nr = textBoxCardNr.Text;

            ClassBLL objBLL = new ClassBLL();
            if(objBLL.SaveOrder(order, amount, date, name, address, phone, email, payment_method, card_nr))
            {
                if (dialog == DialogResult.Yes)
                {
                    //Clearing all data
                    foreach(UserControl ctrl in flowLayoutPanelPizzaList.Controls)
                    {
                        ResetUserControl(ctrl);
                    }

                    ResetGroupBox(groupBoxDrinks);
                    ResetGroupBox(groupBoxOtherItems);

                    listViewOrderList.Items.Clear();
                    ResetGroupBox(groupAmount);

                    ResetGroupBox(groupBoxCustomerInfo);
                    ResetGroupBox(groupBoxPaymentInfo);

                    tabControl.SelectTab("tabPageSelectYourOrder");
                }

                else if (dialog == DialogResult.No)
                    Close();
            }
            else
            {
                    MessageBox.Show("Failed upload data to data base!");
            }


        }

        private void comboBoxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPaymentMethod.Text == "Cash")
            {
                textBoxCardNr.Enabled = false;
                textBoxExpirationDate.Enabled = false;
                textBoxCVC.Enabled = false;
            }
            else
            {
                textBoxCardNr.Enabled = true;
                textBoxExpirationDate.Enabled = true;
                textBoxCVC.Enabled = true;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                tabControl.Height = 1790;
                AutoScrollPosition = new Point(0, 0);
            }
            if (tabControl.SelectedIndex == 1)
            {
                tabControl.Height = 1060;
                AutoScrollPosition = new Point(0, 0);
            }
            if (tabControl.SelectedIndex == 2)
            {
                tabControl.Height = 1400;
                AutoScrollPosition = new Point(0, 0);
            }
        }

        private void labelAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLoginForm form = new AdminLoginForm();
            form.Show();
        }

        void ResetUserControl(UserControl userControl)
        {
            foreach (Control ctrl in userControl.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox textBox = (TextBox)ctrl;
                    textBox.Text = "1";
                }
                if (ctrl is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)ctrl;
                    checkBox.Checked = false;
                }
                if(ctrl is Panel)
                {
                    Panel panel = (Panel)ctrl;

                    foreach(Control control in panel.Controls)
                    {
                        int count = 0;

                        if (control is RadioButton)
                        {
                            RadioButton radioButton = (RadioButton)control;

                            count++;
                            if (count == 1)
                                radioButton.Checked = true;
                            else
                                radioButton.Checked = false;
                        }
                    }
                }
            }
        }

        void ResetGroupBox(GroupBox groupBox)
        {
            foreach (Control ctrl in groupBox.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox textBox = (TextBox)ctrl;
                    textBox.Text = null;
                }
                if (ctrl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)ctrl;
                    comboBox.SelectedIndex = -1;
                }
                if (ctrl is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)ctrl;
                    checkBox.Checked = false;
                }
                if (ctrl is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)ctrl;
                    radioButton.Checked = false;
                }
                if (ctrl is MaskedTextBox)
                {
                    MaskedTextBox maskedTextBox = (MaskedTextBox)ctrl;
                    maskedTextBox.Text = null;
                }
            }
        }

        private void MainForm_Enter(object sender, EventArgs e)
        {
             GenerateDynamicUserControl();
        }

        private void maskedTextBox_Enter(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                MaskedTextBox textBox = (MaskedTextBox)sender;
                textBox.Select(0, 0);
            });
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }
    }
}