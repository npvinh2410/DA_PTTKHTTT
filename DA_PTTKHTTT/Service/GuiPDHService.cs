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
    internal class GuiPDHService
    {
        public static bool GuiPDH()
        {


            return true;
        }

        public static DataTable docDanhSachCTPhieuDatHang()
        {
            string maDH = PhieuDatHangDAO.docIDChoDatPhieuDatHang();

            return CTPhieuDatHangDAO.docCTPhieuDatHang(maDH);
        }

        public static int docSoLuongVCDH()
        {
            return PhieuDatHangDAO.docSoLuongVCChoDat();
        }
    }
}
