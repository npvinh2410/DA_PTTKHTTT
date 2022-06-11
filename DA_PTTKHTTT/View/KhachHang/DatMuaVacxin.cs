using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_PTTKHTTT.View.QuanLy
{
    public partial class DatMuaVacxin : Form
    {
        public DatMuaVacxin()
        {
            InitializeComponent();

            DataGridViewCheckBoxColumn dgvcCheckBox = new DataGridViewCheckBoxColumn();
            dgvcCheckBox.HeaderText = "Chọn mua";
            dataGridView1.Columns.Add(dgvcCheckBox);

            dataGridView1.Rows.Add("1", "Nguyễn", "Thảo", false);
            dataGridView1.Rows.Add("2", "Cái Trí", "Minh", false);
            dataGridView1.Rows.Add("3", "Võ Sơn", "Băng", false);
            dataGridView1.Rows.Add("4", "Nguyễn Đình", "Tuyên", false);
            dataGridView1.Rows.Add("5", "Fernaldo", "Torres", false);

            dataGridView1.AllowUserToAddRows = false;
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void txtBuy_Click(object sender, EventArgs e)
        {
            // Loại KH
            int loaiKH = tabControl2.SelectedIndex;
            MessageBox.Show(loaiKH.ToString());

            String cnt = "";
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                bool checkedCell = (bool)dataGridView1.Rows[i].Cells[3].Value;
                if (checkedCell == true)
                {
                    cnt += dataGridView1.Rows[i].Cells[0].Value;
                }
            }
            MessageBox.Show("selected " + cnt);
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

        private void txtVacxinOther_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCheckInfo_Click_1(object sender, EventArgs e)
        {
            string maKH = this.txtIDCustomer.Text;
            bool checkKH = true;

            if (maKH == "")
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng!");
                return;
            }

            if (checkKH)
            {
                txtInfoName.Text = "Nguyễn Văn Quân";
                txtInfoPhone.Text = "0974298501";
                txtInfoAddress.Text = "KTX khu B";
            }
            else
            {
                MessageBox.Show("khách hàng không tồn tại!");
                return ;
            }
        }

        private void txtInfoName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVacxinOther_TextChanged_1(object sender, EventArgs e)
        {
 
        }

        private void txtVacxinOther_TextClick(object sender, EventArgs e)
        {
            if(txtVacxinKhac.Text == "Nhập tên vắc xin tại đây")
            {
                txtVacxinKhac.Text = "";
            }
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

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
