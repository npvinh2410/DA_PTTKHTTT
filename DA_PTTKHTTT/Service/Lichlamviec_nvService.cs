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
    class Lichlamviec_nvService
    {
        public static Lichlamviec_nvDTO khoiTao(String maLich, String maNV, DateTime ngay, String Ca, String MaNVDH)
        {
            Lichlamviec_nvDTO lichlamviec= new Lichlamviec_nvDTO();
            lichlamviec.MaLich = maLich;
            lichlamviec.MaNV = maNV;
            lichlamviec.Ngay = ngay;
            lichlamviec.Ca = Ca;
            lichlamviec.NvQuyetDinh = MaNVDH;
            return lichlamviec;
        }

        public static bool kiemTraSoLuongNhanVienDacThu(String maLich, DateTime ngay, String Ca, String tenLoaiNV)
        {
            int soluong = LichLamViec_nvDAO.docSoLuongLoaiNhanVien(maLich, ngay, Ca, tenLoaiNV);
            if(tenLoaiNV == "Y bác sĩ" && soluong < 4)
            {
                return true;
            }
            if (tenLoaiNV == "Nhân viên thu ngân" && soluong < 2)
            {
                return true;
            }
            if (tenLoaiNV == "Nhân viên lễ tân" && soluong < 2)
            {
                return true;
            }
            if (tenLoaiNV == "Nhân viên y tế" && soluong < 6)
            {
                return true;
            }
            return false;
        }

        public static bool themLichLamViec(Lichlamviec_nvDTO lichlamviec)
        {
            return LichLamViec_nvDAO.themLichLamViec(lichlamviec);   
        }

        public static DataTable docLichLamViecNV(String maLich, String maNV)
        {
            return LichLamViec_nvDAO.docLichLamViecNhanVien(maLich, maNV);
        }

    }
}
