﻿using System;
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
        public DataTable LayMonAn()
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DanhSachMonAn]";
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
        public DataTable LayDonGia(string tenMonAn)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[LayDonGia]";
                cmd.Parameters.AddWithValue("@tenMonAn", tenMonAn);
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
        public DataTable DanhSachHoaDonChiTiet(string mahd)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DanhSachHoaDonChiTiet]";
                cmd.Parameters.AddWithValue("mahd", mahd);
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
        public DataTable DanhSachHoaDonChiTietFull(string mahd)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[DanhSachHoaDonChiTietFull]";
                cmd.Parameters.AddWithValue("mahd", mahd);
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
        public bool CapNhatHoaDon(string mahd, int tongtien)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateInHoaDon";
                cmd.Parameters.AddWithValue("mahd", mahd);
                cmd.Parameters.AddWithValue("tongtien", tongtien);
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
        public bool CapNhatTrangThai(string mahd)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateTrangThaiHoaDon";
                cmd.Parameters.AddWithValue("mahd", mahd);
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
        public bool HuyHoaDonChiTiet(string mahd)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CancelHoaDonChiTiet";
                cmd.Parameters.AddWithValue("mahd", mahd);

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
