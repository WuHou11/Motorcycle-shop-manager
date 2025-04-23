using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bx.ALL_UserControl
{
    public partial class UC_Product : UserControl
    {
        
        QLSP qlsp;
        public UC_Product()
        {
            InitializeComponent();
            qlsp = new QLSP();
        }

        
        private void UC_Product_Load(object sender, EventArgs e)
        {
            HienDanhSachXe();
            ClearFields();
        }
        private void ClearFields()
        {
            txtMaXe.Clear();
            txtTenXe.Clear();
            txtLoaiXe.Clear();
            txtDungTich.Clear();
            txtHangSanXuat.Clear();
            txtMauSac.Clear();
            txtGiaNhap.Clear();
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            txtDonViTinh.Clear();
            txtHinhAnh.Clear();
            ptbHinhSP.Image = null;
        }
        private void HienDanhSachXe()
        {
            try
            {
                if (dgvQLSP.Columns.Count == 0)
                {
                    dgvQLSP.Columns.Add("MaXe", "Mã Xe");
                    dgvQLSP.Columns.Add("TenXe", "Tên Xe");
                    dgvQLSP.Columns.Add("LoaiXe", "Loại Xe");
                    dgvQLSP.Columns.Add("DungTich", "Dung Tích");
                    dgvQLSP.Columns.Add("HangSanXuat", "Hãng Sản Xuất");
                    dgvQLSP.Columns.Add("MauSac", "Màu Sắc");
                    dgvQLSP.Columns.Add("GiaNhap", "Giá Nhập");
                    dgvQLSP.Columns.Add("GiaBan", "Giá Bán");
                    dgvQLSP.Columns.Add("SoLuong", "Số Lượng");
                    dgvQLSP.Columns.Add("DonViTinh", "Đơn Vị Tính");
                }
                DataTable dt = qlsp.LayDSSanPham();
                dgvQLSP.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    DataGridViewRow dgvRow = new DataGridViewRow();
                    dgvRow.CreateCells(dgvQLSP);
                    dgvRow.Cells[dgvQLSP.Columns["MaXe"].Index].Value = row["MaXe"].ToString();
                    dgvRow.Cells[dgvQLSP.Columns["TenXe"].Index].Value = row["TenXe"].ToString();
                    dgvRow.Cells[dgvQLSP.Columns["LoaiXe"].Index].Value = row["LoaiXe"].ToString();
                    dgvRow.Cells[dgvQLSP.Columns["DungTich"].Index].Value = row["DungTich"].ToString();
                    dgvRow.Cells[dgvQLSP.Columns["HangSanXuat"].Index].Value = row["HangSanXuat"].ToString();
                    dgvRow.Cells[dgvQLSP.Columns["MauSac"].Index].Value = row["MauSac"].ToString();
                    dgvRow.Cells[dgvQLSP.Columns["GiaNhap"].Index].Value = row["GiaNhap"].ToString();
                    dgvRow.Cells[dgvQLSP.Columns["GiaBan"].Index].Value = row["GiaBan"].ToString();
                    dgvRow.Cells[dgvQLSP.Columns["SoLuong"].Index].Value = row["SoLuong"].ToString();
                    dgvRow.Cells[dgvQLSP.Columns["DonViTinh"].Index].Value = row["DonViTinh"].ToString();

                    dgvQLSP.Rows.Add(dgvRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị danh sách xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ThemDong()
        {
            DataTable dt = qlsp.LayDSSanPham();
            dgvQLSP.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                DataGridViewRow dgvRow = new DataGridViewRow();
                dgvRow.CreateCells(dgvQLSP);
                dgvRow.Cells[dgvQLSP.Columns["MaXe"].Index].Value = row["MaXe"].ToString();
                dgvRow.Cells[dgvQLSP.Columns["TenXe"].Index].Value = row["TenXe"].ToString();
                dgvRow.Cells[dgvQLSP.Columns["LoaiXe"].Index].Value = row["LoaiXe"].ToString();
                dgvRow.Cells[dgvQLSP.Columns["DungTich"].Index].Value = row["DungTich"].ToString();
                dgvRow.Cells[dgvQLSP.Columns["HangSanXuat"].Index].Value = row["HangSanXuat"].ToString();
                dgvRow.Cells[dgvQLSP.Columns["MauSac"].Index].Value = row["MauSac"].ToString();
                dgvRow.Cells[dgvQLSP.Columns["GiaNhap"].Index].Value = row["GiaNhap"].ToString();
                dgvRow.Cells[dgvQLSP.Columns["GiaBan"].Index].Value = row["GiaBan"].ToString();
                dgvRow.Cells[dgvQLSP.Columns["SoLuong"].Index].Value = row["SoLuong"].ToString();
                dgvRow.Cells[dgvQLSP.Columns["DonViTinh"].Index].Value = row["DonViTinh"].ToString();

                dgvQLSP.Rows.Add(dgvRow);
            }
        }

        private void txtMaXe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMaXe, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtMaXe, "");
            }
        }

        private void txtTenXe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTenXe, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtTenXe, "");
            }
        }

        private void txtLoaiXe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtLoaiXe, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtLoaiXe, "");
            }
        }

        private void txtDungTich_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtDungTich, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtDungTich, "");
            }
        }

        private void txtMauSac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMauSac, "Chỉ được nhập chữ!");
                MessageBox.Show("Vui lòng chỉ nhập chữ vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtMauSac, "");
            }
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) &&!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                errorProvider1.SetError(txtGiaNhap, "Chỉ được nhập số!");
                MessageBox.Show("Vui lòng chỉ được nhập số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtGiaNhap, "");
            }

        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtGiaBan, "Chỉ được nhập số!");
                MessageBox.Show("Vui lòng chỉ được nhập số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtGiaBan, "");
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtGiaBan, "Chỉ được nhập số!");
                MessageBox.Show("Vui lòng chỉ được nhập số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtGiaBan, "");
            }
        }

        private void dgvQLSP_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLSP.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvQLSP.SelectedRows[0];
                    txtMaXe.Text = row.Cells["MaXe"].Value.ToString().Trim();
                    txtTenXe.Text = row.Cells["TenXe"].Value.ToString().Trim();
                    txtLoaiXe.Text = row.Cells["LoaiXe"].Value.ToString().Trim();
                    txtDungTich.Text = row.Cells["DungTich"].Value.ToString().Trim();
                    txtHangSanXuat.Text = row.Cells["HangSanXuat"].Value.ToString().Trim();
                    txtMauSac.Text = row.Cells["MauSac"].Value.ToString().Trim();
                    txtGiaNhap.Text = row.Cells["GiaNhap"].Value.ToString().Trim();
                    txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString().Trim();
                    txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString().Trim();
                    txtDonViTinh.Text = row.Cells["DonViTinh"].Value.ToString().Trim();

                    // Hiển thị hình ảnh
                    string maXe = row.Cells["MaXe"].Value.ToString().Trim();
                    DataTable dt = qlsp.LayDSSanPham();
                    string thuMucChuaAnh = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "asset", "images");
                    foreach (DataRow dataRow in dt.Rows)
                    {
                        if (dataRow["MaXe"].ToString().Trim() == maXe)
                        {
                            string tenFileAnh = dataRow["HinhAnh"].ToString().Trim();
                            string duongDanHinhAnh = Path.Combine(thuMucChuaAnh, tenFileAnh);

                            if (!string.IsNullOrEmpty(duongDanHinhAnh) && System.IO.File.Exists(duongDanHinhAnh))
                            {

                                if (ptbHinhSP.Image != null)
                                {
                                    ptbHinhSP.Image.Dispose();
                                    ptbHinhSP.Image = null;
                                }

                                try
                                {
                                    using (Bitmap tempImage = new Bitmap(duongDanHinhAnh))
                                    {
                                        int newWidth = 300; // Kích thước mới
                                        int newHeight = (int)((double)tempImage.Height / tempImage.Width * newWidth);
                                        ptbHinhSP.Image = new Bitmap(tempImage, newWidth, newHeight);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Lỗi khi load hình ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    ptbHinhSP.Image = null;
                                }
                            }
                            else
                            {
                                if (!this.DesignMode) // Chỉ chạy khi không ở Design Time
                                {
                                    // Giải phóng hình ảnh cũ nếu có
                                    if (ptbHinhSP.Image != null)
                                    {
                                        ptbHinhSP.Image.Dispose();
                                        ptbHinhSP.Image = null;
                                    }
                                    MessageBox.Show($"Không tìm thấy hình ảnh: {tenFileAnh}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienDanhSachXe();
            ClearFields();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaXe.Text) ||
                    string.IsNullOrWhiteSpace(txtTenXe.Text) ||
                    string.IsNullOrWhiteSpace(txtLoaiXe.Text) ||
                    string.IsNullOrWhiteSpace(txtDungTich.Text) ||
                    string.IsNullOrWhiteSpace(txtHangSanXuat.Text) ||
                    string.IsNullOrWhiteSpace(txtMauSac.Text) ||
                    string.IsNullOrWhiteSpace(txtGiaNhap.Text) ||
                    string.IsNullOrWhiteSpace(txtGiaBan.Text) ||
                    string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                    string.IsNullOrWhiteSpace(txtDonViTinh.Text) ||
                    string.IsNullOrWhiteSpace(txtHinhAnh.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (DataGridViewRow row in dgvQLSP.Rows)
                {
                    if (row.Cells["MaXe"].Value != null &&
                        row.Cells["MaXe"].Value.ToString().Trim().ToUpper() == txtMaXe.Text.Trim().ToUpper())
                    {
                        MessageBox.Show("Mã xe đã tồn tại!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                string maXe = txtMaXe.Text.Trim();
                string tenXe = txtTenXe.Text.Trim();
                string loaiXe = txtLoaiXe.Text.Trim();
                string dungTich = txtDungTich.Text.Trim();
                string hangSanXuat = txtHangSanXuat.Text.Trim();
                string mauSac = txtMauSac.Text.Trim();
                decimal giaNhap = decimal.Parse(txtGiaNhap.Text.Trim());
                decimal giaBan = decimal.Parse(txtGiaBan.Text.Trim());
                int soLuong = int.Parse(txtSoLuong.Text.Trim());
                string donViTinh = txtDonViTinh.Text.Trim();
                string Hinhanh = txtHinhAnh.Text.Trim();
                qlsp.ThemSP(maXe, tenXe, loaiXe, dungTich, hangSanXuat, mauSac, giaNhap, giaBan, soLuong, donViTinh,Hinhanh);

                ClearFields();
                MessageBox.Show("Thêm xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienDanhSachXe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaXe.Text) ||
                    string.IsNullOrWhiteSpace(txtTenXe.Text) ||
                    string.IsNullOrWhiteSpace(txtLoaiXe.Text) ||
                    string.IsNullOrWhiteSpace(txtDungTich.Text) ||
                    string.IsNullOrWhiteSpace(txtHangSanXuat.Text) ||
                    string.IsNullOrWhiteSpace(txtMauSac.Text) ||
                    string.IsNullOrWhiteSpace(txtGiaNhap.Text) ||
                    string.IsNullOrWhiteSpace(txtGiaBan.Text) ||
                    string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                    string.IsNullOrWhiteSpace(txtDonViTinh.Text) ||
                    string.IsNullOrWhiteSpace(txtHinhAnh.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maXe = txtMaXe.Text.Trim();
                string tenXe = txtTenXe.Text.Trim();
                string loaiXe = txtLoaiXe.Text.Trim();
                string dungTich = txtDungTich.Text.Trim();
                string hangSanXuat = txtHangSanXuat.Text.Trim();
                string mauSac = txtMauSac.Text.Trim();
                decimal giaNhap = decimal.Parse(txtGiaNhap.Text.Trim());
                decimal giaBan = decimal.Parse(txtGiaBan.Text.Trim());
                int soLuong = int.Parse(txtSoLuong.Text.Trim());
                string donViTinh = txtDonViTinh.Text.Trim();
                string hinhAnh = txtHinhAnh.Text.Trim();
                qlsp.SuaSP(maXe, tenXe, loaiXe, dungTich, hangSanXuat, mauSac, giaNhap, giaBan, soLuong, donViTinh,hinhAnh);

                ClearFields();
                MessageBox.Show("Sửa xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienDanhSachXe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLSP.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa xe này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataGridViewRow row = dgvQLSP.SelectedRows[0];
                        string maXe = row.Cells["MaXe"].Value.ToString();
                        qlsp.XoaSP(maXe);
                        HienDanhSachXe();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một xe để xóa!", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaXe.Text) && string.IsNullOrWhiteSpace(txtTenXe.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã xe hoặc tên xe để tìm kiếm!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maXeTimKiem = txtMaXe.Text.Trim().ToUpper();
                string tenXeTimKiem=txtTenXe.Text.Trim().ToUpper();
                bool timThay = false;
                dgvQLSP.Rows.Clear();
                DataTable dt = qlsp.LayDSSanPham();
                foreach (DataRow row in dt.Rows)
                {
                    string maXe = row["MaXe"].ToString().Trim().ToUpper().Replace("\r", "").Replace("\n", "");
                    string tenXe = row["TenXe"].ToString().Trim().ToUpper().Replace("\r", "").Replace("\n", "");

                    bool maXeMatch = string.IsNullOrWhiteSpace(maXeTimKiem) || maXe == maXeTimKiem;
                    bool tenXeMatch = string.IsNullOrWhiteSpace(tenXeTimKiem) || tenXe.Contains(tenXeTimKiem);
                    if (maXeMatch && tenXeMatch)
                    {
                        timThay = true;
                        DataGridViewRow dgvRow = new DataGridViewRow();
                        dgvRow.CreateCells(dgvQLSP);
                        dgvRow.Cells[dgvQLSP.Columns["MaXe"].Index].Value = row["MaXe"].ToString();
                        dgvRow.Cells[dgvQLSP.Columns["TenXe"].Index].Value = row["TenXe"].ToString();
                        dgvRow.Cells[dgvQLSP.Columns["LoaiXe"].Index].Value = row["LoaiXe"].ToString();
                        dgvRow.Cells[dgvQLSP.Columns["DungTich"].Index].Value = row["DungTich"].ToString();
                        dgvRow.Cells[dgvQLSP.Columns["HangSanXuat"].Index].Value = row["HangSanXuat"].ToString();
                        dgvRow.Cells[dgvQLSP.Columns["MauSac"].Index].Value = row["MauSac"].ToString();
                        dgvRow.Cells[dgvQLSP.Columns["GiaNhap"].Index].Value = row["GiaNhap"].ToString();
                        dgvRow.Cells[dgvQLSP.Columns["GiaBan"].Index].Value = row["GiaBan"].ToString();
                        dgvRow.Cells[dgvQLSP.Columns["SoLuong"].Index].Value = row["SoLuong"].ToString();
                        dgvRow.Cells[dgvQLSP.Columns["DonViTinh"].Index].Value = row["DonViTinh"].ToString();

                        dgvQLSP.Rows.Add(dgvRow);
                        string thuMucChuaAnh = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "asset", "images");
                        foreach (DataRow dataRow in dt.Rows)
                        {
                            if (dataRow["MaXe"].ToString().Trim() == maXe)
                            {
                                string tenFileAnh = dataRow["HinhAnh"].ToString().Trim();
                                string duongDanHinhAnh = Path.Combine(thuMucChuaAnh, tenFileAnh);

                                if (!string.IsNullOrEmpty(duongDanHinhAnh) && System.IO.File.Exists(duongDanHinhAnh))
                                {

                                    if (ptbHinhSP.Image != null)
                                    {
                                        ptbHinhSP.Image.Dispose();
                                        ptbHinhSP.Image = null;
                                    }

                                    try
                                    {
                                        using (Bitmap tempImage = new Bitmap(duongDanHinhAnh))
                                        {
                                            int newWidth = 300; // Kích thước mới
                                            int newHeight = (int)((double)tempImage.Height / tempImage.Width * newWidth);
                                            ptbHinhSP.Image = new Bitmap(tempImage, newWidth, newHeight);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show($"Lỗi khi load hình ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        ptbHinhSP.Image = null;
                                    }
                                }
                                else
                                {
                                    // Giải phóng hình ảnh cũ nếu có
                                    if (ptbHinhSP.Image != null)
                                    {
                                        ptbHinhSP.Image.Dispose();
                                        ptbHinhSP.Image = null;
                                    }
                                    MessageBox.Show($"Không tìm thấy hình ảnh: {tenFileAnh}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                }
                            }
                        }
                    }
                }
                if (!timThay)
                    {
                        MessageBox.Show("Không tìm thấy xe với mã xe hoặc tên xe", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HienDanhSachXe(); 
                        return;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HienDanhSachXe();
                return;
            }
        }

        private void dgvQLSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
