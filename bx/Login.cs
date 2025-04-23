using System;
using System.Data;
using System.Windows.Forms;

namespace bx
{
    public partial class Login : Form
    {
        private Database db;
        QLTK qltk;
        public Login()
        {
            InitializeComponent();
            db = new Database();
            qltk=new QLTK();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tgAgree.Checked)
            {
                string taiKhoan = txtUsername.Text.Trim();
                string matKhau = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string query = $"SELECT * FROM QLTK WHERE TaiKhoan = '{taiKhoan}' AND MatKhau = '{matKhau}'";
                DataTable dt = db.Execute(query);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string chucVu = row["ChucVu"].ToString();
                        if (chucVu=="Nhan vien")
                        {
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new EmployeeBoard().ShowDialog();
                            this.Close();
                        }
                        else if (chucVu=="Quan ly")
                        {
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new MainBoard().ShowDialog();
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn không đồng ý với điều khoản của chúng tôi?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }
        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}