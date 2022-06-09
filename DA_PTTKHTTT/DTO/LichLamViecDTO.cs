using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DTO
{
    class LichLamViecDTO
    {
        private String maLich;
        private DateTime ngayApDung;
        private DateTime ngayKetThuc;
        private String trangThai;

        public string MaLich { get => maLich; set => maLich = value; }
        public DateTime NgayApDung { get => ngayApDung; set => ngayApDung = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public String TrangThai { get => trangThai; set => trangThai = value; }
    }
}
