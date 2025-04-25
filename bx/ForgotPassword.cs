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
        private Database db;
        QLTK qltk;
        public ForgotPassword()
        {
            InitializeComponent();
            qltk = new QLTK();
            db= new Database();
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
            this.Hide();
            Login login = new Login();
            login.ShowDialog();  // Chặn luồng cho tới khi Login được đóng
            this.Show();         // Hiện lại form hiện tại nếu cần sau khi login đóng
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            txtRePassword.UseSystemPasswordChar = true; // ẩn mật khẩu
            picEyeOpen2.Visible = false;
            picEyeClosed2.Visible = true;


            txtNewPassword.UseSystemPasswordChar = true; // ẩn mật khẩu
            picEyeOpen1.Visible = false;
            picEyeClosed1.Visible = true;
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {

            string maNV = txtMaNV.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string taikhoan=txtUsername.Text.Trim();
            string email=txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(txtNewPassword.Text.Trim())|| string.IsNullOrEmpty(txtRePassword.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện truy vấn reset password
            string query = $"SELECT * FROM QLTK WHERE MaNV = '{maNV}'AND SDT='{sdt}' AND TaiKhoan='{taikhoan}'";
            DataTable dt = db.Execute(query);

            if (dt.Rows.Count > 0)
            {
                string passwordNew = txtNewPassword.Text.Trim();
                string rePasswordNew = txtRePassword.Text.Trim();
                if (passwordNew == rePasswordNew)
                {
                    foreach (DataRow row in dt.Rows)
                    {

                        if (passwordNew == rePasswordNew)
                        {
                            qltk.UpdatePass(maNV, passwordNew);
                            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login login = new Login();
                            login.ShowDialog();
                            this.Close();
                        }
                    }
                }
                 else
                {
                    MessageBox.Show("Mật khẩu mới và nhập lại không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show("Sai mã nhân viên hoặc số điện thoại hoặc tên đăng nhập!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
