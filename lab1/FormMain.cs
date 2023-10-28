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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (rbEmployer.Checked)
            {
                FormEmployer form = new FormEmployer();
                form.ShowDialog();
            }
            if (rbSeeker.Checked) { 
                FormSeeker form = new FormSeeker();
                form.ShowDialog();
            }
            if (rbAdmin.Checked)
            {
                FormAdmin form = new FormAdmin();
                form.ShowDialog();
            }
        }
    }
}
