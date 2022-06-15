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

namespace DA_PTTKHTTT.View.KhachHang
{
    public partial class DangKyTiemChung : Form
    {
        public DangKyTiemChung()
        {
            InitializeComponent();
        }

        public DangKyTiemChung(DataTable dataSource, bool loaitiem, string makh, string tenkh, string diachi, string sdt,
            string gioitinh, string hotennt, string moiqh, string sdtnguoithan)
        {
            InitializeComponent();
            tb_makh.Text = makh;
            tb_hotenkh.Text = tenkh;
            tb_diachikh.Text = diachi;
            tb_sdtkh.Text = sdt;
            if (gioitinh == "NAM")
            {
                ckb_nam.Checked = true;
                ckb_nu.Checked = false;
            }
            else
            {
                ckb_nam.Checked = false;
                ckb_nu.Checked = true;
            }

            if (loaitiem == true)
            {
                ckb_tiemtheogoi.Checked = true;
                ckb_goitiemle.Checked = false;
            }
            else
            {
                ckb_tiemtheogoi.Checked = false;
                ckb_goitiemle.Checked = true;
            }
            if (hotennt == "")
            {
                ckb_treem.Checked = false;
            }
            else
            {
                ckb_treem.Checked = true;
            }

            tb_hotennguoithan.Text = hotennt;
            tb_moiquanhe.Text = moiqh;
            tb_sdtnguoithan.Text = sdtnguoithan;

            grid_goitiemchon.DataSource = dataSource;
            grid_goitiemchon.Columns[0].Name = "MAVC";
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
            kiemTraKHThanhVien();
        }

        private void ckb_treem_CheckedChanged(object sender, EventArgs e)
        {
            bool check = ckb_treem.CheckState == CheckState.Checked ? true : false;
            if (check == false)
            {
                tb_hotennguoithan.Enabled = false;
                tb_moiquanhe.Enabled = false;
                tb_sdtnguoithan.Enabled = false;
            }
            else
            {
                tb_hotennguoithan.Enabled = true;
                tb_moiquanhe.Enabled = true;
                tb_sdtnguoithan.Enabled = true;
            }
        }

        private void ckb_goitiemle_CheckedChanged(object sender, EventArgs e)
        {
            bool check = ckb_goitiemle.CheckState == CheckState.Checked ? true : false;
            if (check == true)
            {
                ckb_tiemtheogoi.Checked = false;
            }
            else
            {
                ckb_tiemtheogoi.Checked = true;
            }
        }

        private void ckb_tiemtheogoi_CheckedChanged(object sender, EventArgs e)
        {
            bool check = ckb_tiemtheogoi.CheckState == CheckState.Checked ? true : false;
            if (check == true)
            {
                ckb_goitiemle.Checked = false;
            }
            else
            {
                ckb_goitiemle.Checked = true;
            }
        }

        private void ckb_nu_CheckedChanged(object sender, EventArgs e)
        {
            bool check = ckb_nu.CheckState == CheckState.Checked ? true : false;
            if (check == true)
            {
                ckb_nam.Checked = false;
            }
            else
            {
                ckb_nam.Checked = true;
            }
        }

        private void ckb_nam_CheckedChanged(object sender, EventArgs e)
        {
            bool check = ckb_nam.CheckState == CheckState.Checked ? true : false;
            if (check == true)
            {
                ckb_nu.Checked = false;
            }
            else
            {
                ckb_nu.Checked = true;
            }
        }

        private List<CTDangKyGoiTiemLeDTO> docDSGoiTiemLe()
        {
            List<CTDangKyGoiTiemLeDTO> dsGoiTiem = new List<CTDangKyGoiTiemLeDTO>();
            int selectCount = grid_goitiemchon.SelectedRows.Count;

            for (int i = 0; i < selectCount; i++)
            {
                string mavc = grid_goitiemchon.SelectedRows[i].Cells[0].Value.ToString();
                DateTime ngay = DateTime.Parse(grid_goitiemchon.SelectedRows[i].Cells[3].Value.ToString());
                string trungtamtiem = grid_goitiemchon.SelectedRows[i].Cells[4].Value.ToString();
                CTDangKyGoiTiemLeDTO ct = new CTDangKyGoiTiemLeDTO("", mavc, ngay, trungtamtiem);
                dsGoiTiem.Add(ct);
            }
            return dsGoiTiem;
        }

