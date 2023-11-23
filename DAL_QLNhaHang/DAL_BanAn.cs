using DTO_QLNhaHang;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLNhaHang
{
    public class DAL_BanAn : DBConnect
    {
        public DataTable DanhSachBanAn()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DanhSachBanAn]";
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }

            finally { _conn.Close(); }
        }
        public bool ThemBanAn(DTO_BanAn ba)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[InsertBanAn]";
                cmd.Parameters.AddWithValue("tenbanan", ba.TenBanAn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            finally { _conn.Close(); }
            return false;
        }
        public bool CapNhatBanAn(DTO_BanAn ba, string mabanan)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[UpdateBanAn]";
                cmd.Parameters.AddWithValue("tenbanan", ba.TenBanAn);
                cmd.Parameters.AddWithValue("mabanan", mabanan);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }
        public bool XoaBanAn(string MaBanAn)
        {

            {
                try
                {
                    _conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = _conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[DeleteBanAn]";
                    cmd.Parameters.AddWithValue("mabanan", MaBanAn);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }

                }
                catch (Exception)
                { }
                finally { _conn.Close(); }
                return false;
            }
        }

    }
}
