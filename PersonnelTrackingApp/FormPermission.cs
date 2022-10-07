using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
