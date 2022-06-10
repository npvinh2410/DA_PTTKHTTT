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
    internal class CTPhieuDatHangDAO
    {
        public static DataTable docCTPhieuDatHang(string maDH)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select * from DBA_PTTK.CT_DatHang where MADH = " + "'" + maDH + "'";

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

        public static bool themCTPhieuDatHang(string maDH, string maVC, int soLuong)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query0 = "select * from DBA_PTTK.CT_DatHang where MADH = " + "'" + maDH + "'" + " and MAVC = " + "'" + maVC + "'";

                OracleCommand command0 = new OracleCommand(query0, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command0);
                adapter.Fill(dataTable);

                string query;

                if (dataTable.Rows.Count > 0)
                {
                    query = "update DBA_PTTK.CT_DatHang set SOLUONG = SOLUONG + " + soLuong + " where MADH = " + "'" + maDH + "'" + " and MAVC = " + "'" + maVC + "'";
                }
                else
                {
                    query = "insert into DBA_PTTK.CT_DatHang values('" + maDH + "', '" + maVC + "', '" + soLuong +"')";
                }

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
