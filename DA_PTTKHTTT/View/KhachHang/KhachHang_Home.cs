using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_PTTKHTTT.View.KhachHang
{
    public partial class KhachHang_Home : Form
    {
        public KhachHang_Home()
        {
            InitializeComponent();
        }

        private void KhachHang_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void KhachHang_Home_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            View.KhachHang.DatMuaVacxin form = new View.KhachHang.DatMuaVacxin();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LichSuTiemChung form = new LichSuTiemChung();
            form.ShowDialog();
        }
    }
}
