namespace DA_PTTKHTTT.View.QuanLy
{
    partial class LishSuDatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridLichSuDH = new System.Windows.Forms.DataGridView();
            this.gridCTLichSuDH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridLichSuDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTLichSuDH)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLichSuDH
            // 
            this.gridLichSuDH.AllowUserToAddRows = false;
            this.gridLichSuDH.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridLichSuDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLichSuDH.Location = new System.Drawing.Point(64, 113);
            this.gridLichSuDH.MultiSelect = false;
            this.gridLichSuDH.Name = "gridLichSuDH";
            this.gridLichSuDH.ReadOnly = true;
            this.gridLichSuDH.RowHeadersVisible = false;
            this.gridLichSuDH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLichSuDH.Size = new System.Drawing.Size(377, 263);
            this.gridLichSuDH.TabIndex = 0;
            this.gridLichSuDH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLichSuDH_CellContentClick);
            this.gridLichSuDH.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridLichSuDH_MouseClick);
            // 
            // gridCTLichSuDH
            // 
            this.gridCTLichSuDH.AllowUserToAddRows = false;
            this.gridCTLichSuDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCTLichSuDH.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridCTLichSuDH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridCTLichSuDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCTLichSuDH.Location = new System.Drawing.Point(458, 113);
            this.gridCTLichSuDH.Name = "gridCTLichSuDH";
            this.gridCTLichSuDH.ReadOnly = true;
            this.gridCTLichSuDH.RowHeadersVisible = false;
            this.gridCTLichSuDH.Size = new System.Drawing.Size(283, 263);
            this.gridCTLichSuDH.TabIndex = 1;
            this.gridCTLichSuDH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCTLichSuDH_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(312, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lịch sử đặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách phiếu đặt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chi tiết phiếu đặt";
            // 
            // LishSuDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridCTLichSuDH);
            this.Controls.Add(this.gridLichSuDH);
            this.Name = "LishSuDatHang";
            this.Text = "LishSuDatHang";
            ((System.ComponentModel.ISupportInitialize)(this.gridLichSuDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTLichSuDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLichSuDH;
        private System.Windows.Forms.DataGridView gridCTLichSuDH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}