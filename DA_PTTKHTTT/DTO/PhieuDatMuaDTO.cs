using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DTO
{
    internal class PhieuDatMuaDTO
    {
        private string maPD;
        private DateTime ngayDat;
        private string maKH;
        private string maNV;
        private string tinhTrang;
        private float tongTien;

        public string MaPD { get => maPD; set => maPD = value; }
        public DateTime NgayDat { get => ngayDat; set => ngayDat = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
    }
}
