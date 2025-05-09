using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    internal class PnQuanLyDatChoGUI : UserControl
    {
        private Color colorPanel = Color.FromArgb(0xFB, 0xF1, 0xF1);
        private DataGridView dgvPhieuDatCho;
        private DataTable dtPhieuDatCho;
        private TextBox txtMaPhieu, txtMaThanhVien, txtTenThanhVien, txtSoLuong, txtThoiGianDat, txtNote;
        private Button btnThanhVien, btnThemPhieu, btnXoaPhieu, btnSuaPhieu, btnInPhieu;
        public PnQuanLyDatChoGUI() 
        {
            AddControls();
        }

        private void AddControls()
        {
            this.Text = "Quản lý phiếu đặt chỗ";
            this.Size = new Size(1290, 760);

            Panel pnPhieuDatCho = new Panel();
            pnPhieuDatCho.AutoSize = false;
            pnPhieuDatCho.BackColor = colorPanel;

            Label lblTitle = new Label();
            lblTitle.Text = "PHIẾU ĐẶT CHỖ";
            lblTitle.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            lblTitle.Size = new Size(350, 30);
            lblTitle.Location = new Point(500, 0);

            Label lblId = CreateLabel("ID: ");
            lblId.Size = new Size(100, 30);
            lblId.Location = new Point(20, 50);
            txtMaPhieu = CreateTextBox();
            txtMaPhieu.Location = new Point(170, 50);
            txtMaPhieu.Enabled = false;

            Label lblMaTV = CreateLabel("Mã TV: ");
            lblMaTV.Size = new Size(100, 30);
            lblMaTV.Location = new Point(20, 90);
            txtMaThanhVien = CreateTextBox();
            txtMaThanhVien.Location = new Point(170, 90);
            txtMaThanhVien.Enabled = false;
            btnThanhVien = new Button();
            btnThanhVien.Text = "...";
            btnThanhVien.Size = new Size(30, 30);
            btnThanhVien.Location = new Point(480, 90);

            Label lblTenTV = CreateLabel("Tên TV: ");
            lblTenTV.Size = new Size(100, 30);
            lblTenTV.Location = new Point(20, 130);
            txtTenThanhVien = CreateTextBox();
            txtTenThanhVien.Location = new Point(170, 130);
            txtTenThanhVien.Enabled = false;

            Label lblSoLuong = CreateLabel("Số lượng: ");
            lblSoLuong.Size = new Size(100, 30);
            lblSoLuong.Location = new Point(20, 170);
            txtSoLuong = CreateTextBox();
            txtSoLuong.Location = new Point(170, 170);

            Label lblTGDat = CreateLabel("Thời gian:");
            lblTGDat.Size = new Size(130, 30);
            lblTGDat.Location = new Point(20, 210);
            txtThoiGianDat = CreateTextBox();
            txtThoiGianDat.Location = new Point(170, 210);
            txtThoiGianDat.Enabled = false;

            Label lblNote = CreateLabel("Ghi chú:");
            lblNote.Size = new Size(150, 30);
            lblNote.Location = new Point(20, 250);
            txtNote = new TextBox();
            txtNote.Multiline = true;
            txtNote.Size = new Size(300, 125);
            txtNote.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            txtNote.BackColor = Color.White;
            txtNote.Location = new Point(170, 250);

            //--------------------Bảng phiếu đặt chỗ-----------------------
            dgvPhieuDatCho = new DataGridView();
            DataGridViewCellStyle dgcPhieuDatCho = new DataGridViewCellStyle();
            dgcPhieuDatCho.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtPhieuDatCho = new DataTable();
            dtPhieuDatCho.Columns.Add("Mã");
            dtPhieuDatCho.Columns.Add("Tên TV");
            dtPhieuDatCho.Columns.Add("SL");
            dtPhieuDatCho.Columns.Add("Time");
            dtPhieuDatCho.Columns.Add("Note");

            dgvPhieuDatCho.ColumnHeadersHeight = 40;
            dgvPhieuDatCho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuDatCho.DataSource = dtPhieuDatCho;

            //dgvSachMuon.Columns[0].DefaultCellStyle = dgcSachMuon;
            //dgvSachMuon.Columns[1].DefaultCellStyle = dgcSachMuon;
            //dgvSachMuon.Columns[2].DefaultCellStyle = dgcSachMuon;
            //dgvSachMuon.Columns[3].DefaultCellStyle = dgcSachMuon;

            //dgvSachMuon.Columns[0].Width = 50;
            //dgvSachMuon.Columns[1].Width = 80;
            //dgvSachMuon.Columns[2].Width = 320;
            //dgvSachMuon.Columns[3].Width = 150;

            dgvPhieuDatCho.Font = new Font("Times New Roman", 15, FontStyle.Regular);
            dgvPhieuDatCho.RowTemplate.Height = 30; // setRowHeight
            dgvPhieuDatCho.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 20, FontStyle.Bold);
            dgvPhieuDatCho.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B6F2E6");
            dgvPhieuDatCho.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvPhieuDatCho.EnableHeadersVisualStyles = false;
            dgvPhieuDatCho.GridColor = Color.Black;
            dgvPhieuDatCho.BorderStyle = BorderStyle.FixedSingle;
            dgvPhieuDatCho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Panel scrTblPhieuDatCho = new Panel();
            scrTblPhieuDatCho.Size = new Size(650, 500);
            scrTblPhieuDatCho.Location = new Point(600, 50);
            scrTblPhieuDatCho.BorderStyle = BorderStyle.FixedSingle;
            scrTblPhieuDatCho.Controls.Add(dgvPhieuDatCho);
            dgvPhieuDatCho.Dock = DockStyle.Fill;

            //----------------------------------BUTTON-----------------------------------
            btnThemPhieu = CreateItemButton("image/img_qltv/icon_them.png", "Thêm");
            btnThemPhieu.Size = new Size(140, 40);
            btnThemPhieu.Location = new Point(650, 600);
            btnSuaPhieu = CreateItemButton("image/img_qltv/icon_sua.png", "Sửa");
            btnSuaPhieu.Size = new Size(140, 40);
            btnSuaPhieu.Location = new Point(840, 600);
            btnXoaPhieu = CreateItemButton("image/img_qltv/icon_xoa.png", "Xóa");
            btnXoaPhieu.Size = new Size(140, 40);
            btnXoaPhieu.Location = new Point(1030, 600);
            btnInPhieu = CreateItemButton("image/img_qltv/icon_print.png", "In thẻ");
            btnInPhieu.Size = new Size(140, 40);
            btnInPhieu.Location = new Point(220, 400);

            pnPhieuDatCho.Controls.Add(lblTitle);
            pnPhieuDatCho.Controls.Add(lblId);
            pnPhieuDatCho.Controls.Add(txtMaPhieu);
            pnPhieuDatCho.Controls.Add(lblMaTV);
            pnPhieuDatCho.Controls.Add(txtMaThanhVien);
            pnPhieuDatCho.Controls.Add(btnThanhVien);
            pnPhieuDatCho.Controls.Add(lblTenTV);
            pnPhieuDatCho.Controls.Add(txtTenThanhVien);
            pnPhieuDatCho.Controls.Add(lblSoLuong);
            pnPhieuDatCho.Controls.Add(txtSoLuong);
            pnPhieuDatCho.Controls.Add(lblTGDat);
            pnPhieuDatCho.Controls.Add(txtThoiGianDat);
            pnPhieuDatCho.Controls.Add(lblNote);
            pnPhieuDatCho.Controls.Add(txtNote);
            pnPhieuDatCho.Controls.Add(scrTblPhieuDatCho);
            pnPhieuDatCho.Controls.Add(btnThemPhieu);
            pnPhieuDatCho.Controls.Add(btnXoaPhieu);
            pnPhieuDatCho.Controls.Add(btnSuaPhieu);
            pnPhieuDatCho.Controls.Add(btnInPhieu);

            //------------------------------Bảng phiếu đặt chỗ------------------------------
            pnPhieuDatCho.Dock = DockStyle.Fill;
            this.Controls.Add(pnPhieuDatCho);
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
