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
using DAL.DTO;  
namespace PersonnelTrackingApp
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        EmployeeDTO dto = new EmployeeDTO();
        private bool combofull = false;
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            dto = EmployeeBLL.GetALL();
            dataGridView1.DataSource = dto.Employees;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Surname";
            dataGridView1.Columns[4].HeaderText = "Department";
            dataGridView1.Columns[5].HeaderText = "Position";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Salary";
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            combofull = false;
            cmbDept.DataSource = dto.Departments;
            cmbDept.ValueMember = "ID";
            cmbPos.DataSource = dto.Positions;
            cmbPos.DisplayMember = "PositionName";
            cmbPos.ValueMember = "ID";
            cmbDept.SelectedIndex = -1;
            cmbPos.SelectedIndex = -1;
            combofull = true;



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combofull)
            {
                cmbPos.DataSource = dto.Positions.Where(x => x.DepartmentID == Convert.ToInt32(cmbDept.SelectedValue)).ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmpUserNo.Clear();
            txtEmpName.Clear();
            txtEmpSurname.Clear();
            combofull = false;
            cmbDept.SelectedIndex = -1;
            cmbPos.DataSource = dto.Positions;
            cmbPos.SelectedIndex = -1;
            combofull = true;
            dataGridView1.DataSource = dto.Employees;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtEmpUserNo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmpUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeUpdate FrmUpd = new EmployeeUpdate();
            FrmUpd.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormAddNewEmp FrmNewEmp = new FormAddNewEmp();
            FrmNewEmp.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<EmployeeDetailDTO> list = dto.Employees;
            if (txtEmpUserNo.Text.Trim() == "")
                list = list.Where(x => x.UserNo == Convert.ToInt32(txtEmpUserNo.Text)).ToList();
            if (txtEmpName.Text.Trim() == "")
                list = list.Where(x => x.Name.Contains(txtEmpUserNo.Text)).ToList();
            if (txtEmpSurname.Text.Trim() == "")
                list = list.Where(x => x.Surname.Contains(txtEmpSurname.Text)).ToList();
            if (cmbDept.SelectedIndex != -1)
                list = list.Where(x => x.DepartmentID == Convert.ToInt32(cmbDept.SelectedValue)).ToList();
            if (cmbPos.SelectedIndex != -1)
                list = list.Where(x => x.PositionID == Convert.ToInt32(cmbPos.SelectedValue)).ToList();
            dataGridView1.DataSource = list;

        }
    }
}
