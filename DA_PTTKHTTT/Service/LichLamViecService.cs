using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_PTTKHTTT.DAO;
using DA_PTTKHTTT.DTO;


namespace DA_PTTKHTTT.Service
{
    class LichLamViecService
    {
        public static List<LichLamViecDTO> DocKhoangThoiGianLichLamViec()
        {
            List<LichLamViecDTO> lichLamViecs = LichLamViecDAO.docKhoangThoiGianLichLamViec();
            return lichLamViecs;
        }

        public static bool KiemTraThoiGianHopLe(DateTime fromTime, DateTime toTime)
        {
            if (fromTime > toTime) return false;
            return true;
        }

        public static bool themLichLamViec(LichLamViecDTO lichLamViec)
        {
            return LichLamViecDAO.themLichLamViec(lichLamViec);
        }

        public static LichLamViecDTO khoiTao(DateTime fromTime, DateTime toTime)
        {
            LichLamViecDTO lichLamViec = new LichLamViecDTO();
            lichLamViec.NgayApDung = fromTime;
            lichLamViec.NgayKetThuc = toTime;
            lichLamViec.TrangThai = "0";
            return lichLamViec;
        }
    }
}
