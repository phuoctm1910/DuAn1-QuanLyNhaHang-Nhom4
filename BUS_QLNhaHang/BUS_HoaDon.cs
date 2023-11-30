using DAL_QLNhaHang;
using DTO_QLNhaHang;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLNhaHang
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dalHoaDon = new DAL_HoaDon();
        public DataTable ThongKe()
        {
            return dalHoaDon.ThongKe();
        }
        public DataTable DanhSachHoaDon()
        {
            return dalHoaDon.DanhSachHoaDon();
        }

        public DataTable LayKhachHang()
        {
            return dalHoaDon.LayKhachHang();
        }

        public DataTable LayNguoiDung()
        {
            return dalHoaDon.LayNguoiDung();
        }

        public DataTable LayBanAn()
        {
            return dalHoaDon.LayBanAn();
        }

        public bool ThemHoaDon(DTO_HoaDon HD, int tongtien)
        {
            return dalHoaDon.ThemHoaDon(HD, tongtien);
        }


        public bool XoaHoaDon(DTO_HoaDon HD, string mahd)
        {
            return dalHoaDon.XoaHoaDon(HD, mahd);
        }


        public DataTable SearchHoaDon(DTO_HoaDon HD, string mahd)
        {
            return dalHoaDon.SearchHoaDon(HD, mahd);
        }

        public bool CapNhatHoaDon(DTO_HoaDon HD, string mahd)
        {
            return dalHoaDon.CapNhatHoaDon(HD, mahd);
        }

    }
}
