
namespace GUI_QLNhaHang
{
    partial class HoaDonChiTiet
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
            this.dvgThongTinCTHD = new System.Windows.Forms.DataGridView();
            this.txtTongTienHDBangChu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTenMonAn = new System.Windows.Forms.ComboBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgThongTinCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgThongTinCTHD
            // 
            this.dvgThongTinCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgThongTinCTHD.Location = new System.Drawing.Point(367, 85);
            this.dvgThongTinCTHD.Name = "dvgThongTinCTHD";
            this.dvgThongTinCTHD.RowHeadersWidth = 51;
            this.dvgThongTinCTHD.RowTemplate.Height = 24;
            this.dvgThongTinCTHD.Size = new System.Drawing.Size(697, 219);
            this.dvgThongTinCTHD.TabIndex = 65;
            this.dvgThongTinCTHD.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgThongTinCTHD_CellValueChanged);
            this.dvgThongTinCTHD.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dvgThongTinCTHD_RowsAdded);
            this.dvgThongTinCTHD.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dvgThongTinCTHD_RowsRemoved);
            this.dvgThongTinCTHD.DoubleClick += new System.EventHandler(this.dvgThongTinCTHD_DoubleClick);
            // 
            // txtTongTienHDBangChu
            // 
            this.txtTongTienHDBangChu.Location = new System.Drawing.Point(214, 352);
            this.txtTongTienHDBangChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTienHDBangChu.Name = "txtTongTienHDBangChu";
            this.txtTongTienHDBangChu.Size = new System.Drawing.Size(353, 22);
            this.txtTongTienHDBangChu.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 17);
            this.label6.TabIndex = 63;
            this.label6.Text = "Tổng Tiền HĐ Bằng Chữ:";
            // 
            // cboTenMonAn
            // 
            this.cboTenMonAn.FormattingEnabled = true;
            this.cboTenMonAn.Location = new System.Drawing.Point(136, 128);
            this.cboTenMonAn.Name = "cboTenMonAn";
            this.cboTenMonAn.Size = new System.Drawing.Size(204, 24);
            this.cboTenMonAn.TabIndex = 62;
            this.cboTenMonAn.SelectedIndexChanged += new System.EventHandler(this.cboTenMonAn_SelectedIndexChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(136, 282);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(204, 22);
            this.txtThanhTien.TabIndex = 61;
            this.txtThanhTien.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Thành Tiền:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(136, 232);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(204, 22);
            this.txtDonGia.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Đơn Giá:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(136, 182);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(204, 22);
            this.txtSoLuong.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Số Lượng:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Tên Món Ăn:*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(415, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "Thông tin Chi Tiết Hóa Đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(136, 82);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(204, 22);
            this.txtMaHD.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mã HĐ:";
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = global::GUI_QLNhaHang.Properties.Resources.exit1;
            this.btnThoat.Location = new System.Drawing.Point(631, 417);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnThoat.Size = new System.Drawing.Size(95, 44);
            this.btnThoat.TabIndex = 70;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSize = true;
            this.btnHuy.BackColor = System.Drawing.Color.OrangeRed;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Image = global::GUI_QLNhaHang.Properties.Resources.Cancel1;
            this.btnHuy.Location = new System.Drawing.Point(491, 417);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHuy.Size = new System.Drawing.Size(81, 44);
            this.btnHuy.TabIndex = 69;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::GUI_QLNhaHang.Properties.Resources.delete1;
            this.btnXoa.Location = new System.Drawing.Point(352, 417);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnXoa.Size = new System.Drawing.Size(80, 44);
            this.btnXoa.TabIndex = 68;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnInHD
            // 
            this.btnInHD.AutoSize = true;
            this.btnInHD.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.ForeColor = System.Drawing.Color.White;
            this.btnInHD.Image = global::GUI_QLNhaHang.Properties.Resources.InHD;
            this.btnInHD.Location = new System.Drawing.Point(785, 417);
            this.btnInHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInHD.Size = new System.Drawing.Size(143, 44);
            this.btnInHD.TabIndex = 67;
            this.btnInHD.Text = "In Hóa Đơn";
            this.btnInHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInHD.UseVisualStyleBackColor = false;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = global::GUI_QLNhaHang.Properties.Resources.data_storage;
            this.btnLuu.Location = new System.Drawing.Point(214, 417);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLuu.Size = new System.Drawing.Size(79, 44);
            this.btnLuu.TabIndex = 66;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // HoaDonChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1111, 493);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dvgThongTinCTHD);
            this.Controls.Add(this.txtTongTienHDBangChu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboTenMonAn);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label2);
            this.Name = "HoaDonChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn Chi Tiết";
            this.Load += new System.EventHandler(this.HoaDonChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgThongTinCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dvgThongTinCTHD;
        private System.Windows.Forms.TextBox txtTongTienHDBangChu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTenMonAn;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label2;
    }
}