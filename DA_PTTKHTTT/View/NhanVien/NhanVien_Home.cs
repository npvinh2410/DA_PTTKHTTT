using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_PTTKHTTT.View.NhanVien
{
    public partial class NhanVien_Home : Form
    {
        public NhanVien_Home()
        {
            InitializeComponent();
        }

        private void NhanVien_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View.NhanVien.XemThongTinKhachHang form = new View.NhanVien.XemThongTinKhachHang();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            View.DangKyLichLamViec form = new View.DangKyLichLamViec();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            View.XemLichLamViec form = new View.XemLichLamViec();
            form.ShowDialog();
        }
    }
}
