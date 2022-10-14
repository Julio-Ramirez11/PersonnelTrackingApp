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
using DAL;

namespace PersonnelTrackingApp
{
    public partial class Position : Form
    {
        public Position()
        {
            InitializeComponent();
        }

        List<Department> departmentlist = new List<Department>();
        public PositionDTO detail = new PositionDTO();
        public bool isUpdate = false;
        private void Position_Load(object sender, EventArgs e)
        {
            departmentlist = DepartmentBLL.GetDepartment();
            cmbDepartment.DataSource = departmentlist;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            if(isUpdate)
            {
                txtPos.Text = detail.PositionName;
                cmbDepartment.SelectedValue = detail.DepartmentID;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPos.Text.Trim() == "")
                MessageBox.Show("Please fill the position name");
            else if (cmbDepartment.SelectedIndex == -1)
                MessageBox.Show("Please select a department");
            else
            {
                if (!isUpdate)
                {
                    DAL.Position position = new DAL.Position();
                    position.PositionName = txtPos.Text;
                    position.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                    BLL.PositionBLL.AddPosition(position);
                    MessageBox.Show("Position was added");
                    txtPos.Clear();
                    cmbDepartment.SelectedIndex = -1;
                }
                else
                {
                    DAL.Position position = new DAL.Position();
                    position.ID = detail.ID;
                    position.PositionName = txtPos.Text;
                    position.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                    bool control = false;
                    if (Convert.ToInt32(cmbDepartment.SelectedValue) != detail.OldDepartmentID)
                        control = true;
                    PositionBLL.UpdatePosition(position, control);
                    MessageBox.Show("Postion was Updated");
                    this.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
