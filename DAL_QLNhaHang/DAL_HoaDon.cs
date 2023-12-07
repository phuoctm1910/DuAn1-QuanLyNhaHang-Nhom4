using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNhaHang;
using DTO_QLNhaHang;

namespace DAL_QLNhaHang
{
    public class DAL_HoaDon : DBConnect
    {
        public DataTable ThongKe()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[ThongKe]";
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
        public DataTable LayNguoiDung()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DanhSachNguoiDung]";
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

        public DataTable LayKhachHang()
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
            finally { _conn.Close(); }

        }


        public DataTable LayBanAn()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[LayBanAn]";
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }

        }


        public DataTable DanhSachHoaDon()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DanhSachHoaDon]";
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }

        }


        public bool ThemHoaDon(DTO_HoaDon HD, int tongtien)
        {
            try
            {

                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[InsertHoaDon]";
                cmd.Parameters.AddWithValue("maNV", HD.MaNV);
                cmd.Parameters.AddWithValue("maKH", HD.MaKH);
                cmd.Parameters.AddWithValue("MaBanAn", HD.MaBanAn);
                cmd.Parameters.AddWithValue("ngayLap", HD.NgayLap);
                cmd.Parameters.AddWithValue("trangThai", HD.TrangThai);
                cmd.Parameters.AddWithValue("giamgia", HD.GiamGia);
                cmd.Parameters.AddWithValue("tongtien", tongtien);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            finally { _conn.Close(); }
            return false;

        }



        public bool CapNhatHoaDon(DTO_HoaDon HD, string mahd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[UpdateHoaDon]";
                cmd.Parameters.AddWithValue("MaHD", mahd);
                cmd.Parameters.AddWithValue("MaNV", HD.MaNV);
                cmd.Parameters.AddWithValue("MaKH", HD.MaKH);
                cmd.Parameters.AddWithValue("MaBanAn", HD.MaBanAn);
                cmd.Parameters.AddWithValue("NgayLap", HD.NgayLap);
                cmd.Parameters.AddWithValue("TrangThai", HD.TrangThai);
                cmd.Parameters.AddWithValue("GiamGia", HD.GiamGia);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            finally { _conn.Close(); }
            return false;
        }



        public bool XoaHoaDon(DTO_HoaDon hoaDon, string mahd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DeleteHoaDon]";
                cmd.Parameters.AddWithValue("MaHD", mahd);
                if (cmd.ExecuteNonQuery() > 0)
                {

                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { _conn.Close(); }
            return false;

        }


        public DataTable SearchHoaDon(string mahd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[SearchHoaDon]";
                cmd.Parameters.AddWithValue("MaHD", mahd);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }

    }
}
