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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyBanHang
{
    public partial class frmThongTinCaNhan : Form
    {
        private string tenDangNhap; // Lưu tên đăng nhập của người dùng
        private string connectionString = "Data Source=DESKTOP-AOFC2NB\\SQLEXPRESS;Initial Catalog=QuanLyCHNoiThat;Integrated Security=True";
        public frmThongTinCaNhan()
        {
            InitializeComponent();
            tenDangNhap ="";
            LoadUserInfo();
        }
        private void LoadUserInfo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TenHienThi FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtTenDangNhap.Text = tenDangNhap;
                        txtTenHienThi.Text = reader["TenHienThi"].ToString();
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string tenHienThi = txtTenHienThi.Text;
            string matKhauCu = txtMatKhau.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string nhapLai = txtNhapLai.Text;

            if (string.IsNullOrWhiteSpace(matKhauCu) || string.IsNullOrWhiteSpace(matKhauMoi) || string.IsNullOrWhiteSpace(nhapLai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhauMoi != nhapLai)
            {
                MessageBox.Show("Mật khẩu mới không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    checkCmd.Parameters.AddWithValue("@MatKhau", matKhauCu);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string updateQuery = "UPDATE TaiKhoan SET TenHienThi = @TenHienThi, MatKhau = @MatKhauMoi WHERE TenDangNhap = @TenDangNhap";
                using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    updateCmd.Parameters.AddWithValue("@TenHienThi", tenHienThi);
                    updateCmd.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);
                    updateCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
