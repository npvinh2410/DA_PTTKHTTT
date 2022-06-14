using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DTO
{
    class KhachHangDTO
    {
        private String maKH;
        private String tenKH;
        private string sdt;
        private string gioiTinh;
        private String diaChi;
        private String nguoiThan;
        private String moiQuanHe;
        private String sdtNguoiThan;

        public static KhachHangDTO KhoiTaoKH(string maKH, string tenKH, string sdt, string gioiTinh, string diaChi, string nguoiThan, string moiQuanHe, string sdtNguoiThan)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.maKH = maKH;
            kh.tenKH = tenKH;
            kh.sdt = sdt;
            kh.gioiTinh = gioiTinh;
            kh.diaChi = diaChi;
            kh.nguoiThan = nguoiThan;
            kh.moiQuanHe = moiQuanHe;
            kh.sdtNguoiThan = sdtNguoiThan;
            return kh;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string NguoiThan { get => nguoiThan; set => nguoiThan = value; }
        public string MoiQuanHe { get => moiQuanHe; set => moiQuanHe = value; }
        public string SdtNguoiThan { get => sdtNguoiThan; set => sdtNguoiThan = value; }
    }
}
