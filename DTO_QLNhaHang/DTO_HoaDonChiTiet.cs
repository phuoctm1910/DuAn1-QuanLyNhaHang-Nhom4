using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhaHang
{
    public class DTO_HoaDonChiTiet
    {
        private string maHD;
        private string maMonAn;
        private int donGia;
        private int soLuong;

        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }

        public string MaMonAn
        {
            get { return maMonAn; }
            set { maMonAn = value; }
        }

        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public DTO_HoaDonChiTiet(string maHD, string maMonAn, int donGia, int soLuong)
        {
            this.maHD = maHD;
            this.maMonAn = maMonAn;
            this.donGia = donGia;
            this.soLuong = soLuong;
        }

        public DTO_HoaDonChiTiet()
        { }
    }
}
