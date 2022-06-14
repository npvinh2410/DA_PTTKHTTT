namespace DA_PTTKHTTT.View.BacSy
{
    partial class KhamSangLoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhietDo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHuyetAp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnChoTiem = new System.Windows.Forms.Button();
            this.btnKhongChoTiem = new System.Windows.Forms.Button();
            this.btnNhapKham = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHÁM SÀNG LỌC";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(91, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(616, 78);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhiệt độ";
            // 
            // txtNhietDo
            // 
            this.txtNhietDo.Location = new System.Drawing.Point(174, 165);
            this.txtNhietDo.Name = "txtNhietDo";
            this.txtNhietDo.Size = new System.Drawing.Size(142, 22);
            this.txtNhietDo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(474, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Huyết áp";
            // 
            // txtHuyetAp
            // 
            this.txtHuyetAp.Location = new System.Drawing.Point(565, 166);
            this.txtHuyetAp.Name = "txtHuyetAp";
            this.txtHuyetAp.Size = new System.Drawing.Size(142, 22);
            this.txtHuyetAp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Có tiền sử bệnh nền không?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.comboBox1.Location = new System.Drawing.Point(366, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "-- Chọn --";
            // 
            // btnChoTiem
            // 
            this.btnChoTiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoTiem.Location = new System.Drawing.Point(91, 358);
            this.btnChoTiem.Name = "btnChoTiem";
            this.btnChoTiem.Size = new System.Drawing.Size(255, 52);
            this.btnChoTiem.TabIndex = 8;
            this.btnChoTiem.Text = "Cho phép TIÊM";
            this.btnChoTiem.UseVisualStyleBackColor = true;
            this.btnChoTiem.Click += new System.EventHandler(this.btnChoTiem_Click);
            // 
            // btnKhongChoTiem
            // 
            this.btnKhongChoTiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongChoTiem.Location = new System.Drawing.Point(452, 358);
            this.btnKhongChoTiem.Name = "btnKhongChoTiem";
            this.btnKhongChoTiem.Size = new System.Drawing.Size(255, 52);
            this.btnKhongChoTiem.TabIndex = 9;
            this.btnKhongChoTiem.Text = "KHÔNG cho phép TIÊM";
            this.btnKhongChoTiem.UseVisualStyleBackColor = true;
            this.btnKhongChoTiem.Click += new System.EventHandler(this.btnKhongChoTiem_Click);
            // 
            // btnNhapKham
            // 
            this.btnNhapKham.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapKham.ForeColor = System.Drawing.Color.Red;
            this.btnNhapKham.Location = new System.Drawing.Point(255, 281);
            this.btnNhapKham.Name = "btnNhapKham";
            this.btnNhapKham.Size = new System.Drawing.Size(267, 44);
            this.btnNhapKham.TabIndex = 10;
            this.btnNhapKham.Text = "Nhập";
            this.btnNhapKham.UseVisualStyleBackColor = true;
            this.btnNhapKham.Click += new System.EventHandler(this.btnNhapKham_Click);
            // 
            // KhamSangLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNhapKham);
            this.Controls.Add(this.btnKhongChoTiem);
            this.Controls.Add(this.btnChoTiem);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHuyetAp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNhietDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "KhamSangLoc";
            this.Text = "KhamSangLoc";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhietDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHuyetAp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnChoTiem;
        private System.Windows.Forms.Button btnKhongChoTiem;
        private System.Windows.Forms.Button btnNhapKham;
    }
}