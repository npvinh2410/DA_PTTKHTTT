﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_PTTKHTTT.DTO;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace DA_PTTKHTTT.DAO
{
    class NhanVienDAO
    {
        public static DataTable docDanhSachNhanVienDangKyLich(String maLich)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select nv.MANV, nv.TENNV, loai.TENLOAINV, tt.tentt, nv.EMAIL"
                                + "\nfrom DBA_PTTK.nhanvien nv, DBA_PTTK.thongtin_dk_lichlamviec dkl, DBA_PTTK.loainhanvien loai, DBA_PTTK.trungtamtiemchung tt"
                                + "\nwhere VITRI = 'BS' and nv.manv = dkl.manv and dkl.malich = '" + maLich + "'"
                                + "\nand nv.vitri = loai.maloai and tt.matt = nv.matt"
                                + "\ngroup by nv.MANV, nv.TENNV, loai.TENLOAINV, tt.tentt, nv.EMAIL";
                OracleCommand command = new OracleCommand(query, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }


}
