using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bx
{
    internal class QLKH
    {
        Database db;
        SqlConnection sqlConn;
        public QLKH()
        {
            sqlConn = new SqlConnection("Data Source=MSI\\TRIEUHIEU; Initial Catalog= QLCHXM; User ID= sa; Password=trieuphuchieu; MultipleActiveResultSets=True; TrustServerCertificate=True;");
            db = new Database();
        }
        public DataTable LayDSKhachHang()
        {
            string query = "SELECT * FROM QLKH";
            return db.Execute(query);
        }
        public void ThemKH(string MaKH, string TenKH, string GioiTinh, string SoCCCD, string DiaChi, string DienThoai)
        {
            string query = "INSERT INTO QLKH(MaKH, TenKH, GioiTinh, SoCCCD, DiaChi, SoDT) VALUES (@MaKH, @TenKH, @GioiTinh, @SoCCCD, @DiaChi, @SoDT)";
            SqlCommand command = new SqlCommand(query, sqlConn);
            command.Parameters.AddWithValue("@MaKH", MaKH);
            command.Parameters.AddWithValue("@TenKH", TenKH);
            command.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            command.Parameters.AddWithValue("@SoCCCD", SoCCCD);
            command.Parameters.AddWithValue("@DiaChi", DiaChi);
            command.Parameters.AddWithValue("@SoDT", DienThoai);
            db.ExecuteNonQuery(command);
        }
        public void SuaKH(string MaKH, string TenKH, string GioiTinh, string SoCCCD, string DiaChi, string DienThoai)
        {
            string query = "UPDATE QLKH SET TenKH=@TenKH, GioiTinh=@GioiTinh, SoCCCD=@SoCCCD, DiaChi=@DiaChi, SoDT=@SoDT WHERE MaKH=@MaKH";
            SqlCommand command = new SqlCommand(query, sqlConn);
            command.Parameters.AddWithValue("@MaKH", MaKH);
            command.Parameters.AddWithValue("@TenKH", TenKH);
            command.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            command.Parameters.AddWithValue("@SoCCCD", SoCCCD);
            command.Parameters.AddWithValue("@DiaChi", DiaChi);
            command.Parameters.AddWithValue("@SoDT", DienThoai);
            db.ExecuteNonQuery(command);
        }
        public void XoaKH(string maKH)
        {
            string query = "DELETE FROM QLKH WHERE MaKH=@MaKH";
            SqlCommand command = new SqlCommand(query, sqlConn);
            command.Parameters.AddWithValue("@MaKH", maKH);
            db.ExecuteNonQuery(command);
        }
    }
}
