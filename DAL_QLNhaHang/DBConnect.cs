using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL_QLNhaHang
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=MINHPHUOC\SQLEXPRESS;Initial Catalog=QLNhaHang_DuAn1_Nhom4;Integrated Security=True");
    }
}
