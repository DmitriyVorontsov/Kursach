using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class DataBaseInit
    {
        private MySqlConnection connector = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=users");
        public MySqlConnection GetConnector() {
            return connector;
        }

        public void OpenConnection()
        {
            if (connector.State == System.Data.ConnectionState.Closed)
                connector.Open();
        }

        public void CloseConnection()
        {
            if (connector.State == System.Data.ConnectionState.Open)
                connector.Close();
        }
    }
}
