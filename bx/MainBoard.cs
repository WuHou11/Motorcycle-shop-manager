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
    public partial class MainBoard : Form
    {
        public MainBoard()
        {
            InitializeComponent();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(btnAccount);
            uC_Account1.Visible = true;
            uC_Account1.BringToFront();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            ActivateButton(btnRevenue);
            uC_Revenue1.Visible = true;
            uC_Revenue1.BringToFront();
        }

        private void MainBoard_Load(object sender, EventArgs e)
        {
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(btnProduct);
            uC_Product1.Visible = true;
            uC_Product1.BringToFront();
        }

        private void btnSuppiler_Click(object sender, EventArgs e)
        {
            ActivateButton(btnSuppiler);
            uC_Supplier1.Visible = true;
            uC_Supplier1.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(btnCustomer);
            uC_Customer1.Visible = true;
            uC_Customer1.BringToFront();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            ActivateButton(btnBill);   
            uC_Bill1.Visible = true;
            uC_Bill1.BringToFront();
        }
        private void ActivateButton(Button activeButton)
        {
            // Đặt màu mặc định cho tất cả các nút
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.Black; // Màu nền mặc định
                    btn.ForeColor = Color.White; // Màu chữ mặc định
                }
            }

            // Đổi màu cho nút được chọn
            activeButton.BackColor = Color.RoyalBlue;
            activeButton.ForeColor = Color.Black;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login Formout = new Login();
            Formout.Show();
            this.Hide();
        }
    }
}
