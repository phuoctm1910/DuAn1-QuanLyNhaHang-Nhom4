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
using System.Text.RegularExpressions;

namespace GUI_QLNhaHang
{
    public partial class NguoiDung : Form
    {
        public static string taiKhoan;
        public static string vaiTro;
        BUS_NguoiDung busND = new BUS_NguoiDung();
        DTO_NguoiDung ND = new DTO_NguoiDung();
        public NguoiDung(string vaitro, string taikhoan)
        {
            InitializeComponent();
            LayVaiTro();
            LayCapDoLuong();
            LayLichLam();
            taiKhoan = taikhoan;
            vaiTro = vaitro;
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
            cboLichLam.DataSource = busND.LayLichLam();
            cboLichLam.DisplayMember = "LichLam";
            cboLichLam.ValueMember = "id";
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadDataND();
            ResetValue();
            txtManv.Enabled = false;
        }

        private void LoadDataND()
        {
            if (int.Parse(vaiTro) == 0)
            {
                dtvDanhSachNhanVien.DataSource = busND.DanhSachNguoiDungNV(taiKhoan);
            }
            else
            {
                dtvDanhSachNhanVien.DataSource = busND.DanhSachNguoiDung();
            }
            dtvDanhSachNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            dtvDanhSachNhanVien.Columns[1].HeaderText = "Tài Khoản";
            dtvDanhSachNhanVien.Columns[2].HeaderText = "Mật Khẩu";
            dtvDanhSachNhanVien.Columns[3].HeaderText = "Tên Nhân Viên";
            dtvDanhSachNhanVien.Columns[4].HeaderText = "Giới Tính";
            dtvDanhSachNhanVien.Columns[5].HeaderText = "Địa Chỉ";
            dtvDanhSachNhanVien.Columns[6].HeaderText = "SĐT";
            dtvDanhSachNhanVien.Columns[7].HeaderText = "Ngày Sinh";
            dtvDanhSachNhanVien.Columns[8].HeaderText = "Ngày Vào Làm";
            dtvDanhSachNhanVien.Columns[9].HeaderText = "Lịch Làm";
            dtvDanhSachNhanVien.Columns[10].HeaderText = "Chức Vụ";
            dtvDanhSachNhanVien.Columns[11].HeaderText = "Lương";

            cboLichLam.SelectedIndex = -1;
            cboLuong.SelectedIndex = -1;
            cboChucVu.SelectedIndex = -1;
            dtvDanhSachNhanVien.CellFormatting += dtvDanhSachNhanVien_CellFormatting;
        }

        private void dtvDanhSachNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
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
            txtTimKiem.Text = "Nhập mã NV";
            txtMatKhau.Enabled = true;
            txtTaiKhoan.Enabled = true;
            radNam.Checked = false;
            radNu.Checked = false;
            cboLichLam.Text = null;
            cboLuong.SelectedIndex = -1;
            cboChucVu.SelectedIndex = -1;
            txtTenNhanVien.Enabled = txtManv.Enabled = txtMatKhau.Enabled = txtTaiKhoan.Enabled = txtSDT.Enabled = rtbDiaChi.Enabled
            = radNam.Enabled = radNu.Enabled = cboChucVu.Enabled = cboLuong.Enabled = cboLichLam.Enabled = dtpNgaySinh.Enabled = dtpNgayVaoLam.Enabled = false;
            btnLuu.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            if (int.Parse(vaiTro) == 0)
            {
                btnThem.Visible = btnSua.Visible = btnXoa.Visible = btnThemNgayVaoLam.Visible = btnLuu.Visible = txtTimKiem.Visible = btnTimKiem.Visible = false;
            }
        }

