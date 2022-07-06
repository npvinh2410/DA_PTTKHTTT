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
    internal class GoiTiemService
    {
        public static bool KiemTraSLGoiTiemton(string mavc)
        {
            int sl = GoiTiemDAO.docSLGoiTiemton(mavc);
            if (sl > 0) return true;
            return false;
        }

        public static DataTable docGoiTiem()
        {
           return GoiTiemDAO.docDanhSachGoiTiem();
        }

        public static DataTable docCTGoiTiem(string maGT)
        {
            return GoiTiemDAO.docCTGoiTiem(maGT);
        }
    }
}
