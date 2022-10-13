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
    public partial class FormPermission : Form
    {
        public FormPermission()
        {
            InitializeComponent();
        }

        private void btnPerNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNewPermission FrmNewPer = new FormNewPermission();
            FrmNewPer.ShowDialog();
            this.Visible = true;
            FillAllData();
            CleanFilters();
        }

        private void btnPerUpd_Click(object sender, EventArgs e)
        {

            if (detail.PermissionID == 0)
                MessageBox.Show("Please select a permission from table");
            else {
                FormNewPermission frmNewPer = new FormNewPermission();
                frmNewPer.isUpdate = true;
                frmNewPer.detail = detail;
                this.Hide();
                frmNewPer.ShowDialog();
                this.Visible = true;
                FillAllData();
                CleanFilters();
            }
        }

        private void btnPerClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        PermissionDTO dto = new PermissionDTO();
        private bool combofull;

        void FillAllData()
        {
            dto = PermissionBLL.GetALL();
            dataGridView1.DataSource = dto.Permission;
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
            cmbState.DataSource = dto.States;
            cmbState.DisplayMember = "MonthName";
            cmbState.ValueMember = "ID";
            cmbState.SelectedIndex = -1;
        }

       


        private void FormPermission_Load(object sender, EventArgs e)
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
            dataGridView1.Columns[8].HeaderText = "Start Date";
            dataGridView1.Columns[9].HeaderText = "End Date";
            dataGridView1.Columns[10].HeaderText = "Day Amount";
            dataGridView1.Columns[11].HeaderText = "State";
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;


        }

        private void btnPerClean_Click(object sender, EventArgs e)
        {
            CleanFilters();
        }

        private void CleanFilters()
        {
            txtPerUser.Clear();
            txtPerName.Clear();
            txtPerSurname.Clear();
            combofull = false;
            cmbDept.SelectedIndex = -1;
            cmbPos.DataSource = dto.Positions;
            cmbPos.SelectedIndex = -1;
            combofull = true;
            rbEndDate.Checked = false;
            rbTaskStart.Checked = false;
            txtPerDay.Clear();
            cmbState.SelectedIndex = -1;
            txtPerDay.Clear();
            dataGridView1.DataSource = dto.Permission;
        }

        private void btnPerSearch_Click(object sender, EventArgs e)
        {
            List<PermissionDetailDTO> list = dto.Permission;
            if (txtPerUser.Text.Trim() != "")
                list = list.Where(x => x.UserNo == Convert.ToInt32(txtPerUser.Text)).ToList();
            if (txtPerName.Text.Trim() != "")
                list = list.Where(x => x.Name.Contains(txtPerName.Text)).ToList();
            if (txtPerSurname.Text.Trim() != "")
                list = list.Where(x => x.Surname.Contains(txtPerSurname.Text)).ToList();
            if (cmbDept.SelectedIndex != -1)
                list = list.Where(x => x.DepartmentID == Convert.ToInt32(cmbDept.SelectedValue)).ToList();
            if (cmbPos.SelectedIndex != -1)
                list = list.Where(x => x.PositionID == Convert.ToInt32(cmbPos.SelectedValue)).ToList();
            if (txtPerDay.Text.Trim() != "")
                list = list.Where(x => x.PermissionDayAmount == Convert.ToInt32(txtPerDay.Text)).ToList();
            if (cmbState.SelectedIndex != -1)
                list = list.Where(x => x.State == Convert.ToInt32(cmbState.SelectedValue)).ToList();
            if (rbTaskStart.Checked)
                list = list.Where(x => x.StartDate < Convert.ToDateTime(dpEnd.Value) && x.StartDate > Convert.ToDateTime(dpStart.Value)).ToList();
            else if (rbEndDate.Checked)
                list = list.Where(x => x.EndDate < Convert.ToDateTime(dpEnd.Value) && x.EndDate > Convert.ToDateTime(dpStart.Value)).ToList();



            dataGridView1.DataSource = list;
        }

        PermissionDetailDTO detail = new PermissionDetailDTO();
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.PermissionID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[14].Value);
            detail.StartDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
            detail.EndDate = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
            detail.Explanation = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            detail.UserNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            detail.State = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
            detail.PermissionDayAmount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
        }

        private void btnPerApp_Click(object sender, EventArgs e)
        {
            PermissionBLL.UpdatePermission(detail.PermissionID,PermissionStateDTO.Approved);
            MessageBox.Show("Approved");
            FillAllData();
            CleanFilters();
        }

        private void btnPerDisapp_Click(object sender, EventArgs e)
        {
            PermissionBLL.UpdatePermission(detail.PermissionID, PermissionStateDTO.Disapproved);
            MessageBox.Show("Disapproved");
            FillAllData();
            CleanFilters();
        }
    }
}
