using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace hoadon
{

    public partial class frmHoaDonKH : Form
    {
        private string connectionString = "Data Source=DESKTOP-AOFC2NB\\SQLEXPRESS;Initial Catalog=QuanLyCHNoiThat;Integrated Security=True";
        public frmHoaDonKH()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                Dictionary<string, (ComboBox, string, string)> queries = new Dictionary<string, (ComboBox, string, string)>
        {
            { "SELECT MaNV, TenNV FROM NhanVien", (cmbMaNV, "TenNV", "MaNV") },
            { "SELECT MaKH, TenKH FROM KhachHang", (cmbMaKH, "TenKH", "MaKH") },
            { "SELECT MaHang, TenHang FROM SanPham", (cmbMaHang, "TenHang", "MaHang") }
        };

                foreach (var query in queries)
                {
                    SqlDataAdapter da = new SqlDataAdapter(query.Key, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    query.Value.Item1.DataSource = dt;
                    query.Value.Item1.DisplayMember = query.Value.Item2;
                    query.Value.Item1.ValueMember = query.Value.Item3;
                }
            }
        }

        private void frmHoaDonKH_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            LoadNhanVien();
            LoadSanPham();
            LoadHoaDon();
        }
        // Load danh sách khách hàng vào combobox
        private void LoadKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaKH, TenKH FROM KhachHang", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbMaKH.DataSource = dt;
                cmbMaKH.DisplayMember = "TenKH";
                cmbMaKH.ValueMember = "MaKH";
            }
        }

        // Load danh sách nhân viên
        private void LoadNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaNV, TenNV FROM NhanVien", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbMaNV.DataSource = dt;
                cmbMaNV.DisplayMember = "TenNV";
                cmbMaNV.ValueMember = "MaNV";
            }
        }
        // Load danh sách sản phẩm
        private void LoadSanPham()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaHang, TenHang, DonGia FROM SanPham", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbMaHang.DataSource = dt;
                cmbMaHang.DisplayMember = "TenHang";
                cmbMaHang.ValueMember = "MaHang";
            }
        }

        // Load danh sách hóa đơn
        private void LoadHoaDon()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoaDon", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvChiTiet.DataSource = dt;
            }
        }
        // Nút thêm hóa đơn
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO HoaDon (NgayBan, MaNV, MaKH, TongTien) VALUES (@NgayBan, @MaNV, @MaKH, 0)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NgayBan", dtpNgayBan.Value);
                        cmd.Parameters.AddWithValue("@MaNV", cmbMaNV.SelectedValue);
                        cmd.Parameters.AddWithValue("@MaKH", cmbMaKH.SelectedValue);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo");
                    LoadHoaDon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
                }
            }
        }

        // Nút lưu hóa đơn
        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string queryHD = "INSERT INTO HoaDon (NgayBan, MaNV, MaKH, TongTien) OUTPUT INSERTED.MaHD VALUES (@NgayBan, @MaNV, @MaKH, 0)";
                    SqlCommand cmdHD = new SqlCommand(queryHD, conn, transaction);
                    cmdHD.Parameters.AddWithValue("@NgayBan", dtpNgayBan.Value);
                    cmdHD.Parameters.AddWithValue("@MaNV", cmbMaNV.SelectedValue);
                    cmdHD.Parameters.AddWithValue("@MaKH", cmbMaKH.SelectedValue);
                    int maHD = (int)cmdHD.ExecuteScalar();

                    foreach (DataGridViewRow row in dgvChiTiet.Rows)
                    {
                        if (row.Cells["MaHang"].Value != null)
                        {
                            string queryCTHD = "INSERT INTO ChiTietHoaDon (MaHD, MaHang, SoLuong, GiamGia, ThanhTien) VALUES (@MaHD, @MaHang, @SoLuong, @GiamGia, @ThanhTien)";
                            SqlCommand cmdCTHD = new SqlCommand(queryCTHD, conn, transaction);
                            cmdCTHD.Parameters.AddWithValue("@MaHD", maHD);
                            cmdCTHD.Parameters.AddWithValue("@MaHang", row.Cells["MaHang"].Value);
                            cmdCTHD.Parameters.AddWithValue("@SoLuong", row.Cells["SoLuong"].Value);
                            cmdCTHD.Parameters.AddWithValue("@GiamGia", row.Cells["GiamGia"].Value ?? 0);
                            cmdCTHD.Parameters.AddWithValue("@ThanhTien", row.Cells["ThanhTien"].Value);
                            cmdCTHD.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Lưu hóa đơn thành công!", "Thông báo");
                    LoadHoaDon();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi khi lưu hóa đơn: " + ex.Message, "Lỗi");
                }
            }
        }

        // Nút hủy hóa đơn
        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM HoaDon WHERE MaHD = @MaHD";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo");
                    LoadHoaDon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
                }
            }
        }


        // Nút in hóa đơn
        private void btnInHD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In hóa đơn thành công!", "Thông báo");
        }
        // Nút đóng form
        private void btnDongHD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Nút tìm kiếm hóa đơn
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoaDon WHERE MaHD = @MaHD", conn);
                da.SelectCommand.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvChiTiet.DataSource = dt;
            }
        }
    }
}
