
namespace PersonnelTrackingApp
{
    partial class FormSalary
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
            this.txtSalUser = new System.Windows.Forms.TextBox();
            this.txtSalName = new System.Windows.Forms.TextBox();
            this.txtSalSurname = new System.Windows.Forms.TextBox();
            this.txtSalYear = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEqual = new System.Windows.Forms.RadioButton();
            this.rbLess = new System.Windows.Forms.RadioButton();
            this.rbMore = new System.Windows.Forms.RadioButton();
            this.btnSalSearch = new System.Windows.Forms.Button();
            this.btnSalClear = new System.Windows.Forms.Button();
            this.btnSalExport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalNew = new System.Windows.Forms.Button();
            this.btnSalUpdate = new System.Windows.Forms.Button();
            this.btnSalClose = new System.Windows.Forms.Button();
            this.btnSalDel = new System.Windows.Forms.Button();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.cmbPos = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "User No.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Department";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Position";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Year";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Month";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(452, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Salary";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSalUser
            // 
            this.txtSalUser.Location = new System.Drawing.Point(200, 28);
            this.txtSalUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalUser.Name = "txtSalUser";
            this.txtSalUser.Size = new System.Drawing.Size(181, 26);
            this.txtSalUser.TabIndex = 19;
            // 
            // txtSalName
            // 
            this.txtSalName.Location = new System.Drawing.Point(200, 72);
            this.txtSalName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalName.Name = "txtSalName";
            this.txtSalName.Size = new System.Drawing.Size(181, 26);
            this.txtSalName.TabIndex = 20;
            // 
            // txtSalSurname
            // 
            this.txtSalSurname.Location = new System.Drawing.Point(200, 115);
            this.txtSalSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalSurname.Name = "txtSalSurname";
            this.txtSalSurname.Size = new System.Drawing.Size(181, 26);
            this.txtSalSurname.TabIndex = 21;
            // 
            // txtSalYear
            // 
            this.txtSalYear.Location = new System.Drawing.Point(560, 28);
            this.txtSalYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalYear.Name = "txtSalYear";
            this.txtSalYear.Size = new System.Drawing.Size(181, 26);
            this.txtSalYear.TabIndex = 24;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(560, 145);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(181, 26);
            this.txtSalary.TabIndex = 25;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(560, 82);
            this.cmbMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(181, 28);
            this.cmbMonth.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEqual);
            this.groupBox1.Controls.Add(this.rbLess);
            this.groupBox1.Controls.Add(this.rbMore);
            this.groupBox1.Location = new System.Drawing.Point(783, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(160, 158);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // rbEqual
            // 
            this.rbEqual.AutoSize = true;
            this.rbEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEqual.Location = new System.Drawing.Point(24, 98);
            this.rbEqual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbEqual.Name = "rbEqual";
            this.rbEqual.Size = new System.Drawing.Size(110, 30);
            this.rbEqual.TabIndex = 2;
            this.rbEqual.TabStop = true;
            this.rbEqual.Text = "Equals";
            this.rbEqual.UseVisualStyleBackColor = true;
            // 
            // rbLess
            // 
            this.rbLess.AutoSize = true;
            this.rbLess.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLess.Location = new System.Drawing.Point(24, 58);
            this.rbLess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbLess.Name = "rbLess";
            this.rbLess.Size = new System.Drawing.Size(83, 35);
            this.rbLess.TabIndex = 1;
            this.rbLess.TabStop = true;
            this.rbLess.Text = "Less";
            this.rbLess.UseVisualStyleBackColor = true;
            // 
            // rbMore
            // 
            this.rbMore.AutoSize = true;
            this.rbMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMore.Location = new System.Drawing.Point(24, 23);
            this.rbMore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMore.Name = "rbMore";
            this.rbMore.Size = new System.Drawing.Size(90, 30);
            this.rbMore.TabIndex = 0;
            this.rbMore.TabStop = true;
            this.rbMore.Text = "More";
            this.rbMore.UseVisualStyleBackColor = true;
            // 
            // btnSalSearch
            // 
            this.btnSalSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalSearch.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalSearch.Location = new System.Drawing.Point(456, 197);
            this.btnSalSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalSearch.Name = "btnSalSearch";
            this.btnSalSearch.Size = new System.Drawing.Size(118, 51);
            this.btnSalSearch.TabIndex = 28;
            this.btnSalSearch.Text = "Search";
            this.btnSalSearch.UseVisualStyleBackColor = true;
            this.btnSalSearch.Click += new System.EventHandler(this.btnSalSearch_Click);
            // 
            // btnSalClear
            // 
            this.btnSalClear.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalClear.Location = new System.Drawing.Point(598, 197);
            this.btnSalClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalClear.Name = "btnSalClear";
            this.btnSalClear.Size = new System.Drawing.Size(118, 51);
            this.btnSalClear.TabIndex = 29;
            this.btnSalClear.Text = "Clear";
            this.btnSalClear.UseVisualStyleBackColor = true;
            this.btnSalClear.Click += new System.EventHandler(this.btnSalClear_Click);
            // 
            // btnSalExport
            // 
            this.btnSalExport.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalExport.Location = new System.Drawing.Point(740, 197);
            this.btnSalExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalExport.Name = "btnSalExport";
            this.btnSalExport.Size = new System.Drawing.Size(118, 51);
            this.btnSalExport.TabIndex = 30;
            this.btnSalExport.Text = "Export";
            this.btnSalExport.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 283);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(921, 295);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // btnSalNew
            // 
            this.btnSalNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalNew.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalNew.Location = new System.Drawing.Point(174, 595);
            this.btnSalNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalNew.Name = "btnSalNew";
            this.btnSalNew.Size = new System.Drawing.Size(118, 51);
            this.btnSalNew.TabIndex = 32;
            this.btnSalNew.Text = "New";
            this.btnSalNew.UseVisualStyleBackColor = true;
            this.btnSalNew.Click += new System.EventHandler(this.btnSalNew_Click);
            // 
            // btnSalUpdate
            // 
            this.btnSalUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalUpdate.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalUpdate.Location = new System.Drawing.Point(316, 595);
            this.btnSalUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalUpdate.Name = "btnSalUpdate";
            this.btnSalUpdate.Size = new System.Drawing.Size(118, 51);
            this.btnSalUpdate.TabIndex = 33;
            this.btnSalUpdate.Text = "Update";
            this.btnSalUpdate.UseVisualStyleBackColor = true;
            this.btnSalUpdate.Click += new System.EventHandler(this.btnSalUpdate_Click);
            // 
            // btnSalClose
            // 
            this.btnSalClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalClose.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalClose.Location = new System.Drawing.Point(598, 595);
            this.btnSalClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalClose.Name = "btnSalClose";
            this.btnSalClose.Size = new System.Drawing.Size(118, 51);
            this.btnSalClose.TabIndex = 35;
            this.btnSalClose.Text = "Close";
            this.btnSalClose.UseVisualStyleBackColor = true;
            this.btnSalClose.Click += new System.EventHandler(this.btnSalClose_Click);
            // 
            // btnSalDel
            // 
            this.btnSalDel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalDel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalDel.Location = new System.Drawing.Point(456, 595);
            this.btnSalDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalDel.Name = "btnSalDel";
            this.btnSalDel.Size = new System.Drawing.Size(118, 51);
            this.btnSalDel.TabIndex = 34;
            this.btnSalDel.Text = "Delete";
            this.btnSalDel.UseVisualStyleBackColor = true;
            this.btnSalDel.Click += new System.EventHandler(this.btnSalDel_Click);
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(200, 157);
            this.cmbDept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(181, 28);
            this.cmbDept.TabIndex = 36;
            this.cmbDept.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbPos
            // 
            this.cmbPos.FormattingEnabled = true;
            this.cmbPos.Location = new System.Drawing.Point(200, 202);
            this.cmbPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPos.Name = "cmbPos";
            this.cmbPos.Size = new System.Drawing.Size(181, 28);
            this.cmbPos.TabIndex = 37;
            this.cmbPos.SelectedIndexChanged += new System.EventHandler(this.cmbPos_SelectedIndexChanged);
            // 
            // FormSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 665);
            this.Controls.Add(this.cmbPos);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.btnSalClose);
            this.Controls.Add(this.btnSalDel);
            this.Controls.Add(this.btnSalUpdate);
            this.Controls.Add(this.btnSalNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalExport);
            this.Controls.Add(this.btnSalClear);
            this.Controls.Add(this.btnSalSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtSalYear);
            this.Controls.Add(this.txtSalSurname);
            this.Controls.Add(this.txtSalName);
            this.Controls.Add(this.txtSalUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Salary";
            this.Load += new System.EventHandler(this.FormSalary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtSalUser;
        private System.Windows.Forms.TextBox txtSalName;
        private System.Windows.Forms.TextBox txtSalSurname;
        private System.Windows.Forms.TextBox txtSalYear;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEqual;
        private System.Windows.Forms.RadioButton rbLess;
        private System.Windows.Forms.RadioButton rbMore;
        private System.Windows.Forms.Button btnSalSearch;
        private System.Windows.Forms.Button btnSalClear;
        private System.Windows.Forms.Button btnSalExport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalNew;
        private System.Windows.Forms.Button btnSalUpdate;
        private System.Windows.Forms.Button btnSalClose;
        private System.Windows.Forms.Button btnSalDel;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.ComboBox cmbPos;
    }
}