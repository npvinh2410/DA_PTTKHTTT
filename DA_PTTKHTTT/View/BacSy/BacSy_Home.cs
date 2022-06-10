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
    public partial class BacSy_Home : Form
    {
        public BacSy_Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XemLichLamViec form = new XemLichLamViec();
            form.ShowDialog();
        }

        private void BacSy_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DangKyLichLamViec form = new DangKyLichLamViec();
            form.ShowDialog();
        }
    }
}
