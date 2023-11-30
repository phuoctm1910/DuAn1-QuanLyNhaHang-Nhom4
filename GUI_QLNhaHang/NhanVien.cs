using BUS_QLNhaHang;
using DTO_QLNhaHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLNhaHang
{
    public partial class NhanVien : Form
    {
        BUS_NguoiDung busND = new BUS_NguoiDung();
        DTO_NguoiDung ND = new DTO_NguoiDung();
        public NhanVien()
        {
            InitializeComponent();
            LayVaiTro();
            LayCapDoLuong();
            LayLichLam();
        }

        void LayVaiTro()
        {
            cboChucVu.DataSource = busND.LayVaiTro();
            cboChucVu.DisplayMember = "TenChucVu";
            cboChucVu.ValueMember = "id";

        }

        void LayCapDoLuong()
        {
            cboLuong.DataSource = busND.LayCapDoLuong();
            cboLuong.DisplayMember = "Luong";
            cboLuong.ValueMember = "id";
        }

        void LayLichLam()
        {
            cboNgayVaoLam.DataSource = busND.LayLichLam();
            cboNgayVaoLam.DisplayMember = "LichLam";
            cboNgayVaoLam.ValueMember = "id";
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadDataND();
            ResetValue();
            txtManv.Enabled = false;

        }

        private void LoadDataND()
        {
            dtvDanhSachNhanVien.DataSource = busND.DanhSachNguoiDung();
            dtvDanhSachNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            dtvDanhSachNhanVien.Columns[1].HeaderText = "Tài Khoản";
            dtvDanhSachNhanVien.Columns[2].HeaderText = "Mật Khẩu";
            dtvDanhSachNhanVien.Columns[3].HeaderText = "Tên Nhân Viên";
            dtvDanhSachNhanVien.Columns[4].HeaderText = "Giới Tính";
            dtvDanhSachNhanVien.Columns[5].HeaderText = "Địa Chỉ";
            dtvDanhSachNhanVien.Columns[6].HeaderText = "SĐT";
            dtvDanhSachNhanVien.Columns[7].HeaderText = "Ngày Sinh";
            dtvDanhSachNhanVien.Columns[8].HeaderText = "Ngày Vào Làm";
            dtvDanhSachNhanVien.Columns[9].HeaderText = "Chức Vụ";
            dtvDanhSachNhanVien.Columns[10].HeaderText = "Lương";

            cboNgayVaoLam.SelectedIndex = -1;
            cboLuong.SelectedIndex = -1;
            cboChucVu.SelectedIndex = -1;
            dtvDanhSachNhanVien.CellFormatting += dtvDanhSachNhanVien_CellFormatting;
        }

        private void dtvDanhSachNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null) // Kiểm tra nếu là cột Mật Khẩu
            {
                e.Value = new string('*', e.Value.ToString().Length); // Thay thế giá trị bằng ***
            }
        }

        private void ResetValue()
        {
            txtTenNhanVien.Clear();
            txtManv.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            txtSDT.Clear();
            rtbDiaChi.Clear();
            txtTimKiem.Text = "Nhập tên NV";

            cboNgayVaoLam.Text = null;
            cboLuong.SelectedIndex = -1;
            cboChucVu.SelectedIndex = -1;
        }

        private void dtvDanhSachNhanVien_DoubleClick(object sender, EventArgs e)
        {
            txtMatKhau.Enabled = false;
            txtManv.Enabled = false;
            int lst = dtvDanhSachNhanVien.CurrentRow.Index;
            txtManv.Text = dtvDanhSachNhanVien.Rows[lst].Cells[0].Value.ToString();
            txtTaiKhoan.Text = dtvDanhSachNhanVien.Rows[lst].Cells[1].Value.ToString();
            txtMatKhau.Text = dtvDanhSachNhanVien.Rows[lst].Cells[2].Value.ToString();
            txtTenNhanVien.Text = dtvDanhSachNhanVien.Rows[lst].Cells[3].Value.ToString();
            string phai = dtvDanhSachNhanVien.Rows[lst].Cells[4].Value.ToString();
            if (phai == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            rtbDiaChi.Text = dtvDanhSachNhanVien.Rows[lst].Cells[5].Value.ToString();
            txtSDT.Text = dtvDanhSachNhanVien.Rows[lst].Cells[6].Value.ToString();
            dtpNgaySinh.Text = dtvDanhSachNhanVien.Rows[lst].Cells[7].Value.ToString();
            string ngaylam = dtvDanhSachNhanVien.Rows[lst].Cells[8].Value.ToString();
            if (ngaylam == "0")
            {
                cboNgayVaoLam.SelectedIndex = 0;
            }
            else
            {
                cboNgayVaoLam.SelectedIndex = 1;
            }

            string chucvu = dtvDanhSachNhanVien.Rows[lst].Cells[9].Value.ToString();
            if (chucvu == "0")
            {
                cboChucVu.SelectedIndex = 0;
            }
            else
            {
                cboChucVu.SelectedIndex = 1;
            }

            string luong = dtvDanhSachNhanVien.Rows[lst].Cells[10].Value.ToString();
            if (luong == "0")
            {
                cboLuong.SelectedIndex = 0;
            }
            else
            {
                cboLuong.SelectedIndex = 1;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            float intDienThoai;
            bool isInt = float.TryParse(txtSDT.Text.Trim().ToString(), out intDienThoai);
            string phai;


            if (radNam.Checked)
            { phai = radNam.Text; }
            else
            { phai = radNu.Text; }
            if (string.IsNullOrEmpty(txtTenNhanVien.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên");
                txtTenNhanVien.Focus();
            }
            else if (string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");
                txtTaiKhoan.Focus();
            }
            else if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                txtMatKhau.Focus();
            }
            else if (string.IsNullOrEmpty(cboChucVu.Text))
            {
                MessageBox.Show("Bạn chưa chọn chức vụ");
                cboChucVu.Focus();
            }
            else if (radNam.Checked == false && radNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính nhân viên");
                cboChucVu.Focus();
            }
            else if (string.IsNullOrEmpty(rtbDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                rtbDiaChi.Focus();
            }
            else if (!isInt || float.Parse(txtSDT.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số lớn hơn 0 và phải là số nguyên");
                txtSDT.Focus();
            }
            else if (txtSDT.TextLength < 10)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại đủ 10-11 số");
                txtSDT.Focus();
            }
            else if (string.IsNullOrEmpty(dtpNgaySinh.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày sinh");
                dtpNgaySinh.Focus();
            }
            else if (string.IsNullOrEmpty(cboNgayVaoLam.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày vào làm");
                cboNgayVaoLam.Focus();
            }
            else if (string.IsNullOrEmpty(cboLuong.Text))
            {
                MessageBox.Show("Bạn chưa chọn mức độ lương cho nhân viên");
                cboLuong.Focus();
            }
            else
            {

                string matkhaumd5 = busND.Encryption(txtMatKhau.Text);
                ND = new DTO_NguoiDung(txtTaiKhoan.Text, matkhaumd5, txtTenNhanVien.Text, phai, rtbDiaChi.Text,
                    txtSDT.Text, dtpNgaySinh.Text, cboNgayVaoLam.SelectedIndex, cboChucVu.SelectedIndex, cboLuong.SelectedIndex);
                if (busND.ThemNguoiDung(ND))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    LoadDataND();
                    ResetValue();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!!!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            float intDienThoai;
            bool isInt = float.TryParse(txtSDT.Text.Trim().ToString(), out intDienThoai);
            string phai;


            if (radNam.Checked)
            { phai = radNam.Text; }
            else
            { phai = radNu.Text; }
            if (string.IsNullOrEmpty(txtTenNhanVien.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên");
                txtTenNhanVien.Focus();
            }
            else if (string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");
                txtTaiKhoan.Focus();
            }
            else if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                txtMatKhau.Focus();
            }
            else if (string.IsNullOrEmpty(cboChucVu.Text))
            {
                MessageBox.Show("Bạn chưa chọn chức vụ");
                cboChucVu.Focus();
            }
            else if (radNam.Checked == false && radNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính nhân viên");
                cboChucVu.Focus();
            }
            else if (string.IsNullOrEmpty(rtbDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                rtbDiaChi.Focus();
            }
            else if (!isInt || float.Parse(txtSDT.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số lớn hơn 0 và phải là số nguyên");
                txtSDT.Focus();
            }
            else if (txtSDT.TextLength < 10)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại đủ 10-11 số");
                txtSDT.Focus();
            }
            else if (string.IsNullOrEmpty(dtpNgaySinh.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày sinh");
                dtpNgaySinh.Focus();
            }
            else if (string.IsNullOrEmpty(cboNgayVaoLam.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày vào làm");
                cboNgayVaoLam.Focus();
            }
            else if (string.IsNullOrEmpty(cboLuong.Text))
            {
                MessageBox.Show("Bạn chưa chọn mức độ lương cho nhân viên");
                cboLuong.Focus();
            }
            else
            {
                string matkhaumd5 = busND.Encryption(txtMatKhau.Text);
                ND = new DTO_NguoiDung(txtTaiKhoan.Text, matkhaumd5, txtTenNhanVien.Text, phai, rtbDiaChi.Text,
                    txtSDT.Text, dtpNgaySinh.Text, cboNgayVaoLam.SelectedIndex, cboChucVu.SelectedIndex, cboLuong.SelectedIndex);
                DialogResult result = MessageBox.Show("Bạn có thật sự muốn sửa không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (busND.CapNhatNguoiDung(ND, txtManv.Text))
                {
                    MessageBox.Show("Sữa thông tin nhân viên thành công!");
                    LoadDataND();
                    ResetValue();
                }
                else
                {
                    MessageBox.Show("Sữa thông tin thất bại!!!");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadDataND();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (busND.XoaNguoiDung(ND, txtManv.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    ResetValue();
                    LoadDataND();
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
            DataTable dtSearch = busND.SearchNguoiDung(ND, txtManv.Text);
            if (dtSearch.Rows.Count > 0)
            {
                MessageBox.Show("Tìm thành công");
                dtvDanhSachNhanVien.DataSource = dtSearch;
            }
            else
            {
                MessageBox.Show("Không tìm thấy Người Dùng");
            }
            ResetValue();
        }

      
    }
}
