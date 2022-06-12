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

namespace DA_PTTKHTTT.View.QuanLy
{
    public partial class GuiPDHDenNCC : Form
    {
        public GuiPDHDenNCC()
        {
            InitializeComponent();
            hienThiDSCTDatHang();
            hienThiSLCTDatHang();
        }
        private void hienThiDSCTDatHang()
        {
            DataTable dataTable = GuiPDHService.docDanhSachCTPhieuDatHang();
            /*dataTable.Columns.Remove("TINHTRANG");
            dataTable.Columns.Remove("MANV");*/
            gridCTPDH.DataSource = dataTable;
            gridCTPDH.AllowUserToAddRows = false;
        }

        private void hienThiSLCTDatHang()
        {
            int amountVC = GuiPDHService.docSoLuongVCDH();

            txtAmountVC.Text = amountVC.ToString();
        }

        private void gridCTPDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtAmountVC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int soLuong = Int32.Parse(txtAmountVC.Text);

            if(soLuong > 0)
            {
                if (!GuiPDHService.GuiPDH())
                {
                    MessageBox.Show("Gửi không thành công!");
                }
                else
                {
                    gridCTPDH.DataSource = null;
                    txtAmountVC.Text = "0";
                }
            }
            else
            {
                MessageBox.Show("Phiếu trống, không thể gửi!");
            }
        }
    }
}
