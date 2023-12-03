﻿using System;
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
    public partial class NhomMonAn : Form
    {
        BUS_NhomMonAn busNMA = new BUS_NhomMonAn();
        DTO_NhomMonAn nma = new DTO_NhomMonAn();
        public static string vaiTro;
        public NhomMonAn(string vaitro)
        {         
            InitializeComponent();
            vaiTro = vaitro;
        }
        void LoadData()
        {
            dvDanhSachNhomMonAn.DataSource = busNMA.DanhSachNhomMonAn();
            dvDanhSachNhomMonAn.Columns[0].HeaderText = "Mã Nhóm";
            dvDanhSachNhomMonAn.Columns[1].HeaderText = "Tên Nhóm";
        }
        void ResetValues()
        {
            if (int.Parse(vaiTro) == 0)
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                txtMaNhomMonAn.Enabled = txtTenNhomMonAn.Enabled = false;
            }
            else
            {
                txtMaNhomMonAn.Clear();
                txtTenNhomMonAn.Clear();
            }
        }
        private bool IsTenValid(string ten)
        {
            return Regex.IsMatch(ten, "^[a-zA-ZÀ-Ỹà-ỹ\\s]+$");
        }
        private bool IsTenExists(string sodt)
        {
            foreach (DataGridViewRow row in dvDanhSachNhomMonAn.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == sodt)
                {
                    return true;
                }
            }
            return false;
        }
        private void NhomMonAn_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetValues();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenNMA = txtTenNhomMonAn.Text.Trim();
            if (string.IsNullOrEmpty(tenNMA) || tenNMA.Length < 5)
            {
                MessageBox.Show("Bạn chưa nhập tê nhóm món ăn và phải dài hơn 5 kí tự");
                txtTenNhomMonAn.Focus();
            }
            else if (!IsTenValid(tenNMA))
            {
                MessageBox.Show("Tên nhóm món ăn không hợp lệ. Tên chỉ được chứa ký tự tiếng Việt và khoảng trắng.");
                txtTenNhomMonAn.Focus();
            }
            else if (IsTenExists(tenNMA))
            {
                MessageBox.Show("Tên nhóm món ăn đã tồn tại. Vui lòng nhập tên nhóm món ăn khác.");
                txtTenNhomMonAn.Focus();
            }
            else
            {
                nma = new DTO_NhomMonAn(txtTenNhomMonAn.Text);
                if (busNMA.ThemNhomMonAn(nma, txtMaNhomMonAn.Text))
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
            string tenNMA = txtTenNhomMonAn.Text.Trim();
            if (string.IsNullOrEmpty(tenNMA) || tenNMA.Length < 5)
            {
                MessageBox.Show("Bạn chưa nhập tê nhóm món ăn và phải dài hơn 5 kí tự");
                txtTenNhomMonAn.Focus();
            }
            else if (!IsTenValid(tenNMA))
            {
                MessageBox.Show("Tên nhóm món ăn không hợp lệ. Tên chỉ được chứa ký tự tiếng Việt và khoảng trắng.");
                txtTenNhomMonAn.Focus();
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
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetValues();
        }
        private void dvDanhSachNhomMonAn_DoubleClick(object sender, EventArgs e)
        {
            if (dvDanhSachNhomMonAn.Rows.Count <= 0)
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
                    int lst = dvDanhSachNhomMonAn.CurrentRow.Index;
                    txtMaNhomMonAn.Text = dvDanhSachNhomMonAn.Rows[lst].Cells[0].Value.ToString();
                    txtTenNhomMonAn.Text = dvDanhSachNhomMonAn.Rows[lst].Cells[1].Value.ToString();
                }
            }

        }
    }
}
