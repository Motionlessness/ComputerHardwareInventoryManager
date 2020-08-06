using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerHardwareInventoryManager.DB_Classes
{
    class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookRegistration;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return connection;
        }
    }
}
