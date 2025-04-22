using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bx
{
    internal class QLNCC
    {
        Database db;
        SqlConnection sqlConn;
        public QLNCC()
        {
            sqlConn = new SqlConnection("Data Source=MSI\\TRIEUHIEU; Initial Catalog= QLCHXM; User ID= sa; Password=trieuphuchieu; MultipleActiveResultSets=True; TrustServerCertificate=True;");
            db = new Database();
        }
        public DataTable LayDSNhaCungCap()
        {
            string query = "SELECT * FROM NhaCungCap";
            return db.Execute(query);
        }
        public void ThemNCC(string MaNCC, string TenNCC, string DiaChi, string Email, string SDT)
        {
            string query = "INSERT INTO NhaCungCap(MaNCC, TenNCC, DiaChi, Email, SDT) VALUES (@MaNCC, @TenNCC, @DiaChi, @Email, @SDT)";
            SqlCommand command = new SqlCommand(query, sqlConn);
            command.Parameters.AddWithValue("@MaNCC", MaNCC);
            command.Parameters.AddWithValue("@TenNCC", TenNCC);
            command.Parameters.AddWithValue("@DiaChi", DiaChi);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@SDT", SDT);
            db.ExecuteNonQuery(command);
        }
        public void SuaNCC(string MaNCC, string TenNCC, string DiaChi, string Email, string SDT)
        {
            string query = "UPDATE NhaCungCap SET TenNCC=@TenNCC, DiaChi=@DiaChi, Email=@Email, SDT=@SDT WHERE MaNCC=@MaNCC";
            SqlCommand command = new SqlCommand(query, sqlConn);
            command.Parameters.AddWithValue("@MaNCC", MaNCC);
            command.Parameters.AddWithValue("@TenNCC", TenNCC);
            command.Parameters.AddWithValue("@DiaChi", DiaChi);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@SDT", SDT);
            db.ExecuteNonQuery(command);
        }
        public void XoaNCC(string maNCC)
        {
            string query = "DELETE FROM NhaCungCap WHERE MaNCC=@MaNCC";
            SqlCommand command = new SqlCommand(query, sqlConn);
            command.Parameters.AddWithValue("@MaNCC", maNCC);
            db.ExecuteNonQuery(command);
        }

    }
}
