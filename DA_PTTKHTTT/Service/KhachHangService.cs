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
    internal class KhachHangService
    {
        public static KhachHangDTO docThongTinKH(string maKH)
        {
            KhachHangDTO kh = new KhachHangDTO();
            DataTable dt = KhachHangDAO.docCTKhachHang(maKH);

            if (dt.Rows.Count > 0)
            {
                kh.MaKH = dt.Rows[0]["MAKH"].ToString();
                kh.TenKH = dt.Rows[0]["TENKH"].ToString();
                kh.Sdt = dt.Rows[0]["SODT"].ToString();
                kh.DiaChi = dt.Rows[0]["DIACHI"].ToString();
                return kh;
            }
            return null;
        }

        public static KhachHangDTO khoiTaoKH(string tenKH, string sdt, string diaChi, string gioiTinh)
        {
            KhachHangDTO kh = new KhachHangDTO();

            kh.TenKH = tenKH;
            kh.Sdt = sdt;
            kh.DiaChi = diaChi;
            kh.GioiTinh = gioiTinh;

            return kh;
        }

    }
}
