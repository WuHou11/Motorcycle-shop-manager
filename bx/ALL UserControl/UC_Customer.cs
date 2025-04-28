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
    public partial class UC_Customer : UserControl
    {
        QLKH qlkh;
        public UC_Customer()
        {
            InitializeComponent();
            qlkh=new QLKH();
        }

        private void ClearFields()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            rbNam.Checked = false; 
            rbNu.Checked = false;  
            txtSoCCCD.Clear();
            txtDiachi.Clear();
            txtSDT.Clear();
            txtTimMaKH.Clear();
            txtTimTenKH.Clear();
        }
        private void HienDanhSachKH()
        {
            try
            {
                if (dgvQLKH.Columns.Count == 0)
                {
                    dgvQLKH.Columns.Add("MaKH", "Mã KH");
                    dgvQLKH.Columns.Add("TenKH", "Tên KH");
                    dgvQLKH.Columns.Add("GioiTinh", "Giới Tính");
                    dgvQLKH.Columns.Add("SoCCCD", "Số CCCD");
                    dgvQLKH.Columns.Add("DiaChi", "Địa Chỉ");
                    dgvQLKH.Columns.Add("SoDT", "ĐT");
                }
                DataTable dt = qlkh.LayDSKhachHang();
                dgvQLKH.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    DataGridViewRow dgvRow = new DataGridViewRow();
                    dgvRow.CreateCells(dgvQLKH);
                    dgvRow.Cells[dgvQLKH.Columns["MaKH"].Index].Value = row["MaKH"].ToString();
                    dgvRow.Cells[dgvQLKH.Columns["TenKH"].Index].Value = row["TenKH"].ToString();
                    dgvRow.Cells[dgvQLKH.Columns["GioiTinh"].Index].Value = row["GioiTinh"].ToString();
                    dgvRow.Cells[dgvQLKH.Columns["SoCCCD"].Index].Value = row["SoCCCD"].ToString();
                    dgvRow.Cells[dgvQLKH.Columns["DiaChi"].Index].Value = row["DiaChi"].ToString();
                    dgvRow.Cells[dgvQLKH.Columns["SoDT"].Index].Value = row["SoDT"].ToString();

                    dgvQLKH.Rows.Add(dgvRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị danh sách khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UC_Customer_Load(object sender, EventArgs e)
        {
            HienDanhSachKH();
            ClearFields();
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMaKH, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtMaKH, "");
            }
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTenKH, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtTenKH, "");
            }
        }

        private void txtSoCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSoCCCD, "Chỉ được nhập số!");
                MessageBox.Show("Vui lòng chỉ được nhập số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtSoCCCD, "");
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSDT, "Chỉ được nhập số!");
                MessageBox.Show("Vui lòng chỉ được nhập số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

        }

        private void dgvQLKH_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLKH.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvQLKH.SelectedRows[0];
                    txtMaKH.Text = row.Cells["MaKH"].Value.ToString().Trim();
                    txtTenKH.Text = row.Cells["TenKH"].Value.ToString().Trim();
                    string gioiTinh = row.Cells["GioiTinh"].Value.ToString().Trim();
                    rbNam.Checked = gioiTinh == "Nam";
                    rbNu.Checked = gioiTinh == "Nu";
                    txtSoCCCD.Text = row.Cells["SoCCCD"].Value.ToString().Trim();
                    txtDiachi.Text = row.Cells["DiaChi"].Value.ToString().Trim();
                    txtSDT.Text = row.Cells["SoDT"].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienDanhSachKH();
            ClearFields();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaKH.Text) ||
                    string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                    (!rbNam.Checked && !rbNu.Checked) ||
                    string.IsNullOrWhiteSpace(txtSoCCCD.Text) ||
                    string.IsNullOrWhiteSpace(txtDiachi.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (DataGridViewRow row in dgvQLKH.Rows)
                {
                    if (row.Cells["MaKH"].Value != null &&
                        row.Cells["MaKH"].Value.ToString().Trim().ToUpper() == txtMaKH.Text.Trim().ToUpper())
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                string maKH = txtMaKH.Text.Trim();
                string tenKH = txtTenKH.Text.Trim();
                string gioiTinh = rbNam.Checked ? "Nam" : "Nu";
                string soCCCD = txtSoCCCD.Text.Trim();
                string diaChi = txtDiachi.Text.Trim();
                string dienThoai = txtSDT.Text.Trim();
                qlkh.ThemKH(maKH, tenKH, gioiTinh, soCCCD, diaChi, dienThoai);

                ClearFields();
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienDanhSachKH();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaKH.Text) ||
                    string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                    (!rbNam.Checked && !rbNu.Checked) ||
                    string.IsNullOrWhiteSpace(txtSoCCCD.Text) ||
                    string.IsNullOrWhiteSpace(txtDiachi.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maKH = txtMaKH.Text.Trim();
                string tenKH = txtTenKH.Text.Trim();
                string gioiTinh = rbNam.Checked ? "Nam" : "Nu";
                string soCCCD = txtSoCCCD.Text.Trim();
                string diaChi = txtDiachi.Text.Trim();
                string dienThoai = txtSDT.Text.Trim();
                qlkh.SuaKH(maKH, tenKH, gioiTinh, soCCCD, diaChi, dienThoai);
                ClearFields();
                MessageBox.Show("Sửa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienDanhSachKH();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLKH.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataGridViewRow row = dgvQLKH.SelectedRows[0];
                        string maKH = row.Cells["MaKH"].Value.ToString();
                        qlkh.XoaKH(maKH);
                        HienDanhSachKH();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một khách hàng để xóa!", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTimMaKH.Text) && string.IsNullOrWhiteSpace(txtTimTenKH.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã hoặc tên khách hàng để tìm kiếm!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maKHTimKiem = txtTimMaKH.Text.Trim().ToUpper();
                string tenKHTimKiem = txtTimTenKH.Text.Trim().ToUpper();
                bool timThay = false;
                dgvQLKH.Rows.Clear();
                DataTable dt = qlkh.LayDSKhachHang();
                foreach (DataRow row in dt.Rows)
                {
                    string maKH = row["MaKH"].ToString().Trim().ToUpper().Replace("\r", "").Replace("\n", "");
                    string tenKH = row["TenKH"].ToString().Trim().ToUpper().Replace("\r", "").Replace("\n", "");

                    bool maKHMatch = string.IsNullOrWhiteSpace(maKHTimKiem) || maKH == maKHTimKiem;
                    bool tenKHMatch = string.IsNullOrWhiteSpace(tenKHTimKiem) || tenKH.Contains(tenKHTimKiem);

                    if (maKHMatch && tenKHMatch)
                    {
                        timThay = true;
                        DataGridViewRow dgvRow = new DataGridViewRow();
                        dgvRow.CreateCells(dgvQLKH);
                        dgvRow.Cells[dgvQLKH.Columns["MaKH"].Index].Value = row["MaKH"].ToString();
                        dgvRow.Cells[dgvQLKH.Columns["TenKH"].Index].Value = row["TenKH"].ToString();
                        dgvRow.Cells[dgvQLKH.Columns["GioiTinh"].Index].Value = row["GioiTinh"].ToString();
                        dgvRow.Cells[dgvQLKH.Columns["SoCCCD"].Index].Value = row["SoCCCD"].ToString();
                        dgvRow.Cells[dgvQLKH.Columns["DiaChi"].Index].Value = row["DiaChi"].ToString();
                        dgvRow.Cells[dgvQLKH.Columns["SoDT"].Index].Value = row["SoDT"].ToString();

                        dgvQLKH.Rows.Add(dgvRow);
                    }
                }

                if (!timThay)
                {
                    MessageBox.Show("Không tìm thấy khách hàng với mã hoặc tên đã nhập!", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienDanhSachKH();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HienDanhSachKH();
                return;
            }
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string maKH = txtMaKH.Text.Trim();
                if (string.IsNullOrWhiteSpace(maKH))
                {
                    ClearFields();
                    return;
                }

                DataTable dt = qlkh.LayDSKhachHang();
                bool found = false;

                foreach (DataRow row in dt.Rows)
                {
                    if (row["MaKH"].ToString().Trim().ToUpper() == maKH.ToUpper())
                    {
                        found = true;
                        txtTenKH.Text = row["TenKH"].ToString().Trim();
                        string gioiTinh = row["GioiTinh"].ToString().Trim();
                        rbNam.Checked = gioiTinh == "Nam";
                        rbNu.Checked = gioiTinh == "Nu";
                        txtSoCCCD.Text = row["SoCCCD"].ToString().Trim();
                        txtDiachi.Text = row["DiaChi"].ToString().Trim();
                        txtSDT.Text = row["SoDT"].ToString().Trim();
                        break;
                    }
                }

                if (!found)
                {
                    txtTenKH.Clear();
                    rbNam.Checked = false;
                    rbNu.Checked = false;
                    txtSoCCCD.Clear();
                    txtDiachi.Clear();
                    txtSDT.Clear();
                    txtTimMaKH.Clear();
                    txtTimTenKH.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFields();
            }
        }
    }
}
