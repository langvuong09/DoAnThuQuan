using DoAnThuQuan.QuanLyThuQuan.BUS;
using DoAnThuQuan.QuanLyThuQuan.DTO;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    internal class PnQuanLyPhieuTraGUI : UserControl
    {
        private Color colorPanel = Color.FromArgb(0xFB, 0xF1, 0xF1);
        private DataGridView dgvPhieuTra, dgvSachTra;
        private DataTable dtPhieuTra, dtSachTra;
        private TextBox txtMaPhieuTra, txtMaPhieuMuon, txtDocGia, txtNgayMuon, txtNgayTra, txtTimKiem, txtNote;
        private Button btnThem, btnXoa, btnInthe, btnReset, btnXuatExcel, btnNhapExcel, btnTim, btnThemSach, btnXoaSach, btnPhieuMuon, btnClose, btnLoc;
        private DateTimePicker dtpNgayBD, dtpNgayKT;
        private PhieuTraBUS phieuTraBUS = new PhieuTraBUS();
        private UserBUS userBUS = new UserBUS();

        public PnQuanLyPhieuTraGUI()
        {
            AddControls();
        }

        private void AddControls()
        {
            this.Text = "Quản lý phiếu trả";
            this.Size = new Size(1290, 760);

            Panel pnPhieuTra = new Panel();
            pnPhieuTra.AutoSize = false;
            pnPhieuTra.BackColor = colorPanel;

            Label lblTitle = new Label();
            lblTitle.Text = "PHIẾU TRẢ";
            lblTitle.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            lblTitle.Size = new Size(350, 30);
            lblTitle.Location = new Point(500, 0);

            Label lblId = CreateLabel("ID: ");
            lblId.Size = new Size(100, 30);
            lblId.Location = new Point(20, 50);
            txtMaPhieuTra = CreateTextBox();
            txtMaPhieuTra.Location = new Point(170, 50);
            txtMaPhieuTra.Enabled = false;

            Label lblMaPM = CreateLabel("Mã PM:");
            lblMaPM.Size = new Size(100, 30);
            lblMaPM.Location = new Point(20, 90);
            txtMaPhieuMuon = CreateTextBox();
            txtMaPhieuMuon.Location = new Point(170, 90);
            txtMaPhieuMuon.Enabled = false;
            btnPhieuMuon = new Button();
            btnPhieuMuon.Text = "...";
            btnPhieuMuon.Size = new Size(30, 30);
            btnPhieuMuon.Location = new Point(480, 90);

            Label lblThanhVien = CreateLabel("Thành viên:");
            lblThanhVien.Size = new Size(150, 30);
            lblThanhVien.Location = new Point(20, 130);
            txtDocGia = CreateTextBox();
            txtDocGia.Location = new Point(170, 130);
            txtDocGia.Enabled = false;

            Label lblNgayMuon = CreateLabel("Ngày mượn:");
            lblNgayMuon.Size = new Size(150, 30);
            lblNgayMuon.Location = new Point(20, 170);
            txtNgayMuon = CreateTextBox();
            txtNgayMuon.Location = new Point(170, 170);
            txtNgayMuon.Enabled = false;

            Label lblNgayTra = CreateLabel("Ngày trả:");
            lblNgayTra.Size = new Size(150, 30);
            lblNgayTra.Location = new Point(20, 210);
            txtNgayTra = CreateTextBox();
            txtNgayTra.Location = new Point(170, 210);
            txtNgayTra.Enabled = false;

            Label lblNote = CreateLabel("Ghi chú:");
            lblNote.Size = new Size(150, 30);
            lblNote.Location = new Point(20, 250);
            txtNote = new TextBox();
            txtNote.Multiline = true;
            txtNote.Size = new Size(300, 125);
            txtNote.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            txtNote.BackColor = Color.White;
            txtNote.Location = new Point(170, 250);

            //--------------------Panel chi tiết phiếu trả-----------------------
            dgvSachTra = new DataGridView();
            DataGridViewCellStyle dgcSachMuon = new DataGridViewCellStyle();
            dgcSachMuon.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtSachTra = new DataTable();
            dtSachTra.Columns.Add("Mã");
            dtSachTra.Columns.Add("Tên thiết bị");
            dtSachTra.Columns.Add("Tiền mượn");

            dgvSachTra.ColumnHeadersHeight = 40;
            dgvSachTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSachTra.DataSource = dtSachTra;
            //dgvSachMuon.Columns[0].DefaultCellStyle = dgcSachMuon;
            //dgvSachMuon.Columns[1].DefaultCellStyle = dgcSachMuon;
            //dgvSachMuon.Columns[2].DefaultCellStyle = dgcSachMuon;
            //dgvSachMuon.Columns[3].DefaultCellStyle = dgcSachMuon;

            //dgvSachMuon.Columns[0].Width = 50;
            //dgvSachMuon.Columns[1].Width = 80;
            //dgvSachMuon.Columns[2].Width = 320;
            //dgvSachMuon.Columns[3].Width = 150;

            dgvSachTra.Size = new Size(600, 200);
            dgvSachTra.Font = new Font("Times New Roman", 15, FontStyle.Regular);
            dgvSachTra.RowTemplate.Height = 30;
            dgvSachTra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSachTra.ReadOnly = true;
            dgvSachTra.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            dgvSachTra.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvSachTra.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSachTra.GridColor = Color.Black;
            dgvSachTra.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvSachTra.BorderStyle = BorderStyle.FixedSingle;
            Panel scrTblSachTra = new Panel();
            scrTblSachTra.BorderStyle = BorderStyle.FixedSingle; // Viền ngoài giống JScrollPane
            scrTblSachTra.Size = new Size(600, 200);
            scrTblSachTra.Location = new Point(650, 50);
            scrTblSachTra.Controls.Add(dgvSachTra);

            btnThemSach = new Button();
            btnThemSach.Text = "Thêm";
            btnThemSach.Font = new Font("Arial", 20, FontStyle.Bold);
            btnThemSach.Size = new Size(100, 40);
            btnThemSach.BackColor = Color.FromArgb(0xE0, 0x65, 0x76);
            btnThemSach.Location = new Point(570, 210);
            btnXoaSach = new Button();
            btnXoaSach.Text = "Xóa";
            btnXoaSach.Font = new Font("Arial", 20, FontStyle.Bold);
            btnXoaSach.Size = new Size(100, 40);
            btnXoaSach.BackColor = Color.FromArgb(0xE0, 0x65, 0x76);
            btnXoaSach.Location = new Point(720, 210);

            txtTimKiem = new TextBox();
            txtTimKiem.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            txtTimKiem.Size = new Size(350, 40);
            txtTimKiem.BackColor = Color.White;
            txtTimKiem.Location = new Point(650, 300);
            btnTim = new Button();
            btnTim.Text = "Tìm";
            btnTim.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            btnTim.BackColor = Color.FromArgb(0xD4, 0xF7, 0xF0);
            btnTim.Size = new Size(100, 40);
            btnTim.Location = new Point(1020, 295);

            dtpNgayBD = new DateTimePicker();
            dtpNgayKT = new DateTimePicker();
            dtpNgayBD.Format = DateTimePickerFormat.Custom;
            dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            dtpNgayKT.Format = DateTimePickerFormat.Custom;
            dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            dtpNgayBD.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            dtpNgayKT.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            dtpNgayBD.Size = new Size(200, 40);
            dtpNgayKT.Size = new Size(200, 40);
            dtpNgayBD.Location = new Point(650, 340);
            dtpNgayKT.Location = new Point(880, 340);
            btnLoc = CreateItemButton("image/img_qltv/icon_dgiachuatrasach.png", "Lọc");
            btnLoc.Size = new Size(140, 40);
            btnLoc.Location = new Point(1100, 340);

            //----------------------------------BUTTON-----------------------------------
            btnThem = CreateItemButton("image/img_qltv/icon_them.png", "Thêm");
            btnThem.Size = new Size(140, 40);
            btnThem.Location = new Point(50, 400);
            btnXoa = CreateItemButton("image/img_qltv/icon_xoa.png", "Xóa");
            btnXoa.Size = new Size(140, 40);
            btnXoa.Location = new Point(220, 400);
            btnInthe = CreateItemButton("image/img_qltv/icon_print.png", "In thẻ");
            btnInthe.Size = new Size(140, 40);
            btnInthe.Location = new Point(390, 400);
            btnNhapExcel = CreateItemButton("image/img_qltv/icon_excel.png", "Nhập");
            btnNhapExcel.Size = new Size(140, 40);
            btnNhapExcel.Location = new Point(560, 400);
            btnXuatExcel = CreateItemButton("image/img_qltv/icon_excel.png", "Xuất");
            btnXuatExcel.Size = new Size(140, 40);
            btnXuatExcel.Location = new Point(730, 400);
            btnReset = CreateItemButton("image/img_qltv/icon_reload.png", "");
            btnReset.Size = new Size(50, 40);
            btnReset.Location = new Point(900, 400);
            btnReset.BackColor = Color.FromArgb(0xE0, 0x65, 0x76);

            //----------------------------------TABLE PHIẾU TRẢ-----------------------------------
            dgvPhieuTra = new DataGridView();
            DataGridViewCellStyle dgcPhieuTra = new DataGridViewCellStyle();
            dgcPhieuTra.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtPhieuTra = new DataTable();
            dtPhieuTra.Columns.Add("ID");
            dtPhieuTra.Columns.Add("Người mượn");
            dtPhieuTra.Columns.Add("Nhân viên");
            dtPhieuTra.Columns.Add("Ngày mượn");
            dtPhieuTra.Columns.Add("Số lượng");
            dtPhieuTra.Columns.Add("Tổng tiền");

            dgvPhieuTra.ColumnHeadersHeight = 40;
            dgvPhieuTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuTra.DataSource = dtPhieuTra;
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

            dgvPhieuTra.Font = new Font("Times New Roman", 15, FontStyle.Regular);
            dgvPhieuTra.RowTemplate.Height = 30; // setRowHeight
            dgvPhieuTra.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            dgvPhieuTra.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B6F2E6");
            dgvPhieuTra.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvPhieuTra.EnableHeadersVisualStyles = false;
            dgvPhieuTra.GridColor = Color.Black;
            dgvPhieuTra.BorderStyle = BorderStyle.FixedSingle;
            dgvPhieuTra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Panel scrTblPhieuTra = new Panel();
            scrTblPhieuTra.Size = new Size(1250, 300);
            scrTblPhieuTra.Location = new Point(20, 470);
            scrTblPhieuTra.BorderStyle = BorderStyle.FixedSingle;
            scrTblPhieuTra.Controls.Add(dgvPhieuTra);
            dgvPhieuTra.Dock = DockStyle.Fill;

            pnPhieuTra.Controls.Add(lblTitle);
            pnPhieuTra.Controls.Add(btnClose);
            pnPhieuTra.Controls.Add(lblId);
            pnPhieuTra.Controls.Add(txtMaPhieuTra);
            pnPhieuTra.Controls.Add(lblMaPM);
            pnPhieuTra.Controls.Add(txtMaPhieuMuon);
            pnPhieuTra.Controls.Add(btnPhieuMuon);
            pnPhieuTra.Controls.Add(lblThanhVien);
            pnPhieuTra.Controls.Add(txtDocGia);
            pnPhieuTra.Controls.Add(lblNgayMuon);
            pnPhieuTra.Controls.Add(txtNgayMuon);
            pnPhieuTra.Controls.Add(lblNgayTra);
            pnPhieuTra.Controls.Add(txtNgayTra);
            pnPhieuTra.Controls.Add(lblNote);
            pnPhieuTra.Controls.Add(txtNote);
            pnPhieuTra.Controls.Add(scrTblSachTra);
            pnPhieuTra.Controls.Add(txtTimKiem);
            pnPhieuTra.Controls.Add(btnTim);
            pnPhieuTra.Controls.Add(dtpNgayBD);
            pnPhieuTra.Controls.Add(dtpNgayKT);
            pnPhieuTra.Controls.Add(btnLoc);
            pnPhieuTra.Controls.Add(btnReset);
            pnPhieuTra.Controls.Add(btnThem);
            pnPhieuTra.Controls.Add(btnXoa);
            pnPhieuTra.Controls.Add(btnInthe);
            pnPhieuTra.Controls.Add(btnNhapExcel);
            pnPhieuTra.Controls.Add(btnXuatExcel);
            pnPhieuTra.Controls.Add(scrTblPhieuTra);

            //------------------------------Bảng phiếu trả------------------------------
            pnPhieuTra.Dock = DockStyle.Fill;
            this.Controls.Add(pnPhieuTra);
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
