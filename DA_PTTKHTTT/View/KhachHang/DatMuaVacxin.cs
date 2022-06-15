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
    public partial class DatMuaVacxin : Form
    {
        public DatMuaVacxin()
        {
            InitializeComponent();

            docDSGoiTiem();
            docDSVC();
        }

        private void docDSGoiTiem()
        {
            DataTable dataTable = GoiTiemService.docGoiTiem();
            gridDatMuaGoi.DataSource = dataTable;
            gridDatMuaGoi.AllowUserToAddRows = false;
        }

        private void docCTGoiTiem(string maGT)
        {
            DataTable dataTable = GoiTiemService.docCTGoiTiem(maGT);
            gridTraCuuVC.DataSource = dataTable;
            dataTable.Columns.Remove("SOLUONGTON");
            dataTable.Columns.Remove("DONGIA");
            gridTraCuuVC.AllowUserToAddRows = false;
        }

        private void docDSVC()
        {
            DataTable dataTable = VacXinService.docDanhSachVC();
            gridDatMuaLe.DataSource = dataTable;
            dataTable.Columns.Remove("SOLUONGTON");
            gridDatMuaLe.AllowUserToAddRows = false;
        }

        private void docDSDatMuaKH(string maKH)
        {
            DataTable dataTable = PhieuDatMuaService.docDSDatMuaKH(maKH);
            gridLSDSDM.DataSource = dataTable;
            dataTable.Columns.Remove("MAKH");
            gridLSDSDM.AllowUserToAddRows = false;
        }

        private void docCTPhieuDatMua(string maPD)
        {
            DataTable dataTable = PhieuDatMuaService.docCTPhieuDatMua(maPD);
            gridLSCTDM.DataSource = dataTable;
            gridLSCTDM.AllowUserToAddRows = false;
        }

        private List<string> docDSGoiDuocChon()
        {
            List<string> dsMaGoi = new List<string>();
            int selectCount = gridDatMuaGoi.SelectedRows.Count;

            for (int i = 0; i < selectCount; i++)
            {
                dsMaGoi.Add(gridDatMuaGoi.SelectedRows[i].Cells[0].Value.ToString());
            }
            return dsMaGoi;
        }

        private List<string> docDSVCDuocChon()
        {
            List<string> dsMaVC = new List<string>();
            int selectCount = gridDatMuaLe.SelectedRows.Count;

            for (int i = 0; i < selectCount; i++)
            {
                dsMaVC.Add(gridDatMuaLe.SelectedRows[i].Cells[0].Value.ToString());
            }
            return dsMaVC;
        }

        private bool kiemTraKHThanhVien()
        {
            string maKH = txtIDCustomer.Text;

            if(maKH == "")
            {
                MessageBox.Show("Vui lòng nhập mã KH!");
                return false;
            }

            KhachHangDTO kh = KhachHangService.docThongTinKH(maKH);

            if (kh == null)
            {
                MessageBox.Show("Khách hàng không tồn tại!");
                return false;
            }

            txtInfoName.Text = kh.TenKH;
            txtInfoAddress.Text = kh.DiaChi;
            txtInfoPhone.Text = kh.Sdt;

            return true;
        }

        private bool kiemTraKH()
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string gender = radioGenderMale.Checked ? "Nam" : "Nữ";

            if (name == "" || phone == "" || address == "")
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin!");
                return false;
            }

            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void txtIDCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            if(index == 1)
            {
                DataTable dataTable = GoiTiemService.docGoiTiem();
                gridTraCuuGoi.DataSource = dataTable;
                dataTable.Columns.Remove("THANHTIEN");
                gridTraCuuGoi.AllowUserToAddRows = false;

                docCTGoiTiem(gridTraCuuGoi.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgree_Click(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            // Loại KH
            int loaiKH = tabControl2.SelectedIndex;
            
            if(loaiKH == 0)
            {
                if (!kiemTraKHThanhVien())
                    return;
            }
            else
            {
                if (!kiemTraKH())
                    return;
            }

            List<string> dsMaGoi = docDSGoiDuocChon();
            List<string> dsMaVC = docDSVCDuocChon();

            if (dsMaGoi.Count == 0 && dsMaVC.Count == 0)
            {
                MessageBox.Show("Cần chọn vắc xin!");
                return;
            }

            string maKH = "";
            KhachHangDTO kh = new KhachHangDTO();
            kh = null;

            if (loaiKH == 0)
            {
                maKH = txtIDCustomer.Text;

            }
            else
            {
                string tenKH = txtName.Text;
                string sdt = txtPhone.Text;
                string diaChi = txtAddress.Text;
                string gioiTinh = radioGenderMale.Checked ? "Nam" : "Nữ";

                kh = KhachHangService.khoiTaoKH(tenKH, sdt, diaChi, gioiTinh);
            }

            maKH = VacXinService.datMuaVC(maKH, kh, dsMaGoi, dsMaVC);

            if (maKH==null)
            {
                MessageBox.Show("Không thành công!");
            }
            else
            {
                MessageBox.Show("Thành công!");
                MessageBox.Show("Mã Khách hàng của bạn là: " + maKH);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtInfoPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtIDCustomer_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCheckInfo_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridDatMuaGoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCheckInfo_Click_1(object sender, EventArgs e)
        {
            kiemTraKHThanhVien();
        }

        private void txtInfoName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInfoPhone_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtInfoAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioGenderMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioGenderFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gridDatMuaLe_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXemLS_Click(object sender, EventArgs e)
        {
            string maKH = txtLSmaKH.Text;

            if(maKH == "" || maKH == "Nhập mã KH")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng!");
                return;
            }

            docDSDatMuaKH(maKH);
        }

        private void gridLSDSDM_MouseClick(object sender, MouseEventArgs e)
        {
            string maPD = gridLSDSDM.SelectedRows[0].Cells[0].Value.ToString();
            docCTPhieuDatMua(maPD);
        }

        private void gridLSDSDM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }

        private void txtLSmaKH_Click(object sender, EventArgs e)
        {
            if (txtLSmaKH.Text == "Nhập mã KH")
            {
                txtLSmaKH.Text = "";
            }
        }

        private void gridDatMuaGoi_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridDatMuaGoi.ClearSelection();
        }

        private void gridDatMuaLe_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridDatMuaLe.ClearSelection();
        }

        private void radioBtnTatCaVC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnTatCaVC.Checked)
            {
                DataTable dataTable = VacXinService.docDanhSachVC();
                gridTraCuuVC.DataSource = dataTable;
                dataTable.Columns.Remove("SOLUONGTON");
                dataTable.Columns.Remove("DONGIA");
                gridTraCuuVC.AllowUserToAddRows = false;

                gridTraCuuGoi.ClearSelection();
            }
        }

        private void gridTraCuuGoi_MouseClick(object sender, DataGridViewCellEventArgs e)
        {
            string maGT = gridTraCuuGoi.SelectedRows[0].Cells[0].Value.ToString();
            docCTGoiTiem(maGT);
            radioBtnTatCaVC.Checked = false;
        }

        private void gridLSCTDM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
