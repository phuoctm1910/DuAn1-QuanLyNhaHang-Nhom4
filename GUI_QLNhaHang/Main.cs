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
    }
}
