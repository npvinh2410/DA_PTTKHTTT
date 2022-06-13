using DA_PTTKHTTT.DAO.Connection;
using DA_PTTKHTTT.Service;
using Oracle.ManagedDataAccess.Client;
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
    public partial class TiemChung : Form
    {
        public TiemChung()
        {
            InitializeComponent();
        }

        private void xemHoSoKhachHang(string MaKH)
        {
            DataTable dataTable = HoSoTiemChungService.docDanhSachKhachHangTiem();
            dataGridView1.DataSource = dataTable;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = null;
        }

        private void btnTimKiemTiemChung_Click(object sender, EventArgs e)
        {
            string MaKhachHang = txtMaKH.Text.ToUpper();

            if (MaKhachHang == "")
            {
                MessageBox.Show("Bạn cần nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                xemHoSoKhachHang(MaKhachHang);
                txtMaKH.Text = "";
            }
        }

        private void btnKhamSangLoc_Click(object sender, EventArgs e)
        {
            KhamSangLoc form = new KhamSangLoc();
            form.ShowDialog();
        }

        private void btnDaTiem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xác nhận tiêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
