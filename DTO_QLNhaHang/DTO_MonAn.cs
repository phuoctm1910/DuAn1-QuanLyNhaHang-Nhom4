using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhaHang
{
    public class DTO_MonAn
    {
        private string tenMonAn;
        private int donGia;
        private string maNhomMonAn;
        private string maMonAn;

        public string MaMonAn
        {
            get { return maMonAn; }
            set { maMonAn = value; }
        }
        public string TenMonAn
        {
            get { return tenMonAn; }
            set { tenMonAn = value; }
        }

        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public string MaNhomMonAn
        {
            get { return maNhomMonAn; }
            set { maNhomMonAn = value; }
        }

        public DTO_MonAn(string tenMonAn, int donGia, string maNhomMonAn)
        {
            this.tenMonAn = tenMonAn;
            this.donGia = donGia;
            this.maNhomMonAn = maNhomMonAn;
        }
        public DTO_MonAn()
        { }
    }
}
