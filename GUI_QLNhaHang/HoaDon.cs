using BUS_QLNhaHang;
using DTO_QLNhaHang;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLNhaHang
{
    public partial class HoaDon : Form
    {
        BUS_HoaDon busHD = new BUS_HoaDon();
        DTO_HoaDon HD = new DTO_HoaDon();
        public static string vaiTro;
        public HoaDon(string vaitro)
        {
            InitializeComponent();
            LayNhanVien();
            LayKhachHang();
            LayBanAnConTrong();
            vaiTro = vaitro;
        }
        private void LoadDataHD()
        {
            dtvDanhSachHoaDon.DataSource = busHD.DanhSachHoaDon();
            dtvDanhSachHoaDon.Columns[0].HeaderText = "Mã Hóa Đơn";
            dtvDanhSachHoaDon.Columns[1].HeaderText = "Tên Nhân Viên";
            dtvDanhSachHoaDon.Columns[2].HeaderText = "Tên Khách Hàng";
            dtvDanhSachHoaDon.Columns[3].HeaderText = "Tên Bàn Ăn";
            dtvDanhSachHoaDon.Columns[4].HeaderText = "Ngày Lập";
            dtvDanhSachHoaDon.Columns[5].HeaderText = "Trạng Thái";
            dtvDanhSachHoaDon.Columns[6].HeaderText = "Tổng Tiền";
            dtvDanhSachHoaDon.Columns[7].HeaderText = "Giảm Giá";
        }
        void LayNhanVien()
        {
            cboNhanVien.DataSource = busHD.LayNguoiDung();
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "MaNV";
        }
        void LayKhachHang()
        {
            cboKhachHang.DataSource = busHD.LayKhachHang();
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
        }
        void LayBanAn()
        {
            cboBanAn.DataSource = busHD.LayBanAn();
            cboBanAn.DisplayMember = "TenBanAn";
            cboBanAn.ValueMember = "MaBanAn";
        }
        void LayBanAnConTrong()
        {
            cboBanAn.DataSource = busHD.LayBanAnConTrong();
            cboBanAn.DisplayMember = "TenBanAn";
            cboBanAn.ValueMember = "MaBanAn";
        }
        private void ResetValue()
        {
            if (int.Parse(vaiTro) == 0)
            {
                btnSua.Visible = false;
                btnXoa.Visible = false;
            }
            txtMaHoaDon.Clear();
            txtGiamGia.Clear();
            txtTimKiem.Clear();
            txtMaHoaDon.Enabled = false;
            txtGiamGia.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtTimKiem.Text = "Nhập mã hóa đơn muốn tìm";
            txtTrangThai.Text = "Chưa in";
            txtTrangThai.ReadOnly = true;
            cboBanAn.SelectedIndex = cboKhachHang.SelectedIndex = cboNhanVien.SelectedIndex = -1;
            cboBanAn.Enabled = cboKhachHang.Enabled = cboNhanVien.Enabled = false;
            dtpNgayLap.Enabled = false;
            this.Refresh();
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadDataHD();
            ResetValue();
        }
        private void dtvDanhSachHoaDon_DoubleClick(object sender, EventArgs e)
        {
            if (dtvDanhSachHoaDon.RowCount == 0)
            {
                MessageBox.Show("Bảng không có dữ liệu");
            }
            else
            {
                if (int.Parse(vaiTro) == 0)
                {
                    btnSua.Enabled = false;
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                }
                else
                {
                    cboBanAn.Enabled = false;
                    cboKhachHang.Enabled = false;
                    cboNhanVien.Enabled = false;
                    txtMaHoaDon.Enabled = false;
                    btnSua.Enabled = true;
                    btnThem.Enabled = false;
                    btnLuu.Enabled = false;
                    btnXoa.Enabled = true;
                    dtpNgayLap.Enabled = true;
                    txtGiamGia.Enabled = true;
                    LayBanAn();
                }
                int lst = dtvDanhSachHoaDon.CurrentRow.Index;
                txtMaHoaDon.Text = dtvDanhSachHoaDon.Rows[lst].Cells[0].Value.ToString();
                cboNhanVien.Text = dtvDanhSachHoaDon.Rows[lst].Cells[1].Value.ToString();
                cboKhachHang.Text = dtvDanhSachHoaDon.Rows[lst].Cells[2].Value.ToString();
                cboBanAn.Text = dtvDanhSachHoaDon.Rows[lst].Cells[3].Value.ToString();
                dtpNgayLap.Text = dtvDanhSachHoaDon.Rows[lst].Cells[4].Value.ToString();
                txtTrangThai.Text = dtvDanhSachHoaDon.Rows[lst].Cells[5].Value.ToString();
                txtGiamGia.Text = dtvDanhSachHoaDon.Rows[lst].Cells[7].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            cboBanAn.Enabled = cboKhachHang.Enabled = cboNhanVien.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            dtpNgayLap.Enabled = true;
            txtGiamGia.Enabled = true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int giamGia;
            bool isInt = int.TryParse(txtGiamGia.Text, out giamGia);

            if (string.IsNullOrEmpty(cboNhanVien.Text))
            {
                MessageBox.Show("Bạn chưa chọn nhân viên");
                cboNhanVien.Focus();
            }
            else if (string.IsNullOrEmpty(cboKhachHang.Text))
            {
                MessageBox.Show("Bạn chưa chọn khách hàng");
                cboKhachHang.Focus();
            }
            else if (string.IsNullOrEmpty(cboBanAn.Text))
            {
                MessageBox.Show("Bạn chưa chọn bàn ăn");
                cboBanAn.Focus();
            }
            else if (string.IsNullOrEmpty(txtGiamGia.Text))
            {
                MessageBox.Show("Bạn chưa nhập giảm giá");
                txtGiamGia.Focus();
            }
            else if (!isInt || int.Parse(txtGiamGia.Text) < 0 || Regex.IsMatch(txtGiamGia.Text, "[a-zA-Z!@#$%^&*()]"))
            {
                MessageBox.Show("Giảm giá không hợp lệ. Giảm giá phải là số nguyên dương và không chứa chữ cái hoặc ký tự đặc biệt.");
                txtGiamGia.Focus();
            }
            else
            {
                string cbond = cboNhanVien.SelectedValue.ToString();
                string cbokh = cboKhachHang.SelectedValue.ToString();
                string cboba = cboBanAn.SelectedValue.ToString();
                HD = new DTO_HoaDon(cbond, cbokh, cboba, dtpNgayLap.Text, txtTrangThai.Text, giamGia);
                if (busHD.CapNhatHoaDon(HD, txtMaHoaDon.Text))
                {
                    MessageBox.Show("Cập nhật hóa đơn thành công!");
                    LoadDataHD();
                    ResetValue();
                }
                else
                {
                    MessageBox.Show("Cập nhật hóa đơn thất bại!!!");
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHoaDon.Text))
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần xóa");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (busHD.XoaHoaDon(HD, txtMaHoaDon.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    ResetValue();
                    LoadDataHD();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                ResetValue();
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timkiem = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(timkiem))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn muốn tìm");
                ResetValue();
                txtTimKiem.Focus();
            }
            else if (timkiem.Length != 6 || !Regex.IsMatch(timkiem, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Mã hóa đơn không hợp lệ. Mã hóa đơn phải có đúng 6 ký tự và không chứa ký tự đặc biệt.");
                ResetValue();
                txtTimKiem.Focus();
            }
            else
            {
                DataTable dtSearch = busHD.SearchHoaDon(timkiem);
                if (dtSearch.Rows.Count > 0)
                {
                    MessageBox.Show("Tìm thành công");
                    dtvDanhSachHoaDon.DataSource = dtSearch;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Người Dùng");
                }
            }
        }
        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
            textBox.Text = ""; 
        }
        private void btnChiTietHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHoaDon.Text))
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn để xem chi tiết");
            }
            else
            {
                int lst = dtvDanhSachHoaDon.CurrentRow.Index;
                string trangthai = dtvDanhSachHoaDon.Rows[lst].Cells[5].Value.ToString();
                if (trangthai == "Đã hủy hóa đơn")
                {
                    MessageBox.Show("Hóa đơn này đã được hủy");
                }
                else
                {
                    
                    HoaDonChiTiet hdct = new HoaDonChiTiet(txtMaHoaDon.Text, dtvDanhSachHoaDon.Rows[lst].Cells[2].Value.ToString(), dtvDanhSachHoaDon.Rows[lst].Cells[1].Value.ToString(), (int)dtvDanhSachHoaDon.Rows[lst].Cells[7].Value);
                    hdct.OnCapNhatDuLieu += LoadDataHD;
                    hdct.OnHuyHoaDon += LoadDataHD;
                    hdct.Show();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)

        {
            int giamGia;
            bool isInt = int.TryParse(txtGiamGia.Text, out giamGia);

            if (string.IsNullOrEmpty(cboNhanVien.Text))
            {
                MessageBox.Show("Bạn chưa chọn nhân viên");
                cboNhanVien.Focus();
            }
            else if (string.IsNullOrEmpty(cboKhachHang.Text))
            {
                MessageBox.Show("Bạn chưa chọn khách hàng");
                cboKhachHang.Focus();
            }
            else if (string.IsNullOrEmpty(cboBanAn.Text))
            {
                MessageBox.Show("Bạn chưa chọn bàn ăn");
                cboBanAn.Focus();
            }
            else if (string.IsNullOrEmpty(txtGiamGia.Text))
            {
                MessageBox.Show("Bạn chưa nhập giảm giá");
                txtGiamGia.Focus();
            }
            else if (!isInt || int.Parse(txtGiamGia.Text) < 0 || Regex.IsMatch(txtGiamGia.Text, "[a-zA-Z!@#$%^&*()]"))
            {
                MessageBox.Show("Giảm giá không hợp lệ. Giảm giá phải là số nguyên dương và không chứa chữ cái hoặc ký tự đặc biệt.");
                txtGiamGia.Focus();
            }
            else
            {
                string cbond = cboNhanVien.SelectedValue.ToString();
                string cbokh = cboKhachHang.SelectedValue.ToString();
                string cboba = cboBanAn.SelectedValue.ToString();
                HD = new DTO_HoaDon(cbond, cbokh, cboba, dtpNgayLap.Text, txtTrangThai.Text, giamGia);

                if (busHD.ThemHoaDon(HD, 0))
                {
                    MessageBox.Show("Thêm hóa đơn thành công!");
                    LoadDataHD();
                    LayBanAnConTrong();
                    ResetValue();
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thất bại!!!");
                }
            }
        }
    }
}
