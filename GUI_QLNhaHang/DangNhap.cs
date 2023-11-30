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
            DTO_NguoiDung nd = new DTO_NguoiDung();

            nd.taikhoan = txtTaiKhoan.Text;
            nd.matkhau = bus_nd.Encryption(txtMatKhau.Text);
            if (!string.IsNullOrWhiteSpace(txtTaiKhoan.Text) &&
                !string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                if (bus_nd.NguoiDungDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
                {
                    DataTable dt = bus_nd.VaiTroNguoiDung(txtTaiKhoan.Text);
                    if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
                    {
                        vaiTro = dt.Rows[0][0].ToString();
                        frmMain frmMain = new frmMain(txtTaiKhoan.Text, vaiTro, 1);
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
            else
            {
                MessageBox.Show("Không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
