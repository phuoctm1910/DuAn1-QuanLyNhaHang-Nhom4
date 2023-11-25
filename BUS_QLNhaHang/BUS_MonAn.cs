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
    public class BUS_MonAn
    {
        DAL_MonAn dalMA = new DAL_MonAn();

        public DataTable DanhSachNhomMonAn()
        {
            return dalMA.DanhSachNhomMonAn();
        }
        public DataTable DanhSachMonAn()
        {
            return dalMA.DanhSachMonAn();
        }

        public bool ThemMonAn(DTO_MonAn ma)
        {
            return dalMA.ThemMonAn(ma);
        }

        public bool CapNhatMonAn(DTO_MonAn ma, string mamonan)
        {
            return dalMA.CapNhatMonAn(ma, mamonan);
        }

        public bool XoaMonAn(string mamonan)
        {
            return dalMA.XoaMonAn(mamonan);
        }
    }
}
