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

namespace QuanLyBanHang.Form_QLKhachHang
{
    public partial class frmThemKHMoi : Form
    {
        public frmThemKHMoi()
        {
            InitializeComponent();
            this.Load += frmThemKHMoi_Load; // Gán sự kiện Load cho Form
        }
        private void frmThemKHMoi_Load(object sender, EventArgs e)
        {
            cbCapKH.Items.Clear(); // Xóa trước để tránh trùng dữ liệu
            cbCapKH.Items.Add("Khách Mới");
            cbCapKH.Items.Add("Khách Thường");
            cbCapKH.Items.Add("Khách VIP");

            // Đặt mục mặc định
            if (cbCapKH.Items.Count > 0)
                cbCapKH.SelectedIndex = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ form
            string tenKH = txtTenKH.Text.Trim();
            string soDienThoai = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string capKH = cbCapKH.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tenKH) || string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(capKH))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm vào CSDL
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AOFC2NB\\SQLEXPRESS;Initial Catalog=QuanLyCHNoiThat;Integrated Security=True"))
            {
                string query = "INSERT INTO KhachHang (TenKH, SoDienThoai, DiaChi, CapKH) VALUES (@TenKH, @SDT, @DiaChi, @CapKH)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenKH", tenKH);
                    cmd.Parameters.AddWithValue("@SDT", soDienThoai);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    cmd.Parameters.AddWithValue("@CapKH", capKH);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

            MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Mở form danh sách khách hàng
            frmDSKH frm = new frmDSKH();
            frm.ShowDialog();
        }
        private void frmThemKHMoi_Load_1(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
