using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhaHang
{
    public class DTO_NhomMonAn
    {
        private string tenNhomMonAn;

        public string TenNhomMonAn { get { return tenNhomMonAn; } set { tenNhomMonAn = value; } }

        public DTO_NhomMonAn()
        {
        }

        public DTO_NhomMonAn(string tenNhomMonAn)
        {
            this.tenNhomMonAn = tenNhomMonAn;
        }
    }
}
