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

        public static bool DuyetPDM(List<string> dsMaPD, int trangThai)
        {
            List<CTPhieuDatMuaDTO> CTPhieuDatMuas = new List<CTPhieuDatMuaDTO>();
            PhieuDatMuaDAO.capNhatTrangThaiDuyet(dsMaPD, trangThai);

            if (trangThai == 0)
            {
                return true;
            }

            string maDH = PhieuDatHangDAO.docIDChoDatPhieuDatHang();
            CTPhieuDatMuas = CTPhieuDatMuaDAO.docCTPhieuDatMuaDuocDuyet(dsMaPD);

            for (int i = 0; i < CTPhieuDatMuas.Count; i++)
            {
                string maVC = CTPhieuDatMuas[i].MaVC;
                int soLuong = CTPhieuDatMuas[i].SoLuong;

                CTPhieuDatHangDAO.themCTPhieuDatHang(maDH, maVC, soLuong);
            }

            return true;
        }

        public static DataTable docDSDatMuaKH(string maKH)
        {
            return PhieuDatMuaDAO.docDSPhieuDatMuaKH(maKH);
        }
    }
}
