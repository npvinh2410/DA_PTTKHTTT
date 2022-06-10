using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_PTTKHTTT.DTO;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace DA_PTTKHTTT.DAO
{
    internal class PhieuDatHangDAO
    {
        public static DataTable docDSPhieuDatHang()
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select * from DBA_PTTK.PhieuDatHang";

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

        public static String docIDChoDatPhieuDatHang()
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select MADH from DBA_PTTK.PhieuDatHang where TRANGTHAI = 'Chờ đặt'";

                OracleCommand command = new OracleCommand(query, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);
                string idPD = dataTable.Rows[0]["MADH"].ToString();

                return idPD;
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
