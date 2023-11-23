using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhaHang
{
    public class DTO_BanAn
    {
        private string maBanAn;
        private string tenBanAn;

        public string MaBanAn
        {
            get { return maBanAn; }
            set { maBanAn = value; }
        }
        public string TenBanAn
        {
            get { return tenBanAn; }
            set { tenBanAn = value; }
        }
        public DTO_BanAn()
        { 

        }

        public DTO_BanAn(string tenBanAn)
        {
            this.tenBanAn = tenBanAn;
        }
    }
}
