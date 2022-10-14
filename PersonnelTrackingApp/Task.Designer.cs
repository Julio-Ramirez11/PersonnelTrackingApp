
namespace PersonnelTrackingApp
{
    partial class Task
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTaskUser = new System.Windows.Forms.TextBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtTaskSur = new System.Windows.Forms.TextBox();
            this.dpTaskStart = new System.Windows.Forms.DateTimePicker();
            this.dpTaskFinish = new System.Windows.Forms.DateTimePicker();
            this.cmbTaskState = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTaskDeliver = new System.Windows.Forms.RadioButton();
            this.rbTaskStart = new System.Windows.Forms.RadioButton();
            this.btnTaskSearch = new System.Windows.Forms.Button();
            this.btnTaskClean = new System.Windows.Forms.Button();
            this.btnTaskExport = new System.Windows.Forms.Button();
            this.btnTaskNew = new System.Windows.Forms.Button();
            this.btnTaskDel = new System.Windows.Forms.Button();
            this.btnTaskClose = new System.Windows.Forms.Button();
            this.btnTaskApp = new System.Windows.Forms.Button();
            this.btnTaskUpd = new System.Windows.Forms.Button();
            this.pnlForAdmin = new System.Windows.Forms.Panel();
            this.cmbPos = new System.Windows.Forms.ComboBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.pnlForAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "User No ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(418, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Start";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(418, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Finish";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(399, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Task Date";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(399, 154);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Task State";
            // 
            // txtTaskUser
            // 
            this.txtTaskUser.Location = new System.Drawing.Point(171, 31);
            this.txtTaskUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaskUser.Name = "txtTaskUser";
            this.txtTaskUser.Size = new System.Drawing.Size(148, 26);
            this.txtTaskUser.TabIndex = 1;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(171, 77);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(148, 26);
            this.txtTaskName.TabIndex = 1;
            // 
            // txtTaskSur
            // 
            this.txtTaskSur.Location = new System.Drawing.Point(171, 125);
            this.txtTaskSur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaskSur.Name = "txtTaskSur";
            this.txtTaskSur.Size = new System.Drawing.Size(148, 26);
            this.txtTaskSur.TabIndex = 1;
            // 
            // dpTaskStart
            // 
            this.dpTaskStart.Location = new System.Drawing.Point(519, 58);
            this.dpTaskStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpTaskStart.Name = "dpTaskStart";
            this.dpTaskStart.Size = new System.Drawing.Size(180, 26);
            this.dpTaskStart.TabIndex = 2;
            // 
            // dpTaskFinish
            // 
            this.dpTaskFinish.Location = new System.Drawing.Point(519, 103);
            this.dpTaskFinish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpTaskFinish.Name = "dpTaskFinish";
            this.dpTaskFinish.Size = new System.Drawing.Size(180, 26);
            this.dpTaskFinish.TabIndex = 2;
            // 
            // cmbTaskState
            // 
            this.cmbTaskState.FormattingEnabled = true;
            this.cmbTaskState.Location = new System.Drawing.Point(519, 152);
            this.cmbTaskState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTaskState.Name = "cmbTaskState";
            this.cmbTaskState.Size = new System.Drawing.Size(180, 28);
            this.cmbTaskState.TabIndex = 3;
            this.cmbTaskState.SelectedIndexChanged += new System.EventHandler(this.cbTaskState_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTaskDeliver);
            this.groupBox1.Controls.Add(this.rbTaskStart);
            this.groupBox1.Location = new System.Drawing.Point(759, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(170, 109);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rbTaskDeliver
            // 
            this.rbTaskDeliver.AutoSize = true;
            this.rbTaskDeliver.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTaskDeliver.Location = new System.Drawing.Point(21, 65);
            this.rbTaskDeliver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTaskDeliver.Name = "rbTaskDeliver";
            this.rbTaskDeliver.Size = new System.Drawing.Size(128, 35);
            this.rbTaskDeliver.TabIndex = 1;
            this.rbTaskDeliver.TabStop = true;
            this.rbTaskDeliver.Text = "Delivery";
            this.rbTaskDeliver.UseVisualStyleBackColor = true;
            this.rbTaskDeliver.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbTaskStart
            // 
            this.rbTaskStart.AutoSize = true;
            this.rbTaskStart.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTaskStart.Location = new System.Drawing.Point(21, 29);
            this.rbTaskStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTaskStart.Name = "rbTaskStart";
            this.rbTaskStart.Size = new System.Drawing.Size(134, 32);
            this.rbTaskStart.TabIndex = 0;
            this.rbTaskStart.TabStop = true;
            this.rbTaskStart.Text = "Start Date";
            this.rbTaskStart.UseVisualStyleBackColor = true;
            // 
            // btnTaskSearch
            // 
            this.btnTaskSearch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskSearch.Location = new System.Drawing.Point(774, 143);
            this.btnTaskSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaskSearch.Name = "btnTaskSearch";
            this.btnTaskSearch.Size = new System.Drawing.Size(117, 42);
            this.btnTaskSearch.TabIndex = 5;
            this.btnTaskSearch.Text = "Search";
            this.btnTaskSearch.UseVisualStyleBackColor = true;
            this.btnTaskSearch.Click += new System.EventHandler(this.btnTaskSearch_Click);
            // 
            // btnTaskClean
            // 
            this.btnTaskClean.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskClean.Location = new System.Drawing.Point(774, 194);
            this.btnTaskClean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaskClean.Name = "btnTaskClean";
            this.btnTaskClean.Size = new System.Drawing.Size(117, 37);
            this.btnTaskClean.TabIndex = 5;
            this.btnTaskClean.Text = "Clean";
            this.btnTaskClean.UseVisualStyleBackColor = true;
            this.btnTaskClean.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTaskExport
            // 
            this.btnTaskExport.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskExport.Location = new System.Drawing.Point(774, 240);
            this.btnTaskExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaskExport.Name = "btnTaskExport";
            this.btnTaskExport.Size = new System.Drawing.Size(117, 37);
            this.btnTaskExport.TabIndex = 5;
            this.btnTaskExport.Text = "Export";
            this.btnTaskExport.UseVisualStyleBackColor = true;
            // 
            // btnTaskNew
            // 
            this.btnTaskNew.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskNew.Location = new System.Drawing.Point(266, 591);
            this.btnTaskNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaskNew.Name = "btnTaskNew";
            this.btnTaskNew.Size = new System.Drawing.Size(130, 55);
            this.btnTaskNew.TabIndex = 5;
            this.btnTaskNew.Text = "New";
            this.btnTaskNew.UseVisualStyleBackColor = true;
            this.btnTaskNew.Click += new System.EventHandler(this.btnTaskNew_Click);
            // 
            // btnTaskDel
            // 
            this.btnTaskDel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskDel.Location = new System.Drawing.Point(544, 591);
            this.btnTaskDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaskDel.Name = "btnTaskDel";
            this.btnTaskDel.Size = new System.Drawing.Size(130, 55);
            this.btnTaskDel.TabIndex = 5;
            this.btnTaskDel.Text = "Delete";
            this.btnTaskDel.UseVisualStyleBackColor = true;
            this.btnTaskDel.Click += new System.EventHandler(this.btnTaskDel_Click);
            // 
            // btnTaskClose
            // 
            this.btnTaskClose.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskClose.Location = new System.Drawing.Point(684, 591);
            this.btnTaskClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaskClose.Name = "btnTaskClose";
            this.btnTaskClose.Size = new System.Drawing.Size(130, 55);
            this.btnTaskClose.TabIndex = 5;
            this.btnTaskClose.Text = "Close";
            this.btnTaskClose.UseVisualStyleBackColor = true;
            this.btnTaskClose.Click += new System.EventHandler(this.btnTaskClose_Click);
            // 
            // btnTaskApp
            // 
            this.btnTaskApp.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskApp.Location = new System.Drawing.Point(126, 591);
            this.btnTaskApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaskApp.Name = "btnTaskApp";
            this.btnTaskApp.Size = new System.Drawing.Size(130, 55);
            this.btnTaskApp.TabIndex = 5;
            this.btnTaskApp.Text = "Approve";
            this.btnTaskApp.UseVisualStyleBackColor = true;
            // 
            // btnTaskUpd
            // 
            this.btnTaskUpd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskUpd.Location = new System.Drawing.Point(405, 591);
            this.btnTaskUpd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaskUpd.Name = "btnTaskUpd";
            this.btnTaskUpd.Size = new System.Drawing.Size(130, 55);
            this.btnTaskUpd.TabIndex = 5;
            this.btnTaskUpd.Text = "Update";
            this.btnTaskUpd.UseVisualStyleBackColor = true;
            this.btnTaskUpd.Click += new System.EventHandler(this.btnTaskUpd_Click);
            // 
            // pnlForAdmin
            // 
            this.pnlForAdmin.Controls.Add(this.cmbPos);
            this.pnlForAdmin.Controls.Add(this.cmbDept);
            this.pnlForAdmin.Controls.Add(this.txtTaskName);
            this.pnlForAdmin.Controls.Add(this.txtTaskSur);
            this.pnlForAdmin.Controls.Add(this.txtTaskUser);
            this.pnlForAdmin.Controls.Add(this.label5);
            this.pnlForAdmin.Controls.Add(this.label4);
            this.pnlForAdmin.Controls.Add(this.label3);
            this.pnlForAdmin.Controls.Add(this.label2);
            this.pnlForAdmin.Controls.Add(this.label1);
            this.pnlForAdmin.Location = new System.Drawing.Point(2, 3);
            this.pnlForAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlForAdmin.Name = "pnlForAdmin";
            this.pnlForAdmin.Size = new System.Drawing.Size(360, 297);
            this.pnlForAdmin.TabIndex = 7;
            // 
            // cmbPos
            // 
            this.cmbPos.FormattingEnabled = true;
            this.cmbPos.Location = new System.Drawing.Point(171, 221);
            this.cmbPos.Name = "cmbPos";
            this.cmbPos.Size = new System.Drawing.Size(148, 28);
            this.cmbPos.TabIndex = 3;
            this.cmbPos.SelectedIndexChanged += new System.EventHandler(this.cmbPos_SelectedIndexChanged);
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(171, 174);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(148, 28);
            this.cmbDept.TabIndex = 2;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.cmbDept_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 665);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 317);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(927, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 665);
            this.Controls.Add(this.pnlForAdmin);
            this.Controls.Add(this.btnTaskExport);
            this.Controls.Add(this.btnTaskClean);
            this.Controls.Add(this.btnTaskUpd);
            this.Controls.Add(this.btnTaskApp);
            this.Controls.Add(this.btnTaskClose);
            this.Controls.Add(this.btnTaskDel);
            this.Controls.Add(this.btnTaskNew);
            this.Controls.Add(this.btnTaskSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbTaskState);
            this.Controls.Add(this.dpTaskFinish);
            this.Controls.Add(this.dpTaskStart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Task";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task";
            this.Load += new System.EventHandler(this.Task_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlForAdmin.ResumeLayout(false);
            this.pnlForAdmin.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTaskUser;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.TextBox txtTaskSur;
        private System.Windows.Forms.DateTimePicker dpTaskStart;
        private System.Windows.Forms.DateTimePicker dpTaskFinish;
        private System.Windows.Forms.ComboBox cmbTaskState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTaskDeliver;
        private System.Windows.Forms.RadioButton rbTaskStart;
        private System.Windows.Forms.Button btnTaskSearch;
        private System.Windows.Forms.Button btnTaskClean;
        private System.Windows.Forms.Button btnTaskExport;
        private System.Windows.Forms.Button btnTaskNew;
        private System.Windows.Forms.Button btnTaskDel;
        private System.Windows.Forms.Button btnTaskClose;
        private System.Windows.Forms.Button btnTaskApp;
        private System.Windows.Forms.Button btnTaskUpd;
        private System.Windows.Forms.Panel pnlForAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbPos;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}