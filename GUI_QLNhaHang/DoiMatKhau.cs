using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNhaHang;
namespace GUI_QLNhaHang
{
    public partial class DoiMatKhau : Form
    {
        BUS_NguoiDung bus_nd = new BUS_NguoiDung();
        public static string TaiKhoan;
        public DoiMatKhau(string tk)
        {
            InitializeComponent();
            TaiKhoan = tk;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMKCu.Text) &&
                    !string.IsNullOrWhiteSpace(txtMKMoi.Text) &&
                    !string.IsNullOrWhiteSpace(txtNhapLaiMK.Text))
            {
                if (txtMKMoi.Text == txtMKCu.Text)
                {
                    MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtNhapLaiMK.Text != txtMKMoi.Text)
                {
                    MessageBox.Show("Mật khẩu mới được nhập lại sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if ( txtMKCu.Text.Length < 6 || txtMKMoi.Text.Length < 6 || txtNhapLaiMK.Text.Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải chứa ít nhất 6 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

                string encryptedOldPassword = bus_nd.Encryption(txtMKCu.Text);
                string encryptedNewPassword = bus_nd.Encryption(txtMKMoi.Text);

                if (!bus_nd.NguoiDungDoiMatKhau(TaiKhoan, encryptedOldPassword, encryptedNewPassword))
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
