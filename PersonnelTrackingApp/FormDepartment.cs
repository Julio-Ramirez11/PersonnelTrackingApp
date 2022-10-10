using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PersonnelTrackingApp
{
    public partial class FormDepartment : Form
    {
        public FormDepartment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDept.Text.Trim() == "")
                MessageBox.Show("Please Fill the name field");
            else
            {
                Department department = new Department();
                department.DepartmentName = txtDept.Text;
                BLL.DepartmentBLL.AddDepartment(department);
                MessageBox.Show("Department was added!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDept.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDepartmentList frmDept = new FormDepartmentList();
            frmDept.ShowDialog();
        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {

        }
    }
}
