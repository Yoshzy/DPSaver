using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DP_Saver.Data
{
    internal class Dbc
    {
        public MySqlConnection conn;
        private string UlString = "datasource=127.0.0.1;port=3306;database=dps;username=root;password=;SslMode=none;Allow User Variables=True";

       public Dbc()
        {
            conn = new MySqlConnection(UlString);
        }

        public MySqlConnection GetConn()
        {
            return conn;
        }
    }
}
