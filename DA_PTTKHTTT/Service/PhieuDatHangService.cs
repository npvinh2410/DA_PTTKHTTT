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
    internal class PhieuDatHangService
    {
        public static DataTable docDanhSachPhieuDatHang()
        {
            return PhieuDatHangDAO.docDSPhieuDatHang();
        }

        public static DataTable docCTPhieuDatHang(string maDH)
        {
            return CTPhieuDatHangDAO.docCTPhieuDatHang(maDH);
        }
    }
}
