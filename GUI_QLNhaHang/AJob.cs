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
        private event EventHandler added;
        public event EventHandler Added
        {
            add { added += value; }
            remove { added -= value; }
        }
        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }
        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
         
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Job.Job = txtJob.Text;
            Job.FromTime = new Point((int)nmudFromHour.Value, (int)nmudFromMinute.Value);
            Job.ToTime = new Point((int)nmudToHour.Value, (int)nmudToMinute.Value);
            Job.Status = PlanItem.ListStatus[cboStatus.SelectedIndex];
            if (edited != null)
            {
                edited(this, new EventArgs());
            }
            MessageBox.Show("Đã sửa thành công");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleted != null)
            {
                deleted(this, new EventArgs());
            }
            MessageBox.Show("Đã xóa thành công");
        }

        private void chbDone_CheckedChanged(object sender, EventArgs e)
        {
            cboStatus.SelectedIndex = chbDone.Checked ? (int)EPlantItem.Done : (int)EPlantItem.Doing;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Job.Job = txtJob.Text;
            Job.FromTime = new Point((int)nmudFromHour.Value, (int)nmudFromMinute.Value);
            Job.ToTime = new Point((int)nmudToHour.Value, (int)nmudToMinute.Value);
            Job.Status = PlanItem.ListStatus[cboStatus.SelectedIndex];
            if (added != null)
            {
                added(this, new EventArgs());
            }
            MessageBox.Show("Đã thêm thành công");
        }
    }
}
