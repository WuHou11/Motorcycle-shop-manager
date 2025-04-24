using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bx.ALL_UserControl
{
    public partial class UC_Account : UserControl
    {
        QLTK qltk;
        public UC_Account()
        {
            InitializeComponent();
            qltk = new QLTK();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txtMaNV.Text) ||
                    string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                    string.IsNullOrWhiteSpace(txtTuoi.Text) ||
                    (!rbNam.Checked && !rbNu.Checked) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    cbChucVu.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra trùng mã nhân viên
                foreach (DataGridViewRow row in dgvQLTK.Rows)
                {
                    if (row.Cells["MaNV"].Value != null &&
                        row.Cells["MaNV"].Value.ToString().Trim().ToUpper() == txtMaNV.Text.Trim().ToUpper())
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Thu thập dữ liệu
                string maNV = txtMaNV.Text.Trim();
                string hoTen = txtHoTen.Text.Trim();
                int tuoi = int.Parse(txtTuoi.Text.Trim());
                string gioiTinh = rbNam.Checked ? "Nam" : "Nu";
                string email = txtEmail.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string chucVu = cbChucVu.SelectedItem != null ? cbChucVu.SelectedItem.ToString().Trim() : "";
                cbChucVu.SelectedIndex = cbChucVu.FindStringExact(chucVu);

                // Thêm nhân viên
                qltk.ThemTK(maNV, hoTen, tuoi, gioiTinh, email, sdt, username, password, chucVu);

                ClearFields();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienDSNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaNV.Text) ||
                    string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                    string.IsNullOrWhiteSpace(txtTuoi.Text) ||
                    (!rbNam.Checked && !rbNu.Checked) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    cbChucVu.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maNV = txtMaNV.Text.Trim();
                string hoTen = txtHoTen.Text.Trim();
                int tuoi = int.Parse(txtTuoi.Text.Trim());
                string gioiTinh = rbNam.Checked ? "Nam" : "Nu";
                string email = txtEmail.Text.Trim();
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string chucVu = cbChucVu.SelectedItem != null ? cbChucVu.SelectedItem.ToString().Trim() : "";
                cbChucVu.SelectedIndex = cbChucVu.FindStringExact(chucVu);

                qltk.SuaTK(maNV, hoTen, tuoi, gioiTinh, email, username, password, sdt, chucVu);
                ClearFields();
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienDSNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLTK.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataGridViewRow row = dgvQLTK.SelectedRows[0];
                        string maNV = row.Cells["MaNV"].Value.ToString();
                        qltk.XoaTK(maNV);
                        HienDSNhanVien();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string chucVu = cbChucVu.SelectedItem?.ToString().Trim() ?? "";
                string tuKhoaTen = txtTimTenNV.Text.Trim();
                string tuKhoaMaNV = txtTimMaNV.Text.Trim();

                if (string.IsNullOrEmpty(chucVu) && string.IsNullOrEmpty(tuKhoaTen) && string.IsNullOrEmpty(tuKhoaMaNV))
                {
                    MessageBox.Show("Vui lòng nhập ít nhất một tiêu chí để tìm (chức vụ, mã nhân viên, hoặc tên)!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable dt = qltk.LayDSTaiKhoan();
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvQLTK.Rows.Clear();

                int count = 0;
                foreach (DataRow row in dt.Rows)
                {
                    string chucVuRow = row["ChucVu"].ToString().Trim();
                    string maNV = row["MaNV"].ToString().Trim();
                    string hoTen = row["HoTen"].ToString().Trim();
                    bool match = true; // Sử dụng logic AND
                    if (!string.IsNullOrEmpty(chucVu))
                    {
                        match = match && string.Equals(chucVuRow, chucVu, StringComparison.OrdinalIgnoreCase);
                    }

                    if (!string.IsNullOrEmpty(tuKhoaMaNV))
                    {
                        match = match && (maNV.IndexOf(tuKhoaMaNV, StringComparison.OrdinalIgnoreCase) >= 0);
                    }
                    if (!string.IsNullOrEmpty(tuKhoaTen))
                    {
                        match = match && (hoTen.IndexOf(tuKhoaTen, StringComparison.OrdinalIgnoreCase) >= 0);
                    }

                    if (match)
                    {
                        DataGridViewRow dgvRow = new DataGridViewRow();
                        dgvRow.CreateCells(dgvQLTK);
                        dgvRow.Cells[dgvQLTK.Columns["MaNV"].Index].Value = maNV;
                        dgvRow.Cells[dgvQLTK.Columns["HoTen"].Index].Value = hoTen;
                        dgvRow.Cells[dgvQLTK.Columns["Tuoi"].Index].Value = row["Tuoi"].ToString();
                        dgvRow.Cells[dgvQLTK.Columns["GioiTinh"].Index].Value = row["GioiTinh"].ToString();
                        dgvRow.Cells[dgvQLTK.Columns["Email"].Index].Value = row["Email"].ToString();
                        dgvRow.Cells[dgvQLTK.Columns["SDT"].Index].Value = row["SDT"].ToString();
                        dgvRow.Cells[dgvQLTK.Columns["TaiKhoan"].Index].Value = row["TaiKhoan"].ToString();
                        dgvRow.Cells[dgvQLTK.Columns["MatKhau"].Index].Value = row["MatKhau"].ToString();
                        dgvRow.Cells[dgvQLTK.Columns["ChucVu"].Index].Value = row["ChucVu"].ToString();

                        dgvQLTK.Rows.Add(dgvRow);
                        count++;
                    }
                }

                if (count == 0)
                {
                    string thongBao = "Không tìm thấy nhân viên nào khớp với tiêu chí: ";
                    if (!string.IsNullOrEmpty(chucVu)) thongBao += $"Chức vụ '{chucVu}', ";
                    if (!string.IsNullOrEmpty(tuKhoaMaNV)) thongBao += $"Mã NV '{tuKhoaMaNV}', ";
                    if (!string.IsNullOrEmpty(tuKhoaTen)) thongBao += $"Tên '{tuKhoaTen}'";
                    thongBao = thongBao.TrimEnd(',', ' ') + "!";
                    MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvQLTK.ClearSelection();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtTuoi.Clear();
            rbNam.Checked = false;
            rbNu.Checked = false;
            txtEmail.Clear();
            txtSDT.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cbChucVu.SelectedIndex = -1;
            txtTimMaNV.Clear();
            txtTimTenNV.Clear();
        }

        private void HienDSNhanVien()
        {
            dgvQLTK.AllowUserToAddRows = false;
            try
            {
                if (dgvQLTK.Columns.Count == 0)
                {
                    dgvQLTK.Columns.Add("MaNV", "Mã Nhân Viên");
                    dgvQLTK.Columns.Add("HoTen", "Họ Tên");
                    dgvQLTK.Columns.Add("Tuoi", "Tuổi");
                    dgvQLTK.Columns.Add("GioiTinh", "Giới Tính");
                    dgvQLTK.Columns.Add("Email", "Email");
                    dgvQLTK.Columns.Add("SDT", "SĐT");
                    dgvQLTK.Columns.Add("TaiKhoan", "Tài Khoản");
                    dgvQLTK.Columns.Add("MatKhau", "Mật Khẩu");
                    dgvQLTK.Columns.Add("ChucVu", "Chức Vụ");
                }
                DataTable dt = qltk.LayDSTaiKhoan();
                dgvQLTK.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    DataGridViewRow dgvRow = new DataGridViewRow();
                    dgvRow.CreateCells(dgvQLTK);
                    dgvRow.Cells[dgvQLTK.Columns["MaNV"].Index].Value = row["MaNV"].ToString();
                    dgvRow.Cells[dgvQLTK.Columns["HoTen"].Index].Value = row["HoTen"].ToString();
                    dgvRow.Cells[dgvQLTK.Columns["Tuoi"].Index].Value = row["Tuoi"].ToString();
                    dgvRow.Cells[dgvQLTK.Columns["GioiTinh"].Index].Value = row["GioiTinh"].ToString();
                    dgvRow.Cells[dgvQLTK.Columns["Email"].Index].Value = row["Email"].ToString();
                    dgvRow.Cells[dgvQLTK.Columns["SDT"].Index].Value = row["SDT"].ToString();
                    dgvRow.Cells[dgvQLTK.Columns["TaiKhoan"].Index].Value = row["TaiKhoan"].ToString();
                    dgvRow.Cells[dgvQLTK.Columns["MatKhau"].Index].Value = row["MatKhau"].ToString();
                    dgvRow.Cells[dgvQLTK.Columns["ChucVu"].Index].Value = row["ChucVu"].ToString();

                    dgvQLTK.Rows.Add(dgvRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMaNV, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtMaNV, "");
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtHoTen, "Chỉ được nhập chữ!");
                MessageBox.Show("Vui lòng chỉ nhập chữ vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }
        }

        private void txtTuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTuoi, "Vui lòng chỉ nhập số vào đây");
                MessageBox.Show("Vui lòng chỉ nhập số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtTuoi, "");
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSDT, "Vui lòng chỉ nhập số vào đây");
                MessageBox.Show("Vui lòng chỉ nhập số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtUsername, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtUsername, "");
            }
        }

        private void UC_Account_Load(object sender, EventArgs e)
        {
            HienDSNhanVien();
            cbChucVu.Items.Add("Nhan vien");
            cbChucVu.Items.Add("Quan ly");
            cbChucVu.Items.Add("Truong phong");
            cbChucVu.Items.Add("Giam doc");
            ClearFields();
        }
        

        private void dgvQLTK_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLTK.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvQLTK.SelectedRows[0];
                    txtMaNV.Text = row.Cells["MaNV"].Value.ToString().Trim();
                    txtHoTen.Text = row.Cells["HoTen"].Value.ToString().Trim();
                    txtTuoi.Text = row.Cells["Tuoi"].Value.ToString().Trim();

                    string gioiTinh = row.Cells["GioiTinh"].Value.ToString().Trim();
                    rbNam.Checked = gioiTinh == "Nam";
                    rbNu.Checked = gioiTinh == "Nu";

                    txtEmail.Text = row.Cells["Email"].Value.ToString().Trim();
                    txtSDT.Text = row.Cells["SDT"].Value.ToString().Trim() ;
                    txtUsername.Text = row.Cells["TaiKhoan"].Value.ToString().Trim();
                    txtPassword.Text = row.Cells["MatKhau"].Value.ToString().Trim();

                    string chucVu = row.Cells["ChucVu"].Value.ToString().Trim();
                    if (cbChucVu.DataSource != null)
                        cbChucVu.SelectedValue = chucVu;
                    else
                        cbChucVu.SelectedItem = chucVu;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            HienDSNhanVien();
            ClearFields();
        }
    }
}