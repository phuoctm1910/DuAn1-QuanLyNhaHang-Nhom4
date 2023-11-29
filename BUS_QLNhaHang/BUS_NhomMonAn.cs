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
    public class BUS_NhomMonAn
    {
        DAL_NhomMonAn dalNhommonan = new DAL_NhomMonAn();
        public DataTable DanhSachNhomMonAn()
        {
            return dalNhommonan.DanhSachNhomMonAn();
        }
        public bool ThemNhomMonAn(DTO_NhomMonAn nma)
        {
            return dalNhommonan.ThemNhomMonAn(nma);
        }
        public bool CapNhatNhomMonAn(DTO_NhomMonAn nma, string ma)
        {
            return dalNhommonan.CapNhatNhomMonAn(nma, ma);
        }
        public bool XoaNhomMonAn(string ma)
        {
            return dalNhommonan.XoaNhomMonAn(ma);
        }
    }
}