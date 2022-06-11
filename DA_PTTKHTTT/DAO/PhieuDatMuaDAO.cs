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
    internal class PhieuDatMuaDAO
    {
        public static DataTable docDSPhieuDatMua()
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select * from DBA_PTTK.PhieuDatMua";

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

        public static string themPhieuDatMua(string maKH)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query0 = "select mapd from DBA_PTTK.phieudatmua order by mapd desc";
                OracleCommand command0 = new OracleCommand(query0, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command0);
                adapter.Fill(dataTable);

                string maPD = null;
                if (dataTable.Rows.Count > 0)
                {
                    String maCu = dataTable.Rows[0]["MAPD"].ToString();
                    String sttCu = new String(maCu.Where(Char.IsDigit).ToArray());
                    int stt = Int32.Parse(sttCu) + 1;
                    maPD = "PD" + stt.ToString();
                }
                else
                {
                    maPD = "PD1";
                }

                string query = "insert into DBA_PTTK.PhieuDatMua values('" + maPD+"', "+ "TO_DATE('" + DateTime.Now.ToString("yyyy/MM/dd") + "', 'yyyy/mm/dd'), '"+maKH+"', null, 'Chờ duyệt', 0)";

                OracleCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.ExecuteNonQuery();

                return maPD;
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

        public static DataTable docDSPhieuDatMuaChoDuyet()
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select * from DBA_PTTK.PhieuDatMua where tinhtrang = 'Chờ duyệt'";

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

        public static bool capNhatTrangThaiDuyet(List<string> dsMaPD, int trangThai)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "update DBA_PTTK.PhieuDatMua set TinhTrang = ";
                if (trangThai > 0)
                {
                    query += "'Đã duyệt' where ";
                }
                else
                {
                    query += "'Không được duyệt' where ";
                }

                for (int i = 0; i < dsMaPD.Count; i++)
                {
                    query = query + "MaPD = '" + dsMaPD[i] + "'";
                    if (i != dsMaPD.Count - 1)
                    {
                        query += " or ";
                    }
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
