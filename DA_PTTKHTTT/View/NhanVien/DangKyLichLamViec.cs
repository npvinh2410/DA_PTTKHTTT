using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_PTTKHTTT.DTO;

namespace DA_PTTKHTTT.View
{
    public partial class DangKyLichLamViec : Form
    {
        public DangKyLichLamViec()
        {
            InitializeComponent();
            hienThiKhoangThoiGian();
            hienThiThongTinNV();
        }

        private void hienThiKhoangThoiGian()
        {
            List<LichLamViecDTO> lichLamViecs = Service.LichLamViecService.DocKhoangThoiGianLichLamViec();
            foreach (LichLamViecDTO lichLamViec in lichLamViecs)
            {

                comboBoxThoiGian.DisplayMember = "Text";
                comboBoxThoiGian.ValueMember = "Value";
                String KhoangThoiGian = "Từ " + lichLamViec.NgayApDung.ToString("dd/MM/yyyy")
                                                + " đến " + lichLamViec.NgayKetThuc.ToString("dd/MM/yyyy");
                comboBoxThoiGian.Items.Add(new { Text = KhoangThoiGian, Value = lichLamViec.MaLich });
            }
        }

        private void hienThiThongTinNV()
        {
            NhanVienDTO nhanVien = Service.NhanVienService.docThongTinNV();
            labelMa.Text = nhanVien.MaNV;
            labelTen.Text = nhanVien.TenNV;
            labelVaitro.Text = nhanVien.ViTri;
            labelTrungtam.Text = nhanVien.MaTT;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            String maLich = (comboBoxThoiGian.SelectedItem as dynamic).Value;
            DialogResult dialogResult = MessageBox.Show("Xác nhận gửi ?", "Xác nhận", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {
                List<Thongtin_dk_lichlamviecDTO> lichs = khoiTao(maLich);
                if (Service.Thongtin_dk_lichlamviecService.themLichDangKy(lichs))
                {
                    MessageBox.Show("Gửi thành công");
                }
                else
                {
                    MessageBox.Show("Gửi thất bại");
                }
            }
        }

        private List<Thongtin_dk_lichlamviecDTO> khoiTao(String maLich)
        {
            List<Thongtin_dk_lichlamviecDTO> lichs = new List<Thongtin_dk_lichlamviecDTO>();

            for (int rows = 0; rows < GridDangKy.Rows.Count - 1; rows++)
            {
                Thongtin_dk_lichlamviecDTO lich = new Thongtin_dk_lichlamviecDTO();

                string ngay = GridDangKy.Rows[rows].Cells[0].Value.ToString();
                string ca = GridDangKy.Rows[rows].Cells[1].Value.ToString();

                lich.MaLich = maLich;
                lich.Ngay = DateTime.ParseExact(ngay, "dd/MM/yyyy", null);
                lich.Ca = ca;
                lichs.Add(lich);
            }

            return lichs;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String maLich = (comboBoxThoiGian.SelectedItem as dynamic).Value;
            DateTime ngay = dateNgay.Value.Date;
            String ca = comboBoxCa.Text;
            if (Service.LichLamViecService.kiemTraThoiGianTrongLich(ngay, maLich))
            {
                GridDangKy.Rows.Add(ngay.ToString("dd/MM/yyyy"), ca);
            }
            else
            {
                MessageBox.Show("Thời gian không hợp lệ");
            }
        }
    }
}
