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
        public static DataTable xemHoSoKhachHang(String MaKhachHang)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select HS.MAHS, KH.TENKH, HS.NGAYLAP, CTHS.CHIDINHTIEM"
                                + "\nfrom HOSOTIEMCHUNG HS, KHACHHANG KH, CT_HOSO CTHS"
                                + "\nwhere HS.MAKH = KH.MAKH and HS.MAHS=CTHS.MAHS and HS.MAKH = '" + MaKhachHang + "'";

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

        public static DataTable xemHoSoKhamBenh(String MaHS)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select HS.MAHS, KH.TENKH, HS.NHIETDO, HS.HUYETAP, HS.COTIENSUBENHNEN, HS.NGAYLAP"
                                + "\nfrom HOSOTIEMCHUNG HS, KHACHHANG KH"
                                + "\nwhere HS.MAKH = KH.MAKH and HS.MAKH = '" + MaHS + "'";

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
                string query = "update HOSOTIEMCHUNG HS, KHACHHANG KH "
                                + "\nset HS.NHIETDO = "+ NhietDo + ", HS.HUYETAP = " + HuyetAp + ", HS.COTIENSUBENHNEN = " + cotiensuBenhNen + ""
                                + "\nwhere HS.MAKH = KH.MAKH and HS.MAKH = '" + MaHS + "'";

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
                string query = "update CT_HOSO CTHS"
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
                string query = "update CT_HOSO CTHS"
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


