using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNhaHang;
using DTO_QLNhaHang;

namespace BUS_QLNhaHang
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dalkhachhang = new DAL_KhachHang();
        public DataTable DanhSachKhachHang()
        {
            return dalkhachhang.DanhSachKhachHang();
        }

        public bool ThemKhachHang(DTO_KhachHang kh)
        {
            return dalkhachhang.ThemKhachHang(kh);
        }
        public bool CapNhatKhachHang(DTO_KhachHang kh, string makh)
        {
            return dalkhachhang.CapNhatKhachHang(kh, makh);
        }
        public bool XoaKhachHang(string makh)
        {
            return dalkhachhang.XoaKhachHang(makh);
        }
        public DataTable TimKhachHang(string sdt)
        {
            return dalkhachhang.TimKhachHang(sdt);
        }
    }
}
