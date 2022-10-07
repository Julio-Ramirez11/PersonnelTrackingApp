
namespace PersonnelTrackingApp
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpUserNo = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpSurname = new System.Windows.Forms.TextBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.cmbPos = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEmpExport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEmpNew = new System.Windows.Forms.Button();
            this.btnEmpUpd = new System.Windows.Forms.Button();
            this.btnEmpDel = new System.Windows.Forms.Button();
            this.btnEmpClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User No. :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name : ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname : ";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Department : ";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Position : ";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmpUserNo
            // 
            this.txtEmpUserNo.Location = new System.Drawing.Point(128, 27);
            this.txtEmpUserNo.Name = "txtEmpUserNo";
            this.txtEmpUserNo.Size = new System.Drawing.Size(100, 27);
            this.txtEmpUserNo.TabIndex = 1;
            this.txtEmpUserNo.TextChanged += new System.EventHandler(this.txtEmpUserNo_TextChanged);
            this.txtEmpUserNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpUserNo_KeyPress);
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(128, 69);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 27);
            this.txtEmpName.TabIndex = 2;
            // 
            // txtEmpSurname
            // 
            this.txtEmpSurname.Location = new System.Drawing.Point(128, 111);
            this.txtEmpSurname.Name = "txtEmpSurname";
            this.txtEmpSurname.Size = new System.Drawing.Size(100, 27);
            this.txtEmpSurname.TabIndex = 3;
            this.txtEmpSurname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cmbDept
            // 
            this.cmbDept.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "Department 1",
            "Department 2 ",
            "Department 3 ",
            "Department 4",
            "Department 5",
            "Department 6",
            "Department 7 ",
            "Department 8 ",
            "Department 9",
            "Department 10"});
            this.cmbDept.Location = new System.Drawing.Point(393, 26);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(113, 28);
            this.cmbDept.TabIndex = 4;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbPos
            // 
            this.cmbPos.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPos.FormattingEnabled = true;
            this.cmbPos.Items.AddRange(new object[] {
            "Position 1",
            "Position 2",
            "Position 3",
            "Position 4",
            "Position 5"});
            this.cmbPos.Location = new System.Drawing.Point(393, 73);
            this.cmbPos.Name = "cmbPos";
            this.cmbPos.Size = new System.Drawing.Size(113, 28);
            this.cmbPos.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(534, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEmpExport
            // 
            this.btnEmpExport.Location = new System.Drawing.Point(534, 106);
            this.btnEmpExport.Name = "btnEmpExport";
            this.btnEmpExport.Size = new System.Drawing.Size(90, 40);
            this.btnEmpExport.TabIndex = 6;
            this.btnEmpExport.Text = "Export";
            this.btnEmpExport.UseVisualStyleBackColor = true;
            this.btnEmpExport.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 177);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEmpNew
            // 
            this.btnEmpNew.Location = new System.Drawing.Point(121, 380);
            this.btnEmpNew.Name = "btnEmpNew";
            this.btnEmpNew.Size = new System.Drawing.Size(90, 40);
            this.btnEmpNew.TabIndex = 6;
            this.btnEmpNew.Text = "New";
            this.btnEmpNew.UseVisualStyleBackColor = true;
            this.btnEmpNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmpUpd
            // 
            this.btnEmpUpd.Location = new System.Drawing.Point(217, 380);
            this.btnEmpUpd.Name = "btnEmpUpd";
            this.btnEmpUpd.Size = new System.Drawing.Size(90, 40);
            this.btnEmpUpd.TabIndex = 6;
            this.btnEmpUpd.Text = "Update";
            this.btnEmpUpd.UseVisualStyleBackColor = true;
            this.btnEmpUpd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmpDel
            // 
            this.btnEmpDel.Location = new System.Drawing.Point(313, 380);
            this.btnEmpDel.Name = "btnEmpDel";
            this.btnEmpDel.Size = new System.Drawing.Size(90, 40);
            this.btnEmpDel.TabIndex = 6;
            this.btnEmpDel.Text = "Delete";
            this.btnEmpDel.UseVisualStyleBackColor = true;
            this.btnEmpDel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmpClose
            // 
            this.btnEmpClose.Location = new System.Drawing.Point(409, 380);
            this.btnEmpClose.Name = "btnEmpClose";
            this.btnEmpClose.Size = new System.Drawing.Size(90, 40);
            this.btnEmpClose.TabIndex = 6;
            this.btnEmpClose.Text = "Close";
            this.btnEmpClose.UseVisualStyleBackColor = true;
            this.btnEmpClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 432);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEmpExport);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEmpClose);
            this.Controls.Add(this.btnEmpDel);
            this.Controls.Add(this.btnEmpUpd);
            this.Controls.Add(this.btnEmpNew);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbPos);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.txtEmpSurname);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpUserNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Form";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmpUserNo;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpSurname;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.ComboBox cmbPos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEmpExport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEmpNew;
        private System.Windows.Forms.Button btnEmpUpd;
        private System.Windows.Forms.Button btnEmpDel;
        private System.Windows.Forms.Button btnEmpClose;
    }
}