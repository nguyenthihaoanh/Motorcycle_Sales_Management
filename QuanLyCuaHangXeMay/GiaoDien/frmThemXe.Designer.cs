namespace QuanLyCuaHangXeMay
{
    partial class frmThemXe
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
            this.btLuu = new System.Windows.Forms.Button();
            this.lbThemXe = new System.Windows.Forms.Label();
            this.cbNhanHang = new System.Windows.Forms.ComboBox();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.lbNhanHang = new System.Windows.Forms.Label();
            this.nUpDownSL = new System.Windows.Forms.NumericUpDown();
            this.lbXuatDonGia = new System.Windows.Forms.Label();
            this.cbMauXe = new System.Windows.Forms.ComboBox();
            this.lbMauXe = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownSL)).BeginInit();
            this.SuspendLayout();
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btLuu.Location = new System.Drawing.Point(74, 293);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(100, 45);
            this.btLuu.TabIndex = 41;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // lbThemXe
            // 
            this.lbThemXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbThemXe.Location = new System.Drawing.Point(-2, 9);
            this.lbThemXe.Name = "lbThemXe";
            this.lbThemXe.Size = new System.Drawing.Size(492, 42);
            this.lbThemXe.TabIndex = 40;
            this.lbThemXe.Text = "Thêm Xe";
            this.lbThemXe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbNhanHang
            // 
            this.cbNhanHang.FormattingEnabled = true;
            this.cbNhanHang.Location = new System.Drawing.Point(197, 86);
            this.cbNhanHang.Name = "cbNhanHang";
            this.cbNhanHang.Size = new System.Drawing.Size(234, 24);
            this.cbNhanHang.TabIndex = 38;
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDonGia.Location = new System.Drawing.Point(70, 218);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(75, 20);
            this.lbDonGia.TabIndex = 36;
            this.lbDonGia.Text = "Đơn Giá:";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSL.Location = new System.Drawing.Point(70, 174);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(85, 20);
            this.lbSL.TabIndex = 35;
            this.lbSL.Text = "Số Lượng:";
            // 
            // lbNhanHang
            // 
            this.lbNhanHang.AutoSize = true;
            this.lbNhanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNhanHang.Location = new System.Drawing.Point(70, 86);
            this.lbNhanHang.Name = "lbNhanHang";
            this.lbNhanHang.Size = new System.Drawing.Size(98, 20);
            this.lbNhanHang.TabIndex = 34;
            this.lbNhanHang.Text = "Nhãn Hàng:";
            // 
            // nUpDownSL
            // 
            this.nUpDownSL.Location = new System.Drawing.Point(197, 174);
            this.nUpDownSL.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUpDownSL.Name = "nUpDownSL";
            this.nUpDownSL.Size = new System.Drawing.Size(52, 22);
            this.nUpDownSL.TabIndex = 43;
            // 
            // lbXuatDonGia
            // 
            this.lbXuatDonGia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbXuatDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbXuatDonGia.Location = new System.Drawing.Point(197, 216);
            this.lbXuatDonGia.Name = "lbXuatDonGia";
            this.lbXuatDonGia.Size = new System.Drawing.Size(234, 20);
            this.lbXuatDonGia.TabIndex = 39;
            // 
            // cbMauXe
            // 
            this.cbMauXe.FormattingEnabled = true;
            this.cbMauXe.Location = new System.Drawing.Point(197, 130);
            this.cbMauXe.Name = "cbMauXe";
            this.cbMauXe.Size = new System.Drawing.Size(234, 24);
            this.cbMauXe.TabIndex = 45;
            // 
            // lbMauXe
            // 
            this.lbMauXe.AutoSize = true;
            this.lbMauXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMauXe.Location = new System.Drawing.Point(70, 130);
            this.lbMauXe.Name = "lbMauXe";
            this.lbMauXe.Size = new System.Drawing.Size(71, 20);
            this.lbMauXe.TabIndex = 44;
            this.lbMauXe.Text = "Màu Xe:";
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btThoat.Location = new System.Drawing.Point(331, 293);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 45);
            this.btThoat.TabIndex = 46;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // frmThemXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 362);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.cbMauXe);
            this.Controls.Add(this.lbMauXe);
            this.Controls.Add(this.nUpDownSL);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.lbThemXe);
            this.Controls.Add(this.lbXuatDonGia);
            this.Controls.Add(this.cbNhanHang);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.lbNhanHang);
            this.Name = "frmThemXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Bán Xe Máy Anh Tuấn";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Label lbThemXe;
        private System.Windows.Forms.ComboBox cbNhanHang;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label lbNhanHang;
        private System.Windows.Forms.NumericUpDown nUpDownSL;
        private System.Windows.Forms.Label lbXuatDonGia;
        private System.Windows.Forms.ComboBox cbMauXe;
        private System.Windows.Forms.Label lbMauXe;
        private System.Windows.Forms.Button btThoat;
    }
}