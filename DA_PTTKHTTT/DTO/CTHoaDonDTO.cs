using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DTO
{
    class CTHoaDonDTO
    {
        private string maHD;
        private string maVC;
        private int soLuong;
        private int thanhTien;

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaVC { get => maVC; set => maVC = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}

