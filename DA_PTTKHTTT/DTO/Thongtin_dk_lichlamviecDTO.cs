using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DTO
{
    class Thongtin_dk_lichlamviecDTO
    {
        private String maLich;
        private String maNV;
        private DateTime ngay;
        private String ca;
        private DateTime ngaytao;

        public string MaLich { get => maLich; set => maLich = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public string Ca { get => ca; set => ca = value; }
        public DateTime Ngaytao { get => ngaytao; set => ngaytao = value; }
    }
}
