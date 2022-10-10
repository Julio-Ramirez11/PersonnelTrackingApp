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

namespace PersonnelTrackingApp
{
    public partial class FormPositionList : Form
    {
        public FormPositionList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Position FrmPos = new Position();
            FrmPos.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Position FrmPos = new Position();
            FrmPos.ShowDialog();
            this.Visible = true;
            FillGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        List<PositionDTO> positionList = new List<PositionDTO>();

        void FillGrid()
        {
            positionList = PositionBLL.GetPosition();
            dataGridView1.DataSource = positionList;
        }
        private void FormPositionList_Load(object sender, EventArgs e)
        {
            FillGrid();
            positionList = PositionBLL.GetPosition();
            dataGridView1.DataSource = positionList;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Department Name";
            dataGridView1.Columns[2].HeaderText = "Position Name ";
        }
    }
}