        private void dtvDanhSachNhanVien_DoubleClick(object sender, EventArgs e)
        {
            if (int.Parse(vaiTro) == 0)
            {
                MessageBox.Show("Bạn không thể thực hiện hành động vì bạn là nhân viên");
            }
            else
            {
                txtTenNhanVien.Enabled = txtMatKhau.Enabled = txtTaiKhoan.Enabled = txtSDT.Enabled = rtbDiaChi.Enabled
                = radNam.Enabled = radNu.Enabled = cboChucVu.Enabled = cboLuong.Enabled = cboLichLam.Enabled = dtpNgaySinh.Enabled = dtpNgayVaoLam.Enabled = true;
                btnThem.Enabled = btnLuu.Enabled = false;
                btnSua.Enabled = btnXoa.Enabled = true;
                txtMatKhau.Enabled = false;
                txtManv.Enabled = false;
                txtTaiKhoan.Enabled = false;
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
                dtpNgayVaoLam.Text= dtvDanhSachNhanVien.Rows[lst].Cells[8].Value.ToString();

                DateTime lichLam = (DateTime)dtvDanhSachNhanVien.Rows[lst].Cells[9].Value;
                string lichLamFormatted = lichLam.ToString("MM/dd/yyyy");
                cboLichLam.Text = lichLamFormatted;

                cboChucVu.Text = dtvDanhSachNhanVien.Rows[lst].Cells[10].Value.ToString();
                

                cboLuong.Text = dtvDanhSachNhanVien.Rows[lst].Cells[11].Value.ToString();

                LayLichLam();
            }
        }

