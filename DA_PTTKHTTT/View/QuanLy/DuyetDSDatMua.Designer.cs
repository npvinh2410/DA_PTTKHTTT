namespace DA_PTTKHTTT.View.QuanLy
{
    partial class DuyetDSDatMua
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
            this.gridDuyetPDM = new System.Windows.Forms.DataGridView();
            this.gridDuyetCTPDM = new System.Windows.Forms.DataGridView();
            this.btnAgree = new System.Windows.Forms.Button();
            this.btnDisgree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDuyetPDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDuyetCTPDM)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDuyetPDM
            // 
            this.gridDuyetPDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDuyetPDM.Location = new System.Drawing.Point(51, 112);
            this.gridDuyetPDM.Name = "gridDuyetPDM";
            this.gridDuyetPDM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDuyetPDM.Size = new System.Drawing.Size(276, 233);
            this.gridDuyetPDM.TabIndex = 0;
            this.gridDuyetPDM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDuyetPDM_CellContentClick);
            this.gridDuyetPDM.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridDuyetPDM_MouseClick);
            // 
            // gridDuyetCTPDM
            // 
            this.gridDuyetCTPDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDuyetCTPDM.Location = new System.Drawing.Point(350, 112);
            this.gridDuyetCTPDM.Name = "gridDuyetCTPDM";
            this.gridDuyetCTPDM.Size = new System.Drawing.Size(384, 233);
            this.gridDuyetCTPDM.TabIndex = 1;
            this.gridDuyetCTPDM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDuyetCTPDM_CellContentClick);
            // 
            // btnAgree
            // 
            this.btnAgree.Location = new System.Drawing.Point(646, 360);
            this.btnAgree.Name = "btnAgree";
            this.btnAgree.Size = new System.Drawing.Size(75, 23);
            this.btnAgree.TabIndex = 2;
            this.btnAgree.Text = "Duyệt";
            this.btnAgree.UseVisualStyleBackColor = true;
            this.btnAgree.Click += new System.EventHandler(this.btnAgree_Click);
            // 
            // btnDisgree
            // 
            this.btnDisgree.Location = new System.Drawing.Point(546, 360);
            this.btnDisgree.Name = "btnDisgree";
            this.btnDisgree.Size = new System.Drawing.Size(75, 23);
            this.btnDisgree.TabIndex = 3;
            this.btnDisgree.Text = "Không duyệt";
            this.btnDisgree.UseVisualStyleBackColor = true;
            this.btnDisgree.Click += new System.EventHandler(this.btnDisgree_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(267, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Duyệt danh sách đặt mua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Danh sách phiếu đặt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chi tiết phiếu đặt";
            // 
            // DuyetDSDatMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisgree);
            this.Controls.Add(this.btnAgree);
            this.Controls.Add(this.gridDuyetCTPDM);
            this.Controls.Add(this.gridDuyetPDM);
            this.Name = "DuyetDSDatMua";
            this.Text = "DuyetDSDatMua";
            this.Load += new System.EventHandler(this.DuyetDSDatMua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDuyetPDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDuyetCTPDM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDuyetPDM;
        private System.Windows.Forms.DataGridView gridDuyetCTPDM;
        private System.Windows.Forms.Button btnAgree;
        private System.Windows.Forms.Button btnDisgree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}