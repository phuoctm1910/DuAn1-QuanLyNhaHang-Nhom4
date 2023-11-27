using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_QLNhaHang
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-TQCOIRD;Initial Catalog=QLNhaHang_DuAn1_Nhom4;Integrated Security=True");
    }
}
