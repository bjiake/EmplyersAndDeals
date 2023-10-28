using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class FormAdmin_Employer : Form
    {
        public FormAdmin_Employer()
        {
            InitializeComponent();
        }

        private void FormAdmin_Employer_Load(object sender, EventArgs e)
        {
            DataBase.DataBase dataBase = new DataBase.DataBase();
            dataGridView1.DataSource = dataBase.Reader("Employers");
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
