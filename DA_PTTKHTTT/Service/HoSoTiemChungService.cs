using DA_PTTKHTTT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.Service
{
    internal class HoSoTiemChungService
    {
        public static DataTable docDanhSachKhachHangTiem() => HoSoTiemChungDAO.xemHoSoKhachHang();
    }
}
