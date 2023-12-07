using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        public static int ThanhTien;
        public static int TongTien;
        public static int GiamGia;
        BUS_HoaDonChiTiet busHDCT = new BUS_HoaDonChiTiet();

        // Đoạn mã P/Invoke
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern IntPtr CreateFontIndirect([In] ref LOGFONT lplf);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateFont(
            int nHeight, int nWidth, int nEscapement, int nOrientation, int fnWeight,
            uint fdwItalic, uint fdwUnderline, uint fdwStrikeOut, uint fdwCharSet,
            uint fdwOutputPrecision, uint fdwClipPrecision, uint fdwQuality,
            uint fdwPitchAndFamily, string lpszFace);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct LOGFONT
        {
            public int lfHeight;
            public int lfWidth;
            public int lfEscapement;
            public int lfOrientation;
            public int lfWeight;
            public byte lfItalic;
            public byte lfUnderline;
            public byte lfStrikeOut;
            public byte lfCharSet;
            public byte lfOutPrecision;
            public byte lfClipPrecision;
            public byte lfQuality;
            public byte lfPitchAndFamily;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string lfFaceName;
        }
        public InHoaDon(string mahd, string tenkh, string tennv, int thanhtien, int giamgia)
        {
            InitializeComponent();
            MaHD = mahd;
            TenKH = tenkh;
            TenNV = tennv;
            ThanhTien = thanhtien;
            GiamGia = giamgia;
        }
        private void InHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDonChiTiet();
        }
        private void LoadHoaDonChiTiet()
        {
            DataTable dt = busHDCT.DanhSachHoaDonChiTiet(MaHD);
            TongTien = ThanhTien - (ThanhTien * GiamGia / 100);
            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("TenKhachHang", TenKH),
                new ReportParameter("TenNhanVien", TenNV),
                new ReportParameter("ThanhTien", ThanhTien.ToString()),
                new ReportParameter("GiamGia", GiamGia.ToString()),
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
