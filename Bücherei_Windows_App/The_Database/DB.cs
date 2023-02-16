using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bücherei_Windows_App.The_Database
{
    // Build Database

    public class DBCon
    {
        //edit the constring for all con calls
        public static string dbConnection = "server=localhost;uid=root;pwd=;database=lms_db";
    }
}