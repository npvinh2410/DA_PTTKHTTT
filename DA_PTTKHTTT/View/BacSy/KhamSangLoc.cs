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
            DataTable dataTable = HoSoTiemChungService.docDanhSachKhachHangTiem(MaHS);
            dataGridView1.DataSource = dataTable;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = null;
        }

        private void btnChoTiem_Click(object sender, EventArgs e)
        {
            String maHS = dataGridView1.SelectedRows[0].Cells[0].ToString();
            string chidinhtiem = "CO";
            MessageBox.Show("Cho phép khách hàng tiêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ChiDinhTiemChungService.chidinhChoTiem(maHS, chidinhtiem);
            TiemChung form = new TiemChung();
            form.ShowDialog();
        }

        private void btnKhongChoTiem_Click(object sender, EventArgs e)
        {
            String maHS = dataGridView1.SelectedRows[0].Cells[0].ToString();
            string chidinhtiem = "KHONG";
            ChiDinhTiemChungService.chidinhKhongChoTiem(maHS, chidinhtiem);
            MessageBox.Show("Không cho phép khách hàng tiêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TiemChung form = new TiemChung();
            form.ShowDialog();
        }

        private void btnNhapKham_Click(object sender, EventArgs e)
        {
            string nhietdo = txtNhietDo.Text;
            string huyetap = txtHuyetAp.Text;
            String maHS = dataGridView1.SelectedRows[0].Cells[0].ToString();

            String tiensuBenhnen = (comboBox1.SelectedItem as dynamic).Value;
            

            HoSoKhamBenhService.capnhatThongTinTiemChung(maHS, nhietdo, huyetap, tiensuBenhnen);
            MessageBox.Show("Bạn đã nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            xemHoSoKhachHang(maHS);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
