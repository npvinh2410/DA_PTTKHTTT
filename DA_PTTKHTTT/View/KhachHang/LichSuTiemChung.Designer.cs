namespace DA_PTTKHTTT.View.KhachHang
{
    partial class LichSuTiemChung
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
            this.dataGridLichSuTiemChung = new System.Windows.Forms.DataGridView();
            this.btnXem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLichSuTiemChung)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "XEM LỊCH SỬ TIÊM CHỦNG";
            // 
            // dataGridLichSuTiemChung
            // 
            this.dataGridLichSuTiemChung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLichSuTiemChung.Location = new System.Drawing.Point(117, 101);
            this.dataGridLichSuTiemChung.Name = "dataGridLichSuTiemChung";
            this.dataGridLichSuTiemChung.RowHeadersWidth = 51;
            this.dataGridLichSuTiemChung.RowTemplate.Height = 24;
            this.dataGridLichSuTiemChung.Size = new System.Drawing.Size(569, 150);
            this.dataGridLichSuTiemChung.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(504, 309);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(182, 43);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // LichSuTiemChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dataGridLichSuTiemChung);
            this.Controls.Add(this.label1);
            this.Name = "LichSuTiemChung";
            this.Text = "XemLichSuTiemChung";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLichSuTiemChung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridLichSuTiemChung;
        private System.Windows.Forms.Button btnXem;
    }
}