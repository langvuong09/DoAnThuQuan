using System.Windows.Forms;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class PhieuNhapGUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tabQuanLyPhieuNhap = new TabControl();
            tabNhapHang = new TabPage();
            btnNhapHang = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            txtSoLuong = new TextBox();
            lblSoLuong = new Label();
            txtMaSanPham = new TextBox();
            lblMaSanPham = new Label();
            lblTitle = new Label();
            cboLoaiSanPham = new ComboBox();
            lblLoaiSanPham = new Label();
            dgvGioHang = new DataGridView();
            colmaSanPham = new DataGridViewTextBoxColumn();
            colTenSanPham = new DataGridViewTextBoxColumn();
            colLoai = new DataGridViewTextBoxColumn();
            colSoLuongNhap = new DataGridViewTextBoxColumn();
            colTien = new DataGridViewTextBoxColumn();
            dgvSanPham = new DataGridView();
            colmaSP = new DataGridViewTextBoxColumn();
            colTenSP = new DataGridViewTextBoxColumn();
            colSoLuongSP = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            tabPhieuNhap = new TabPage();
            dgvCTPhieuNhap = new DataGridView();
            colMa = new DataGridViewTextBoxColumn();
            colMaSanP = new DataGridViewTextBoxColumn();
            colTenLoai = new DataGridViewTextBoxColumn();
            colGiaTien = new DataGridViewTextBoxColumn();
            lblCTPhieuNhap = new Label();
            dgvPhieuNhap = new DataGridView();
            colMaPN = new DataGridViewTextBoxColumn();
            colNgayNhap = new DataGridViewTextBoxColumn();
            colTenNhanVien = new DataGridViewTextBoxColumn();
            colslSach = new DataGridViewTextBoxColumn();
            colslMayTinh = new DataGridViewTextBoxColumn();
            colslMayChieu = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            lblPhieuNhap = new Label();
            tabQuanLyPhieuNhap.SuspendLayout();
            tabNhapHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            tabPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTPhieuNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // tabQuanLyPhieuNhap
            // 
            tabQuanLyPhieuNhap.Controls.Add(tabNhapHang);
            tabQuanLyPhieuNhap.Controls.Add(tabPhieuNhap);
            tabQuanLyPhieuNhap.Location = new Point(3, 4);
            tabQuanLyPhieuNhap.Margin = new Padding(3, 4, 3, 4);
            tabQuanLyPhieuNhap.Name = "tabQuanLyPhieuNhap";
            tabQuanLyPhieuNhap.SelectedIndex = 0;
            tabQuanLyPhieuNhap.Size = new Size(1474, 1013);
            tabQuanLyPhieuNhap.TabIndex = 0;
            // 
            // tabNhapHang
            // 
            tabNhapHang.BackColor = Color.Snow;
            tabNhapHang.Controls.Add(btnNhapHang);
            tabNhapHang.Controls.Add(btnXoa);
            tabNhapHang.Controls.Add(btnThem);
            tabNhapHang.Controls.Add(txtSoLuong);
            tabNhapHang.Controls.Add(lblSoLuong);
            tabNhapHang.Controls.Add(txtMaSanPham);
            tabNhapHang.Controls.Add(lblMaSanPham);
            tabNhapHang.Controls.Add(lblTitle);
            tabNhapHang.Controls.Add(cboLoaiSanPham);
            tabNhapHang.Controls.Add(lblLoaiSanPham);
            tabNhapHang.Controls.Add(dgvGioHang);
            tabNhapHang.Controls.Add(dgvSanPham);
            tabNhapHang.Location = new Point(4, 29);
            tabNhapHang.Margin = new Padding(3, 4, 3, 4);
            tabNhapHang.Name = "tabNhapHang";
            tabNhapHang.Padding = new Padding(3, 4, 3, 4);
            tabNhapHang.Size = new Size(1466, 980);
            tabNhapHang.TabIndex = 0;
            tabNhapHang.Text = "Nhập hàng";
            // 
            // btnNhapHang
            // 
            btnNhapHang.BackColor = Color.MediumAquamarine;
            btnNhapHang.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhapHang.ForeColor = SystemColors.ButtonFace;
            btnNhapHang.Location = new Point(181, 571);
            btnNhapHang.Margin = new Padding(3, 5, 3, 5);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.Size = new Size(257, 59);
            btnNhapHang.TabIndex = 12;
            btnNhapHang.Text = "Nhập hàng";
            btnNhapHang.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.MediumAquamarine;
            btnXoa.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = SystemColors.ButtonFace;
            btnXoa.Location = new Point(365, 492);
            btnXoa.Margin = new Padding(3, 5, 3, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(143, 59);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumAquamarine;
            btnThem.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.ButtonFace;
            btnThem.Location = new Point(101, 492);
            btnThem.Margin = new Padding(3, 5, 3, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(143, 59);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(215, 265);
            txtSoLuong.Margin = new Padding(3, 4, 3, 4);
            txtSoLuong.Multiline = true;
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(362, 36);
            txtSoLuong.TabIndex = 9;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSoLuong.Location = new Point(64, 273);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(145, 28);
            lblSoLuong.TabIndex = 8;
            lblSoLuong.Text = "Số lượng nhập:";
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Location = new Point(215, 171);
            txtMaSanPham.Margin = new Padding(3, 4, 3, 4);
            txtMaSanPham.Multiline = true;
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(362, 36);
            txtMaSanPham.TabIndex = 7;
            // 
            // lblMaSanPham
            // 
            lblMaSanPham.AutoSize = true;
            lblMaSanPham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaSanPham.Location = new Point(64, 179);
            lblMaSanPham.Name = "lblMaSanPham";
            lblMaSanPham.Size = new Size(133, 28);
            lblMaSanPham.TabIndex = 6;
            lblMaSanPham.Text = "Mã sản phẩm:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(217, 37);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(216, 37);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Nhập sản phẩm";
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Items.AddRange(new object[] { "Sách", "Máy tính", "Máy chiếu" });
            cboLoaiSanPham.Location = new Point(846, 37);
            cboLoaiSanPham.Margin = new Padding(3, 4, 3, 4);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(490, 36);
            cboLoaiSanPham.TabIndex = 3;
            // 
            // lblLoaiSanPham
            // 
            lblLoaiSanPham.AutoSize = true;
            lblLoaiSanPham.Location = new Point(697, 47);
            lblLoaiSanPham.Name = "lblLoaiSanPham";
            lblLoaiSanPham.Size = new Size(108, 20);
            lblLoaiSanPham.TabIndex = 2;
            lblLoaiSanPham.Text = "Loại sản phẩm:";
            // 
            // dgvGioHang
            // 
            dgvGioHang.AllowUserToAddRows = false;
            dgvGioHang.AllowUserToDeleteRows = false;
            dgvGioHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGioHang.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(101, 224, 199);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvGioHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGioHang.ColumnHeadersHeight = 29;
            dgvGioHang.Columns.AddRange(new DataGridViewColumn[] { colmaSanPham, colTenSanPham, colLoai, colSoLuongNhap, colTien });
            dgvGioHang.EnableHeadersVisualStyles = false;
            dgvGioHang.Location = new Point(0, 664);
            dgvGioHang.Margin = new Padding(3, 4, 3, 4);
            dgvGioHang.MultiSelect = false;
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.ReadOnly = true;
            dgvGioHang.RowHeadersWidth = 51;
            dgvGioHang.Size = new Size(1462, 297);
            dgvGioHang.TabIndex = 1;
            // 
            // colmaSanPham
            // 
            colmaSanPham.HeaderText = "Mã sản phẩm";
            colmaSanPham.MinimumWidth = 6;
            colmaSanPham.Name = "colmaSanPham";
            colmaSanPham.ReadOnly = true;
            // 
            // colTenSanPham
            // 
            colTenSanPham.HeaderText = "Tên sản phẩm";
            colTenSanPham.MinimumWidth = 6;
            colTenSanPham.Name = "colTenSanPham";
            colTenSanPham.ReadOnly = true;
            // 
            // colLoai
            // 
            colLoai.HeaderText = "Loại sản phẩm";
            colLoai.MinimumWidth = 6;
            colLoai.Name = "colLoai";
            colLoai.ReadOnly = true;
            // 
            // colSoLuongNhap
            // 
            colSoLuongNhap.HeaderText = "Số lượng nhập";
            colSoLuongNhap.MinimumWidth = 6;
            colSoLuongNhap.Name = "colSoLuongNhap";
            colSoLuongNhap.ReadOnly = true;
            // 
            // colTien
            // 
            colTien.HeaderText = "Thành tiền";
            colTien.MinimumWidth = 6;
            colTien.Name = "colTien";
            colTien.ReadOnly = true;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(101, 224, 199);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSanPham.ColumnHeadersHeight = 29;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { colmaSP, colTenSP, colSoLuongSP, colThanhTien });
            dgvSanPham.EnableHeadersVisualStyles = false;
            dgvSanPham.Location = new Point(641, 109);
            dgvSanPham.Margin = new Padding(3, 4, 3, 4);
            dgvSanPham.MultiSelect = false;
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(775, 520);
            dgvSanPham.TabIndex = 0;
            // 
            // colmaSP
            // 
            colmaSP.HeaderText = "Mã sản phẩm";
            colmaSP.MinimumWidth = 6;
            colmaSP.Name = "colmaSP";
            colmaSP.ReadOnly = true;
            // 
            // colTenSP
            // 
            colTenSP.HeaderText = "Tên sản phẩm";
            colTenSP.MinimumWidth = 6;
            colTenSP.Name = "colTenSP";
            colTenSP.ReadOnly = true;
            // 
            // colSoLuongSP
            // 
            colSoLuongSP.HeaderText = "Số lượng";
            colSoLuongSP.MinimumWidth = 6;
            colSoLuongSP.Name = "colSoLuongSP";
            colSoLuongSP.ReadOnly = true;
            // 
            // colThanhTien
            // 
            colThanhTien.HeaderText = "Giá";
            colThanhTien.MinimumWidth = 6;
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // tabPhieuNhap
            // 
            tabPhieuNhap.BackColor = Color.Snow;
            tabPhieuNhap.Controls.Add(dgvCTPhieuNhap);
            tabPhieuNhap.Controls.Add(lblCTPhieuNhap);
            tabPhieuNhap.Controls.Add(dgvPhieuNhap);
            tabPhieuNhap.Controls.Add(lblPhieuNhap);
            tabPhieuNhap.Location = new Point(4, 29);
            tabPhieuNhap.Margin = new Padding(3, 4, 3, 4);
            tabPhieuNhap.Name = "tabPhieuNhap";
            tabPhieuNhap.Padding = new Padding(3, 4, 3, 4);
            tabPhieuNhap.Size = new Size(1466, 980);
            tabPhieuNhap.TabIndex = 1;
            tabPhieuNhap.Text = "Phiếu nhập";
            // 
            // dgvCTPhieuNhap
            // 
            dgvCTPhieuNhap.AllowUserToAddRows = false;
            dgvCTPhieuNhap.AllowUserToDeleteRows = false;
            dgvCTPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTPhieuNhap.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(101, 224, 199);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvCTPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCTPhieuNhap.ColumnHeadersHeight = 29;
            dgvCTPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { colMa, colMaSanP, colTenLoai, colGiaTien });
            dgvCTPhieuNhap.EnableHeadersVisualStyles = false;
            dgvCTPhieuNhap.Location = new Point(0, 653);
            dgvCTPhieuNhap.Margin = new Padding(3, 4, 3, 4);
            dgvCTPhieuNhap.MultiSelect = false;
            dgvCTPhieuNhap.Name = "dgvCTPhieuNhap";
            dgvCTPhieuNhap.ReadOnly = true;
            dgvCTPhieuNhap.RowHeadersWidth = 51;
            dgvCTPhieuNhap.Size = new Size(1462, 308);
            dgvCTPhieuNhap.TabIndex = 3;
            // 
            // colMa
            // 
            colMa.HeaderText = "Mã PN";
            colMa.MinimumWidth = 6;
            colMa.Name = "colMa";
            colMa.ReadOnly = true;
            // 
            // colMaSanP
            // 
            colMaSanP.HeaderText = "Mã Sản phẩm";
            colMaSanP.MinimumWidth = 6;
            colMaSanP.Name = "colMaSanP";
            colMaSanP.ReadOnly = true;
            // 
            // colTenLoai
            // 
            colTenLoai.HeaderText = "Loại sản phẩm";
            colTenLoai.MinimumWidth = 6;
            colTenLoai.Name = "colTenLoai";
            colTenLoai.ReadOnly = true;
            // 
            // colGiaTien
            // 
            colGiaTien.HeaderText = "Thành tiền";
            colGiaTien.MinimumWidth = 6;
            colGiaTien.Name = "colGiaTien";
            colGiaTien.ReadOnly = true;
            // 
            // lblCTPhieuNhap
            // 
            lblCTPhieuNhap.AutoSize = true;
            lblCTPhieuNhap.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCTPhieuNhap.Location = new Point(589, 581);
            lblCTPhieuNhap.Name = "lblCTPhieuNhap";
            lblCTPhieuNhap.Size = new Size(260, 37);
            lblCTPhieuNhap.TabIndex = 2;
            lblCTPhieuNhap.Text = "Chi tiết phiếu nhập";
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.AllowUserToAddRows = false;
            dgvPhieuNhap.AllowUserToDeleteRows = false;
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhap.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(101, 224, 199);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPhieuNhap.ColumnHeadersHeight = 29;
            dgvPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { colMaPN, colNgayNhap, colTenNhanVien, colslSach, colslMayTinh, colslMayChieu, colTongTien });
            dgvPhieuNhap.EnableHeadersVisualStyles = false;
            dgvPhieuNhap.Location = new Point(0, 96);
            dgvPhieuNhap.Margin = new Padding(3, 4, 3, 4);
            dgvPhieuNhap.MultiSelect = false;
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.ReadOnly = true;
            dgvPhieuNhap.RowHeadersWidth = 51;
            dgvPhieuNhap.Size = new Size(1462, 443);
            dgvPhieuNhap.TabIndex = 1;
            // 
            // colMaPN
            // 
            colMaPN.HeaderText = "Mã PN";
            colMaPN.MinimumWidth = 6;
            colMaPN.Name = "colMaPN";
            colMaPN.ReadOnly = true;
            // 
            // colNgayNhap
            // 
            colNgayNhap.HeaderText = "Ngày nhập";
            colNgayNhap.MinimumWidth = 6;
            colNgayNhap.Name = "colNgayNhap";
            colNgayNhap.ReadOnly = true;
            // 
            // colTenNhanVien
            // 
            colTenNhanVien.HeaderText = "Tên nhân viên";
            colTenNhanVien.MinimumWidth = 6;
            colTenNhanVien.Name = "colTenNhanVien";
            colTenNhanVien.ReadOnly = true;
            // 
            // colslSach
            // 
            colslSach.HeaderText = "SL sách";
            colslSach.MinimumWidth = 6;
            colslSach.Name = "colslSach";
            colslSach.ReadOnly = true;
            // 
            // colslMayTinh
            // 
            colslMayTinh.HeaderText = "SL máy tính";
            colslMayTinh.MinimumWidth = 6;
            colslMayTinh.Name = "colslMayTinh";
            colslMayTinh.ReadOnly = true;
            // 
            // colslMayChieu
            // 
            colslMayChieu.HeaderText = "SL máy chiếu";
            colslMayChieu.MinimumWidth = 6;
            colslMayChieu.Name = "colslMayChieu";
            colslMayChieu.ReadOnly = true;
            // 
            // colTongTien
            // 
            colTongTien.HeaderText = "Tổng tiền";
            colTongTien.MinimumWidth = 6;
            colTongTien.Name = "colTongTien";
            colTongTien.ReadOnly = true;
            // 
            // lblPhieuNhap
            // 
            lblPhieuNhap.AutoSize = true;
            lblPhieuNhap.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhieuNhap.Location = new Point(643, 28);
            lblPhieuNhap.Name = "lblPhieuNhap";
            lblPhieuNhap.Size = new Size(160, 37);
            lblPhieuNhap.TabIndex = 0;
            lblPhieuNhap.Text = "Phiếu nhập";
            // 
            // PhieuNhapGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabQuanLyPhieuNhap);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PhieuNhapGUI";
            Size = new Size(1474, 1013);
            tabQuanLyPhieuNhap.ResumeLayout(false);
            tabNhapHang.ResumeLayout(false);
            tabNhapHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            tabPhieuNhap.ResumeLayout(false);
            tabPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTPhieuNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabQuanLyPhieuNhap;
        private TabPage tabNhapHang;
        private TabPage tabPhieuNhap;
        private Label lblLoaiSanPham;
        private DataGridView dgvGioHang;
        private DataGridViewTextBoxColumn colmaSP;
        private DataGridViewTextBoxColumn colTenSP;
        private DataGridViewTextBoxColumn colSoLuongSP;
        private DataGridViewTextBoxColumn colThanhTien;
        private DataGridView dgvSanPham;
        private DataGridViewTextBoxColumn colmaSanPham;
        private DataGridViewTextBoxColumn colTenSanPham;
        private DataGridViewTextBoxColumn colSoLuongNhap;
        private DataGridViewTextBoxColumn colLoai;
        private DataGridViewTextBoxColumn colTien;
        private ComboBox cboLoaiSanPham;
        private Label lblTitle;
        private TextBox txtSoLuong;
        private Label lblSoLuong;
        private TextBox txtMaSanPham;
        private Label lblMaSanPham;
        private Button btnXoa;
        private Button btnThem;
        private Button btnNhapHang;
        private DataGridView dgvCTPhieuNhap;
        private DataGridViewTextBoxColumn colMa;
        private DataGridViewTextBoxColumn colMaSanP;
        private DataGridViewTextBoxColumn colTenLoai;
        private DataGridViewTextBoxColumn colGiaTien;
        private Label lblCTPhieuNhap;
        private DataGridView dgvPhieuNhap;
        private DataGridViewTextBoxColumn colMaPN;
        private DataGridViewTextBoxColumn colNgayNhap;
        private DataGridViewTextBoxColumn colTenNhanVien;
        private DataGridViewTextBoxColumn colslSach;
        private DataGridViewTextBoxColumn colslMayTinh;
        private DataGridViewTextBoxColumn colslMayChieu;
        private DataGridViewTextBoxColumn colTongTien;
        private Label lblPhieuNhap;
    }
}
