using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Form_NhanVien;

namespace QuanLyBanHang.Form_Login
{
    public partial class frmDangNhap : Form
    {
        private string loaiTaiKhoan; // Lưu loại tài khoản cần đăng nhập
        public frmDangNhap()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true; // Ẩn mật khẩu khi khởi động
            loaiTaiKhoan = "Admin"; // Gán giá trị mặc định
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            lblTaiKhoan.Text = loaiTaiKhoan;
        }
        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Kiểm tra thông tin đăng nhập từ CSDL
            if (DatabaseHelper.KiemTraDangNhap(username, password, out string loaiTaiKhoanTuCSDL))
            {
                if (loaiTaiKhoanTuCSDL == loaiTaiKhoan) // Kiểm tra xem có đúng loại tài khoản không
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide(); // Ẩn form đăng nhập

                    frmMain mainForm = new frmMain(loaiTaiKhoan);
                    mainForm.ShowDialog();
                    this.Show();
                    this.Close(); // Đóng form đăng nhập sau khi frmMain đóng
                }
                else
                {
                    MessageBox.Show($"Bạn chỉ có thể đăng nhập với vai trò {loaiTaiKhoan}!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void menuTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void mnuadmin_Click(object sender, EventArgs e)
        {
            loaiTaiKhoan = "Admin";
            lblTaiKhoan.Text = "ADMIN:";
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            loaiTaiKhoan = "Nhân Viên Bán Hàng";
            lblTaiKhoan.Text = "STAFF:";
        }

        private void mnuQuanLi_Click(object sender, EventArgs e)
        {
            loaiTaiKhoan = "Quản Lý";
            lblTaiKhoan.Text = "MANAGEMENT:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?",
                                "Xác nhận thoát",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; // Hủy sự kiện đóng form nếu chọn "No"
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false; // Hiện mật khẩu
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true; // Ẩn mật khẩu
            }
        }
    }
}
