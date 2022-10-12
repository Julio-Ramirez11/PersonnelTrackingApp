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

namespace PersonnelTrackingApp
{
    public partial class FormNewPermission : Form
    {
        public FormNewPermission()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TimeSpan PermissionDay;
        private void FormNewPermission_Load(object sender, EventArgs e)
        {
            txtUserNo.Text = UserStatic.UserNo.ToString();
        }

        private void dpStart_ValueChanged(object sender, EventArgs e)
        {
            PermissionDay = dpEnd.Value.Date - dpStart.Value.Date;
            txtAmount.Text = PermissionDay.TotalDays.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text.Trim() == "")
                MessageBox.Show("Please change end or start date");
            else if (Convert.ToInt32(txtAmount.Text) <= 0)
                MessageBox.Show("Permission day must be bigger than 0");
            else if (txtExplanation.Text.Trim() == "")
                MessageBox.Show("Explanation is empty");
            else
            {
                Permission permission = new Permission();
                permission.EmployeeID = UserStatic.EmployeeID;
                permission.PermissionState = 1;
                permission.PermissionStartDate = dpStart.Value.Date;
                permission.PermissionEndDate = dpEnd.Value.Date;
                permission.PermissionDay = Convert.ToInt32(txtAmount.Text);
                permission.PermissionExplanation = txtExplanation.Text;
                PermissionBLL.AddPermission(permission);
                MessageBox.Show("Permission was added");
                permission = new Permission();
                dpStart.Value = DateTime.Today;
                dpEnd.Value = DateTime.Today;
                txtAmount.Clear();
                txtExplanation.Clear();
            }
        }

        private void dpEnd_ValueChanged(object sender, EventArgs e)
        {
            PermissionDay = dpEnd.Value.Date - dpStart.Value.Date;
            txtAmount.Text = PermissionDay.TotalDays.ToString();
        }
    }
}
