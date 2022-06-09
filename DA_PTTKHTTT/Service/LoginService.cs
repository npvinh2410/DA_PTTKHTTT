using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_PTTKHTTT.Service
{
    class LoginService
    {
        public static bool Login(string username, string password)
        {
            bool loginCheck = DAO.LoginDAO.LoginCheck(username, password);
            if(loginCheck == true)
            {
                //Lưu lại thông tin phiên người dùng đang đăng nhập
                DTO.LoginInfo.USERNAME = username;
                DTO.LoginInfo.PASSWORD = password;
            }
            return loginCheck;
        }
    }
}
