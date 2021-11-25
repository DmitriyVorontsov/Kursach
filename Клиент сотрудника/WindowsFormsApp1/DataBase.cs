using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DataBase
    {
        MySqlConnection connector = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=");
    }
}
