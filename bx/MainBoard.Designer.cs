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
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnSuppiler = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Revenue1 = new bx.ALL_UserControl.UC_Revenue();
            this.uC_Account1 = new bx.ALL_UserControl.UC_Account();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Black;
            this.btnCustomer.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.btnCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Location = new System.Drawing.Point(58, 498);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(226, 54);
            this.btnCustomer.TabIndex = 39;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.Maroon;
            this.btnAccount.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.btnAccount.ForeColor = System.Drawing.Color.Transparent;
            this.btnAccount.Location = new System.Drawing.Point(57, 211);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(226, 54);
            this.btnAccount.TabIndex = 38;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Black;
            this.btnProduct.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.btnProduct.ForeColor = System.Drawing.Color.Transparent;
            this.btnProduct.Location = new System.Drawing.Point(57, 303);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(226, 49);
            this.btnProduct.TabIndex = 37;
            this.btnProduct.Text = "Products";
            this.btnProduct.UseVisualStyleBackColor = false;
            // 
            // btnSuppiler
            // 
            this.btnSuppiler.BackColor = System.Drawing.Color.Black;
            this.btnSuppiler.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.btnSuppiler.ForeColor = System.Drawing.Color.Transparent;
            this.btnSuppiler.Location = new System.Drawing.Point(58, 398);
            this.btnSuppiler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuppiler.Name = "btnSuppiler";
            this.btnSuppiler.Size = new System.Drawing.Size(226, 52);
            this.btnSuppiler.TabIndex = 36;
            this.btnSuppiler.Text = "Supplier";
            this.btnSuppiler.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
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
            this.lbExit.ForeColor = System.Drawing.Color.Maroon;
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
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(58, 769);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(226, 54);
            this.button6.TabIndex = 66;
            this.button6.Text = "History";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.Black;
            this.btnBill.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.btnBill.ForeColor = System.Drawing.Color.Transparent;
            this.btnBill.Location = new System.Drawing.Point(58, 598);
            this.btnBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(226, 52);
            this.btnBill.TabIndex = 65;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = false;
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.Color.Black;
            this.btnRevenue.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold);
            this.btnRevenue.ForeColor = System.Drawing.Color.Transparent;
            this.btnRevenue.Location = new System.Drawing.Point(58, 682);
            this.btnRevenue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(226, 52);
            this.btnRevenue.TabIndex = 67;
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.UseVisualStyleBackColor = false;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_Revenue1);
            this.panel1.Controls.Add(this.uC_Account1);
            this.panel1.Location = new System.Drawing.Point(291, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 860);
            this.panel1.TabIndex = 68;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // uC_Revenue1
            // 
            this.uC_Revenue1.BackColor = System.Drawing.Color.Maroon;
            this.uC_Revenue1.Location = new System.Drawing.Point(3, 3);
            this.uC_Revenue1.Name = "uC_Revenue1";
            this.uC_Revenue1.Size = new System.Drawing.Size(1377, 845);
            this.uC_Revenue1.TabIndex = 1;
            // 
            // uC_Account1
            // 
            this.uC_Account1.BackColor = System.Drawing.Color.Maroon;
            this.uC_Account1.Location = new System.Drawing.Point(3, -15);
            this.uC_Account1.Name = "uC_Account1";
            this.uC_Account1.Size = new System.Drawing.Size(1364, 863);
            this.uC_Account1.TabIndex = 0;
            // 
            // MainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1670, 946);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.button6);
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private ALL_UserControl.UC_Account uC_Account1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private ALL_UserControl.UC_Revenue uC_Revenue1;
    }
}