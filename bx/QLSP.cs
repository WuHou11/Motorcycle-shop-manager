using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bx
{
    internal class QLSP
    {
        Database db;
        SqlConnection sqlConn;
        public QLSP()
        {
            sqlConn = new SqlConnection("Data Source=MSI\\TRIEUHIEU; Initial Catalog= QLCHXM; User ID= sa; Password=trieuphuchieu; MultipleActiveResultSets=True; TrustServerCertificate=True;");
            db = new Database();
        }
        public DataTable LayDSSanPham()
        {
            string query = "SELECT * FROM SanPham";
            return db.Execute(query);
        }
        public void ThemSP(string MaXe, string TenXe, string LoaiXe, string DungTich, string HangSanXuat, string MauSac, decimal GiaNhap, decimal GiaBan, int SoLuong, string DonViTinh, string HinhAnh)
        {
            string query = "INSERT INTO SanPham(MaXe, TenXe, LoaiXe, DungTich, HangSanXuat, MauSac, GiaNhap, GiaBan, SoLuong, DonViTinh, HinhAnh) VALUES (@MaXe, @TenXe, @LoaiXe, @DungTich, @HangSanXuat, @MauSac, @GiaNhap, @GiaBan, @SoLuong, @DonViTinh, @HinhAnh)";
            SqlCommand command = new SqlCommand(query, sqlConn);
            command.Parameters.AddWithValue("@MaXe", MaXe);
            command.Parameters.AddWithValue("@TenXe", TenXe);
            command.Parameters.AddWithValue("@LoaiXe", LoaiXe);
            command.Parameters.AddWithValue("@DungTich", DungTich);
            command.Parameters.AddWithValue("@HangSanXuat", HangSanXuat);
            command.Parameters.AddWithValue("@MauSac", MauSac);
            command.Parameters.AddWithValue("@GiaNhap", GiaNhap);
            command.Parameters.AddWithValue("@GiaBan", GiaBan);
            command.Parameters.AddWithValue("@SoLuong", SoLuong);
            command.Parameters.AddWithValue("@DonViTinh", DonViTinh);
            command.Parameters.AddWithValue("@HinhAnh", HinhAnh);
            db.ExecuteNonQuery(command);
        }
        public void SuaSP(string MaXe, string TenXe, string LoaiXe, string DungTich, string HangSanXuat, string MauSac, decimal GiaNhap, decimal GiaBan, int SoLuong, string DonViTinh, string HinhAnh)
        {
            string query = "UPDATE SanPham SET TenXe=@TenXe, LoaiXe=@LoaiXe, DungTich=@DungTich, HangSanXuat=@HangSanXuat, MauSac=@MauSac, GiaNhap=@GiaNhap, GiaBan=@GiaBan, SoLuong=@SoLuong, DonViTinh=@DonViTinh, HinhAnh=@HinhAnh WHERE MaXe=@MaXe";
            SqlCommand command = new SqlCommand(query, sqlConn);
            command.Parameters.AddWithValue("@MaXe", MaXe);
            command.Parameters.AddWithValue("@TenXe", TenXe);
            command.Parameters.AddWithValue("@LoaiXe", LoaiXe);
            command.Parameters.AddWithValue("@DungTich", DungTich);
            command.Parameters.AddWithValue("@HangSanXuat", HangSanXuat);
            command.Parameters.AddWithValue("@MauSac", MauSac);
            command.Parameters.AddWithValue("@GiaNhap", GiaNhap);
            command.Parameters.AddWithValue("@GiaBan", GiaBan);
            command.Parameters.AddWithValue("@SoLuong", SoLuong);
            command.Parameters.AddWithValue("@DonViTinh", DonViTinh);
            command.Parameters.AddWithValue("@HinhAnh", HinhAnh);
            db.ExecuteNonQuery(command);
        }
        public void XoaSP(string maXe)
        {
            string query = "DELETE FROM SanPham WHERE MaXe=@MaXe";
            SqlCommand command = new SqlCommand(query, sqlConn);
            command.Parameters.AddWithValue("@MaXe", maXe);
            db.ExecuteNonQuery(command);
        }
    }
}
