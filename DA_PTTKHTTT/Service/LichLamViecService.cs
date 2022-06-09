using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_PTTKHTTT.DAO;
using DA_PTTKHTTT.DTO;


namespace DA_PTTKHTTT.Service
{
    class LichLamViecService
    {
        public static List<LichLamViecDTO> DocKhoangThoiGianLichLamViec()
        {
            List<LichLamViecDTO> lichLamViecs = LichLamViecDAO.docKhoangThoiGianLichLamViec();
            return lichLamViecs;
        }
    }
}
