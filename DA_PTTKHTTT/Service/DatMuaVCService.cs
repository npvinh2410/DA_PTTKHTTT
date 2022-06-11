﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DA_PTTKHTTT.DAO;
using DA_PTTKHTTT.DTO;

namespace DA_PTTKHTTT.Service
{
    internal class DatMuaVCService
    {
        public static DataTable docGoiTiem()
        {
           return GoiTiemDAO.docDanhSachGoiTiem();
        }

        public static DataTable docCTGoiTiem(string maGT)
        {
            return GoiTiemDAO.docCTGoiTiem(maGT);
        }

        public static DataTable docDanhSachVC()
        {
            return VacXinDAO.docDanhSachVacXin();
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
                kh.DiaChi = dt.Rows[0]["DIACHI"].ToString();
                return kh;
            }
            return null;
        }

        public static KhachHangDTO khoiTao(string tenKH, string sdt, string diaChi, string gioiTinh)
        {
            KhachHangDTO kh = new KhachHangDTO();

            kh.TenKH = tenKH;
            kh.Sdt = sdt;
            kh.DiaChi = diaChi;
            kh.GioiTinh = gioiTinh;

            return kh;
        }

        public static bool datMua(string maKH, KhachHangDTO kh, List<string> dsMaGoi, List<string> dsMaVC, string vcKhac)
        {
            if (maKH == "")
            {
                maKH = KhachHangDAO.themKhachHang(kh);
            }

            if (maKH == null)
            {
                return false;
            }

            string maPD = PhieuDatMuaDAO.themPhieuDatMua(maKH);

            if(maPD == null)
            {
                return false;
            }

            for(int i = 0; i < dsMaGoi.Count; i++)
            {
                if(!CTPhieuDatMuaDAO.themCTPhieuDatMuaTheoGoi(maPD, dsMaGoi[i]))
                    return false;
            }

            for(int j = 0; j < dsMaVC.Count; j++)
            {
                if (!CTPhieuDatMuaDAO.themCTPhieuDatMua(maPD, dsMaVC[j], 1)) 
                    return false;
            }

            if (vcKhac != "")
            {
                /*if (!CTPhieuDatMuaDAO.themCTPhieuDatMua(maPD, vcKhac, 1))
                    return false;*/
            }

            return true;
        }
    }
}
