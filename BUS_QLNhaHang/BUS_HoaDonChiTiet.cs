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
        public DataTable LayMonAn()
        {
            return dalHDCT.LayMonAn();
        }
        public DataTable LayDonGia(string tenMonAn)
        {
            return dalHDCT.LayDonGia(tenMonAn);
        }
        public DataTable DanhSachHoaDonChiTiet(string mahd)
        {
            return dalHDCT.DanhSachHoaDonChiTiet(mahd);
        }
        public DataTable DanhSachHoaDonChiTietFull(string mahd)
        {
            return dalHDCT.DanhSachHoaDonChiTietFull(mahd);
        }

        public bool ThemHoaDonChiTiet(DTO_HoaDonChiTiet hdct)
        {
            return dalHDCT.ThemHoaDonChiTiet(hdct);
        }

        public bool XoaHoaDonChiTiet(string mahdct)
        {
            return dalHDCT.XoaHoaDonChiTiet(mahdct);
        }
        public bool HuyHoaDonChiTiet(string mahd)
        {
            return dalHDCT.HuyHoaDonChiTiet(mahd);
        }
        public bool CapNhatTrangThai(string mahd)
        {
            return dalHDCT.CapNhatTrangThai(mahd);
        }
        public bool CapNhatHoaDon(string mahd, int tongtien)
        {
            return dalHDCT.CapNhatHoaDon(mahd, tongtien);
        }
    }
}
