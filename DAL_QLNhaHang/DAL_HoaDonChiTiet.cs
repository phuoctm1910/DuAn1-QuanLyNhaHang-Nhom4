using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QLNhaHang;

namespace DAL_QLNhaHang
{
    public class DAL_HoaDonChiTiet : DBConnect
    {
        public DataTable DanhSachHoaDonChiTiet()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DanhSachHoaDonChiTiet]";
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool ThemHoaDonChiTiet(DTO_HoaDonChiTiet hdct)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertHoaDonChiTiet";
                cmd.Parameters.AddWithValue("mahdct", hdct.MaHDCT);
                cmd.Parameters.AddWithValue("mahd", hdct.MaHD);
                cmd.Parameters.AddWithValue("mamonan", hdct.MaMonAn);
                cmd.Parameters.AddWithValue("dongia", hdct.DonGia);
                cmd.Parameters.AddWithValue("soluong", hdct.SoLuong);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                _conn.Close();
            }
            return false;

        }

        public bool XoaHoaDonChiTiet(string mahdct)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteHoaDonChiTiet";
                cmd.Parameters.AddWithValue("mahdct", mahdct);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {


            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
