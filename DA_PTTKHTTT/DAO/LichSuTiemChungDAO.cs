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
    internal class LichSuTiemChungDAO
    {
        public static DataTable docDSLichSuTiemChungKH()
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select KH.TENKH, HS.NGAYLAP, VC.TENVC"
                + "from HOSOTIEMCHUNG HS, CT_HOSO CTHS, KHACHHANG KH, VACXIN VC"
                + "where HS.MAHS = CTHS.MAHS AND HS.MAKH = KH.MAKH AND CTHS.MAVC = VC.MAVC AND CTHS.CHIDINHTIEM = 'CO' AND HS.MAKH = '" + LoginInfo.USERNAME + "'";

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

        public static bool ChiDinhTiemChung(CTHoSoDTO CTHS)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "update DBA_PTTK.CT_HOSO "
                                + "\nset CHIDINHTIEM = 'CO'"
                                + "\nwhere ";

                OracleCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
