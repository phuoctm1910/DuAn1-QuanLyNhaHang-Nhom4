using System.Data;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNhaHang;
using DTO_QLNhaHang;

namespace BUS_QLNhaHang
{
    public class BUS_LichLam
    {
        DAL_LichLam dallichlam = new DAL_LichLam();
        public DataTable DanhSachLichLam()
        {
            return dallichlam.DanhSachLichLam();
        }
        public bool ThemLichLam(DTO_LichLam ll)
        {
            return dallichlam.ThemLichLam(ll);
        }
        public bool CapNhatLichLam(DTO_LichLam ll, int id)
        {
            return dallichlam.CapNhatLichLam(ll, id);
        }
    }
}
