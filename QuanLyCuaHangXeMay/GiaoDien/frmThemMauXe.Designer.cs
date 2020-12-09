
namespace QuanLyCuaHangXeMay.GiaoDien
{
    partial class frmThemMauXe
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
            this.lbMa = new System.Windows.Forms.Label();
            this.tbTenMau = new System.Windows.Forms.TextBox();
            this.tbMaMau = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbQLNCC = new System.Windows.Forms.Label();
            this.btTroVe = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btNhapLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMa
            // 
            this.lbMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMa.AutoSize = true;
            this.lbMa.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lbMa.Location = new System.Drawing.Point(34, 157);
            this.lbMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(93, 25);
            this.lbMa.TabIndex = 14;
            this.lbMa.Text = "Mã Màu:";
            // 
            // tbTenMau
            // 
            this.tbTenMau.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbTenMau.Location = new System.Drawing.Point(175, 218);
            this.tbTenMau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTenMau.Name = "tbTenMau";
            this.tbTenMau.Size = new System.Drawing.Size(324, 32);
            this.tbTenMau.TabIndex = 17;
            // 
            // tbMaMau
            // 
            this.tbMaMau.Enabled = false;
            this.tbMaMau.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.tbMaMau.Location = new System.Drawing.Point(175, 154);
            this.tbMaMau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMaMau.Name = "tbMaMau";
            this.tbMaMau.Size = new System.Drawing.Size(324, 32);
            this.tbMaMau.TabIndex = 15;
            // 
            // lbTen
            // 
            this.lbTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lbTen.Location = new System.Drawing.Point(34, 221);
            this.lbTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(104, 25);
            this.lbTen.TabIndex = 16;
            this.lbTen.Text = "Tên Màu: ";
            // 
            // lbQLNCC
            // 
            this.lbQLNCC.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbQLNCC.Location = new System.Drawing.Point(-3, 14);
            this.lbQLNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQLNCC.Name = "lbQLNCC";
            this.lbQLNCC.Size = new System.Drawing.Size(566, 69);
            this.lbQLNCC.TabIndex = 87;
            this.lbQLNCC.Text = "Thêm Màu Xe";
            this.lbQLNCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btTroVe
            // 
            this.btTroVe.BackColor = System.Drawing.Color.White;
            this.btTroVe.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btTroVe.Location = new System.Drawing.Point(350, 315);
            this.btTroVe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTroVe.Name = "btTroVe";
            this.btTroVe.Size = new System.Drawing.Size(119, 45);
            this.btTroVe.TabIndex = 89;
            this.btTroVe.Text = "Trở Về";
            this.btTroVe.UseVisualStyleBackColor = false;
            this.btTroVe.Click += new System.EventHandler(this.btTroVe_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.White;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btThem.Location = new System.Drawing.Point(63, 315);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(119, 45);
            this.btThem.TabIndex = 88;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btNhapLai
            // 
            this.btNhapLai.BackColor = System.Drawing.Color.White;
            this.btNhapLai.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btNhapLai.Location = new System.Drawing.Point(208, 315);
            this.btNhapLai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btNhapLai.Name = "btNhapLai";
            this.btNhapLai.Size = new System.Drawing.Size(119, 45);
            this.btNhapLai.TabIndex = 91;
            this.btNhapLai.Text = "Nhập Lại";
            this.btNhapLai.UseVisualStyleBackColor = false;
            this.btNhapLai.Click += new System.EventHandler(this.btNhapLai_Click);
            // 
            // frmThemMauXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(564, 386);
            this.Controls.Add(this.btNhapLai);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTroVe);
            this.Controls.Add(this.lbQLNCC);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.tbTenMau);
            this.Controls.Add(this.tbMaMau);
            this.Controls.Add(this.lbTen);
            this.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThemMauXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Màu Xe";
            this.Load += new System.EventHandler(this.frmThemMauXe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.TextBox tbTenMau;
        private System.Windows.Forms.TextBox tbMaMau;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbQLNCC;
        private System.Windows.Forms.Button btTroVe;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btNhapLai;
    }
}