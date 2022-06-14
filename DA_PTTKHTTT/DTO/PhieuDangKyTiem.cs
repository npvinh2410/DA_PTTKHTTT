using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DTO
{
    class PhieuDangKyTiem
    {
        private string madk;
        private DateTime ngaylap;
        private string maKH;
        private string tinhtrangthanhtoan;
        private float tongtien;
        private string loaitiem;

        public string Madk { get => madk; set => madk = value; }
        public DateTime Ngaylap { get => ngaylap; set => ngaylap = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string Tinhtrangthanhtoan { get => tinhtrangthanhtoan; set => tinhtrangthanhtoan = value; }
        public float Tongtien { get => tongtien; set => tongtien = value; }
        public string Loaitiem { get => loaitiem; set => loaitiem = value; }
    }
}
