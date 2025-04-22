using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bx.ALL_UserControl
{
    public partial class UC_Bill : UserControl
    {
        QLHD qlhd;
        public UC_Bill()
        {
            InitializeComponent();
            qlhd= new QLHD();
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
    }
}
