using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bx
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void picEyeClosed2_Click(object sender, EventArgs e)
        {
            txtRePassword.UseSystemPasswordChar = false; // hiện mật khẩu
            picEyeClosed2.Visible = false;
            picEyeOpen2.Visible = true;
        }

        private void picEyeClosed1_Click(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = false; // hiện mật khẩu
            picEyeClosed1.Visible = false;
            picEyeOpen1.Visible = true;
        }

        private void picEyeOpen1_Click(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = true; // ẩn mật khẩu
            picEyeOpen1.Visible = false;
            picEyeClosed1.Visible = true;
        }

        private void picEyeOpen2_Click(object sender, EventArgs e)
        {
            txtRePassword.UseSystemPasswordChar = true; // ẩn mật khẩu
            picEyeOpen2.Visible = false;
            picEyeClosed2.Visible = true;
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            Login Formout = new Login();
            Formout.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
