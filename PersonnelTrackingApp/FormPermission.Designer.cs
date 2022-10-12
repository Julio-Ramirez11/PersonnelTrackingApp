
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
            this.btnPerApp.Location = new System.Drawing.Point(78, 594);
            this.btnPerApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPerApp.Name = "btnPerApp";
            this.btnPerApp.Size = new System.Drawing.Size(130, 55);
            this.btnPerApp.TabIndex = 32;
            this.btnPerApp.Text = "Approve";
            this.btnPerApp.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(21, 303);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(940, 282);
            this.dataGridView1.TabIndex = 33;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Task Title";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "User No";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Surname";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Start Date";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Delivery Date";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Task State";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // btnPerExport
            // 
            this.btnPerExport.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerExport.Location = new System.Drawing.Point(772, 243);
            this.btnPerExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPerExport.Name = "btnPerExport";
            this.btnPerExport.Size = new System.Drawing.Size(117, 37);
            this.btnPerExport.TabIndex = 31;
            this.btnPerExport.Text = "Export";
            this.btnPerExport.UseVisualStyleBackColor = true;
            // 
            // btnPerClean
            // 
            this.btnPerClean.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerClean.Location = new System.Drawing.Point(772, 197);
            this.btnPerClean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPerClean.Name = "btnPerClean";
            this.btnPerClean.Size = new System.Drawing.Size(117, 37);
            this.btnPerClean.TabIndex = 30;
            this.btnPerClean.Text = "Clean";
            this.btnPerClean.UseVisualStyleBackColor = true;
            // 
            // btnPerSearch
            // 
            this.btnPerSearch.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerSearch.Location = new System.Drawing.Point(772, 146);
            this.btnPerSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPerSearch.Name = "btnPerSearch";
            this.btnPerSearch.Size = new System.Drawing.Size(117, 42);
            this.btnPerSearch.TabIndex = 29;
            this.btnPerSearch.Text = "Search";
            this.btnPerSearch.UseVisualStyleBackColor = true;
            // 
            // btnPerClose
            // 
            this.btnPerClose.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerClose.Location = new System.Drawing.Point(776, 594);
            this.btnPerClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPerClose.Name = "btnPerClose";
            this.btnPerClose.Size = new System.Drawing.Size(130, 55);
            this.btnPerClose.TabIndex = 28;
            this.btnPerClose.Text = "Close";
            this.btnPerClose.UseVisualStyleBackColor = true;
            this.btnPerClose.Click += new System.EventHandler(this.btnPerClose_Click);
            // 
            // btnPerDel
            // 
            this.btnPerDel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerDel.Location = new System.Drawing.Point(636, 594);
            this.btnPerDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPerDel.Name = "btnPerDel";
            this.btnPerDel.Size = new System.Drawing.Size(130, 55);
            this.btnPerDel.TabIndex = 27;
            this.btnPerDel.Text = "Delete";
            this.btnPerDel.UseVisualStyleBackColor = true;
            // 
            // btnPerNew
            // 
            this.btnPerNew.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerNew.Location = new System.Drawing.Point(357, 594);
            this.btnPerNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPerNew.Name = "btnPerNew";
            this.btnPerNew.Size = new System.Drawing.Size(130, 55);
            this.btnPerNew.TabIndex = 26;
            this.btnPerNew.Text = "New";
            this.btnPerNew.UseVisualStyleBackColor = true;
            this.btnPerNew.Click += new System.EventHandler(this.btnPerNew_Click);
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
            // 
            // btnPerUpd
            // 
            this.btnPerUpd.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerUpd.Location = new System.Drawing.Point(496, 594);
            this.btnPerUpd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPerUpd.Name = "btnPerUpd";
            this.btnPerUpd.Size = new System.Drawing.Size(130, 55);
            this.btnPerUpd.TabIndex = 25;
            this.btnPerUpd.Text = "Update";
            this.btnPerUpd.UseVisualStyleBackColor = true;
            this.btnPerUpd.Click += new System.EventHandler(this.btnPerUpd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTaskDeliver);
            this.groupBox1.Controls.Add(this.rbTaskStart);
            this.groupBox1.Location = new System.Drawing.Point(758, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(170, 109);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // cbTaskState
            // 
            this.cbTaskState.FormattingEnabled = true;
            this.cbTaskState.Location = new System.Drawing.Point(518, 206);
            this.cbTaskState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTaskState.Name = "cbTaskState";
            this.cbTaskState.Size = new System.Drawing.Size(180, 28);
            this.cbTaskState.TabIndex = 23;
            // 
            // dtTaskFinish
            // 
            this.dtTaskFinish.Location = new System.Drawing.Point(518, 106);
            this.dtTaskFinish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtTaskFinish.Name = "dtTaskFinish";
            this.dtTaskFinish.Size = new System.Drawing.Size(180, 26);
            this.dtTaskFinish.TabIndex = 21;
            // 
            // dtTaskStart
            // 
            this.dtTaskStart.Location = new System.Drawing.Point(518, 62);
            this.dtTaskStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtTaskStart.Name = "dtTaskStart";
            this.dtTaskStart.Size = new System.Drawing.Size(180, 26);
            this.dtTaskStart.TabIndex = 22;
            // 
            // txtPerPos
            // 
            this.txtPerPos.Location = new System.Drawing.Point(171, 225);
            this.txtPerPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPerPos.Name = "txtPerPos";
            this.txtPerPos.Size = new System.Drawing.Size(148, 26);
            this.txtPerPos.TabIndex = 20;
            // 
            // txtPerDept
            // 
            this.txtPerDept.Location = new System.Drawing.Point(171, 177);
            this.txtPerDept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPerDept.Name = "txtPerDept";
            this.txtPerDept.Size = new System.Drawing.Size(148, 26);
            this.txtPerDept.TabIndex = 19;
            // 
            // txtPerName
            // 
            this.txtPerName.Location = new System.Drawing.Point(171, 83);
            this.txtPerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPerName.Name = "txtPerName";
            this.txtPerName.Size = new System.Drawing.Size(148, 26);
            this.txtPerName.TabIndex = 18;
            // 
            // txtPerSurname
            // 
            this.txtPerSurname.Location = new System.Drawing.Point(171, 131);
            this.txtPerSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPerSurname.Name = "txtPerSurname";
            this.txtPerSurname.Size = new System.Drawing.Size(148, 26);
            this.txtPerSurname.TabIndex = 17;
            // 
            // txtPerUser
            // 
            this.txtPerUser.Location = new System.Drawing.Point(171, 37);
            this.txtPerUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPerUser.Name = "txtPerUser";
            this.txtPerUser.Size = new System.Drawing.Size(148, 26);
            this.txtPerUser.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(398, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Permission Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Finish";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(362, 157);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 31);
            this.label9.TabIndex = 12;
            this.label9.Text = "Day Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "User No ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(417, 203);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 31);
            this.label10.TabIndex = 34;
            this.label10.Text = "State";
            // 
            // txtPerDay
            // 
            this.txtPerDay.Location = new System.Drawing.Point(518, 154);
            this.txtPerDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPerDay.Name = "txtPerDay";
            this.txtPerDay.Size = new System.Drawing.Size(180, 26);
            this.txtPerDay.TabIndex = 35;
            // 
            // btnPerDisapp
            // 
            this.btnPerDisapp.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerDisapp.Location = new System.Drawing.Point(218, 594);
            this.btnPerDisapp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPerDisapp.Name = "btnPerDisapp";
            this.btnPerDisapp.Size = new System.Drawing.Size(130, 55);
            this.btnPerDisapp.TabIndex = 36;
            this.btnPerDisapp.Text = "Disapprove";
            this.btnPerDisapp.UseVisualStyleBackColor = true;
            // 
            // FormPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 665);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPermission";
            this.Text = "FormPermission";
            this.Load += new System.EventHandler(this.FormPermission_Load);
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