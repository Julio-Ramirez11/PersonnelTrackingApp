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
using DAL.DTO;
using BLL;


namespace PersonnelTrackingApp
{
    public partial class Task : Form
    {
        public Task()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CleanFilter();
        }

        private void CleanFilter()
        {
            txtTaskUser.Clear();
            txtTaskName.Clear();
            txtTaskSur.Clear();
            combofull = false;
            cmbDept.SelectedIndex = -1;
            cmbPos.DataSource = dto.Positions;
            cmbPos.SelectedIndex = -1;
            combofull = true;
            rbTaskDeliver.Checked = false;
            rbTaskDeliver.Checked = false;
            cmbTaskState.SelectedIndex = -1;
            dataGridView1.DataSource = dto.Employees;
        }

        private void btnTaskClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTracking frmTracking1 = new FormTracking();
            frmTracking1.ShowDialog();
        }

        private void btnTaskDel_Click(object sender, EventArgs e)
        {

        }

        private void btnTaskNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewTask FrmNewTask = new NewTask();
            FrmNewTask.ShowDialog();
            this.Visible = true;
            FillAllData();
            CleanFilter();
        }

        TaskDTO dto = new TaskDTO();
        private bool combofull = false;
        TaskDetailDTO detail = new TaskDetailDTO();
        void FillAllData()
        {
            dto = TaskBLL.GetAll();
            dataGridView1.DataSource = dto.Tasks;
            combofull = false;
            cmbDept.DataSource = dto.Departments;
            cmbDept.ValueMember = "ID";
            cmbPos.DataSource = dto.Positions;
            cmbPos.DisplayMember = "PositionName";
            cmbPos.ValueMember = "ID";
            cmbDept.SelectedIndex = -1;
            cmbPos.SelectedIndex = -1;
            cmbTaskState.DataSource = dto.TaskStates;
            cmbTaskState.DisplayMember = "StateName";
            cmbTaskState.ValueMember = "ID";
            cmbTaskState.SelectedIndex = -1;
            combofull = true;
        }

   
        private void Task_Load(object sender, EventArgs e)
        {
            FillAllData();
            dataGridView1.Columns[0].HeaderText = "Task Title";
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
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;

            //dataGridView1.Columns[0].Visible = true;
            //dataGridView1.Columns[1].Visible = true;
            //dataGridView1.Columns[2].Visible = true;
            //dataGridView1.Columns[3].Visible = true;
            //dataGridView1.Columns[4].Visible = true;
            //dataGridView1.Columns[5].Visible = true;
            //dataGridView1.Columns[6].Visible = true;
            //dataGridView1.Columns[7].Visible = true;
            //dataGridView1.Columns[8].Visible = true;
            //dataGridView1.Columns[9].Visible = true;
            //dataGridView1.Columns[10].Visible = true;
            //dataGridView1.Columns[11].Visible = true;
            //dataGridView1.Columns[12].Visible = true;
            //dataGridView1.Columns[13].Visible = true;
            //dataGridView1.Columns[14].Visible = true;
            //dataGridView1.Columns[15].Visible = true;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                cmbPos.DataSource = dto.Positions.Where(x => x.DepartmentID == Convert.ToInt32(cmbDept.SelectedValue)).ToList();
              
            }
        }

        private void cbTaskState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbPos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTaskSearch_Click(object sender, EventArgs e)
        {
            List<TaskDetailDTO> list = dto.Tasks;
            if (txtTaskUser.Text.Trim() != "")
                list = list.Where(x => x.UserNo == Convert.ToInt32(txtTaskUser.Text)).ToList();
            if (txtTaskName.Text.Trim() != "")
                list = list.Where(x => x.Name.Contains(txtTaskName.Text)).ToList();
            if (txtTaskSur.Text.Trim() != "")
                list = list.Where(x => x.Surname.Contains(txtTaskSur.Text)).ToList();
            if (cmbDept.SelectedIndex != -1)
                list = list.Where(x => x.DepartmentID == Convert.ToInt32(cmbDept.SelectedValue)).ToList();
            if (cmbPos.SelectedIndex != -1)
                list = list.Where(x => x.PositionID == Convert.ToInt32(cmbPos.SelectedValue)).ToList();
            if (rbTaskStart.Checked)
                list = list.Where(x => x.TaskStartDate > Convert.ToDateTime(dpTaskStart.Value) && x.TaskStartDate < Convert.ToDateTime(dpTaskFinish.Value)).ToList();
            if(rbTaskDeliver.Checked)
                list = list.Where(x => x.TaskDeliveryDate > Convert.ToDateTime(dpTaskStart.Value) && x.TaskDeliveryDate < Convert.ToDateTime(dpTaskFinish.Value)).ToList();
            if (cmbTaskState.SelectedIndex != -1)
                list = list.Where(x => x.TaskStateID == Convert.ToInt32(cmbTaskState.SelectedValue)).ToList();
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.Name = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            detail.Surname = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            detail.Title = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            detail.Content = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            detail.UserNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            detail.TaskStateID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[15].Value);
            detail.TaskID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
            detail.EmployeeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
            detail.TaskStartDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            detail.TaskDeliveryDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value);

        }

        private void btnTaskUpd_Click(object sender, EventArgs e)
        {
            if (detail.TaskID == 0)
                MessageBox.Show("Please select a task on table");
            else
            {
                NewTask frm = new NewTask();
                frm.isUpdate = true;
                frm.detail = detail;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                FillAllData();
                CleanFilter();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
