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
    public partial class FormDepartmentList : Form
    {
        public FormDepartmentList()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTracking FrmTrack = new FormTracking();
            FrmTrack.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDepartment FrmDept = new FormDepartment();
            FrmDept.ShowDialog();
            this.Visible = true;
            list = DepartmentBLL.GetDepartment();
            dataGridView1.DataSource = list;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDepartment FrmDept = new FormDepartment();
            FrmDept.ShowDialog();
            this.Visible = true;
        }

        List<Department> list = new List<Department>();
        private void FormDepartmentList_Load(object sender, EventArgs e)
        {
            
            list = DepartmentBLL.GetDepartment();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Department Name";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
