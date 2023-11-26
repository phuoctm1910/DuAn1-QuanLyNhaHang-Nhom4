using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNhaHang;
using DTO_QLNhaHang;

namespace BUS_QLNhaHang
{
    public class BUS_HoaDonChiTiet
    {

        DAL_HoaDonChiTiet dalHDCT = new DAL_HoaDonChiTiet();

        public DataTable DanhSachHoaDonChiTiet()
        {
            return dalHDCT.DanhSachHoaDonChiTiet();
        }

        public bool ThemHoaDonChiTiet(DTO_HoaDonChiTiet hdct)
        {
            return dalHDCT.ThemHoaDonChiTiet(hdct);
        }

        public bool XoaHoaDonChiTiet(string mahdct)
        {
            return dalHDCT.XoaHoaDonChiTiet(mahdct);
        }
    }
}
