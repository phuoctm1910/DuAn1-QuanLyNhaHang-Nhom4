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
    public partial class KhachHang : Form
    {
        BUS_KhachHang busKH = new BUS_KhachHang();
        DTO_KhachHang kh = new DTO_KhachHang();
        public KhachHang()
        {
            InitializeComponent();
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
            txtSDT.Clear();
            txtTimKiem.Text = "Nhập sdt khách hàng";
            rtxtDiaChi.Clear();
            radNam.Checked = false;
            radNu.Checked = false;
            //if (int.Parse(vaiTro) == 0)
            //{
            //    btnXoa.Enabled = false;
            //}
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            LoadData();
            ResetValues();
        }
    }
}
