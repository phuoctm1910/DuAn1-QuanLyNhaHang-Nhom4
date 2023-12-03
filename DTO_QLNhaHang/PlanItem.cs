using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DTO_QLNhaHang
{
    public class PlanItem
    {
        private string job;
        private Point fromTime;
        private Point toTime;
        private string status;
        private DateTime jobExpired;
        private static List<string> ListStatus = new List<string>() { "Done", "Doing", "Coming", "Missed" };

        public string Job { get => job; set => job = value; }
        public Point FromTime { get => fromTime; set => fromTime = value; }
        public Point ToTime { get => toTime; set => toTime = value; }
        public string Status { get => status; set => status = value; }
        public DateTime JobExpired { get => jobExpired; set => jobExpired = value; }
    }
    
    public enum EPlantItem
    {
        Done,
        Doing,
        Coming,
        Missed
    }
}
