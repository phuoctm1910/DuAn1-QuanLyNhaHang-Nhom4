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
    public class DAL_MonAn : DBConnect
    {
        public DataTable DanhSachNhomMonAn()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachNhomMonAn";
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
        public DataTable DanhSachMonAn()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachMonAn";
                cmd.Connection = _conn;
                DataTable dtMonAn = new DataTable();
                dtMonAn.Load(cmd.ExecuteReader());

                return dtMonAn;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool ThemMonAn(DTO_MonAn ma)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[InsertMonAn]";
                cmd.Parameters.AddWithValue("TenMonAn", ma.TenMonAn);
                cmd.Parameters.AddWithValue("DonGia", ma.DonGia);
                cmd.Parameters.AddWithValue("MaNhomMonAn", ma.MaNhomMonAn);

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

        public bool CapNhatMonAn(DTO_MonAn ma, string mamonan)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[UpdateMonAn]";
                cmd.Parameters.AddWithValue("mamonan", mamonan);
                cmd.Parameters.AddWithValue("TenMonAn", ma.TenMonAn);
                cmd.Parameters.AddWithValue("DonGia", ma.DonGia);
                cmd.Parameters.AddWithValue("MaNhomMonAn", ma.MaNhomMonAn);

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

        public bool XoaMonAn(string mamonan)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteMonAn";
                cmd.Parameters.AddWithValue("mamonan", mamonan);

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
