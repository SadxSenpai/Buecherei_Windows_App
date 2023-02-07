using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bücherei_Windows_App.The_Database
{
    // Build Database

    internal class DB
    {
        // Connection
        public MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=lms_db");

        //function to open connection
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        //function to close connection
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // function to return Connection
        public MySqlConnection GetConnection()
        {
            return connection;
        }

    }
}