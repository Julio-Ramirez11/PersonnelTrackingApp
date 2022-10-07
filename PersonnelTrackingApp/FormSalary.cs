using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonnelTrackingApp
{
    public partial class FormSalary : Form
    {
        public FormSalary()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSalaryAdd FrmNewSalary = new FormSalaryAdd();
            FrmNewSalary.ShowDialog();
            this.Visible = true;
        }
    }
}
