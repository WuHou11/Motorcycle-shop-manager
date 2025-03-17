using bx.ALL_UserControl;
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
    public partial class EmployeeBoard : Form
    {
        private Timer moveTimer = new Timer();
        private int targetY;
        public EmployeeBoard()
        {
            InitializeComponent();
            moveTimer.Interval = 1; // 5ms mỗi lần tick
            moveTimer.Tick += moveTimer_Tick;
        }
        private void moveTimer_Tick(object sender, EventArgs e)
        {
            int speed = 5; // Điều chỉnh tốc độ di chuyển

            if (PanelMoving.Top < targetY)
            {
                PanelMoving.Top += speed;
                if (PanelMoving.Top > targetY) PanelMoving.Top = targetY; // Đảm bảo không vượt quá
            }
            else if (PanelMoving.Top > targetY)
            {
                PanelMoving.Top -= speed;
                if (PanelMoving.Top < targetY) PanelMoving.Top = targetY; // Đảm bảo không vượt quá
            }

            if (PanelMoving.Top == targetY)
            {
                moveTimer.Stop(); // Dừng timer khi đã đến vị trí
            }
        }
        private void MovePanel(Guna.UI2.WinForms.Guna2Button btn)
        {
            targetY = btn.Top;
            if (PanelMoving.Top != targetY) // Chỉ chạy nếu chưa ở đúng vị trí
            {
                moveTimer.Start();
            }
        }
        private void btnlog_out_MouseEnter(object sender, EventArgs e)
        {
            btnlog_out.ImageSize = new Size(60, 60);
        }

        private void btnlog_out_MouseLeave(object sender, EventArgs e)
        {
            btnlog_out.ImageSize = new Size(50, 50);
        }

        private void btnlog_out_Click(object sender, EventArgs e)
        {
            Login Formout = new Login();
            Formout.Show();
            this.Hide();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn không đủ quyền hạng để truy cập!",
                   "Cảnh báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            uC_Product1.BackColor = Color.DarkOrange;
            ActivateButton(btnProduct);
            MovePanel(btnProduct);
            uC_Product1.Visible = true;
            uC_Product1.BringToFront();
        }

        private void btnSuppiler_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn không đủ quyền hạng để truy cập!",
                   "Cảnh báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn không đủ quyền hạng để truy cập!",
                   "Cảnh báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);

        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            ActivateButton(btnSale);
            MovePanel(btnSale);
            uC_Sale1.Visible = true;
            uC_Sale1.BringToFront();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn không đủ quyền hạng để truy cập!",
                   "Cảnh báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);

        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn không đủ quyền hạng để truy cập!",
                   "Cảnh báo",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
        }
        private void ActivateButton(Guna2Button activeButton)
        {
            // Đặt màu mặc định cho tất cả các Guna2Button
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Guna2Button btn)
                {
                    btn.FillColor = Color.WhiteSmoke;   // Màu nền mặc định
                    btn.ForeColor = Color.DimGray;   // Màu chữ mặc định
                    btn.ImageSize = new Size(50, 50); // Đặt kích thước icon về bình thường
                }
            }

            // Đổi màu cho nút được chọn
            activeButton.FillColor = Color.DarkOrange;
            activeButton.ForeColor = Color.White;
            activeButton.ImageSize = new Size(55, 55); // Làm icon to hơn khi nút được chọn
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmployeeBoard_Load(object sender, EventArgs e)
        {
           
            uC_Product1.Visible = false;
            uC_Sale1.Visible = false;
            btnProduct.PerformClick();
        }
    }
}
