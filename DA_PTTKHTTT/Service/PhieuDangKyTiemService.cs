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
    class PhieuDangKyTiemService
    {
        public static DataTable docdsPhieuDangKyTiem(string maKH)
        {
            return PhieuDangKyTiemDAO.docdsPhieuDangKyTiem(maKH);
        }

        public static KhachHangDTO docThongTinKH(string maKH)
        {
            KhachHangDTO kh = new KhachHangDTO();
            DataTable dt = KhachHangDAO.docCTKhachHang(maKH);

            if (dt.Rows.Count > 0)
            {
                kh.MaKH = dt.Rows[0]["MAKH"].ToString();
                kh.TenKH = dt.Rows[0]["TENKH"].ToString();
                kh.Sdt = dt.Rows[0]["SODT"].ToString();
                kh.GioiTinh = dt.Rows[0]["GIOITINH"].ToString();
                kh.DiaChi = dt.Rows[0]["DIACHI"].ToString();
                kh.NguoiThan = dt.Rows[0]["TENNGUOITHAN"].ToString();
                kh.MoiQuanHe = dt.Rows[0]["MOIQUANHE"].ToString();
                kh.SdtNguoiThan = dt.Rows[0]["SODTNGUOITHAN"].ToString();
                return kh;
            }
            return null;
        }

        public static string dkGoiTiemLe(string maKH, KhachHangDTO kh, List<CTDangKyGoiTiemLeDTO> ds)
        {
            if (maKH == "")
            {
                maKH = KhachHangDAO.themKhachHang(kh);
            }

            if (maKH == null)
            {
                return null;
            }

            string madk = PhieuDangKyTiemDAO.themPhieuDangKyTiem(maKH, "GOI TIEM LE");
            string mahd = HoaDonDAO.themHoaDon(maKH, madk);
            if (madk == null||mahd==null)
            {
                return null;
            }

            for (int i = 0; i < ds.Count; i++)
            {
                if (!CTDangKyGoiTiemLeDAO.themCTDangKyGoiTiemLe(madk, ds[i].MaVC, ds[i].Ngaytiem, ds[i].Trungtamtiem))
                    return null;
            }

            return maKH;
        }
        public static string dkGoiTiem(string maKH, KhachHangDTO kh, List<CTDangKyGoiTiemDTO> ds)
        {
            if (maKH == "")
            {
                maKH = KhachHangDAO.themKhachHang(kh);
            }

            if (maKH == null)
            {
                return null;
            }

            string madk = PhieuDangKyTiemDAO.themPhieuDangKyTiem(maKH, "TIEM THEO GOI");
            string mahd = HoaDonDAO.themHoaDon(maKH, madk);

            if (madk == null || mahd == null)
            {
                return null;
            }

            for (int i = 0; i < ds.Count; i++)
            {
                if (!CTDangKyGoiTiemDAO.themCTDangKyGoiTiem(madk, ds[i].MaGT, ds[i].Ngaytiem, ds[i].Trungtamtiem))
                    return null;
            }

            return maKH;
        }
    }
}
