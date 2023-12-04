using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLNhaHang;

namespace GUI_QLNhaHang
{
    public partial class AJob : UserControl
    {
        private PlanItem job;
        public PlanItem Job { get => job; set => job = value; }

        public AJob(PlanItem job)
        {
            InitializeComponent();
            cboStatus.DataSource = PlanItem.ListStatus;

            this.Job = job;
            ShowData();
        }

        void ShowData()
        {
            txtJob.Text = Job.Job;
            nmudFromHour.Value = Job.FromTime.X;
            nmudFromMinute.Value = Job.FromTime.Y;
            nmudToHour.Value = Job.ToTime.X;
            nmudToMinute.Value = Job.ToTime.Y;
            cboStatus.SelectedIndex = PlanItem.ListStatus.IndexOf(Job.Status);
            chbDone.Checked = PlanItem.ListStatus.IndexOf(Job.Status) == (int)EPlantItem.Done ? true : false;
        }
    }
}
