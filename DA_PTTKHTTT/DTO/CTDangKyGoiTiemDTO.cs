using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DTO
{
    class CTDangKyGoiTiemDTO
    {
        private string maDK;
        private string maGT;
        private DateTime ngaytiem;
        private string trungtamtiem;

        public CTDangKyGoiTiemDTO()
        {
        }

        public CTDangKyGoiTiemDTO(string maDK, string maGT, DateTime ngaytiem, string trungtamtiem)
        {
            this.maDK = maDK;
            this.maGT = maGT;
            this.ngaytiem = ngaytiem;
            this.trungtamtiem = trungtamtiem;
        }

        public string MaDK { get => maDK; set => maDK = value; }
        public string MaGT { get => maGT; set => maGT = value; }
        public DateTime Ngaytiem { get => ngaytiem; set => ngaytiem = value; }
        public string Trungtamtiem { get => trungtamtiem; set => trungtamtiem = value; }
    }
}
