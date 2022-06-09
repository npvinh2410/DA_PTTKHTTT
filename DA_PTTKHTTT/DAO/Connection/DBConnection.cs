using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using DA_PTTKHTTT.DAO.DBConnection;

namespace DA_PTTKHTTT.DAO.Connection
{
    class DBConnection
    {
        public static OracleConnection GetDBConnection(string username, string password)
        {
            string host = "localhost";
            int port = 1521;
            string sid = "xe";
            return DBOracleUtils.GetDBConnection(host, port, sid, username, password);
        }
    }
}
