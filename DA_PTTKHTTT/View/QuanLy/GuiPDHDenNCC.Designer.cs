﻿namespace DA_PTTKHTTT.View.QuanLy
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
            ((System.ComponentModel.ISupportInitialize)(this.gridCTPDH)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCTPDH
            // 
            this.gridCTPDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCTPDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCTPDH.Location = new System.Drawing.Point(136, 68);
            this.gridCTPDH.MultiSelect = false;
            this.gridCTPDH.Name = "gridCTPDH";
            this.gridCTPDH.ReadOnly = true;
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
            // GuiPDHDenNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}