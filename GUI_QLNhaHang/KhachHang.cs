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
    public partial class KhachHang : Form
    {
        public static string vaiTro;

        BUS_KhachHang busKH = new BUS_KhachHang();
        DTO_KhachHang kh = new DTO_KhachHang();
        public KhachHang(string vaitro)
        {
            InitializeComponent();
            vaiTro = vaitro;
        }
        void LoadData()
        {
            dvThongTinKH.DataSource = busKH.DanhSachKhachHang();
            dvThongTinKH.Columns[0].HeaderText = "Mã KH";
            dvThongTinKH.Columns[1].HeaderText = "Tên KH";
            dvThongTinKH.Columns[2].HeaderText = "Ngày Sinh";
            dvThongTinKH.Columns[3].HeaderText = "Giới tính";
            dvThongTinKH.Columns[4].HeaderText = "Địa chỉ";
            dvThongTinKH.Columns[5].HeaderText = "Số điện thoại";
        }

        void ResetValues()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtTenKH.Enabled = txtSDT.Enabled = rtxtDiaChi.Enabled = dtpNgaySinh.Enabled = radNam.Enabled = radNu.Enabled = false;
            txtSDT.Clear();
            txtTimKiem.Text = "Nhập sdt khách hàng";
            rtxtDiaChi.Clear();
            radNam.Checked = false;
            radNu.Checked = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = btnSua.Enabled= btnXoa.Enabled = false;
            if (int.Parse(vaiTro) == 0)
            {
                btnXoa.Visible = false;
            }
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            LoadData();
            ResetValues();
        }

        private bool IsTenValid(string ten)
        {
            return Regex.IsMatch(ten, "^[a-zA-ZÀ-Ỹà-ỹ\\s]+$");
        }

        private bool IsSoDienThoaiExists(string sodt)
        {
            foreach (DataGridViewRow row in dvThongTinKH.Rows)
            {
                if (row.Cells[5].Value != null && row.Cells[5].Value.ToString() == sodt)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            LoadData();
            txtTenKH.Enabled = txtSDT.Enabled = rtxtDiaChi.Enabled = dtpNgaySinh.Enabled = radNam.Enabled = radNu.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void dvThongTinKH_DoubleClick(object sender, EventArgs e)
        {
            if (dvThongTinKH.Rows.Count <= 0)
            {
                MessageBox.Show("Bảng không có dữ liệu");
            }
            else
            {
                btnThem.Enabled = btnLuu.Enabled = false;
                btnSua.Enabled = btnXoa.Enabled = true;
                txtMaKH.Enabled = false;
                txtTenKH.Enabled = txtSDT.Enabled = rtxtDiaChi.Enabled = dtpNgaySinh.Enabled = radNam.Enabled = radNu.Enabled = true;
                int lst = dvThongTinKH.CurrentRow.Index;
                txtMaKH.Text = dvThongTinKH.Rows[lst].Cells[0].Value.ToString();
                txtTenKH.Text = dvThongTinKH.Rows[lst].Cells[1].Value.ToString();
                dtpNgaySinh.Text = dvThongTinKH.Rows[lst].Cells[2].Value.ToString();
                string phai = dvThongTinKH.Rows[lst].Cells[3].Value.ToString();
                if (phai == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                rtxtDiaChi.Text = dvThongTinKH.Rows[lst].Cells[4].Value.ToString();
                txtSDT.Text = dvThongTinKH.Rows[lst].Cells[5].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text.Trim();
            string phai;

            if (radNam.Checked)
            {
                phai = radNam.Text;
            }
            else
            {
                phai = radNu.Text;
            }

            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng");
                txtTenKH.Focus();
            }
            else if (!IsTenValid(txtTenKH.Text))
            {
                MessageBox.Show("Tên khách hàng không hợp lệ. Tên chỉ được chứa ký tự tiếng Việt và khoảng trắng.");
                txtTenKH.Focus();
            }
            else if (radNam.Checked == false && radNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính khách hàng");
            }
            else if (string.IsNullOrEmpty(rtxtDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                rtxtDiaChi.Focus();
            }
            else if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại khách hàng");
                txtSDT.Focus();
            }
            else if (!Regex.IsMatch(sdt, "^[0-9]+$") || sdt.Length < 10 || sdt.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại đủ 10-11 số và không chứa ký tự đặc biệt.");
                txtSDT.Focus();
            }
            else
            {
                DateTime selectdate = dtpNgaySinh.Value;
                string formatdate = selectdate.ToString("MM/dd/yyyy");
                kh = new DTO_KhachHang(txtTenKH.Text, formatdate, phai, rtxtDiaChi.Text, txtSDT.Text);
                if (busKH.CapNhatKhachHang(kh, txtMaKH.Text))
                {
                    MessageBox.Show("Sửa thành công");
                    ResetValues();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Bạn chưa chọn khách hàng");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (busKH.XoaKhachHang(txtMaKH.Text))
                    {
                        MessageBox.Show("Xóa thành công");
                        ResetValues();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
                else
                {
                    ResetValues();
                }

            }
        }
        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
            textBox.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dtSearch = busKH.TimKhachHang(txtTimKiem.Text);
            if (dtSearch.Rows.Count < 0)
            {
                MessageBox.Show("Không tìm thấy Nhân Viên");
            }
            else
            {
                MessageBox.Show("Tìm thành công");
                dvThongTinKH.DataSource = dtSearch;
                dvThongTinKH.Columns[0].HeaderText = "Mã KH";
                dvThongTinKH.Columns[1].HeaderText = "Tên KH";
                dvThongTinKH.Columns[2].HeaderText = "Ngày Sinh";
                dvThongTinKH.Columns[3].HeaderText = "Giới tính";
                dvThongTinKH.Columns[4].HeaderText = "Địa chỉ";
                dvThongTinKH.Columns[5].HeaderText = "Số điện thoại";
            }
            txtTimKiem.Text = "Nhập sdt khách hàng";
            txtTimKiem.BackColor = Color.LightGray;
            ResetValues();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text.Trim();
            string phai;

            if (radNam.Checked)
            {
                phai = radNam.Text;
            }
            else
            {
                phai = radNu.Text;
            }

            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng");
                txtTenKH.Focus();
            }
            else if (!IsTenValid(txtTenKH.Text))
            {
                MessageBox.Show("Tên khách hàng không hợp lệ. Tên chỉ được chứa ký tự tiếng Việt và khoảng trắng.");
                txtTenKH.Focus();
            }
            else if (radNam.Checked == false && radNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính khách hàng");
            }
            else if (string.IsNullOrEmpty(rtxtDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                rtxtDiaChi.Focus();
            }
            else if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại khách hàng");
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
            else
            {
                DateTime selectdate = dtpNgaySinh.Value;
                string formatdate = selectdate.ToString("MM/dd/yyyy");
                kh = new DTO_KhachHang(txtTenKH.Text, formatdate, phai, rtxtDiaChi.Text, txtSDT.Text);
                if (busKH.ThemKhachHang(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    ResetValues();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }
    }
}
