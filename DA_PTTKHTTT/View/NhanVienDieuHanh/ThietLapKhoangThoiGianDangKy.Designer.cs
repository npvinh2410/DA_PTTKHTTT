
namespace DA_PTTKHTTT
{
    partial class ThietLapKhoangThoiGianDangKy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThietLap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateThoiGianTu = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateThoiGianDen = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThietLap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateThoiGianTu);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateThoiGianDen);
            this.panel1.Location = new System.Drawing.Point(122, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 165);
            this.panel1.TabIndex = 15;
            // 
            // btnThietLap
            // 
            this.btnThietLap.Location = new System.Drawing.Point(316, 111);
            this.btnThietLap.Name = "btnThietLap";
            this.btnThietLap.Size = new System.Drawing.Size(84, 32);
            this.btnThietLap.TabIndex = 14;
            this.btnThietLap.Text = "Thiết lập";
            this.btnThietLap.UseVisualStyleBackColor = true;
            this.btnThietLap.Click += new System.EventHandler(this.btnThietLap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian từ:";
            // 
            // dateThoiGianTu
            // 
            this.dateThoiGianTu.Location = new System.Drawing.Point(150, 23);
            this.dateThoiGianTu.Name = "dateThoiGianTu";
            this.dateThoiGianTu.Size = new System.Drawing.Size(250, 22);
            this.dateThoiGianTu.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hiển thị";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thời gian đến:";
            // 
            // dateThoiGianDen
            // 
            this.dateThoiGianDen.Location = new System.Drawing.Point(150, 72);
            this.dateThoiGianDen.Name = "dateThoiGianDen";
            this.dateThoiGianDen.Size = new System.Drawing.Size(250, 22);
            this.dateThoiGianDen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thiết lập thời gian đăng ký lịch làm việc";
            // 
            // ThietLapKhoangThoiGianDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 294);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ThietLapKhoangThoiGianDangKy";
            this.Text = "ThietLapKhoangThoiGianDangKy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThietLap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateThoiGianTu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateThoiGianDen;
        private System.Windows.Forms.Label label1;
    }
}