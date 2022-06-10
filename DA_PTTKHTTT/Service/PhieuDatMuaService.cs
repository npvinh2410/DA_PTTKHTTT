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
    internal class PhieuDatMuaService
    {
        public static DataTable docDanhSachPhieuDatMuaChoDuyet()
        {
            return PhieuDatMuaDAO.docDSPhieuDatMuaChoDuyet();
        }

        public static DataTable docCTPhieuDatMua(string maPD)
        {
            return CTPhieuDatMuaDAO.docCTPhieuDatMua(maPD);
        }
    }
}
