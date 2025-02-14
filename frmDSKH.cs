using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Form_QLKhachHang
{
    public partial class frmDSKH : Form
    {
        public frmDSKH()
        {
            InitializeComponent();
            this.Load += frmDSKH_Load; // Đảm bảo sự kiện được gọi
        }
        private void frmDSKH_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhachHang(); // Nạp dữ liệu từ CSDL
        }
        //

        private void LoadDanhSachKhachHang()
        {
            DataTable dt = DatabaseHelper.GetDanhSachKhachHang();
            dgvKhachHang.AutoGenerateColumns = false; // Tự động tạo cột
            dgvKhachHang.DataSource = dt;
            MessageBox.Show($"Số dòng lấy được từ SQL: {dt.Rows.Count}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dgvKhachHang.DataSource = dt;
                MessageBox.Show($"Đã tải {dt.Rows.Count} khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
