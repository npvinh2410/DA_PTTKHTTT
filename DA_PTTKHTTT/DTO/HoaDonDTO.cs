using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DTO
{
    class HoaDonDTO
    {
        private string maHD;
        private int soLuong;
        private int tongTien;
        private string maKH;
        private string maDK;
        private int lanTT;
        private string pTTT;
        private string hTTT;

        public string MaHD { get => maHD; set => maHD = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaDK { get => maDK; set => maDK = value; }
        public int LanTT { get => lanTT; set => lanTT = value; }
        public string PTTT { get => pTTT; set => pTTT = value; }
        public string HTTT { get => hTTT; set => hTTT = value; }
    }
}

