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
using System.IO;


namespace QuanLyBanHang.Form_NhanVien
{
    public partial class frmThemNhanVien : Form
    {
        private byte[] imageBytes = null;
        private string connectionString = "Data Source=DESKTOP-AOFC2NB\\SQLEXPRESS;Initial Catalog=QuanLyCHNoiThat;Integrated Security=True";

        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        // Load dữ liệu nhân viên
        public void LoadNhanVien(int maNV)
        {
            string query = "SELECT * FROM NhanVien WHERE MaNV = @MaNV";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtTenNV.Text = reader["TenNV"].ToString();
                        dtpNgaySinh.Value = reader["NgaySinh"] == DBNull.Value ? DateTime.Today : Convert.ToDateTime(reader["NgaySinh"]);
                        cbGioiTinh.Text = reader["GioiTinh"].ToString();
                        txtDiaChi.Text = reader["DiaChi"].ToString();
                        txtSoDienThoai.Text = reader["SoDienThoai"].ToString();
                        txtTenDangNhap.Text = reader["TenDangNhap"].ToString();
                        txtMatKhau.Text = reader["MatKhau"].ToString();
                        cbChucVu.Text = reader["ChucVu"].ToString();
                        dtpNgayTuyenDung.Value = reader["NgayTuyenDung"] == DBNull.Value ? DateTime.Today : Convert.ToDateTime(reader["NgayTuyenDung"]);

                        if (reader["Anh"] != DBNull.Value)
                        {
                            imageBytes = (byte[])reader["Anh"];
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                picAvatar.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            picAvatar.Image = null;
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSoDienThoai.Text.Length < 10 || txtSoDienThoai.Text.Length > 11 || !txtSoDienThoai.Text.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Vui lòng nhập 10-11 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string query = "INSERT INTO NhanVien (TenNV, NgaySinh, GioiTinh, DiaChi, SoDienThoai, TenDangNhap, MatKhau, ChucVu, NgayTuyenDung, Anh) " +
                           "VALUES (@TenNV, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai, @TenDangNhap, @MatKhau, @ChucVu, @NgayTuyenDung, @Anh)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        cmd.Parameters.AddWithValue("@GioiTinh", cbGioiTinh.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        cmd.Parameters.AddWithValue("@SoDienThoai", txtSoDienThoai.Text);
                        cmd.Parameters.AddWithValue("@TenDangNhap", txtTenDangNhap.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", txtMatKhau.Text);
                        cmd.Parameters.AddWithValue("@ChucVu", cbChucVu.Text);
                        cmd.Parameters.AddWithValue("@NgayTuyenDung", dtpNgayTuyenDung.Value);
                        cmd.Parameters.Add("@Anh", SqlDbType.VarBinary).Value = imageBytes ?? (object)DBNull.Value;

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Chọn ảnh từ máy tính
        private void btnChonAnh_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Chọn ảnh đại diện"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Kiểm tra dung lượng ảnh (giới hạn 2MB)
                    FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                    if (fileInfo.Length > 2 * 1024 * 1024)
                    {
                        MessageBox.Show("Ảnh quá lớn! Vui lòng chọn ảnh có dung lượng dưới 2MB.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    picAvatar.Image = Image.FromFile(openFileDialog.FileName);
                    imageBytes = File.ReadAllBytes(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
