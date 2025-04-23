namespace bx.ALL_UserControl
{
    partial class UC_Revenue
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Revenue));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtLoiNhuan = new System.Windows.Forms.TextBox();
            this.lblLoinhuan = new System.Windows.Forms.Label();
            this.txtTongChi = new System.Windows.Forms.TextBox();
            this.lblTongchi = new System.Windows.Forms.Label();
            this.txtTongThu = new System.Windows.Forms.TextBox();
            this.lblTongthu = new System.Windows.Forms.Label();
            this.chart_DoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grbTKDT = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.dtStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDenngay = new System.Windows.Forms.Label();
            this.lblTungay = new System.Windows.Forms.Label();
            this.attList = new System.Windows.Forms.DataGridView();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnExcel = new Guna.UI2.WinForms.Guna2Button();
            this.qLCHXMDataSet = new bx.QLCHXMDataSet();
            this.thongKeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongKeTableAdapter = new bx.QLCHXMDataSetTableAdapters.ThongKeTableAdapter();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThu)).BeginInit();
            this.grbTKDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHXMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtLoiNhuan
            // 
            this.txtLoiNhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoiNhuan.Location = new System.Drawing.Point(1076, 733);
            this.txtLoiNhuan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoiNhuan.Name = "txtLoiNhuan";
            this.txtLoiNhuan.Size = new System.Drawing.Size(189, 29);
            this.txtLoiNhuan.TabIndex = 55;
            // 
            // lblLoinhuan
            // 
            this.lblLoinhuan.AutoSize = true;
            this.lblLoinhuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLoinhuan.ForeColor = System.Drawing.Color.Transparent;
            this.lblLoinhuan.Location = new System.Drawing.Point(947, 733);
            this.lblLoinhuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoinhuan.Name = "lblLoinhuan";
            this.lblLoinhuan.Size = new System.Drawing.Size(106, 28);
            this.lblLoinhuan.TabIndex = 54;
            this.lblLoinhuan.Text = "Lợi nhuận";
            // 
            // txtTongChi
            // 
            this.txtTongChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongChi.Location = new System.Drawing.Point(721, 733);
            this.txtTongChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongChi.Name = "txtTongChi";
            this.txtTongChi.Size = new System.Drawing.Size(189, 29);
            this.txtTongChi.TabIndex = 53;
            // 
            // lblTongchi
            // 
            this.lblTongchi.AutoSize = true;
            this.lblTongchi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongchi.ForeColor = System.Drawing.Color.Transparent;
            this.lblTongchi.Location = new System.Drawing.Point(592, 733);
            this.lblTongchi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongchi.Name = "lblTongchi";
            this.lblTongchi.Size = new System.Drawing.Size(94, 28);
            this.lblTongchi.TabIndex = 52;
            this.lblTongchi.Text = "Tổng chi";
            // 
            // txtTongThu
            // 
            this.txtTongThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongThu.Location = new System.Drawing.Point(369, 733);
            this.txtTongThu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongThu.Name = "txtTongThu";
            this.txtTongThu.Size = new System.Drawing.Size(189, 29);
            this.txtTongThu.TabIndex = 51;
            // 
            // lblTongthu
            // 
            this.lblTongthu.AutoSize = true;
            this.lblTongthu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongthu.ForeColor = System.Drawing.Color.Transparent;
            this.lblTongthu.Location = new System.Drawing.Point(247, 733);
            this.lblTongthu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongthu.Name = "lblTongthu";
            this.lblTongthu.Size = new System.Drawing.Size(98, 28);
            this.lblTongthu.TabIndex = 50;
            this.lblTongthu.Text = "Tổng thu";
            // 
            // chart_DoanhThu
            // 
            chartArea9.Name = "ChartArea1";
            this.chart_DoanhThu.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart_DoanhThu.Legends.Add(legend9);
            this.chart_DoanhThu.Location = new System.Drawing.Point(604, 40);
            this.chart_DoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart_DoanhThu.Name = "chart_DoanhThu";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            series9.YValuesPerPoint = 2;
            this.chart_DoanhThu.Series.Add(series9);
            this.chart_DoanhThu.Size = new System.Drawing.Size(633, 240);
            this.chart_DoanhThu.TabIndex = 49;
            this.chart_DoanhThu.Text = "chart1";
            // 
            // grbTKDT
            // 
            this.grbTKDT.Controls.Add(this.btnTimKiem);
            this.grbTKDT.Controls.Add(this.dtStart);
            this.grbTKDT.Controls.Add(this.dtEnd);
            this.grbTKDT.Controls.Add(this.lblDenngay);
            this.grbTKDT.Controls.Add(this.lblTungay);
            this.grbTKDT.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTKDT.ForeColor = System.Drawing.Color.White;
            this.grbTKDT.Location = new System.Drawing.Point(46, 26);
            this.grbTKDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTKDT.Name = "grbTKDT";
            this.grbTKDT.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTKDT.Size = new System.Drawing.Size(512, 254);
            this.grbTKDT.TabIndex = 48;
            this.grbTKDT.TabStop = false;
            this.grbTKDT.Text = "THỐNG KÊ DOANH THU";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BorderRadius = 15;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.AliceBlue;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Blue;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTimKiem.Location = new System.Drawing.Point(146, 170);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(116, 44);
            this.btnTimKiem.TabIndex = 68;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtStart
            // 
            this.dtStart.Checked = true;
            this.dtStart.FillColor = System.Drawing.Color.OrangeRed;
            this.dtStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(201, 62);
            this.dtStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(183, 29);
            this.dtStart.TabIndex = 44;
            this.dtStart.Value = new System.DateTime(2025, 3, 11, 19, 4, 58, 781);
            // 
            // dtEnd
            // 
            this.dtEnd.Checked = true;
            this.dtEnd.FillColor = System.Drawing.Color.OrangeRed;
            this.dtEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(201, 108);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(183, 29);
            this.dtEnd.TabIndex = 43;
            this.dtEnd.Value = new System.DateTime(2025, 3, 11, 19, 4, 55, 247);
            // 
            // lblDenngay
            // 
            this.lblDenngay.AutoSize = true;
            this.lblDenngay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDenngay.ForeColor = System.Drawing.Color.Transparent;
            this.lblDenngay.Location = new System.Drawing.Point(57, 108);
            this.lblDenngay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDenngay.Name = "lblDenngay";
            this.lblDenngay.Size = new System.Drawing.Size(102, 28);
            this.lblDenngay.TabIndex = 41;
            this.lblDenngay.Text = "Đến ngày";
            // 
            // lblTungay
            // 
            this.lblTungay.AutoSize = true;
            this.lblTungay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTungay.ForeColor = System.Drawing.Color.Transparent;
            this.lblTungay.Location = new System.Drawing.Point(57, 62);
            this.lblTungay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTungay.Name = "lblTungay";
            this.lblTungay.Size = new System.Drawing.Size(89, 28);
            this.lblTungay.TabIndex = 39;
            this.lblTungay.Text = "Từ ngày";
            // 
            // attList
            // 
            this.attList.AllowUserToAddRows = false;
            this.attList.AllowUserToDeleteRows = false;
            this.attList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.attList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.attList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.attList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.attList.DefaultCellStyle = dataGridViewCellStyle26;
            this.attList.Location = new System.Drawing.Point(46, 294);
            this.attList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.attList.MultiSelect = false;
            this.attList.Name = "attList";
            this.attList.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attList.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.attList.RowHeadersWidth = 62;
            this.attList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.attList.Size = new System.Drawing.Size(1219, 417);
            this.attList.TabIndex = 47;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExcel.BorderRadius = 15;
            this.btnExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcel.FillColor = System.Drawing.Color.AliceBlue;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.DimGray;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExcel.Location = new System.Drawing.Point(1011, 778);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(210, 44);
            this.btnExcel.TabIndex = 56;
            this.btnExcel.Text = "Xuất File Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // qLCHXMDataSet
            // 
            this.qLCHXMDataSet.DataSetName = "QLCHXMDataSet";
            this.qLCHXMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongKeBindingSource
            // 
            this.thongKeBindingSource.DataMember = "ThongKe";
            this.thongKeBindingSource.DataSource = this.qLCHXMDataSet;
            // 
            // thongKeTableAdapter
            // 
            this.thongKeTableAdapter.ClearBeforeFill = true;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(69, 325);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(1168, 360);
            this.dgvThongKe.TabIndex = 57;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.BorderRadius = 15;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Navy;
            this.btnRefresh.Image = global::bx.Properties.Resources.rs2;
            this.btnRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Location = new System.Drawing.Point(46, 718);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(116, 44);
            this.btnRefresh.TabIndex = 68;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UC_Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.txtLoiNhuan);
            this.Controls.Add(this.lblLoinhuan);
            this.Controls.Add(this.txtTongChi);
            this.Controls.Add(this.lblTongchi);
            this.Controls.Add(this.txtTongThu);
            this.Controls.Add(this.lblTongthu);
            this.Controls.Add(this.chart_DoanhThu);
            this.Controls.Add(this.grbTKDT);
            this.Controls.Add(this.attList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Revenue";
            this.Size = new System.Drawing.Size(1289, 880);
            this.Load += new System.EventHandler(this.UC_Revenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_DoanhThu)).EndInit();
            this.grbTKDT.ResumeLayout(false);
            this.grbTKDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHXMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TextBox txtLoiNhuan;
        private System.Windows.Forms.Label lblLoinhuan;
        private System.Windows.Forms.TextBox txtTongChi;
        private System.Windows.Forms.Label lblTongchi;
        private System.Windows.Forms.TextBox txtTongThu;
        private System.Windows.Forms.Label lblTongthu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DoanhThu;
        private System.Windows.Forms.GroupBox grbTKDT;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtEnd;
        private System.Windows.Forms.Label lblDenngay;
        private System.Windows.Forms.Label lblTungay;
        private System.Windows.Forms.DataGridView attList;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btnExcel;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.BindingSource thongKeBindingSource;
        private QLCHXMDataSet qLCHXMDataSet;
        private QLCHXMDataSetTableAdapters.ThongKeTableAdapter thongKeTableAdapter;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}
