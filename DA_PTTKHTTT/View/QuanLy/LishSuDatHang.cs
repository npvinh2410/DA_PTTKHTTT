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
    public partial class LishSuDatHang : Form
    {
        public LishSuDatHang()
        {
            InitializeComponent();
            hienThiDSDatHang();
        }

        private void hienThiDSDatHang()
        {
            DataTable dataTable = PhieuDatHangService.docDanhSachPhieuDatHang();
            /*dataTable.Columns.Remove("TINHTRANG");
            dataTable.Columns.Remove("MANV");*/
            gridLichSuDH.DataSource = dataTable;
            gridLichSuDH.AllowUserToAddRows = false;

            gridCTLichSuDH.DataSource = null;
        }

        private void gridLichSuDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridCTLichSuDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridLichSuDH_MouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string maDH = gridLichSuDH.SelectedRows[0].Cells[0].Value.ToString();

            DataTable dataTable = PhieuDatHangService.docCTPhieuDatHang(maDH);
            /*dataTable.Columns.Remove("TINHTRANG");
            dataTable.Columns.Remove("MANV");*/
            gridCTLichSuDH.DataSource = dataTable;
            gridCTLichSuDH.AllowUserToAddRows = false;
        }
    }
}
