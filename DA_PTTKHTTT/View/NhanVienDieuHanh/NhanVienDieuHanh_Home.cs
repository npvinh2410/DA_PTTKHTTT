using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_PTTKHTTT.View.NhanVienDieuHanh
{
    public partial class NhanVienDieuHanh_Home : Form
    {
        public NhanVienDieuHanh_Home()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PhanCongBacSi form = new PhanCongBacSi();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ThietLapKhoangThoiGianDangKy form = new ThietLapKhoangThoiGianDangKy();
            form.ShowDialog();
        }
    }
}
