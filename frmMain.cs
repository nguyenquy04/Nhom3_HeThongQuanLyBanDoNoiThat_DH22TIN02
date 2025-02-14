using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Form_Login;

namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        private string loaiTaiKhoan;

        public frmMain(string loaiTaiKhoan)
        {
            InitializeComponent();
            this.loaiTaiKhoan = loaiTaiKhoan ?? "Không xác định"; // Đề phòng null
            this.IsMdiContainer = true; // Đặt Form Trang Chủ làm Form cha (MDI Parent)
        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            // Có thể thêm các thiết lập khởi động ở đây
        }
        // Xử lý sự kiện khi nhấn "Thoát"
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        // Xử lý sự kiện khi mở "Quản Lý Tài Khoản"
        //private void mnuQLTaiKhoan_Click(object sender, EventArgs e)
        //{
        //    frmQuanLyTaiKhoan frm = new frmQuanLyTaiKhoan();
        //    frm.MdiParent = this; // Mở form con trong form cha
        //    frm.Show();
        //}
        // Xử lý sự kiện khi mở "Đổi Mật Khẩu"
        //private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        //{
        //    frmDoiMatKhau = new frmDoiMatKhau();
        //    frm.MdiParent = this;
        //    frm.Show();
        //}

        // Xử lý sự kiện khi mở "Khôi Phục Dữ Liệu"
        //private void mnuKhoiPhuc_Click(object sender, EventArgs e)
        //{
        //    frmKhoiPhucDuLieu frm = new frmKhoiPhucDuLieu();
        //    frm.MdiParent = this;
        //    frm.Show();
        //}

        // Xử lý sự kiện khi mở "Trợ giúp"
        private void mnuTroGiup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hướng dẫn sử dụng phần mềm", "Trợ giúp", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Xử lý sự kiện khi nhấn "Đăng xuất"
        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap frm = new frmDangNhap();
                frm.ShowDialog();
                this.Close();
            }
        }
        // Xử lý sự kiện khi mở "Thêm người dùng"
        //private void mnuThemNguoiDung_Click(object sender, EventArgs e)
        //{
        //    frmThemNguoiDung frm = new frmThemNguoiDung();
        //    frm.MdiParent = this;
        //    frm.Show();
        //}
        // Xử lý sự kiện khi mở "Quản lý nhân viên"
        //private void mnuQLNhanVien_Click(object sender, EventArgs e)
        //{
        //    frmQuanLyNhanVien frm = new frmQuanLyNhanVien();
        //    frm.MdiParent = this;
        //    frm.Show();
        //}

        // Xử lý sự kiện khi mở "Phân quyền"
        //private void mnuPhanQuyen_Click(object sender, EventArgs e)
        //{
        //    frmPhanQuyen frm = new frmPhanQuyen();
        //    frm.MdiParent = this;
        //    frm.Show();
        //}
        // Mở form Nhập Hàng
        //private void mnuNhapHang_Click(object sender, EventArgs e)
        //{
        //    frmNhapHang frm = new frmNhapHang();
        //    OpenChildForm(frm);
        //}
        //private void mnuHoaDonNhap_Click(object sender, EventArgs e)
        //{
        //    frm frm = new frmHoaDonNhap();
        //    OpenChildForm(frm);
        //}
        //private void mnuDanhSachHoaDon_Click(object sender, EventArgs e)
        //{
        //    frmHoaDonKH frm = new frmHoaDonKH();
        //    OpenChildForm(frm);
        //}

        private void OpenChildForm(Form childForm)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == childForm.GetType())
                {
                    frm.Activate(); // Nếu form đã mở thì chỉ cần kích hoạt
                    return;
                }
            }

            childForm.MdiParent = this; // Thiết lập frmMain là MDI Parent
            childForm.Show();
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {

        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void quảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuQLKH_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            frmThongTinCaNhan f = new frmThongTinCaNhan();
            f.ShowDialog();
        }

        private void nmSP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mnuDangXuat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuHeThong_Click(object sender, EventArgs e)
        {

        }

        private void tàiKhoảnAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            f.ShowDialog();
        }
    }
}
