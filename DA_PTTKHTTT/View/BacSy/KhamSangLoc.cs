using DA_PTTKHTTT.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_PTTKHTTT.View.BacSy
{
    public partial class KhamSangLoc : Form
    {
        public KhamSangLoc(string MaKH)
        {
            InitializeComponent();
            xemHoSoKhachHang(MaKH);
        }

        private void xemHoSoKhachHang(string MaKH)
        {
            DataTable dataTable = HoSoTiemChungService.docDanhSachKhachHangTiem(MaKH);
            dataGridView1.DataSource = dataTable;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = null;
        }

        private void btnChoTiem_Click(object sender, EventArgs e)
        {

        }

        private void btnKhongChoTiem_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapKham_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
