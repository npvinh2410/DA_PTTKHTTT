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
    class HoaDonDAO
    {
        public static DataTable docHoaDon(String maKH)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "SELECT MAHD, LANTHANHTOAN, PHUONGTHUCTHANHTOAN, TONGTIEN, MADK FROM DBA_PTTK.HOADON WHERE MAKH = '" + maKH + "' order by MAHD desc";

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

        public static DataTable layPhieuDKTiem()
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select MADK, TONGTIEN from DBA_PTTK.PHIEUDANGKYTIEM WHERE MAKH = '" + LoginInfo.USERNAME.ToUpper() + "' AND (NGAYLAP - CURRENT_DATE) <= 1";

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

        public static DataTable layPhieuDM()
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select MAPD, TONGTIEN from DBA_PTTK.PHIEUDATMUA WHERE MAKH = '" + LoginInfo.USERNAME.ToUpper() + "' AND TINHTRANG = 'ĐÃ DUYỆT' AND (NGAYDAT - CURRENT_DATE) <= 1 order by MAPD desc ";

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

        public static DataTable layCTPhieuDM(string maPD)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select MAVC, SOLUONG, THANHTIEN from DBA_PTTK.CT_PHIEUDATMUA WHERE MAPD = '" + maPD + "'";

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

        public static bool taoHoaDon(string pttt, string httt, string maHD)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                /*PhieuDatMuaDTO phieudat = new PhieuDatMuaDTO();
                HoaDonDTO hoadon = new HoaDonDTO();

                DataTable dataTable = HoaDonDAO.layPhieuDM();
                phieudat.MaPD = dataTable.Rows[0]["MAPD"].ToString();
                phieudat.TongTien = Int32.Parse(dataTable.Rows[0]["TONGTIEN"].ToString());

                DataTable dt_hd = docHoaDon(LoginInfo.USERNAME.ToUpper());

                if (dataTable.Rows.Count > 0)
                {
                    String maCu = dt_hd.Rows[0]["MAHD"].ToString();
                    String sttmaCu = new String(maCu.Where(Char.IsDigit).ToArray());
                    int stt = Int32.Parse(sttmaCu) + 1;
                    hoadon.MaHD = "H" + stt.ToString();
                }
                else
                {
                    hoadon.MaHD = "H1";
                }*/




                string query = "UPDATE DBA_PTTK.HOADON SET PHUONGTHUCTHANHTOAN = '" + pttt + "', HINHTHUCTHANHTOAN = '" + httt + "' WHERE MAHD = '" + maHD + "'";

                //string query = "INSERT INTO DBA_PTTK.HOADON "
                                //+ "values('" + hoadon.MaHD + "', " + dataTable.Rows.Count.ToString() + ", " + phieudat.TongTien.ToString() + ", '" + LoginInfo.USERNAME.ToUpper() + "', null, 1, '" + pttt + "', '" + httt + "')";

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

        public static bool taoCTHoaDon(string maHD)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {

                conn.Open();

                DataTable dt_pd = HoaDonDAO.layPhieuDM();
                string maPD = dt_pd.Rows[0]["MAPD"].ToString();
                DataTable dataTable = HoaDonDAO.layCTPhieuDM(maPD);

                foreach (DataRow row in dataTable.Rows)
                {
                    CTPhieuDatMuaDTO ctphieudat = new CTPhieuDatMuaDTO();
                    ctphieudat.MaVC = row["MAVC"].ToString();
                    ctphieudat.SoLuong = Int32.Parse(row["SOLUONG"].ToString());
                    ctphieudat.ThanhTien = Int32.Parse(row["THANHTIEN"].ToString());

                    string query = "INSERT INTO DBA_PTTK.CT_HOADON "
                                    + "values('" + maHD + "', '" + ctphieudat.MaVC + "', " + ctphieudat.SoLuong.ToString() + ", " + ctphieudat.ThanhTien.ToString() + ")";

                    //OracleCommand command = new OracleCommand(query, conn);
                    OracleCommand command = conn.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = query;
                    command.ExecuteNonQuery();

                }

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

        public static string themHoaDon(string maKH, string maDK)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query0 = "select mahd from DBA_PTTK.HOADON order by mahd desc";
                OracleCommand command0 = new OracleCommand(query0, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command0);
                adapter.Fill(dataTable);

                string mahd = null;
                if (dataTable.Rows.Count > 0)
                {
                    String maCu = dataTable.Rows[0]["MAHD"].ToString();
                    String sttCu = new String(maCu.Where(Char.IsDigit).ToArray());
                    int stt = Int32.Parse(sttCu) + 1;
                    mahd = "HD" + stt.ToString();
                }
                else
                {
                    mahd = "HD1001";
                }

                string query = "insert into DBA_PTTK.HOADON values('" + mahd + "',null,null, '" + maKH + "','" + maDK + "', 0,null,null)";

                OracleCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.ExecuteNonQuery();

                return mahd;
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

        public static int ThThanhToan(string lantt, string pttt)
        {
            if (pttt == "Thanh toán một lần" && lantt == "1")   //hoa don tt 1 lan da tt xong
                return 1;
            else if (pttt == "Thanh toán một lần" && lantt == "0") // hoa don tt1 lan chua tt
                return 0;
            else if (pttt == "Thanh toán theo đợt" && lantt == "3")  //hoa don tt theo dot da tt xong
                return 1;
            else if (pttt == "Thanh toán theo đợt" && lantt != "3") // hoa don tt theo dot chua tt xong
                return 0;
            else
                return 9999;


        }

        public static bool thanhtoanHoaDon(string mahd, string lantt, string pttt)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                int new_lantt = Int32.Parse(lantt) + 1;

                string query = "UPDATE DBA_PTTK.HOADON SET LANTHANHTOAN = " + new_lantt.ToString() + " WHERE MAHD = '" + mahd + "'";

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

        public static bool update_phieuDK(string maDK)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "UPDATE DBA_PTTK.PHIEUDANGKYTIEM SET TINHTRANGTHANHTOAN = 'ĐÃ THANH TOÁN' WHERE MADK = '" + maDK + "'";

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

