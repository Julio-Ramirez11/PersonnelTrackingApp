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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeUpdate frmEmpUpd = new EmployeeUpdate();
            frmEmpUpd.ShowDialog();
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
    }
}
