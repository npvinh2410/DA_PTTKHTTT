using DA_PTTKHTTT.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.Service
{
    internal class HoSoKhamBenhService
    {
        public static DataTable docThongTinTiemChung(string maHS)
        {
            return HoSoTiemChungDAO.xemHoSoKhachHang(maHS);
        }

        public static DataTable capnhatThongTinTiemChung(string maHS, string NhietDo, string HuyetAp, string cotiensuBenhNen)
        {
            return HoSoTiemChungDAO.capnhatHoSoKhamBenh(maHS, NhietDo, HuyetAp, cotiensuBenhNen);
        }
    }
}