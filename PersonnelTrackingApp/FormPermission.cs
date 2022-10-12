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
        }

        private void btnPerUpd_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNewPermission FrmNewPer = new FormNewPermission();
            FrmNewPer.ShowDialog();
            this.Visible = true;
        }

        private void btnPerClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        PermissionDTO dto = new PermissionDTO();
        
        private void FormPermission_Load(object sender, EventArgs e)
        {
            dto = PermissionBLL.GetALL();
        }
    }
}
