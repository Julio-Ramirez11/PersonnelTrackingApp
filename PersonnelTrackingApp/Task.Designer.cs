
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
            this.txtTaskDept = new System.Windows.Forms.TextBox();
            this.txtTaskPos = new System.Windows.Forms.TextBox();
            this.dtTaskStart = new System.Windows.Forms.DateTimePicker();
            this.dtTaskFinish = new System.Windows.Forms.DateTimePicker();
            this.cbTaskState = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTaskDeliver = new System.Windows.Forms.RadioButton();
            this.rbTaskStart = new System.Windows.Forms.RadioButton();
            this.btnTaskSearch = new System.Windows.Forms.Button();
            this.btnTaskClean = new System.Windows.Forms.Button();
            this.btnTaskExport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTaskNew = new System.Windows.Forms.Button();
            this.btnTaskDel = new System.Windows.Forms.Button();
            this.btnTaskClose = new System.Windows.Forms.Button();
            this.btnTaskApp = new System.Windows.Forms.Button();
            this.btnTaskUpd = new System.Windows.Forms.Button();
            this.pnlForAdmin = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlForAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User No ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Start";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(279, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Finish";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(266, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Task Date";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(266, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Task State";
            // 
            // txtTaskUser
            // 
            this.txtTaskUser.Location = new System.Drawing.Point(114, 20);
            this.txtTaskUser.Name = "txtTaskUser";
            this.txtTaskUser.Size = new System.Drawing.Size(100, 20);
            this.txtTaskUser.TabIndex = 1;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(114, 50);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(100, 20);
            this.txtTaskName.TabIndex = 1;
            // 
            // txtTaskSur
            // 
            this.txtTaskSur.Location = new System.Drawing.Point(114, 81);
            this.txtTaskSur.Name = "txtTaskSur";
            this.txtTaskSur.Size = new System.Drawing.Size(100, 20);
            this.txtTaskSur.TabIndex = 1;
            // 
            // txtTaskDept
            // 
            this.txtTaskDept.Location = new System.Drawing.Point(114, 111);
            this.txtTaskDept.Name = "txtTaskDept";
            this.txtTaskDept.Size = new System.Drawing.Size(100, 20);
            this.txtTaskDept.TabIndex = 1;
            // 
            // txtTaskPos
            // 
            this.txtTaskPos.Location = new System.Drawing.Point(114, 142);
            this.txtTaskPos.Name = "txtTaskPos";
            this.txtTaskPos.Size = new System.Drawing.Size(100, 20);
            this.txtTaskPos.TabIndex = 1;
            // 
            // dtTaskStart
            // 
            this.dtTaskStart.Location = new System.Drawing.Point(346, 38);
            this.dtTaskStart.Name = "dtTaskStart";
            this.dtTaskStart.Size = new System.Drawing.Size(121, 20);
            this.dtTaskStart.TabIndex = 2;
            // 
            // dtTaskFinish
            // 
            this.dtTaskFinish.Location = new System.Drawing.Point(346, 67);
            this.dtTaskFinish.Name = "dtTaskFinish";
            this.dtTaskFinish.Size = new System.Drawing.Size(121, 20);
            this.dtTaskFinish.TabIndex = 2;
            // 
            // cbTaskState
            // 
            this.cbTaskState.FormattingEnabled = true;
            this.cbTaskState.Location = new System.Drawing.Point(346, 99);
            this.cbTaskState.Name = "cbTaskState";
            this.cbTaskState.Size = new System.Drawing.Size(121, 21);
            this.cbTaskState.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTaskDeliver);
            this.groupBox1.Controls.Add(this.rbTaskStart);
            this.groupBox1.Location = new System.Drawing.Point(506, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 71);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rbTaskDeliver
            // 
            this.rbTaskDeliver.AutoSize = true;
            this.rbTaskDeliver.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTaskDeliver.Location = new System.Drawing.Point(14, 42);
            this.rbTaskDeliver.Name = "rbTaskDeliver";
            this.rbTaskDeliver.Size = new System.Drawing.Size(85, 24);
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
            this.rbTaskStart.Location = new System.Drawing.Point(14, 19);
            this.rbTaskStart.Name = "rbTaskStart";
            this.rbTaskStart.Size = new System.Drawing.Size(88, 21);
            this.rbTaskStart.TabIndex = 0;
            this.rbTaskStart.TabStop = true;
            this.rbTaskStart.Text = "Start Date";
            this.rbTaskStart.UseVisualStyleBackColor = true;
            // 
            // btnTaskSearch
            // 
            this.btnTaskSearch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskSearch.Location = new System.Drawing.Point(516, 93);
            this.btnTaskSearch.Name = "btnTaskSearch";
            this.btnTaskSearch.Size = new System.Drawing.Size(78, 27);
            this.btnTaskSearch.TabIndex = 5;
            this.btnTaskSearch.Text = "Search";
            this.btnTaskSearch.UseVisualStyleBackColor = true;
            // 
            // btnTaskClean
            // 
            this.btnTaskClean.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskClean.Location = new System.Drawing.Point(516, 126);
            this.btnTaskClean.Name = "btnTaskClean";
            this.btnTaskClean.Size = new System.Drawing.Size(78, 24);
            this.btnTaskClean.TabIndex = 5;
            this.btnTaskClean.Text = "Clean";
            this.btnTaskClean.UseVisualStyleBackColor = true;
            this.btnTaskClean.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTaskExport
            // 
            this.btnTaskExport.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskExport.Location = new System.Drawing.Point(516, 156);
            this.btnTaskExport.Name = "btnTaskExport";
            this.btnTaskExport.Size = new System.Drawing.Size(78, 24);
            this.btnTaskExport.TabIndex = 5;
            this.btnTaskExport.Text = "Export";
            this.btnTaskExport.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(15, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 183);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Task Title";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "User No";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Surname";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Start Date";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Delivery Date";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Task State";
            this.Column7.Name = "Column7";
            // 
            // btnTaskNew
            // 
            this.btnTaskNew.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskNew.Location = new System.Drawing.Point(177, 384);
            this.btnTaskNew.Name = "btnTaskNew";
            this.btnTaskNew.Size = new System.Drawing.Size(87, 36);
            this.btnTaskNew.TabIndex = 5;
            this.btnTaskNew.Text = "New";
            this.btnTaskNew.UseVisualStyleBackColor = true;
            this.btnTaskNew.Click += new System.EventHandler(this.btnTaskNew_Click);
            // 
            // btnTaskDel
            // 
            this.btnTaskDel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskDel.Location = new System.Drawing.Point(363, 384);
            this.btnTaskDel.Name = "btnTaskDel";
            this.btnTaskDel.Size = new System.Drawing.Size(87, 36);
            this.btnTaskDel.TabIndex = 5;
            this.btnTaskDel.Text = "Delete";
            this.btnTaskDel.UseVisualStyleBackColor = true;
            this.btnTaskDel.Click += new System.EventHandler(this.btnTaskDel_Click);
            // 
            // btnTaskClose
            // 
            this.btnTaskClose.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskClose.Location = new System.Drawing.Point(456, 384);
            this.btnTaskClose.Name = "btnTaskClose";
            this.btnTaskClose.Size = new System.Drawing.Size(87, 36);
            this.btnTaskClose.TabIndex = 5;
            this.btnTaskClose.Text = "Close";
            this.btnTaskClose.UseVisualStyleBackColor = true;
            this.btnTaskClose.Click += new System.EventHandler(this.btnTaskClose_Click);
            // 
            // btnTaskApp
            // 
            this.btnTaskApp.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskApp.Location = new System.Drawing.Point(84, 384);
            this.btnTaskApp.Name = "btnTaskApp";
            this.btnTaskApp.Size = new System.Drawing.Size(87, 36);
            this.btnTaskApp.TabIndex = 5;
            this.btnTaskApp.Text = "Approve";
            this.btnTaskApp.UseVisualStyleBackColor = true;
            // 
            // btnTaskUpd
            // 
            this.btnTaskUpd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskUpd.Location = new System.Drawing.Point(270, 384);
            this.btnTaskUpd.Name = "btnTaskUpd";
            this.btnTaskUpd.Size = new System.Drawing.Size(87, 36);
            this.btnTaskUpd.TabIndex = 5;
            this.btnTaskUpd.Text = "Update";
            this.btnTaskUpd.UseVisualStyleBackColor = true;
            // 
            // pnlForAdmin
            // 
            this.pnlForAdmin.Controls.Add(this.txtTaskPos);
            this.pnlForAdmin.Controls.Add(this.txtTaskDept);
            this.pnlForAdmin.Controls.Add(this.txtTaskName);
            this.pnlForAdmin.Controls.Add(this.txtTaskSur);
            this.pnlForAdmin.Controls.Add(this.txtTaskUser);
            this.pnlForAdmin.Controls.Add(this.label5);
            this.pnlForAdmin.Controls.Add(this.label4);
            this.pnlForAdmin.Controls.Add(this.label3);
            this.pnlForAdmin.Controls.Add(this.label2);
            this.pnlForAdmin.Controls.Add(this.label1);
            this.pnlForAdmin.Location = new System.Drawing.Point(1, 2);
            this.pnlForAdmin.Name = "pnlForAdmin";
            this.pnlForAdmin.Size = new System.Drawing.Size(240, 193);
            this.pnlForAdmin.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 432);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 432);
            this.Controls.Add(this.pnlForAdmin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTaskExport);
            this.Controls.Add(this.btnTaskClean);
            this.Controls.Add(this.btnTaskUpd);
            this.Controls.Add(this.btnTaskApp);
            this.Controls.Add(this.btnTaskClose);
            this.Controls.Add(this.btnTaskDel);
            this.Controls.Add(this.btnTaskNew);
            this.Controls.Add(this.btnTaskSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbTaskState);
            this.Controls.Add(this.dtTaskFinish);
            this.Controls.Add(this.dtTaskStart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "Task";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task";
            this.Load += new System.EventHandler(this.Task_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlForAdmin.ResumeLayout(false);
            this.pnlForAdmin.PerformLayout();
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
        private System.Windows.Forms.TextBox txtTaskDept;
        private System.Windows.Forms.TextBox txtTaskPos;
        private System.Windows.Forms.DateTimePicker dtTaskStart;
        private System.Windows.Forms.DateTimePicker dtTaskFinish;
        private System.Windows.Forms.ComboBox cbTaskState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTaskDeliver;
        private System.Windows.Forms.RadioButton rbTaskStart;
        private System.Windows.Forms.Button btnTaskSearch;
        private System.Windows.Forms.Button btnTaskClean;
        private System.Windows.Forms.Button btnTaskExport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnTaskNew;
        private System.Windows.Forms.Button btnTaskDel;
        private System.Windows.Forms.Button btnTaskClose;
        private System.Windows.Forms.Button btnTaskApp;
        private System.Windows.Forms.Button btnTaskUpd;
        private System.Windows.Forms.Panel pnlForAdmin;
        private System.Windows.Forms.Panel panel1;
    }
}