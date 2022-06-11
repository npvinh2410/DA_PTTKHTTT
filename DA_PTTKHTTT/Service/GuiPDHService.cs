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
            string maDHCu = PhieuDatHangDAO.docIDChoDatPhieuDatHang();
            string tienTo = maDHCu.Substring(0, 2);
            string idCu = maDHCu.Substring(2);
            string idMoi = (Int32.Parse(maDHCu.Substring(2)) + 1).ToString();
            string maDHMoi = tienTo + idMoi.PadLeft(idCu.Length - idMoi.Length + 1, '0'); ;

            if (!PhieuDatHangDAO.capNhatPhieuDatHang(maDHCu))
            {
                return false;
            }

            PhieuDatHangDAO.themPhieuDatHang(maDHMoi);

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
