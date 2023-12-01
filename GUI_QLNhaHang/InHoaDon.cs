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
using Microsoft.Reporting.WinForms;

namespace GUI_QLNhaHang
{
    public partial class InHoaDon : Form
    {
        public static string MaHD;
        public static string TenKH;
        public static string TenNV;
        public static int TongTien;
        BUS_HoaDonChiTiet busHDCT = new BUS_HoaDonChiTiet();
        public InHoaDon(string mahd, string tenkh, string tennv, int tongtien)
        {
            InitializeComponent();
            MaHD = mahd;
            TenKH = tenkh;
            TenNV = tennv;
            TongTien = tongtien;
        }
        private void InHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDonChiTiet();
        }
        private void LoadHoaDonChiTiet()
        {
            DataTable dt = busHDCT.DanhSachHoaDonChiTiet(MaHD);
            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("TenKhachHang", TenKH),
                new ReportParameter("TenNhanVien", TenNV),
                new ReportParameter("TongTien", TongTien.ToString())
            };
            reportInHoaDon.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("InHoaDon", dt);
            reportInHoaDon.LocalReport.ReportPath = @"D:\FPT POLYTECHNIC\Hoc Ki 4\DuAn1-QuanLyNhaHang-Nhom4\GUI_QLNhaHang\Report1.rdlc";
            reportInHoaDon.LocalReport.SetParameters(reportParameters);
            reportInHoaDon.LocalReport.DataSources.Add(source);
            reportInHoaDon.RefreshReport();

        }
    }
}
