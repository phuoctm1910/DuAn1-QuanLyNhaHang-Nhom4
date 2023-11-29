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
    public class DAL_KhachHang : DBConnect
    {
        public DataTable DanhSachKhachHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DanhSachKhachHang]";
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
        public bool ThemKhachHang(DTO_KhachHang kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[InsertKhachHang]";
                cmd.Parameters.AddWithValue("tenkh", kh.TenKH);
                cmd.Parameters.AddWithValue("ngaysinh", kh.NgaySinh);
                cmd.Parameters.AddWithValue("gioitinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("diachi", kh.DiaChi);
                cmd.Parameters.AddWithValue("sdt", kh.SoDT);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            finally { _conn.Close(); }
            return false;
        }
        public bool CapNhatKhachHang(DTO_KhachHang kh, string makh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[UpdateKhachHang]";
                cmd.Parameters.AddWithValue("tenkh", kh.TenKH);
                cmd.Parameters.AddWithValue("ngaysinh", kh.NgaySinh);
                cmd.Parameters.AddWithValue("gioitinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("diachi", kh.DiaChi);
                cmd.Parameters.AddWithValue("sdt", kh.SoDT);
                cmd.Parameters.AddWithValue("makh", makh);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            finally { _conn.Close(); }
            return false;
        }

        public bool XoaKhachHang(string makh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DeleteKhachHang]";
                cmd.Parameters.AddWithValue("makh", makh);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            finally { _conn.Close(); }
            return false;
        }
        public DataTable TimKhachHang(string sdt)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[SearchKhachHang]";
                cmd.Parameters.AddWithValue("sodt", sdt);
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
    }
}
