using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PizzaDelivery.DAL;

namespace PizzaDelivery.BLL
{
    class ClassBLL
    {
        public bool SavePizza(string name, string price, Image image)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.AddPizzaToTable(name, price, image);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public DataTable GetPizza()
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.ReadPizzaTable();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public bool SaveOrder(string[] order, string amount, string date, string name, string address, string phone, string email, string paymentMethod, string cardNr)
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.AddOrderToTable(order, amount, date, name, address, phone, email, paymentMethod, cardNr);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public static DataTable GetOrder()
        {
            try
            {
                ClassDAL objdal = new ClassDAL();
                return objdal.ReadOrdersTable();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
    }
}
