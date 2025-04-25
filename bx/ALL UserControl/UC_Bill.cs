using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.IO.Font.Constants;
using System.Drawing.Printing;

namespace bx.ALL_UserControl
{
    public partial class UC_Bill : UserControl
    {
        private Database db; 
        QLHD qlhd;
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        public UC_Bill()
        {
            InitializeComponent();
            qlhd= new QLHD();
            db = new Database(); 
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.Document = printDocument1;
        }
        private void ClearFields()
        {
            txtTimMaHD.Clear();
            txtTimMaKH.Clear();
            txtThanhTien.Clear();
        }
        private void UC_Bill_Load(object sender, EventArgs e)
        {
            HienDanhSachHoaDon();
            ClearFields();
        }
        private void HienDanhSachHoaDon()
        {
            try
            {
                if (dgvQLHD.Columns.Count == 0)
                {
                    dgvQLHD.Columns.Add("MaHD", "Mã Hóa Đơn");
                    dgvQLHD.Columns.Add("NgayLap", "Ngày Lập");
                    dgvQLHD.Columns.Add("MaKH", "Mã khách hàng");
                    dgvQLHD.Columns.Add("TenKH", "Tên Khách Hàng");
                    dgvQLHD.Columns.Add("GioiTinh", "Giới Tính");
                    dgvQLHD.Columns.Add("CCCD", "CCCD");
                    dgvQLHD.Columns.Add("DiaChi", "Địa Chỉ");
                    dgvQLHD.Columns.Add("SoDT", "Số Điện Thoại");
                    dgvQLHD.Columns.Add("MaXe", "Mã Xe");
                    dgvQLHD.Columns.Add("TenXe", "Tên Xe");
                    dgvQLHD.Columns.Add("LoaiXe", "Loại Xe");
                    dgvQLHD.Columns.Add("DungTich", "Dung Tích");
                    dgvQLHD.Columns.Add("HangSanXuat", "Hãng Sản Xuất");
                    dgvQLHD.Columns.Add("MauSac", "Màu Sắc");
                    dgvQLHD.Columns.Add("GiaBan", "Giá Bán");
                    dgvQLHD.Columns.Add("SoLuong", "Số Lượng");
                    dgvQLHD.Columns.Add("DonViTinh", "Đơn Vị Tính");
                    dgvQLHD.Columns.Add("ThanhTien", "Thành Tiền");
                    dgvQLHD.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
                DataTable dt = qlhd.LayDSHoaDon(); 
                dgvQLHD.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    DataGridViewRow dgvRow = new DataGridViewRow();
                    dgvRow.CreateCells(dgvQLHD);
                    dgvRow.Cells[dgvQLHD.Columns["MaHD"].Index].Value = row["MaHD"].ToString();
                    if (row["NgayLap"] != DBNull.Value)
                    {
                        dgvRow.Cells[dgvQLHD.Columns["NgayLap"].Index].Value = Convert.ToDateTime(row["NgayLap"]).ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        dgvRow.Cells[dgvQLHD.Columns["NgayLap"].Index].Value = string.Empty;
                    }
                    dgvRow.Cells[dgvQLHD.Columns["MaKH"].Index].Value = row["MaKH"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["TenKH"].Index].Value = row["TenKH"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["GioiTinh"].Index].Value = row["GioiTinh"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["CCCD"].Index].Value = row["CCCD"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["DiaChi"].Index].Value = row["DiaChi"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["SoDT"].Index].Value = row["SoDT"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["MaXe"].Index].Value = row["MaXe"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["TenXe"].Index].Value = row["TenXe"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["LoaiXe"].Index].Value = row["LoaiXe"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["DungTich"].Index].Value = row["DungTich"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["HangSanXuat"].Index].Value = row["HangSanXuat"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["MauSac"].Index].Value = row["MauSac"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["GiaBan"].Index].Value = row["GiaBan"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["SoLuong"].Index].Value = row["SoLuong"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["DonViTinh"].Index].Value = row["DonViTinh"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["ThanhTien"].Index].Value = row["ThanhTien"].ToString();

                    dgvQLHD.Rows.Add(dgvRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị danh sách hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTimMaHD.Text) && string.IsNullOrWhiteSpace(txtTimMaKH.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã hóa đơn hoặc Mã khách hàng để tìm kiếm!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    HienDanhSachHoaDon(); 
                    return;
                }
                string maHDTimKiem = txtTimMaHD.Text.Trim().ToUpper();
                string maKHTimKiem = txtTimMaKH.Text.Trim().ToUpper();
                bool timThay = false;
                dgvQLHD.Rows.Clear();
                DataTable dt = qlhd.LayDSHoaDon();
                foreach (DataRow row in dt.Rows)
                {
                    string maHD = row["MaHD"].ToString().Trim().ToUpper().Replace("\r", "").Replace("\n", "");
                    string maKH = row["MaKH"].ToString().Trim().ToUpper().Replace("\r", "").Replace("\n", "");
                    bool maHDMatch = string.IsNullOrWhiteSpace(maHDTimKiem) || maHD == maHDTimKiem;
                    bool maKHMatch = string.IsNullOrWhiteSpace(maKHTimKiem) || maKH == maKHTimKiem;

                    if (maHDMatch && maKHMatch)
                    {
                        timThay = true;
                        DataGridViewRow dgvRow = new DataGridViewRow();
                        dgvRow.CreateCells(dgvQLHD);
                        dgvRow.Cells[dgvQLHD.Columns["MaHD"].Index].Value = row["MaHD"].ToString();
                        dgvRow.Cells[dgvQLHD.Columns["NgayLap"].Index].Value = row["NgayLap"].ToString();
                        dgvRow.Cells[dgvQLHD.Columns["MaKH"].Index].Value = row["MaKH"].ToString();
                        dgvRow.Cells[dgvQLHD.Columns["TenKH"].Index].Value = row["TenKH"].ToString();
                        dgvRow.Cells[dgvQLHD.Columns["GioiTinh"].Index].Value = row["GioiTinh"].ToString();
                        dgvRow.Cells[dgvQLHD.Columns["CCCD"].Index].Value = row["CCCD"].ToString();
                        dgvRow.Cells[dgvQLHD.Columns["DiaChi"].Index].Value = row["DiaChi"].ToString();
                        dgvRow.Cells[dgvQLHD.Columns["SoDT"].Index].Value = row["SoDT"].ToString();
                        dgvRow.Cells[dgvQLHD.Columns["MaXe"].Index].Value = row["MaXe"].ToString();
                        dgvRow.Cells[dgvQLHD.Columns["TenXe"].Index].Value = row["TenXe"].ToString();
                        dgvRow.Cells[dgvQLHD.Columns["LoaiXe"].Index].Value = row["LoaiXe"].ToString();
                        dgvRow.Cells[dgvQLHD.Columns["DungTich"].Index].Value = row["DungTich"].ToString();
                        dgvRow.Cells[dgvQLHD.Columns["HangSanXuat"].Index].Value = row["HangSanXuat"].ToString();
                        dgvRow.Cells[dgvQLHD.Columns["MauSac"].Index].Value = row["MauSac"].ToString();
                        dgvRow.Cells[dgvQLHD.Columns["GiaBan"].Index].Value = row["GiaBan"].ToString();
                        dgvRow.Cells[dgvQLHD.Columns["SoLuong"].Index].Value = row["SoLuong"].ToString();
                        dgvRow.Cells[dgvQLHD.Columns["DonViTinh"].Index].Value = row["DonViTinh"].ToString();
                        dgvRow.Cells[dgvQLHD.Columns["ThanhTien"].Index].Value = row["ThanhTien"].ToString();

                        dgvQLHD.Rows.Add(dgvRow);
                    }
                }
                if (!timThay)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn với Mã hóa đơn hoặc Mã khách hàng đã nhập!", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienDanhSachHoaDon(); 
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HienDanhSachHoaDon(); 
                return;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienDanhSachHoaDon();
            ClearFields();
        }

        private void dgvQLHD_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLHD.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvQLHD.SelectedRows[0];
                    txtTimMaHD.Text = row.Cells["MaHD"].Value?.ToString().Trim() ?? "";
                    txtTimMaKH.Text = row.Cells["MaKH"].Value?.ToString().Trim() ?? "";
                    txtThanhTien.Text = row.Cells["ThanhTien"].Value?.ToString().Trim() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dgvQLHD.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để in!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected invoice ID (MaHD)
            string maHD = dgvQLHD.SelectedRows[0].Cells["MaHD"].Value?.ToString().Trim();
            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Mã hóa đơn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Query to fetch invoice data using Database class
                string query = "SELECT * FROM QLHD WHERE MaHD = @MaHD";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@MaHD", maHD);
                DataTable dt = db.Execute(query, cmd);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Store the invoice data for printing
                selectedInvoice = dt.Rows[0];

                // Show print preview and print if confirmed
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}\nChi tiết: {ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataRow selectedInvoice; // To store the selected invoice data for printing

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Header
            e.Graphics.DrawString("Motobikes Shop", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(50, 50));
            e.Graphics.DrawString(" HOTLINE: 039.79.86868", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, 80));
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(300, 100));

