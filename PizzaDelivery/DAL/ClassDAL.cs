using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows;

namespace PizzaDelivery.DAL
{
    class ClassDAL
    {
        public bool AddPizzaToTable(string name, string price, Image image)
        {
            Connection con = new Connection();
            if(ConnectionState.Closed == con.connect.State)
                con.connect.Open();

            string query = "INSERT INTO pizza_list (name, price, image) VALUES (@name, @price, @image)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@name", name.Trim());
                    cmd.Parameters.AddWithValue("@price", price.Trim());

                    MemoryStream ms = new MemoryStream();
                    image.Save(ms, image.RawFormat);
                    cmd.Parameters.AddWithValue("@image", ms.ToArray());

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch
            {
                throw;
            }
        }

        public DataTable ReadPizzaTable()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
                con.connect.Open();

            string query = "SELECT * FROM pizza_list";
            SqlCommand cmd = new SqlCommand(query, con.connect);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }

        public bool AddOrderToTable(string[] order, string amount, string date, string name, string address, string phone, string email, 
            string paymentMethod, string cardNr)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
                con.connect.Open();

            string query = "INSERT INTO orders ([order], amount, date, name, address, phone, email, payment_method, card_nr) " +
                "VALUES (@order, @amount, @date, @name, @address, @phone, @email, @payment_method, @card_nr)";

            string filePath = @"C:\oreder.txt";
            try
            {   
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
   
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    foreach (string line in order)
                        sw.WriteLine(line);
                }
            }
            catch
            {
                MessageBox.Show("Can't create text file with order");
            }

            try
            {
                using (Stream stream = File.OpenRead(filePath))
                {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);

                    using (SqlCommand cmd = new SqlCommand(query, con.connect))
                    {
                        cmd.Parameters.Add("@order", SqlDbType.VarBinary).Value = buffer;
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@payment_method", paymentMethod);
                        cmd.Parameters.AddWithValue("@card_nr", cardNr);

                        cmd.ExecuteNonQuery();
                    }
                }

                File.Delete(filePath);

                return true;
            }
            catch
            {
                File.Delete(filePath);
                throw;
            }
        }

        public DataTable ReadOrdersTable()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
                con.connect.Open();

            string query = "SELECT * FROM orders";
            SqlCommand cmd = new SqlCommand(query, con.connect);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}