
namespace GUI_QLNhaHang
{
    partial class DailyPlan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.pnlJob = new System.Windows.Forms.Panel();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mnsAddJob = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsToday = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNextDay = new System.Windows.Forms.Button();
            this.btnPreviousDay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlJob);
            this.panel1.Location = new System.Drawing.Point(2, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 468);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPreviousDay);
            this.panel3.Controls.Add(this.btnNextDay);
            this.panel3.Controls.Add(this.dtpDate);
            this.panel3.Location = new System.Drawing.Point(3, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 35);
            this.panel3.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dddd,  dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(111, 6);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(219, 22);
            this.dtpDate.TabIndex = 1;
            // 
            // pnlJob
            // 
            this.pnlJob.Location = new System.Drawing.Point(3, 46);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(441, 419);
            this.pnlJob.TabIndex = 0;
            // 
            // mnsMain
            // 
            this.mnsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAddJob,
            this.mnsToday});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(452, 28);
            this.mnsMain.TabIndex = 1;
            this.mnsMain.Text = "menuStrip1";
            // 
            // mnsAddJob
            // 
            this.mnsAddJob.Name = "mnsAddJob";
            this.mnsAddJob.Size = new System.Drawing.Size(90, 24);
            this.mnsAddJob.Text = "Thêm việc";
            // 
            // mnsToday
            // 
            this.mnsToday.Name = "mnsToday";
            this.mnsToday.Size = new System.Drawing.Size(83, 24);
            this.mnsToday.Text = "Hôm nay";
            // 
            // btnNextDay
            // 
            this.btnNextDay.AutoSize = true;
            this.btnNextDay.Location = new System.Drawing.Point(360, 3);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Size = new System.Drawing.Size(77, 27);
            this.btnNextDay.TabIndex = 3;
            this.btnNextDay.Text = "Ngày mai";
            this.btnNextDay.UseVisualStyleBackColor = true;
            // 
            // btnPreviousDay
            // 
            this.btnPreviousDay.AutoSize = true;
            this.btnPreviousDay.Location = new System.Drawing.Point(3, 3);
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Size = new System.Drawing.Size(87, 27);
            this.btnPreviousDay.TabIndex = 4;
            this.btnPreviousDay.Text = "Ngày trước";
            this.btnPreviousDay.UseVisualStyleBackColor = true;
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnsMain);
            this.MainMenuStrip = this.mnsMain;
            this.Name = "DailyPlan";
            this.Text = "Công việc trong ngày";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlJob;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem mnsAddJob;
        private System.Windows.Forms.ToolStripMenuItem mnsToday;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnPreviousDay;
        private System.Windows.Forms.Button btnNextDay;
    }
}