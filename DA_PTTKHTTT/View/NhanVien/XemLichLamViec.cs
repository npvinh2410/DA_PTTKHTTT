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
    public partial class XemLichLamViec : Form
    {
        public XemLichLamViec()
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

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            String maLich = (comboBoxThoiGian.SelectedItem as dynamic).Value;
            DataTable dataTable = Service.Lichlamviec_nvService.docLichLamViecNV(maLich, labelMa.Text);
            GridLichLamViec.DataSource = dataTable;
        }
    }
}
