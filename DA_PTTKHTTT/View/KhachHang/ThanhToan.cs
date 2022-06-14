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

namespace DA_PTTKHTTT.View.KhachHang
{
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void XanNhan_Click(object sender, EventArgs e)
        {
            if (httt.Text != "" && pttt.Text != "")
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn xác nhận?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                switch (rs)
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:
                        string maHD = Service.HoaDonService.TaoHoaDon(pttt.Text, httt.Text);
                        Service.HoaDonService.TaoCTHoaDon(maHD);
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }

            }
            else
            {
                MessageBox.Show("Bạn cần nhập đầy thủ thông tin để xác nhận");
                return;
            }
        }

        private void XemHD_Click(object sender, EventArgs e)
        {
            string mahd = LoginInfo.USERNAME.ToUpper();
            DataTable dtb = Service.HoaDonService.DocHoaDon(mahd);
            dtvhd.DataSource = dtb;
        }

        private void tt_Click(object sender, EventArgs e)
        {
            string mahd = dtvhd.SelectedRows[0].Cells[0].Value.ToString();
            string lantt = dtvhd.SelectedRows[0].Cells[1].Value.ToString();
            string pttt = dtvhd.SelectedRows[0].Cells[2].Value.ToString();
            if (dtvhd.SelectedRows != null)
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn xác nhận thanh toán?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                switch (rs)
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:
                        if (Service.HoaDonService.THThanhtoan(lantt, pttt) == 1)
                        {
                            MessageBox.Show("Hóa đơn này bạn đã thanh toán xong");
                            return;
                        }
                        else
                        {
                            Service.HoaDonService.ThanhToanHoaDon(mahd, lantt, pttt);
                            MessageBox.Show("Bạn đã thanh toán thành công");
                            XemHD_Click(sender, e);
                        }

                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
            else
                MessageBox.Show("Bạn cần chọn hóa đơn để thanh toán");
        }

        private void dtvhd_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string mahd = dtvhd["MAHD", e.RowIndex].Value.ToString();
            string lantt = dtvhd["LANTHANHTOAN", e.RowIndex].Value.ToString();
            string pttt = dtvhd["PHUONGTHUCTHANHTOAN", e.RowIndex].Value.ToString();
            string tong = dtvhd["TONGTIEN", e.RowIndex].Value.ToString();

            HOADON f_hd = new HOADON(mahd, lantt, pttt, tong);

            f_hd.Show();
        }
    }
}

