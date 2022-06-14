using DA_PTTKHTTT.DTO;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DAO
{
    class HoSoTiemChungDAO
    {
        public static DataTable xemHoSoKhachHang(String MaKhachHang)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select HS.MAKH, KH.TENKH, HS.NHIETDO, HS.HUYETAP, HS.COTIENSUBENHNEN"
                                + "\nfrom HOSOTIEMCHUNG HS, KHACHHANG KH"
                                + "\nwhere HS.MAKH = KH.MAKH and HS.MAKH = '" + MaKhachHang + "'";

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


