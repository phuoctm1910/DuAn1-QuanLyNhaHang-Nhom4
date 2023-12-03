using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhaHang
{
    [Serializable]
    public class PlaneData
    {
        private List<PlanItem> job;
        private bool isCheckNotify;
        public List<PlanItem> Job { get => job; set => job = value; }
        public bool IsCheckNotify { get => isCheckNotify; set => isCheckNotify = value; }
    }
}
