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
    public partial class MonAn : Form
    {
        BUS_MonAn busMA = new BUS_MonAn();
        DTO_MonAn ma = new DTO_MonAn();
        public MonAn()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            dvDanhSachMonAn.DataSource = busMA.DanhSachMonAn();
            dvDanhSachMonAn.Columns[0].HeaderText = "Nhóm Món Ăn";
            dvDanhSachMonAn.Columns[1].HeaderText = "Mã Món Ăn";
            dvDanhSachMonAn.Columns[2].HeaderText = "Tên Món Ăn";
            dvDanhSachMonAn.Columns[3].HeaderText = "Đơn Vị Tính";
        }
        private void ResetValues()
        {
            txtTenMonAn.Clear();
            txtDonViTinh.Clear();
            txtMaMonAn.Clear();
            cboNhomMonAn.SelectedIndex = -1;
        }

        private void MonAn_Load(object sender, EventArgs e)
        {
            LoadData();
            cboNhomMonAn.DataSource = busMA.DanhSachNhomMonAn();
            cboNhomMonAn.DisplayMember = "TenNhom";
            cboNhomMonAn.ValueMember = "MaNhomMonAn";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string nhomMA = cboNhomMonAn.SelectedValue.ToString();
            if (string.IsNullOrEmpty(txtTenMonAn.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Món Ăn");
                txtTenMonAn.Focus();
            }
            else if (string.IsNullOrEmpty(txtDonViTinh.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Đơn Vị Tính");
                txtTenMonAn.Focus();
            }
            else if (cboNhomMonAn.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Chưa Chọn Nhóm Món Ăn");
                cboNhomMonAn.Focus();
            }
            else
            {
                ma = new DTO_MonAn(txtTenMonAn.Text, txtDonViTinh.Text, nhomMA);
                if (busMA.ThemMonAn(ma))
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
            string nhomMA = cboNhomMonAn.SelectedValue.ToString();

            if (string.IsNullOrEmpty(txtTenMonAn.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Món Ăn");
                txtTenMonAn.Focus();
            }
            else if (string.IsNullOrEmpty(txtDonViTinh.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Đơn Vị Tính");
                txtTenMonAn.Focus();
            }
            else if (cboNhomMonAn.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Chưa Chọn Nhóm Món Ăn");
                cboNhomMonAn.Focus();
            }
            else
            {
                ma = new DTO_MonAn(txtTenMonAn.Text, txtDonViTinh.Text, nhomMA);
                DialogResult result = MessageBox.Show("Bạn có thật sự muốn sửa không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (busMA.CapNhatMonAn(ma, txtMaMonAn.Text))
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenMonAn.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên món ăn");
                txtTenMonAn.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (busMA.XoaMonAn(txtMaMonAn.Text))
                    {
                        MessageBox.Show("Xóa thành công");
                        ResetValues();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
                else
                {
                    ResetValues();
                }

            }
        }

        private void dvDanhSachMonAn_DoubleClick(object sender, EventArgs e)
        {
            if (dvDanhSachMonAn.Rows.Count <= 0)
            {
                MessageBox.Show("Bảng không có dữ liệu");
            }
            else
            {
                btnThem.Enabled = false;
                txtTenMonAn.Enabled = txtDonViTinh.Enabled = true;
                cboNhomMonAn.Enabled = true;
                btnSua.Enabled = btnXoa.Enabled = true;
                int lst = dvDanhSachMonAn.CurrentRow.Index;
                txtMaMonAn.Text = dvDanhSachMonAn.Rows[lst].Cells[0].Value.ToString();
                txtTenMonAn.Text = dvDanhSachMonAn.Rows[lst].Cells[1].Value.ToString();
                txtDonViTinh.Text = dvDanhSachMonAn.Rows[lst].Cells[2].Value.ToString();
                string nMA = dvDanhSachMonAn.Rows[lst].Cells[3].Value.ToString();
                if (nMA == "0")
                {
                    cboNhomMonAn.SelectedIndex = 0;
                }
                else
                {
                    cboNhomMonAn.SelectedIndex = 1;
                }
            }
        }
    }
}
