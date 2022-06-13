using DA_PTTKHTTT.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_PTTKHTTT.View.BacSy
{
    /*List<BenhNen> listItem;*/
    public partial class KhamSangLoc : Form
    {
        public KhamSangLoc()
        {
            InitializeComponent();

            /*listItem = new List<BenhNen>()
            {
                new BenhNen(){Status = "Có"},
                new BenhNen(){Status = "Không"}
            };
            comboBox1.DataSource = listItem;*/
            comboBox1.DisplayMember = "Name";

            string MaKH = null;
            xemHoSoKhachHang(MaKH);
        }

        private void xemHoSoKhachHang(string MaKH)
        {
            DataTable dataTable = HoSoTiemChungService.docDanhSachKhachHangTiem();
            dataGridView1.DataSource = dataTable;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = null;
        }

        private void btnChoTiem_Click(object sender, EventArgs e)
        {

        }

    }

    public class BenhNen
    {
        public string Status { get; set; }
    }
}
