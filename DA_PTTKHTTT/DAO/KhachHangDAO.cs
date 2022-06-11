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
    class KhachHangDAO
    {
        public static DataTable docDanhSachKhachHang()
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select * from dba_pttk.khachhang";
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

        public static DataTable docCTKhachHang(string maKH)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select * from dba_pttk.khachhang where makh = '" + maKH +"'";
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

        public static string themKhachHang(KhachHangDTO kh)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query0 = "select makh from DBA_PTTK.khachhang order by makh desc";
                OracleCommand command0 = new OracleCommand(query0, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command0);
                adapter.Fill(dataTable);

                string maKH;
                if (dataTable.Rows.Count > 0)
                {
                    String maCu = dataTable.Rows[0]["MAKH"].ToString();
                    String sttCu = new String(maCu.Where(Char.IsDigit).ToArray());
                    int stt = Int32.Parse(sttCu) + 1;
                    maKH = "KH" + stt.ToString();
                }
                else
                {
                    maKH = "KH1";
                }

                string query = "insert into dba_pttk.khachhang values('" + maKH + "', '" + kh.TenKH + "', '" + kh.Sdt + "', '" + kh.GioiTinh + "', '" + kh.DiaChi + "', '" + kh.NguoiThan + "', '" + kh.MoiQuanHe + "', '" + kh.SdtNguoiThan + "')";
                OracleCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.ExecuteNonQuery();

                return maKH;
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
