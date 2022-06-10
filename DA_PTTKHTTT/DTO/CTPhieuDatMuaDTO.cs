using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DTO
{
    internal class CTPhieuDatMuaDTO
    {
        private string maPD;
        private string maVC;
        private int soLuong;
        private int donGia;
        private int thanhTien;

        public string MaPD { get => maPD; set => maPD = value; }
        public string MaVC { get => maVC; set => maVC = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
