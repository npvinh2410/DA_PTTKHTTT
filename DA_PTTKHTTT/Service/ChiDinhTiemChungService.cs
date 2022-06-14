using DA_PTTKHTTT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.Service
{
    internal class ChiDinhTiemChungService
    {
        public static DataTable chidinhChoTiem(string maHS, string chidinh)
        {
            return HoSoTiemChungDAO.capnhatchopheptiem(maHS, chidinh);
        }
        public static DataTable chidinhKhongChoTiem(string maHS, string chidinh)
        {
            return HoSoTiemChungDAO.capnhatkhongchopheptiem(maHS, chidinh);
        }
    }
}
