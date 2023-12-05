
namespace GUI_QLNhaHang
{
    partial class ThongKe
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
            this.dvThongKe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXuatThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dvThongKe
            // 
            this.dvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvThongKe.Location = new System.Drawing.Point(12, 77);
            this.dvThongKe.Name = "dvThongKe";
            this.dvThongKe.RowHeadersWidth = 51;
            this.dvThongKe.RowTemplate.Height = 24;
            this.dvThongKe.Size = new System.Drawing.Size(807, 210);
            this.dvThongKe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(287, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lí Thống Kê";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI_QLNhaHang.Properties.Resources.z4818527692435_6add3f2bb755ba21434309235e05916c_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnXuatThongKe
            // 
            this.btnXuatThongKe.AutoSize = true;
            this.btnXuatThongKe.BackColor = System.Drawing.Color.ForestGreen;
            this.btnXuatThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatThongKe.ForeColor = System.Drawing.Color.White;
            this.btnXuatThongKe.Image = global::GUI_QLNhaHang.Properties.Resources.excel;
            this.btnXuatThongKe.Location = new System.Drawing.Point(622, 308);
            this.btnXuatThongKe.Name = "btnXuatThongKe";
            this.btnXuatThongKe.Size = new System.Drawing.Size(166, 30);
            this.btnXuatThongKe.TabIndex = 2;
            this.btnXuatThongKe.Text = "Xuất Thống Kê";
            this.btnXuatThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuatThongKe.UseVisualStyleBackColor = false;
            this.btnXuatThongKe.Click += new System.EventHandler(this.btnXuatThongKe_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(831, 364);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnXuatThongKe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvThongKe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuatThongKe;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}