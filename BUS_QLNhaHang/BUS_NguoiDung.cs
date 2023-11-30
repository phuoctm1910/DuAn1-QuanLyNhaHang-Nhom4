using DAL_QLNhaHang;
using DTO_QLNhaHang;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLNhaHang
{
    public class BUS_NguoiDung
    {
        DAL_NguoiDung dalnguoidung = new DAL_NguoiDung();

        public DataTable LayVaiTro()
        {
            return dalnguoidung.LayVaiTro();
        }

        public DataTable LayCapDoLuong()
        {
            return dalnguoidung.LayCapDoLuong();
        }

        public DataTable LayLichLam()
        {
            return dalnguoidung.LayLichLam();
        }

        public DataTable DanhSachNguoiDung()
        {
            return dalnguoidung.DanhSachNguoiDung();
        }

        public bool ThemNguoiDung(DTO_NguoiDung ND)
        {
            return dalnguoidung.ThemNguoiDung(ND);
        }

        public bool CapNhatNguoiDung(DTO_NguoiDung ND, string manv)
        {
            return dalnguoidung.CapNhatNguoiDung(ND, manv);
        }

        public bool XoaNguoiDung(DTO_NguoiDung ND, string manv)
        {
            return dalnguoidung.XoaNguoiDung(ND, manv);
        }

        public DataTable SearchNguoiDung(DTO_NguoiDung ND, string manv)
        {
            return dalnguoidung.SearchNguoiDung(ND, manv);
        }

        public string Encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encoding = new UTF8Encoding();
            //mã hóa chuỗi mật khẩu đc cho thành Encrypt data
            encrypt = md5.ComputeHash(encoding.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            //tạo một chuỗi mới bằng cách sử dụng Encrypting data
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }
    }
}
