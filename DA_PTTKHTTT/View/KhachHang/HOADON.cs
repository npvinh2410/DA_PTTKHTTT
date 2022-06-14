using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_PTTKHTTT.View.KhachHang
{
    public partial class HOADON : Form
    {
        public HOADON(string maHD, string lanThanhToan, string pTTT, string tongTien)
        {
            InitializeComponent();

            mahd.Text = maHD;
            lantt.Text = lanThanhToan;
            loaitt.Text = pTTT;
            tongtien.Text = tongTien;

            DataTable dtb = Service.HoaDonService.DocCTHoaDon(maHD);
            CTHoaDon.DataSource = dtb;
        }
    }
}
