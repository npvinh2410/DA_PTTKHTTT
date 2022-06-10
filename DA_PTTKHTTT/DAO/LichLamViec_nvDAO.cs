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
    class LichLamViec_nvDAO
    {

        public static int docSoLuongLoaiNhanVien(String maLich, DateTime ngay, String Ca, String tenLoaiNV)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select count(*) as SOLUONG"
                                + "\nfrom DBA_PTTK.lichlamviec_nv lich, DBA_PTTK.nhanvien nv, DBA_PTTK.loainhanvien loai"
                                + "\nwhere lich.manv = nv.manv and nv.vitri = loai.maloai and loai.tenloainv = '"+ tenLoaiNV + "'"
                                +"\nand lich.ca = '" + Ca +"' and lich.ngay = to_date('" + ngay.ToString("dd/MM/yyy") + "', 'dd/mm/yyyy')";

                OracleCommand command = new OracleCommand(query, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);
                int soluong = Int32.Parse(dataTable.Rows[0]["SOLUONG"].ToString());

                return soluong;
            }
            catch (Exception ex)
            {
                return 9999;
            }
            finally
            {
                conn.Close();
            }
        }

        public static bool themLichLamViec(Lichlamviec_nvDTO lich)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "insert into DBA_PTTK.lichlamviec_nv "
                                + "\nvalues('" + lich.MaLich + "', '" + lich.MaNV + "', to_date('" + lich.Ngay.ToString("dd/MM/yyyy") + "', 'dd/mm/yyyy'),'" + lich.Ca + "', '" + lich.NvQuyetDinh + "')";

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

        public static DataTable docLichLamViecNhanVien(String maLich, String maNV)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select TO_CHAR(NGAY,'MM/dd/yyyy') as NGAY, CA"
                                + "\nfrom DBA_PTTK.lichlamviec_nv"
                                + "\nwhere malich = '" + maLich + "' and manv = '" + maNV + "' ";

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

        public static int docThongTin(Lichlamviec_nvDTO lichlamviec)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select MALICH, MANV, NGAY, CA"
                                + "\nfrom DBA_PTTK.lichlamviec_nv"
                                + "\nwhere malich = '"+ lichlamviec.MaLich + "' and manv = '"+ lichlamviec.MaNV +"'"
                                 + "\nand ngay = to_date('"+ lichlamviec.Ngay.ToString("dd/MM/yyy") + "', 'dd/mm/yyyy') and ca = '"+lichlamviec.Ca+"'";

                OracleCommand command = new OracleCommand(query, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);


                int soluong = dataTable.Rows.Count;

                return soluong;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
    }


}
