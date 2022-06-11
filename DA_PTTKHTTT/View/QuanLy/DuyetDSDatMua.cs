﻿using System;
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
    public partial class DuyetDSDatMua : Form
    {
        public DuyetDSDatMua()
        {
            InitializeComponent();
            hienThiDSDatMua();
        }

        private void hienThiDSDatMua()
        {
            DataTable dataTable = PhieuDatMuaService.docDanhSachPhieuDatMuaChoDuyet();
            dataTable.Columns.Remove("TINHTRANG");
            dataTable.Columns.Remove("MANV");
            gridDuyetPDM.DataSource = dataTable;
            gridDuyetPDM.AllowUserToAddRows = false;

            gridDuyetCTPDM.DataSource = null;
        }

        private List<string> docDSPhieuDuocChon()
        {
            List<string> dsMaPD = new List<string>();
            int selectCount = gridDuyetPDM.SelectedRows.Count;

            for (int i = 0; i < selectCount; i++)
            {
                dsMaPD.Add(gridDuyetPDM.SelectedRows[i].Cells[0].Value.ToString());
            }
            return dsMaPD;
        }


        private void gridDuyetPDM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnAgree_Click(object sender, EventArgs e)
        {
            List<string> dsMaPD = docDSPhieuDuocChon();

            if (!DuyetPDMService.DuyetPDM(dsMaPD, 1))
            {
                MessageBox.Show("Duyệt không thành công");
            }

            hienThiDSDatMua();
        }

        private void gridDuyetPDM_MouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string maPD = gridDuyetPDM.SelectedRows[0].Cells[0].Value.ToString();

            DataTable dataTable = PhieuDatMuaService.docCTPhieuDatMua(maPD);
            gridDuyetCTPDM.DataSource = dataTable;

        }

        private void gridDuyetCTPDM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDisgree_Click(object sender, EventArgs e)
        {
            List<string> dsMaPD = docDSPhieuDuocChon();

            if (!DuyetPDMService.DuyetPDM(dsMaPD, 0))
            {
                MessageBox.Show("không thành công");
            }

            hienThiDSDatMua();
        }
    }
}