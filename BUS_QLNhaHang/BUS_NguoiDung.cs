using DAL_QLNhaHang;
using DTO_QLNhaHang;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLNhaHang
{
    public class BUS_NguoiDung
    {
        DAL_NguoiDung dalnguoidung = new DAL_NguoiDung();

        public DataTable LayVaiTro()
        {
            return dalnguoidung.LayVaiTro();
        }

        public DataTable LayCapDoLuong()
        {
            return dalnguoidung.LayCapDoLuong();
        }

        public DataTable LayLichLam()
        {
            return dalnguoidung.LayLichLam();
        }

        public DataTable DanhSachNguoiDung()
        {
            return dalnguoidung.DanhSachNguoiDung();
        }

        public bool ThemNguoiDung(DTO_NguoiDung ND)
        {
            return dalnguoidung.ThemNguoiDung(ND);
        }

        public bool CapNhatNguoiDung(DTO_NguoiDung ND, string manv)
        {
            return dalnguoidung.CapNhatNguoiDung(ND, manv);
        }

        public bool XoaNguoiDung(DTO_NguoiDung ND, string manv)
        {
            return dalnguoidung.XoaNguoiDung(ND, manv);
        }

        public DataTable SearchNguoiDung(DTO_NguoiDung ND, string manv)
        {
            return dalnguoidung.SearchNguoiDung(ND, manv);
        }
    }
}
