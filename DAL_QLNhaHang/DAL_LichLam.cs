using DTO_QLNhaHang;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLNhaHang
{
    public class DAL_LichLam : DBConnect
    {
        public DataTable DanhSachLichLam()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DanhSachLichLam]";
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }

            finally { _conn.Close(); }
        }
        public bool ThemLichLam(DTO_LichLam ll)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[InsertLichLam]";
                cmd.Parameters.AddWithValue("LichLam", ll.LichLam);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            finally { _conn.Close(); }
            return false;
        }
        public bool CapNhatLichLam(DTO_LichLam ll, int id)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[UpdateLichLam]";
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("lichlam", ll.LichLam);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }
    }
}
