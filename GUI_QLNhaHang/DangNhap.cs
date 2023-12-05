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
    public partial class DangNhap : Form
    {
        BUS_NguoiDung bus_nd = new BUS_NguoiDung();
        public string vaiTro { set; get; }
        public DangNhap()
        {
            InitializeComponent();
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
            chbLuuTTDN.Checked = true;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();
            if (!string.IsNullOrWhiteSpace(taiKhoan) &&
                !string.IsNullOrWhiteSpace(matkhau))
            {
                string encryptedPassword = bus_nd.Encryption(matkhau);
                if (bus_nd.NguoiDungDangNhap(taiKhoan, encryptedPassword))
                {
                    DataTable dt = bus_nd.VaiTroNguoiDung(taiKhoan);
                    if (dt.Rows.Count > 0)
                    {
                        vaiTro = dt.Rows[0][0].ToString();
                        Main frmMain = new Main(taiKhoan, vaiTro, 1);
                        MessageBox.Show("Đăng nhập thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        frmMain.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaiKhoan.Text = null;
                    txtMatKhau.Text = null;
                    txtTaiKhoan.Focus();
                }
            }
            else if (string.IsNullOrEmpty(taiKhoan) || taiKhoan.Length < 5)
            {
                MessageBox.Show("Bạn chưa nhập tài khoản và tài khoản phải dài hơn hoặc bằng 5 kí tự");
                txtTaiKhoan.Focus();
            }
            else if (string.IsNullOrEmpty(matkhau) || matkhau.Length < 6)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu và phải dài hơn 6 kí tự");
                txtMatKhau.Focus();
            }
            else
            {
                MessageBox.Show("Không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hệ thống không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
