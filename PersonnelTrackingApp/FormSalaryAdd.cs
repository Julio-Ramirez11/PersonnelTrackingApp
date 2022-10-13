using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using DAL.DTO;
using DAL.DAO;

namespace PersonnelTrackingApp
{
    public partial class FormSalaryAdd : Form
    {
        public FormSalaryAdd()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        SalaryDTO dto = new SalaryDTO();
        DAL.Salary salary = new DAL.Salary();
        private bool combofull = false;
        public SalaryDetailDTO detail = new SalaryDetailDTO();
        public bool isUpdate = false;
        private void FormSalaryAdd_Load(object sender, EventArgs e)
        {
            dto = SalaryBLL.GetAll();
            if(!isUpdate)
            {
                dataGridView1.DataSource = dto.Employees;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "User No";
                dataGridView1.Columns[2].HeaderText = "Name";
                dataGridView1.Columns[3].HeaderText = "Surname";
                dataGridView1.Columns[4].HeaderText = "Start Date";
                dataGridView1.Columns[5].HeaderText = "Delivery Date";
                dataGridView1.Columns[6].HeaderText = "Task State";
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
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
                if (dto.Departments.Count > 0)
                    combofull = true;
            }
            cmbMonth.DataSource = dto.Months;
            cmbMonth.DisplayMember = "MonthName";
            cmbMonth.ValueMember = "ID";
            cmbMonth.SelectedIndex = -1;
            

                
        }

     

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             if (cmbMonth.SelectedIndex == -1)
                MessageBox.Show("Please select month");
            else if (txtSalary.Text.Trim() == "")
                MessageBox.Show("Please fill the salary");
            else if (txtUserNo.Text == "")
                MessageBox.Show("Please select an employee from table");
            else
            {
                bool control = false;
                if (!isUpdate)
                {
                    if (txtYear.Text.Trim() == "")
                        MessageBox.Show("Please fill the year");
                    else
                    {
                        salary.Year = Convert.ToInt32(txtYear.Text);
                        salary.MonthId = Convert.ToInt32(cmbMonth.SelectedValue);
                        salary.Amount = Convert.ToInt32(txtSalary.Text);
                        if (salary.Amount > oldsalary)
                            control = true;
                        SalaryBLL.AddSalary(salary,control);
                        MessageBox.Show("Salary was added");
                        cmbMonth.SelectedIndex = -1;
                        salary = new Salary();
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "title", MessageBoxButtons.YesNo);
                    if(DialogResult.Yes== result)
                    {
                        Salary salary = new Salary();
                        salary.ID = detail.SalaryID;
                        salary.EmployeeID = detail.EmployeeID;
                        salary.Year = Convert.ToInt32(txtYear.Text);
                        salary.MonthId = Convert.ToInt32(cmbMonth.SelectedValue);
                        salary.Amount = Convert.ToInt32(txtSalary.Text);
                        
                        if (salary.Amount > detail.OldSalary)
                            control = true;
                        SalaryBLL.UpdateSalary(salary, control);
                        MessageBox.Show("Salary was updated");
                        this.Close(); 
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowErrorTextChanged(object sender, DataGridViewRowEventArgs e)
        {

        }
        int oldsalary = 0;
        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            txtUserNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSalary.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtYear.Text = DateTime.Today.Year.ToString();
            salary.EmployeeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            oldsalary = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
