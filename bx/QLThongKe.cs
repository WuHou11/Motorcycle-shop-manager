using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bx
{

   
    internal class QLThongKe
    {

        Database db;
        SqlConnection sqlConn;
        DataTable dt;
        public QLThongKe()
        {
            sqlConn = new SqlConnection("Data Source=MINH_NHUT;Initial Catalog=QLCHXM;User ID=sa;Password=28102005Zz@;TrustServerCertificate=True;");
            db = new Database();
        }
        public DataTable LayDSThongke()
        {
            string query = "SELECT * FROM ThongKe";
            return db.Execute(query);
        }
        public DataTable LayDSThongkeTheoNgay(DateTime startDate, DateTime endDate)
        {
            try
            {
                string query = "SELECT * FROM ThongKe WHERE NgayLap BETWEEN @StartDate AND @EndDate";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);
                return db.Execute(query, cmd) ?? new DataTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách thống kê theo ngày: " + ex.Message);
                return new DataTable(); // Trả về DataTable rỗng nếu có lỗi
            }
        }
    }
}
