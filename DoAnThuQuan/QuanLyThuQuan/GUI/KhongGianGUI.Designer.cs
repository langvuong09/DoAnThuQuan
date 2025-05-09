using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class KhongGianGUI : UserControl
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
            tabKhuVucPhong = new TabControl();
            tabKhuVuc = new TabPage();
            btnLoadKhuVuc = new Button();
            btnChinhSua = new Button();
            btnThemKhuVuc = new Button();
            btnThemKe = new Button();
            pnlDanhSachKhuVuc = new Panel();
            dgvDanhSachKhuVuc = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            lblDanhSachKhuVuc = new Label();
            pnlThongTinKhuVuc = new Panel();
            dgvKhuVucKe = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            txtTenKhuVuc = new TextBox();
            lblTenKhuVuc = new Label();
            txtMaKhuVuc = new TextBox();
            lblMaKhuVuc = new Label();
            pnlTimKiemKhuVuc = new Panel();
            lblKhuVuc = new Label();
            lblTimKiemKhuVuc = new Label();
            txtTimKiemKhuVuc = new TextBox();
            btnTimKiemKhuVuc = new Button();
            tabPhong = new TabPage();
            btnLoadPhong = new Button();
            pnlDanhSachPhong = new Panel();
            dgvChoNgoi = new DataGridView();
            lblMaChoNgoi = new Label();
            txtMaChoNgoi = new TextBox();
            lblMaPhongChoNgoi = new Label();
            txtMaPhongChoNgoi = new TextBox();
            lblTinhTrangChoNgoi = new Label();
            cboTinhTrangChoNgoi = new ComboBox();
            btnThemChoNgoi = new Button();
            btnSuaChoNgoi = new Button();
            txtViTri = new TextBox();
            txtSoLuongChoNgoi = new TextBox();
            lblViTri = new Label();
            lblSoLuongChoNgoi = new Label();
            pnlThongTinPhong = new Panel();
            button2 = new Button();
            button1 = new Button();
            dgvPhong = new DataGridView();
            txtSoLuong = new TextBox();
            lblSoLuong = new Label();
            txtMaPhong = new TextBox();
            lblMaPhong = new Label();
            lblTinhTrangPhong = new Label();
            cboTinhTrangPhong = new ComboBox();
            btnThemPhong = new Button();
            btnSuaPhong = new Button();
            pnlTimKiemPhong = new Panel();
            lblPhong = new Label();
            txtTimKiemPhong = new TextBox();
            btnTimPhong = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            tabKhuVucPhong.SuspendLayout();
            tabKhuVuc.SuspendLayout();
            pnlDanhSachKhuVuc.SuspendLayout();
            ((ISupportInitialize)dgvDanhSachKhuVuc).BeginInit();
            pnlThongTinKhuVuc.SuspendLayout();
            ((ISupportInitialize)dgvKhuVucKe).BeginInit();
            pnlTimKiemKhuVuc.SuspendLayout();
            tabPhong.SuspendLayout();
            pnlDanhSachPhong.SuspendLayout();
            ((ISupportInitialize)dgvChoNgoi).BeginInit();
            pnlThongTinPhong.SuspendLayout();
            ((ISupportInitialize)dgvPhong).BeginInit();
            pnlTimKiemPhong.SuspendLayout();
            SuspendLayout();
            // 
            // tabKhuVucPhong
            // 
            tabKhuVucPhong.Controls.Add(tabKhuVuc);
            tabKhuVucPhong.Controls.Add(tabPhong);
            tabKhuVucPhong.Dock = DockStyle.Fill;
            tabKhuVucPhong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabKhuVucPhong.Location = new Point(0, 0);
            tabKhuVucPhong.Margin = new Padding(3, 4, 3, 4);
            tabKhuVucPhong.Name = "tabKhuVucPhong";
            tabKhuVucPhong.Padding = new Point(50, 15);
            tabKhuVucPhong.SelectedIndex = 0;
            tabKhuVucPhong.Size = new Size(1474, 1013);
            tabKhuVucPhong.TabIndex = 0;
            // 
            // tabKhuVuc
            // 
            tabKhuVuc.BackColor = Color.Snow;
            tabKhuVuc.Controls.Add(btnLoadKhuVuc);
            tabKhuVuc.Controls.Add(btnChinhSua);
            tabKhuVuc.Controls.Add(btnThemKhuVuc);
            tabKhuVuc.Controls.Add(btnThemKe);
            tabKhuVuc.Controls.Add(pnlDanhSachKhuVuc);
            tabKhuVuc.Controls.Add(pnlThongTinKhuVuc);
            tabKhuVuc.Controls.Add(pnlTimKiemKhuVuc);
            tabKhuVuc.Location = new Point(4, 61);
            tabKhuVuc.Margin = new Padding(3, 4, 3, 4);
            tabKhuVuc.Name = "tabKhuVuc";
            tabKhuVuc.Padding = new Padding(3, 4, 3, 4);
            tabKhuVuc.Size = new Size(1466, 948);
            tabKhuVuc.TabIndex = 0;
            tabKhuVuc.Text = "Khu Vực";
            // 
            // btnLoadKhuVuc
            // 
            btnLoadKhuVuc.BackColor = Color.Honeydew;
            btnLoadKhuVuc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadKhuVuc.Location = new Point(1249, 8);
            btnLoadKhuVuc.Margin = new Padding(3, 4, 3, 4);
            btnLoadKhuVuc.Name = "btnLoadKhuVuc";
            btnLoadKhuVuc.Size = new Size(106, 80);
            btnLoadKhuVuc.TabIndex = 0;
            btnLoadKhuVuc.Text = "Reload";
            btnLoadKhuVuc.UseVisualStyleBackColor = false;
            // 
            // btnChinhSua
            // 
            btnChinhSua.BackColor = Color.IndianRed;
            btnChinhSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnChinhSua.Location = new Point(591, 773);
            btnChinhSua.Margin = new Padding(3, 4, 3, 4);
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new Size(183, 89);
            btnChinhSua.TabIndex = 5;
            btnChinhSua.Text = "Chỉnh sửa";
            btnChinhSua.UseVisualStyleBackColor = false;
            // 
            // btnThemKhuVuc
            // 
            btnThemKhuVuc.BackColor = Color.MediumSpringGreen;
            btnThemKhuVuc.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemKhuVuc.Location = new Point(323, 773);
            btnThemKhuVuc.Margin = new Padding(3, 4, 3, 4);
            btnThemKhuVuc.Name = "btnThemKhuVuc";
            btnThemKhuVuc.Size = new Size(214, 89);
            btnThemKhuVuc.TabIndex = 4;
            btnThemKhuVuc.Text = "Thêm khu vực";
            btnThemKhuVuc.UseVisualStyleBackColor = false;
            // 
            // btnThemKe
            // 
            btnThemKe.BackColor = Color.MediumSeaGreen;
            btnThemKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemKe.Location = new Point(112, 773);
            btnThemKe.Margin = new Padding(3, 4, 3, 4);
            btnThemKe.Name = "btnThemKe";
            btnThemKe.Size = new Size(162, 89);
            btnThemKe.TabIndex = 3;
            btnThemKe.Text = "Thêm kệ";
            btnThemKe.UseVisualStyleBackColor = false;
            // 
            // pnlDanhSachKhuVuc
            // 
            pnlDanhSachKhuVuc.Controls.Add(dgvDanhSachKhuVuc);
            pnlDanhSachKhuVuc.Controls.Add(lblDanhSachKhuVuc);
            pnlDanhSachKhuVuc.Location = new Point(773, 223);
            pnlDanhSachKhuVuc.Margin = new Padding(3, 4, 3, 4);
            pnlDanhSachKhuVuc.Name = "pnlDanhSachKhuVuc";
            pnlDanhSachKhuVuc.Size = new Size(664, 495);
            pnlDanhSachKhuVuc.TabIndex = 2;
            // 
            // dgvDanhSachKhuVuc
            // 
            dgvDanhSachKhuVuc.AllowUserToAddRows = false;
            dgvDanhSachKhuVuc.AllowUserToDeleteRows = false;
            dgvDanhSachKhuVuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachKhuVuc.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(101, 224, 199);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDanhSachKhuVuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDanhSachKhuVuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachKhuVuc.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4 });
            dgvDanhSachKhuVuc.EnableHeadersVisualStyles = false;
            dgvDanhSachKhuVuc.Location = new Point(47, 119);
            dgvDanhSachKhuVuc.Margin = new Padding(3, 4, 3, 4);
            dgvDanhSachKhuVuc.MultiSelect = false;
            dgvDanhSachKhuVuc.Name = "dgvDanhSachKhuVuc";
            dgvDanhSachKhuVuc.ReadOnly = true;
            dgvDanhSachKhuVuc.RowHeadersWidth = 51;
            dgvDanhSachKhuVuc.Size = new Size(571, 337);
            dgvDanhSachKhuVuc.TabIndex = 8;
            // 
            // Column3
            // 
            Column3.HeaderText = "Mã Khu Vực";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tên Khu Vực";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // lblDanhSachKhuVuc
            // 
            lblDanhSachKhuVuc.AutoSize = true;
            lblDanhSachKhuVuc.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachKhuVuc.Location = new Point(239, 23);
            lblDanhSachKhuVuc.Name = "lblDanhSachKhuVuc";
            lblDanhSachKhuVuc.Size = new Size(272, 32);
            lblDanhSachKhuVuc.TabIndex = 8;
            lblDanhSachKhuVuc.Text = "Danh sách các khu vực";
            // 
            // pnlThongTinKhuVuc
            // 
            pnlThongTinKhuVuc.Controls.Add(dgvKhuVucKe);
            pnlThongTinKhuVuc.Controls.Add(txtTenKhuVuc);
            pnlThongTinKhuVuc.Controls.Add(lblTenKhuVuc);
            pnlThongTinKhuVuc.Controls.Add(txtMaKhuVuc);
            pnlThongTinKhuVuc.Controls.Add(lblMaKhuVuc);
            pnlThongTinKhuVuc.Location = new Point(30, 223);
            pnlThongTinKhuVuc.Margin = new Padding(3, 4, 3, 4);
            pnlThongTinKhuVuc.Name = "pnlThongTinKhuVuc";
            pnlThongTinKhuVuc.Size = new Size(664, 495);
            pnlThongTinKhuVuc.TabIndex = 1;
            // 
            // dgvKhuVucKe
            // 
            dgvKhuVucKe.AllowUserToAddRows = false;
            dgvKhuVucKe.AllowUserToDeleteRows = false;
            dgvKhuVucKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhuVucKe.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(101, 224, 199);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKhuVucKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKhuVucKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhuVucKe.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvKhuVucKe.EnableHeadersVisualStyles = false;
            dgvKhuVucKe.Location = new Point(61, 167);
            dgvKhuVucKe.Margin = new Padding(3, 4, 3, 4);
            dgvKhuVucKe.MultiSelect = false;
            dgvKhuVucKe.Name = "dgvKhuVucKe";
            dgvKhuVucKe.ReadOnly = true;
            dgvKhuVucKe.RowHeadersWidth = 51;
            dgvKhuVucKe.Size = new Size(547, 255);
            dgvKhuVucKe.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã Kệ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã Khu Vực";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // txtTenKhuVuc
            // 
            txtTenKhuVuc.Location = new Point(168, 89);
            txtTenKhuVuc.Margin = new Padding(3, 4, 3, 4);
            txtTenKhuVuc.Name = "txtTenKhuVuc";
            txtTenKhuVuc.Size = new Size(439, 34);
            txtTenKhuVuc.TabIndex = 6;
            // 
            // lblTenKhuVuc
            // 
            lblTenKhuVuc.AutoSize = true;
            lblTenKhuVuc.Location = new Point(29, 100);
            lblTenKhuVuc.Name = "lblTenKhuVuc";
            lblTenKhuVuc.Size = new Size(126, 28);
            lblTenKhuVuc.TabIndex = 5;
            lblTenKhuVuc.Text = "Tên khu vực";
            // 
            // txtMaKhuVuc
            // 
            txtMaKhuVuc.Location = new Point(168, 23);
            txtMaKhuVuc.Margin = new Padding(3, 4, 3, 4);
            txtMaKhuVuc.Name = "txtMaKhuVuc";
            txtMaKhuVuc.Size = new Size(439, 34);
            txtMaKhuVuc.TabIndex = 4;
            // 
            // lblMaKhuVuc
            // 
            lblMaKhuVuc.AutoSize = true;
            lblMaKhuVuc.Location = new Point(29, 33);
            lblMaKhuVuc.Name = "lblMaKhuVuc";
            lblMaKhuVuc.Size = new Size(123, 28);
            lblMaKhuVuc.TabIndex = 0;
            lblMaKhuVuc.Text = "Mã khu vực";
            // 
            // pnlTimKiemKhuVuc
            // 
            pnlTimKiemKhuVuc.Controls.Add(lblKhuVuc);
            pnlTimKiemKhuVuc.Controls.Add(lblTimKiemKhuVuc);
            pnlTimKiemKhuVuc.Controls.Add(txtTimKiemKhuVuc);
            pnlTimKiemKhuVuc.Controls.Add(btnTimKiemKhuVuc);
            pnlTimKiemKhuVuc.Location = new Point(246, 27);
            pnlTimKiemKhuVuc.Margin = new Padding(3, 4, 3, 4);
            pnlTimKiemKhuVuc.Name = "pnlTimKiemKhuVuc";
            pnlTimKiemKhuVuc.Size = new Size(997, 137);
            pnlTimKiemKhuVuc.TabIndex = 0;
            // 
            // lblKhuVuc
            // 
            lblKhuVuc.AutoSize = true;
            lblKhuVuc.ForeColor = Color.IndianRed;
            lblKhuVuc.Location = new Point(410, 15);
            lblKhuVuc.Name = "lblKhuVuc";
            lblKhuVuc.Size = new Size(101, 28);
            lblKhuVuc.TabIndex = 0;
            lblKhuVuc.Text = "KHU VỰC";
            // 
            // lblTimKiemKhuVuc
            // 
            lblTimKiemKhuVuc.AutoSize = true;
            lblTimKiemKhuVuc.Location = new Point(56, 45);
            lblTimKiemKhuVuc.Name = "lblTimKiemKhuVuc";
            lblTimKiemKhuVuc.Size = new Size(0, 28);
            lblTimKiemKhuVuc.TabIndex = 1;
            // 
            // txtTimKiemKhuVuc
            // 
            txtTimKiemKhuVuc.Location = new Point(168, 57);
            txtTimKiemKhuVuc.Margin = new Padding(3, 4, 3, 4);
            txtTimKiemKhuVuc.Name = "txtTimKiemKhuVuc";
            txtTimKiemKhuVuc.Size = new Size(548, 34);
            txtTimKiemKhuVuc.TabIndex = 2;
            // 
            // btnTimKiemKhuVuc
            // 
            btnTimKiemKhuVuc.BackColor = Color.Turquoise;
            btnTimKiemKhuVuc.Location = new Point(746, 51);
            btnTimKiemKhuVuc.Margin = new Padding(3, 4, 3, 4);
            btnTimKiemKhuVuc.Name = "btnTimKiemKhuVuc";
            btnTimKiemKhuVuc.Size = new Size(159, 49);
            btnTimKiemKhuVuc.TabIndex = 3;
            btnTimKiemKhuVuc.Text = "Tìm kiếm";
            btnTimKiemKhuVuc.UseVisualStyleBackColor = false;
            // 
            // tabPhong
            // 
            tabPhong.BackColor = Color.Snow;
            tabPhong.Controls.Add(btnLoadPhong);
            tabPhong.Controls.Add(pnlDanhSachPhong);
            tabPhong.Controls.Add(pnlThongTinPhong);
            tabPhong.Controls.Add(pnlTimKiemPhong);
            tabPhong.Location = new Point(4, 61);
            tabPhong.Margin = new Padding(3, 4, 3, 4);
            tabPhong.Name = "tabPhong";
            tabPhong.Padding = new Padding(3, 4, 3, 4);
            tabPhong.Size = new Size(1466, 948);
            tabPhong.TabIndex = 1;
            tabPhong.Text = "Phòng";
            // 
            // btnLoadPhong
            // 
            btnLoadPhong.BackColor = Color.Honeydew;
            btnLoadPhong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadPhong.Location = new Point(1249, 8);
            btnLoadPhong.Margin = new Padding(3, 4, 3, 4);
            btnLoadPhong.Name = "btnLoadPhong";
            btnLoadPhong.Size = new Size(106, 80);
            btnLoadPhong.TabIndex = 12;
            btnLoadPhong.Text = "Reload";
            btnLoadPhong.UseVisualStyleBackColor = false;
            // 
            // pnlDanhSachPhong
            // 
            pnlDanhSachPhong.Controls.Add(dgvChoNgoi);
            pnlDanhSachPhong.Controls.Add(lblMaChoNgoi);
            pnlDanhSachPhong.Controls.Add(txtMaChoNgoi);
            pnlDanhSachPhong.Controls.Add(lblMaPhongChoNgoi);
            pnlDanhSachPhong.Controls.Add(txtMaPhongChoNgoi);
            pnlDanhSachPhong.Controls.Add(lblTinhTrangChoNgoi);
            pnlDanhSachPhong.Controls.Add(cboTinhTrangChoNgoi);
            pnlDanhSachPhong.Controls.Add(btnThemChoNgoi);
            pnlDanhSachPhong.Controls.Add(btnSuaChoNgoi);
            pnlDanhSachPhong.Controls.Add(txtViTri);
            pnlDanhSachPhong.Controls.Add(txtSoLuongChoNgoi);
            pnlDanhSachPhong.Controls.Add(lblViTri);
            pnlDanhSachPhong.Controls.Add(lblSoLuongChoNgoi);
            pnlDanhSachPhong.Location = new Point(778, 223);
            pnlDanhSachPhong.Margin = new Padding(3, 4, 3, 4);
            pnlDanhSachPhong.Name = "pnlDanhSachPhong";
            pnlDanhSachPhong.Size = new Size(641, 621);
            pnlDanhSachPhong.TabIndex = 2;
            // 
            // dgvChoNgoi
            // 
            dgvChoNgoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChoNgoi.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(101, 224, 199);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvChoNgoi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvChoNgoi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChoNgoi.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvChoNgoi.EnableHeadersVisualStyles = false;
            dgvChoNgoi.Location = new Point(26, 31);
            dgvChoNgoi.Margin = new Padding(3, 4, 3, 4);
            dgvChoNgoi.Name = "dgvChoNgoi";
            dgvChoNgoi.RowHeadersWidth = 51;
            dgvChoNgoi.Size = new Size(589, 195);
            dgvChoNgoi.TabIndex = 9;
            // 
            // lblMaChoNgoi
            // 
            lblMaChoNgoi.AutoSize = true;
            lblMaChoNgoi.Location = new Point(26, 253);
            lblMaChoNgoi.Name = "lblMaChoNgoi";
            lblMaChoNgoi.Size = new Size(130, 28);
            lblMaChoNgoi.TabIndex = 0;
            lblMaChoNgoi.Text = "Mã chỗ ngồi";
            // 
            // txtMaChoNgoi
            // 
            txtMaChoNgoi.Location = new Point(200, 249);
            txtMaChoNgoi.Margin = new Padding(3, 4, 3, 4);
            txtMaChoNgoi.Name = "txtMaChoNgoi";
            txtMaChoNgoi.Size = new Size(364, 34);
            txtMaChoNgoi.TabIndex = 9;
            // 
            // lblMaPhongChoNgoi
            // 
            lblMaPhongChoNgoi.AutoSize = true;
            lblMaPhongChoNgoi.Location = new Point(26, 313);
            lblMaPhongChoNgoi.Name = "lblMaPhongChoNgoi";
            lblMaPhongChoNgoi.Size = new Size(108, 28);
            lblMaPhongChoNgoi.TabIndex = 10;
            lblMaPhongChoNgoi.Text = "Mã phòng";
            // 
            // txtMaPhongChoNgoi
            // 
            txtMaPhongChoNgoi.Location = new Point(200, 309);
            txtMaPhongChoNgoi.Margin = new Padding(3, 4, 3, 4);
            txtMaPhongChoNgoi.Name = "txtMaPhongChoNgoi";
            txtMaPhongChoNgoi.Size = new Size(364, 34);
            txtMaPhongChoNgoi.TabIndex = 9;
            // 
            // lblTinhTrangChoNgoi
            // 
            lblTinhTrangChoNgoi.AutoSize = true;
            lblTinhTrangChoNgoi.Location = new Point(26, 373);
            lblTinhTrangChoNgoi.Name = "lblTinhTrangChoNgoi";
            lblTinhTrangChoNgoi.Size = new Size(111, 28);
            lblTinhTrangChoNgoi.TabIndex = 9;
            lblTinhTrangChoNgoi.Text = "Tình trạng";
            // 
            // cboTinhTrangChoNgoi
            // 
            cboTinhTrangChoNgoi.FormattingEnabled = true;
            cboTinhTrangChoNgoi.Location = new Point(200, 369);
            cboTinhTrangChoNgoi.Margin = new Padding(3, 4, 3, 4);
            cboTinhTrangChoNgoi.Name = "cboTinhTrangChoNgoi";
            cboTinhTrangChoNgoi.Size = new Size(364, 36);
            cboTinhTrangChoNgoi.TabIndex = 9;
            // 
            // btnThemChoNgoi
            // 
            btnThemChoNgoi.BackColor = Color.BlanchedAlmond;
            btnThemChoNgoi.Location = new Point(200, 549);
            btnThemChoNgoi.Margin = new Padding(3, 4, 3, 4);
            btnThemChoNgoi.Name = "btnThemChoNgoi";
            btnThemChoNgoi.Size = new Size(154, 53);
            btnThemChoNgoi.TabIndex = 9;
            btnThemChoNgoi.Text = "Thêm";
            btnThemChoNgoi.UseVisualStyleBackColor = false;
            // 
            // btnSuaChoNgoi
            // 
            btnSuaChoNgoi.BackColor = Color.RosyBrown;
            btnSuaChoNgoi.Location = new Point(410, 549);
            btnSuaChoNgoi.Margin = new Padding(3, 4, 3, 4);
            btnSuaChoNgoi.Name = "btnSuaChoNgoi";
            btnSuaChoNgoi.Size = new Size(154, 53);
            btnSuaChoNgoi.TabIndex = 9;
            btnSuaChoNgoi.Text = "Sửa";
            btnSuaChoNgoi.UseVisualStyleBackColor = false;
            // 
            // txtViTri
            // 
            txtViTri.Location = new Point(200, 429);
            txtViTri.Margin = new Padding(3, 4, 3, 4);
            txtViTri.Name = "txtViTri";
            txtViTri.Size = new Size(364, 34);
            txtViTri.TabIndex = 10;
            // 
            // txtSoLuongChoNgoi
            // 
            txtSoLuongChoNgoi.Location = new Point(200, 489);
            txtSoLuongChoNgoi.Margin = new Padding(3, 4, 3, 4);
            txtSoLuongChoNgoi.Name = "txtSoLuongChoNgoi";
            txtSoLuongChoNgoi.Size = new Size(364, 34);
            txtSoLuongChoNgoi.TabIndex = 11;
            // 
            // lblViTri
            // 
            lblViTri.AutoSize = true;
            lblViTri.Location = new Point(26, 433);
            lblViTri.Name = "lblViTri";
            lblViTri.Size = new Size(59, 28);
            lblViTri.TabIndex = 12;
            lblViTri.Text = "Vị trí";
            // 
            // lblSoLuongChoNgoi
            // 
            lblSoLuongChoNgoi.AutoSize = true;
            lblSoLuongChoNgoi.Location = new Point(26, 493);
            lblSoLuongChoNgoi.Name = "lblSoLuongChoNgoi";
            lblSoLuongChoNgoi.Size = new Size(97, 28);
            lblSoLuongChoNgoi.TabIndex = 13;
            lblSoLuongChoNgoi.Text = "Số lượng";
            // 
            // pnlThongTinPhong
            // 
            pnlThongTinPhong.Controls.Add(button2);
            pnlThongTinPhong.Controls.Add(button1);
            pnlThongTinPhong.Controls.Add(dgvPhong);
            pnlThongTinPhong.Controls.Add(txtSoLuong);
            pnlThongTinPhong.Controls.Add(lblSoLuong);
            pnlThongTinPhong.Controls.Add(txtMaPhong);
            pnlThongTinPhong.Controls.Add(lblMaPhong);
            pnlThongTinPhong.Controls.Add(lblTinhTrangPhong);
            pnlThongTinPhong.Controls.Add(cboTinhTrangPhong);
            pnlThongTinPhong.Controls.Add(btnThemPhong);
            pnlThongTinPhong.Controls.Add(btnSuaPhong);
            pnlThongTinPhong.Location = new Point(30, 223);
            pnlThongTinPhong.Margin = new Padding(3, 4, 3, 4);
            pnlThongTinPhong.Name = "pnlThongTinPhong";
            pnlThongTinPhong.Size = new Size(664, 621);
            pnlThongTinPhong.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Location = new Point(336, 505);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(154, 79);
            button2.TabIndex = 11;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.BlanchedAlmond;
            button1.Location = new Point(138, 505);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(154, 79);
            button1.TabIndex = 11;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // dgvPhong
            // 
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(101, 224, 199);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhong.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dgvPhong.EnableHeadersVisualStyles = false;
            dgvPhong.Location = new Point(73, 281);
            dgvPhong.Margin = new Padding(3, 4, 3, 4);
            dgvPhong.Name = "dgvPhong";
            dgvPhong.RowHeadersWidth = 51;
            dgvPhong.Size = new Size(481, 191);
            dgvPhong.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(190, 95);
            txtSoLuong.Margin = new Padding(3, 4, 3, 4);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(364, 34);
            txtSoLuong.TabIndex = 3;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(25, 105);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(97, 28);
            lblSoLuong.TabIndex = 2;
            lblSoLuong.Text = "Số lượng";
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(190, 20);
            txtMaPhong.Margin = new Padding(3, 4, 3, 4);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(364, 34);
            txtMaPhong.TabIndex = 1;
            // 
            // lblMaPhong
            // 
            lblMaPhong.AutoSize = true;
            lblMaPhong.Location = new Point(25, 31);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new Size(108, 28);
            lblMaPhong.TabIndex = 0;
            lblMaPhong.Text = "Mã phòng";
            // 
            // lblTinhTrangPhong
            // 
            lblTinhTrangPhong.AutoSize = true;
            lblTinhTrangPhong.Location = new Point(25, 181);
            lblTinhTrangPhong.Name = "lblTinhTrangPhong";
            lblTinhTrangPhong.Size = new Size(111, 28);
            lblTinhTrangPhong.TabIndex = 4;
            lblTinhTrangPhong.Text = "Tình trạng";
            // 
            // cboTinhTrangPhong
            // 
            cboTinhTrangPhong.FormattingEnabled = true;
            cboTinhTrangPhong.Location = new Point(190, 173);
            cboTinhTrangPhong.Margin = new Padding(3, 4, 3, 4);
            cboTinhTrangPhong.Name = "cboTinhTrangPhong";
            cboTinhTrangPhong.Size = new Size(364, 36);
            cboTinhTrangPhong.TabIndex = 5;
            // 
            // btnThemPhong
            // 
            btnThemPhong.BackColor = Color.MediumSeaGreen;
            btnThemPhong.Location = new Point(34, 773);
            btnThemPhong.Margin = new Padding(3, 4, 3, 4);
            btnThemPhong.Name = "btnThemPhong";
            btnThemPhong.Size = new Size(239, 89);
            btnThemPhong.TabIndex = 3;
            btnThemPhong.Text = "Thêm kệ";
            btnThemPhong.UseVisualStyleBackColor = false;
            // 
            // btnSuaPhong
            // 
            btnSuaPhong.BackColor = Color.MediumSeaGreen;
            btnSuaPhong.Location = new Point(323, 773);
            btnSuaPhong.Margin = new Padding(3, 4, 3, 4);
            btnSuaPhong.Name = "btnSuaPhong";
            btnSuaPhong.Size = new Size(239, 89);
            btnSuaPhong.TabIndex = 4;
            btnSuaPhong.Text = "Thêm khu vực";
            btnSuaPhong.UseVisualStyleBackColor = false;
            // 
            // pnlTimKiemPhong
            // 
            pnlTimKiemPhong.Controls.Add(lblPhong);
            pnlTimKiemPhong.Controls.Add(txtTimKiemPhong);
            pnlTimKiemPhong.Controls.Add(btnTimPhong);
            pnlTimKiemPhong.Location = new Point(246, 27);
            pnlTimKiemPhong.Margin = new Padding(3, 4, 3, 4);
            pnlTimKiemPhong.Name = "pnlTimKiemPhong";
            pnlTimKiemPhong.Size = new Size(997, 137);
            pnlTimKiemPhong.TabIndex = 0;
            // 
            // lblPhong
            // 
            lblPhong.AutoSize = true;
            lblPhong.ForeColor = Color.IndianRed;
            lblPhong.Location = new Point(410, 15);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new Size(84, 28);
            lblPhong.TabIndex = 0;
            lblPhong.Text = "PHÒNG";
            // 
            // txtTimKiemPhong
            // 
            txtTimKiemPhong.Location = new Point(168, 57);
            txtTimKiemPhong.Margin = new Padding(3, 4, 3, 4);
            txtTimKiemPhong.Name = "txtTimKiemPhong";
            txtTimKiemPhong.Size = new Size(548, 34);
            txtTimKiemPhong.TabIndex = 2;
            // 
            // btnTimPhong
            // 
            btnTimPhong.BackColor = Color.Turquoise;
            btnTimPhong.Location = new Point(746, 51);
            btnTimPhong.Margin = new Padding(3, 4, 3, 4);
            btnTimPhong.Name = "btnTimPhong";
            btnTimPhong.Size = new Size(159, 49);
            btnTimPhong.TabIndex = 3;
            btnTimPhong.Text = "Tìm kiếm";
            btnTimPhong.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "Mã chỗ ngồi";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "Mã phòng";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "Trạng thái";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "Vị trí";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "Số lượng";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "Mã phòng";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "Số lượng chỗ ngồi";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "Trạng thái";
            // 
            // Column8
            // 
            Column8.HeaderText = "Mã Chỗ Ngồi";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Mã Phòng";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "Tình Trạng";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Mã Phòng";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Số Lượng Chỗ Ngồi";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Trạng Thái";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // KhongGianGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabKhuVucPhong);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KhongGianGUI";
            Size = new Size(1474, 1013);
            tabKhuVucPhong.ResumeLayout(false);
            tabKhuVuc.ResumeLayout(false);
            pnlDanhSachKhuVuc.ResumeLayout(false);
            pnlDanhSachKhuVuc.PerformLayout();
            ((ISupportInitialize)dgvDanhSachKhuVuc).EndInit();
            pnlThongTinKhuVuc.ResumeLayout(false);
            pnlThongTinKhuVuc.PerformLayout();
            ((ISupportInitialize)dgvKhuVucKe).EndInit();
            pnlTimKiemKhuVuc.ResumeLayout(false);
            pnlTimKiemKhuVuc.PerformLayout();
            tabPhong.ResumeLayout(false);
            pnlDanhSachPhong.ResumeLayout(false);
            pnlDanhSachPhong.PerformLayout();
            ((ISupportInitialize)dgvChoNgoi).EndInit();
            pnlThongTinPhong.ResumeLayout(false);
            pnlThongTinPhong.PerformLayout();
            ((ISupportInitialize)dgvPhong).EndInit();
            pnlTimKiemPhong.ResumeLayout(false);
            pnlTimKiemPhong.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabKhuVucPhong;
        private TabPage tabKhuVuc;
        private TabPage tabPhong;
        private Panel pnlTimKiemKhuVuc;
        private Label lblKhuVuc;
        private Label lblTimKiemKhuVuc;
        private TextBox txtTimKiemKhuVuc;
        private Button btnTimKiemKhuVuc;
        private Panel pnlThongTinKhuVuc;
        private Panel pnlDanhSachKhuVuc;
        private Label lblMaKhuVuc;
        private TextBox txtMaKhuVuc;
        private Label lblTenKhuVuc;
        private TextBox txtTenKhuVuc;
        private DataGridView dgvKhuVucKe;
        private Label lblDanhSachKhuVuc;
        private DataGridView dgvDanhSachKhuVuc;
        private Button btnThemKe;
        private Button btnThemKhuVuc;
        private Button btnChinhSua;
        private Button btnLoadKhuVuc;
        private Panel pnlTimKiemPhong;
        private Label lblPhong;
        private TextBox txtTimKiemPhong;
        private Button btnTimPhong;
        private Panel pnlThongTinPhong;
        private Panel pnlDanhSachPhong;
        private Label lblMaPhong;
        private TextBox txtMaPhong;
        private Label lblSoLuong;
        private TextBox txtSoLuong;
        private Label lblTinhTrangPhong;
        private ComboBox cboTinhTrangPhong;
        private DataGridView dgvPhong;
        private Button btnThemPhong;
        private Button btnSuaPhong;
        private Label lblMaChoNgoi;
        private TextBox txtMaChoNgoi;
        private Label lblMaPhongChoNgoi;
        private TextBox txtMaPhongChoNgoi;
        private Label lblTinhTrangChoNgoi;
        private ComboBox cboTinhTrangChoNgoi;
        private DataGridView dgvChoNgoi;
        private Button btnThemChoNgoi;
        private Button btnSuaChoNgoi;
        private Button btnLoadPhong;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Button button2;
        private Button button1;
        private TextBox txtViTri;
        private TextBox txtSoLuongChoNgoi;
        private Label lblViTri;
        private Label lblSoLuongChoNgoi;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}
