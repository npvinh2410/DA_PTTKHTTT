using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DTO
{
    class NhanVienDTO
    {
        private String maNV;
        private String tenNV;
        private String diaChi;
        private String dienThoai;
        private String email;
        private int Luong;
        private String viTri;
        private String maTT;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string Email { get => email; set => email = value; }
        public int Luong1 { get => Luong; set => Luong = value; }
        public string ViTri { get => viTri; set => viTri = value; }
        public string MaTT { get => maTT; set => maTT = value; }
    }
}
