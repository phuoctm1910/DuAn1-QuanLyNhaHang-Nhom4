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
            this.IsMdiContainer = true;
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
        void HienThiVaiTroNV()
        {
            quảnLýNhómMónĂnToolStripMenuItem.Visible = false;
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
                    HienThiVaiTroNV();
                }
            }

        }
        private void frm_FromClose(object sender, FormClosedEventArgs e)
        {
            ResetValue();
        }
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
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
    }
}
