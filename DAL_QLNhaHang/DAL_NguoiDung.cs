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


                if (dt.Columns.Count < 9)
                {
                    for (int i = dt.Columns.Count; i < 9; i++)
                    {
                        dt.Columns.Add(new DataColumn("Column" + i.ToString()));
                    }
                }

                if (!dt.Columns.Contains("NgaySinh"))
                {
                    dt.Columns.Add("NgaySinh", typeof(string));
                }
                if (!dt.Columns.Contains("NgayVaoLam"))
                {
                    dt.Columns.Add("NgayVaoLam", typeof(string));
                }
                if (!dt.Columns.Contains("ChucVu"))
                {
                    dt.Columns.Add("ChucVu", typeof(int));
                }
                if (!dt.Columns.Contains("Luong"))
                {
                    dt.Columns.Add("Luong", typeof(int));
                }

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
    }
}
                                                                                    