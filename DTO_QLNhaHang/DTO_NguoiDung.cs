using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhaHang
{
    public class DTO_NguoiDung
    {
        private string TaiKhoan;
        private string MatKhau;
        private string TenNV;
        private string GioiTinh;
        private string DiaChi;
        private string SDT;
        private string NgaySinh;
        private string NgayVaoLam;
        private int LichLam;
        private int ChucVu;
        private int Luong;



        public string taikhoan
        {
            get { return TaiKhoan; }
            set { TaiKhoan = value; }
        }


        public string matkhau
        {
            get { return MatKhau; }
            set { MatKhau = value; }
        }


        public string tenNV
        {
            get { return TenNV; }
            set { TenNV = value; }
        }


        public string gioitinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }


        public string diachi
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }


        public string sdt
        {
            get { return SDT; }
            set { SDT = value; }
        }



        public string ngaysinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }



        public string ngayvaolam
        {
            get { return NgayVaoLam; }
            set { NgayVaoLam = value; }
        }



        public int chucvu
        {
            get { return ChucVu; }
            set { ChucVu = value; }
        }


        public int luong
        {
            get { return Luong; }
            set { Luong = value; }
        }

        public int lichlam { get => LichLam; set => LichLam = value; }

        public DTO_NguoiDung()
        {

        }

        public DTO_NguoiDung(string taiKhoan, string matKhau, string tenNV, string gioiTinh, string diaChi, string sDT, string ngaySinh, string ngayVaoLam, int lichLam, int chucVu, int luong)
        {
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
            TenNV = tenNV;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SDT = sDT;
            NgaySinh = ngaySinh;
            NgayVaoLam = ngayVaoLam;
            LichLam = lichLam;
            ChucVu = chucVu;
            Luong = luong;
        }
    }
}
