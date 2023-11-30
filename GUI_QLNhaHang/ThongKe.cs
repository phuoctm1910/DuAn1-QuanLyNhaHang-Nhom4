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
    public partial class ThongKe : Form
    {
        BUS_HoaDon busHD = new BUS_HoaDon();
        public ThongKe()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            dvThongKe.DataSource = busHD.ThongKe();
            dvThongKe.Columns[0].HeaderText = "Mã Hóa Đơn";
            dvThongKe.Columns[1].HeaderText = "Mã Nhân Viên";
            dvThongKe.Columns[2].HeaderText = "Mã Khách Hàng";
            dvThongKe.Columns[3].HeaderText = "Mã Bàn Ăn";
            dvThongKe.Columns[4].HeaderText = "Trạng Thái";
            dvThongKe.Columns[5].HeaderText = "Tổng Tiền";
        }

    }
}
