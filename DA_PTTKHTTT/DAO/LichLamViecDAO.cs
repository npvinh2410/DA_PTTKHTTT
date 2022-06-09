using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DA_PTTKHTTT.DTO;
using Oracle.ManagedDataAccess.Client;

namespace DA_PTTKHTTT.DAO
{
    class LichLamViecDAO
    {
        public static List<LichLamViecDTO> docKhoangThoiGianLichLamViec()
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "SELECT MALICH, TO_CHAR(NGAYAPDUNG,'MM/dd/yyyy') AS NGAYAPDUNG, TO_CHAR(NGAYKETTHUC,'MM/dd/yyyy') AS NGAYKETTHUC FROM DBA_PTTK.lichlamviec WHERE TRANGTHAI = '0'";
                OracleCommand command = new OracleCommand(query, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);

                List<LichLamViecDTO> lichLamViecs = new List<LichLamViecDTO>();

                foreach(DataRow row in dataTable.Rows)
                {
                    LichLamViecDTO lichLamViec = new LichLamViecDTO();
                    lichLamViec.MaLich = row["MALICH"].ToString();
                    lichLamViec.NgayApDung = DateTime.Parse(row["NGAYAPDUNG"].ToString());
                    lichLamViec.NgayKetThuc = DateTime.Parse(row["NGAYKETTHUC"].ToString());  

                    lichLamViecs.Add(lichLamViec);
                }
                return lichLamViecs;
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
