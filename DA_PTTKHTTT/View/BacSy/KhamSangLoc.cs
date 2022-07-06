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
        public KhamSangLoc(string MaHS)
        {
            InitializeComponent();
            xemHoSoKhachHang(MaHS);
        }

        private void xemHoSoKhachHang(string MaHS)
        {
            DataTable dataTable = HoSoKhamBenhService.docThongTinTiemChung(MaHS);
            dataGridView1.DataSource = dataTable;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnChoTiem_Click(object sender, EventArgs e)
        {
            String maHS = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string chidinhtiem = "CO";
            MessageBox.Show("Cho phép khách hàng tiêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ChiDinhTiemChungService.chidinhChoTiem(maHS, chidinhtiem);
            /*TiemChung form = new TiemChung();
            form.ShowDialog();*/
        }

        private void btnKhongChoTiem_Click(object sender, EventArgs e)
        {
            String maHS = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string chidinhtiem = "KHONG";
            ChiDinhTiemChungService.chidinhKhongChoTiem(maHS, chidinhtiem);
            MessageBox.Show("Không cho phép khách hàng tiêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*TiemChung form = new TiemChung();
            form.ShowDialog();*/
        }

        private void btnNhapKham_Click(object sender, EventArgs e)
        {
            string nhietdo = txtNhietDo.Text.ToUpper();
            string huyetap = txtHuyetAp.Text.ToUpper();
            String maHS = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            String cotiensuBenhnen = (comboBox1.SelectedItem as dynamic).ToString();

            HoSoKhamBenhService.capnhatThongTinTiemChung(maHS, nhietdo, huyetap, cotiensuBenhnen);
            DataTable dataTable = HoSoKhamBenhService.docThongTinTiemChung(maHS);
            dataGridView1.DataSource = dataTable;
            MessageBox.Show("Bạn đã nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
