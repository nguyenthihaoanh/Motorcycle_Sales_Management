namespace QuanLyCuaHangXeMay
{
    partial class frmThongKe
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
            this.btThoat = new System.Windows.Forms.Button();
            this.dGVThongKe = new System.Windows.Forms.DataGridView();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.gbThongKe = new System.Windows.Forms.GroupBox();
            this.lbQLThongKe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btThoat.Location = new System.Drawing.Point(346, 557);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(119, 45);
            this.btThoat.TabIndex = 38;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // dGVThongKe
            // 
            this.dGVThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVThongKe.Location = new System.Drawing.Point(45, 236);
            this.dGVThongKe.Name = "dGVThongKe";
            this.dGVThongKe.RowHeadersWidth = 51;
            this.dGVThongKe.RowTemplate.Height = 24;
            this.dGVThongKe.Size = new System.Drawing.Size(721, 297);
            this.dGVThongKe.TabIndex = 5;
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTenNhanVien.BackColor = System.Drawing.SystemColors.Info;
            this.lbTenNhanVien.Location = new System.Drawing.Point(543, 0);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(264, 23);
            this.lbTenNhanVien.TabIndex = 9;
            // 
            // gbThongKe
            // 
            this.gbThongKe.Location = new System.Drawing.Point(45, 90);
            this.gbThongKe.Name = "gbThongKe";
            this.gbThongKe.Size = new System.Drawing.Size(721, 128);
            this.gbThongKe.TabIndex = 48;
            this.gbThongKe.TabStop = false;
            this.gbThongKe.Text = "Thống Kê Doanh Thu";
            // 
            // lbQLThongKe
            // 
            this.lbQLThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLThongKe.Location = new System.Drawing.Point(3, 23);
            this.lbQLThongKe.Name = "lbQLThongKe";
            this.lbQLThongKe.Size = new System.Drawing.Size(804, 44);
            this.lbQLThongKe.TabIndex = 51;
            this.lbQLThongKe.Text = "Quản Lý Thống Kê";
            this.lbQLThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 619);
            this.Controls.Add(this.lbQLThongKe);
            this.Controls.Add(this.gbThongKe);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.dGVThongKe);
            this.Controls.Add(this.lbTenNhanVien);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Bán Xe Máy Anh Tuấn";
            ((System.ComponentModel.ISupportInitialize)(this.dGVThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVThongKe;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.GroupBox gbThongKe;
        private System.Windows.Forms.Label lbQLThongKe;
    }
}