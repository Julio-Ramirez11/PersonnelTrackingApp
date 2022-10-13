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
using DAL.DTO;
//using DAL;


namespace PersonnelTrackingApp
{
    public partial class NewTask : Form
    {
        public NewTask()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        TaskDTO dto = new TaskDTO();
        private bool combofull = false;
        public bool isUpdate = false;
        public TaskDetailDTO detail = new TaskDetailDTO();

        private void NewTask_Load(object sender, EventArgs e)
        {
            label8.Visible = false;
            cmbTaskState.Visible = false;
            dto = TaskBLL.GetAll();
            dataGridView1.DataSource = dto.Employees;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "User No";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Surname";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
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
            combofull = true;
            cmbTaskState.DataSource = dto.TaskStates;
            cmbTaskState.DisplayMember = "Statement";
            cmbTaskState.ValueMember = "ID";
            cmbTaskState.SelectedIndex = -1;
            if(isUpdate)
            {
                label8.Visible = true;
                cmbTaskState.Visible = true;
                txtName.Text = detail.Name;
                txtUserNo.Text = detail.UserNo.ToString();
                txtSurname.Text = detail.Surname;
                txtTitle.Text = detail.Title;
                txtContent.Text = detail.Content;
                cmbTaskState.DataSource = dto.TaskStates;
                cmbTaskState.DisplayMember = "StateName";
                cmbTaskState.ValueMember = "ID";
                cmbTaskState.SelectedValue = detail.TaskStateID; 
            }



        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                cmbPos.DataSource = dto.Positions.Where(x => x.DepartmentID == Convert.ToInt32(cmbDept.SelectedValue)).ToList();
                List<EmployeeDetailDTO> list = dto.Employees;
                dataGridView1.DataSource = list.Where(x => x.DepartmentID == Convert.ToInt32(cmbDept.SelectedValue)).ToList();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtUserNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            task.EmployeeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            
        }

        private void cmbPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                
                List<EmployeeDetailDTO> list = dto.Employees;
                dataGridView1.DataSource = list.Where(x => x.PositionID == Convert.ToInt32(cmbPos.SelectedValue)).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        DAL.Task task = new DAL.Task();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (task.EmployeeID == 0)
                MessageBox.Show("Please select an employee on table");
            else if (txtTitle.Text.Trim() == "")
                MessageBox.Show("Task Title is empty");
            else if (txtContent.Text.Trim() == "")
                MessageBox.Show("Content is empty");
            else
            {
                if (!isUpdate)
                {
                    task.TaskTitle = txtTitle.Text;
                    task.TaskContent = txtContent.Text;
                    task.TaskStartDate = DateTime.Today;
                    task.TaskStae = 1;
                    TaskBLL.AddTask(task);
                    MessageBox.Show("Task was added");
                    txtTitle.Clear();
                    txtContent.Clear();
                    task = new DAL.Task();
                }
                else if(isUpdate)
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Warning!!", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                    {
                        DAL.Task update = new DAL.Task();
                        update.ID = detail.TaskID;
                        if (Convert.ToInt32(txtUserNo.Text) != detail.UserNo)
                            update.EmployeeID = task.EmployeeID;
                        else
                            update.EmployeeID = detail.EmployeeID;
                        update.TaskTitle = txtTitle.Text;
                        update.TaskContent = txtContent.Text;
                        update.TaskStae = Convert.ToInt32(cmbTaskState.SelectedValue);
                        TaskBLL.UpdateTask(update);
                        MessageBox.Show("Task was Update");
                        this.Close();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
