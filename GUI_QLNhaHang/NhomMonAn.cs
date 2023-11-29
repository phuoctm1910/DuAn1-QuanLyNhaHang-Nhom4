using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNhaHang;
using DTO_QLNhaHang;

namespace GUI_QLNhaHang
{
    public partial class NhomMonAn : Form
    {
        BUS_NhomMonAn busNMA = new BUS_NhomMonAn();
        DTO_NhomMonAn nma = new DTO_NhomMonAn();
        public NhomMonAn()
        {
            
            InitializeComponent();
        }
        void LoadData()
        {
            txtMaNhomMonAn.Enabled = false;
            dvDanhSachNhomMonAn.DataSource = busNMA.DanhSachNhomMonAn();
            dvDanhSachNhomMonAn.Columns[0].HeaderText = "Mã Nhóm";
            dvDanhSachNhomMonAn.Columns[1].HeaderText = "Tên Nhóm";
        }
        void ResetValues()
        {
            txtMaNhomMonAn.Clear();
            txtTenNhomMonAn.Clear();
        }

        private void NhomMonAn_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetValues();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNhomMonAn.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhóm món ăn");
                txtTenNhomMonAn.Focus();
            }
            else
            {
                nma = new DTO_NhomMonAn(txtTenNhomMonAn.Text);
                if (busNMA.ThemNhomMonAn(nma))
                {
                    MessageBox.Show("Thêm thành công");
                    ResetValues();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNhomMonAn.Text))
            {
                MessageBox.Show("Bạn chưa chọn nhóm món ăn");
            }
            else if (string.IsNullOrEmpty(txtTenNhomMonAn.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhóm món ăn");
                txtMaNhomMonAn.Focus();
            }
            else
            {
                nma = new DTO_NhomMonAn(txtTenNhomMonAn.Text);
                if (busNMA.CapNhatNhomMonAn(nma, txtMaNhomMonAn.Text))
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
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (busNMA.XoaNhomMonAn(txtMaNhomMonAn.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    ResetValues();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            else
            {
                ResetValues();
            }
        }
    }
}
