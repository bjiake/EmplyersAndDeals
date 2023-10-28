using lab1.Entity;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class FormSeeker : Form
    {
        public FormSeeker()
        {
            InitializeComponent();
        }

        private void FormSeeker_Load(object sender, EventArgs e)
        {

        }

        private void tbQualification_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbEstimatedSalary.Text == "" || tbFirstName.Text == "" || tbLastName.Text == "" || tbMiddleName.Text == "" || tbOtherData.Text == "" || tbQualification.Text == "" || tbTypeOfActivity.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            Seeker seeker = new Seeker();
            seeker.lastName = tbLastName.Text;
            seeker.firstName = tbFirstName.Text;
            seeker.middleName = tbMiddleName.Text;

            try
            {
                seeker.estimatedSalary = Convert.ToDouble(tbEstimatedSalary.Text);
            } catch {
                MessageBox.Show("Введите корректные данные в ожидаемой з.п");
                return;
            }

            seeker.otherData = tbOtherData.Text;
            seeker.qualification = tbQualification.Text;
            seeker.typeOfActivity = tbTypeOfActivity.Text;

            DataBase.DataBase dataBase = new DataBase.DataBase();
            dataBase.ConnectionDataBase();

            // Create Employers table
            var cmd = new NpgsqlCommand();
            cmd.Connection = dataBase.NpgsqlConnection;

            cmd.CommandText = @"SELECT SeekerID FROM Seekers WHERE LastName = @LastName AND FirstName = @FirstName AND MiddleName = @MiddleName;";
            cmd.Parameters.AddWithValue("LastName", tbLastName.Text);
            cmd.Parameters.AddWithValue("FirstName", tbFirstName.Text);
            cmd.Parameters.AddWithValue("MiddleName", tbMiddleName.Text);
            var result = cmd.ExecuteScalar();

            if (result != null) // Existing record found
            {
                // Update the existing record
                cmd.CommandText = @"UPDATE Seekers SET Qualification = @Qualification, Activity = @Activity, OtherInfo = @OtherInfo, ExpectedSalary = @ExpectedSalary WHERE SeekerID = @SeekerID;";
                cmd.Parameters.AddWithValue("Qualification", tbQualification.Text);
                cmd.Parameters.AddWithValue("Activity", tbTypeOfActivity.Text);
                cmd.Parameters.AddWithValue("OtherInfo", tbOtherData.Text);
                cmd.Parameters.AddWithValue("ExpectedSalary", Convert.ToDouble(tbEstimatedSalary.Text));
                cmd.Parameters.AddWithValue("SeekerID", result);
                cmd.ExecuteNonQuery();
            }
            else // No existing record found
            {
                // Insert data into Seekers table
                cmd.CommandText = @"INSERT INTO Seekers (LastName, FirstName, MiddleName, Qualification, Activity, OtherInfo, ExpectedSalary) 
                        VALUES (@LastName, @FirstName, @MiddleName, @Qualification, @Activity, @OtherInfo, @ExpectedSalary);";
                cmd.Parameters.AddWithValue("LastName", tbLastName.Text);
                cmd.Parameters.AddWithValue("FirstName", tbFirstName.Text);
                cmd.Parameters.AddWithValue("MiddleName", tbMiddleName.Text);
                cmd.Parameters.AddWithValue("Qualification", tbQualification.Text);
                cmd.Parameters.AddWithValue("Activity", tbTypeOfActivity.Text);
                cmd.Parameters.AddWithValue("OtherInfo", tbOtherData.Text);
                cmd.Parameters.AddWithValue("ExpectedSalary", Convert.ToDouble(tbEstimatedSalary.Text));
                cmd.ExecuteNonQuery();
            }

            dataBase.CloseConnectionDataBase();
        }
    }
}
