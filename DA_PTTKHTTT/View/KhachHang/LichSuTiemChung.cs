using DA_PTTKHTTT.Service;
using DA_PTTKHTTT.DTO;
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
    public partial class LichSuTiemChung : Form
    {
        public LichSuTiemChung()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DataTable dataTable = LichSuTiemChungService.docDSLichSuTC();
            dataGridLichSuTiemChung.DataSource = dataTable;
            dataGridLichSuTiemChung.AllowUserToAddRows = false;
        }
    }
}
