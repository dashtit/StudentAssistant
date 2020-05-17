using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentAssistant
{
    class Connection
    {
        private static string connectionString = @"Data Source=DESKTOP-R7UA68L;Initial Catalog=TimeManager;Integrated Security=True;MultipleActiveResultSets=True";
        private static readonly Connection instance = new Connection();
        private SqlConnection connection;


        private Connection()
        {
            connection = new SqlConnection(connectionString);
        }

        public static Connection GetInstance() => instance;

        public SqlConnection GetConnection() => connection;

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
