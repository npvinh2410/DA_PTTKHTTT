using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DTO
{
    class HoSoTiemChungDTO
    {
        private string maHS;
        private string tenHS;
        private DateTime ngayLap;
        private string maKH;
        private string maBS;
        private string NhietDo;
        private string HuyetAp;
        private string cotiensuBenhNen;

        public string MaHS { get => maHS; set => maHS = value; }
        public string TenHS { get => tenHS; set => tenHS = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaBS { get => maBS; set => maBS = value; }
        public string NhietDo1 { get => NhietDo; set => NhietDo = value; }
        public string HuyetAp1 { get => HuyetAp; set => HuyetAp = value; }
        public string CotiensuBenhNen { get => cotiensuBenhNen; set => cotiensuBenhNen = value; }
    }
}
