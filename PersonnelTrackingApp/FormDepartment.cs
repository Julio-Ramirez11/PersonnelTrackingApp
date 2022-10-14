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

namespace PersonnelTrackingApp
{
    public partial class FormDepartment : Form
    {
        public FormDepartment()
        {
            InitializeComponent();
        }


        public bool isUpdate = false;
        public DAL.Department detail = new DAL.Department();
        private void FormDepartment_Load(object sender, EventArgs e)
        {
            if (isUpdate)
                txtDept.Text = detail.DepartmentName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDepartmentList frmDept = new FormDepartmentList();
            frmDept.ShowDialog();
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtDept.Text.Trim() == "")
                MessageBox.Show("Please Fill the name field");
            else
            {
                Department department = new Department();
                if(!isUpdate)
                {
                    department.DepartmentName = txtDept.Text;
                    BLL.DepartmentBLL.AddDepartment(department);
                    MessageBox.Show("Department was added!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDept.Clear();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo);
                    if(DialogResult.Yes==result)
                    {
                        department.ID = detail.ID;
                        department.DepartmentName = txtDept.Text;
                        DepartmentBLL.UpdateDepartment(department);
                        MessageBox.Show("Department was updated");
                        this.Close();
                    }
                }
            }

        }

        private void txtDept_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