        private List<CTDangKyGoiTiemDTO> docDSGoiTiem()
        {
            List<CTDangKyGoiTiemDTO> dsGoiTiem = new List<CTDangKyGoiTiemDTO>();
            int selectCount = grid_goitiemchon.SelectedRows.Count;

            for (int i = 0; i < selectCount; i++)
            {
                string magt = grid_goitiemchon.SelectedRows[i].Cells[0].Value.ToString();
                DateTime ngay = DateTime.Parse(grid_goitiemchon.SelectedRows[i].Cells[3].Value.ToString());
                string trungtamtiem = grid_goitiemchon.SelectedRows[i].Cells[4].Value.ToString();
                CTDangKyGoiTiemDTO ct = new CTDangKyGoiTiemDTO("", magt, ngay, trungtamtiem);
                dsGoiTiem.Add(ct);
            }
            return dsGoiTiem;
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            if (grid_goitiemchon.RowCount == 0)
            {
                MessageBox.Show("Việc đăng ký tiêm chủng phải gồm ít nhất 1 gói tiêm");
                return;
            }
            bool check = ckb_treem.CheckState == CheckState.Checked ? true : false;
            if (check == true)
            {
                if (tb_hotenkh.Text == "" || tb_diachikh.Text == "" || tb_sdtkh.Text == "" || tb_hotennguoithan.Text == "" || tb_moiquanhe.Text == "" || tb_sdtnguoithan.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
            }
            else
            {
                if (tb_hotenkh.Text == "" || tb_diachikh.Text == "" || tb_sdtkh.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
            }

            string makh = tb_makh.Text;
            KhachHangDTO kh = new KhachHangDTO();
            kh = null;
            if (makh == "")
            {
                string tenkh = tb_hotenkh.Text;
                string sdtkh = tb_sdtkh.Text;
                string diachi = tb_diachikh.Text;
                string hotennt = tb_hotennguoithan.Text;
                string sdtnguoithan = tb_sdtnguoithan.Text;
                string moiqh = tb_moiquanhe.Text;
                string gioitinh = ckb_nam.CheckState == CheckState.Checked ? "Nam" : "Nữ";

                kh = KhachHangService.khoiTaoKH(tenkh, sdtkh, diachi, gioitinh);
            }

            bool checkgt = ckb_tiemtheogoi.CheckState == CheckState.Checked ? true : false;
            if (checkgt == true)
            {
                List<CTDangKyGoiTiemDTO> ds = docDSGoiTiem();
                makh = PhieuDangKyTiemService.dkGoiTiem(makh, kh, ds);
            }
            else
            {
                List<CTDangKyGoiTiemLeDTO> ds = docDSGoiTiemLe();
                makh = PhieuDangKyTiemService.dkGoiTiemLe(makh, kh, ds);
            }
            if (makh == null)
            {
                MessageBox.Show("Không thành công!");
            }
            else
            {
                MessageBox.Show("Thành công!");
                MessageBox.Show("Mã Khách hàng của bạn là: " + makh);
            }
        }

        private void btn_chongoitiem_Click(object sender, EventArgs e)
        {
            string makh = tb_makh.Text;
            string tenkh = tb_hotenkh.Text;
            string sdtkh = tb_sdtkh.Text;
            string diachi = tb_diachikh.Text;
            string gioitinh;
            string hotennt = tb_hotennguoithan.Text;
            string sdtnguoithan = tb_sdtnguoithan.Text;
            string moiqh = tb_moiquanhe.Text;
            bool checkgioitinh = ckb_nam.CheckState == CheckState.Checked ? true : false;
            if (checkgioitinh == true)
            {
                gioitinh = "NAM";
            }
            else
            {
                gioitinh = "NAM";
            }
            bool tiemtheogoi = ckb_tiemtheogoi.CheckState == CheckState.Checked ? true : false;
            View.KhachHang.ChonGoiTiem form = new View.KhachHang.ChonGoiTiem(tiemtheogoi, makh, tenkh, diachi, sdtkh, gioitinh, hotennt, moiqh, sdtnguoithan); ;
            this.Hide();
            form.ShowDialog();
        }
    }
}
