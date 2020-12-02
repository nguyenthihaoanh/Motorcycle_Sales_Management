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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btThoat = new System.Windows.Forms.Button();
            this.gbThongKe = new System.Windows.Forms.GroupBox();
            this.lbQLThongKe = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.qLMuaBanXeDataSet = new QuanLyCuaHangXeMay.QLMuaBanXeDataSet();
            this.qLMuaBanXeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMuaBanXeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMuaBanXeDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.White;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btThoat.Location = new System.Drawing.Point(893, 894);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(119, 45);
            this.btThoat.TabIndex = 38;
            this.btThoat.Text = "Trở Về";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // gbThongKe
            // 
            this.gbThongKe.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.gbThongKe.Location = new System.Drawing.Point(139, 90);
            this.gbThongKe.Name = "gbThongKe";
            this.gbThongKe.Size = new System.Drawing.Size(1762, 128);
            this.gbThongKe.TabIndex = 48;
            this.gbThongKe.TabStop = false;
            this.gbThongKe.Text = "Thống Kê Doanh Thu";
            // 
            // lbQLThongKe
            // 
            this.lbQLThongKe.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.lbQLThongKe.Location = new System.Drawing.Point(3, 23);
            this.lbQLThongKe.Name = "lbQLThongKe";
            this.lbQLThongKe.Size = new System.Drawing.Size(1898, 44);
            this.lbQLThongKe.TabIndex = 51;
            this.lbQLThongKe.Text = "Quản Lý Thống Kê";
            this.lbQLThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(373, 267);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "HoaDonXe";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueMembers = "CTHoaDonXe";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(729, 599);
            this.chart1.TabIndex = 52;
            this.chart1.Text = "chart1";
            // 
            // qLMuaBanXeDataSet
            // 
            this.qLMuaBanXeDataSet.DataSetName = "QLMuaBanXeDataSet";
            this.qLMuaBanXeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLMuaBanXeDataSetBindingSource
            // 
            this.qLMuaBanXeDataSetBindingSource.DataSource = this.qLMuaBanXeDataSet;
            this.qLMuaBanXeDataSetBindingSource.Position = 0;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lbQLThongKe);
            this.Controls.Add(this.gbThongKe);
            this.Controls.Add(this.btThoat);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Bán Xe Máy Anh Tuấn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMuaBanXeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLMuaBanXeDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox gbThongKe;
        private System.Windows.Forms.Label lbQLThongKe;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource qLMuaBanXeDataSetBindingSource;
        private QLMuaBanXeDataSet qLMuaBanXeDataSet;
    }
}