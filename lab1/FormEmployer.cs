using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab1.DataBase;
using Npgsql;

namespace lab1
{
    public partial class FormEmployer : Form
    {
        public FormEmployer()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbAddress.Text == "" || tbNumber.Text == "" || tbTypeOfActivity.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            Employer employer = new Employer();
            employer.name = tbName.Text;
            employer.addres = tbAddress.Text;
            employer.number = tbNumber.Text;
            employer.typeOfActivity = tbTypeOfActivity.Text;

            DataBase.DataBase dataBase = new DataBase.DataBase();
            dataBase.ConnectionDataBase();

            // Create Employers table
            var cmd = new NpgsqlCommand();
            cmd.Connection = dataBase.NpgsqlConnection;

            cmd.CommandText = @"SELECT EmployerID FROM Employers WHERE Name = @Name AND Activity = @Activity;";
            cmd.Parameters.AddWithValue("Name", tbName.Text);
            cmd.Parameters.AddWithValue("Activity", tbTypeOfActivity.Text);
            var result = cmd.ExecuteScalar();

            if (result != null) // Existing record found
            {
                // Update the existing record
                cmd.CommandText = @"UPDATE Employers SET Address = @Address, Phone = @Phone WHERE EmployerID = @EmployerID;";
                cmd.Parameters.AddWithValue("Address", tbAddress.Text);
                cmd.Parameters.AddWithValue("Phone", tbNumber.Text);
                cmd.Parameters.AddWithValue("EmployerID", result);
                cmd.ExecuteNonQuery();
            }
            else // No existing record found
            {
                // Insert data into Employers table
                cmd.CommandText = @"INSERT INTO Employers (Name, Activity, Address, Phone) 
                        VALUES (@Name, @Activity, @Address, @Phone);";
                cmd.Parameters.AddWithValue("Name", tbName.Text);
                cmd.Parameters.AddWithValue("Activity", tbTypeOfActivity.Text);
                cmd.Parameters.AddWithValue("Address", tbAddress.Text);
                cmd.Parameters.AddWithValue("Phone", tbNumber.Text);
                cmd.ExecuteNonQuery();
            }

            // Close connection
            dataBase.CloseConnectionDataBase();
        }
    }
}
