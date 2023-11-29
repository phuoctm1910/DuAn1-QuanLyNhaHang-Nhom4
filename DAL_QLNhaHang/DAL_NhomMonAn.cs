using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLNhaHang;

namespace DAL_QLNhaHang
{
    public class DAL_NhomMonAn : DBConnect
    {
        public DataTable DanhSachNhomMonAn()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DanhSachNhomMonAn]";
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
            finally { _conn.Close(); }
        }
        public bool ThemNhomMonAn(DTO_NhomMonAn nma)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[InsertNhomMonAn]";
                cmd.Parameters.AddWithValue("tennhom", nma.TenNhomMonAn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            finally { _conn.Close(); }
            return false;
        }
        public bool CapNhatNhomMonAn(DTO_NhomMonAn nma, string ma)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[UpdateNhomMonAn]";
                cmd.Parameters.AddWithValue("manhomMonan", ma);
                cmd.Parameters.AddWithValue("tennhom", nma.TenNhomMonAn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            finally { _conn.Close(); }
            return false;
        }

        public bool XoaNhomMonAn(string ma)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DeleteNhomMonAn]";
                cmd.Parameters.AddWithValue("manhomMonan", ma);
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

