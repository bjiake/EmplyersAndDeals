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
    public partial class FormAdmin_Seeker : Form
    {
        public FormAdmin_Seeker()
        {
            InitializeComponent();
        }

        private void FormAdmin_Seeker_Load(object sender, EventArgs e)
        {
            DataBase.DataBase dataBase = new DataBase.DataBase();
            dataGridView1.DataSource = dataBase.Reader("Seekers");
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
