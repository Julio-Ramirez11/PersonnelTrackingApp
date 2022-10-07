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
    
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == Convert.ToString("1") && txtPassword.Text == "admin")
            {
                this.Hide();
                FormTracking frmTrack = new FormTracking();
                frmTrack.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Wrong User or Password", "INVALID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = general.isNumber(e);
        }
    }
}
