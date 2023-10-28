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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            DataBase.DataBase dataBase = new DataBase.DataBase();
            dataBase.ConnectionDataBase();

            // Create Employers table
            var cmd = new NpgsqlCommand();
            cmd.Connection = dataBase.NpgsqlConnection;

            cmd.CommandText = @"INSERT INTO Deals (EmployerID, SeekerID, Commission) 
                    SELECT e.EmployerID, s.SeekerID, s.ExpectedSalary * 0.15 FROM Employers e, Seekers s 
                    WHERE e.Activity = s.Activity;
                    DELETE FROM Deals WHERE DealID NOT IN (SELECT MIN(DealID) FROM Deals GROUP BY EmployerID, SeekerID);
                    SELECT SUM(Commission) FROM Deals;";
            var sum = cmd.ExecuteScalar();

            // Show message box with sum of commissions
            if (sum == null )
            {
                MessageBox.Show("Не найдено ни одной сделки");
            } else
            {
                MessageBox.Show("Сумма всех коммиссионных: " + sum.ToString());
            }

            dataBase.CloseConnectionDataBase();
        }

        private void btEmployer_Click(object sender, EventArgs e)
        {
            FormAdmin_Employer formAdmin_Employer = new FormAdmin_Employer();
            formAdmin_Employer.ShowDialog();
        }

        private void btSeeker_Click(object sender, EventArgs e)
        {
            FormAdmin_Seeker formAdmin_Seeker = new FormAdmin_Seeker();
            formAdmin_Seeker.ShowDialog();
        }

        private void btDeals_Click(object sender, EventArgs e)
        {
            FormAdmin_Deals formAdmin_Deals = new FormAdmin_Deals();
            formAdmin_Deals.ShowDialog();
        }
    }
}
