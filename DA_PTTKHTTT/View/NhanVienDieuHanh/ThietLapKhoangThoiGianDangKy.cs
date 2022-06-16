using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_PTTKHTTT
{
    public partial class ThietLapKhoangThoiGianDangKy : Form
    {
        public ThietLapKhoangThoiGianDangKy()
        {
            InitializeComponent();
        }

        private void btnThietLap_Click(object sender, EventArgs e)
        {
            DateTime thoiGianTu = dateThoiGianTu.Value.Date;
            DateTime thoiGianDen = dateThoiGianDen.Value.Date;
            DTO.LichLamViecDTO lichLamViec = Service.LichLamViecService.khoiTao(thoiGianTu, thoiGianDen);
            if (Service.LichLamViecService.KiemTraThoiGianHopLe(thoiGianTu, thoiGianDen))
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận tạo ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Service.LichLamViecService.themLichLamViec(lichLamViec);
                    MessageBox.Show("Thêm thành công");
                }
            }
            else
            {
                MessageBox.Show("Các mốc thời gian không hợp lệ");
            }

        }
    }
}
