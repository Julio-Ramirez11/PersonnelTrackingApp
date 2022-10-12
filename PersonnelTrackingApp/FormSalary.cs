using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DTO;
using BLL;
using DAL;


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
            if (combofull)
            {
                cmbPos.DataSource = dto.Positions.Where(x => x.DepartmentID == Convert.ToInt32(cmbDept.SelectedValue)).ToList();
            }
        }

        private void btnSalNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSalaryAdd FrmNewSalary = new FormSalaryAdd();
            FrmNewSalary.ShowDialog();
            this.Visible = true;
            FillAllData();
            CleanFilters();
        }

        private void btnSalClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SalaryDTO dto = new SalaryDTO();
        private bool combofull;
        void FillAllData()
        {
            dto = SalaryBLL.GetAll();
            dataGridView1.DataSource = dto.Salaries;
            combofull = false;
            cmbDept.DataSource = dto.Departments;
            cmbDept.DisplayMember = "DepartmentName";
            cmbDept.ValueMember = "ID";
            if (dto.Departments.Count > 0)
                combofull = true;
            cmbPos.DataSource = dto.Positions;
            cmbPos.DisplayMember = "PositionName";
            cmbPos.ValueMember = "ID";
            cmbDept.SelectedIndex = -1;
            cmbPos.SelectedIndex = -1;
            cmbMonth.DataSource = dto.Months;
            cmbMonth.DisplayMember = "MonthName";
            cmbMonth.ValueMember = "ID";
            cmbMonth.SelectedIndex = -1;
        }
        private void FormSalary_Load(object sender, EventArgs e)
        {
            FillAllData();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Surname";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "Month";
            dataGridView1.Columns[9].HeaderText = "Year";
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].HeaderText = "Salary";
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalSearch_Click(object sender, EventArgs e)
        {
            List<SalaryDetailDTO> list = dto.Salaries;
            if (txtSalUser.Text.Trim() != "")
                list = list.Where(x => x.UserNo == Convert.ToInt32(txtSalUser.Text)).ToList();
            if (txtSalName.Text.Trim() != "")
                list = list.Where(x => x.Name.Contains(txtSalName.Text)).ToList();
            if (txtSalSurname.Text.Trim() != "")
                list = list.Where(x => x.Surname.Contains(txtSalSurname.Text)).ToList();
            if (cmbDept.SelectedIndex != -1)
                list = list.Where(x => x.DepartmentID == Convert.ToInt32(cmbDept.SelectedValue)).ToList();
            if (cmbPos.SelectedIndex != -1)
                list = list.Where(x => x.PositionID == Convert.ToInt32(cmbPos.SelectedValue)).ToList();
            if (txtSalYear.Text.Trim() != "")
                list = list.Where(x => x.SalaryYear == Convert.ToInt32(txtSalYear.Text)).ToList();
            if (cmbMonth.SelectedIndex != -1)
                list = list.Where(x => x.MonthID == Convert.ToInt32(cmbMonth.SelectedValue)).ToList();
            if(txtSalary.Text.Trim() != "")
            {
                if (rbMore.Checked)
                    list = list.Where(x => x.SalaryAmount > Convert.ToInt32(txtSalary.Text)).ToList();
                else if (rbLess.Checked)
                    list = list.Where(x => x.SalaryAmount < Convert.ToInt32(txtSalary.Text)).ToList();
                else
                    list = list.Where(x => x.SalaryAmount == Convert.ToInt32(txtSalary.Text)).ToList();
            }
            dataGridView1.DataSource = list;

        }

        private void btnSalClear_Click(object sender, EventArgs e)
        {
            CleanFilters();
        }

        private void CleanFilters()
        {
            txtSalUser.Clear();
            txtSalName.Clear();
            txtSalSurname.Clear();
            combofull = false;
            cmbDept.SelectedIndex = -1;
            cmbPos.DataSource = dto.Positions;
            cmbPos.SelectedIndex = -1;
            combofull = true;
            cmbMonth.SelectedIndex = -1;
            rbLess.Checked = false;
            rbMore.Checked = false;
            rbEqual.Checked = false;
            txtSalYear.Clear();
            txtSalary.Clear();
            dataGridView1.DataSource = dto.Salaries;
        }

        private void cmbPos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
