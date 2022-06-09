using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_PTTKHTTT.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool loginCheck = Service.LoginService.Login(username, password);
            if(loginCheck == false)
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                // Này để xác định với username nào thì sẽ mở form nào
                loginController(username);
            }
        }

        private void loginController(String username)
        {
            if (username.ToUpper().Contains("NVDH"))
            {
                PhanCongBacSi form = new PhanCongBacSi();
                this.Hide();
                form.ShowDialog();
            }
        }
    }
}
