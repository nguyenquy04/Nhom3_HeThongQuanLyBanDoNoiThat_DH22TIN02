using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using hoadon;
using QuanLyBanHang.Form_Login;
using QuanLyBanHang.Form_NhanVien;
using QuanLyBanHang.Form_QLKhachHang;

namespace QuanLyBanHang
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());

        }
    }
}
