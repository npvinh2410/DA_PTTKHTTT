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
    class Thongtin_dk_lichlamviecDAO
    {
        public static DataTable docLichDangKyNhanVien(String maLich, String maNV)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select TO_CHAR(NGAY,'MM/dd/yyyy') as NGAY, CA"
                                + "\nfrom DBA_PTTK.thongtin_dk_lichlamviec"
                                + "\nwhere malich = '" + maLich +"' and manv = '"+ maNV + "' ";

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
