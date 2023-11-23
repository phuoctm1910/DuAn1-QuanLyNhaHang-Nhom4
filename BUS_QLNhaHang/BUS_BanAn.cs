using DTO_QLNhaHang;
using DAL_QLNhaHang;
using System.Collections.Generic;
using System.Data;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLNhaHang
{
    public class BUS_BanAn
    {
        DAL_BanAn dalbanan = new DAL_BanAn();
        public DataTable DanhSachBanAn()
        {
            return dalbanan.DanhSachBanAn();
        }
        public bool ThemBanAn(DTO_BanAn ba)
        {
            return dalbanan.ThemBanAn(ba);
        }
        public bool CapNhatBanAn(DTO_BanAn ba, string mabanan)
        {
            return dalbanan.CapNhatBanAn(ba, mabanan);
        }

        public object getDanhSachBanAn()
        {
            throw new NotImplementedException();
        }

        public bool XoaBanAn(string mabanan)
        {
            return dalbanan.XoaBanAn(mabanan);
        }
    }
}
