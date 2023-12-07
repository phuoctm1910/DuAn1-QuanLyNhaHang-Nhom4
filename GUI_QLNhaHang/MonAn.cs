using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public static string vaiTro;
        public MonAn(string vaitro)
        {
            InitializeComponent();
            vaiTro = vaitro;
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
            if (int.Parse(vaiTro) == 0)
            {
                btnThem.Visible = btnSua.Visible = btnXoa.Visible = btnLamMoi.Visible = false;
                txtTenMonAn.Enabled = txtMaMonAn.Enabled = txtDonViTinh.Enabled = false;
                cboNhomMonAn.Enabled = false;
                btnNhomMonAn.Enabled = false;
            }
            else
            {
                txtMaMonAn.Enabled = false;
                txtDonViTinh.Enabled = false;
                txtTenMonAn.Clear();
                txtDonViTinh.Text = "VNĐ";
                txtMaMonAn.Clear();
                cboNhomMonAn.SelectedIndex = -1;
            }   
        }
        private void MonAn_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetValues();
            cboNhomMonAn.DataSource = busMA.DanhSachNhomMonAn();
            cboNhomMonAn.DisplayMember = "TenNhom";
            cboNhomMonAn.ValueMember = "MaNhomMonAn";
        }
        private bool IsTenValid(string ten)
        {
            return Regex.IsMatch(ten, "^[a-zA-ZÀ-Ỹà-ỹ\\s]+$");
        }
        private bool IsTenExists(string sodt)
        {
            foreach (DataGridViewRow row in dvDanhSachMonAn.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() == sodt)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string nhomMA = cboNhomMonAn.SelectedValue.ToString();
            string tenMA = txtTenMonAn.Text.Trim();
            if (string.IsNullOrEmpty(tenMA) || tenMA.Length < 5)
            {
                MessageBox.Show("Bạn chưa nhập tên món ăn và phải dài hơn 5 kí tự");
                txtTenMonAn.Focus();
            }
            else if (!IsTenValid(txtTenMonAn.Text))
            {
                MessageBox.Show("Tên món ăn không hợp lệ. Tên chỉ được chứa ký tự tiếng Việt và khoảng trắng.");
                txtTenMonAn.Focus();
            }
            else if (IsTenExists(tenMA))
            {
                MessageBox.Show("Tên món ăn đã tồn tại. Vui lòng nhập tên món ăn khác.");
                txtTenMonAn.Focus();
            }
            else if (string.IsNullOrEmpty(txtDonViTinh.Text) || txtDonViTinh.TextLength < 3)
            {
                MessageBox.Show("Bạn chưa nhập đơn vị tính và phải dài hơn 3 kí tự");
                txtDonViTinh.Focus();
            }
            else if (cboNhomMonAn.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn nhóm món ăn");
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
            string tenMA = txtTenMonAn.Text.Trim();
            if (string.IsNullOrEmpty(tenMA) || tenMA.Length < 5)
            {
                MessageBox.Show("Bạn chưa nhập tên món ăn và phải dài hơn 5 kí tự");
                txtTenMonAn.Focus();
            }
            else if (!IsTenValid(txtTenMonAn.Text))
            {
                MessageBox.Show("Tên món ăn không hợp lệ. Tên chỉ được chứa ký tự tiếng Việt và khoảng trắng.");
                txtTenMonAn.Focus();
            }
            else if (string.IsNullOrEmpty(txtDonViTinh.Text) || txtDonViTinh.TextLength < 3)
            {
                MessageBox.Show("Bạn chưa nhập đơn vị tính và phải dài hơn 3 kí tự");
                txtTenMonAn.Focus();
            }
            else if (cboNhomMonAn.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn nhóm món ăn");
                cboNhomMonAn.Focus();
            }
            else
            {
                ma = new DTO_MonAn(txtTenMonAn.Text, txtDonViTinh.Text, nhomMA);
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
                if (int.Parse(vaiTro) == 0)
                {
                    MessageBox.Show("Bạn không thể sử dụng chức năng này vì bạn là nhân viên");
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

        private void btnNhomMonAn_Click(object sender, EventArgs e)
        {
            NhomMonAn nma = new NhomMonAn(vaiTro);
            nma.Show();
        }

    }
}
