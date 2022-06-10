using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DA_PTTKHTTT.DTO;
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;

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

        public static bool themLichLamViec(LichLamViecDTO lichLamViec)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query0 = "select MALICH from DBA_PTTK.lichlamviec order by MALICH desc";
                OracleCommand command0 = new OracleCommand(query0, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command0);
                adapter.Fill(dataTable);
                String maLichCu = dataTable.Rows[0]["MALICH"].ToString();
                String sttLichCu = new String(maLichCu.Where(Char.IsDigit).ToArray());
                int stt = Int32.Parse(sttLichCu) +1;
                lichLamViec.MaLich = "L" + stt.ToString();

                string query = "insert into DBA_PTTK.lichlamviec "
                                + "\nvalues('"+lichLamViec.MaLich+ "', to_date('"+ lichLamViec.NgayApDung.ToString("dd/MM/yyyy")+ "', 'dd/mm/yyyy'), to_date('"+lichLamViec.NgayKetThuc.ToString("dd/MM/yyyy") + "', 'dd/mm/yyyy'), "+lichLamViec.TrangThai+")";

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
