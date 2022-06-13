namespace DA_PTTKHTTT.View.BacSy
{
    partial class TiemChung
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.btnTimKiemTiemChung = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKhamSangLoc = new System.Windows.Forms.Button();
            this.btnDaTiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIÊM CHỦNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mã khách hàng:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(255, 93);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(279, 22);
            this.txtMaKH.TabIndex = 2;
            // 
            // btnTimKiemTiemChung
            // 
            this.btnTimKiemTiemChung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimKiemTiemChung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemTiemChung.Location = new System.Drawing.Point(565, 84);
            this.btnTimKiemTiemChung.Name = "btnTimKiemTiemChung";
            this.btnTimKiemTiemChung.Size = new System.Drawing.Size(139, 36);
            this.btnTimKiemTiemChung.TabIndex = 3;
            this.btnTimKiemTiemChung.Text = "Tìm kiếm";
            this.btnTimKiemTiemChung.UseVisualStyleBackColor = false;
            this.btnTimKiemTiemChung.Click += new System.EventHandler(this.btnTimKiemTiemChung_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(85, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(619, 124);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnKhamSangLoc
            // 
            this.btnKhamSangLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKhamSangLoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhamSangLoc.Location = new System.Drawing.Point(85, 316);
            this.btnKhamSangLoc.Name = "btnKhamSangLoc";
            this.btnKhamSangLoc.Size = new System.Drawing.Size(219, 46);
            this.btnKhamSangLoc.TabIndex = 5;
            this.btnKhamSangLoc.Text = "Khám sàng lọc";
            this.btnKhamSangLoc.UseVisualStyleBackColor = false;
            this.btnKhamSangLoc.Click += new System.EventHandler(this.btnKhamSangLoc_Click);
            // 
            // btnDaTiem
            // 
            this.btnDaTiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDaTiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaTiem.Location = new System.Drawing.Point(485, 318);
            this.btnDaTiem.Name = "btnDaTiem";
            this.btnDaTiem.Size = new System.Drawing.Size(219, 46);
            this.btnDaTiem.TabIndex = 6;
            this.btnDaTiem.Text = "Đã tiêm";
            this.btnDaTiem.UseVisualStyleBackColor = false;
            this.btnDaTiem.Click += new System.EventHandler(this.btnDaTiem_Click);
            // 
            // TiemChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDaTiem);
            this.Controls.Add(this.btnKhamSangLoc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTimKiemTiemChung);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TiemChung";
            this.Text = "TiemChung";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button btnTimKiemTiemChung;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKhamSangLoc;
        private System.Windows.Forms.Button btnDaTiem;
    }
}