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
            qltk = new QLTK();

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
            //if (tgAgree.Checked)
            //{
            //    string taiKhoan = txtUsername.Text.Trim();
            //    string matKhau = txtPassword.Text.Trim();

            //    if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            //    {
            //        MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    string query = $"SELECT * FROM QLTK WHERE TaiKhoan = '{taiKhoan}' AND MatKhau = '{matKhau}'";
            //    DataTable dt = db.Execute(query);

            //    if (dt.Rows.Count > 0)
            //    {
            //        foreach (DataRow row in dt.Rows)
            //        {
            //            string chucVu = row["ChucVu"].ToString();
            //            if (chucVu=="Nhan vien")
            //            {
            //                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                this.Hide();
            //                new EmployeeBoard().ShowDialog();
            //                this.Close();
            //            }
            //            else if (chucVu=="Quan ly")
            //            {
            //                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                this.Hide();
            //                new MainBoard().ShowDialog();
            //                this.Close();
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Bạn không đồng ý với điều khoản của chúng tôi?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //}

            string taiKhoan = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text.Trim();

            // Kiểm tra tài khoản/mật khẩu trước
            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra điều khoản sau
            if (!tgAgree.Checked)
            {
                MessageBox.Show("Bạn không đồng ý với điều khoản của chúng tôi?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            // Nếu mọi thứ ok, thực hiện truy vấn đăng nhập
            string query = $"SELECT * FROM QLTK WHERE TaiKhoan = '{taiKhoan}' AND MatKhau = '{matKhau}'";
            DataTable dt = db.Execute(query);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string chucVu = row["ChucVu"].ToString();
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    if (chucVu == "Nhan vien")
                    {
                        new EmployeeBoard().ShowDialog();
                    }
                    else if (chucVu == "Quan ly")
                    {
                        new MainBoard().ShowDialog();
                    }

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void picEyeClosed_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            picEyeClosed.Visible = false;
            picEyeOpen.Visible = true;
        }
        private void picEyeOpen_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            picEyeOpen.Visible = false;
            picEyeClosed.Visible = true;
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.ShowDialog();
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            picEyeOpen.Visible = false;
            picEyeClosed.Visible = true;
        }

        private void lbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbDieuKhoan_Click(object sender, EventArgs e)
        {
            string dieuKhoan = "ĐIỀU KHOẢN SỬ DỤNG HỆ THỐNG (DÀNH CHO NHÂN VIÊN & QUẢN LÝ)\n\n" +
            "1. Chấp nhận điều khoản:\n" +
            "  - Khi đăng nhập và sử dụng hệ thống, bạn đồng ý tuân thủ tất cả điều khoản sử dụng.\n" +
            "2. Bảo mật tài khoản:\n" +
            "  - Không chia sẻ tài khoản và mật khẩu cho người khác.\n" +
            "  - Quản lý có trách nhiệm phân quyền phù hợp cho từng nhân viên.\n" +
            "3. Nhập và cập nhật dữ liệu:\n" +
            "  - Nhân viên cần nhập liệu chính xác về sản phẩm, khách hàng, hóa đơn...\n" +
            "  - Không chỉnh sửa/xóa dữ liệu nếu không có quyền hoặc lý do chính đáng.\n" +
            "4. Trách nhiệm sử dụng:\n" +
            "  - Chỉ sử dụng hệ thống vào mục đích công việc.\n" +
            "  - Nghiêm cấm truy xuất trái phép, phá hoại hoặc sao chép dữ liệu.\n" +
            "5. Quản lý bán hàng:\n" +
            "  - Kiểm tra thông tin sản phẩm, giá bán, khuyến mãi trước khi lập hóa đơn.\n" +
            "  - Mọi giao dịch phải được lưu trên hệ thống.\n" +
            "6. Quản lý kho:\n" +
            "  - Nhập – xuất hàng phải thực hiện trên hệ thống.\n" +
            "  - Kiểm kho định kỳ và báo cáo nếu có chênh lệch.\n" +
            "7. Báo cáo và thống kê:\n" +
            "  - Chỉ dùng báo cáo nội bộ, không chia sẻ ra bên ngoài khi chưa được phép.\n" +
            "8. Xử lý vi phạm:\n" +
            "  - Các hành vi làm sai lệch dữ liệu hoặc vi phạm bảo mật sẽ bị xử lý theo quy định.\n" +
            "9. Thay đổi điều khoản:\n" +
            "  - Điều khoản có thể được cập nhật để phù hợp thực tế. Nhân viên có trách nhiệm theo dõi.\n\n" +

            "Vui lòng liên hệ quản lý cửa hàng nếu bạn cần thêm thông tin.";

            MessageBox.Show(dieuKhoan, "Điều khoản sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}