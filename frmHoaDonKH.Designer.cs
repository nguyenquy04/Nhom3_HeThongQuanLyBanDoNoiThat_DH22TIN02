namespace hoadon
{
    partial class frmHoaDonKH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.cmbMaHang = new System.Windows.Forms.ComboBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.GiayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMaKH = new System.Windows.Forms.ComboBox();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnDongHD = new System.Windows.Forms.Button();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMKH = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnHuyHD = new System.Windows.Forms.Button();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbThongTinChung = new System.Windows.Forms.GroupBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.lblHDKH = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.lblMaHang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grbThongTinChung.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(523, 77);
            this.txtThanhtien.Margin = new System.Windows.Forms.Padding(2);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(100, 22);
            this.txtThanhtien.TabIndex = 11;
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(321, 43);
            this.txtTenhang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(88, 22);
            this.txtTenhang.TabIndex = 10;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(321, 77);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(88, 22);
            this.txtGiamGia.TabIndex = 9;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(88, 77);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(88, 22);
            this.txtSoluong.TabIndex = 8;
            // 
            // cmbMaHang
            // 
            this.cmbMaHang.FormattingEnabled = true;
            this.cmbMaHang.Location = new System.Drawing.Point(88, 43);
            this.cmbMaHang.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaHang.Name = "cmbMaHang";
            this.cmbMaHang.Size = new System.Drawing.Size(88, 23);
            this.cmbMaHang.TabIndex = 7;
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GiayID,
            this.Giay,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgvChiTiet.Location = new System.Drawing.Point(11, 103);
            this.dgvChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.RowTemplate.Height = 24;
            this.dgvChiTiet.Size = new System.Drawing.Size(663, 147);
            this.dgvChiTiet.TabIndex = 6;
            // 
            // GiayID
            // 
            this.GiayID.HeaderText = "Mã hàng";
            this.GiayID.MinimumWidth = 6;
            this.GiayID.Name = "GiayID";
            this.GiayID.Width = 125;
            // 
            // Giay
            // 
            this.Giay.HeaderText = "Tên hàng ";
            this.Giay.MinimumWidth = 6;
            this.Giay.Name = "Giay";
            this.Giay.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng ";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá ";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền ";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 125;
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.Location = new System.Drawing.Point(516, 23);
            this.cmbMaKH.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(107, 23);
            this.cmbMaKH.TabIndex = 18;
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(107, 88);
            this.cmbMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(176, 23);
            this.cmbMaNV.TabIndex = 17;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(516, 121);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(109, 22);
            this.txtDienThoai.TabIndex = 16;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(516, 88);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(109, 22);
            this.txtDiaChi.TabIndex = 15;
            // 
            // btnDongHD
            // 
            this.btnDongHD.Location = new System.Drawing.Point(619, 478);
            this.btnDongHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnDongHD.Name = "btnDongHD";
            this.btnDongHD.Size = new System.Drawing.Size(65, 36);
            this.btnDongHD.TabIndex = 26;
            this.btnDongHD.Text = "ĐÓNG";
            this.btnDongHD.UseVisualStyleBackColor = true;
            this.btnDongHD.Click += new System.EventHandler(this.btnDongHD_Click);
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(253, 81);
            this.lblGiamGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(66, 15);
            this.lblGiamGia.TabIndex = 3;
            this.lblGiamGia.Text = "Giảm giá %";
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Location = new System.Drawing.Point(260, 48);
            this.lblTenHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(58, 15);
            this.lblTenHang.TabIndex = 2;
            this.lblTenHang.Text = "Tên hàng";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(26, 80);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(58, 15);
            this.lblSoLuong.TabIndex = 1;
            this.lblSoLuong.Text = "Số lượng ";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(516, 55);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(107, 22);
            this.txtTenKH.TabIndex = 14;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(107, 23);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(176, 22);
            this.txtMaHD.TabIndex = 12;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(107, 123);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(176, 22);
            this.txtTenNV.TabIndex = 11;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Location = new System.Drawing.Point(107, 57);
            this.dtpNgayBan.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(176, 22);
            this.dtpNgayBan.TabIndex = 9;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(461, 46);
            this.lblDonGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(49, 15);
            this.lblDonGia.TabIndex = 4;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(399, 123);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(77, 15);
            this.lblSDT.TabIndex = 8;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(399, 57);
            this.lblTenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(93, 15);
            this.lblTenKH.TabIndex = 6;
            this.lblTenKH.Text = "Tên khách hàng";
            // 
            // lblMKH
            // 
            this.lblMKH.AutoSize = true;
            this.lblMKH.Location = new System.Drawing.Point(399, 29);
            this.lblMKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMKH.Name = "lblMKH";
            this.lblMKH.Size = new System.Drawing.Size(90, 15);
            this.lblMKH.TabIndex = 5;
            this.lblMKH.Text = "Mã khách hàng";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(447, 80);
            this.lblThanhTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(65, 15);
            this.lblThanhTien.TabIndex = 5;
            this.lblThanhTien.Text = "Thành tiền";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(399, 90);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(47, 15);
            this.lblDiaChi.TabIndex = 7;
            this.lblDiaChi.Text = "Địa chỉ ";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(10, 123);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(84, 15);
            this.lblTenNV.TabIndex = 4;
            this.lblTenNV.Text = "Tên nhân viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimkiem);
            this.panel1.Controls.Add(this.cboMaHD);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 522);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 46);
            this.panel1.TabIndex = 24;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(435, 13);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(65, 22);
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm ";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // cboMaHD
            // 
            this.cboMaHD.FormattingEnabled = true;
            this.cboMaHD.Location = new System.Drawing.Point(251, 13);
            this.cboMaHD.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(107, 23);
            this.cboMaHD.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã hóa đơn";
            // 
            // btnThemHD
            // 
            this.btnThemHD.Location = new System.Drawing.Point(22, 477);
            this.btnThemHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(65, 36);
            this.btnThemHD.TabIndex = 20;
            this.btnThemHD.Text = "THÊM";
            this.btnThemHD.UseVisualStyleBackColor = true;
            // 
            // btnInHD
            // 
            this.btnInHD.Location = new System.Drawing.Point(469, 478);
            this.btnInHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(94, 36);
            this.btnInHD.TabIndex = 23;
            this.btnInHD.Text = "IN HÓA ĐƠN";
            this.btnInHD.UseVisualStyleBackColor = true;
            // 
            // btnHuyHD
            // 
            this.btnHuyHD.Location = new System.Drawing.Point(301, 478);
            this.btnHuyHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyHD.Name = "btnHuyHD";
            this.btnHuyHD.Size = new System.Drawing.Size(107, 36);
            this.btnHuyHD.TabIndex = 22;
            this.btnHuyHD.Text = "HỦY HÓA ĐƠN";
            this.btnHuyHD.UseVisualStyleBackColor = true;
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHD.Location = new System.Drawing.Point(139, 478);
            this.btnLuuHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(110, 36);
            this.btnLuuHD.TabIndex = 21;
            this.btnLuuHD.Text = "LƯU HÓA ĐƠN";
            this.btnLuuHD.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, -2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grbThongTinChung);
            this.splitContainer1.Panel1.Controls.Add(this.lblHDKH);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(693, 471);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 25;
            // 
            // grbThongTinChung
            // 
            this.grbThongTinChung.Controls.Add(this.cmbMaKH);
            this.grbThongTinChung.Controls.Add(this.cmbMaNV);
            this.grbThongTinChung.Controls.Add(this.txtDienThoai);
            this.grbThongTinChung.Controls.Add(this.txtDiaChi);
            this.grbThongTinChung.Controls.Add(this.txtTenKH);
            this.grbThongTinChung.Controls.Add(this.txtMaHD);
            this.grbThongTinChung.Controls.Add(this.txtTenNV);
            this.grbThongTinChung.Controls.Add(this.dtpNgayBan);
            this.grbThongTinChung.Controls.Add(this.lblSDT);
            this.grbThongTinChung.Controls.Add(this.lblDiaChi);
            this.grbThongTinChung.Controls.Add(this.lblTenKH);
            this.grbThongTinChung.Controls.Add(this.lblMKH);
            this.grbThongTinChung.Controls.Add(this.lblTenNV);
            this.grbThongTinChung.Controls.Add(this.lblMaHD);
            this.grbThongTinChung.Controls.Add(this.lblMaNV);
            this.grbThongTinChung.Controls.Add(this.lblNgayBan);
            this.grbThongTinChung.Location = new System.Drawing.Point(8, 40);
            this.grbThongTinChung.Margin = new System.Windows.Forms.Padding(2);
            this.grbThongTinChung.Name = "grbThongTinChung";
            this.grbThongTinChung.Padding = new System.Windows.Forms.Padding(2);
            this.grbThongTinChung.Size = new System.Drawing.Size(683, 156);
            this.grbThongTinChung.TabIndex = 1;
            this.grbThongTinChung.TabStop = false;
            this.grbThongTinChung.Text = "Thông tin chung ";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(10, 29);
            this.lblMaHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(72, 15);
            this.lblMaHD.TabIndex = 1;
            this.lblMaHD.Text = "Mã hóa đơn";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(10, 88);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(84, 15);
            this.lblMaNV.TabIndex = 2;
            this.lblMaNV.Text = "Mã nhân viên ";
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.AutoSize = true;
            this.lblNgayBan.Location = new System.Drawing.Point(10, 57);
            this.lblNgayBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(62, 15);
            this.lblNgayBan.TabIndex = 3;
            this.lblNgayBan.Text = "Ngày bán ";
            // 
            // lblHDKH
            // 
            this.lblHDKH.AutoSize = true;
            this.lblHDKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDKH.ForeColor = System.Drawing.Color.Blue;
            this.lblHDKH.Location = new System.Drawing.Point(219, 14);
            this.lblHDKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHDKH.Name = "lblHDKH";
            this.lblHDKH.Size = new System.Drawing.Size(248, 24);
            this.lblHDKH.TabIndex = 0;
            this.lblHDKH.Text = "HÓA ĐƠN KHÁCH HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDongia);
            this.groupBox2.Controls.Add(this.txtThanhtien);
            this.groupBox2.Controls.Add(this.txtTenhang);
            this.groupBox2.Controls.Add(this.txtGiamGia);
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.cmbMaHang);
            this.groupBox2.Controls.Add(this.dgvChiTiet);
            this.groupBox2.Controls.Add(this.lblThanhTien);
            this.groupBox2.Controls.Add(this.lblDonGia);
            this.groupBox2.Controls.Add(this.lblGiamGia);
            this.groupBox2.Controls.Add(this.lblTenHang);
            this.groupBox2.Controls.Add(this.lblSoLuong);
            this.groupBox2.Controls.Add(this.lblMaHang);
            this.groupBox2.Location = new System.Drawing.Point(10, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(681, 262);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng ";
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(523, 46);
            this.txtDongia.Margin = new System.Windows.Forms.Padding(2);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(100, 22);
            this.txtDongia.TabIndex = 12;
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Location = new System.Drawing.Point(24, 46);
            this.lblMaHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(58, 15);
            this.lblMaHang.TabIndex = 0;
            this.lblMaHang.Text = "Mã hàng ";
            // 
            // frmHoaDonKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 568);
            this.Controls.Add(this.btnDongHD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.btnHuyHD);
            this.Controls.Add(this.btnLuuHD);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHoaDonKH";
            this.Text = "Hóa Đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grbThongTinChung.ResumeLayout(false);
            this.grbThongTinChung.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.ComboBox cmbMaHang;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiayID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.ComboBox cmbMaKH;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnDongHD;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMKH;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.ComboBox cboMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnHuyHD;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grbThongTinChung;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.Label lblHDKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.Label lblMaHang;
    }
}

