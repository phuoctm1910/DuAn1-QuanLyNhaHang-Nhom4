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
    public partial class BanAn : Form
    {
        BUS_BanAn busBA = new BUS_BanAn();
        DTO_BanAn ba = new DTO_BanAn();
        public static string vaiTro;
        public BanAn(string vaitro)
        {
            InitializeComponent();
            vaiTro = vaitro;
        }

        void LoadData()
        {
            dvDanhSachBanAn.DataSource = busBA.DanhSachBanAn();
            dvDanhSachBanAn.Columns[0].HeaderText = "Mã bàn ăn"; 
            dvDanhSachBanAn.Columns[1].HeaderText = "Tên bàn ăn"; 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenBanAn.Text)) // chinh lai bat loi
            {
                MessageBox.Show("Bạn chưa nhập tên bàn ăn");
                txtTenBanAn.Focus();
            }
            else
            {
                ba = new DTO_BanAn(txtTenBanAn.Text);
                if (busBA.ThemBanAn(ba))
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
        private void ResetValues()
        {
            txtMaBanAn.Enabled = false;
            btnThem.Enabled = true;
            txtMaBanAn.Clear(); 
            txtTenBanAn.Clear();
            if (int.Parse(vaiTro) == 0)
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
                txtMaBanAn.Enabled = txtTenBanAn.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaBanAn.Text)) //chinh lai bat loi
            {
                MessageBox.Show("Bạn chưa nhập tên bàn ăn");
                txtTenBanAn.Focus();
            }
            else if (string.IsNullOrEmpty(txtMaBanAn.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã bàn ăn");
                txtMaBanAn.Focus();
            }
            else
            {
                ba = new DTO_BanAn(txtTenBanAn.Text);
                DialogResult result = MessageBox.Show("Bạn có thật sự muốn sửa không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (busBA.CapNhatBanAn(ba, txtMaBanAn.Text))
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
            
            if (string.IsNullOrEmpty(txtMaBanAn.Text.Trim()))
            {
                MessageBox.Show("Bạn chưa nhập mã bàn ăn");
                txtMaBanAn.Focus();
            }
            else if (string.IsNullOrEmpty(txtTenBanAn.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên bàn ăn");
                txtTenBanAn.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    //chinh lai la txtmabanan
                    if (busBA.XoaBanAn(txtMaBanAn.Text))
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

        private void BanAn_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetValues();
        }

        private void dvDanhSachBanAn_DoubleClick(object sender, EventArgs e)
        {
            if (dvDanhSachBanAn.Rows.Count <= 0)
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
                    txtMaBanAn.Enabled = false;
                    int lst = dvDanhSachBanAn.CurrentRow.Index;
                    txtMaBanAn.Text = dvDanhSachBanAn.Rows[lst].Cells[0].Value.ToString();
                    txtTenBanAn.Text = dvDanhSachBanAn.Rows[lst].Cells[1].Value.ToString();
                }
            }
        }
    }
}
