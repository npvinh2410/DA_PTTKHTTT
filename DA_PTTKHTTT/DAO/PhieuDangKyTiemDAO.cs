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
    class PhieuDangKyTiemDAO
    {
        public static DataTable docdsPhieuDangKyTiem(string maKH)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select * from dba_pttk.phieudangkytiem where makh = '" + maKH + "'";
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

        public static string themPhieuDangKyTiem(string maKH, string loaitiem)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query0 = "select madk from DBA_PTTK.PHIEUDANGKYTIEM order by madk desc";
                OracleCommand command0 = new OracleCommand(query0, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command0);
                adapter.Fill(dataTable);

                string madk = null;
                if (dataTable.Rows.Count > 0)
                {
                    String maCu = dataTable.Rows[0]["MADK"].ToString();
                    String sttCu = new String(maCu.Where(Char.IsDigit).ToArray());
                    int stt = Int32.Parse(sttCu) + 1;
                    madk = "DK" + stt.ToString();
                }
                else
                {
                    madk = "DK1001";
                }

                string query = "insert into DBA_PTTK.PHIEUDANGKYTIEM values('" + madk + "', " + "TO_DATE('" + DateTime.Now.ToString("yyyy/MM/dd") + "', 'yyyy/mm/dd'), '" + maKH + "', 'CHUA THANH TOAN', 0, '" + loaitiem + "')";

                OracleCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.ExecuteNonQuery();

                return madk;
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
