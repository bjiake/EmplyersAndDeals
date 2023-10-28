using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1.DataBase
{
    internal class DataBase
    {
        public NpgsqlConnection NpgsqlConnection { get; set; }
        public void ConnectionDataBase()
        {
            // Connection string
            var connString = "Server=localhost;Port=5432;Username=postgres;Password=internet1;Database=postgres;";

            // Create connection
            NpgsqlConnection = new NpgsqlConnection(connString);
            NpgsqlConnection.Open();
        }
        public DataTable Reader(string nameTable)
        {
            DataBase dataBase = new DataBase();
            dataBase.ConnectionDataBase();

            // Create Employers table
            var cmd = new NpgsqlCommand();
            cmd.Connection = dataBase.NpgsqlConnection;

            string query = "SELECT * FROM " + nameTable + ";";
            NpgsqlCommand command = new NpgsqlCommand(query, dataBase.NpgsqlConnection);
            NpgsqlDataReader reader = command.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(reader);

            reader.Close();
            dataBase.CloseConnectionDataBase();
            return data;
        }
        public void CloseConnectionDataBase()
        {
            NpgsqlConnection.Close();
        }
    }
}
