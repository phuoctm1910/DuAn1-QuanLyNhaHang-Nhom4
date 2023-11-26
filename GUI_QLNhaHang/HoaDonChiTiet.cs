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
using DTO_QLNhaHang;

namespace GUI_QLNhaHang
{
    public partial class HoaDonChiTiet : Form
    {
        BUS_HoaDonChiTiet busHDCT = new BUS_HoaDonChiTiet();
        DTO_HoaDonChiTiet hdct = new DTO_HoaDonChiTiet();
        public HoaDonChiTiet()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dvgThongTinCTHD.DataSource = busHDCT.DanhSachHoaDonChiTiet();
            dvgThongTinCTHD.Columns[0].HeaderText = "Mã Hóa Đơn";
            dvgThongTinCTHD.Columns[1].HeaderText = "Tên Món Ăn";
            dvgThongTinCTHD.Columns[2].HeaderText = "Số Lượng";
            dvgThongTinCTHD.Columns[3].HeaderText = "Đơn Giá";
            dvgThongTinCTHD.Columns[4].HeaderText = "Thành Tiền";
            dvgThongTinCTHD.Columns[5].HeaderText = "Tổng Tiền Hóa Đơn Bằng Chữ";
        }
        private void ResetValues()
        {
            txtMaHD.Clear();
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtThanhTien.Clear();
            txtTongTienHDBangChu.Clear();
            cboTenMonAn.SelectedIndex = -1;
        }

        private void HoaDonChiTiet_Load(object sender, EventArgs e)
        {
            LoadData();
            cboTenMonAn.DataSource = busHDCT.DanhSachHoaDonChiTiet();
            cboTenMonAn.DisplayMember = "TenMon";
            cboTenMonAn.ValueMember = "MaMonAn";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenMA = cboTenMonAn.SelectedValue.ToString();
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Hóa Đơn");
                txtMaHD.Focus();
            }
            else if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Số Lượng");
                txtSoLuong.Focus();
            }
            else if (cboTenMonAn.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Chưa Chọn Tên Món Ăn");
                cboTenMonAn.Focus();
            }
            else if (string.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Đơn Giá");
                txtDonGia.Focus();
            }
            else if (string.IsNullOrEmpty(txtThanhTien.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Thành Tiền");
                txtThanhTien.Focus();
            }
            else if (string.IsNullOrEmpty(txtTongTienHDBangChu.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Tổng Tiền Hóa Đơn (Băng Chữ)");
                txtTongTienHDBangChu.Focus();
            }
            else
            {
                hdct = new DTO_HoaDonChiTiet(txtMaHD.Text,txtDonGia.Text, txtSoLuong.Text, tenMA);
                if (busHDCT.ThemHoaDonChiTiet(hdct))
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn");
                txtMaHD.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (busHDCT.XoaHoaDonChiTiet(txtMaHD.Text))
                    {
                        MessageBox.Show("Xóa thành công");
                        ResetValues();
                        LoadData();
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
    }
}
