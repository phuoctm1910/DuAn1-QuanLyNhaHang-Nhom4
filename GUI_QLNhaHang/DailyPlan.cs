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
    public partial class DailyPlan : Form
    {
        private DateTime date;
        private PlaneData job;
        public DateTime Date { get => date; set => date = value; }
        public PlaneData Job { get => job; set => job = value; }
        FlowLayoutPanel fpanel = new FlowLayoutPanel();

        public DailyPlan(DateTime date, PlaneData job)
        {
            InitializeComponent();
            this.Date = date;
            this.Job = job;

            fpanel.Width = pnlJob.Width;
            fpanel.Height = pnlJob.Height;
            pnlJob.Controls.Add(fpanel);


            dtpDate.Value = Date;
        }
        
        void ShowJobByDate(DateTime date)
        {
            fpanel.Controls.Clear();
            if (Job != null && Job.Job != null)
            {
                List<PlanItem> todayJob = GetJobByDate(date);
                for (int i = 0; i < GetJobByDate(date).Count; i++)
                {
                    AJob ajob = new AJob(todayJob[i]);
                    fpanel.Controls.Add(ajob);
                }
            }
        }

        List<PlanItem> GetJobByDate(DateTime date)
        {
            return Job.Job.Where(x => x.JobExpired.Year == date.Year && x.JobExpired.Month == date.Month && x.JobExpired.Day == date.Day).ToList();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDate((sender as DateTimePicker).Value);
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddDays(1);
        }

        private void btnPreviousDay_Click(object sender, EventArgs e)
        {
            dtpDate.Value = dtpDate.Value.AddDays(-1);
        }
    }
}
