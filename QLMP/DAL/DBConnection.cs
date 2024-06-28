using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class DBConnection
    {
        public static string host = "";
        public static int port = 1521;
        public static string sid = "";
        public static string user = "";
        public static string password = "";

        public string connectionSTR = @"Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;
        public static OracleConnection conn = null;
        public void Moketnoi()
        {
            if (conn == null)
                conn = new OracleConnection(connectionSTR);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public  void dongketnoi() {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
