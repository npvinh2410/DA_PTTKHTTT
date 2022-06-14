
namespace DA_PTTKHTTT.View.KhachHang
{
    partial class ThanhToan
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
            this.tt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtvhd = new System.Windows.Forms.DataGridView();
            this.XemHD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.httt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.XanNhan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pttt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvhd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tt
            // 
            this.tt.Location = new System.Drawing.Point(254, 398);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(90, 38);
            this.tt.TabIndex = 25;
            this.tt.Text = "Thanh toán";
            this.tt.UseVisualStyleBackColor = true;
            this.tt.Click += new System.EventHandler(this.tt_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtvhd);
            this.panel2.Location = new System.Drawing.Point(365, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 391);
            this.panel2.TabIndex = 24;
            // 
            // dtvhd
            // 
            this.dtvhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvhd.Location = new System.Drawing.Point(3, 3);
            this.dtvhd.Name = "dtvhd";
            this.dtvhd.Size = new System.Drawing.Size(378, 383);
            this.dtvhd.TabIndex = 4;
            this.dtvhd.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtvhd_RowHeaderMouseDoubleClick);
            // 
            // XemHD
            // 
            this.XemHD.Location = new System.Drawing.Point(49, 398);
            this.XemHD.Name = "XemHD";
            this.XemHD.Size = new System.Drawing.Size(90, 38);
            this.XemHD.TabIndex = 23;
            this.XemHD.Text = "Xem hóa đơn";
            this.XemHD.UseVisualStyleBackColor = true;
            this.XemHD.Click += new System.EventHandler(this.XemHD_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.httt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.XanNhan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pttt);
            this.panel1.Location = new System.Drawing.Point(49, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 210);
            this.panel1.TabIndex = 22;
            // 
            // httt
            // 
            this.httt.FormattingEnabled = true;
            this.httt.Items.AddRange(new object[] {
            "Trực tiếp",
            "Qua thẻ"});
            this.httt.Location = new System.Drawing.Point(22, 40);
            this.httt.Name = "httt";
            this.httt.Size = new System.Drawing.Size(121, 21);
            this.httt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phương thức thanh toán";
            // 
            // XanNhan
            // 
            this.XanNhan.Location = new System.Drawing.Point(193, 82);
            this.XanNhan.Name = "XanNhan";
            this.XanNhan.Size = new System.Drawing.Size(78, 33);
            this.XanNhan.TabIndex = 2;
            this.XanNhan.Text = "Xác nhận";
            this.XanNhan.UseVisualStyleBackColor = true;
            this.XanNhan.Click += new System.EventHandler(this.XanNhan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hình thức thanh toán";
            // 
            // pttt
            // 
            this.pttt.FormattingEnabled = true;
            this.pttt.Items.AddRange(new object[] {
            "Thanh toán một lần",
            "Thanh toán theo đợt"});
            this.pttt.Location = new System.Drawing.Point(22, 136);
            this.pttt.Name = "pttt";
            this.pttt.Size = new System.Drawing.Size(121, 21);
            this.pttt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thanh toán";
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 459);
            this.Controls.Add(this.tt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.XemHD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ThanhToan";
            this.Text = "ThanhToan";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvhd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtvhd;
        private System.Windows.Forms.Button XemHD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox httt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button XanNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pttt;
        private System.Windows.Forms.Label label1;
    }
}