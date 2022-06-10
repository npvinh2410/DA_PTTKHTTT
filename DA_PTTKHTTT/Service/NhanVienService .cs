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
    class NhanVienService
    {
        public static DataTable DocKhoangThoiGianLichLamViec(String maLich)
        {
            if(maLich != null && maLich != "")
            {
                DataTable lichLamViecs = NhanVienDAO.docDanhSachNhanVienDangKyLich(maLich);
                return lichLamViecs;
            }
            else
            {
                return null;
            }
        }

        public static NhanVienDTO docThongTinNV()
        {
            return NhanVienDAO.docThongTin();
        }
    }
}
