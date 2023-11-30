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
        public static string mahdct;
        public static string MaHD;
        public static string TenKH;
        public static int tongtien;
        public HoaDonChiTiet(string mahd, string tenkh)
        {
            InitializeComponent();
            MaHD = mahd;
            TenKH = tenkh;
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
            else
            {
                hdct = new DTO_HoaDonChiTiet(txtMaHD.Text, cboTenMonAn.SelectedValue.ToString(), int.Parse(txtDonGia.Text), int.Parse(txtSoLuong.Text));
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
