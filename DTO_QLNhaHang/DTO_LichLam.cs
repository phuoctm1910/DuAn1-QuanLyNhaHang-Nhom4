using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhaHang
{
    public class DTO_LichLam
    {
        private string lichLam;

        public string LichLam
        {
            get { return lichLam; }
            set { lichLam = value; }
        }

        public DTO_LichLam(string lichLam)
        {
            this.lichLam = lichLam;
        }

        public DTO_LichLam()
        {
        }
    }
}
