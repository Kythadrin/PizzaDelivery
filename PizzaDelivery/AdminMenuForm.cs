using System;
using System.Drawing;
using System.Windows.Forms;
using PizzaDelivery.BLL;

namespace PizzaDelivery
{
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if(opendlg.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(opendlg.FileName);
                pictureBoxPizzaImage.Image = image;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ClassBLL objbll = new ClassBLL();

            if (textBoxPizzaName.Text != null && textBoxPizzaPrice != null && pictureBoxPizzaImage.Image != null)
            {
                if (objbll.SavePizza(textBoxPizzaName.Text, textBoxPizzaPrice.Text, pictureBoxPizzaImage.Image))
                {
                    MessageBox.Show("Success!");
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
            else
                MessageBox.Show("Fill all fields!");
        }

        private void AdminMenuForm_Load(object sender, EventArgs e)
        {
            ordersTableAdapter.Fill(pizzaDataSet.orders);
            dataGridViewOrdersList.ClearSelection();
        }

        private void dataGridViewOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            listViewOrder.Items.Clear();

            DataGridViewRow row = dataGridViewOrdersList.Rows[e.RowIndex];

            byte[] bytes = (byte[])row.Cells[1].Value;

            string order = System.Text.Encoding.Default.GetString(bytes);
            order = order.Replace("\r\n", string.Empty);

            string[] rows = order.Split(';');
            string[,] grid = new string[3, rows.Length];
            
            for(int y = 0; y < rows.Length; y++)
            {
                string[] cells = rows[y].Split(':');

                for (int x = 0; x < cells.Length; x++)
                    grid[x, y] = cells[x];
            }

            for (int y = 0; y < rows.Length; y++)
            {
                ListViewItem item = new ListViewItem(grid[0, y]);
                item.SubItems.Add(grid[1, y]);
                item.SubItems.Add(grid[2, y]);
                listViewOrder.Items.Add(item);
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            dataGridViewOrdersList.Update();
            dataGridViewOrdersList.Refresh();
        }
    }
}
