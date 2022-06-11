using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DTO
{
    class GoiTiemDTO
    {
        private string maGT;
        private string tenGT;
        private int soLuongVC;
        private int thanhTien;

        public string MaGT { get => maGT; set => maGT = value; }
        public string TenGT { get => tenGT; set => tenGT = value; }
        public int SoLuongVC { get => soLuongVC; set => soLuongVC = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
