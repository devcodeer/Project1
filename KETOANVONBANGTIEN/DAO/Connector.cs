using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAO
{
    public class Connector
    {
        public static SqlConnection getConnection()
        {
            string connectionString = "Data Source=(local);Initial Catalog=KTVBT;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
