using Guna.UI2.WinForms;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ToggleSwitch_Agree.Checked) // Phải chấp nhận điều khoản mới login được
            {
                MainBoard mainb = new MainBoard();
                this.Hide();
                mainb.Show();
            }    
                
            else
                MessageBox.Show("Bạn chưa chấp nhận điều khoản.");
            

        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
             "🔒 Tính năng này hiện chưa đủ kinh phí để phát triển.\n\n" +
             "📞 Vui lòng liên hệ quản lý của bạn để lấy lại mật khẩu.",
             "Thông báo",
             MessageBoxButtons.OK,
             MessageBoxIcon.Warning
            );
        }

        private void pictureBox_Logo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
