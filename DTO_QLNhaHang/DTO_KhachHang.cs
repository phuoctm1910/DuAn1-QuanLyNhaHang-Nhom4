using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhaHang
{
    public class DTO_KhachHang
    {
        private string tenKH;
        private string ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string soDT;

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string SoDT
        {
            get { return soDT; }
            set { soDT = value; }
        }
        public DTO_KhachHang()
        {
        }

        public DTO_KhachHang(string tenKH, string ngaySinh, string gioiTinh, string diaChi, string soDT)
        {
            this.tenKH = tenKH;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.soDT = soDT;
        }
    }
}
