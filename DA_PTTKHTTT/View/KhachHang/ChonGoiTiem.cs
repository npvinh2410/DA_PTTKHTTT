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

namespace DA_PTTKHTTT.View.KhachHang
{
    public partial class ChonGoiTiem : Form
    {
        private KhachHangDTO kh = new KhachHangDTO();
        private bool loai;
        public ChonGoiTiem(bool loaitiem, string makh, string tenkh, string diachi, string sdt,
            string gioitinh, string hotennt, string moiqh, string sdtnguoithan)
        {
            InitializeComponent();

            //Neu la goi tiem
            if (loaitiem == true)
            {
                docDSGoiTiem();
            }
            else
            {
                docDSVC();
            }
            kh = KhachHangDTO.KhoiTaoKH(makh, tenkh, sdt, gioitinh, diachi, hotennt, moiqh, sdtnguoithan);
            loai = loaitiem;
            string magt = grid_dsgoitiem.Columns[0].Name.ToString();
            string tengt = grid_dsgoitiem.Columns[1].Name.ToString();
            string dongia = grid_dsgoitiem.Columns[3].Name.ToString();
            grid_dsgoitiemchon.Columns.Add(magt, magt);
            grid_dsgoitiemchon.Columns.Add(tengt, tengt);
            grid_dsgoitiemchon.Columns.Add(dongia, dongia);
            grid_dsgoitiemchon.Columns.Add("ngaytiem", "NGAYTIEM");
            grid_dsgoitiemchon.Columns.Add("trungtam", "TRUNGTAMTIEM");
        }

        private void docDSGoiTiem()
        {
            DataTable dataTable = DatMuaVCService.docGoiTiem();
            grid_dsgoitiem.DataSource = dataTable;
            grid_dsgoitiem.AllowUserToAddRows = false;
        }

        private void docDSVC()
        {
            DataTable dataTable = DatMuaVCService.docDanhSachVC();
            grid_dsgoitiem.DataSource = dataTable;
            dataTable.Columns.Remove("SOLUONGTON");
            grid_dsgoitiem.AllowUserToAddRows = false;
        }

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    // You could potentially name the column based on the DGV column name (beware of dupes)
                    // or assign a type based on the data type of the data bound to this DGV column.
                    dt.Columns.Add();
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }

        private void btn_hoanthanh_Click(object sender, EventArgs e)
        {
            View.KhachHang.DangKyTiemChung form = new View.KhachHang.DangKyTiemChung(GetDataTableFromDGV(grid_dsgoitiemchon), loai, kh.MaKH, kh.TenKH
                , kh.DiaChi, kh.Sdt, kh.GioiTinh, kh.NguoiThan, kh.MoiQuanHe, kh.SdtNguoiThan);
            this.Hide();
            form.ShowDialog();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            grid_dsgoitiemchon.Rows.RemoveAt(this.grid_dsgoitiemchon.SelectedRows[0].Index);
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            DateTime ngay = DateTime.Parse(tb_ngaytiem.Value.ToString());
            string trungtamtiem = cbb_trungtamtiem.Text.ToString();
            grid_dsgoitiemchon.SelectedRows[0].Cells[3].Value = ngay;
            grid_dsgoitiemchon.SelectedRows[0].Cells[4].Value = trungtamtiem;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void grid_dsgoitiemchon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tb_ngaytiem.Value.ToString() == "" || cbb_trungtamtiem.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
                return;
            }
            else
            {
                bool kt;
                string magt = grid_dsgoitiem.SelectedRows[0].Cells[0].Value.ToString();
                if (loai==true)
                {
                    kt = PhieuDangKyTiemService.docSLGoiTiemton(magt);
                }    
                else
                {
                    kt = PhieuDangKyTiemService.docSLVacXinton(magt);
                }
                if (kt == true)
                {
                    string tengt = grid_dsgoitiem.SelectedRows[0].Cells[1].Value.ToString();
                    string dongia = grid_dsgoitiem.SelectedRows[0].Cells[3].Value.ToString();
                    DateTime ngay = DateTime.Parse(tb_ngaytiem.Value.ToString());
                    string trungtamtiem = cbb_trungtamtiem.Text.ToString();
                    grid_dsgoitiemchon.Rows.Add(magt, tengt, dongia, ngay, trungtamtiem);
                }
                else
                {
                    MessageBox.Show("Số lượng vắc xin không đủ để đáp ứng. Vui lòng đặt vắc xin thêm!");
                    return;
                }
            }
        }

        private void cbb_trungtamtiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_ngaytiem_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grid_dsgoitiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChonGoiTiem_Load(object sender, EventArgs e)
        {

        }
    }
}
