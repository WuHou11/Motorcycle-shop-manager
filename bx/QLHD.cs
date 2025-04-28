using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bx
{
    internal class QLHD
    {
        Database db;
        SqlConnection sqlConn;
        public QLHD()
        {
            sqlConn = new SqlConnection("Data Source=MSI\\TRIEUHIEU; Initial Catalog= QLCHXM; User ID= sa; Password=trieuphuchieu; MultipleActiveResultSets=True; TrustServerCertificate=True;");
            db = new Database();
        }
        public DataTable LayDSHoaDon()
        {
            string query = "SELECT * FROM QLHD";
            return db.Execute(query);
        }
        public void ThemHD(string MaHD, DateTime NgayLap, string MaKH, string TenKH, string GioiTinh, string CCCD, string DiaChi, string SoDT,
                       string MaXe, string TenXe, string LoaiXe, string DungTich, string HangSanXuat, string MauSac, decimal GiaBan, int SoLuong, string DonViTinh, string MaNV)
        {
            string query = @"INSERT INTO QLHD(MaHD, NgayLap, MaKH, TenKH, GioiTinh, CCCD, DiaChi, SoDT, MaXe, TenXe, LoaiXe, DungTich, HangSanXuat, MauSac, GiaBan, SoLuong, DonViTinh, MaNV)
                     VALUES (@MaHD, @NgayLap, @MaKH, @TenKH, @GioiTinh, @CCCD, @DiaChi, @SoDT, @MaXe, @TenXe, @LoaiXe, @DungTich, @HangSanXuat, @MauSac, @GiaBan, @SoLuong, @DonViTinh, @MaNV)";

            SqlCommand command = new SqlCommand(query, sqlConn);
            command.Parameters.AddWithValue("@MaHD", MaHD);
            command.Parameters.AddWithValue("@NgayLap", NgayLap);
            command.Parameters.AddWithValue("@MaKH", MaKH);
            command.Parameters.AddWithValue("@TenKH", TenKH);
            command.Parameters.AddWithValue("@GioiTinh", GioiTinh);
            command.Parameters.AddWithValue("@CCCD", CCCD);
            command.Parameters.AddWithValue("@DiaChi", DiaChi);
            command.Parameters.AddWithValue("@SoDT", SoDT);
            command.Parameters.AddWithValue("@MaXe", MaXe);
            command.Parameters.AddWithValue("@TenXe", TenXe);
            command.Parameters.AddWithValue("@LoaiXe", LoaiXe);
            command.Parameters.AddWithValue("@DungTich", DungTich);
            command.Parameters.AddWithValue("@HangSanXuat", HangSanXuat);
            command.Parameters.AddWithValue("@MauSac", MauSac);
            command.Parameters.AddWithValue("@GiaBan", GiaBan);
            command.Parameters.AddWithValue("@SoLuong", SoLuong);
            command.Parameters.AddWithValue("@DonViTinh", DonViTinh);
            command.Parameters.AddWithValue("@MaNV", MaNV);

            db.ExecuteNonQuery(command);
        }
        public void SuaHoaDon(string MaHD, DateTime NgayLap, string MaKH, string TenKH, string GioiTinh, string CCCD, string DiaChi, string SoDT,
                          string MaXe, string TenXe, string LoaiXe, string DungTich, string HangSanXuat, string MauSac,
                          decimal GiaBan, int SoLuong, string DonViTinh, string MaNV)
            {
                string query = @"UPDATE QLHD SET NgayLap = @NgayLap, MaKH = @MaKH, TenKH = @TenKH, GioiTinh = @GioiTinh, CCCD = @CCCD, DiaChi = @DiaChi, SoDT = @SoDT,
                             MaXe = @MaXe, TenXe = @TenXe, LoaiXe = @LoaiXe, DungTich = @DungTich, HangSanXuat = @HangSanXuat, MauSac = @MauSac,
                             GiaBan = @GiaBan, SoLuong = @SoLuong, DonViTinh = @DonViTinh, MaNV=@MaNV WHERE MaHD = @MaHD";
                SqlCommand command = new SqlCommand(query, sqlConn);
                command.Parameters.AddWithValue("@MaHD", MaHD);
                command.Parameters.AddWithValue("@NgayLap", NgayLap);
                command.Parameters.AddWithValue("@MaKH", MaKH);
                command.Parameters.AddWithValue("@TenKH", TenKH);
                command.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                command.Parameters.AddWithValue("@CCCD", CCCD);
                command.Parameters.AddWithValue("@DiaChi", DiaChi);
                command.Parameters.AddWithValue("@SoDT", SoDT);
                command.Parameters.AddWithValue("@MaXe", MaXe);
                command.Parameters.AddWithValue("@TenXe", TenXe);
                command.Parameters.AddWithValue("@LoaiXe", LoaiXe);
                command.Parameters.AddWithValue("@DungTich", DungTich);
                command.Parameters.AddWithValue("@HangSanXuat", HangSanXuat);
                command.Parameters.AddWithValue("@MauSac", MauSac);
                command.Parameters.AddWithValue("@GiaBan", GiaBan);
                command.Parameters.AddWithValue("@SoLuong", SoLuong);
                command.Parameters.AddWithValue("@DonViTinh", DonViTinh);
                command.Parameters.AddWithValue("@MaNV", MaNV);
                
                db.ExecuteNonQuery(command);
            }
        
        public void XoaHD(string maHD)
        {
            string query = "DELETE FROM QLHD WHERE MaHD = @MaHD";
            SqlCommand command = new SqlCommand(query, sqlConn);
            command.Parameters.AddWithValue("@MaHD", maHD);
            db.ExecuteNonQuery(command);
        }


    }
}
