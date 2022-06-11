
namespace DA_PTTKHTTT
{
    partial class PhanCongBacSi
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
            this.btnThemLichLamViec = new System.Windows.Forms.Button();
            this.GridLichLamViec = new System.Windows.Forms.DataGridView();
            this.GridLichDangKy = new System.Windows.Forms.DataGridView();
            this.GridThongTin = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.comboBoxThoiGian = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridLichLamViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLichDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridThongTin)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemLichLamViec
            // 
            this.btnThemLichLamViec.Location = new System.Drawing.Point(1065, 245);
            this.btnThemLichLamViec.Name = "btnThemLichLamViec";
            this.btnThemLichLamViec.Size = new System.Drawing.Size(66, 44);
            this.btnThemLichLamViec.TabIndex = 16;
            this.btnThemLichLamViec.Text = "Thêm";
            this.btnThemLichLamViec.UseVisualStyleBackColor = true;
            this.btnThemLichLamViec.Click += new System.EventHandler(this.btnThemLichLamViec_Click);
            // 
            // GridLichLamViec
            // 
            this.GridLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLichLamViec.Location = new System.Drawing.Point(709, 477);
            this.GridLichLamViec.Name = "GridLichLamViec";
            this.GridLichLamViec.RowHeadersWidth = 51;
            this.GridLichLamViec.RowTemplate.Height = 24;
            this.GridLichLamViec.Size = new System.Drawing.Size(313, 192);
            this.GridLichLamViec.TabIndex = 13;
            // 
            // GridLichDangKy
            // 
            this.GridLichDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLichDangKy.Location = new System.Drawing.Point(709, 245);
            this.GridLichDangKy.Name = "GridLichDangKy";
            this.GridLichDangKy.RowHeadersWidth = 51;
            this.GridLichDangKy.RowTemplate.Height = 24;
            this.GridLichDangKy.Size = new System.Drawing.Size(313, 186);
            this.GridLichDangKy.TabIndex = 14;
            // 
            // GridThongTin
            // 
            this.GridThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridThongTin.Location = new System.Drawing.Point(46, 245);
            this.GridThongTin.Name = "GridThongTin";
            this.GridThongTin.RowHeadersWidth = 51;
            this.GridThongTin.RowTemplate.Height = 24;
            this.GridThongTin.Size = new System.Drawing.Size(598, 424);
            this.GridThongTin.TabIndex = 15;
            this.GridThongTin.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GridThongTin_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(822, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lịch làm việc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(790, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thông tin lịch đăng ký";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Thông tin nhân viên đăng ký";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "PHÂN CÔNG BÁC SĨ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.comboBoxThoiGian);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnHienThi);
            this.panel1.Location = new System.Drawing.Point(163, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 79);
            this.panel1.TabIndex = 17;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(705, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(68, 34);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // comboBoxThoiGian
            // 
            this.comboBoxThoiGian.FormattingEnabled = true;
            this.comboBoxThoiGian.Location = new System.Drawing.Point(333, 30);
            this.comboBoxThoiGian.Name = "comboBoxThoiGian";
            this.comboBoxThoiGian.Size = new System.Drawing.Size(232, 24);
            this.comboBoxThoiGian.TabIndex = 9;
            this.comboBoxThoiGian.Text = "-- Chọn giời gian --";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(173, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Chọn khoảng thời gian:";
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(593, 24);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(80, 34);
            this.btnHienThi.TabIndex = 7;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // PhanCongBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 704);
            this.Controls.Add(this.btnThemLichLamViec);
            this.Controls.Add(this.GridLichLamViec);
            this.Controls.Add(this.GridLichDangKy);
            this.Controls.Add(this.GridThongTin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "PhanCongBacSi";
            this.Text = "PhanCongBacSi";
            ((System.ComponentModel.ISupportInitialize)(this.GridLichLamViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLichDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridThongTin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemLichLamViec;
        private System.Windows.Forms.DataGridView GridLichLamViec;
        private System.Windows.Forms.DataGridView GridLichDangKy;
        private System.Windows.Forms.DataGridView GridThongTin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox comboBoxThoiGian;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnHienThi;
    }
}