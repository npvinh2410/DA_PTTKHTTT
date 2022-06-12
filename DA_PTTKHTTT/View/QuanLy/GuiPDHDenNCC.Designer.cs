namespace DA_PTTKHTTT.View.QuanLy
{
    partial class GuiPDHDenNCC
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
            this.gridCTPDH = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmountVC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTPDH)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCTPDH
            // 
            this.gridCTPDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCTPDH.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridCTPDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCTPDH.Location = new System.Drawing.Point(135, 80);
            this.gridCTPDH.MultiSelect = false;
            this.gridCTPDH.Name = "gridCTPDH";
            this.gridCTPDH.ReadOnly = true;
            this.gridCTPDH.RowHeadersVisible = false;
            this.gridCTPDH.Size = new System.Drawing.Size(542, 253);
            this.gridCTPDH.TabIndex = 0;
            this.gridCTPDH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCTPDH_CellContentClick);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(602, 341);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Gửi";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng số vắc xin:";
            // 
            // txtAmountVC
            // 
            this.txtAmountVC.Enabled = false;
            this.txtAmountVC.Location = new System.Drawing.Point(234, 339);
            this.txtAmountVC.Name = "txtAmountVC";
            this.txtAmountVC.Size = new System.Drawing.Size(79, 20);
            this.txtAmountVC.TabIndex = 3;
            this.txtAmountVC.Text = "00";
            this.txtAmountVC.TextChanged += new System.EventHandler(this.txtAmountVC_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(205, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gửi phiếu đặt hàng đến nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Danh sách vắc xin chờ đặt";
            // 
            // GuiPDHDenNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmountVC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gridCTPDH);
            this.Name = "GuiPDHDenNCC";
            this.Text = "GuiPDHDenNCC";
            ((System.ComponentModel.ISupportInitialize)(this.gridCTPDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCTPDH;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmountVC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}