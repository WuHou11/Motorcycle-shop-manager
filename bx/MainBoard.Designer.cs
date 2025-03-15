namespace bx
{
    partial class MainBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBoard));
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnSuppiler = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_Supplier1 = new bx.ALL_UserControl.UC_Supplier();
            this.uC_Product1 = new bx.ALL_UserControl.UC_Product();
            this.uC_Revenue1 = new bx.ALL_UserControl.UC_Revenue();
            this.uC_Account1 = new bx.ALL_UserControl.UC_Account();
            this.uC_Bill1 = new bx.ALL_UserControl.UC_Bill();
            this.uC_Customer1 = new bx.ALL_UserControl.UC_Customer();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnLogout = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton4 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton5 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton6 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton7 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Black;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Location = new System.Drawing.Point(-1, 526);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(284, 94);
            this.btnCustomer.TabIndex = 39;
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.Black;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.Transparent;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 213);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(284, 94);
            this.btnAccount.TabIndex = 38;
            this.btnAccount.Text = "Tài Khoản";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Black;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnProduct.ForeColor = System.Drawing.Color.Transparent;
            this.btnProduct.Location = new System.Drawing.Point(-1, 317);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(284, 94);
            this.btnProduct.TabIndex = 37;
            this.btnProduct.Text = "Sản Phẩm";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnSuppiler
            // 
            this.btnSuppiler.BackColor = System.Drawing.Color.Black;
            this.btnSuppiler.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnSuppiler.ForeColor = System.Drawing.Color.Transparent;
            this.btnSuppiler.Location = new System.Drawing.Point(-1, 422);
            this.btnSuppiler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuppiler.Name = "btnSuppiler";
            this.btnSuppiler.Size = new System.Drawing.Size(284, 94);
            this.btnSuppiler.TabIndex = 36;
            this.btnSuppiler.Text = "         Đối Tác";
            this.btnSuppiler.UseVisualStyleBackColor = false;
            this.btnSuppiler.Click += new System.EventHandler(this.btnSuppiler_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(1568, 2);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 46);
            this.label8.TabIndex = 62;
            this.label8.Text = "-";
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Black;
            this.lbExit.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbExit.Location = new System.Drawing.Point(1620, 2);
            this.lbExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(45, 46);
            this.lbExit.TabIndex = 60;
            this.lbExit.Text = "x";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1612, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 45);
            this.panel2.TabIndex = 61;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(1556, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(52, 45);
            this.panel3.TabIndex = 63;
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.Black;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnBill.ForeColor = System.Drawing.Color.Transparent;
            this.btnBill.Location = new System.Drawing.Point(-1, 630);
            this.btnBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(284, 94);
            this.btnBill.TabIndex = 65;
            this.btnBill.Text = "Hóa Đơn";
            this.btnBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.Color.Black;
            this.btnRevenue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.ForeColor = System.Drawing.Color.Transparent;
            this.btnRevenue.Location = new System.Drawing.Point(-1, 734);
            this.btnRevenue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(284, 94);
            this.btnRevenue.TabIndex = 67;
            this.btnRevenue.Text = "Doanh Thu";
            this.btnRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRevenue.UseVisualStyleBackColor = false;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_Supplier1);
            this.panel1.Controls.Add(this.uC_Product1);
            this.panel1.Controls.Add(this.uC_Revenue1);
            this.panel1.Controls.Add(this.uC_Account1);
            this.panel1.Controls.Add(this.uC_Bill1);
            this.panel1.Controls.Add(this.uC_Customer1);
            this.panel1.Location = new System.Drawing.Point(291, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 860);
            this.panel1.TabIndex = 68;
            // 
            // uC_Supplier1
            // 
            this.uC_Supplier1.BackColor = System.Drawing.Color.RoyalBlue;
            this.uC_Supplier1.Location = new System.Drawing.Point(0, 3);
            this.uC_Supplier1.Name = "uC_Supplier1";
            this.uC_Supplier1.Size = new System.Drawing.Size(1377, 845);
            this.uC_Supplier1.TabIndex = 5;
            // 
            // uC_Product1
            // 
            this.uC_Product1.BackColor = System.Drawing.Color.RoyalBlue;
            this.uC_Product1.Location = new System.Drawing.Point(-1, 3);
            this.uC_Product1.Name = "uC_Product1";
            this.uC_Product1.Size = new System.Drawing.Size(1377, 845);
            this.uC_Product1.TabIndex = 4;
            // 
            // uC_Revenue1
            // 
            this.uC_Revenue1.BackColor = System.Drawing.Color.RoyalBlue;
            this.uC_Revenue1.Location = new System.Drawing.Point(-1, 3);
            this.uC_Revenue1.Name = "uC_Revenue1";
            this.uC_Revenue1.Size = new System.Drawing.Size(1377, 845);
            this.uC_Revenue1.TabIndex = 1;
            // 
            // uC_Account1
            // 
            this.uC_Account1.BackColor = System.Drawing.Color.RoyalBlue;
            this.uC_Account1.Location = new System.Drawing.Point(0, 3);
            this.uC_Account1.Name = "uC_Account1";
            this.uC_Account1.Size = new System.Drawing.Size(1364, 863);
            this.uC_Account1.TabIndex = 0;
            // 
            // uC_Bill1
            // 
            this.uC_Bill1.BackColor = System.Drawing.Color.RoyalBlue;
            this.uC_Bill1.Location = new System.Drawing.Point(-1, 3);
            this.uC_Bill1.Name = "uC_Bill1";
            this.uC_Bill1.Size = new System.Drawing.Size(1377, 845);
            this.uC_Bill1.TabIndex = 2;
            // 
            // uC_Customer1
            // 
            this.uC_Customer1.BackColor = System.Drawing.Color.RoyalBlue;
            this.uC_Customer1.Location = new System.Drawing.Point(0, 3);
            this.uC_Customer1.Name = "uC_Customer1";
            this.uC_Customer1.Size = new System.Drawing.Size(1377, 845);
            this.uC_Customer1.TabIndex = 3;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // btnLogout
            // 
            this.btnLogout.BorderThickness = 18;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(150, 150);
            this.btnLogout.Location = new System.Drawing.Point(12, 836);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLogout.Size = new System.Drawing.Size(109, 97);
            this.btnLogout.TabIndex = 69;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton2.Image")));
            this.guna2CircleButton2.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2CircleButton2.Location = new System.Drawing.Point(21, 229);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(75, 62);
            this.guna2CircleButton2.TabIndex = 71;
            // 
            // guna2CircleButton3
            // 
            this.guna2CircleButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton3.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton3.Image")));
            this.guna2CircleButton3.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2CircleButton3.Location = new System.Drawing.Point(21, 334);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.Size = new System.Drawing.Size(75, 62);
            this.guna2CircleButton3.TabIndex = 72;
            // 
            // guna2CircleButton4
            // 
            this.guna2CircleButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton4.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton4.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton4.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton4.Image")));
            this.guna2CircleButton4.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2CircleButton4.Location = new System.Drawing.Point(21, 752);
            this.guna2CircleButton4.Name = "guna2CircleButton4";
            this.guna2CircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton4.Size = new System.Drawing.Size(75, 62);
            this.guna2CircleButton4.TabIndex = 73;
            // 
            // guna2CircleButton5
            // 
            this.guna2CircleButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton5.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton5.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton5.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton5.Image")));
            this.guna2CircleButton5.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2CircleButton5.Location = new System.Drawing.Point(21, 442);
            this.guna2CircleButton5.Name = "guna2CircleButton5";
            this.guna2CircleButton5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton5.Size = new System.Drawing.Size(75, 62);
            this.guna2CircleButton5.TabIndex = 74;
            // 
            // guna2CircleButton6
            // 
            this.guna2CircleButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton6.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton6.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton6.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton6.Image")));
            this.guna2CircleButton6.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2CircleButton6.Location = new System.Drawing.Point(21, 539);
            this.guna2CircleButton6.Name = "guna2CircleButton6";
            this.guna2CircleButton6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton6.Size = new System.Drawing.Size(75, 62);
            this.guna2CircleButton6.TabIndex = 75;
            // 
            // guna2CircleButton7
            // 
            this.guna2CircleButton7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton7.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton7.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton7.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton7.Image")));
            this.guna2CircleButton7.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2CircleButton7.Location = new System.Drawing.Point(21, 645);
            this.guna2CircleButton7.Name = "guna2CircleButton7";
            this.guna2CircleButton7.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton7.Size = new System.Drawing.Size(75, 62);
            this.guna2CircleButton7.TabIndex = 76;
            // 
            // MainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1670, 946);
            this.Controls.Add(this.guna2CircleButton7);
            this.Controls.Add(this.guna2CircleButton6);
            this.Controls.Add(this.guna2CircleButton5);
            this.Controls.Add(this.guna2CircleButton4);
            this.Controls.Add(this.guna2CircleButton3);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnSuppiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainBoard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnSuppiler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private ALL_UserControl.UC_Account uC_Account1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private ALL_UserControl.UC_Revenue uC_Revenue1;
        private ALL_UserControl.UC_Supplier uC_Supplier1;
        private ALL_UserControl.UC_Product uC_Product1;
        private ALL_UserControl.UC_Customer uC_Customer1;
        private ALL_UserControl.UC_Bill uC_Bill1;
        private Guna.UI2.WinForms.Guna2CircleButton btnLogout;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton7;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton6;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton5;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton4;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
    }
}