            // Customer Information
            int pt = 150;
            e.Graphics.DrawString($"Số: {selectedInvoice["MaHD"]}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(550, 50));
            e.Graphics.DrawString($"Ngày {Convert.ToDateTime(selectedInvoice["NgayLap"]).Day} tháng {Convert.ToDateTime(selectedInvoice["NgayLap"]).Month} năm {Convert.ToDateTime(selectedInvoice["NgayLap"]).Year}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(550, 65));
            e.Graphics.DrawString($"Khách hàng: {selectedInvoice["TenKH"]}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, pt));
            pt += 20;
            e.Graphics.DrawString($"Điện thoại: {selectedInvoice["SoDT"]}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, pt));
            pt += 20;
            e.Graphics.DrawString($"Địa chỉ: {selectedInvoice["DiaChi"]}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, pt));
            pt += 30;

            // Table Header
            e.Graphics.DrawString("STT", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, pt));
            e.Graphics.DrawString("Sản Phẩm", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(100, pt));
            e.Graphics.DrawString("DVT", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(420, pt));
            e.Graphics.DrawString("SL", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(470, pt));
            e.Graphics.DrawString("Đơn Giá", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(500, pt));
            e.Graphics.DrawString("Thành Tiền", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, pt));
            pt += 20;

            // Draw table border (top line)
            e.Graphics.DrawLine(Pens.Black, new Point(50, pt), new Point(700, pt));
            pt += 10;

            // Product Row (only one row as per your data structure)
            e.Graphics.DrawString("1", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(50, pt));
            string productDescription = $"{selectedInvoice["TenXe"]} {selectedInvoice["LoaiXe"]} {selectedInvoice["DungTich"]}cc {selectedInvoice["HangSanXuat"]} {selectedInvoice["MauSac"]}";
            e.Graphics.DrawString(productDescription, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(100, pt));
            e.Graphics.DrawString(selectedInvoice["DonViTinh"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(420, pt));
            e.Graphics.DrawString(selectedInvoice["SoLuong"].ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(470, pt));
            e.Graphics.DrawString(Convert.ToDecimal(selectedInvoice["GiaBan"]).ToString("N0"), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(500, pt));
            e.Graphics.DrawString(Convert.ToDecimal(selectedInvoice["ThanhTien"]).ToString("N0"), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(600, pt));
            pt += 20;

            // Draw table border (bottom line)
            e.Graphics.DrawLine(Pens.Black, new Point(50, pt), new Point(700, pt));
            pt += 30;

            // Total
            e.Graphics.DrawString($"Tổng cộng: {Convert.ToDecimal(selectedInvoice["ThanhTien"]).ToString("N0")} VND", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(500, pt));
            pt += 50;

            // Footer
            
            e.Graphics.DrawString("Người viết hóa đơn", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(600, pt));
            pt += 50;
            e.Graphics.DrawString("Cảm Ơn Quý Khách", new Font("Arial", 10, FontStyle.Italic), Brushes.Black, new Point(350, pt));
        }
    }
}
