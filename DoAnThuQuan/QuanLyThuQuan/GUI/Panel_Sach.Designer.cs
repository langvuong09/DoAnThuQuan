namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    partial class Panel_Sach
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
        private void AddControls()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Sach));
            dgvSach = new DataGridView();
            colMaSach = new DataGridViewTextBoxColumn();
            colTenSach = new DataGridViewTextBoxColumn(); 
            colTheLoai = new DataGridViewTextBoxColumn();
            colTacGia = new DataGridViewTextBoxColumn();
            colMaKe = new DataGridViewTextBoxColumn();
            colMota = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            colTinhTrangSach = new DataGridViewTextBoxColumn();
            
            lblMaSach = new Label();
            txtMaSach = new TextBox();
            lblTenSach = new Label();
            txtTenSach = new TextBox();
            lblTheLoai = new Label();
            lblTacGia = new Label();
            lblMaKe = new Label();
            cboMaKe = new ComboBox();
            lblMoTa = new Label();
            txtMoTa = new TextBox();
            lblThanhTien = new Label();
            txtThanhTien = new TextBox();
            cboTheLoai = new ComboBox();
            txtDocGia = new TextBox();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            btnTimKiem = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            btnCapNhat = new Button();
            button_Nhap = new Button();
            pnlThongTinSach = new Panel();
            button_DSPSach = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            pnlThongTinSach.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSach
            // 
            dgvSach.AllowUserToAddRows = false;
            dgvSach.AllowUserToDeleteRows = false;
            dgvSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSach.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(101, 224, 199);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSach.Columns.AddRange(new DataGridViewColumn[] { colMaSach, colTenSach, colTheLoai, colTacGia, colMaKe, colMota, colThanhTien, colTinhTrangSach });
            dgvSach.EnableHeadersVisualStyles = false;
            dgvSach.Location = new Point(34, 411);
            dgvSach.MultiSelect = false;
            dgvSach.Name = "dgvSach";
            dgvSach.ReadOnly = true;
            dgvSach.Size = new Size(1230, 327);
            dgvSach.TabIndex = 1;
            // 
            // colMaSach
            // 
            colMaSach.HeaderText = "Mã sách";
            colMaSach.Name = "colMaSach";
            colMaSach.ReadOnly = true;
            // 
            // colTenSach
            // 
            colTenSach.HeaderText = "Tên Sách";
            colTenSach.Name = "colTenSach";
            colTenSach.ReadOnly = true;
            // 
            // colTacGia
            // 
            colTacGia.HeaderText = "Tác Giả";
            colTacGia.Name = "colTacGia";
            colTacGia.ReadOnly = true;
            // 
            // colTheLoai
            // 
            colTheLoai.HeaderText = "Thể loại";
            colTheLoai.Name = "colTheLoai";
            colTheLoai.ReadOnly = true;
            // 
            // colTinhTrangSach
            // 
            colTinhTrangSach.HeaderText = "Tình trạng";
            colTinhTrangSach.Name = "colTinhTrangSach";
            colTinhTrangSach.ReadOnly = true;
            // 
            // colMaKe
            // 
            colMaKe.HeaderText = "Mã Kệ";
            colMaKe.Name = "colMaKe";
            colMaKe.ReadOnly = true;
            // 
            // colMoTa
            // 
            colMota.HeaderText = "Mô tả";
            colMota.Name = "colMoTa";
            colMota.ReadOnly = true;
            // 
            // colThanhTien
            // 
            colThanhTien.HeaderText = "Giá";
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // lblMaSach
            // 
            lblMaSach.AutoSize = true;
            lblMaSach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaSach.Location = new Point(185, 19);
            lblMaSach.Name = "lblMaSach";
            lblMaSach.Size = new Size(72, 21);
            lblMaSach.TabIndex = 1;
            lblMaSach.Text = "Mã sách";
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(306, 16);
            txtMaSach.Multiline = true;
            txtMaSach.Name = "txtMaSach";
            txtMaSach.Size = new Size(265, 37);
            txtMaSach.TabIndex = 2;
            txtMaSach.ReadOnly = true;
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenSach.Location = new Point(185, 63);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(75, 21);
            lblTenSach.TabIndex = 3;
            lblTenSach.Text = "Tên sách";
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(306, 60);
            txtTenSach.Multiline = true;
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(265, 35);
            txtTenSach.TabIndex = 4;
            // 
            // lblTheLoai
            // 
            lblTheLoai.AutoSize = true;
            lblTheLoai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTheLoai.Location = new Point(185, 109);
            lblTheLoai.Name = "lblTheLoai";
            lblTheLoai.Size = new Size(71, 21);
            lblTheLoai.TabIndex = 5;
            lblTheLoai.Text = "Thể loại";
            // 
            // lblTacGia
            // 
            lblTacGia.AutoSize = true;
            lblTacGia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTacGia.Location = new Point(185, 158);
            lblTacGia.Name = "lblTacGia";
            lblTacGia.Size = new Size(63, 21);
            lblTacGia.TabIndex = 7;
            lblTacGia.Text = "Tác giả";
            // 
            // lblMaKe
            // 
            lblMaKe.AutoSize = true;
            lblMaKe.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaKe.Location = new Point(185, 208);
            lblMaKe.Name = "lblMaKe";
            lblMaKe.Size = new Size(56, 21);
            lblMaKe.TabIndex = 9;
            lblMaKe.Text = "Mã kệ";
            // 
            // txtMaKe
            // 
            cboMaKe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMaKe.FormattingEnabled = true;
            cboMaKe.Location = new Point(306, 203);
            cboMaKe.Name = "cboTheLoai";
            cboMaKe.Size = new Size(265, 35);
            cboMaKe.TabIndex = 10;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMoTa.Location = new Point(185, 257);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(72, 21);
            lblMoTa.TabIndex = 11;
            lblMoTa.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(306, 244);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(265, 34);
            txtMoTa.TabIndex = 12;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThanhTien.Location = new Point(185, 298);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(72, 21);
            lblThanhTien.TabIndex = 11;
            lblThanhTien.Text = "Giá";
            // 
            // txtthanhTien
            // 
            txtThanhTien.Location = new Point(306, 285);
            txtThanhTien.Multiline = true;
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(265, 34);
            txtThanhTien.TabIndex = 12;
            // 
            // cboTheLoai
            // 
            cboTheLoai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTheLoai.FormattingEnabled = true;
            cboTheLoai.Location = new Point(306, 111);
            cboTheLoai.Name = "cboTheLoai";
            cboTheLoai.Size = new Size(265, 29);
            cboTheLoai.TabIndex = 13;
            // 
            // txtTacGia
            // 
            txtDocGia.Multiline = true;
            txtDocGia.Location = new Point(306, 160);
            txtDocGia.Name = "txtTacGia";
            txtDocGia.Size = new Size(265, 29);
            txtDocGia.TabIndex = 14;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(832, 19);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(265, 43);
            txtTimKiem.TabIndex = 15;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimKiem.Location = new Point(715, 21);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(81, 21);
            lblTimKiem.TabIndex = 16;
            lblTimKiem.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.RosyBrown;
            btnTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.Location = new Point(1121, 16);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(89, 38);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.MediumAquamarine;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(715, 89);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(146, 62);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.MediumAquamarine;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(892, 88);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(146, 62);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.MediumAquamarine;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(1064, 88);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(146, 62);
            btnSua.TabIndex = 20;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.MediumAquamarine;
            btnNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhap.Location = new Point(715, 180);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(146, 62);
            btnNhap.TabIndex = 21;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = false;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.MediumAquamarine;
            btnXuat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuat.Image = (Image)resources.GetObject("btnXuat.Image");
            btnXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuat.Location = new Point(1064, 180);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(146, 62);
            btnXuat.TabIndex = 22;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnCapNhat.BackColor = Color.MediumAquamarine;
            btnCapNhat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.Image = (Image)resources.GetObject("btnCapNhat.Image");
            btnCapNhat.ImageAlign = ContentAlignment.MiddleLeft;
            btnCapNhat.Location = new Point(715, 180);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(146, 62);
            btnCapNhat.TabIndex = 23;
            btnCapNhat.Text = "Reset";
            btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // button_Nhap
            // 
            button_Nhap.BackColor = Color.MediumAquamarine;
            button_Nhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Nhap.Image = (Image)resources.GetObject("button_Nhap.Image");
            button_Nhap.ImageAlign = ContentAlignment.MiddleLeft;
            button_Nhap.Location = new Point(892, 180);
            button_Nhap.Name = "button_Nhap";
            button_Nhap.Size = new Size(146, 62);
            button_Nhap.TabIndex = 24;
            button_Nhap.Text = "Nhập";
            button_Nhap.UseVisualStyleBackColor = false;
            // 
            // pnlThongTinSach
            // 
            pnlThongTinSach.Controls.Add(button_DSPSach);
            pnlThongTinSach.Controls.Add(button_Nhap);
            pnlThongTinSach.Controls.Add(btnCapNhat);
            pnlThongTinSach.Controls.Add(btnXuat);
            pnlThongTinSach.Controls.Add(btnNhap);
            pnlThongTinSach.Controls.Add(btnSua);
            pnlThongTinSach.Controls.Add(btnXoa);
            pnlThongTinSach.Controls.Add(btnThem);
            pnlThongTinSach.Controls.Add(btnTimKiem);
            pnlThongTinSach.Controls.Add(lblTimKiem);
            pnlThongTinSach.Controls.Add(txtTimKiem);
            pnlThongTinSach.Controls.Add(txtDocGia);
            pnlThongTinSach.Controls.Add(cboTheLoai);
            pnlThongTinSach.Controls.Add(txtMoTa);
            pnlThongTinSach.Controls.Add(lblMoTa);
            pnlThongTinSach.Controls.Add(cboMaKe);
            pnlThongTinSach.Controls.Add(lblMaKe);
            pnlThongTinSach.Controls.Add(lblThanhTien);
            pnlThongTinSach.Controls.Add(txtThanhTien);
            pnlThongTinSach.Controls.Add(lblTacGia);
            pnlThongTinSach.Controls.Add(lblTheLoai);
            pnlThongTinSach.Controls.Add(txtTenSach);
            pnlThongTinSach.Controls.Add(lblTenSach);
            pnlThongTinSach.Controls.Add(txtMaSach);
            pnlThongTinSach.Controls.Add(lblMaSach);
            pnlThongTinSach.Location = new Point(34, 21);
            pnlThongTinSach.Name = "pnlThongTinSach";
            pnlThongTinSach.Size = new Size(1230, 318);
            pnlThongTinSach.TabIndex = 0;
            // 
            // button_DSPSach
            // 
            button_DSPSach.BackColor = Color.Salmon;
            button_DSPSach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_DSPSach.Location = new Point(715, 248);
            button_DSPSach.Name = "button_DSPSach";
            button_DSPSach.Size = new Size(323, 54);
            button_DSPSach.TabIndex = 25;
            button_DSPSach.Text = "Xem DS Phân Sách";
            button_DSPSach.UseVisualStyleBackColor = false;
            // 
            // Panel_Sach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            Controls.Add(dgvSach);
            Controls.Add(pnlThongTinSach);
            Name = "Panel_Sach";
            Size = new Size(1290, 760);
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            pnlThongTinSach.ResumeLayout(false);
            pnlThongTinSach.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvSach;
        private DataGridViewTextBoxColumn colMaSach;
        private DataGridViewTextBoxColumn colTenSach;
        private DataGridViewTextBoxColumn colTheLoai;
        private DataGridViewTextBoxColumn colTacGia;
        private DataGridViewTextBoxColumn colMaKe;
        private DataGridViewTextBoxColumn colMota;
        private DataGridViewTextBoxColumn colThanhTien;
        private DataGridViewTextBoxColumn colTinhTrangSach;
        private Label lblMaSach;
        private TextBox txtMaSach;
        private Label lblTenSach;
        private TextBox txtTenSach;
        private Label lblTheLoai;
        private Label lblTacGia;
        private Label lblMaKe;
        private ComboBox cboMaKe;
        private Label lblMoTa;
        private TextBox txtMoTa;
        private Label lblThanhTien;
        private TextBox txtThanhTien;
        private ComboBox cboTheLoai;
        private TextBox txtDocGia;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private Button btnTimKiem;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnCapNhat;
        private Button button_Nhap;
        private Panel pnlThongTinSach;
        private Button button_DSPSach;
    }
}
