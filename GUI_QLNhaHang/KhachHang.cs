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
    public partial class KhachHang : Form
    {
        BUS_KhachHang busKH = new BUS_KhachHang();
        DTO_KhachHang kh = new DTO_KhachHang();
        public KhachHang()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            dvThongTinKH.DataSource = busKH.DanhSachKhachHang();
            dvThongTinKH.Columns[0].HeaderText = "Mã KH";
            dvThongTinKH.Columns[1].HeaderText = "Tên KH";
            dvThongTinKH.Columns[2].HeaderText = "Ngày Sinh";
            dvThongTinKH.Columns[3].HeaderText = "Giới tính";
            dvThongTinKH.Columns[4].HeaderText = "Địa chỉ";
            dvThongTinKH.Columns[5].HeaderText = "Số điện thoại";
        }
        void ResetValues()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtTimKiem.Text = "Nhập sdt khách hàng";
            rtxtDiaChi.Clear();
            radNam.Checked = false;
            radNu.Checked = false;
            //if (int.Parse(vaiTro) == 0)
            //{
            //    btnXoa.Enabled = false;
            //}
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            LoadData();
            ResetValues();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            float intDienThoai;
            bool isInt = float.TryParse(txtSDT.Text.Trim().ToString(), out intDienThoai);
            string phai;
            if (radNam.Checked)
            { phai = radNam.Text; }
            else
            { phai = radNu.Text; }

            if (string.IsNullOrEmpty(txtTenKH.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng");
                txtTenKH.Focus();
            }
            else if (string.IsNullOrEmpty(dtpNgaySinh.Text))
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh khách hàng");
                dtpNgaySinh.Focus();
            }
            else if (radNam.Checked == false && radNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính khách hàng");
            }
            else if (string.IsNullOrEmpty(rtxtDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                rtxtDiaChi.Focus();
            }
            else if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại khách hàng");
                txtSDT.Focus();
            }
            else if (!isInt || float.Parse(txtSDT.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số lớn hơn 0 và phải là số nguyên");
                txtSDT.Focus();
            }
            else if (txtSDT.TextLength < 10)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại đủ 10-11 số");
                txtSDT.Focus();
            }
            else
            {
                DateTime selectdate = dtpNgaySinh.Value;
                string formatdate = selectdate.ToString("MM/dd/yyyy");
                kh = new DTO_KhachHang(txtTenKH.Text, formatdate, phai, rtxtDiaChi.Text, txtSDT.Text);
                if (busKH.ThemKhachHang(kh))
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
    }
}
