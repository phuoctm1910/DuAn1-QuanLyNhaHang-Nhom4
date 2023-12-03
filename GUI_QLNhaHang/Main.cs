using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLNhaHang
{
    public partial class Main : Form
    {
        public static int Session = 0;
        public static string vaiTro;
        public Main(string tk, string vaitro, int session)
        {
            InitializeComponent();
            lblXinChao.Text = tk;
            Session = session;
            vaiTro = vaitro;
        }
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private bool ActiveChildForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
            return check;
        }
        void ResetValue()
        {
            if (Session == 1)
            {
                quảnLýBànĂnToolStripMenuItem.Visible = true;
                quảnLýKháchHàngToolStripMenuItem.Visible = true;
                quảnLýLịchLàmToolStripMenuItem.Visible = true;
                quảnLýLịchSựKiệnToolStripMenuItem.Visible = true;
                quảnLýMónĂnToolStripMenuItem.Visible = true;
                quảnLýNhânViênToolStripMenuItem.Visible = true;
                thốngKêToolStripMenuItem.Visible = true;
                đổiMậtKhẩuToolStripMenuItem.Visible = true;
                if (int.Parse(vaiTro) == 0)
                {
                    quảnLýNhómMónĂnToolStripMenuItem.Visible = false;
                    thốngKêToolStripMenuItem.Visible = false;
                }
            }

        }
        private void frm_FromClose(object sender, FormClosedEventArgs e)
        {
            ResetValue();
        }
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau(lblXinChao.Text);
            if (!CheckExistForm("DoiMatKhau"))
            {
                dmk.MdiParent = this;
                dmk.Show();
                dmk.FormClosed += new FormClosedEventHandler(frm_FromClose);
            }
            else
            {
                ActiveChildForm("DoiMatKhau");
            }
        }
        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NguoiDung nv = new NguoiDung(vaiTro, lblXinChao.Text);
            if (!CheckExistForm("NhanVien"))
            {
                nv.Show();
                nv.FormClosed += new FormClosedEventHandler(frm_FromClose);
            }
            else
            {
                ActiveChildForm("NhanVien");
            }
        }
        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang(vaiTro);
            if (!CheckExistForm("KhachHang"))
            {
                kh.Show();
                kh.FormClosed += new FormClosedEventHandler(frm_FromClose);
            }
            else
            {
                ActiveChildForm("KhachHang");
            }
        }
        private void quảnLýBànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanAn sp = new BanAn(vaiTro);
            if (!CheckExistForm("BanAn"))
            {
                sp.MdiParent = this;
                sp.Show();
                sp.FormClosed += new FormClosedEventHandler(frm_FromClose);
            }
            else
            {
                ActiveChildForm("BanAn");
            }
        }
        private void quảnLýMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonAn sp = new MonAn(vaiTro);
            if (!CheckExistForm("MonAn"))
            {
                sp.MdiParent = this;
                sp.Show();
                sp.FormClosed += new FormClosedEventHandler(frm_FromClose);
            }
            else
            {
                ActiveChildForm("MonAn");
            }
        }
        private void quảnLýNhómMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhomMonAn sp = new NhomMonAn(vaiTro);
            if (!CheckExistForm("NhomMonAn"))
            {
                sp.MdiParent = this;
                sp.Show();
                sp.FormClosed += new FormClosedEventHandler(frm_FromClose);
            }
            else
            {
                ActiveChildForm("NhomMonAn");
            }
        }
        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon sp = new HoaDon(vaiTro);
            if (!CheckExistForm("HoaDon"))
            {
                sp.Show();
                sp.FormClosed += new FormClosedEventHandler(frm_FromClose);
            }
            else
            {
                ActiveChildForm("HoaDon");
            }
        }
        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe sp = new ThongKe();
            if (!CheckExistForm("ThongKe"))
            {
                sp.MdiParent = this;
                sp.Show();
                sp.FormClosed += new FormClosedEventHandler(frm_FromClose);
            }
            else
            {
                ActiveChildForm("ThongKe");
            }
        }
        private void quảnLýLịchLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LichLam sp = new LichLam(vaiTro);
            if (!CheckExistForm("LichLam"))
            {
                sp.MdiParent = this;
                sp.Show();
                sp.FormClosed += new FormClosedEventHandler(frm_FromClose);
            }
            else
            {
                ActiveChildForm("LichLam");
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            ResetValue();
            ManHinhChao mha = new ManHinhChao();
            mha.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
