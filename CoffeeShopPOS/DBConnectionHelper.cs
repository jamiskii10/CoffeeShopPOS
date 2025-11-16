using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopPOS
{
    public static class DbConnectionHelper
    {
        private static readonly string connectionString =
            "Data Source=LAPTOP-NI3QOG5B\\SQLEXPRESS;Initial Catalog=CoffeeShop;Integrated Security=True;Encrypt=False";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
