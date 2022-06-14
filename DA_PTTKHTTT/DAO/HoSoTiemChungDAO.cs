using DA_PTTKHTTT.DTO;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.DAO
{
    class HoSoTiemChungDAO
    {
        public static DataTable xemHoSoKhamBenh(String MaKhachHang)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select HS.MAHS, KH.TENKH, HS.NGAYLAP, CTHS.CHIDINHTIEM"
                                + "\nfrom DBA_TEST.HOSOTIEMCHUNG HS, DBA_TEST.KHACHHANG KH, DBA_TEST.CT_HOSO CTHS"
                                + "\nwhere HS.MAKH = KH.MAKH and HS.MAHS=CTHS.MAHS and HS.MAKH = '" + MaKhachHang + "'";

                /*string query = "select * from DBA_TEST.HOSOTIEMCHUNG where MAKH = 'KH001'";*/

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

        public static DataTable xemHoSoKhachHang(String MaHS)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select HS.MAHS, KH.TENKH, HS.NHIETDO, HS.HUYETAP, HS.COTIENSUBENHNEN, HS.NGAYLAP"
                                + "\nfrom DBA_TEST.HOSOTIEMCHUNG HS, DBA_TEST.KHACHHANG KH"
                                + "\nwhere HS.MAKH = KH.MAKH and HS.MAHS = '" + MaHS + "'";

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

        public static DataTable capnhatHoSoKhamBenh(String MaHS, string NhietDo, string HuyetAp, string cotiensuBenhNen)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();
                string query = "update DBA_TEST.HOSOTIEMCHUNG "
                                + "\nset NHIETDO = '"+ NhietDo + "', HUYETAP = '" + HuyetAp + "', COTIENSUBENHNEN = '" + cotiensuBenhNen + "'"
                                + "\nwhere MAHS = '" + MaHS + "'";

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

        public static DataTable capnhatchopheptiem(String MaHS, string chidinhtiem)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();
                string query = "update DBA_TEST.CT_HOSO CTHS"
                                + "\nset HS.CHIDINHTIEM = " + chidinhtiem + ""
                                + "\nwhere CTHS.MAHS = '" + MaHS + "'";

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

        public static DataTable capnhatkhongchopheptiem(String MaHS, string chidinhtiem)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();
                string query = "update DBA_TEST.CT_HOSO CTHS"
                                + "\nset HS.CHIDINHTIEM = " + chidinhtiem + ""
                                + "\nwhere CTHS.MAHS = '" + MaHS + "'";

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


