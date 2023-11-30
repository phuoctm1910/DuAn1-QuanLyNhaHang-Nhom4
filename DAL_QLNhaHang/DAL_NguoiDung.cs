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
    public class DAL_NguoiDung : DBConnect
    {

        public DataTable LayLichLam()
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
        public DataTable LayCapDoLuong()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[LayCapDoLuong]";
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
        public DataTable LayVaiTro()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[LayVaiTro]";
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
        public DataTable DanhSachNguoiDung()
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
        public bool ThemNguoiDung(DTO_NguoiDung ND)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[InsertNguoiDung]";
                cmd.Parameters.AddWithValue("taikhoan", ND.taikhoan);
                cmd.Parameters.AddWithValue("matkhau", ND.matkhau);
                cmd.Parameters.AddWithValue("tenNv", ND.tenNV);
                cmd.Parameters.AddWithValue("Gioitinh", ND.gioitinh);
                cmd.Parameters.AddWithValue("Diachi", ND.diachi);
                cmd.Parameters.AddWithValue("soDT", ND.sdt);
                cmd.Parameters.AddWithValue("ngaysinh", ND.ngaysinh);
                cmd.Parameters.AddWithValue("ngayvaolam", ND.ngayvaolam);
                cmd.Parameters.AddWithValue("chucvu", ND.chucvu);
                cmd.Parameters.AddWithValue("luong", ND.luong);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            finally { _conn.Close(); }
            return false;

        }
        public bool CapNhatNguoiDung(DTO_NguoiDung ND, string manv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[UpdateNguoiDung]";
                cmd.Parameters.AddWithValue("taikhoan", ND.taikhoan);
                cmd.Parameters.AddWithValue("matkhau", ND.matkhau);
                cmd.Parameters.AddWithValue("tenNV", ND.tenNV);
                cmd.Parameters.AddWithValue("Gioitinh", ND.gioitinh);
                cmd.Parameters.AddWithValue("Diachi", ND.diachi);
                cmd.Parameters.AddWithValue("soDT", ND.sdt);
                cmd.Parameters.AddWithValue("ngaysinh", ND.ngaysinh);
                cmd.Parameters.AddWithValue("ngayvaolam", ND.ngayvaolam);
                cmd.Parameters.AddWithValue("chucvu", ND.chucvu);
                cmd.Parameters.AddWithValue("luong", ND.luong);
                cmd.Parameters.AddWithValue("maNV", manv);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            finally { _conn.Close(); }
            return false;
        }
        public bool XoaNguoiDung(DTO_NguoiDung ND, string manv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DeleteNguoiDung]";
                cmd.Parameters.AddWithValue("MaNV", manv);
                if (cmd.ExecuteNonQuery() > 0)
                {

                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;

        }
        public DataTable SearchNguoiDung(DTO_NguoiDung ND, string manv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[SearchNguoiDung]";
                cmd.Parameters.AddWithValue("MaNV", manv);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
        public bool NguoiDungDangNhap(string taikhoan, string matkhau)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[Login]";
                cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
                cmd.Parameters.AddWithValue("@matkhau", matkhau);

                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public DataTable VaiTroNV(string taikhoan)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[LayVaiTroND]";
                cmd.Parameters.AddWithValue("taikhoan", taikhoan);
                DataTable dtNhanvien = new DataTable();
                dtNhanvien.Load(cmd.ExecuteReader());
                return dtNhanvien;
            }
            catch (Exception)
            {

                throw;
            }
            finally { _conn.Close(); }
        }
    }
}
