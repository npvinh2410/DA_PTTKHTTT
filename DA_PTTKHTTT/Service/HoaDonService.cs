using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DA_PTTKHTTT.DAO;
using DA_PTTKHTTT.DTO;

namespace DA_PTTKHTTT.Service
{
    class HoaDonService
    {
        public static DataTable DocHoaDon(string maKH)
        {
            return HoaDonDAO.docHoaDon(maKH);
        }

        public static DataTable DocCTHoaDon(string maHD)
        {
            return CTHoaDonDAO.docCTHoaDon(maHD);
        }

        public static bool TaoHoaDon(string pttt, string httt, string maHD)
        {
            return HoaDonDAO.taoHoaDon(pttt, httt, maHD);
        }

        public static bool TaoCTHoaDon(string maHD)
        {
            return HoaDonDAO.taoCTHoaDon(maHD);
        }

        public static int THThanhtoan(string lantt, string pttt)
        {
            return HoaDonDAO.ThThanhToan(lantt, pttt);

        }

        public static bool ThanhToanHoaDon(string mahd, string lantt, string pttt)
        {
            return HoaDonDAO.thanhtoanHoaDon(mahd, lantt, pttt);
        }

        public static bool update_PhieuDK(string maDK)
        {
            return HoaDonDAO.update_phieuDK(maDK);
        }
    }
}
