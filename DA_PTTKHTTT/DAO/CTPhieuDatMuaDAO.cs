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
    internal class CTPhieuDatMuaDAO
    {
        public static DataTable docCTPhieuDatMua(string maPD)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select * from DBA_PTTK.CT_PhieuDatMua where MAPD = " + "'" + maPD + "'";

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

        public static List<CTPhieuDatMuaDTO> docCTPhieuDatMuaDuocDuyet(List<string> dsMaPD)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query = "select * from DBA_PTTK.CT_PhieuDatMua where ";

                for(int i = 0; i < dsMaPD.Count; i++)
                {
                    query = query + "MaPD = '" + dsMaPD[i] + "'";
                    if(i != dsMaPD.Count - 1)
                    {
                        query += " or ";
                    }
                }

                OracleCommand command = new OracleCommand(query, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);

                List<CTPhieuDatMuaDTO> CTPhieuDatMuas = new List<CTPhieuDatMuaDTO>();

                foreach (DataRow row in dataTable.Rows)
                {
                    CTPhieuDatMuaDTO CTPhieuDatMua = new CTPhieuDatMuaDTO();
                    CTPhieuDatMua.MaPD = row["MAPD"].ToString();
                    CTPhieuDatMua.MaVC = row["MAVC"].ToString();
                    CTPhieuDatMua.SoLuong = Int32.Parse(row["SOLUONG"].ToString());
                    CTPhieuDatMua.DonGia = Int32.Parse(row["DONGIA"].ToString());
                    CTPhieuDatMua.ThanhTien = Int32.Parse(row["THANHTIEN"].ToString());


                    CTPhieuDatMuas.Add(CTPhieuDatMua);
                }
                return CTPhieuDatMuas;
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

        public static bool themCTPhieuDatMuaTheoGoi(string maPD, string maGoi)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query0 = "select mavc from DBA_PTTK.ct_goitiem where magt='"+maGoi+"'";
                OracleCommand command0 = new OracleCommand(query0, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command0);
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    for(int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        String maVC = dataTable.Rows[i]["MAVC"].ToString();
                        themCTPhieuDatMua(maPD, maVC, 1);
                    }
              
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

        public static bool themCTPhieuDatMua(string maPD, string maVC, int soLuong)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(LoginInfo.USERNAME, LoginInfo.PASSWORD);
            try
            {
                conn.Open();

                string query0 = "select * from DBA_PTTK.CT_PHIEUDATMUA where MAPD = " + "'" + maPD + "'" + " and MAVC = " + "'" + maVC + "'";

                OracleCommand command0 = new OracleCommand(query0, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command0);
                adapter.Fill(dataTable);

                string query;

                if (dataTable.Rows.Count > 0)
                {
                    query = "update DBA_PTTK.CT_PHIEUDATMUA set SOLUONG = SOLUONG + " + soLuong + " where MAPD = " + "'" + maPD + "'" + " and MAVC = " + "'" + maVC + "'";
                }
                else
                {
                    query = "insert into DBA_PTTK.CT_PHIEUDATMUA values('" + maPD + "', '" + maVC + "', '" + soLuong + "', 0, 0)";
                }

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
