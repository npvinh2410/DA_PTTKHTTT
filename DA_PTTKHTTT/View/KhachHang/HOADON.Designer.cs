
namespace DA_PTTKHTTT.View.KhachHang
{
    partial class HOADON
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
            this.label9 = new System.Windows.Forms.Label();
            this.mahd = new System.Windows.Forms.TextBox();
            this.lantt = new System.Windows.Forms.TextBox();
            this.loaitt = new System.Windows.Forms.TextBox();
            this.tongtien = new System.Windows.Forms.TextBox();
            this.CTHoaDon = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CTHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Loại thanh toán";
            // 
            // mahd
            // 
            this.mahd.Location = new System.Drawing.Point(135, 69);
            this.mahd.Name = "mahd";
            this.mahd.ReadOnly = true;
            this.mahd.Size = new System.Drawing.Size(136, 20);
            this.mahd.TabIndex = 43;
            // 
            // lantt
            // 
            this.lantt.Location = new System.Drawing.Point(135, 110);
            this.lantt.Name = "lantt";
            this.lantt.ReadOnly = true;
            this.lantt.Size = new System.Drawing.Size(136, 20);
            this.lantt.TabIndex = 42;
            // 
            // loaitt
            // 
            this.loaitt.Location = new System.Drawing.Point(135, 147);
            this.loaitt.Name = "loaitt";
            this.loaitt.ReadOnly = true;
            this.loaitt.Size = new System.Drawing.Size(136, 20);
            this.loaitt.TabIndex = 41;
            // 
            // tongtien
            // 
            this.tongtien.Location = new System.Drawing.Point(135, 441);
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            this.tongtien.Size = new System.Drawing.Size(136, 20);
            this.tongtien.TabIndex = 40;
            // 
            // CTHoaDon
            // 
            this.CTHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CTHoaDon.Location = new System.Drawing.Point(35, 204);
            this.CTHoaDon.Name = "CTHoaDon";
            this.CTHoaDon.Size = new System.Drawing.Size(289, 217);
            this.CTHoaDon.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "Hóa đơn bán hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Lần thanh toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Mã hóa đơn";
            // 
            // HOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 490);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mahd);
            this.Controls.Add(this.lantt);
            this.Controls.Add(this.loaitt);
            this.Controls.Add(this.tongtien);
            this.Controls.Add(this.CTHoaDon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "HOADON";
            this.Text = "HOADON";
            ((System.ComponentModel.ISupportInitialize)(this.CTHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mahd;
        private System.Windows.Forms.TextBox lantt;
        private System.Windows.Forms.TextBox loaitt;
        private System.Windows.Forms.TextBox tongtien;
        private System.Windows.Forms.DataGridView CTHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}