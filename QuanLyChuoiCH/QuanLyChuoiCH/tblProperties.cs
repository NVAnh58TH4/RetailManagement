using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChuoiCH
{
    class Nhanvien
    {
        public string MaNV { set; get; }
        public string TenNV { set; get; }
        public DateTime NgaySinh { set; get; }
        public string Gioitinh { set; get; }
        public string MaCH { set; get; }
    }
    class Cuahang
    {
        public string MaCH { set; get; }
        public string TenCH { set; get; }
        public string Diachi { set; get; }
    }
    class Khachhang
    {
        public string MaKH { set; get; }
        public string TenKH { set; get; }
        public string Diachi { set; get; }
    }
    class Mathang
    {
        public string MaH { set; get; }
        public string TenH { set; get; }
        public string Dvitinh { set; get; }
        public int Gia { set; get; }
    }
    class Hoadon
    {
        public string MaHD { set; get; }
        public string MaKH { set; get; }
        public string MaCH { set; get; }
        public DateTime Ngaylap { set; get; }
    }
    class ChitietHD
    {
        public string MaHD { set; get; }
        public string MaH { set; get; }
        public int Soluong { set; get; }
    }
}
