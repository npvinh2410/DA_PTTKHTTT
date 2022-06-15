using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_PTTKHTTT.Service;
using DA_PTTKHTTT.DTO;

namespace DA_PTTKHTTT.View.NhanVien
{
    public partial class XemThongTinKhachHang : Form
    {
        public XemThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void XemThongTinKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tb_sdtkh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ckb_nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_hotenkh_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_diachikh_TextChanged(object sender, EventArgs e)
        {

        }

        private bool kiemTraKHThanhVien()
        {
            string maKH = tb_makh.Text;

            if (maKH == "")
            {
                MessageBox.Show("Vui lòng nhập mã KH!");
                return false;
            }

            KhachHangDTO kh = PhieuDangKyTiemService.docThongTinKH(maKH);

            if (kh == null)
            {
                MessageBox.Show("Khách hàng không tồn tại!");
                return false;
            }

            tb_hotenkh.Text = kh.TenKH;
            tb_diachikh.Text = kh.DiaChi;
            tb_sdtkh.Text = kh.Sdt;
            tb_hotennguoithan.Text = kh.NguoiThan;
            tb_moiquanhe.Text = kh.MoiQuanHe;
            tb_sdtnguoithan.Text = kh.SdtNguoiThan;
            if (kh.GioiTinh == "NAM")
            {
                ckb_nam.Checked = true;
                ckb_nu.Checked = false;
            }
            else
            {
                ckb_nam.Checked = false;
                ckb_nu.Checked = true;
            }
            if (kh.NguoiThan != "")
            {
                ckb_treem.Checked = true;
            }
            else
            {
                ckb_treem.Checked = false;
                tb_hotennguoithan.Enabled = false;
                tb_moiquanhe.Enabled = false;
                tb_sdtnguoithan.Enabled = false;
            }
            return true;
        }

        private void btn_tracuu_Click(object sender, EventArgs e)
        {
            string makh = tb_makh.Text;
            kiemTraKHThanhVien();
            DataTable dataTable = Service.PhieuDangKyTiemService.docdsPhieuDangKyTiem(makh);
            grid_dsdktiem.DataSource = dataTable;
        }
    }
}
