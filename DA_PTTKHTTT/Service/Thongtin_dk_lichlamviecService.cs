using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DA_PTTKHTTT.DAO;
using DA_PTTKHTTT.DTO;

namespace DA_PTTKHTTT.Service
{
    class Thongtin_dk_lichlamviecService
    {
        public static DataTable docLichDangKyNhanVien(String maLich, String maNV)
        {
            if (maLich == null || maLich == "" || maNV == null || maNV == "") return null;
            DataTable dataTable = Thongtin_dk_lichlamviecDAO.docLichDangKyNhanVien(maLich, maNV);
            return dataTable;
        }
        public static bool themLichDangKy(List<Thongtin_dk_lichlamviecDTO> thongTinDangKys)
        {
            return Thongtin_dk_lichlamviecDAO.themLichDangKy(thongTinDangKys);
        }

    }
}
