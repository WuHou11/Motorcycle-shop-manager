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
            uC_Account1.Visible = true;
            uC_Account1.BringToFront();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
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
    }
}
