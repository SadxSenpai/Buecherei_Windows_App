using System;
using System.Collections.Generic;
using System.Data;
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

        // Funktion für "Return Table Data"
        // parameters = the parameters of the query
        public DataTable getData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            return table;
        }

        // Funktion um Daten festzulegen und des ausführen der Query
        public void setData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            cmd.ExecuteNonQuery();
        }

    }
}