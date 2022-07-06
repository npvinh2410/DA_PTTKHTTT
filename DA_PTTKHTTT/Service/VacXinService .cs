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
    internal class VacXinService
    {
        public static DataTable docDanhSachVC()
        {
            return VacXinDAO.docDanhSachVacXin();
        }

        public static bool KiemTraSLVacXinton(string mavc)
        {
            int sl = VacXinDAO.docSLVacXinton(mavc);
            if (sl > 0) return true;
            return false;
        }

        public static string datMuaVC(string maKH, KhachHangDTO kh, List<string> dsMaGoi, List<string> dsMaVC)
        {
            if (maKH == "")
            {
                maKH = KhachHangDAO.themKhachHang(kh);
            }

            if (maKH == null)
            {
                return null;
            }

            string maPD = PhieuDatMuaDAO.themPhieuDatMua(maKH);

            if(maPD == null)
            {
                return null;
            }

            for(int i = 0; i < dsMaGoi.Count; i++)
            {
                if(!CTPhieuDatMuaDAO.themCTPhieuDatMuaTheoGoi(maPD, dsMaGoi[i]))
                    return null;
            }

            for(int j = 0; j < dsMaVC.Count; j++)
            {
                if (!CTPhieuDatMuaDAO.themCTPhieuDatMua(maPD, dsMaVC[j], 1)) 
                    return null;
            }

            return maKH;
        }
    }
}
