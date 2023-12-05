
namespace GUI_QLNhaHang
{
    partial class Calender
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calender));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nmudNotice = new System.Windows.Forms.NumericUpDown();
            this.chbNotice = new System.Windows.Forms.CheckBox();
            this.btnToday = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMatrix = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnPreviousMonth = new System.Windows.Forms.Button();
            this.btnSunday = new System.Windows.Forms.Button();
            this.btnSaturday = new System.Windows.Forms.Button();
            this.btnFriday = new System.Windows.Forms.Button();
            this.btnThursday = new System.Windows.Forms.Button();
            this.btnWednesday = new System.Windows.Forms.Button();
            this.btnTuesday = new System.Windows.Forms.Button();
            this.btnMonday = new System.Windows.Forms.Button();
            this.timerNotify = new System.Windows.Forms.Timer(this.components);
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudNotice)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 538);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btnToday);
            this.panel3.Controls.Add(this.dtpDate);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 35);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nmudNotice);
            this.panel6.Controls.Add(this.chbNotice);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(214, 35);
            this.panel6.TabIndex = 2;
            // 
            // nmudNotice
            // 
            this.nmudNotice.Enabled = false;
            this.nmudNotice.Location = new System.Drawing.Point(108, 8);
            this.nmudNotice.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nmudNotice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudNotice.Name = "nmudNotice";
            this.nmudNotice.Size = new System.Drawing.Size(100, 22);
            this.nmudNotice.TabIndex = 1;
            this.nmudNotice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmudNotice.ValueChanged += new System.EventHandler(this.nmudNotice_ValueChanged);
            // 
            // chbNotice
            // 
            this.chbNotice.AutoSize = true;
            this.chbNotice.Location = new System.Drawing.Point(7, 7);
            this.chbNotice.Name = "chbNotice";
            this.chbNotice.Size = new System.Drawing.Size(99, 21);
            this.chbNotice.TabIndex = 0;
            this.chbNotice.Text = "Thông báo";
            this.chbNotice.UseVisualStyleBackColor = true;
            this.chbNotice.CheckedChanged += new System.EventHandler(this.chbNotice_CheckedChanged);
            // 
            // btnToday
            // 
            this.btnToday.AutoSize = true;
            this.btnToday.Location = new System.Drawing.Point(544, 5);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(75, 27);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dddd,  dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(257, 6);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(219, 22);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlMatrix);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 491);
            this.panel2.TabIndex = 0;
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.Location = new System.Drawing.Point(108, 52);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(570, 416);
            this.pnlMatrix.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnNextMonth);
            this.panel4.Controls.Add(this.btnPreviousMonth);
            this.panel4.Controls.Add(this.btnSunday);
            this.panel4.Controls.Add(this.btnSaturday);
            this.panel4.Controls.Add(this.btnFriday);
            this.panel4.Controls.Add(this.btnThursday);
            this.panel4.Controls.Add(this.btnWednesday);
            this.panel4.Controls.Add(this.btnTuesday);
            this.panel4.Controls.Add(this.btnMonday);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(761, 47);
            this.panel4.TabIndex = 0;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.AutoSize = true;
            this.btnNextMonth.Location = new System.Drawing.Point(672, 4);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(86, 40);
            this.btnNextMonth.TabIndex = 8;
            this.btnNextMonth.Text = "Tháng sau";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnPreviousMonth
            // 
            this.btnPreviousMonth.AutoSize = true;
            this.btnPreviousMonth.Location = new System.Drawing.Point(4, 3);
            this.btnPreviousMonth.Name = "btnPreviousMonth";
            this.btnPreviousMonth.Size = new System.Drawing.Size(95, 40);
            this.btnPreviousMonth.TabIndex = 7;
            this.btnPreviousMonth.Text = "Tháng trước";
            this.btnPreviousMonth.UseVisualStyleBackColor = true;
            this.btnPreviousMonth.Click += new System.EventHandler(this.btnPreviousMonth_Click);
            // 
            // btnSunday
            // 
            this.btnSunday.AutoSize = true;
            this.btnSunday.Location = new System.Drawing.Point(591, 3);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(75, 40);
            this.btnSunday.TabIndex = 6;
            this.btnSunday.Text = "Chủ nhật";
            this.btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            this.btnSaturday.AutoSize = true;
            this.btnSaturday.Location = new System.Drawing.Point(510, 3);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(75, 40);
            this.btnSaturday.TabIndex = 5;
            this.btnSaturday.Text = "Thứ bảy";
            this.btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            this.btnFriday.AutoSize = true;
            this.btnFriday.Location = new System.Drawing.Point(429, 3);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(75, 40);
            this.btnFriday.TabIndex = 4;
            this.btnFriday.Text = "Thứ sáu";
            this.btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnThursday
            // 
            this.btnThursday.AutoSize = true;
            this.btnThursday.Location = new System.Drawing.Point(348, 4);
            this.btnThursday.Name = "btnThursday";
            this.btnThursday.Size = new System.Drawing.Size(75, 40);
            this.btnThursday.TabIndex = 3;
            this.btnThursday.Text = "Thứ năm";
            this.btnThursday.UseVisualStyleBackColor = true;
            // 
            // btnWednesday
            // 
            this.btnWednesday.AutoSize = true;
            this.btnWednesday.Location = new System.Drawing.Point(267, 3);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(75, 40);
            this.btnWednesday.TabIndex = 2;
            this.btnWednesday.Text = "Thứ tư";
            this.btnWednesday.UseVisualStyleBackColor = true;
            // 
            // btnTuesday
            // 
            this.btnTuesday.AutoSize = true;
            this.btnTuesday.Location = new System.Drawing.Point(186, 3);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(75, 40);
            this.btnTuesday.TabIndex = 1;
            this.btnTuesday.Text = "Thứ ba";
            this.btnTuesday.UseVisualStyleBackColor = true;
            // 
            // btnMonday
            // 
            this.btnMonday.AutoSize = true;
            this.btnMonday.Location = new System.Drawing.Point(105, 3);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(75, 40);
            this.btnMonday.TabIndex = 0;
            this.btnMonday.Text = "Thứ hai";
            this.btnMonday.UseVisualStyleBackColor = true;
            // 
            // timerNotify
            // 
            this.timerNotify.Enabled = true;
            this.timerNotify.Interval = 5000;
            this.timerNotify.Tick += new System.EventHandler(this.timerNotify_Tick);
            // 
            // Notify
            // 
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "notifyIcon1";
            this.Notify.Visible = true;
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 544);
            this.Controls.Add(this.panel1);
            this.Name = "Calender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calender_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Calender_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudNotice)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMatrix;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown nmudNotice;
        private System.Windows.Forms.CheckBox chbNotice;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnPreviousMonth;
        private System.Windows.Forms.Button btnSunday;
        private System.Windows.Forms.Button btnSaturday;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnThursday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button btnTuesday;
        private System.Windows.Forms.Button btnMonday;
        private System.Windows.Forms.Timer timerNotify;
        private System.Windows.Forms.NotifyIcon Notify;
    }
}