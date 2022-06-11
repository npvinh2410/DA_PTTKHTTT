using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DTO
{
    class VacXinDTO
    {
        private String maVC;
        private String tenVC;
        private string phongBenh;
        private int donGia;
        private int soLuongTon;
        private string NCC;

        public string MaVC { get => maVC; set => maVC = value; }
        public string TenVC { get => tenVC; set => tenVC = value; }
        public string PhongBenh { get => phongBenh; set => phongBenh = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }
        public string NCC1 { get => NCC; set => NCC = value; }
    }
}
