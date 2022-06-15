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
    class CTDangKyGoiTiemLeDAO
    {
        public static bool themCTDangKyGoiTiemLe(string madk, string maVC, DateTime ngaytiem, string trungtamtiem)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query;
                query = "insert into DBA_PTTK.CT_DANGKY_GOITIEMLE values('" + madk + "', '" + maVC + "',TO_DATE('" + ngaytiem.ToString("yyyy/MM/dd") + "', 'yyyy/mm/dd'), '" + trungtamtiem + "')";

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
