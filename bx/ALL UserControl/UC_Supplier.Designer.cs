namespace bx.ALL_UserControl
{
    partial class UC_Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Supplier));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimMaNCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimTenNCC = new System.Windows.Forms.TextBox();
            this.grbTTNCC = new System.Windows.Forms.GroupBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.dgvQLNCC = new System.Windows.Forms.DataGridView();
            this.lblNCC = new System.Windows.Forms.Label();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2.SuspendLayout();
            this.grbTTNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.txtTimMaNCC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTimTenNCC);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(544, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 146);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
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
            this.btnTimKiem.Location = new System.Drawing.Point(547, 72);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(131, 55);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimMaNCC
            // 
            this.txtTimMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMaNCC.Location = new System.Drawing.Point(252, 94);
            this.txtTimMaNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimMaNCC.Name = "txtTimMaNCC";
            this.txtTimMaNCC.Size = new System.Drawing.Size(187, 33);
            this.txtTimMaNCC.TabIndex = 2;
            this.txtTimMaNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimMaNCC_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(50, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 32);
            this.label3.TabIndex = 34;
            this.label3.Text = "Theo Mã NCC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(50, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 32);
            this.label9.TabIndex = 33;
            this.label9.Text = "Theo Tên NCC";
            // 
            // txtTimTenNCC
            // 
            this.txtTimTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTenNCC.Location = new System.Drawing.Point(252, 51);
            this.txtTimTenNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimTenNCC.Name = "txtTimTenNCC";
            this.txtTimTenNCC.Size = new System.Drawing.Size(187, 33);
            this.txtTimTenNCC.TabIndex = 1;
            this.txtTimTenNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimTenNCC_KeyPress);
            // 
            // grbTTNCC
            // 
            this.grbTTNCC.Controls.Add(this.lblDiaChi);
            this.grbTTNCC.Controls.Add(this.txtDiaChi);
            this.grbTTNCC.Controls.Add(this.txtSDT);
            this.grbTTNCC.Controls.Add(this.lblSDT);
            this.grbTTNCC.Controls.Add(this.lblEmail);
            this.grbTTNCC.Controls.Add(this.txtEmail);
            this.grbTTNCC.Controls.Add(this.lblTenNCC);
            this.grbTTNCC.Controls.Add(this.txtTenNCC);
            this.grbTTNCC.Controls.Add(this.lblMaNCC);
            this.grbTTNCC.Controls.Add(this.txtMaNCC);
            this.grbTTNCC.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTNCC.ForeColor = System.Drawing.Color.White;
            this.grbTTNCC.Location = new System.Drawing.Point(47, 141);
            this.grbTTNCC.Name = "grbTTNCC";
            this.grbTTNCC.Size = new System.Drawing.Size(464, 546);
            this.grbTTNCC.TabIndex = 38;
            this.grbTTNCC.TabStop = false;
            this.grbTTNCC.Text = "Thông tin nhà cung cấp";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDiaChi.ForeColor = System.Drawing.Color.Transparent;
            this.lblDiaChi.Location = new System.Drawing.Point(13, 189);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(95, 32);
            this.lblDiaChi.TabIndex = 40;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(169, 189);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(260, 33);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(169, 306);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(260, 33);
            this.txtSDT.TabIndex = 5;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSDT.ForeColor = System.Drawing.Color.Transparent;
            this.lblSDT.Location = new System.Drawing.Point(13, 306);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(81, 32);
            this.lblSDT.TabIndex = 37;
            this.lblSDT.Text = "Số ĐT";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(13, 245);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 32);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(169, 245);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 33);
            this.txtEmail.TabIndex = 4;
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTenNCC.ForeColor = System.Drawing.Color.Transparent;
            this.lblTenNCC.Location = new System.Drawing.Point(13, 135);
            this.lblTenNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(109, 32);
            this.lblTenNCC.TabIndex = 34;
            this.lblTenNCC.Text = "Tên NCC";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.Location = new System.Drawing.Point(169, 135);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(260, 33);
            this.txtTenNCC.TabIndex = 2;
            this.txtTenNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNCC_KeyPress);
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.ForeColor = System.Drawing.Color.Transparent;
            this.lblMaNCC.Location = new System.Drawing.Point(13, 75);
            this.lblMaNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(112, 27);
            this.lblMaNCC.TabIndex = 32;
            this.lblMaNCC.Text = "Mã NCC";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(169, 71);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(260, 33);
            this.txtMaNCC.TabIndex = 1;
            this.txtMaNCC.TextChanged += new System.EventHandler(this.txtMaNCC_TextChanged);
            this.txtMaNCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNCC_KeyPress);
            // 
            // dgvQLNCC
            // 
            this.dgvQLNCC.AllowUserToAddRows = false;
            this.dgvQLNCC.AllowUserToDeleteRows = false;
            this.dgvQLNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQLNCC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvQLNCC.BackgroundColor = System.Drawing.Color.White;
            this.dgvQLNCC.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLNCC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLNCC.Location = new System.Drawing.Point(544, 197);
            this.dgvQLNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvQLNCC.MultiSelect = false;
            this.dgvQLNCC.Name = "dgvQLNCC";
            this.dgvQLNCC.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLNCC.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLNCC.RowHeadersVisible = false;
            this.dgvQLNCC.RowHeadersWidth = 62;
            this.dgvQLNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLNCC.Size = new System.Drawing.Size(872, 752);
            this.dgvQLNCC.TabIndex = 37;
            this.dgvQLNCC.SelectionChanged += new System.EventHandler(this.dgvQLNCC_SelectionChanged);
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblNCC.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCC.ForeColor = System.Drawing.Color.White;
            this.lblNCC.Location = new System.Drawing.Point(41, 35);
            this.lblNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(359, 60);
            this.lblNCC.TabIndex = 57;
            this.lblNCC.Text = "NHÀ CUNG CẤP";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DodgerBlue;
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
            this.btnXoa.Location = new System.Drawing.Point(364, 722);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 55);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DodgerBlue;
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
            this.btnSua.Location = new System.Drawing.Point(213, 722);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(131, 55);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DodgerBlue;
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
            this.btnThem.Location = new System.Drawing.Point(67, 722);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 55);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btnRefresh.TabIndex = 78;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UC_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblNCC);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbTTNCC);
            this.Controls.Add(this.dgvQLNCC);
            this.Name = "UC_Supplier";
            this.Size = new System.Drawing.Size(1450, 1100);
            this.Load += new System.EventHandler(this.UC_Supplier_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbTTNCC.ResumeLayout(false);
            this.grbTTNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimMaNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimTenNCC;
        private System.Windows.Forms.GroupBox grbTTNCC;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.DataGridView dgvQLNCC;
        private System.Windows.Forms.Label lblNCC;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}
