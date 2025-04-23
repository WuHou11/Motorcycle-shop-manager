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
    public partial class UC_Supplier : UserControl
    {
        QLNCC qlncc;
        public UC_Supplier()
        {
            InitializeComponent();
            qlncc=new QLNCC();
        }
        private void ClearFields()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtTimMaNCC.Clear();
            txtTimTenNCC.Clear();
        }
        private void HienDanhSachNCC()
        {
            try
            {
                if (dgvQLNCC.Columns.Count == 0)
                {
                    dgvQLNCC.Columns.Add("MaNCC", "Mã NCC");
                    dgvQLNCC.Columns.Add("TenNCC", "Tên NCC");
                    dgvQLNCC.Columns.Add("DiaChi", "Địa Chỉ");
                    dgvQLNCC.Columns.Add("Email", "Email");
                    dgvQLNCC.Columns.Add("SDT", "SĐT");
                }
                DataTable dt = qlncc.LayDSNhaCungCap();
                dgvQLNCC.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    DataGridViewRow dgvRow = new DataGridViewRow();
                    dgvRow.CreateCells(dgvQLNCC);
                    dgvRow.Cells[dgvQLNCC.Columns["MaNCC"].Index].Value = row["MaNCC"].ToString();
                    dgvRow.Cells[dgvQLNCC.Columns["TenNCC"].Index].Value = row["TenNCC"].ToString();
                    dgvRow.Cells[dgvQLNCC.Columns["DiaChi"].Index].Value = row["DiaChi"].ToString();
                    dgvRow.Cells[dgvQLNCC.Columns["Email"].Index].Value = row["Email"].ToString();
                    dgvRow.Cells[dgvQLNCC.Columns["SDT"].Index].Value = row["SDT"].ToString();

                    dgvQLNCC.Rows.Add(dgvRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị danh sách nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_Supplier_Load(object sender, EventArgs e)
        {
            HienDanhSachNCC();
            ClearFields();
        }

        private void txtMaNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMaNCC, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtMaNCC, "");
            }
        }

        private void txtTenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTenNCC, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtTenNCC, "");
            }
        }

        

        private void txtTimTenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTimTenNCC, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtTimTenNCC, "");
            }
        }

        private void txtTimMaNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTimMaNCC, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtTimMaNCC, "");
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
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

        private void dgvQLNCC_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLNCC.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvQLNCC.SelectedRows[0];
                    txtMaNCC.Text = row.Cells["MaNCC"].Value.ToString().Trim();
                    txtTenNCC.Text = row.Cells["TenNCC"].Value.ToString().Trim();
                    txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString().Trim();
                    txtEmail.Text = row.Cells["Email"].Value.ToString().Trim();
                    txtSDT.Text = row.Cells["SDT"].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienDanhSachNCC();
            ClearFields();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaNCC.Text) ||
                    string.IsNullOrWhiteSpace(txtTenNCC.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (DataGridViewRow row in dgvQLNCC.Rows)
                {
                    if (row.Cells["MaNCC"].Value != null &&
                        row.Cells["MaNCC"].Value.ToString().Trim().ToUpper() == txtMaNCC.Text.Trim().ToUpper())
                    {
                        MessageBox.Show("Mã nhà cung cấp đã tồn tại!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                string maNCC = txtMaNCC.Text.Trim();
                string tenNCC = txtTenNCC.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                string email = txtEmail.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                qlncc.ThemNCC(maNCC, tenNCC, diaChi, email, sdt);

                ClearFields();
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienDanhSachNCC();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaNCC.Text) ||
                    string.IsNullOrWhiteSpace(txtTenNCC.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maNCC = txtMaNCC.Text.Trim();
                string tenNCC = txtTenNCC.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                string email = txtEmail.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                qlncc.SuaNCC(maNCC, tenNCC, diaChi, email, sdt);
                ClearFields();
                MessageBox.Show("Sửa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienDanhSachNCC();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLNCC.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa nhà cung cấp này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataGridViewRow row = dgvQLNCC.SelectedRows[0];
                        string maNCC = row.Cells["MaNCC"].Value.ToString();
                        qlncc.XoaNCC(maNCC); // Assumed method to delete a supplier
                        HienDanhSachNCC();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhà cung cấp để xóa!", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTimMaNCC.Text) && string.IsNullOrWhiteSpace(txtTimTenNCC.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã hoặc tên nhà cung cấp để tìm kiếm!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maNCCTimKiem = txtTimMaNCC.Text.Trim().ToUpper();
                string tenNCCTimKiem = txtTimTenNCC.Text.Trim().ToUpper();
                bool timThay = false;
                dgvQLNCC.Rows.Clear();
                DataTable dt = qlncc.LayDSNhaCungCap();
                foreach (DataRow row in dt.Rows)
                {
                    string maNCC = row["MaNCC"].ToString().Trim().ToUpper().Replace("\r", "").Replace("\n", "");
                    string tenNCC = row["TenNCC"].ToString().Trim().ToUpper().Replace("\r", "").Replace("\n", "");

                    // Kiểm tra nếu mã hoặc tên khớp (hoặc cả hai)
                    bool maNCCMatch = string.IsNullOrWhiteSpace(maNCCTimKiem) || maNCC == maNCCTimKiem;
                    bool tenNCCMatch = string.IsNullOrWhiteSpace(tenNCCTimKiem) || tenNCC.Contains(tenNCCTimKiem);

                    if (maNCCMatch && tenNCCMatch)
                    {
                        timThay = true;
                        DataGridViewRow dgvRow = new DataGridViewRow();
                        dgvRow.CreateCells(dgvQLNCC);
                        dgvRow.Cells[dgvQLNCC.Columns["MaNCC"].Index].Value = row["MaNCC"].ToString();
                        dgvRow.Cells[dgvQLNCC.Columns["TenNCC"].Index].Value = row["TenNCC"].ToString();
                        dgvRow.Cells[dgvQLNCC.Columns["DiaChi"].Index].Value = row["DiaChi"].ToString();
                        dgvRow.Cells[dgvQLNCC.Columns["Email"].Index].Value = row["Email"].ToString();
                        dgvRow.Cells[dgvQLNCC.Columns["SDT"].Index].Value = row["SDT"].ToString();

                        dgvQLNCC.Rows.Add(dgvRow);
                    }
                }

                if (!timThay)
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp với mã hoặc tên đã nhập!", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienDanhSachNCC();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HienDanhSachNCC();
                return;
            }
        }
    }
}
