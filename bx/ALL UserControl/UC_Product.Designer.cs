namespace bx.ALL_UserControl
{
    partial class UC_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Product));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.grbTTSV = new System.Windows.Forms.GroupBox();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.lblHinhanh = new System.Windows.Forms.Label();
            this.lblGiaban = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.lblDonvi = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblGianhap = new System.Windows.Forms.Label();
            this.lblMausac = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtMauSac = new System.Windows.Forms.TextBox();
            this.lblLoaixe = new System.Windows.Forms.Label();
            this.txtLoaiXe = new System.Windows.Forms.TextBox();
            this.txtHangSanXuat = new System.Windows.Forms.TextBox();
            this.lblHangSX = new System.Windows.Forms.Label();
            this.lblDungtich = new System.Windows.Forms.Label();
            this.txtDungTich = new System.Windows.Forms.TextBox();
            this.lblTenxe = new System.Windows.Forms.Label();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.lblMaxe = new System.Windows.Forms.Label();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.dgvQLSP = new System.Windows.Forms.DataGridView();
            this.lblSanpham = new System.Windows.Forms.Label();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.ptbHinhSP = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.grbTTSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // grbTTSV
            // 
            this.grbTTSV.Controls.Add(this.txtHinhAnh);
            this.grbTTSV.Controls.Add(this.lblHinhanh);
            this.grbTTSV.Controls.Add(this.lblGiaban);
            this.grbTTSV.Controls.Add(this.txtGiaBan);
            this.grbTTSV.Controls.Add(this.lblDonvi);
            this.grbTTSV.Controls.Add(this.txtDonViTinh);
            this.grbTTSV.Controls.Add(this.lblSoluong);
            this.grbTTSV.Controls.Add(this.txtSoLuong);
            this.grbTTSV.Controls.Add(this.lblGianhap);
            this.grbTTSV.Controls.Add(this.lblMausac);
            this.grbTTSV.Controls.Add(this.txtGiaNhap);
            this.grbTTSV.Controls.Add(this.txtMauSac);
            this.grbTTSV.Controls.Add(this.lblLoaixe);
            this.grbTTSV.Controls.Add(this.txtLoaiXe);
            this.grbTTSV.Controls.Add(this.txtHangSanXuat);
            this.grbTTSV.Controls.Add(this.lblHangSX);
            this.grbTTSV.Controls.Add(this.lblDungtich);
            this.grbTTSV.Controls.Add(this.txtDungTich);
            this.grbTTSV.Controls.Add(this.lblTenxe);
            this.grbTTSV.Controls.Add(this.txtTenXe);
            this.grbTTSV.Controls.Add(this.lblMaxe);
            this.grbTTSV.Controls.Add(this.txtMaXe);
            this.grbTTSV.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTSV.ForeColor = System.Drawing.Color.White;
            this.grbTTSV.Location = new System.Drawing.Point(500, 28);
            this.grbTTSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTTSV.Name = "grbTTSV";
            this.grbTTSV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTTSV.Size = new System.Drawing.Size(903, 406);
            this.grbTTSV.TabIndex = 43;
            this.grbTTSV.TabStop = false;
            this.grbTTSV.Text = "Thông tin sản phẩm";
            this.grbTTSV.Enter += new System.EventHandler(this.grbTTSV_Enter);
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHinhAnh.Location = new System.Drawing.Point(251, 346);
            this.txtHinhAnh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.Size = new System.Drawing.Size(169, 33);
            this.txtHinhAnh.TabIndex = 6;
            // 
            // lblHinhanh
            // 
            this.lblHinhanh.AutoSize = true;
            this.lblHinhanh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHinhanh.ForeColor = System.Drawing.Color.Transparent;
            this.lblHinhanh.Location = new System.Drawing.Point(52, 346);
            this.lblHinhanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHinhanh.Name = "lblHinhanh";
            this.lblHinhanh.Size = new System.Drawing.Size(117, 32);
            this.lblHinhanh.TabIndex = 63;
            this.lblHinhanh.Text = "Hình ảnh";
            // 
            // lblGiaban
            // 
            this.lblGiaban.AutoSize = true;
            this.lblGiaban.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGiaban.ForeColor = System.Drawing.Color.Transparent;
            this.lblGiaban.Location = new System.Drawing.Point(494, 178);
            this.lblGiaban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaban.Name = "lblGiaban";
            this.lblGiaban.Size = new System.Drawing.Size(101, 32);
            this.lblGiaban.TabIndex = 62;
            this.lblGiaban.Text = "Giá Bán";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(682, 176);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(178, 33);
            this.txtGiaBan.TabIndex = 9;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // lblDonvi
            // 
            this.lblDonvi.AutoSize = true;
            this.lblDonvi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDonvi.ForeColor = System.Drawing.Color.Transparent;
            this.lblDonvi.Location = new System.Drawing.Point(494, 294);
            this.lblDonvi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonvi.Name = "lblDonvi";
            this.lblDonvi.Size = new System.Drawing.Size(141, 32);
            this.lblDonvi.TabIndex = 61;
            this.lblDonvi.Text = "Đơn vị tính";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Location = new System.Drawing.Point(682, 292);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(178, 33);
            this.txtDonViTinh.TabIndex = 11;
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoluong.ForeColor = System.Drawing.Color.Transparent;
            this.lblSoluong.Location = new System.Drawing.Point(494, 232);
            this.lblSoluong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(117, 32);
            this.lblSoluong.TabIndex = 60;
            this.lblSoluong.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(682, 234);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(178, 33);
            this.txtSoLuong.TabIndex = 10;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // lblGianhap
            // 
            this.lblGianhap.AutoSize = true;
            this.lblGianhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGianhap.ForeColor = System.Drawing.Color.Transparent;
            this.lblGianhap.Location = new System.Drawing.Point(494, 119);
            this.lblGianhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGianhap.Name = "lblGianhap";
            this.lblGianhap.Size = new System.Drawing.Size(115, 32);
            this.lblGianhap.TabIndex = 59;
            this.lblGianhap.Text = "Giá nhập";
            // 
            // lblMausac
            // 
            this.lblMausac.AutoSize = true;
            this.lblMausac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMausac.ForeColor = System.Drawing.Color.Transparent;
            this.lblMausac.Location = new System.Drawing.Point(494, 59);
            this.lblMausac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMausac.Name = "lblMausac";
            this.lblMausac.Size = new System.Drawing.Size(108, 32);
            this.lblMausac.TabIndex = 58;
            this.lblMausac.Text = "Màu sắc";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Location = new System.Drawing.Point(682, 118);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(178, 33);
            this.txtGiaNhap.TabIndex = 8;
            this.txtGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaNhap_KeyPress);
            // 
            // txtMauSac
            // 
            this.txtMauSac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMauSac.Location = new System.Drawing.Point(682, 58);
            this.txtMauSac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMauSac.Name = "txtMauSac";
            this.txtMauSac.Size = new System.Drawing.Size(178, 33);
            this.txtMauSac.TabIndex = 7;
            this.txtMauSac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMauSac_KeyPress);
            // 
            // lblLoaixe
            // 
            this.lblLoaixe.AutoSize = true;
            this.lblLoaixe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLoaixe.ForeColor = System.Drawing.Color.Transparent;
            this.lblLoaixe.Location = new System.Drawing.Point(52, 180);
            this.lblLoaixe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaixe.Name = "lblLoaixe";
            this.lblLoaixe.Size = new System.Drawing.Size(94, 32);
            this.lblLoaixe.TabIndex = 40;
            this.lblLoaixe.Text = "Loại xe";
            // 
            // txtLoaiXe
            // 
            this.txtLoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiXe.Location = new System.Drawing.Point(251, 176);
            this.txtLoaiXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLoaiXe.Name = "txtLoaiXe";
            this.txtLoaiXe.Size = new System.Drawing.Size(169, 33);
            this.txtLoaiXe.TabIndex = 3;
            this.txtLoaiXe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoaiXe_KeyPress);
            // 
            // txtHangSanXuat
            // 
            this.txtHangSanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHangSanXuat.Location = new System.Drawing.Point(251, 292);
            this.txtHangSanXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHangSanXuat.Name = "txtHangSanXuat";
            this.txtHangSanXuat.Size = new System.Drawing.Size(169, 33);
            this.txtHangSanXuat.TabIndex = 5;
            // 
            // lblHangSX
            // 
            this.lblHangSX.AutoSize = true;
            this.lblHangSX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHangSX.ForeColor = System.Drawing.Color.Transparent;
            this.lblHangSX.Location = new System.Drawing.Point(52, 298);
            this.lblHangSX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHangSX.Name = "lblHangSX";
            this.lblHangSX.Size = new System.Drawing.Size(178, 32);
            this.lblHangSX.TabIndex = 37;
            this.lblHangSX.Text = "Hãng sản xuất";
            // 
            // lblDungtich
            // 
            this.lblDungtich.AutoSize = true;
            this.lblDungtich.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDungtich.ForeColor = System.Drawing.Color.Transparent;
            this.lblDungtich.Location = new System.Drawing.Point(52, 236);
            this.lblDungtich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDungtich.Name = "lblDungtich";
            this.lblDungtich.Size = new System.Drawing.Size(126, 32);
            this.lblDungtich.TabIndex = 36;
            this.lblDungtich.Text = "Dung tích";
            // 
            // txtDungTich
            // 
            this.txtDungTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDungTich.Location = new System.Drawing.Point(251, 232);
            this.txtDungTich.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDungTich.Name = "txtDungTich";
            this.txtDungTich.Size = new System.Drawing.Size(169, 33);
            this.txtDungTich.TabIndex = 4;
            this.txtDungTich.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDungTich_KeyPress);
            // 
            // lblTenxe
            // 
            this.lblTenxe.AutoSize = true;
            this.lblTenxe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTenxe.ForeColor = System.Drawing.Color.Transparent;
            this.lblTenxe.Location = new System.Drawing.Point(52, 122);
            this.lblTenxe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenxe.Name = "lblTenxe";
            this.lblTenxe.Size = new System.Drawing.Size(87, 32);
            this.lblTenxe.TabIndex = 34;
            this.lblTenxe.Text = "Tên xe";
            // 
            // txtTenXe
            // 
            this.txtTenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenXe.Location = new System.Drawing.Point(251, 118);
            this.txtTenXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(169, 33);
            this.txtTenXe.TabIndex = 2;
            this.txtTenXe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenXe_KeyPress);
            // 
            // lblMaxe
            // 
            this.lblMaxe.AutoSize = true;
            this.lblMaxe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMaxe.ForeColor = System.Drawing.Color.Transparent;
            this.lblMaxe.Location = new System.Drawing.Point(52, 62);
            this.lblMaxe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxe.Name = "lblMaxe";
            this.lblMaxe.Size = new System.Drawing.Size(83, 32);
            this.lblMaxe.TabIndex = 32;
            this.lblMaxe.Text = "Mã xe";
            // 
            // txtMaXe
            // 
            this.txtMaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaXe.Location = new System.Drawing.Point(251, 58);
            this.txtMaXe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(169, 33);
            this.txtMaXe.TabIndex = 1;
            this.txtMaXe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaXe_KeyPress);
            // 
            // dgvQLSP
            // 
            this.dgvQLSP.AllowUserToAddRows = false;
            this.dgvQLSP.AllowUserToDeleteRows = false;
            this.dgvQLSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQLSP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvQLSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvQLSP.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLSP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLSP.Location = new System.Drawing.Point(48, 535);
            this.dgvQLSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvQLSP.MultiSelect = false;
            this.dgvQLSP.Name = "dgvQLSP";
            this.dgvQLSP.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLSP.RowHeadersVisible = false;
            this.dgvQLSP.RowHeadersWidth = 62;
            this.dgvQLSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLSP.Size = new System.Drawing.Size(1354, 524);
            this.dgvQLSP.TabIndex = 42;
            this.dgvQLSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLSP_CellContentClick);
            this.dgvQLSP.SelectionChanged += new System.EventHandler(this.dgvQLSP_SelectionChanged);
            // 
            // lblSanpham
            // 
            this.lblSanpham.AutoSize = true;
            this.lblSanpham.BackColor = System.Drawing.Color.Transparent;
            this.lblSanpham.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanpham.ForeColor = System.Drawing.Color.White;
            this.lblSanpham.Location = new System.Drawing.Point(50, 18);
            this.lblSanpham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSanpham.Name = "lblSanpham";
            this.lblSanpham.Size = new System.Drawing.Size(262, 60);
            this.lblSanpham.TabIndex = 57;
            this.lblSanpham.Text = "SẢN PHẨM";
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
            this.btnTimKiem.Location = new System.Drawing.Point(1262, 454);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(130, 55);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderRadius = 15;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.AliceBlue;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Maroon;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoa.Location = new System.Drawing.Point(1112, 454);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 55);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BorderRadius = 15;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.AliceBlue;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Purple;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSua.Location = new System.Drawing.Point(964, 454);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(130, 55);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BorderRadius = 15;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.AliceBlue;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Green;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThem.Location = new System.Drawing.Point(814, 454);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 55);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ptbHinhSP
            // 
            this.ptbHinhSP.Location = new System.Drawing.Point(60, 95);
            this.ptbHinhSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbHinhSP.Name = "ptbHinhSP";
            this.ptbHinhSP.Size = new System.Drawing.Size(399, 369);
            this.ptbHinhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbHinhSP.TabIndex = 45;
            this.ptbHinhSP.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderRadius = 15;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.AliceBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Navy;
            this.btnRefresh.Image = global::bx.Properties.Resources.rs2;
            this.btnRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Location = new System.Drawing.Point(500, 452);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 55);
            this.btnRefresh.TabIndex = 68;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UC_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblSanpham);
            this.Controls.Add(this.ptbHinhSP);
            this.Controls.Add(this.grbTTSV);
            this.Controls.Add(this.dgvQLSP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_Product";
            this.Size = new System.Drawing.Size(1450, 1100);
            this.Load += new System.EventHandler(this.UC_Product_Load);
            this.grbTTSV.ResumeLayout(false);
            this.grbTTSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHinhSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox ptbHinhSP;
        private System.Windows.Forms.GroupBox grbTTSV;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtMauSac;
        private System.Windows.Forms.Label lblLoaixe;
        private System.Windows.Forms.TextBox txtLoaiXe;
        private System.Windows.Forms.TextBox txtHangSanXuat;
        private System.Windows.Forms.Label lblHangSX;
        private System.Windows.Forms.Label lblDungtich;
        private System.Windows.Forms.TextBox txtDungTich;
        private System.Windows.Forms.Label lblTenxe;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.Label lblMaxe;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.DataGridView dgvQLSP;
        private System.Windows.Forms.Label lblSanpham;
        private System.Windows.Forms.Label lblGiaban;
        private System.Windows.Forms.Label lblDonvi;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblGianhap;
        private System.Windows.Forms.Label lblMausac;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.Label lblHinhanh;
    }
}
