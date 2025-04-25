using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bx
{
    internal class QLTK
    {
        Database db;
        SqlConnection sqlConn;
        public QLTK()
        {
            sqlConn = new SqlConnection("Data Source=MSI\\TRIEUHIEU; Initial Catalog= QLCHXM; User ID= sa; Password=trieuphuchieu; MultipleActiveResultSets=True; TrustServerCertificate=True;");
            db = new Database();
        }
        public DataTable LayDSTaiKhoan()
        {
            string query = "SELECT * FROM QLTK";
            return db.Execute(query);
        }
        public void ThemTK(string MaNV, string HoTen, int Tuoi, string GioiTinh, string Email, string SDT, string TaiKhoan, string MatKhau, string ChucVu)
        {
            string query = "INSERT INTO QLTK(MaNV, HoTen, Tuoi, GioiTinh, Email, SDT, TaiKhoan, MatKhau, ChucVu) VALUES (@MaNV, @HoTen, @Tuoi, @GioiTinh, @Email, @SDT, @TaiKhoan, @MatKhau, @ChucVu)";
            SqlCommand command = new SqlCommand(query, sqlConn);
            command.Parameters.AddWithValue("@MaNV", MaNV);
            command.Parameters.AddWithValue("@HoTen", HoTen);
            command.Parameters.AddWithValue("@Tuoi", Tuoi);
            command.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@SDT",SDT);
            command.Parameters.AddWithValue("@TaiKhoan", TaiKhoan);
            command.Parameters.AddWithValue("@MatKhau", MatKhau);
            command.Parameters.AddWithValue("@ChucVu", ChucVu);
            db.ExecuteNonQuery(command);
        }
        public void SuaTK(string MaNV, string HoTen, int Tuoi, string GioiTinh, string Email, string SDT, string TaiKhoan, string MatKhau, string ChucVu)
        {
            string query = "UPDATE QLTK SET HoTen=@HoTen, Tuoi=@Tuoi, GioiTinh=@GioiTinh, Email=@Email, SDT= @SDT, TaiKhoan=@TaiKhoan, MatKhau=@MatKhau, ChucVu=@ChucVu WHERE MaNV=@MaNV";
            SqlCommand command = new SqlCommand(query, sqlConn);
            command.Parameters.AddWithValue("@MaNV", MaNV);
            command.Parameters.AddWithValue("@HoTen", HoTen);
            command.Parameters.AddWithValue("@Tuoi", Tuoi);
            command.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@SDT", SDT);
            command.Parameters.AddWithValue("@TaiKhoan", TaiKhoan);
            command.Parameters.AddWithValue("@MatKhau", MatKhau);
            command.Parameters.AddWithValue("@ChucVu", ChucVu);
            db.ExecuteNonQuery(command);
        }
        public void XoaTK(string MaNV)
        {
            string query = "DELETE FROM QLTK WHERE MaNV=@MaNV";
            SqlCommand command = new SqlCommand(query, sqlConn);
            command.Parameters.AddWithValue("@MaNV", MaNV);
            db.ExecuteNonQuery(command);
        }
        public void UpdatePass(string maNV, string matkhau)
        {
            string query = "UPDATE QLTK SET MatKhau=@MatKhau WHERE MaNV=@MaNV";
            SqlCommand command = new SqlCommand(query, sqlConn);
            command.Parameters.AddWithValue("@MaNV", maNV);
            command.Parameters.AddWithValue("@MatKhau", matkhau);
            db.ExecuteNonQuery(command);
        }
    }
}
