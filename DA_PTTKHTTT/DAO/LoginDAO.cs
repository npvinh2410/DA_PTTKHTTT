using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_PTTKHTTT.DAO.DBConnection;
using Oracle.ManagedDataAccess.Client;

namespace DA_PTTKHTTT.DAO
{
    class LoginDAO
    {
        public static bool LoginCheck(string username, string password)
        {
            try
            {
                OracleConnection conn = Connection.DBConnection.GetDBConnection(username, password);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
