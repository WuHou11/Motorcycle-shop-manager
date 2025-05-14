using System.Drawing;
using System.Windows.Forms;

namespace bx
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.display = new System.Windows.Forms.Panel();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.formside = new System.Windows.Forms.Panel();
            this.picEyeOpen = new System.Windows.Forms.PictureBox();
            this.picEyeClosed = new System.Windows.Forms.PictureBox();
            this.lbDieuKhoan = new System.Windows.Forms.Label();
            this.tgAgree = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbMinimize = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.formside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeClosed)).BeginInit();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.AliceBlue;
            this.display.Controls.Add(this.pictureBox_Logo);
            this.display.Controls.Add(this.label2);
            this.display.Controls.Add(this.label1);
            this.display.Location = new System.Drawing.Point(-2, -2);
            this.display.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(515, 729);
            this.display.TabIndex = 0;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.Image")));
            this.pictureBox_Logo.Location = new System.Drawing.Point(61, 290);
            this.pictureBox_Logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(418, 384);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 2;
            this.pictureBox_Logo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(125, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 96);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shop";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(49, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motobikes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formside
            // 
            this.formside.BackColor = System.Drawing.Color.Cyan;
            this.formside.Controls.Add(this.picEyeOpen);
            this.formside.Controls.Add(this.picEyeClosed);
            this.formside.Controls.Add(this.lbDieuKhoan);
            this.formside.Controls.Add(this.tgAgree);
            this.formside.Controls.Add(this.btnClear);
            this.formside.Controls.Add(this.btnLogin);
            this.formside.Controls.Add(this.txtPassword);
            this.formside.Controls.Add(this.txtUsername);
            this.formside.Controls.Add(this.lbMinimize);
            this.formside.Controls.Add(this.lbExit);
            this.formside.Controls.Add(this.panel2);
            this.formside.Controls.Add(this.panel3);
            this.formside.Controls.Add(this.lbForgotPassword);
            this.formside.Controls.Add(this.label5);
            this.formside.Controls.Add(this.label4);
            this.formside.Controls.Add(this.label3);
            this.formside.Location = new System.Drawing.Point(509, -2);
            this.formside.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formside.Name = "formside";
            this.formside.Size = new System.Drawing.Size(685, 729);
            this.formside.TabIndex = 1;
            // 
            // picEyeOpen
            // 
            this.picEyeOpen.BackColor = System.Drawing.Color.White;
            this.picEyeOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEyeOpen.Image = ((System.Drawing.Image)(resources.GetObject("picEyeOpen.Image")));
            this.picEyeOpen.InitialImage = null;
            this.picEyeOpen.Location = new System.Drawing.Point(576, 348);
            this.picEyeOpen.Name = "picEyeOpen";
            this.picEyeOpen.Size = new System.Drawing.Size(40, 40);
            this.picEyeOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeOpen.TabIndex = 80;
            this.picEyeOpen.TabStop = false;
            this.picEyeOpen.Click += new System.EventHandler(this.picEyeOpen_Click);
            // 
            // picEyeClosed
            // 
            this.picEyeClosed.BackColor = System.Drawing.Color.White;
            this.picEyeClosed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEyeClosed.ErrorImage = null;
            this.picEyeClosed.Image = ((System.Drawing.Image)(resources.GetObject("picEyeClosed.Image")));
            this.picEyeClosed.Location = new System.Drawing.Point(576, 348);
            this.picEyeClosed.Name = "picEyeClosed";
            this.picEyeClosed.Size = new System.Drawing.Size(40, 40);
            this.picEyeClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeClosed.TabIndex = 79;
            this.picEyeClosed.TabStop = false;
            this.picEyeClosed.Click += new System.EventHandler(this.picEyeClosed_Click);
            // 
            // lbDieuKhoan
            // 
            this.lbDieuKhoan.AutoSize = true;
            this.lbDieuKhoan.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbDieuKhoan.ForeColor = System.Drawing.Color.Maroon;
            this.lbDieuKhoan.Location = new System.Drawing.Point(3, 673);
            this.lbDieuKhoan.Name = "lbDieuKhoan";
            this.lbDieuKhoan.Size = new System.Drawing.Size(552, 32);
            this.lbDieuKhoan.TabIndex = 78;
            this.lbDieuKhoan.Text = "Bạn chấp nhận các điều khoản của chúng tôi";
            this.lbDieuKhoan.Click += new System.EventHandler(this.lbDieuKhoan_Click);
            // 
            // tgAgree
            // 
            this.tgAgree.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tgAgree.CheckedState.BorderThickness = 2;
            this.tgAgree.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tgAgree.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tgAgree.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tgAgree.Location = new System.Drawing.Point(576, 673);
            this.tgAgree.Name = "tgAgree";
            this.tgAgree.Size = new System.Drawing.Size(61, 32);
            this.tgAgree.TabIndex = 77;
            this.tgAgree.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.tgAgree.UncheckedState.FillColor = System.Drawing.Color.White;
            this.tgAgree.UncheckedState.InnerBorderColor = System.Drawing.Color.Gray;
            this.tgAgree.UncheckedState.InnerColor = System.Drawing.Color.DarkGray;
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 18;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.GreenYellow;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Gray;
            this.btnClear.Location = new System.Drawing.Point(117, 480);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 67);
            this.btnClear.TabIndex = 72;
            this.btnClear.Text = "Xóa";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 18;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.GreenYellow;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogin.Location = new System.Drawing.Point(375, 480);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 67);
            this.btnLogin.TabIndex = 71;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 18;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPassword.IconLeft")));
            this.txtPassword.IconRightOffset = new System.Drawing.Point(15, 1);
            this.txtPassword.Location = new System.Drawing.Point(303, 337);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Nhập mật khẩu";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(334, 60);
            this.txtPassword.TabIndex = 70;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 18;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtUsername.IconLeft")));
            this.txtUsername.Location = new System.Drawing.Point(303, 243);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "Nhập tên đăng nhập";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(334, 60);
            this.txtUsername.TabIndex = 69;
            // 
            // lbMinimize
            // 
            this.lbMinimize.AutoSize = true;
            this.lbMinimize.BackColor = System.Drawing.Color.Cyan;
            this.lbMinimize.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinimize.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbMinimize.Location = new System.Drawing.Point(579, 11);
            this.lbMinimize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMinimize.Name = "lbMinimize";
            this.lbMinimize.Size = new System.Drawing.Size(31, 46);
            this.lbMinimize.TabIndex = 66;
            this.lbMinimize.Text = "-";
            this.lbMinimize.Click += new System.EventHandler(this.lbMinimize_Click);
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Cyan;
            this.lbExit.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.Red;
            this.lbExit.Location = new System.Drawing.Point(631, 11);
            this.lbExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(45, 46);
            this.lbExit.TabIndex = 64;
            this.lbExit.Text = "x";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(623, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 45);
            this.panel2.TabIndex = 65;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(567, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(52, 45);
            this.panel3.TabIndex = 67;
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.AutoSize = true;
            this.lbForgotPassword.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgotPassword.ForeColor = System.Drawing.Color.Indigo;
            this.lbForgotPassword.Location = new System.Drawing.Point(466, 424);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(171, 27);
            this.lbForgotPassword.TabIndex = 8;
            this.lbForgotPassword.Text = "Quên mật khẩu?";
            this.lbForgotPassword.Click += new System.EventHandler(this.lbForgotPassword_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cyan;
            this.label5.Font = new System.Drawing.Font("Ravie", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(205, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 96);
            this.label5.TabIndex = 4;
            this.label5.Text = "LOGIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(39, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(39, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đăng nhập";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 726);
            this.Controls.Add(this.formside);
            this.Controls.Add(this.display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Login_Load);
            this.display.ResumeLayout(false);
            this.display.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.formside.ResumeLayout(false);
            this.formside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeClosed)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel formside;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Label lbForgotPassword;
        private Label lbMinimize;
        private Label lbExit;
        private Panel panel2;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tgAgree;
        private Label lbDieuKhoan;
        private PictureBox picEyeClosed;
        private PictureBox picEyeOpen;
    }
}