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
    class VacXinDAO
    {
        public static int docSLVacXinton(string mavc)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query0 = "select soluongton from DBA_PTTK.vacxin where mavc = '"+mavc+"'";
                OracleCommand command0 = new OracleCommand(query0, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command0);
                adapter.Fill(dataTable);

                int sl = Int32.Parse(dataTable.Rows[0]["SOLUONGTON"].ToString());

                return sl;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable docDanhSachVacXin()
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select * from dba_pttk.vacxin";
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

        public static bool themVacXin(VacXinDTO vacXin)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "insert into dba_pttk.vacxin values('" + vacXin.MaVC + "', '" + vacXin.TenVC + "', '" + vacXin.PhongBenh + "', " + vacXin.DonGia + ", " + vacXin.SoLuongTon + ", '" + vacXin.NCC1 + "')";
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
