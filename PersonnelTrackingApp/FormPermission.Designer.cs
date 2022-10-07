
namespace PersonnelTrackingApp
{
    partial class FormPermission
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
            this.btnPerApp = new System.Windows.Forms.Button();
            this.rbTaskStart = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPerExport = new System.Windows.Forms.Button();
            this.btnPerClean = new System.Windows.Forms.Button();
            this.btnPerSearch = new System.Windows.Forms.Button();
            this.btnPerClose = new System.Windows.Forms.Button();
            this.btnPerDel = new System.Windows.Forms.Button();
            this.btnPerNew = new System.Windows.Forms.Button();
            this.rbTaskDeliver = new System.Windows.Forms.RadioButton();
            this.btnPerUpd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTaskState = new System.Windows.Forms.ComboBox();
            this.dtTaskFinish = new System.Windows.Forms.DateTimePicker();
            this.dtTaskStart = new System.Windows.Forms.DateTimePicker();
            this.txtPerPos = new System.Windows.Forms.TextBox();
            this.txtPerDept = new System.Windows.Forms.TextBox();
            this.txtPerName = new System.Windows.Forms.TextBox();
            this.txtPerSurname = new System.Windows.Forms.TextBox();
            this.txtPerUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPerDay = new System.Windows.Forms.TextBox();
            this.btnPerDisapp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPerApp
            // 
            this.btnPerApp.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerApp.Location = new System.Drawing.Point(52, 386);
            this.btnPerApp.Name = "btnPerApp";
            this.btnPerApp.Size = new System.Drawing.Size(87, 36);
            this.btnPerApp.TabIndex = 32;
            this.btnPerApp.Text = "Approve";
            this.btnPerApp.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 183);
            this.dataGridView1.TabIndex = 33;
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
            // btnPerExport
            // 
            this.btnPerExport.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerExport.Location = new System.Drawing.Point(515, 158);
            this.btnPerExport.Name = "btnPerExport";
            this.btnPerExport.Size = new System.Drawing.Size(78, 24);
            this.btnPerExport.TabIndex = 31;
            this.btnPerExport.Text = "Export";
            this.btnPerExport.UseVisualStyleBackColor = true;
            // 
            // btnPerClean
            // 
            this.btnPerClean.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerClean.Location = new System.Drawing.Point(515, 128);
            this.btnPerClean.Name = "btnPerClean";
            this.btnPerClean.Size = new System.Drawing.Size(78, 24);
            this.btnPerClean.TabIndex = 30;
            this.btnPerClean.Text = "Clean";
            this.btnPerClean.UseVisualStyleBackColor = true;
            // 
            // btnPerSearch
            // 
            this.btnPerSearch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerSearch.Location = new System.Drawing.Point(515, 95);
            this.btnPerSearch.Name = "btnPerSearch";
            this.btnPerSearch.Size = new System.Drawing.Size(78, 27);
            this.btnPerSearch.TabIndex = 29;
            this.btnPerSearch.Text = "Search";
            this.btnPerSearch.UseVisualStyleBackColor = true;
            // 
            // btnPerClose
            // 
            this.btnPerClose.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerClose.Location = new System.Drawing.Point(517, 386);
            this.btnPerClose.Name = "btnPerClose";
            this.btnPerClose.Size = new System.Drawing.Size(87, 36);
            this.btnPerClose.TabIndex = 28;
            this.btnPerClose.Text = "Close";
            this.btnPerClose.UseVisualStyleBackColor = true;
            // 
            // btnPerDel
            // 
            this.btnPerDel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerDel.Location = new System.Drawing.Point(424, 386);
            this.btnPerDel.Name = "btnPerDel";
            this.btnPerDel.Size = new System.Drawing.Size(87, 36);
            this.btnPerDel.TabIndex = 27;
            this.btnPerDel.Text = "Delete";
            this.btnPerDel.UseVisualStyleBackColor = true;
            // 
            // btnPerNew
            // 
            this.btnPerNew.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerNew.Location = new System.Drawing.Point(238, 386);
            this.btnPerNew.Name = "btnPerNew";
            this.btnPerNew.Size = new System.Drawing.Size(87, 36);
            this.btnPerNew.TabIndex = 26;
            this.btnPerNew.Text = "New";
            this.btnPerNew.UseVisualStyleBackColor = true;
            this.btnPerNew.Click += new System.EventHandler(this.btnPerNew_Click);
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
            // 
            // btnPerUpd
            // 
            this.btnPerUpd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerUpd.Location = new System.Drawing.Point(331, 386);
            this.btnPerUpd.Name = "btnPerUpd";
            this.btnPerUpd.Size = new System.Drawing.Size(87, 36);
            this.btnPerUpd.TabIndex = 25;
            this.btnPerUpd.Text = "Update";
            this.btnPerUpd.UseVisualStyleBackColor = true;
            this.btnPerUpd.Click += new System.EventHandler(this.btnPerUpd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTaskDeliver);
            this.groupBox1.Controls.Add(this.rbTaskStart);
            this.groupBox1.Location = new System.Drawing.Point(505, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 71);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // cbTaskState
            // 
            this.cbTaskState.FormattingEnabled = true;
            this.cbTaskState.Location = new System.Drawing.Point(345, 134);
            this.cbTaskState.Name = "cbTaskState";
            this.cbTaskState.Size = new System.Drawing.Size(121, 21);
            this.cbTaskState.TabIndex = 23;
            // 
            // dtTaskFinish
            // 
            this.dtTaskFinish.Location = new System.Drawing.Point(345, 69);
            this.dtTaskFinish.Name = "dtTaskFinish";
            this.dtTaskFinish.Size = new System.Drawing.Size(121, 20);
            this.dtTaskFinish.TabIndex = 21;
            // 
            // dtTaskStart
            // 
            this.dtTaskStart.Location = new System.Drawing.Point(345, 40);
            this.dtTaskStart.Name = "dtTaskStart";
            this.dtTaskStart.Size = new System.Drawing.Size(121, 20);
            this.dtTaskStart.TabIndex = 22;
            // 
            // txtPerPos
            // 
            this.txtPerPos.Location = new System.Drawing.Point(114, 146);
            this.txtPerPos.Name = "txtPerPos";
            this.txtPerPos.Size = new System.Drawing.Size(100, 20);
            this.txtPerPos.TabIndex = 20;
            // 
            // txtPerDept
            // 
            this.txtPerDept.Location = new System.Drawing.Point(114, 115);
            this.txtPerDept.Name = "txtPerDept";
            this.txtPerDept.Size = new System.Drawing.Size(100, 20);
            this.txtPerDept.TabIndex = 19;
            // 
            // txtPerName
            // 
            this.txtPerName.Location = new System.Drawing.Point(114, 54);
            this.txtPerName.Name = "txtPerName";
            this.txtPerName.Size = new System.Drawing.Size(100, 20);
            this.txtPerName.TabIndex = 18;
            // 
            // txtPerSurname
            // 
            this.txtPerSurname.Location = new System.Drawing.Point(114, 85);
            this.txtPerSurname.Name = "txtPerSurname";
            this.txtPerSurname.Size = new System.Drawing.Size(100, 20);
            this.txtPerSurname.TabIndex = 17;
            // 
            // txtPerUser
            // 
            this.txtPerUser.Location = new System.Drawing.Point(114, 24);
            this.txtPerUser.Name = "txtPerUser";
            this.txtPerUser.Size = new System.Drawing.Size(100, 20);
            this.txtPerUser.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(265, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Permission Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(278, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Finish";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(241, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Day Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "User No ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(278, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "State";
            // 
            // txtPerDay
            // 
            this.txtPerDay.Location = new System.Drawing.Point(345, 100);
            this.txtPerDay.Name = "txtPerDay";
            this.txtPerDay.Size = new System.Drawing.Size(121, 20);
            this.txtPerDay.TabIndex = 35;
            // 
            // btnPerDisapp
            // 
            this.btnPerDisapp.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerDisapp.Location = new System.Drawing.Point(145, 386);
            this.btnPerDisapp.Name = "btnPerDisapp";
            this.btnPerDisapp.Size = new System.Drawing.Size(87, 36);
            this.btnPerDisapp.TabIndex = 36;
            this.btnPerDisapp.Text = "Disapprove";
            this.btnPerDisapp.UseVisualStyleBackColor = true;
            // 
            // FormPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 432);
            this.Controls.Add(this.btnPerDisapp);
            this.Controls.Add(this.txtPerDay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnPerApp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPerExport);
            this.Controls.Add(this.btnPerClean);
            this.Controls.Add(this.btnPerSearch);
            this.Controls.Add(this.btnPerClose);
            this.Controls.Add(this.btnPerDel);
            this.Controls.Add(this.btnPerNew);
            this.Controls.Add(this.btnPerUpd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbTaskState);
            this.Controls.Add(this.dtTaskFinish);
            this.Controls.Add(this.dtTaskStart);
            this.Controls.Add(this.txtPerPos);
            this.Controls.Add(this.txtPerDept);
            this.Controls.Add(this.txtPerName);
            this.Controls.Add(this.txtPerSurname);
            this.Controls.Add(this.txtPerUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPermission";
            this.Text = "FormPermission";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPerApp;
        private System.Windows.Forms.RadioButton rbTaskStart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnPerExport;
        private System.Windows.Forms.Button btnPerClean;
        private System.Windows.Forms.Button btnPerSearch;
        private System.Windows.Forms.Button btnPerClose;
        private System.Windows.Forms.Button btnPerDel;
        private System.Windows.Forms.Button btnPerNew;
        private System.Windows.Forms.RadioButton rbTaskDeliver;
        private System.Windows.Forms.Button btnPerUpd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTaskState;
        private System.Windows.Forms.DateTimePicker dtTaskFinish;
        private System.Windows.Forms.DateTimePicker dtTaskStart;
        private System.Windows.Forms.TextBox txtPerPos;
        private System.Windows.Forms.TextBox txtPerDept;
        private System.Windows.Forms.TextBox txtPerName;
        private System.Windows.Forms.TextBox txtPerSurname;
        private System.Windows.Forms.TextBox txtPerUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPerDay;
        private System.Windows.Forms.Button btnPerDisapp;
    }
}