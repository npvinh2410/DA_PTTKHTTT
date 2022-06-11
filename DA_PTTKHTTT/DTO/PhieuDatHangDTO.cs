using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DTO
{
    internal class PhieuDatHangDTO
    {
        private string maDH;
        private DateTime ngayDat;
        private string nvDH;
        private string trangThai;

        public string MaDH { get => maDH; set => maDH = value; }
        public DateTime NgayDat { get => ngayDat; set => ngayDat = value; }
        public string NvDH { get => nvDH; set => nvDH = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
