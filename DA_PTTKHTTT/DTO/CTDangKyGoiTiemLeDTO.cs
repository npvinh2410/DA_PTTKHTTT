using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DTO
{
    class CTDangKyGoiTiemLeDTO
    {
        private string maDK;
        private string maVC;
        private DateTime ngaytiem;
        private string trungtamtiem;

        public CTDangKyGoiTiemLeDTO()
        {
        }

        public CTDangKyGoiTiemLeDTO(string maDK, string maVC, DateTime ngaytiem, string trungtamtiem)
        {
            this.maDK = maDK;
            this.maVC = maVC;
            this.ngaytiem = ngaytiem;
            this.trungtamtiem = trungtamtiem;
        }

        public string MaDK { get => maDK; set => maDK = value; }
        public string MaVC { get => maVC; set => maVC = value; }
        public DateTime Ngaytiem { get => ngaytiem; set => ngaytiem = value; }
        public string Trungtamtiem { get => trungtamtiem; set => trungtamtiem = value; }
    }
}
