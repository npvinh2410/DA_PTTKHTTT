
namespace DA_PTTKHTTT.View.KhachHang
{
    partial class ChonGoiTiem
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
            this.btn_hoanthanh = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grid_dsgoitiemchon = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.cbb_trungtamtiem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ngaytiem = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_dsgoitiem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsgoitiemchon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsgoitiem)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hoanthanh
            // 
            this.btn_hoanthanh.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_hoanthanh.Location = new System.Drawing.Point(335, 504);
            this.btn_hoanthanh.Name = "btn_hoanthanh";
            this.btn_hoanthanh.Size = new System.Drawing.Size(158, 34);
            this.btn_hoanthanh.TabIndex = 75;
            this.btn_hoanthanh.Text = "HOÀN THÀNH";
            this.btn_hoanthanh.UseVisualStyleBackColor = false;
            this.btn_hoanthanh.Click += new System.EventHandler(this.btn_hoanthanh_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_xoa.Location = new System.Drawing.Point(509, 279);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(158, 37);
            this.btn_xoa.TabIndex = 74;
            this.btn_xoa.Text = "XÓA";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_capnhat.Location = new System.Drawing.Point(335, 281);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(158, 35);
            this.btn_capnhat.TabIndex = 73;
            this.btn_capnhat.Text = "CẬP NHẬT";
            this.btn_capnhat.UseVisualStyleBackColor = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "DANH SÁCH GÓI TIÊM CHỌN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // grid_dsgoitiemchon
            // 
            this.grid_dsgoitiemchon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_dsgoitiemchon.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grid_dsgoitiemchon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_dsgoitiemchon.Location = new System.Drawing.Point(165, 354);
            this.grid_dsgoitiemchon.Margin = new System.Windows.Forms.Padding(4);
            this.grid_dsgoitiemchon.Name = "grid_dsgoitiemchon";
            this.grid_dsgoitiemchon.ReadOnly = true;
            this.grid_dsgoitiemchon.RowHeadersVisible = false;
            this.grid_dsgoitiemchon.RowHeadersWidth = 51;
            this.grid_dsgoitiemchon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_dsgoitiemchon.Size = new System.Drawing.Size(496, 130);
            this.grid_dsgoitiemchon.TabIndex = 71;
            this.grid_dsgoitiemchon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_dsgoitiemchon_CellContentClick);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_them.Location = new System.Drawing.Point(165, 279);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(158, 37);
            this.btn_them.TabIndex = 70;
            this.btn_them.Text = "THÊM";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // cbb_trungtamtiem
            // 
            this.cbb_trungtamtiem.FormattingEnabled = true;
            this.cbb_trungtamtiem.Items.AddRange(new object[] {
            "TT1001",
            "TT1002"});
            this.cbb_trungtamtiem.Location = new System.Drawing.Point(298, 240);
            this.cbb_trungtamtiem.Name = "cbb_trungtamtiem";
            this.cbb_trungtamtiem.Size = new System.Drawing.Size(250, 24);
            this.cbb_trungtamtiem.TabIndex = 69;
            this.cbb_trungtamtiem.SelectedIndexChanged += new System.EventHandler(this.cbb_trungtamtiem_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 17);
            this.label3.TabIndex = 68;
            this.label3.Text = "CHỌN TRUNG TÂM TIÊM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "CHỌN NGÀY TIÊM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_ngaytiem
            // 
            this.tb_ngaytiem.Location = new System.Drawing.Point(299, 185);
            this.tb_ngaytiem.Name = "tb_ngaytiem";
            this.tb_ngaytiem.Size = new System.Drawing.Size(250, 22);
            this.tb_ngaytiem.TabIndex = 66;
            this.tb_ngaytiem.ValueChanged += new System.EventHandler(this.tb_ngaytiem_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "DANH SÁCH GÓI TIÊM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grid_dsgoitiem
            // 
            this.grid_dsgoitiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_dsgoitiem.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grid_dsgoitiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_dsgoitiem.Location = new System.Drawing.Point(165, 32);
            this.grid_dsgoitiem.Margin = new System.Windows.Forms.Padding(4);
            this.grid_dsgoitiem.Name = "grid_dsgoitiem";
            this.grid_dsgoitiem.ReadOnly = true;
            this.grid_dsgoitiem.RowHeadersVisible = false;
            this.grid_dsgoitiem.RowHeadersWidth = 51;
            this.grid_dsgoitiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_dsgoitiem.Size = new System.Drawing.Size(496, 130);
            this.grid_dsgoitiem.TabIndex = 64;
            this.grid_dsgoitiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_dsgoitiem_CellContentClick);
            // 
            // ChonGoiTiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.btn_hoanthanh);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grid_dsgoitiemchon);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.cbb_trungtamtiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ngaytiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_dsgoitiem);
            this.Name = "ChonGoiTiem";
            this.Text = "ChonGoiTiem";
            this.Load += new System.EventHandler(this.ChonGoiTiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsgoitiemchon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_dsgoitiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hoanthanh;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grid_dsgoitiemchon;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cbb_trungtamtiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tb_ngaytiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_dsgoitiem;
    }
}