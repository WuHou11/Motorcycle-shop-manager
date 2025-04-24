namespace bx.ALL_UserControl
{
    partial class UC_Account
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Account));
            this.lblQLTK = new System.Windows.Forms.Label();
            this.dgvQLTK = new System.Windows.Forms.DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.grbTK = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimMaNV = new System.Windows.Forms.TextBox();
            this.lblTKMaNV = new System.Windows.Forms.Label();
            this.lblTKTenNV = new System.Windows.Forms.Label();
            this.txtTimTenNV = new System.Windows.Forms.TextBox();
            this.grbTTTK = new System.Windows.Forms.GroupBox();
            this.cbChucVu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLTK)).BeginInit();
            this.grbTK.SuspendLayout();
            this.grbTTTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQLTK
            // 
            this.lblQLTK.AutoSize = true;
            this.lblQLTK.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblQLTK.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLTK.ForeColor = System.Drawing.Color.White;
            this.lblQLTK.Location = new System.Drawing.Point(38, 21);
            this.lblQLTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQLTK.Name = "lblQLTK";
            this.lblQLTK.Size = new System.Drawing.Size(470, 60);
            this.lblQLTK.TabIndex = 56;
            this.lblQLTK.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // dgvQLTK
            // 
            this.dgvQLTK.AllowUserToAddRows = false;
            this.dgvQLTK.AllowUserToDeleteRows = false;
            this.dgvQLTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLTK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvQLTK.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQLTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLTK.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvQLTK.Location = new System.Drawing.Point(500, 234);
            this.dgvQLTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvQLTK.MultiSelect = false;
            this.dgvQLTK.Name = "dgvQLTK";
            this.dgvQLTK.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLTK.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvQLTK.RowHeadersWidth = 62;
            this.dgvQLTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLTK.Size = new System.Drawing.Size(935, 837);
            this.dgvQLTK.TabIndex = 45;
            this.dgvQLTK.SelectionChanged += new System.EventHandler(this.dgvQLTK_SelectionChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // grbTK
            // 
            this.grbTK.Controls.Add(this.btnTimKiem);
            this.grbTK.Controls.Add(this.txtTimMaNV);
            this.grbTK.Controls.Add(this.lblTKMaNV);
            this.grbTK.Controls.Add(this.lblTKTenNV);
            this.grbTK.Controls.Add(this.txtTimTenNV);
            this.grbTK.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTK.ForeColor = System.Drawing.Color.White;
            this.grbTK.Location = new System.Drawing.Point(554, 71);
            this.grbTK.Name = "grbTK";
            this.grbTK.Size = new System.Drawing.Size(746, 146);
            this.grbTK.TabIndex = 64;
            this.grbTK.TabStop = false;
            this.grbTK.Text = "Tìm kiếm";
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
            this.btnTimKiem.Location = new System.Drawing.Point(521, 44);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(131, 55);
            this.btnTimKiem.TabIndex = 68;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimMaNV
            // 
            this.txtTimMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMaNV.Location = new System.Drawing.Point(252, 88);
            this.txtTimMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimMaNV.Name = "txtTimMaNV";
            this.txtTimMaNV.Size = new System.Drawing.Size(187, 33);
            this.txtTimMaNV.TabIndex = 35;
            // 
            // lblTKMaNV
            // 
            this.lblTKMaNV.AutoSize = true;
            this.lblTKMaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTKMaNV.ForeColor = System.Drawing.Color.Transparent;
            this.lblTKMaNV.Location = new System.Drawing.Point(50, 94);
            this.lblTKMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTKMaNV.Name = "lblTKMaNV";
            this.lblTKMaNV.Size = new System.Drawing.Size(155, 32);
            this.lblTKMaNV.TabIndex = 34;
            this.lblTKMaNV.Text = "Theo Mã NV";
            // 
            // lblTKTenNV
            // 
            this.lblTKTenNV.AutoSize = true;
            this.lblTKTenNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTKTenNV.ForeColor = System.Drawing.Color.Transparent;
            this.lblTKTenNV.Location = new System.Drawing.Point(50, 41);
            this.lblTKTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTKTenNV.Name = "lblTKTenNV";
            this.lblTKTenNV.Size = new System.Drawing.Size(159, 32);
            this.lblTKTenNV.TabIndex = 33;
            this.lblTKTenNV.Text = "Theo Tên NV";
            // 
            // txtTimTenNV
            // 
            this.txtTimTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTenNV.Location = new System.Drawing.Point(252, 37);
            this.txtTimTenNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimTenNV.Name = "txtTimTenNV";
            this.txtTimTenNV.Size = new System.Drawing.Size(187, 33);
            this.txtTimTenNV.TabIndex = 32;
            // 
            // grbTTTK
            // 
            this.grbTTTK.Controls.Add(this.cbChucVu);
            this.grbTTTK.Controls.Add(this.lblChucVu);
            this.grbTTTK.Controls.Add(this.lblMaNV);
            this.grbTTTK.Controls.Add(this.txtMaNV);
            this.grbTTTK.Controls.Add(this.rbNu);
            this.grbTTTK.Controls.Add(this.rbNam);
            this.grbTTTK.Controls.Add(this.lblGioiTinh);
            this.grbTTTK.Controls.Add(this.txtPassword);
            this.grbTTTK.Controls.Add(this.lblMatKhau);
            this.grbTTTK.Controls.Add(this.lblTaiKhoan);
            this.grbTTTK.Controls.Add(this.txtUsername);
            this.grbTTTK.Controls.Add(this.txtSDT);
            this.grbTTTK.Controls.Add(this.lblSDT);
            this.grbTTTK.Controls.Add(this.lblEmail);
            this.grbTTTK.Controls.Add(this.txtEmail);
            this.grbTTTK.Controls.Add(this.lblTuoi);
            this.grbTTTK.Controls.Add(this.txtTuoi);
            this.grbTTTK.Controls.Add(this.lblHoTen);
            this.grbTTTK.Controls.Add(this.txtHoTen);
            this.grbTTTK.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.grbTTTK.ForeColor = System.Drawing.Color.White;
            this.grbTTTK.Location = new System.Drawing.Point(27, 112);
            this.grbTTTK.Name = "grbTTTK";
            this.grbTTTK.Size = new System.Drawing.Size(466, 617);
            this.grbTTTK.TabIndex = 65;
            this.grbTTTK.TabStop = false;
            this.grbTTTK.Text = "Thông tin tài khoản";
            // 
            // cbChucVu
            // 
            this.cbChucVu.BackColor = System.Drawing.Color.Transparent;
            this.cbChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChucVu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChucVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbChucVu.ItemHeight = 30;
            this.cbChucVu.Location = new System.Drawing.Point(171, 537);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(260, 36);
            this.cbChucVu.TabIndex = 79;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblChucVu.ForeColor = System.Drawing.Color.Transparent;
            this.lblChucVu.Location = new System.Drawing.Point(15, 541);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(106, 32);
            this.lblChucVu.TabIndex = 78;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMaNV.ForeColor = System.Drawing.Color.Transparent;
            this.lblMaNV.Location = new System.Drawing.Point(15, 73);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(92, 32);
            this.lblMaNV.TabIndex = 77;
            this.lblMaNV.Text = "Mã NV";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(171, 73);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(260, 33);
            this.txtMaNV.TabIndex = 76;
            this.txtMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaNV_KeyPress);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.rbNu.ForeColor = System.Drawing.Color.Transparent;
            this.rbNu.Location = new System.Drawing.Point(307, 249);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(74, 36);
            this.rbNu.TabIndex = 75;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.rbNam.ForeColor = System.Drawing.Color.Transparent;
            this.rbNam.Location = new System.Drawing.Point(171, 249);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(93, 36);
            this.rbNam.TabIndex = 74;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Transparent;
            this.lblGioiTinh.Location = new System.Drawing.Point(15, 251);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(112, 32);
            this.lblGioiTinh.TabIndex = 73;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(171, 487);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(260, 33);
            this.txtPassword.TabIndex = 72;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMatKhau.ForeColor = System.Drawing.Color.Transparent;
            this.lblMatKhau.Location = new System.Drawing.Point(15, 487);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(121, 32);
            this.lblMatKhau.TabIndex = 71;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTaiKhoan.ForeColor = System.Drawing.Color.Transparent;
            this.lblTaiKhoan.Location = new System.Drawing.Point(15, 426);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(123, 32);
            this.lblTaiKhoan.TabIndex = 70;
            this.lblTaiKhoan.Text = "Tài khoản";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(171, 426);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(260, 33);
            this.txtUsername.TabIndex = 69;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.HideSelection = false;
            this.txtSDT.Location = new System.Drawing.Point(171, 364);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(260, 33);
            this.txtSDT.TabIndex = 68;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSDT.ForeColor = System.Drawing.Color.Transparent;
            this.lblSDT.Location = new System.Drawing.Point(15, 364);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(59, 32);
            this.lblSDT.TabIndex = 67;
            this.lblSDT.Text = "SĐT";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(15, 303);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 32);
            this.lblEmail.TabIndex = 66;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(171, 303);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 33);
            this.txtEmail.TabIndex = 65;
            // 
            // lblTuoi
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTuoi.ForeColor = System.Drawing.Color.Transparent;
            this.lblTuoi.Location = new System.Drawing.Point(15, 193);
            this.lblTuoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(63, 32);
            this.lblTuoi.TabIndex = 64;
            this.lblTuoi.Text = "Tuổi";
            // 
            // txtTuoi
            // 
            this.txtTuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuoi.Location = new System.Drawing.Point(171, 193);
            this.txtTuoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(260, 33);
            this.txtTuoi.TabIndex = 63;
            this.txtTuoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTuoi_KeyPress);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.ForeColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Location = new System.Drawing.Point(15, 129);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(94, 32);
            this.lblHoTen.TabIndex = 62;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(171, 129);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(260, 33);
            this.txtHoTen.TabIndex = 61;
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReset.BorderRadius = 10;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.FillColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.ForeColor = System.Drawing.Color.Navy;
            this.btnReset.Image = global::bx.Properties.Resources.rs2;
            this.btnReset.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReset.Location = new System.Drawing.Point(1316, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 51);
            this.btnReset.TabIndex = 61;
            this.btnReset.Text = "Refresh";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(339, 758);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 55);
            this.btnXoa.TabIndex = 63;
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
            this.btnSua.Location = new System.Drawing.Point(188, 758);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(131, 55);
            this.btnSua.TabIndex = 62;
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
            this.btnThem.Location = new System.Drawing.Point(42, 758);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 55);
            this.btnThem.TabIndex = 61;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // UC_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grbTTTK);
            this.Controls.Add(this.grbTK);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblQLTK);
            this.Controls.Add(this.dgvQLTK);
            this.Name = "UC_Account";
            this.Size = new System.Drawing.Size(1450, 1082);
            this.Load += new System.EventHandler(this.UC_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLTK)).EndInit();
            this.grbTK.ResumeLayout(false);
            this.grbTK.PerformLayout();
            this.grbTTTK.ResumeLayout(false);
            this.grbTTTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblQLTK;
        private System.Windows.Forms.DataGridView dgvQLTK;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.GroupBox grbTK;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimMaNV;
        private System.Windows.Forms.Label lblTKMaNV;
        private System.Windows.Forms.Label lblTKTenNV;
        private System.Windows.Forms.TextBox txtTimTenNV;
        private System.Windows.Forms.GroupBox grbTTTK;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2ComboBox cbChucVu;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button btnReset;
    }
}
