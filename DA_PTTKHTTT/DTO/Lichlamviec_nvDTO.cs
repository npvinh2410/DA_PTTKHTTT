using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DTO
{
    class Lichlamviec_nvDTO
    {
        private String maLich;
        private String maNV;
        private DateTime ngay;
        private String ca;
        private String nvQuyetDinh;

        public string MaLich { get => maLich; set => maLich = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public string Ca { get => ca; set => ca = value; }
        public string NvQuyetDinh { get => nvQuyetDinh; set => nvQuyetDinh = value; }
    }
}
