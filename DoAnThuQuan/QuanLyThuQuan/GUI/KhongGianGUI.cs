using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnThuQuan.QuanLyThuQuan.BUS;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using System.Data.SqlClient;
using Thuvien.DTO;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class KhongGianGUI : UserControl
    {
        
        private readonly Color headerColor = ColorTranslator.FromHtml("#65E0C7");
        private readonly Color bgColor = ColorTranslator.FromHtml("#FBF1F1");
        private ChoNgoiBUS choNgoiBUS = ChoNgoiBUS.Instance;
        private PhongBUS phongBUS = PhongBUS.Instance;
        
        public KhongGianGUI()
        {
            InitializeComponent();
            FormatDataGridViews();
            RemoveDragBorders();
            LoadKeData();
            LoadKhuVucData();
            LoadChoNgoiData();
            LoadPhongData();
            SetupDataGridViewProperties();
            SetupEventHandlers();
            SetupComboBoxes();
        }
      
        private void SetupDataGridViewProperties()
        {
            dgvKhuVucKe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachKhuVuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachKhuVuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

       private void SetupEventHandlers()
        {
            dgvKhuVucKe.CellClick += dgvKhuVucKe_CellClick;
            dgvDanhSachKhuVuc.CellClick += dgvDanhSachKhuVuc_CellClick;
            btnThemKe.Click += btnThemKe_Click;
            btnThemKhuVuc.Click += btnThemKhuVuc_Click;
            btnChinhSua.Click += btnChinhSua_Click;
            btnTimKiemKhuVuc.Click += btnTimKiemKhuVuc_Click;
            btnLoadKhuVuc.Click += btnLoadKhuVuc_Click;
            tabKhuVuc.Click += TabKhuVuc_Click;
            btnThemChoNgoi.Click += btnThemChoNgoi_Click;
            btnSuaChoNgoi.Click += btnSuaChoNgoi_Click;
            btnThemPhong.Click += btnThemPhong_Click;
            btnSuaPhong.Click += btnSuaPhong_Click;
            btnLoadPhong.Click += btnLoadPhong_Click;
            dgvPhong.CellClick += dgvPhong_CellClick;
            dgvChoNgoi.CellClick += dgvChoNgoi_CellClick;
            button1.Click += btnThemPhong_Click;  // Gán sự kiện cho button1 (Thêm phòng)
            button2.Click += btnSuaPhong_Click;   // Gán sự kiện cho button2 (Sửa phòng)
            btnTimPhong.Click += btnTimPhong_Click;
        }

        private void dgvChoNgoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChoNgoi.Rows[e.RowIndex];
                txtMaChoNgoi.Text = row.Cells[0].Value?.ToString();
                txtMaPhongChoNgoi.Text = row.Cells[1].Value?.ToString();
                cboTinhTrangChoNgoi.Text = row.Cells[2].Value?.ToString();
                txtViTri.Text = row.Cells[3].Value?.ToString();
                txtSoLuongChoNgoi.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhong.Rows[e.RowIndex];
                txtMaPhong.Text = row.Cells[0].Value?.ToString();
                txtSoLuong.Text = row.Cells[1].Value?.ToString();
                cboTinhTrangPhong.Text = row.Cells[2].Value?.ToString();
            }
        }

        private void FormatDataGridViews()
        {
            FormatDataGridView(dgvKhuVucKe);
            FormatDataGridView(dgvDanhSachKhuVuc);
            FormatDataGridView(dgvPhong);
            FormatDataGridView(dgvChoNgoi);
        }

        private void FormatDataGridView(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgv.BackgroundColor = bgColor;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.LightGray;
        }

        private void RemoveDragBorders()
        {
            // Set background color for the main control and panels
            this.BackColor = bgColor;
            tabKhuVucPhong.BackColor = bgColor;

            // Set background color for all panels
            pnlDanhSachKhuVuc.BackColor = bgColor;
            pnlThongTinKhuVuc.BackColor = bgColor;
            pnlTimKiemKhuVuc.BackColor = bgColor;
            pnlDanhSachPhong.BackColor = bgColor;
            pnlThongTinPhong.BackColor = bgColor;
            pnlTimKiemPhong.BackColor = bgColor;

            // Remove borders when dragging for all DataGridViews
            SetupDragDrop(dgvKhuVucKe);
            SetupDragDrop(dgvDanhSachKhuVuc);
            SetupDragDrop(dgvPhong);
            SetupDragDrop(dgvChoNgoi);

            // Set the control to handle its own drag-drop events
            this.AllowDrop = true;
            this.DragEnter += DataGridView_DragEnter;
            this.DragOver += DataGridView_DragOver;
        }

        private void SetupDragDrop(DataGridView dgv)
        {
            dgv.AllowDrop = true;
            dgv.BorderStyle = BorderStyle.None;
            dgv.DragEnter += DataGridView_DragEnter;
            dgv.DragOver += DataGridView_DragOver;
        }
        

        private void LoadKeData()
        {
            KeBUS keBUS = new KeBUS();
            ArrayList listKe = keBUS.GetListKe();

            dgvKhuVucKe.Rows.Clear();
            foreach (ke k in listKe)
            {
                dgvKhuVucKe.Rows.Add(k.id_ke, k.id_khuvuc);
            }
        }

        private void LoadKhuVucData()
        {
            KhuVucBUS khuVucBUS = new KhuVucBUS();
            ArrayList listKhuVuc = khuVucBUS.GetListKhuVuc();

            dgvDanhSachKhuVuc.Rows.Clear();
            foreach (KhuVuc kv in listKhuVuc)
            {
                dgvDanhSachKhuVuc.Rows.Add(kv.idKhuVuc, kv.tenKhuVuc);
            }
        }

        private void LoadChoNgoiData()
        {
            try
            {
                dgvChoNgoi.Rows.Clear();
                List<ChoNgoi> listChoNgoi = ChoNgoiBUS.Instance.LayDanhSachChoNgoi();
                foreach (ChoNgoi choNgoi in listChoNgoi)
                {
                    string trangThai = "0 - Không hoạt động";
                    if (int.TryParse(choNgoi.TrangThai, out int trangThaiInt) && trangThaiInt == 1)
                    {
                        trangThai = "1 - Hoạt động";
                    }
                    
                    dgvChoNgoi.Rows.Add(
                        choNgoi.MaChoNgoi,
                        choNgoi.MaPhong,
                        trangThai,
                        choNgoi.ViTri,
                        choNgoi.SoLuong
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu chỗ ngồi: " + ex.Message);
            }
        }

        private void LoadPhongData()
        {
            try
            {
                dgvPhong.Rows.Clear();
                List<Phong> listPhong = PhongBUS.Instance.LayDanhSachPhong();
                foreach (Phong phong in listPhong)
                {
                    string tinhTrang = "0 - Không hoạt động";
                    if (int.TryParse(phong.TinhTrang, out int tinhTrangInt) && tinhTrangInt == 1)
                    {
                        tinhTrang = "1 - Hoạt động";
                    }
                    
                    dgvPhong.Rows.Add(
                        phong.MaPhong,
                        phong.SoChoNgoi,
                        tinhTrang
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu phòng: " + ex.Message);
            }
        }

        private void DataGridView_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void DataGridView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void TabKhuVuc_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện click vào tab Khu Vực
            LoadKhuVucData();
        }

        private void lblMaChoNgoi_Click_1(object sender, EventArgs e)
        {
            // Xử lý sự kiện click vào label Mã Chỗ Ngồi
            txtMaChoNgoi.Focus();
        }

        private void btnThemKe_Click(object sender, EventArgs e)
        {
            int maKe, maKhuVuc;
            if (!int.TryParse(txtMaKhuVuc.Text.Trim(), out maKhuVuc))
            {
                MessageBox.Show("Mã khu vực không hợp lệ!");
                return;
            }
            maKe = dgvKhuVucKe.Rows.Count + 1;

            KeBUS keBUS = new KeBUS();
            if (keBUS.ThemKe(maKe, maKhuVuc))
            {
                LoadKeData();
            }
        }

        private void btnThemKhuVuc_Click(object sender, EventArgs e)
        {
            int maKhuVuc;
            string tenKhuVuc = txtTenKhuVuc.Text.Trim();
            if (!int.TryParse(txtMaKhuVuc.Text.Trim(), out maKhuVuc))
            {
                MessageBox.Show("Mã khu vực không hợp lệ!");
                return;
            }

            KhuVucBUS khuVucBUS = new KhuVucBUS();
            if (khuVucBUS.ThemKhuVuc(maKhuVuc, tenKhuVuc))
            {
                LoadKhuVucData();
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            int maKhuVuc;
            string tenKhuVuc = txtTenKhuVuc.Text.Trim();
            if (!int.TryParse(txtMaKhuVuc.Text.Trim(), out maKhuVuc))
            {
                MessageBox.Show("Mã khu vực không hợp lệ!");
                return;
            }

            KhuVucBUS khuVucBUS = new KhuVucBUS();
            if (khuVucBUS.SuaKhuVuc(maKhuVuc, tenKhuVuc))
            {
                LoadKhuVucData();
            }
        }

        private void btnTimKiemKhuVuc_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemKhuVuc.Text.Trim().ToLower();
            KhuVucBUS khuVucBUS = new KhuVucBUS();
            ArrayList listKhuVuc = khuVucBUS.GetListKhuVuc();

            dgvDanhSachKhuVuc.Rows.Clear();
            foreach (KhuVuc kv in listKhuVuc)
            {
                if (kv.tenKhuVuc.ToLower().Contains(tuKhoa) || kv.idKhuVuc.ToString().Contains(tuKhoa))
                {
                    dgvDanhSachKhuVuc.Rows.Add(kv.idKhuVuc, kv.tenKhuVuc);
                }
            }
        }

        private void dgvKhuVucKe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhuVucKe.Rows[e.RowIndex];
                txtMaKhuVuc.Text = row.Cells["Column2"].Value.ToString();
            }
        }

        private void dgvDanhSachKhuVuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSachKhuVuc.Rows[e.RowIndex];
                txtMaKhuVuc.Text = row.Cells["Column3"].Value.ToString();
                txtTenKhuVuc.Text = row.Cells["Column4"].Value.ToString();
            }
        }

        private void SetupComboBoxes()
        {
            // Thêm các giá trị cho ComboBox tình trạng
            cboTinhTrangChoNgoi.Items.Clear();
            cboTinhTrangChoNgoi.Items.Add("0 - Không hoạt động");
            cboTinhTrangChoNgoi.Items.Add("1 - Hoạt động");
            cboTinhTrangChoNgoi.SelectedIndex = 1;

            cboTinhTrangPhong.Items.Clear();
            cboTinhTrangPhong.Items.Add("0 - Không hoạt động");
            cboTinhTrangPhong.Items.Add("1 - Hoạt động");
            cboTinhTrangPhong.SelectedIndex = 1;
        }

        private bool KiemTraPhongTonTai(string maPhong)
        {
            try
            {
                if (!int.TryParse(maPhong, out int maPhongInt))
                {
                    return false;
                }

                ArrayList listPhong = phongBUS.GetListPhong();
                foreach (Phong p in listPhong)
                {
                    if (p.maPhong == maPhongInt)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi kiểm tra phòng: " + ex.Message);
                return false;
            }
        }

        private bool KiemTraViTriTonTai(string maPhong, string viTri, string maChoNgoi = null)
        {
            try
            {
                if (!int.TryParse(maPhong, out int maPhongInt) || !int.TryParse(viTri, out int viTriInt))
                {
                    return false;
                }

                ArrayList listChoNgoi = choNgoiBUS.GetListChoNgoi();
                foreach (ChoNgoi cn in listChoNgoi)
                {
                    // Nếu đang sửa chỗ ngồi, bỏ qua chỗ ngồi hiện tại
                    if (maChoNgoi != null && cn.idChoNgoi.ToString() == maChoNgoi)
                    {
                        continue;
                    }

                    if (cn.idPhong == maPhongInt && cn.viTri == viTriInt)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi kiểm tra vị trí: " + ex.Message);
                return false;
            }
        }

       private bool KiemTraSoLuongChoNgoi(string idPhong, string soLuong, string maChoNgoi = null)
        {
            try
            {
                Phong phong = PhongBUS.Instance.GetPhongById(idPhong);
                if(phong != null)
                {
                    int tongSoLuong = 0;
                    List<ChoNgoi> listChoNgoi = ChoNgoiBUS.Instance.LayDanhSachChoNgoi();
                    foreach(ChoNgoi cn in listChoNgoi)
                    {
                        if(cn.MaPhong == phong.MaPhong && (maChoNgoi == null || cn.MaChoNgoi != maChoNgoi))
                        {
                            tongSoLuong += cn.SoLuong;
                        }
                    }
                    return tongSoLuong + int.Parse(soLuong) <= phong.SoChoNgoi;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi kiểm tra số lượng chỗ ngồi: " + ex.Message);
                return false;
            }
        }

        private void btnThemChoNgoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaChoNgoi.Text) || string.IsNullOrEmpty(txtMaPhongChoNgoi.Text) ||
                    string.IsNullOrEmpty(txtViTri.Text) || string.IsNullOrEmpty(txtSoLuongChoNgoi.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin chỗ ngồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ChoNgoi choNgoi = new ChoNgoi();
                choNgoi.MaChoNgoi = txtMaChoNgoi.Text;
                choNgoi.MaPhong = txtMaPhongChoNgoi.Text;
                choNgoi.ViTri = txtViTri.Text;
                choNgoi.SoLuong = int.Parse(txtSoLuongChoNgoi.Text);
                choNgoi.TrangThai = cboTinhTrangChoNgoi.Text;

                if (ChoNgoiBUS.Instance.ThemChoNgoi(choNgoi))
                {
                    MessageBox.Show("Thêm chỗ ngồi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChoNgoiData();
                    ClearChoNgoiInputs();
                }
                else
                {
                    MessageBox.Show("Thêm chỗ ngồi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaChoNgoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaChoNgoi.Text) || string.IsNullOrEmpty(txtMaPhongChoNgoi.Text) ||
                    string.IsNullOrEmpty(txtViTri.Text) || string.IsNullOrEmpty(txtSoLuongChoNgoi.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin chỗ ngồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ChoNgoi choNgoi = new ChoNgoi();
                choNgoi.MaChoNgoi = txtMaChoNgoi.Text;
                choNgoi.MaPhong = txtMaPhongChoNgoi.Text;
                choNgoi.ViTri = txtViTri.Text;
                choNgoi.SoLuong = int.Parse(txtSoLuongChoNgoi.Text);
                choNgoi.TrangThai = cboTinhTrangChoNgoi.Text;

                if (ChoNgoiBUS.Instance.SuaChoNgoi(choNgoi))
                {
                    MessageBox.Show("Cập nhật chỗ ngồi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChoNgoiData();
                    ClearChoNgoiInputs();
                }
                else
                {
                    MessageBox.Show("Cập nhật chỗ ngồi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearChoNgoiInputs()
        {
            txtMaChoNgoi.Clear();
            txtMaPhongChoNgoi.Clear();
            txtViTri.Clear();
            txtSoLuongChoNgoi.Clear();
            cboTinhTrangChoNgoi.SelectedIndex = 1; // Mặc định là "Hoạt động"
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaPhong.Text) || string.IsNullOrEmpty(txtSoLuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Phong phong = new Phong();
                phong.MaPhong = txtMaPhong.Text;
                phong.SoChoNgoi = int.Parse(txtSoLuong.Text);
                phong.TinhTrang = cboTinhTrangPhong.Text;

                if (PhongBUS.Instance.ThemPhong(phong))
                {
                    MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPhongData();
                    ClearPhongInputs();
                }
                else
                {
                    MessageBox.Show("Thêm phòng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaPhong.Text) || string.IsNullOrEmpty(txtSoLuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Phong phong = new Phong();
                phong.MaPhong = txtMaPhong.Text;
                phong.SoChoNgoi = int.Parse(txtSoLuong.Text);
                phong.TinhTrang = cboTinhTrangPhong.Text;

                if (PhongBUS.Instance.SuaPhong(phong))
                {
                    MessageBox.Show("Cập nhật phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPhongData();
                    ClearPhongInputs();
                }
                else
                {
                    MessageBox.Show("Cập nhật phòng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearPhongInputs()
        {
            txtMaPhong.Clear();
            txtSoLuong.Clear();
            cboTinhTrangPhong.SelectedIndex = 0;
        }

        private void btnLoadPhong_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPhongData();
                LoadChoNgoiData(); // Cập nhật cả danh sách chỗ ngồi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLoadKhuVuc_Click(object sender, EventArgs e)
        {
            try
            {
                LoadKhuVucData();
                LoadKeData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTimPhong_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhong = txtTimKiemPhong.Text.Trim();
                if (string.IsNullOrEmpty(maPhong))
                {
                    MessageBox.Show("Vui lòng nhập mã phòng cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dgvPhong.Rows.Clear();
                List<Phong> listPhong = PhongBUS.Instance.LayDanhSachPhong();
                bool timThay = false;

                foreach (Phong phong in listPhong)
                {
                    if (phong.MaPhong.ToLower().Contains(maPhong.ToLower()))
                    {
                        string tinhTrang = "0 - Không hoạt động";
                        if (int.TryParse(phong.TinhTrang, out int tinhTrangInt) && tinhTrangInt == 1)
                        {
                            tinhTrang = "1 - Hoạt động";
                        }

                        dgvPhong.Rows.Add(
                            phong.MaPhong,
                            phong.SoChoNgoi,
                            tinhTrang
                        );
                        timThay = true;
                    }
                }

                if (!timThay)
                {
                    MessageBox.Show("Không tìm thấy phòng có mã: " + maPhong, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPhongData(); // Load lại toàn bộ dữ liệu nếu không tìm thấy
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm phòng: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}