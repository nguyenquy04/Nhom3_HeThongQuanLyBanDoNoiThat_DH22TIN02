using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Form_NhanVien;

namespace QuanLyBanHang
{
    public partial class frmAdmin : Form
    {
        private string connectionString = "Data Source=DESKTOP-AOFC2NB\\SQLEXPRESS;Initial Catalog=QuanLyCHNoiThat;Integrated Security=True";
        public frmAdmin()
        {
            InitializeComponent();
            dgvNhanVien.CellEndEdit += dgvNhanVien_CellEndEdit;
            this.Load += frmAdmin_Load; // Đảm bảo sự kiện được gọi
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            LoadDataGridView(); // Nạp dữ liệu từ CSDL
        }
        // Load dữ liệu nhân viên vào DataGridView
        public void LoadDataGridView()
        {
            string query = "SELECT MaNV, TenNV, GioiTinh, DiaChi, SoDienThoai, NgaySinh FROM NhanVien";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvNhanVien.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sự kiện chỉnh sửa trong DataGridView
        private void dgvNhanVien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int maNV = Convert.ToInt32(dgvNhanVien.Rows[e.RowIndex].Cells["MaNV"].Value);
            string tenNV = dgvNhanVien.Rows[e.RowIndex].Cells["TenNV"].Value.ToString();
            string gioiTinh = dgvNhanVien.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
            string diaChi = dgvNhanVien.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            string soDienThoai = dgvNhanVien.Rows[e.RowIndex].Cells["SoDienThoai"].Value.ToString();
            DateTime ngaySinh = Convert.ToDateTime(dgvNhanVien.Rows[e.RowIndex].Cells["NgaySinh"].Value);

            string query = "UPDATE NhanVien SET TenNV=@TenNV, GioiTinh=@GioiTinh, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai, NgaySinh=@NgaySinh WHERE MaNV=@MaNV";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenNV", tenNV);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frm = new frmThemNhanVien();
            frm.FormClosed += (s, args) => LoadDataGridView(); // Reload dữ liệu sau khi thêm xong
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                string columnName = dgvNhanVien.Columns[0].Name; // Tên cột đầu tiên (Mã Nhân Viên)
                MessageBox.Show("Tên cột thực tế: " + columnName, "Thông báo"); // Kiểm tra tên cột

                if (!dgvNhanVien.Columns.Contains(columnName))
                {
                    MessageBox.Show($"Không tìm thấy cột '{columnName}'. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dgvNhanVien.SelectedRows[0].Cells[columnName].Value == null)
                {
                    MessageBox.Show("Dữ liệu trong ô bị rỗng, không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int maNV = Convert.ToInt32(dgvNhanVien.SelectedRows[0].Cells[columnName].Value);

                // Xác nhận trước khi xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaNV", maNV);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGridView(); // Load lại danh sách
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Nhân Viên để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT MaNV, TenNV, GioiTinh, DiaChi, SoDienThoai, NgaySinh FROM NhanVien WHERE MaNV = @MaNV";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvNhanVien.DataSource = dt;
                        }
                    }
                }

                if (dgvNhanVien.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên với mã: " + txtMaNV.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNhanVien.SelectedRows.Count > 0)
                {
                    // Lấy dòng đang chọn
                    DataGridViewRow row = dgvNhanVien.SelectedRows[0];

                    // Lấy dữ liệu từ DataGridView
                    int maNV = Convert.ToInt32(row.Cells["Mã Nhân Viên"].Value);
                    string tenNV = row.Cells["Tên Nhân Viên"].Value.ToString();
                    string gioiTinh = row.Cells["Giới Tính"].Value.ToString();
                    string diaChi = row.Cells["Địa Chỉ"].Value.ToString();
                    string soDienThoai = row.Cells["Số Điện Thoại"].Value.ToString();
                    DateTime ngaySinh = Convert.ToDateTime(row.Cells["Ngày Sinh"].Value);

                    // Cập nhật database
                    string query = "UPDATE NhanVien SET TenNV = @TenNV, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, NgaySinh = @NgaySinh WHERE MaNV = @MaNV";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaNV", maNV);
                            cmd.Parameters.AddWithValue("@TenNV", tenNV);
                            cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                            cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                            cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                            cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNhanVien_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Lấy mã nhân viên của dòng đang sửa
                int maNV = Convert.ToInt32(dgvNhanVien.Rows[e.RowIndex].Cells["Mã Nhân Viên"].Value);

                // Lấy dữ liệu từ các ô trong DataGridView
                string tenNV = dgvNhanVien.Rows[e.RowIndex].Cells["Tên Nhân Viên"].Value.ToString();
                string gioiTinh = dgvNhanVien.Rows[e.RowIndex].Cells["Giới Tính"].Value.ToString();
                string diaChi = dgvNhanVien.Rows[e.RowIndex].Cells["Địa Chỉ"].Value.ToString();
                string soDienThoai = dgvNhanVien.Rows[e.RowIndex].Cells["Số Điện Thoại"].Value.ToString();
                DateTime ngaySinh = Convert.ToDateTime(dgvNhanVien.Rows[e.RowIndex].Cells["Ngày Sinh"].Value);

                // Chuỗi SQL cập nhật
                string query = "UPDATE NhanVien SET TenNV = @TenNV, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, NgaySinh = @NgaySinh WHERE MaNV = @MaNV";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@TenNV", tenNV);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                        cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                        cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
