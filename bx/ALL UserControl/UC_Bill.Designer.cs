namespace bx.ALL_UserControl
{
    partial class UC_Bill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Bill));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.grbTK = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimMaHD = new System.Windows.Forms.TextBox();
            this.lblTimMaHD = new System.Windows.Forms.Label();
            this.lblTimMaKH = new System.Windows.Forms.Label();
            this.txtTimMaKH = new System.Windows.Forms.TextBox();
            this.dgvQLHD = new System.Windows.Forms.DataGridView();
            this.lblHDTT = new System.Windows.Forms.Label();
            this.btnInHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.grbTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHD)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(1169, 915);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(260, 33);
            this.txtThanhTien.TabIndex = 45;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblThanhTien.ForeColor = System.Drawing.Color.Transparent;
            this.lblThanhTien.Location = new System.Drawing.Point(1021, 915);
            this.lblThanhTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(135, 32);
            this.lblThanhTien.TabIndex = 44;
            this.lblThanhTien.Text = "Thành tiền";
            // 
            // grbTK
            // 
            this.grbTK.Controls.Add(this.btnTimKiem);
            this.grbTK.Controls.Add(this.txtTimMaHD);
            this.grbTK.Controls.Add(this.lblTimMaHD);
            this.grbTK.Controls.Add(this.lblTimMaKH);
            this.grbTK.Controls.Add(this.txtTimMaKH);
            this.grbTK.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTK.ForeColor = System.Drawing.Color.White;
            this.grbTK.Location = new System.Drawing.Point(109, 75);
            this.grbTK.Name = "grbTK";
            this.grbTK.Size = new System.Drawing.Size(1248, 112);
            this.grbTK.TabIndex = 43;
            this.grbTK.TabStop = false;
            this.grbTK.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
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
            this.btnTimKiem.Location = new System.Drawing.Point(918, 33);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(131, 55);
            this.btnTimKiem.TabIndex = 68;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimMaHD
            // 
            this.txtTimMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMaHD.Location = new System.Drawing.Point(630, 44);
            this.txtTimMaHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimMaHD.Name = "txtTimMaHD";
            this.txtTimMaHD.Size = new System.Drawing.Size(187, 33);
            this.txtTimMaHD.TabIndex = 35;
            // 
            // lblTimMaHD
            // 
            this.lblTimMaHD.AutoSize = true;
            this.lblTimMaHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimMaHD.ForeColor = System.Drawing.Color.Transparent;
            this.lblTimMaHD.Location = new System.Drawing.Point(446, 45);
            this.lblTimMaHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimMaHD.Name = "lblTimMaHD";
            this.lblTimMaHD.Size = new System.Drawing.Size(156, 32);
            this.lblTimMaHD.TabIndex = 34;
            this.lblTimMaHD.Text = "Theo Mã HĐ";
            // 
            // lblTimMaKH
            // 
            this.lblTimMaKH.AutoSize = true;
            this.lblTimMaKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTimMaKH.ForeColor = System.Drawing.Color.Transparent;
            this.lblTimMaKH.Location = new System.Drawing.Point(27, 46);
            this.lblTimMaKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimMaKH.Name = "lblTimMaKH";
            this.lblTimMaKH.Size = new System.Drawing.Size(154, 32);
            this.lblTimMaKH.TabIndex = 33;
            this.lblTimMaKH.Text = "Theo Mã KH";
            // 
            // txtTimMaKH
            // 
            this.txtTimMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMaKH.Location = new System.Drawing.Point(208, 46);
            this.txtTimMaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimMaKH.Name = "txtTimMaKH";
            this.txtTimMaKH.Size = new System.Drawing.Size(187, 33);
            this.txtTimMaKH.TabIndex = 32;
            // 
            // dgvQLHD
            // 
            this.dgvQLHD.AllowUserToAddRows = false;
            this.dgvQLHD.AllowUserToDeleteRows = false;
            this.dgvQLHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLHD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvQLHD.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLHD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLHD.Location = new System.Drawing.Point(44, 195);
            this.dgvQLHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvQLHD.MultiSelect = false;
            this.dgvQLHD.Name = "dgvQLHD";
            this.dgvQLHD.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLHD.RowHeadersWidth = 62;
            this.dgvQLHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLHD.Size = new System.Drawing.Size(1385, 710);
            this.dgvQLHD.TabIndex = 42;
            this.dgvQLHD.SelectionChanged += new System.EventHandler(this.dgvQLHD_SelectionChanged);
            // 
            // lblHDTT
            // 
            this.lblHDTT.AutoSize = true;
            this.lblHDTT.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblHDTT.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDTT.ForeColor = System.Drawing.Color.White;
            this.lblHDTT.Location = new System.Drawing.Point(421, 12);
            this.lblHDTT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHDTT.Name = "lblHDTT";
            this.lblHDTT.Size = new System.Drawing.Size(541, 60);
            this.lblHDTT.TabIndex = 57;
            this.lblHDTT.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BorderRadius = 18;
            this.btnInHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInHoaDon.FillColor = System.Drawing.Color.AliceBlue;
            this.btnInHoaDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.ForeColor = System.Drawing.Color.DimGray;
            this.btnInHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.Image")));
            this.btnInHoaDon.ImageSize = new System.Drawing.Size(30, 30);
            this.btnInHoaDon.Location = new System.Drawing.Point(1196, 983);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(199, 61);
            this.btnInHoaDon.TabIndex = 58;
            this.btnInHoaDon.Text = "In hóa đơn";
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
            this.btnRefresh.Location = new System.Drawing.Point(1316, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(131, 55);
            this.btnRefresh.TabIndex = 61;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UC_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.lblHDTT);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.grbTK);
            this.Controls.Add(this.dgvQLHD);
            this.Name = "UC_Bill";
            this.Size = new System.Drawing.Size(1450, 1100);
            this.Load += new System.EventHandler(this.UC_Bill_Load);
            this.grbTK.ResumeLayout(false);
            this.grbTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.GroupBox grbTK;
        private System.Windows.Forms.TextBox txtTimMaHD;
        private System.Windows.Forms.Label lblTimMaHD;
        private System.Windows.Forms.Label lblTimMaKH;
        private System.Windows.Forms.TextBox txtTimMaKH;
        private System.Windows.Forms.DataGridView dgvQLHD;
        private System.Windows.Forms.Label lblHDTT;
        private Guna.UI2.WinForms.Guna2Button btnInHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}
