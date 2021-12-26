using System.Data.SqlClient;

namespace PizzaDelivery.DAL
{
    class Connection
    {
        public SqlConnection connect = 
            new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vadims.sirics\source\repos\PizzaDelivery\PizzaDelivery\pizza.mdf;Integrated Security=True");
    }
}
