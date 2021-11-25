using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal static class DataBaseRequest
    {
        /// <summary>
        /// Выполняет команду и возвращает данные в виде DataTable
        /// </summary>
        /// <param name="commandStr">
        /// Командная строка, в которой аргументы обозначаются как @P0, @P1 и т.д.
        /// </param>
        /// <param name="args">
        /// Последовательность строковых значений соответствующих аргументов
        /// </param>
        /// <returns></returns>
        public static DataTable AskForData(string commandStr, params string[] args)
        {
            DataBaseInit DB = new DataBaseInit();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(commandStr, DB.GetConnector());
            for (int i = 0; i< args.Length; i++)
                command.Parameters.Add("@P" + i.ToString(), MySqlDbType.VarChar).Value = args[i];
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
    }
}
