using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace bx.ALL_UserControl
{
    public partial class UC_Revenue : UserControl
    {
        QLThongKe qltk;

        public UC_Revenue()
        {
            InitializeComponent();
            qltk = new QLThongKe();
        }


        private void btnExcel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            // Define columns based on DataGridView structure
            DataColumn col1 = new DataColumn("MaThongKe");
            DataColumn col2 = new DataColumn("MaHD");
            DataColumn col3 = new DataColumn("NgayLap");
            DataColumn col4 = new DataColumn("MaXe");
            DataColumn col5 = new DataColumn("TenXe");
            DataColumn col6 = new DataColumn("SoLuongBan");
            DataColumn col7 = new DataColumn("GiaBan");
            DataColumn col8 = new DataColumn("ThanhTien");
            DataColumn col9 = new DataColumn("GiaNhap");
            DataColumn col10 = new DataColumn("LoiNhuan");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);
            dataTable.Columns.Add(col9);
            dataTable.Columns.Add(col10);

            // Populate DataTable from DataGridView
            foreach (DataGridViewRow dtgvRow in dgvThongKe.Rows)
            {
                if (dtgvRow.IsNewRow) continue; // Skip the new row placeholder
                DataRow drow = dataTable.NewRow();

                drow["MaThongKe"] = dtgvRow.Cells["MaThongKe"].Value?.ToString() ?? "";
                drow["MaHD"] = dtgvRow.Cells["MaHD"].Value?.ToString() ?? "";
                drow["NgayLap"] = dtgvRow.Cells["NgayLap"].Value?.ToString() ?? "";
                drow["MaXe"] = dtgvRow.Cells["MaXe"].Value?.ToString() ?? "";
                drow["TenXe"] = dtgvRow.Cells["TenXe"].Value?.ToString() ?? "";
                drow["SoLuongBan"] = dtgvRow.Cells["SoLuongBan"].Value?.ToString() ?? "";
                drow["GiaBan"] = dtgvRow.Cells["GiaBan"].Value?.ToString() ?? "";
                drow["ThanhTien"] = dtgvRow.Cells["ThanhTien"].Value?.ToString() ?? "";
                drow["GiaNhap"] = dtgvRow.Cells["GiaNhap"].Value?.ToString() ?? "";
                drow["LoiNhuan"] = dtgvRow.Cells["LoiNhuan"].Value?.ToString() ?? "";

                dataTable.Rows.Add(drow);
            }

            ExportFile(dataTable, "Revenue", "Doanh Thu");

        }
        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            // Create Excel objects
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            // Create new Excel Workbook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = oBooks.Add(Type.Missing);
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            // Create Title
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "J1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = 20;
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Create Column Headers
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã thống kê";
            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Mã hợp đồng";
            cl2.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Ngày lập";
            cl3.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Mã xe";
            cl4.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Tên xe";
            cl5.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Số lượng bán";
            cl6.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Giá bán";
            cl7.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            cl8.Value2 = "Tổng thu";
            cl8.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            cl9.Value2 = "Tổng chi";
            cl9.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");
            cl10.Value2 = "Lợi nhuận";
            cl10.ColumnWidth = 15;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "J3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Create array from DataTable
            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            // Set data range
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 1;
            int columnEnd = dataTable.Columns.Count;

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            // Fill data into range
            range.Value2 = arr;
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            range.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Format numeric columns
            Microsoft.Office.Interop.Excel.Range giaBanRange = oSheet.get_Range("G4", $"G{rowEnd}");
            giaBanRange.NumberFormat = "#,##0.00";
            Microsoft.Office.Interop.Excel.Range thanhTienRange = oSheet.get_Range("H4", $"H{rowEnd}");
            thanhTienRange.NumberFormat = "#,##0.00";
            Microsoft.Office.Interop.Excel.Range giaNhapRange = oSheet.get_Range("I4", $"I{rowEnd}");
            giaNhapRange.NumberFormat = "#,##0.00";
            Microsoft.Office.Interop.Excel.Range loiNhuanRange = oSheet.get_Range("J4", $"J{rowEnd}");
            loiNhuanRange.NumberFormat = "#,##0.00";
        }
        //public void ExportFile(DataTable dataTable, string sheetName, string title) // title là tên tiêu đề(doanh thu)
        //{
        //    //Tạo các đối tượng Excel

        //    Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

        //    Microsoft.Office.Interop.Excel.Workbooks oBooks;

        //    Microsoft.Office.Interop.Excel.Sheets oSheets;

        //    Microsoft.Office.Interop.Excel.Workbook oBook;

        //    Microsoft.Office.Interop.Excel.Worksheet oSheet;

        //    //Tạo mới một Excel WorkBook 

        //    oExcel.Visible = true;

        //    oExcel.DisplayAlerts = false;

        //    oExcel.Application.SheetsInNewWorkbook = 1;

        //    oBooks = oExcel.Workbooks;

        //    oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

        //    oSheets = oBook.Worksheets;

        //    oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

        //    oSheet.Name = sheetName;

        //    // Tạo phần Tiêu đề
        //    Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

        //    head.MergeCells = true;

        //    head.Value2 = title;

        //    head.Font.Bold = true;

        //    head.Font.Name = "Times New Roman";

        //    head.Font.Size = "20";

        //    head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

        //    // Tạo tiêu đề cột 

        //    Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

        //    cl1.Value2 = "Mã hóa đơn";

        //    cl1.ColumnWidth = 12;

        //    Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

        //    cl2.Value2 = "Ngày lập hóa đơn";

        //    cl2.ColumnWidth = 15.0;

        //    Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

        //    cl3.Value2 = "Tên khách hàng";
        //    cl3.ColumnWidth = 12.0;

        //    Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

        //    cl4.Value2 = "Tên nhân viên lập hóa đơn";

        //    cl4.ColumnWidth = 20.5;

        //    Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

        //    cl5.Value2 = "Tên sản phẩm";

        //    cl5.ColumnWidth = 13.5;

        //    Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

        //    cl6.Value2 = "Số lượng";

        //    cl6.ColumnWidth = 13.5;

        //    Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

        //    cl7.Value2 = "Đơn giá";

        //    cl7.ColumnWidth = 13.5;

        //    Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

        //    cl7.Value2 = "Thành tiền";

        //    cl7.ColumnWidth = 13.5;


        //    Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

        //    rowHead.Font.Bold = true;

        //    // Kẻ viền

        //    rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

        //    // Thiết lập màu nền

        //    rowHead.Interior.ColorIndex = 6;

        //    rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

        //    // Tạo mảng theo datatable

        //    object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

        //    //Chuyển dữ liệu từ DataTable vào mảng đối tượng

        //    for (int row = 0; row < dataTable.Rows.Count; row++)
        //    {
        //        DataRow dataRow = dataTable.Rows[row];

        //        for (int col = 0; col < dataTable.Columns.Count; col++)
        //        {
        //            arr[row, col] = dataRow[col];
        //        }
        //    }

        //    //Thiết lập vùng điền dữ liệu

        //    int rowStart = 4;

        //    int columnStart = 1;

        //    int rowEnd = rowStart + dataTable.Rows.Count - 2;

        //    int columnEnd = dataTable.Columns.Count;

        //    // Ô bắt đầu điền dữ liệu

        //    Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

        //    // Ô kết thúc điền dữ liệu

        //    Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

        //    // Lấy về vùng điền dữ liệu

        //    Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

        //    //Điền dữ liệu vào vùng đã thiết lập

        //    range.Value2 = arr;

        //    // Kẻ viền

        //    range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

        //    // Căn giữa 

        //    //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

        //    //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

        //    //Căn giữa cả bảng 
        //    oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        //}

        private void UC_Revenue_Load(object sender, EventArgs e)
        {
            HienDanhSachThongKe();
            txtTongThu.Text = "0 VNĐ";
            txtTongChi.Text = "0 VNĐ";
            txtLoiNhuan.Text = "0 VNĐ";
            txtTongThu.Visible = true;
            txtTongChi.Visible = true;
            txtLoiNhuan.Visible = true;

        }
        private void HienDanhSachThongKe()
        {
            try
            {

                DataTable dt = qltk.LayDSThongke();
                dgvThongKe.DataSource = dt;

                
                CustomizeDataGridView();

                // Tính tổng và hiển thị 
                decimal totalTongThu = 0;
                decimal totalTongChi = 0;
                foreach (DataGridViewRow row in dgvThongKe.Rows)
                {
                    if (row.IsNewRow) continue; 
                    if (row.Cells["ThanhTien"].Value != null && decimal.TryParse(row.Cells["ThanhTien"].Value.ToString(), out decimal thanhTien))
                        totalTongThu += thanhTien;
                    if (row.Cells["GiaNhap"].Value != null && decimal.TryParse(row.Cells["GiaNhap"].Value.ToString(), out decimal giaNhap))
                        totalTongChi += giaNhap;
                }
                decimal totalLoiNhuan = totalTongThu - totalTongChi;

                txtTongThu.Text = totalTongThu.ToString("#,##0 VNĐ");
                txtTongChi.Text = totalTongChi.ToString("#,##0 VNĐ");
                txtLoiNhuan.Text = totalLoiNhuan.ToString("#,##0 VNĐ");

              
                txtTongThu.Visible = true;
                txtTongChi.Visible = true;
                txtLoiNhuan.Visible = true;

                // Cập nhật biểu đồ chart_DoanhThu
                chart_DoanhThu.Series.Clear();
                chart_DoanhThu.ChartAreas.Clear();

                ChartArea chartArea = new ChartArea();
                chartArea.AxisX.Title = "Thời gian";
                chartArea.AxisY.Title = "Giá trị (VNĐ)";
                chart_DoanhThu.ChartAreas.Add(chartArea);

                Series seriesTongThu = new Series("Tổng thu") { ChartType = SeriesChartType.Column, Color = Color.Blue };
                Series seriesTongChi = new Series("Tổng chi") { ChartType = SeriesChartType.Column, Color = Color.Red };
                Series seriesLoiNhuan = new Series("Lợi nhuận") { ChartType = SeriesChartType.Column, Color = Color.Green };

                chart_DoanhThu.Series.Add(seriesTongThu);
                chart_DoanhThu.Series.Add(seriesTongChi);
                chart_DoanhThu.Series.Add(seriesLoiNhuan);

                // Tính tổng theo ngày để vẽ biểu đồ
                var groupedData = dt.AsEnumerable()
                    .GroupBy(row => Convert.ToDateTime(row["NgayLap"]))
                    .Select(g => new
                    {
                        NgayLap = g.Key,
                        TongThu = g.Sum(row => Convert.ToDecimal(row["ThanhTien"])),
                        TongChi = g.Sum(row => Convert.ToDecimal(row["GiaNhap"])),
                        LoiNhuan = g.Sum(row => Convert.ToDecimal(row["LoiNhuan"]))
                    })
                    .OrderBy(x => x.NgayLap);

                foreach (var item in groupedData)
                {
                    seriesTongThu.Points.AddXY(item.NgayLap.ToString("dd/MM/yyyy"), item.TongThu);
                    seriesTongChi.Points.AddXY(item.NgayLap.ToString("dd/MM/yyyy"), item.TongChi);
                    seriesLoiNhuan.Points.AddXY(item.NgayLap.ToString("dd/MM/yyyy"), item.LoiNhuan);
                }

                chart_DoanhThu.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị danh sách thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CustomizeDataGridView()
        {
           
            dgvThongKe.EnableHeadersVisualStyles = false;

            // Tùy chỉnh tiêu đề cột
            dgvThongKe.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
            dgvThongKe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvThongKe.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvThongKe.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

     
            dgvThongKe.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvThongKe.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

           
            if (dgvThongKe.Columns.Contains("GiaBan"))
                dgvThongKe.Columns["GiaBan"].DefaultCellStyle.Format = "#,##0.00";
            if (dgvThongKe.Columns.Contains("ThanhTien"))
                dgvThongKe.Columns["ThanhTien"].DefaultCellStyle.Format = "#,##0.00";
            if (dgvThongKe.Columns.Contains("GiaNhap"))
                dgvThongKe.Columns["GiaNhap"].DefaultCellStyle.Format = "#,##0.00";
            if (dgvThongKe.Columns.Contains("LoiNhuan"))
                dgvThongKe.Columns["LoiNhuan"].DefaultCellStyle.Format = "#,##0.00";

            // Tùy chỉnh tiêu đề cột
            if (dgvThongKe.Columns.Contains("MaThongKe"))
                dgvThongKe.Columns["MaThongKe"].HeaderText = "Mã thống kê";
            if (dgvThongKe.Columns.Contains("MaHD"))
                dgvThongKe.Columns["MaHD"].HeaderText = "Mã hợp đồng";
            if (dgvThongKe.Columns.Contains("NgayLap"))
                dgvThongKe.Columns["NgayLap"].HeaderText = "Ngày lập";
            if (dgvThongKe.Columns.Contains("MaXe"))
                dgvThongKe.Columns["MaXe"].HeaderText = "Mã xe";
            if (dgvThongKe.Columns.Contains("TenXe"))
                dgvThongKe.Columns["TenXe"].HeaderText = "Tên xe";
            if (dgvThongKe.Columns.Contains("SoLuongBan"))
                dgvThongKe.Columns["SoLuongBan"].HeaderText = "Số lượng bán";
            if (dgvThongKe.Columns.Contains("GiaBan"))
                dgvThongKe.Columns["GiaBan"].HeaderText = "Giá Bán";
            if (dgvThongKe.Columns.Contains("ThanhTien"))
                dgvThongKe.Columns["ThanhTien"].HeaderText = "Tổng thu";
            if (dgvThongKe.Columns.Contains("GiaNhap"))
                dgvThongKe.Columns["GiaNhap"].HeaderText = "Tổng chi";
            if (dgvThongKe.Columns.Contains("LoiNhuan"))
                dgvThongKe.Columns["LoiNhuan"].HeaderText = "Lợi Nhuận";

            

            
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
               
                DateTime startDate = dtStart.Value.Date;
                DateTime endDate = dtEnd.Value.Date;

                // Kiểm tra ngày hợp lệ
                if (startDate > endDate)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              
                DataTable dt = qltk.LayDSThongkeTheoNgay(startDate, endDate);

                if (dt == null)
                {
                    MessageBox.Show("Không thể lấy dữ liệu thống kê. Vui lòng kiểm tra kết nối cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gán DataTable trực tiếp vào DataSource của DataGridView
                dgvThongKe.DataSource = dt;

                // Kiểm tra nếu DataTable rỗng
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show($"Không có dữ liệu thống kê từ {startDate.ToString("dd/MM/yyyy")} đến {endDate.ToString("dd/MM/yyyy")}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Xóa biểu đồ nếu không có dữ liệu
                    chart_DoanhThu.Series.Clear();
                    chart_DoanhThu.ChartAreas.Clear();
                    txtTongThu.Text = "0 VNĐ";
                    txtTongChi.Text = "0 VNĐ";
                    txtLoiNhuan.Text = "0 VNĐ";
                    txtTongThu.Visible = true;
                    txtTongChi.Visible = true;
                    txtLoiNhuan.Visible = true;
                    return;
                }

               
                CustomizeDataGridView();

               
                decimal totalTongThu = 0;
                decimal totalTongChi = 0;
                foreach (DataGridViewRow row in dgvThongKe.Rows)
                {
                    if (row.IsNewRow) continue; 
                    if (row.Cells["ThanhTien"].Value != null && decimal.TryParse(row.Cells["ThanhTien"].Value.ToString(), out decimal thanhTien))
                        totalTongThu += thanhTien;
                    if (row.Cells["GiaNhap"].Value != null && decimal.TryParse(row.Cells["GiaNhap"].Value.ToString(), out decimal giaNhap))
                        totalTongChi += giaNhap;
                }
                decimal totalLoiNhuan = totalTongThu - totalTongChi;

                txtTongThu.Text = totalTongThu.ToString("#,##0 VNĐ");
                txtTongChi.Text = totalTongChi.ToString("#,##0 VNĐ");
                txtLoiNhuan.Text = totalLoiNhuan.ToString("#,##0 VNĐ");

               
                txtTongThu.Visible = true;
                txtTongChi.Visible = true;
                txtLoiNhuan.Visible = true;

                // Cập nhật biểu đồ chart_DoanhThu
                chart_DoanhThu.Series.Clear();
                chart_DoanhThu.ChartAreas.Clear();

                ChartArea chartArea = new ChartArea();
                chartArea.AxisX.Title = "Thời gian";
                chartArea.AxisY.Title = "Giá trị (VNĐ)";
                chart_DoanhThu.ChartAreas.Add(chartArea);

                Series seriesTongThu = new Series("Tổng thu") { ChartType = SeriesChartType.Column, Color = Color.Blue };
                Series seriesTongChi = new Series("Tổng chi") { ChartType = SeriesChartType.Column, Color = Color.Red };
                Series seriesLoiNhuan = new Series("Lợi nhuận") { ChartType = SeriesChartType.Column, Color = Color.Green };

                chart_DoanhThu.Series.Add(seriesTongThu);
                chart_DoanhThu.Series.Add(seriesTongChi);
                chart_DoanhThu.Series.Add(seriesLoiNhuan);

                var groupedData = dt.AsEnumerable()
                    .GroupBy(row => Convert.ToDateTime(row["NgayLap"]))
                    .Select(g => new
                    {
                        NgayLap = g.Key,
                        TongThu = g.Sum(row => Convert.ToDecimal(row["ThanhTien"])),
                        TongChi = g.Sum(row => Convert.ToDecimal(row["GiaNhap"])),
                        LoiNhuan = g.Sum(row => Convert.ToDecimal(row["LoiNhuan"]))
                    })
                    .OrderBy(x => x.NgayLap);

                foreach (var item in groupedData)
                {
                    seriesTongThu.Points.AddXY(item.NgayLap.ToString("dd/MM/yyyy"), item.TongThu);
                    seriesTongChi.Points.AddXY(item.NgayLap.ToString("dd/MM/yyyy"), item.TongChi);
                    seriesLoiNhuan.Points.AddXY(item.NgayLap.ToString("dd/MM/yyyy"), item.LoiNhuan);
                }

                chart_DoanhThu.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienDanhSachThongKe();
            txtLoiNhuan.Clear();
            txtTongChi.Clear();
            txtTongThu.Clear();    
        }

        private void dgvThongKe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThongKe.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvThongKe.SelectedRows[0];

                decimal thanhTien = row.Cells["ThanhTien"].Value != null ? Convert.ToDecimal(row.Cells["ThanhTien"].Value) : 0;
                decimal giaNhap = row.Cells["GiaNhap"].Value != null ? Convert.ToDecimal(row.Cells["GiaNhap"].Value) : 0;
                decimal loiNhuan = row.Cells["LoiNhuan"].Value != null ? Convert.ToDecimal(row.Cells["LoiNhuan"].Value) : 0;

                txtTongThu.Text = thanhTien.ToString("#,##0 VNĐ");
                txtTongChi.Text = giaNhap.ToString("#,##0 VNĐ");
                txtLoiNhuan.Text = loiNhuan.ToString("#,##0 VNĐ");
            }

        }
    }
}
