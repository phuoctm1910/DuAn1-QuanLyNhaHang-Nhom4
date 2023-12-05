using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNhaHang;
using DTO_QLNhaHang;

namespace GUI_QLNhaHang
{
    public partial class HoaDonChiTiet : Form
    {
        BUS_HoaDonChiTiet busHDCT = new BUS_HoaDonChiTiet();
        DTO_HoaDonChiTiet hdct = new DTO_HoaDonChiTiet();
        public static string mahdct;
        public static string MaHD;
        public static string TenKH;
        public static string TenNV;
        public static int tongtien;
        public static int TongTienHoaDon;
        public delegate void CapNhatDuLieuHandler();
        public event CapNhatDuLieuHandler OnCapNhatDuLieu;
        public delegate void HuyHoaDonHandler();
        public event HuyHoaDonHandler OnHuyHoaDon;
        public HoaDonChiTiet(string mahd, string tenkh, string tennv, int tongtien)
        {
            InitializeComponent();
            MaHD = mahd;
            TenKH = tenkh;
            TenNV = tennv;
            TongTienHoaDon = tongtien;

            this.txtThanhTien.TextChanged += new EventHandler(txtThanhTien_TextChanged);
            this.dvgThongTinCTHD.CellValueChanged += new DataGridViewCellEventHandler(dvgThongTinCTHD_CellValueChanged);
            this.dvgThongTinCTHD.RowsRemoved += new DataGridViewRowsRemovedEventHandler(dvgThongTinCTHD_RowsRemoved);
            this.dvgThongTinCTHD.RowsAdded += new DataGridViewRowsAddedEventHandler(dvgThongTinCTHD_RowsAdded);
        }
        private void LoadData()
        {
            txtMaHD.Text = MaHD;
            txtMaHD.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTienHDBangChu.ReadOnly = true;
            dvgThongTinCTHD.DataSource = busHDCT.DanhSachHoaDonChiTietFull(MaHD);
            dvgThongTinCTHD.Columns[0].HeaderText = "Mã Hóa Đơn Chi Tiết";
            dvgThongTinCTHD.Columns[1].HeaderText = "Mã Hóa Đơn";
            dvgThongTinCTHD.Columns[2].HeaderText = "Tên Món Ăn";
            dvgThongTinCTHD.Columns[3].HeaderText = "Đơn Giá";
            dvgThongTinCTHD.Columns[4].HeaderText = "Số Lượng";
        }
        private void ResetValues()
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            cboTenMonAn.SelectedIndex = -1;
        }
        private void HoaDonChiTiet_Load(object sender, EventArgs e)
        {
            LoadData();
            cboTenMonAn.DataSource = busHDCT.LayMonAn();
            cboTenMonAn.DisplayMember = "TenMonAn";
            cboTenMonAn.ValueMember = "MaMonAn";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng");
                txtSoLuong.Focus();
            }
            else if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ. Số lượng phải là số nguyên dương.");
                txtSoLuong.Focus();
            }
            else if (cboTenMonAn.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn tên món ăn");
                cboTenMonAn.Focus();
            }
            else if (string.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn giá");
                txtDonGia.Focus();
            }
            else if (!int.TryParse(txtDonGia.Text, out int donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ. Đơn giá phải là số nguyên dương.");
                txtDonGia.Focus();
            }
            else
            {
                hdct = new DTO_HoaDonChiTiet(txtMaHD.Text, cboTenMonAn.SelectedValue.ToString(), donGia, soLuong);
                if (busHDCT.ThemHoaDonChiTiet(hdct))
                {
                    MessageBox.Show("Thêm thành công");
                    ResetValues();
                    LoadData();
                    if (busHDCT.CapNhatHoaDon(txtMaHD.Text, int.Parse(txtThanhTien.Text)))
                    {
                        OnCapNhatDuLieu?.Invoke();
                    }
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mahdct))
            {
                MessageBox.Show("Bạn chưa chọn mã hóa đơn chi tiết");
                txtMaHD.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (busHDCT.XoaHoaDonChiTiet(mahdct))
                    {
                        MessageBox.Show("Xóa thành công");
                        ResetValues();
                        LoadData();
                        if (busHDCT.CapNhatHoaDon(txtMaHD.Text, int.Parse(txtThanhTien.Text)))
                        {
                            OnCapNhatDuLieu?.Invoke();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
                else
                {
                    ResetValues();
                }

            }
        }
        private void dvgThongTinCTHD_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                TinhTongTien();
            }
        }
        private void dvgThongTinCTHD_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TinhTongTien();
        }
        private void dvgThongTinCTHD_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TinhTongTien();
        }
        private void TinhTongTien()
        {
            try
            {
                tongtien = 0;

                foreach (DataGridViewRow row in dvgThongTinCTHD.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[3].Value != null && row.Cells[4].Value != null
                            && int.TryParse(row.Cells[3].Value.ToString(), out int donGia)
                            && int.TryParse(row.Cells[4].Value.ToString(), out int soLuong))
                        {
                            tongtien += donGia * soLuong;
                        }
                    }
                }

                txtThanhTien.Text = tongtien.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private string ChuyenSoSangChu(long so)
        {
            if (so == 0) return "Không";

            string[] chuSo = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            string[] donViLon = { "", " Ngàn", " Triệu", " Tỷ" };
            string[] donViNho = { "", " Mươi", " Trăm" };

            string ketQua = "";
            int viTriDonViLon = 0;

            while (so > 0)
            {
                long baChuSo = so % 1000;
                so /= 1000;

                string baChuSoChu = "";

                if (baChuSo > 0)
                {
                    int tram = (int)(baChuSo / 100);
                    baChuSo %= 100;

                    if (tram > 0)
                    {
                        baChuSoChu += chuSo[tram] + donViNho[2];
                        if (baChuSo > 0) baChuSoChu += " và ";
                    }

                    int chuc = (int)(baChuSo / 10);
                    baChuSo %= 10;

                    if (chuc > 1)
                    {
                        baChuSoChu += chuSo[chuc] + donViNho[1] + " ";
                        if (baChuSo == 1) baChuSoChu += "Mốt";
                        else if (baChuSo > 0) baChuSoChu += chuSo[baChuSo];
                    }
                    else if (chuc == 1)
                    {
                        baChuSoChu += "Mười ";
                        if (baChuSo > 0) baChuSoChu += chuSo[baChuSo];
                    }
                    else if (baChuSo > 0)
                    {
                        if (tram != 0) baChuSoChu += "Lẻ ";
                        baChuSoChu += chuSo[baChuSo];
                    }
                }

                if (!string.IsNullOrEmpty(baChuSoChu))
                {
                    ketQua = baChuSoChu + donViLon[viTriDonViLon] + " " + ketQua;
                }

                viTriDonViLon++;
            }

            return ketQua.Trim();
        }
        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(txtThanhTien.Text, out long so))
            {
                txtTongTienHDBangChu.Text = ChuyenSoSangChu(so);
            }
            else
            {
                txtTongTienHDBangChu.Text = "Giá trị không hợp lệ";
            }
        }
        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (busHDCT.CapNhatTrangThai(txtMaHD.Text))
            {
                OnCapNhatDuLieu?.Invoke();
            }
            InHoaDon inhoadon = new InHoaDon(txtMaHD.Text, TenKH, TenNV, TongTienHoaDon);
            inhoadon.Show();
        }
        private void dvgThongTinCTHD_DoubleClick(object sender, EventArgs e)
        {
            int lst = dvgThongTinCTHD.CurrentRow.Index;
            mahdct = dvgThongTinCTHD.Rows[lst].Cells[0].Value.ToString();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn hủy hóa đơn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (busHDCT.HuyHoaDonChiTiet(txtMaHD.Text))
                {
                    MessageBox.Show("Hủy thành công");
                    OnHuyHoaDon?.Invoke();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hủy không thành công");
                }
            }
            else
            {
                ResetValues();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
