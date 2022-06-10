using System;
using System.Data;
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

        public static bool kiemTraThoiGianTrongLich(DateTime ngayDangKy, String maLich)
        {
            LichLamViecDTO lichLamViec = LichLamViecDAO.docLichLamViec(maLich);
            if (ngayDangKy >= lichLamViec.NgayApDung && ngayDangKy <= lichLamViec.NgayKetThuc) return true;
            return false;
        }

        public static bool kiemTraTonTaiTrongLichDangKy(DataTable thongTinDangKy, DateTime ngay, String ca)
        {
            if (thongTinDangKy == null || thongTinDangKy.Rows.Count == 0) return true;
            foreach(DataRow row in thongTinDangKy.Rows)
            {
                if (DateTime.Parse(row["NGAY"].ToString()) == ngay && row["CA"].ToString() == ca) return false;
            }
            return true;
        }
    }
}
