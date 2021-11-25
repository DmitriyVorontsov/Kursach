using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string login = LogInnTextBox.Text;
            string password = LogPasswordTextBox.Text;

            if (InputAnalysis.CheckLogin(login) && InputAnalysis.CheckPassword(password))
            {
                /*
                DataBase DB = new DataBase();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `userdata` WHERE `INN` = @L AND `Password` = @P", DB.GetConnector());
                command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@P", MySqlDbType.VarChar).Value = password;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                */

                DataTable table = DataBaseRequest.AskForData("SELECT * FROM `userdata` WHERE `INN` = @P0 AND `Password` = @P1", login, password);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Авторизован");
                }
                else
                    MessageBox.Show("Неверные данные");
                
            }
        }
    }
}