        private bool IsTaiKhoanExists(string taiKhoan)
        {
            foreach (DataGridViewRow row in dtvDanhSachNhanVien.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == taiKhoan)
                {
                    return true;
                }
            }
            return false; 
        }

        private bool IsSoDienThoaiExists(string sodt)
        {
            foreach (DataGridViewRow row in dtvDanhSachNhanVien.Rows)
            {
                if (row.Cells[6].Value != null && row.Cells[6].Value.ToString() == sodt)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsTenNhanVienValid(string ten)
        {
            return Regex.IsMatch(ten, "^[a-zA-ZÀ-Ỹà-ỹ\\s]+$");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadDataND();
            btnLuu.Enabled = true;
            txtTenNhanVien.Enabled = txtMatKhau.Enabled = txtTaiKhoan.Enabled = txtSDT.Enabled = rtbDiaChi.Enabled
            = radNam.Enabled = radNu.Enabled = cboChucVu.Enabled = cboLuong.Enabled = cboLichLam.Enabled = dtpNgaySinh.Enabled = dtpNgayVaoLam.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txtTenNhanVien.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string taiKhoan = txtTaiKhoan.Text.Trim();

            if (string.IsNullOrEmpty(tenNhanVien))
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên");
                txtTenNhanVien.Focus();
            }
            else if (!IsTenNhanVienValid(tenNhanVien))
            {
                MessageBox.Show("Tên nhân viên không hợp lệ. Tên chỉ được chứa chữ cái tiếng Việt và khoảng trắng.");
                txtTenNhanVien.Focus();
            }
            else if (string.IsNullOrEmpty(taiKhoan) || taiKhoan.Length < 5)
            {
                MessageBox.Show("Bạn chưa nhập tài khoản và tài khoản phải dài hơn hoặc bằng 5 kí tự");
                txtTaiKhoan.Focus();
            }
            else if (string.IsNullOrEmpty(cboChucVu.Text))
            {
                MessageBox.Show("Bạn chưa chọn chức vụ");
                cboChucVu.Focus();
            }
            else if (!(radNam.Checked || radNu.Checked))
            {
                MessageBox.Show("Bạn chưa chọn giới tính nhân viên");
                cboChucVu.Focus();
            }
            else if (string.IsNullOrEmpty(rtbDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                rtbDiaChi.Focus();
            }
            else if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại");
                txtSDT.Focus();
            }
            else if (!Regex.IsMatch(sdt, "^[0-9]+$") || sdt.Length < 10 || sdt.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại đủ 10-11 số và không chứa ký tự đặc biệt.");
                txtSDT.Focus();
            }
            else if (string.IsNullOrEmpty(cboLichLam.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày vào làm");
                cboLichLam.Focus();
            }
            else if (string.IsNullOrEmpty(cboLuong.Text))
            {
                MessageBox.Show("Bạn chưa chọn mức độ lương cho nhân viên");
                cboLuong.Focus();
            }
            else
            {
                string phai = radNam.Checked ? radNam.Text : radNu.Text;
                string matkhaumd5 = busND.Encryption(txtMatKhau.Text);
                ND = new DTO_NguoiDung(txtTaiKhoan.Text, matkhaumd5, tenNhanVien, phai, rtbDiaChi.Text,
                    sdt, dtpNgaySinh.Text, dtpNgayVaoLam.Text , cboLichLam.SelectedIndex, cboChucVu.SelectedIndex, cboLuong.SelectedIndex);

                if (busND.CapNhatNguoiDung(ND, txtManv.Text))
                {
                    MessageBox.Show("Sửa nhân viên thành công!");
                    LoadDataND();
                    ResetValue();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!!!");
                }
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (txtTaiKhoan.Text == taiKhoan)
                {
                    MessageBox.Show("Bạn đang sử dụng người dùng này");
                }
                else
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
                
            }
            else
            {
                ResetValue();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dtSearch = busND.SearchNguoiDung(txtTimKiem.Text);
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

        private void btnThemNgayVaoLam_Click(object sender, EventArgs e)
        {
            LichLam ll = new LichLam(vaiTro);
            ll.Show();
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
            textBox.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txtTenNhanVien.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tenNhanVien))
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên");
                txtTenNhanVien.Focus();
            }
            else if (!IsTenNhanVienValid(tenNhanVien))
            {
                MessageBox.Show("Tên nhân viên không hợp lệ. Tên chỉ được chứa chữ cái tiếng Việt và khoảng trắng.");
                txtTenNhanVien.Focus();
            }
            else if (string.IsNullOrEmpty(taiKhoan) || taiKhoan.Length < 5)
            {
                MessageBox.Show("Bạn chưa nhập tài khoản và tài khoản phải dài hơn hoặc bằng 5 kí tự");
                txtTaiKhoan.Focus();
            }
            else if (IsTaiKhoanExists(taiKhoan))
            {
                MessageBox.Show("Tài khoản đã tồn tại. Vui lòng nhập tài khoản khác.");
                txtTaiKhoan.Focus();
            }
            else if (string.IsNullOrEmpty(matkhau) || matkhau.Length < 6)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu và phải dài hơn 6 kí tự");
                txtMatKhau.Focus();
            }
            else if (string.IsNullOrEmpty(cboChucVu.Text))
            {
                MessageBox.Show("Bạn chưa chọn chức vụ");
                cboChucVu.Focus();
            }
            else if (!(radNam.Checked || radNu.Checked))
            {
                MessageBox.Show("Bạn chưa chọn giới tính nhân viên");
                cboChucVu.Focus();
            }
            else if (string.IsNullOrEmpty(rtbDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                rtbDiaChi.Focus();
            }
            else if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại");
                txtSDT.Focus();
            }
            else if (!Regex.IsMatch(sdt, "^[0-9]+$") || sdt.Length < 10 || sdt.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại đủ 10-11 số và không chứa ký tự đặc biệt.");
                txtSDT.Focus();
            }
            else if (IsSoDienThoaiExists(sdt))
            {
                MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số điện thoại khác.");
                txtSDT.Focus();
            }
            else if (string.IsNullOrEmpty(cboLichLam.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày vào làm");
                cboLichLam.Focus();
            }
            else if (string.IsNullOrEmpty(cboLuong.Text))
            {
                MessageBox.Show("Bạn chưa chọn mức độ lương cho nhân viên");
                cboLuong.Focus();
            }
            else
            {
                string phai = radNam.Checked ? radNam.Text : radNu.Text;
                string matkhaumd5 = busND.Encryption(txtMatKhau.Text);
                ND = new DTO_NguoiDung(txtTaiKhoan.Text, matkhaumd5, tenNhanVien, phai, rtbDiaChi.Text,
                    sdt, dtpNgaySinh.Text, dtpNgayVaoLam.Text, cboLichLam.SelectedIndex, cboChucVu.SelectedIndex, cboLuong.SelectedIndex);

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
    }
}
