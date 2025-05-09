using Mysqlx.Crud;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    internal class PnQuanLyPhieuMuonGUI : UserControl
    {
        private Color colorPanel = Color.FromArgb(0xFB, 0xF1, 0xF1);
        private DataGridView dgvPhieuMuon, dgvSachMuon;
        private DataTable dtPhieuMuon, dtSachMuon;
        private TextBox txtMaPhieuMuon, txtDocGia, txtNgayMuon, txtNgayTra, txtTenDocGia, txtTenNhanVien, txtMaNhanVien, txtTimKiem, txtMaSach, txtTenSach, txtThanhTien, txtTongTien;
        private Button btnThem, btnXoa, btnInthe, btnReset, btnXuatExcel, btnNhapExcel, btnTim, btnThemSach, btnXoaSach, btnDocGia, btnSach, btnClose;

        public PnQuanLyPhieuMuonGUI()
        {
            AddControls();
        }

        private void AddControls()
        {
            this.Text = "Quản lý phiếu mượn";
            this.Size = new Size(1290, 760);

            Panel pnPhieuMuon = new Panel();
            pnPhieuMuon.AutoSize = false;
            pnPhieuMuon.BackColor = colorPanel;

            Label lblTitle = new Label();
            lblTitle.Text = "PHIẾU MƯỢN";
            lblTitle.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            lblTitle.Size = new Size(350, 30);
            lblTitle.Location = new Point(200, 0);

            Label lblId = CreateLabel("ID: ");
            lblId.Size = new Size(100, 30);
            lblId.Location = new Point(20, 50);
            txtMaPhieuMuon = CreateTextBox();
            txtMaPhieuMuon.Location = new Point(170, 50);
            txtMaPhieuMuon.Enabled = false;

            Label lblNgayMuon = CreateLabel("Ngày mượn: ");
            lblNgayMuon.Size = new Size(145, 30);
            lblNgayMuon.Location = new Point(20, 90);
            txtNgayMuon = CreateTextBox();
            txtNgayMuon.Location = new Point(170, 90);
            txtNgayMuon.Enabled=false;

            //Label lblNgayTra = CreateLabel("Ngày trả: ");
            //lblNgayTra.Size = new Size(145, 30);
            //lblNgayTra.Location = new Point(20, 130);
            //txtNgayTra = CreateTextBox();
            //txtNgayTra.Location = new Point(170, 130);
            //txtNgayTra.Enabled=false;

            Label lblThe = CreateLabel("Thẻ: ");
            lblThe.Size = new Size(100, 30);
            lblThe.Location = new Point(20, 130);
            txtDocGia = CreateTextBox();
            txtDocGia.Location = new Point(170, 130);
            btnDocGia = new Button();
            btnDocGia.Text = "...";
            btnDocGia.Size = new Size(30, 30);
            btnDocGia.Location = new Point(480, 130);

            Label lblTen = CreateLabel("Tên: ");
            lblTen.Size = new Size(100, 30);
            lblTen.Location = new Point(20, 170);
            txtTenDocGia = CreateTextBox();
            txtTenDocGia.Location = new Point(170, 170);

            Label lblTongTien = CreateLabel("Tổng tiền:");
            lblTongTien.Size = new Size(145, 30);
            lblTongTien.Location = new Point(20, 210);
            txtTongTien = CreateTextBox();
            txtTongTien.Location = new Point(170, 210);
            txtTongTien.Enabled=false;

            Label lblMaNhanVien = CreateLabel("Mã NV: ");
            lblMaNhanVien.Size = new Size(100, 30);
            lblMaNhanVien.Location = new Point(600, 50);
            txtMaNhanVien = CreateTextBox();
            txtMaNhanVien.Location = new Point(700, 50);
            txtMaNhanVien.Enabled = false;

            Label lblTenNhanVien = CreateLabel("Tên NV: ");
            lblTenNhanVien.Size = new Size(100, 30);
            lblTenNhanVien.Location = new Point(600, 90);
            txtTenNhanVien = CreateTextBox();
            txtTenNhanVien.Location = new Point(700, 90);
            txtTenNhanVien.Enabled = false;

            //--------------------Panel chi tiết phiếu mượn-----------------------
            Label lblCTPhieuMuon = new Label();
            lblCTPhieuMuon.Text = "CHI TIẾT PHIẾU MƯỢN";
            lblCTPhieuMuon.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            lblCTPhieuMuon.Size = new Size(400, 30);
            lblCTPhieuMuon.Location = new Point(150, 0);

            Label lblMaSach = CreateLabel("Loại TB: ");
            lblMaSach.Size = new Size(130, 30);
            lblMaSach.Location = new Point(4, 30);
            txtMaSach = CreateTextBox();
            txtMaSach.Location = new Point(150, 30);
            txtMaSach.Enabled = false;
            btnSach = new Button();
            btnSach.Text = "...";
            btnSach.Size = new Size(30,30);
            btnSach.Location = new Point(460,29);

            Label lblTenSach = CreateLabel("Mã TB: ");
            lblTenSach.Size = new Size(130, 30);
            lblTenSach.Location = new Point(4, 70);
            txtTenSach = CreateTextBox();
            txtTenSach.Location = new Point(150, 70);
            txtTenSach.Enabled = false;

            Label lblThanhTien = CreateLabel("Thành tiền:");
            lblThanhTien.Size = new Size(150, 30);
            lblThanhTien.Location = new Point(4, 110);
            txtThanhTien = CreateTextBox();
            txtThanhTien.Location = new Point(150, 110);
            txtThanhTien.Enabled = false;

            btnThemSach = new Button();
            btnThemSach.Text = "Thêm";
            btnThemSach.Font = new Font("Arial", 20, FontStyle.Bold);
            btnThemSach.Size = new Size(100, 40);
            btnThemSach.BackColor = Color.FromArgb(0xE0, 0x65, 0x76);
            btnThemSach.Location = new Point(520,50);
            btnXoaSach = new Button();
            btnXoaSach.Text = "Xóa";
            btnXoaSach.Font = new Font("Arial", 20, FontStyle.Bold);
            btnXoaSach.Size = new Size(100, 40);
            btnXoaSach.BackColor = Color.FromArgb(0xE0, 0x65, 0x76);
            btnXoaSach.Location = new Point(520, 100);

            Panel pnCTPhieuMuon = new Panel();
            pnCTPhieuMuon.BorderStyle = BorderStyle.FixedSingle; // Viền đen đơn giản
            pnCTPhieuMuon.Size = new Size(670, 152);
            pnCTPhieuMuon.BackColor = colorPanel;
            pnCTPhieuMuon.AutoSize = false;
            pnCTPhieuMuon.Location = new Point(600, 130);

            pnCTPhieuMuon.Controls.Add(lblCTPhieuMuon);
            pnCTPhieuMuon.Controls.Add(lblMaSach);
            pnCTPhieuMuon.Controls.Add(lblTenSach);
            pnCTPhieuMuon.Controls.Add(lblThanhTien);
            pnCTPhieuMuon.Controls.Add(txtMaSach);
            pnCTPhieuMuon.Controls.Add(txtTenSach);
            pnCTPhieuMuon.Controls.Add(txtThanhTien);
            pnCTPhieuMuon.Controls.Add(btnSach);
            pnCTPhieuMuon.Controls.Add(btnThemSach);
            pnCTPhieuMuon.Controls.Add(btnXoaSach);

            //=============TABLE CHI TIẾT PHIẾU MƯỢN VÀ KHU VỰC CÁC NÚT VÀ KHU VỰC TÌM KIẾM==========
            dgvSachMuon = new DataGridView();
            DataGridViewCellStyle dgcSachMuon = new DataGridViewCellStyle();
            dgcSachMuon.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtSachMuon = new DataTable();
            dtSachMuon.Columns.Add("Mã");
            dtSachMuon.Columns.Add("Tên thiết bị");
            dtSachMuon.Columns.Add("Tiền mượn");

            dgvSachMuon.ColumnHeadersHeight = 40;
            dgvSachMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSachMuon.DataSource = dtSachMuon;
            //dgvSachMuon.Columns[0].DefaultCellStyle = dgcSachMuon;
            //dgvSachMuon.Columns[1].DefaultCellStyle = dgcSachMuon;
            //dgvSachMuon.Columns[2].DefaultCellStyle = dgcSachMuon;
            //dgvSachMuon.Columns[3].DefaultCellStyle = dgcSachMuon;

            //dgvSachMuon.Columns[0].Width = 50;
            //dgvSachMuon.Columns[1].Width = 80;
            //dgvSachMuon.Columns[2].Width = 320;
            //dgvSachMuon.Columns[3].Width = 150;

            dgvSachMuon.Size = new Size(600, 150);
            dgvSachMuon.Font = new Font("Times New Roman", 15, FontStyle.Regular);
            dgvSachMuon.RowTemplate.Height = 30;
            dgvSachMuon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSachMuon.ReadOnly = true;
            dgvSachMuon.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            dgvSachMuon.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvSachMuon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSachMuon.GridColor = Color.Black;
            dgvSachMuon.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvSachMuon.BorderStyle = BorderStyle.FixedSingle;
            Panel scrTblSachMuon = new Panel();
            scrTblSachMuon.BorderStyle = BorderStyle.FixedSingle; // Viền ngoài giống JScrollPane
            scrTblSachMuon.Size = new Size(600, 150);
            scrTblSachMuon.Location = new Point(20, 300);
            scrTblSachMuon.Controls.Add(dgvSachMuon);

            Label lblTimKiem = CreateLabel("Tìm kiếm:");
            lblTimKiem.Size = new Size(150, 30);
            lblTimKiem.Location = new Point(630, 300);
            txtTimKiem = new TextBox();
            txtTimKiem.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            txtTimKiem.Size = new Size(350, 40);
            txtTimKiem.BackColor = Color.White;
            txtTimKiem.Location = new Point(750,300);
            btnTim = new Button();
            btnTim.Text = "Tìm";
            btnTim.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            btnTim.BackColor = Color.FromArgb(0xD4, 0xF7, 0xF0);
            btnTim.Size = new Size(100, 40);
            btnTim.Location = new Point(1140, 295);

            btnThem = CreateItemButton("image/img_qltv/icon_them.png", "Thêm");
            btnThem.Size = new Size(140, 40);
            btnThem.Location = new Point(630, 340);
            btnReset = CreateItemButton("image/img_qltv/icon_reload.png", "");
            btnReset.Size = new Size(50, 40);
            btnReset.Location = new Point(800, 340);
            btnReset.BackColor = Color.FromArgb(0xE0, 0x65, 0x76);
            btnXoa = CreateItemButton("image/img_qltv/icon_xoa.png", "Xóa");
            btnXoa.Size = new Size(140, 40);
            btnXoa.Location = new Point(630, 400);
            btnInthe = CreateItemButton("image/img_qltv/icon_print.png", "In thẻ");
            btnInthe.Size = new Size(140, 40);
            btnInthe.Location = new Point(795, 400);
            btnNhapExcel = CreateItemButton("image/img_qltv/icon_excel.png", "Nhập");
            btnNhapExcel.Size = new Size(140, 40);
            btnNhapExcel.Location = new Point(960, 400);
            btnXuatExcel = CreateItemButton("image/img_qltv/icon_excel.png", "Xuất");
            btnXuatExcel.Size = new Size(140, 40);
            btnXuatExcel.Location = new Point(1125, 400);

            //----------------------------------TABLE PHIẾU MƯỢN-----------------------------------
            dgvPhieuMuon = new DataGridView();
            DataGridViewCellStyle dgcPhieuMuon = new DataGridViewCellStyle();
            dgcPhieuMuon.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtPhieuMuon = new DataTable();
            dtPhieuMuon.Columns.Add("ID");
            dtPhieuMuon.Columns.Add("Người mượn");
            dtPhieuMuon.Columns.Add("Nhân viên");
            dtPhieuMuon.Columns.Add("Ngày mượn");
            dtPhieuMuon.Columns.Add("Số lượng");
            dtPhieuMuon.Columns.Add("Tổng tiền");

            dgvPhieuMuon.ColumnHeadersHeight = 40;
            dgvPhieuMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuMuon.DataSource = dtPhieuMuon;
            //dgvPhieuMuon.Columns[0].DefaultCellStyle = dgcPhieuMuon;
            //dgvPhieuMuon.Columns[1].DefaultCellStyle = dgcPhieuMuon;
            //dgvPhieuMuon.Columns[2].DefaultCellStyle = dgcPhieuMuon;
            //dgvPhieuMuon.Columns[3].DefaultCellStyle = dgcPhieuMuon;
            //dgvPhieuMuon.Columns[4].DefaultCellStyle = dgcPhieuMuon;
            //dgvPhieuMuon.Columns[5].DefaultCellStyle = dgcPhieuMuon;

            //dgvPhieuMuon.Columns[0].Width = 50;
            //dgvPhieuMuon.Columns[1].Width = 200;
            //dgvPhieuMuon.Columns[2].Width = 200;
            //dgvPhieuMuon.Columns[3].Width = 200;
            //dgvPhieuMuon.Columns[4].Width = 200;
            //dgvPhieuMuon.Columns[5].Width = 200;

            dgvPhieuMuon.Font = new Font("Times New Roman", 15, FontStyle.Regular);
            dgvPhieuMuon.RowTemplate.Height = 30; // setRowHeight
            dgvPhieuMuon.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            dgvPhieuMuon.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B6F2E6");
            dgvPhieuMuon.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvPhieuMuon.EnableHeadersVisualStyles = false;
            dgvPhieuMuon.GridColor = Color.Black;
            dgvPhieuMuon.BorderStyle = BorderStyle.FixedSingle;
            dgvPhieuMuon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Panel scrTblPhieuMuon = new Panel();
            scrTblPhieuMuon.Size = new Size(1250, 200);
            scrTblPhieuMuon.Location = new Point(20, 460);
            scrTblPhieuMuon.BorderStyle = BorderStyle.FixedSingle;
            scrTblPhieuMuon.Controls.Add(dgvPhieuMuon);
            dgvPhieuMuon.Dock = DockStyle.Fill;

            pnPhieuMuon.Controls.Add(lblTitle);
            pnPhieuMuon.Controls.Add(btnClose);
            pnPhieuMuon.Controls.Add(lblId);
            pnPhieuMuon.Controls.Add(txtMaPhieuMuon);
            pnPhieuMuon.Controls.Add(lblNgayMuon);
            pnPhieuMuon.Controls.Add(txtNgayMuon);
            //pnPhieuMuon.Controls.Add(lblNgayTra);
            //pnPhieuMuon.Controls.Add(txtNgayTra);
            pnPhieuMuon.Controls.Add(lblThe);
            pnPhieuMuon.Controls.Add(txtDocGia);
            pnPhieuMuon.Controls.Add(btnDocGia);
            pnPhieuMuon.Controls.Add(lblTen);
            pnPhieuMuon.Controls.Add(txtTenDocGia);
            pnPhieuMuon.Controls.Add(lblTongTien);
            pnPhieuMuon.Controls.Add(txtTongTien);
            pnPhieuMuon.Controls.Add(lblMaNhanVien);
            pnPhieuMuon.Controls.Add(txtMaNhanVien);
            pnPhieuMuon.Controls.Add(lblTenNhanVien);
            pnPhieuMuon.Controls.Add(txtTenNhanVien);
            pnPhieuMuon.Controls.Add(pnCTPhieuMuon);
            pnPhieuMuon.Controls.Add(scrTblSachMuon);
            pnPhieuMuon.Controls.Add(lblTimKiem);
            pnPhieuMuon.Controls.Add(txtTimKiem);
            pnPhieuMuon.Controls.Add(btnTim);
            pnPhieuMuon.Controls.Add(btnReset);
            pnPhieuMuon.Controls.Add(btnThem);
            pnPhieuMuon.Controls.Add(btnXoa);
            pnPhieuMuon.Controls.Add(btnInthe);
            pnPhieuMuon.Controls.Add(btnNhapExcel);
            pnPhieuMuon.Controls.Add(btnXuatExcel);
            pnPhieuMuon.Controls.Add(scrTblPhieuMuon);

            //------------------------------Bảng phiếu mượn-----------------------------
            pnPhieuMuon.Dock = DockStyle.Fill;
            this.Controls.Add(pnPhieuMuon);
        }

        private TextBox CreateTextBox()
        {
            TextBox tb = new TextBox();
            tb.Size = new Size(300, 30);
            tb.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            tb.BackColor = Color.White;
            return tb;
        }

        private Label CreateLabel(string name)
        {
            Label lbl = new Label();
            lbl.Text = name;
            lbl.Font = new Font("Times New Roman", 18, FontStyle.Bold);
            return lbl;
        }

        public Button CreateItemButton(string linkIcon, string nameButton)
        {
            PictureBox icon = new PictureBox();
            icon.Image = Image.FromFile(linkIcon);
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            icon.Size = new Size(30, 30);

            Label name = new Label();
            name.Text = nameButton;
            name.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            name.ForeColor = Color.Black;
            name.AutoSize = true;

            Panel panel = new Panel();
            panel.BackColor = Color.FromArgb(182, 242, 230); // Màu 0xB6F2E6
            panel.Size = new Size(200, 40); // Kích thước cố định
            panel.Padding = new Padding(5);
            panel.Controls.Add(icon);
            panel.Controls.Add(name);

            icon.Location = new Point(5, 5);
            name.Location = new Point(40, 5);

            // TẠO BUTTON CHỨA PANEL
            Button button = new Button();
            button.Size = new Size(200, 40);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.FromArgb(182, 242, 230);
            button.Text = "";
            button.Controls.Add(panel);

            return button;
        }
    }
}
