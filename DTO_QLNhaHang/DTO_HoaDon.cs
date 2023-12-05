using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhaHang
{
    public class DTO_HoaDon
    {
        private string maNV;
        private string maKH;
        private string maBA;
        private string ngayLap;
        private string trangThai;
        private int giamGia;

        public string MaNV { get { return maNV; } set { maNV = value; } }
        public string MaKH { get { return maKH; } set { maKH = value; } }
        public string MaBanAn { get { return maBA; } set { maBA = value; } }
        public string NgayLap { get { return ngayLap; } set { ngayLap = value; } }
        public string TrangThai { get { return trangThai; } set { trangThai = value; } }
        public int GiamGia { get { return giamGia; } set { giamGia = value; } }


        public DTO_HoaDon()
        {
        }

        public DTO_HoaDon(string maNV, string maKH, string maBA, string ngayLap, string trangThai, int giamGia)
        {
            this.maNV = maNV;
            this.maKH = maKH;
            this.maBA = maBA;
            this.ngayLap = ngayLap;
            this.trangThai = trangThai;
            this.giamGia = giamGia;
        }
    }
}

