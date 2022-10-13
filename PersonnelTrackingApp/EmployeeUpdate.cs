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
using System.IO;

namespace PersonnelTrackingApp
{
    public partial class EmployeeUpdate : Form
    {
        public EmployeeUpdate()
        {
            InitializeComponent();
        }
        EmployeeDTO dto = new EmployeeDTO();
        public EmployeeDetailDTO detail = new EmployeeDetailDTO();
        public bool isUpdate = false;
        string imagepath = "";
        private void EmployeeUpdate_Load(object sender, EventArgs e)
        {
            dto = EmployeeBLL.GetALL();
            cmbDepartment.DataSource = dto.Departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbPosition.DataSource = dto.Positions;
            cmbPosition.DisplayMember = "PositionName";
            cmbPosition.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            combofull = true;
            {
                txtName.Text = detail.Name;
                txtSurname.Text = detail.Surname;
                txtUserNo.Text = detail.UserNo.ToString();
                txtPassword.Text = detail.Password;
                chisAdmin.Checked = Convert.ToBoolean(detail.isAdmin);
                txtAddress.Text = detail.Address;
                dateTimePicker2.Value = Convert.ToDateTime(detail.BirthDay);
                cmbDepartment.SelectedValue = detail.DepartmentID;
                cmbPosition.SelectedValue = detail.PositionID;
                txtSalary.Text = detail.Salary.ToString();
                imagepath = Application.StartupPath + "\\images\\" + detail.ImagePath;
                txtImagePath.Text = imagepath;
                pictureBox1.ImageLocation = imagepath;
            }
            
        }
        bool combofull = false;
        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combofull)
            {
                int departmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                cmbPosition.DataSource = dto.Positions.Where(x => x.DepartmentID == departmentID).ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string fileName = "";




        private void cbNewAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
        bool isUnique = false;

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnNewCheck_Click_1(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "")
            {
                MessageBox.Show("User No. is Empty");
            }
            else
            {
                isUnique = EmployeeBLL.isUnique(Convert.ToInt32(txtUserNo.Text));
                if (!isUnique)
                    MessageBox.Show("This user no. is used by another employee please change");
                else
                    MessageBox.Show("This user no. is usuable");
            }

        }

        private void btnNewBrowse_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                txtImagePath.Text = openFileDialog1.FileName;
                string Unique = Guid.NewGuid().ToString();
                fileName += Unique + openFileDialog1.SafeFileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!EmployeeBLL.isUnique(Convert.ToInt32(txtUserNo.Text)))
                MessageBox.Show("This user no. is used by another employee please change");
            else if (txtPassword.Text.Trim() == "")
                MessageBox.Show("Password is Empty");
            else if (txtName.Text.Trim() == "")
                MessageBox.Show("Name is Empty");
            else if (txtSurname.Text.Trim() == "")
                MessageBox.Show("Surname is Empty");
            else if (txtSalary.Text.Trim() == "")
                MessageBox.Show("Salary is Empty");
            else if (cmbDepartment.SelectedIndex == -1)
                MessageBox.Show("Select a department");
            else if (cmbPosition.SelectedIndex == -1)
                MessageBox.Show("Select a position");
            else
            {

                if(!isUpdate)
                {
                    if (txtName.Text.Trim() == "")
                        MessageBox.Show("User no is Empty");
                    else
                    {
                        DAL.Employee employee = new DAL.Employee();
                        employee.UserNo = Convert.ToInt32(txtUserNo.Text);
                        employee.Password = txtPassword.Text;
                        employee.isAdmin = chisAdmin.Checked;
                        employee.Name = txtName.Text;
                        employee.Surname = txtSurname.Text;
                        employee.Salary = Convert.ToInt32(txtSalary.Text);
                        employee.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                        employee.PositionID = Convert.ToInt32(cmbPosition.SelectedValue);
                        employee.Address = txtAddress.Text;
                        employee.BirthDay = dateTimePicker2.Value;
                        employee.ImagePath = fileName;
                        EmployeeBLL.AddEmployee(employee);
                        File.Copy(txtImagePath.Text, @"images\\" + fileName);
                        MessageBox.Show("Employee was added");
                        txtUserNo.Clear();
                        txtPassword.Clear();
                        chisAdmin.Checked = false;
                        txtName.Clear();
                        txtSurname.Clear();
                        txtSalary.Clear();
                        txtAddress.Clear();
                        txtImagePath.Clear();
                        pictureBox1.Image = null;
                        combofull = false;
                        cmbDepartment.SelectedIndex = -1;
                        cmbPosition.DataSource = dto.Positions;
                        cmbPosition.SelectedIndex = -1;
                        combofull = true;
                        dateTimePicker2.Value = DateTime.Today;
                    }
                }
                else
                {
                //    //DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
                //    //if(result==DialogResult.Yes)
                //    //{
                //    //    Employee employee = new Employee();
                //    //    if(txtImagePath.Text != imagepath)
                //    //    {
                //    //        if (File.Exists(@"images\\" + detail.ImagePath))
                //    //            File.Delete(@"images\\" + detail.ImagePath);
                //    //        File.Copy(txtImagePath.Text, @"images\\" + fileName);
                //    //        employee.ImagePath = fileName;
                //    //    }
                //    //    else

                //}
            }

            }
        }
     }
}
