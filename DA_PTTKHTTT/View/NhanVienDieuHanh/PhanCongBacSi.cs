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

namespace DA_PTTKHTTT
{
    public partial class PhanCongBacSi : Form
    {
        public PhanCongBacSi()
        {
            InitializeComponent();
            hienThiKhoangThoiGian();
        }

        private void hienThiKhoangThoiGian()
        {
            List<LichLamViecDTO> lichLamViecs = LichLamViecService.DocKhoangThoiGianLichLamViec();
            foreach (LichLamViecDTO lichLamViec in lichLamViecs)
            {
                
                comboBoxThoiGian.DisplayMember = "Text";
                comboBoxThoiGian.ValueMember = "Value";
                String KhoangThoiGian = "Từ " + lichLamViec.NgayApDung.ToString("dd/MM/yyyy")
                                                + " đến " + lichLamViec.NgayKetThuc.ToString("dd/MM/yyyy");
                comboBoxThoiGian.Items.Add(new { Text = KhoangThoiGian, Value = lichLamViec.MaLich });
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            String maLich = (comboBoxThoiGian.SelectedItem as dynamic).Value;
            DataTable dataTable = NhanVienService.DocKhoangThoiGianLichLamViec(maLich);
            GridThongTin.DataSource = dataTable;
        }

        private void RowSelect(object sender, EventArgs e)
        {
            String maLich = (comboBoxThoiGian.SelectedItem as dynamic).Value;
            String maNV = GridThongTin.SelectedRows[0].Cells[0].ToString();
            DataTable dataTable = Thongtin_dk_lichlamviecService.docLichDangKyNhanVien(maLich, maNV);
            GridLichDangKy.DataSource = dataTable;
        }

        private void GridThongTin_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String maLich = (comboBoxThoiGian.SelectedItem as dynamic).Value;
            String maNV = GridThongTin.SelectedRows[0].Cells[0].Value.ToString();
            DataTable dataTable = Thongtin_dk_lichlamviecService.docLichDangKyNhanVien(maLich, maNV);
            GridLichDangKy.DataSource = dataTable;

            GridLichLamViec.DataSource = Lichlamviec_nvService.docLichLamViecNV(maLich, maNV);
        }

        private void btnThemLichLamViec_Click(object sender, EventArgs e)
        {
            String maLich = (comboBoxThoiGian.SelectedItem as dynamic).Value;
            String maNV = GridThongTin.SelectedRows[0].Cells[0].Value.ToString();
            String tenLoaiNV = GridThongTin.SelectedRows[0].Cells[2].Value.ToString();
            DateTime ngay = DateTime.Parse(GridLichDangKy.SelectedRows[0].Cells[0].Value.ToString());
            String Ca = GridLichDangKy.SelectedRows[0].Cells[1].Value.ToString();
            String maNVDH = LoginInfo.USERNAME;

            Lichlamviec_nvDTO lichlamviec = Lichlamviec_nvService.khoiTao(maLich, maNV, ngay, Ca, maNVDH);
            if (Lichlamviec_nvService.kiemTraSoLuongNhanVienDacThu(maLich, ngay, Ca, tenLoaiNV) && !Lichlamviec_nvService.kiemTraTonTai(lichlamviec))
            {
                if (Lichlamviec_nvService.themLichLamViec(lichlamviec) )
                {
                    MessageBox.Show("Thêm thành công");
                    GridLichLamViec.DataSource = Lichlamviec_nvService.docLichLamViecNV(maLich, maNV);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
                
                
            }
            else
            {
                MessageBox.Show("Số lượng " + tenLoaiNV + " đã đủ, không thể thêm");
            }

        }
    }
}
