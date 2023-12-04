
namespace GUI_QLNhaHang
{
    partial class AJob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nmudToMinute = new System.Windows.Forms.NumericUpDown();
            this.nmudToHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nmudFromMinute = new System.Windows.Forms.NumericUpDown();
            this.nmudFromHour = new System.Windows.Forms.NumericUpDown();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.chbDone = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudToMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudToHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudFromMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudFromHour)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.cboStatus);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtJob);
            this.panel1.Controls.Add(this.chbDone);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 34);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(784, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(43, 27);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Location = new System.Drawing.Point(735, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(43, 27);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(593, 4);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(136, 24);
            this.cboStatus.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nmudToMinute);
            this.panel2.Controls.Add(this.nmudToHour);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nmudFromMinute);
            this.panel2.Controls.Add(this.nmudFromHour);
            this.panel2.Location = new System.Drawing.Point(361, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 27);
            this.panel2.TabIndex = 2;
            // 
            // nmudToMinute
            // 
            this.nmudToMinute.Location = new System.Drawing.Point(181, 2);
            this.nmudToMinute.Name = "nmudToMinute";
            this.nmudToMinute.Size = new System.Drawing.Size(40, 22);
            this.nmudToMinute.TabIndex = 4;
            // 
            // nmudToHour
            // 
            this.nmudToHour.Location = new System.Drawing.Point(135, 2);
            this.nmudToHour.Name = "nmudToHour";
            this.nmudToHour.Size = new System.Drawing.Size(40, 22);
            this.nmudToHour.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đến";
            // 
            // nmudFromMinute
            // 
            this.nmudFromMinute.Location = new System.Drawing.Point(50, 0);
            this.nmudFromMinute.Name = "nmudFromMinute";
            this.nmudFromMinute.Size = new System.Drawing.Size(40, 22);
            this.nmudFromMinute.TabIndex = 1;
            // 
            // nmudFromHour
            // 
            this.nmudFromHour.Location = new System.Drawing.Point(4, 0);
            this.nmudFromHour.Name = "nmudFromHour";
            this.nmudFromHour.Size = new System.Drawing.Size(40, 22);
            this.nmudFromHour.TabIndex = 0;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(28, 3);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(327, 22);
            this.txtJob.TabIndex = 1;
            // 
            // chbDone
            // 
            this.chbDone.AutoSize = true;
            this.chbDone.Location = new System.Drawing.Point(3, 3);
            this.chbDone.Name = "chbDone";
            this.chbDone.Size = new System.Drawing.Size(18, 17);
            this.chbDone.TabIndex = 0;
            this.chbDone.UseVisualStyleBackColor = true;
            this.chbDone.CheckedChanged += new System.EventHandler(this.chbDone_CheckedChanged);
            // 
            // AJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AJob";
            this.Size = new System.Drawing.Size(842, 40);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmudToMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudToHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudFromMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmudFromHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.CheckBox chbDone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nmudFromMinute;
        private System.Windows.Forms.NumericUpDown nmudFromHour;
        private System.Windows.Forms.NumericUpDown nmudToMinute;
        private System.Windows.Forms.NumericUpDown nmudToHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}
