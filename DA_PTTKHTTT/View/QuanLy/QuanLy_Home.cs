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
    public partial class QuanLy_Home : Form
    {
        public QuanLy_Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLy.DuyetDSDatMua form = new QuanLy.DuyetDSDatMua();
            form.ShowDialog();
        }
    }
}
