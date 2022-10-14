
namespace PersonnelTrackingApp
{
    partial class FormTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTracking));
            this.btnEmp = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnSal = new System.Windows.Forms.Button();
            this.btnPer = new System.Windows.Forms.Button();
            this.btnDept = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmp
            // 
            this.btnEmp.Location = new System.Drawing.Point(23, 58);
            this.btnEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmp.Name = "btnEmp";
            this.btnEmp.Size = new System.Drawing.Size(198, 109);
            this.btnEmp.TabIndex = 0;
            this.btnEmp.Text = "Employee";
            this.btnEmp.UseVisualStyleBackColor = true;
            this.btnEmp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(349, 327);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 60);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(498, 327);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 60);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.Location = new System.Drawing.Point(229, 58);
            this.btnTasks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(198, 109);
            this.btnTasks.TabIndex = 3;
            this.btnTasks.Text = "Tasks";
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnSal
            // 
            this.btnSal.Location = new System.Drawing.Point(437, 58);
            this.btnSal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSal.Name = "btnSal";
            this.btnSal.Size = new System.Drawing.Size(198, 109);
            this.btnSal.TabIndex = 4;
            this.btnSal.Text = "Salary";
            this.btnSal.UseVisualStyleBackColor = true;
            this.btnSal.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnPer
            // 
            this.btnPer.Location = new System.Drawing.Point(23, 177);
            this.btnPer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPer.Name = "btnPer";
            this.btnPer.Size = new System.Drawing.Size(198, 109);
            this.btnPer.TabIndex = 5;
            this.btnPer.Text = "Permission";
            this.btnPer.UseVisualStyleBackColor = true;
            this.btnPer.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnDept
            // 
            this.btnDept.Location = new System.Drawing.Point(229, 177);
            this.btnDept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDept.Name = "btnDept";
            this.btnDept.Size = new System.Drawing.Size(198, 109);
            this.btnDept.TabIndex = 6;
            this.btnDept.Text = "Department";
            this.btnDept.UseVisualStyleBackColor = true;
            this.btnDept.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(437, 177);
            this.btnPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(198, 109);
            this.btnPos.TabIndex = 7;
            this.btnPos.Text = "Position";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 432);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.btnDept);
            this.Controls.Add(this.btnPer);
            this.Controls.Add(this.btnSal);
            this.Controls.Add(this.btnTasks);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Tracking";
            this.Load += new System.EventHandler(this.FormTracking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmp;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnSal;
        private System.Windows.Forms.Button btnPer;
        private System.Windows.Forms.Button btnDept;
        private System.Windows.Forms.Button btnPos;
    }
}