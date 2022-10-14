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
    public partial class FormTracking : Form
    {
        public FormTracking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();    
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
            this.Visible = true;
        }
        FormLogin frmLogin = new FormLogin();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormTracking_Load(object sender, EventArgs e)
        {
            if(!UserStatic.isAdmin)
            {
                btnDept.Visible = false;
                btnPos.Visible = false;
            }
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            Task frmTaskLisk = new Task();
            this.Hide();
            frmTaskLisk.ShowDialog();
            this.Visible = true;

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            FormSalary frmSalary = new FormSalary();
            frmSalary.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormPermission FrmPermission = new FormPermission();
            FrmPermission.ShowDialog();
            this.Visible = true;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormDepartmentList FrmDept = new FormDepartmentList();
            FrmDept.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPositionList FrmPosList = new FormPositionList();
            FrmPosList.ShowDialog();
            this.Visible = true;
        }
    }
}
