using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using BUS_QLNhaHang;
using DTO_QLNhaHang;

namespace GUI_QLNhaHang
{
    public partial class LichLam : Form
    {
        BUS_LichLam busLL = new BUS_LichLam();
        DTO_LichLam ll = new DTO_LichLam();
        public static string vaiTro;
        public LichLam(string vaitro)
        {
            InitializeComponent();
            vaiTro = vaitro;
        }
        void LoadData()
        {
            dvDanhSachLichLam.DataSource = busLL.DanhSachLichLam();
            dvDanhSachLichLam.Columns[0].HeaderText = "ID Lịch Làm";
            dvDanhSachLichLam.Columns[1].HeaderText = "Lịch Làm";
        }
        private void LichLam_Load(object sender, EventArgs e)
        {
            txtIDLichLam.Enabled = false;
            LoadData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dtpLichLam.Text)) 
            {
                MessageBox.Show("Bạn chưa nhập lịch làm");
                txtIDLichLam.Focus();
            }
            else
            {
                DateTime selectdate = dtpLichLam.Value;
                string formatdate = selectdate.ToString("MM/dd/yyyy");
                ll = new DTO_LichLam(formatdate);
                if (busLL.ThemLichLam(ll))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadData();
                    ResetValues();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDLichLam.Text)) //chinh lai bat loi
            {
                MessageBox.Show("Bạn chưa nhập lịch làm");
                dtpLichLam.Focus();
            }
            else if (string.IsNullOrEmpty(txtIDLichLam.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã lịch làm");
                txtIDLichLam.Focus();
            }
            else
            {
                int id = int.Parse(txtIDLichLam.Text);
                DateTime selectdate = dtpLichLam.Value;
                string formatdate = selectdate.ToString("MM/dd/yyyy");
                ll = new DTO_LichLam(formatdate);
                DialogResult result = MessageBox.Show("Bạn có thật sự muốn sửa không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (busLL.CapNhatLichLam(ll, id))
                    {
                        MessageBox.Show("Sửa thành công");
                        ResetValues();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                else
                {
                    ResetValues();
                }
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetValues();
        }  
        private void ResetValues()
        {
            if (int.Parse(vaiTro) == 0)
            {
                btnThem.Enabled = btnSua.Enabled = false;
                txtIDLichLam.Enabled = dtpLichLam.Enabled = false;
            }
            else
            {
                txtIDLichLam.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                txtIDLichLam.Clear();
                txtIDLichLam.Clear();
            }
        }
        private void dvDanhSachLichLam_DoubleClick(object sender, EventArgs e)
        {
            if (dvDanhSachLichLam.Rows.Count <= 0)
            {
                MessageBox.Show("Bảng không có dữ liệu");
            }
            else
            {
                if (int.Parse(vaiTro) == 0)
                {
                    MessageBox.Show("Bạn không thể sử dụng chức năng này vì bạn là nhân viên");
                }
                else
                {
                    btnThem.Enabled = false;
                    txtIDLichLam.Enabled = false;
                    int lst = dvDanhSachLichLam.CurrentRow.Index;
                    txtIDLichLam.Text = dvDanhSachLichLam.Rows[lst].Cells[0].Value.ToString();
                    dtpLichLam.Text = dvDanhSachLichLam.Rows[lst].Cells[1].Value.ToString();
                }
            }
        }
    }
}
