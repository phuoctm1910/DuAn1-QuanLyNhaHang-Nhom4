
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnMonday = new System.Windows.Forms.Button();
            this.btnTuesday = new System.Windows.Forms.Button();
            this.btnWednesday = new System.Windows.Forms.Button();
            this.btnThursday = new System.Windows.Forms.Button();
            this.btnFriday = new System.Windows.Forms.Button();
            this.btnSaturday = new System.Windows.Forms.Button();
            this.btnSunday = new System.Windows.Forms.Button();
            this.btnPreviousMonth = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chbNotice = new System.Windows.Forms.CheckBox();
            this.nmudNotice = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudNotice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 472);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 425);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.btnToday);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(769, 35);
            this.panel3.TabIndex = 1;
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
            this.panel4.Size = new System.Drawing.Size(761, 57);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(40, 63);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(691, 359);
            this.panel5.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dddd,  dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(257, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnToday
            // 
            this.btnToday.AutoSize = true;
            this.btnToday.Location = new System.Drawing.Point(551, 4);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(75, 27);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = true;
            // 
            // btnMonday
            // 
            this.btnMonday.AutoSize = true;
            this.btnMonday.Location = new System.Drawing.Point(105, 3);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(75, 51);
            this.btnMonday.TabIndex = 0;
            this.btnMonday.Text = "Thứ hai";
            this.btnMonday.UseVisualStyleBackColor = true;
            // 
            // btnTuesday
            // 
            this.btnTuesday.AutoSize = true;
            this.btnTuesday.Location = new System.Drawing.Point(186, 3);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(75, 51);
            this.btnTuesday.TabIndex = 1;
            this.btnTuesday.Text = "Thứ ba";
            this.btnTuesday.UseVisualStyleBackColor = true;
            // 
            // btnWednesday
            // 
            this.btnWednesday.AutoSize = true;
            this.btnWednesday.Location = new System.Drawing.Point(267, 3);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(75, 51);
            this.btnWednesday.TabIndex = 2;
            this.btnWednesday.Text = "Thứ tư";
            this.btnWednesday.UseVisualStyleBackColor = true;
            // 
            // btnThursday
            // 
            this.btnThursday.AutoSize = true;
            this.btnThursday.Location = new System.Drawing.Point(348, 3);
            this.btnThursday.Name = "btnThursday";
            this.btnThursday.Size = new System.Drawing.Size(75, 51);
            this.btnThursday.TabIndex = 3;
            this.btnThursday.Text = "Thứ năm";
            this.btnThursday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            this.btnFriday.AutoSize = true;
            this.btnFriday.Location = new System.Drawing.Point(429, 3);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(75, 51);
            this.btnFriday.TabIndex = 4;
            this.btnFriday.Text = "Thứ sáu";
            this.btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            this.btnSaturday.AutoSize = true;
            this.btnSaturday.Location = new System.Drawing.Point(510, 3);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(75, 51);
            this.btnSaturday.TabIndex = 5;
            this.btnSaturday.Text = "Thứ bảy";
            this.btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnSunday
            // 
            this.btnSunday.AutoSize = true;
            this.btnSunday.Location = new System.Drawing.Point(591, 3);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(75, 51);
            this.btnSunday.TabIndex = 6;
            this.btnSunday.Text = "Chủ nhật";
            this.btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnPreviousMonth
            // 
            this.btnPreviousMonth.AutoSize = true;
            this.btnPreviousMonth.Location = new System.Drawing.Point(4, 3);
            this.btnPreviousMonth.Name = "btnPreviousMonth";
            this.btnPreviousMonth.Size = new System.Drawing.Size(95, 51);
            this.btnPreviousMonth.TabIndex = 7;
            this.btnPreviousMonth.Text = "Tháng trước";
            this.btnPreviousMonth.UseVisualStyleBackColor = true;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.AutoSize = true;
            this.btnNextMonth.Location = new System.Drawing.Point(672, 3);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(86, 51);
            this.btnNextMonth.TabIndex = 8;
            this.btnNextMonth.Text = "Tháng sau";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nmudNotice);
            this.panel6.Controls.Add(this.chbNotice);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 35);
            this.panel6.TabIndex = 2;
            // 
            // chbNotice
            // 
            this.chbNotice.AutoSize = true;
            this.chbNotice.Location = new System.Drawing.Point(7, 7);
            this.chbNotice.Name = "chbNotice";
            this.chbNotice.Size = new System.Drawing.Size(70, 21);
            this.chbNotice.TabIndex = 0;
            this.chbNotice.Text = "Notice";
            this.chbNotice.UseVisualStyleBackColor = true;
            // 
            // nmudNotice
            // 
            this.nmudNotice.Location = new System.Drawing.Point(83, 7);
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
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 477);
            this.Controls.Add(this.panel1);
            this.Name = "Calender";
            this.Text = "Calendar";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudNotice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
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
    }
}