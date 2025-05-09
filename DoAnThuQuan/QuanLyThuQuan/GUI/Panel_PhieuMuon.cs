using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DoAnThuQuan.QuanLyThuQuan.BUS;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using System.Collections;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using DocumentFormat.OpenXml.Spreadsheet;
using Thuvien.DTO;
using DoAnThuQuan.QuanLyThuQuan.DAO;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Panel_PhieuMuon : UserControl
    {
        // Khai báo BUS
        private PhieuMuonBUS phieuMuonBUS = new PhieuMuonBUS();
        private UserBUS userBUS = new UserBUS();
        private CTPhieuMuon_BUS ctpmBUS = new CTPhieuMuon_BUS();
        private SachDetailBUS sachdetailBUS = new SachDetailBUS();
        private MayChieuBUS maychieuBUS = new MayChieuBUS();
        private MayTinhBUS maytinhBUS = new MayTinhBUS();
        private bool isSelectedDocGia = false;
        private bool isSelectedMonDo = false;

        public Panel_PhieuMuon()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadData();
        }
        // Thiết lập DataGridView
        private void SetupDataGridView()
        {
            // Thiết lập cho dataGridView_PMuon
            dataGridView_PMuon.Columns.Clear();
            dataGridView_PMuon.Columns.Add("id_phieumuon", "Mã Phiếu Mượn");
            dataGridView_PMuon.Columns.Add("tgian_muon", "Thời Gian Mượn");
            dataGridView_PMuon.Columns.Add("solg", "Số Lượng");
            dataGridView_PMuon.Columns.Add("ngmuon", "Mã Người Mượn");
            dataGridView_PMuon.Columns.Add("nvien", "Mã Nhân Viên");

            // Đặt độ rộng cột cho dataGridView_PMuon
            dataGridView_PMuon.Columns["id_phieumuon"].Width = 150;
            dataGridView_PMuon.Columns["tgian_muon"].Width = 200;
            dataGridView_PMuon.Columns["solg"].Width = 150;
            dataGridView_PMuon.Columns["ngmuon"].Width = 150;
            dataGridView_PMuon.Columns["nvien"].Width = 150;
            dataGridView_PMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Thiết lập cho dataGridView_CTPM
            dataGridView_CTPM.Columns.Clear();
            dataGridView_CTPM.Columns.Add("maPhieuMuon", "Mã Phiếu Mượn");
            dataGridView_CTPM.Columns.Add("maMonDo", "Mã Món Đồ");

            // Đặt độ rộng cột cho dataGridView_CTPM
            dataGridView_CTPM.Columns["maPhieuMuon"].Width = 150;
            dataGridView_CTPM.Columns["maMonDo"].Width = 150;
            dataGridView_CTPM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        // Load dữ liệu
        private void LoadData()
        {
            try
            {
                dataGridView_PMuon.Rows.Clear();
                dataGridView_CTPM.Rows.Clear();
                label_IDPMuon.Text = "";
                label_NgayMuon.Text = "";
                textBox_IDDocGia.Text = "";
                label_IDNVien.Text = "";
                label_TenNhanVien.Text = "";
                label_TenDocGia.Text = "";
                // Load danh sách phiếu mượn
                ArrayList listPhieuMuon = phieuMuonBUS.GetListPhieuMuon();
                if (listPhieuMuon != null && listPhieuMuon.Count > 0)
                {
                    foreach (PhieuMuon pm in listPhieuMuon)
                    {
                        if (pm != null)
                        {
                            dataGridView_PMuon.Rows.Add(
                                pm.idPhieuMuon,
                                pm.tgianMuon.ToString("dd/MM/yyyy HH:mm:ss"),
                                pm.solg,
                                pm.ngMuon,
                                pm.idNhanVien
                            );
                        }
                    }
                }

                // Load tất cả chi tiết phiếu mượn
                ArrayList listChiTiet = phieuMuonBUS.GetAllChiTietPhieuMuon();
                if (listChiTiet != null && listChiTiet.Count > 0)
                {
                    foreach (var chiTiet in listChiTiet)
                    {
                        try
                        {
                            var ct = (dynamic)chiTiet;
                            dataGridView_CTPM.Rows.Add(
                                ct.MaPhieuMuon,
                                ct.MaMonDo,
                                ct.ThoiGianMuon.ToString("dd/MM/yyyy HH:mm:ss"),
                                ct.NguoiMuon,
                                ct.NhanVien
                            );
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi thêm dòng chi tiết: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}\nChi tiết: {ex.StackTrace}");
            }
        }
        // Chọn đọc giả
        private void button_DocGia_Click(object sender, EventArgs e)
        {
            isSelectedDocGia = true;
            dataGridView_CTPM.Columns.Clear();
            dataGridView_CTPM.Columns.Add("maPhieuMuon", "Mã Phiếu Mượn");
            dataGridView_CTPM.Columns.Add("maMonDo", "Mã Món Đồ");
            Form newFormDialog = new Form
            {
                Text = "Danh Sách Các Đọc Gỉa",
                Size = new Size(1005, 500),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Component_DocGia panel = new Component_DocGia
            {
                Dock = DockStyle.Fill
            };

            // Gán sự kiện khi chọn một phiếu mượn
            panel.OnRowSelected += (user) =>
            {
                MessageBox.Show($"Đã chọn đọc giả có ID: {user.userId}");

                label_IDPMuon.Text = phieuMuonBUS.createeNewPhieuMuon().ToString();
                label_NgayMuon.Text = DateTime.Now.ToString("yyyy-MM-dd");
                textBox_IDDocGia.Text = user.userId.ToString();
                label_TenDocGia.Text = user.fullName.ToString();
                label_IDNVien.Text = UserSession.UserId.ToString();
                label_TenNhanVien.Text = userBUS.getUserById(UserSession.UserId).fullName;
                newFormDialog.Close();
            };

            newFormDialog.Controls.Add(panel);
            newFormDialog.ShowDialog();
        }
        // Chọn loại thiết bị
        private void comboBox_LoaiTBi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Panel_PhieuMuon_Load(object sender, EventArgs e)
        {
            string[] items = { "Sách", "Máy Tính", "Máy Chiếu" };
            comboBox_LoaiTBi.Items.AddRange(items);

        }
        // Chọn mã thiết bị
        private void button_MaTBi_Click(object sender, EventArgs e)
        {
            if (isSelectedDocGia == false)
            {
                MessageBox.Show("Vui lòng chọn một đọc giả trước");
                return;
            }

            isSelectedMonDo = true;
            string selectedItem = comboBox_LoaiTBi.SelectedItem as string;
            if (string.IsNullOrEmpty(selectedItem))
            {
                MessageBox.Show("Vui lòng chọn một mục trong loại thiết bị!");
                return;
            }

            Form dialogForm = new Form
            {
                Text = "Chọn Thiết Bị",
                Size = new Size(1005, 500),
                StartPosition = FormStartPosition.CenterParent
            };

            UserControl controlToShow = null;

            if (selectedItem == "Sách")
            {
                var ucSach = new Component_PhanSach();
                ucSach.Dock = DockStyle.Fill;

                // Sự kiện chọn sách
                ucSach.OnPhanSachSelected += (detail) =>
                {
                    // Kiểm tra trùng
                    bool isDuplicate = false;
                    foreach (DataGridViewRow row in dataGridView_CTPM.Rows)
                    {
                        if (row.Cells[1].Value?.ToString() == detail.maDauSach)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }

                    if (isDuplicate)
                    {
                        MessageBox.Show("Thiết bị đã được chọn, không thể mượn trùng lặp!");
                        return;
                    }

                    MessageBox.Show($"Đã chọn phân sách có ID: {detail.maDauSach}");
                    dataGridView_CTPM.Rows.Add(label_IDPMuon.Text, detail.maDauSach);
                    dialogForm.Close();
                };

                controlToShow = ucSach;
            }
            else if (selectedItem == "Máy Tính")
            {
                var ucMayTinh = new Component_MayTinh();
                ucMayTinh.Dock = DockStyle.Fill;

                ucMayTinh.OnMayTinhSelected += (detail) =>
                {
                    bool isDuplicate = false;
                    foreach (DataGridViewRow row in dataGridView_CTPM.Rows)
                    {
                        if (row.Cells[1].Value?.ToString() == detail.idSeriMaytinh)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }

                    if (isDuplicate)
                    {
                        MessageBox.Show("Thiết bị đã được chọn, không thể mượn trùng lặp!");
                        return;
                    }

                    MessageBox.Show($"Đã chọn máy tính có ID: {detail.idSeriMaytinh}");
                    dataGridView_CTPM.Rows.Add(label_IDPMuon.Text, detail.idSeriMaytinh);
                    dialogForm.Close();
                };

                controlToShow = ucMayTinh;
            }
            else if (selectedItem == "Máy Chiếu")
            {
                var ucMayChieu = new Component_MayChieu();
                ucMayChieu.Dock = DockStyle.Fill;

                ucMayChieu.OnMayChieuSelected += (detail) =>
                {
                    bool isDuplicate = false;
                    foreach (DataGridViewRow row in dataGridView_CTPM.Rows)
                    {
                        if (row.Cells[1].Value?.ToString() == detail.idSeriMaychieu)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }

                    if (isDuplicate)
                    {
                        MessageBox.Show("Thiết bị đã được chọn, không thể mượn trùng lặp!");
                        return;
                    }

                    MessageBox.Show($"Đã chọn máy chiếu có ID: {detail.idSeriMaychieu}");
                    dataGridView_CTPM.Rows.Add(label_IDPMuon.Text, detail.idSeriMaychieu);
                    dialogForm.Close();
                };

                controlToShow = ucMayChieu;
            }
            else
            {
                MessageBox.Show("Không xác định mục đã chọn!");
                return;
            }

            dialogForm.Controls.Add(controlToShow);
            dialogForm.ShowDialog();
        }

        // Reload
        private void button_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void button_themPhieu_Click(object sender, EventArgs e)
        {
            if (isSelectedMonDo = false)
            {
                MessageBox.Show("Vui lòng chọn mã đọc giả và chọn các món đò muốn mượn!");
                return;
            }
            int idPhieuMuon = int.Parse(label_IDPMuon.Text);
            int idDocGia = int.Parse(textBox_IDDocGia.Text);
            int idNhanVien = UserSession.UserId;
            DateTime ngayMuon = DateTime.Now;

            int soLuongMuon = dataGridView_CTPM.AllowUserToAddRows
                ? dataGridView_CTPM.Rows.Count - 1
                : dataGridView_CTPM.Rows.Count;

            bool daThemPhieu = phieuMuonBUS.ThemPhieuMuon(idPhieuMuon, ngayMuon, soLuongMuon, idDocGia, idNhanVien);

            if (!daThemPhieu)
            {
                MessageBox.Show("Xảy ra vấn đề khi thêm phiếu!");
                
                return;
            }

            foreach (DataGridViewRow row in dataGridView_CTPM.Rows)
            {
                if (row.IsNewRow) continue;

                string maThietBi = row.Cells[1].Value?.ToString();
                int maPhieuMuon = idPhieuMuon;

                if (string.IsNullOrEmpty(maThietBi)) continue;

                // Thêm chi tiết phiếu mượn
                bool daThemCTPM = ctpmBUS.ThemCTPM(maPhieuMuon, maThietBi);
                if (!daThemCTPM)
                {
                    MessageBox.Show("Đã có vấn đề xảy ra với hệ thống khi thêm chi tiết phiếu mượn!");
                    break;
                }

                // Cập nhật thiết bị tương ứng
                bool capNhatThanhCong = CapNhatTrangThaiThietBi(maThietBi);
                if (!capNhatThanhCong)
                {
                    MessageBox.Show("Đã có vấn đề xảy ra khi cập nhật thiết bị!");
                    break;
                }
            }
            dataGridView_PMuon.Rows.Add(idPhieuMuon,ngayMuon.ToString("dd/MM/yyyy HH:mm:ss"),soLuongMuon,idDocGia,idNhanVien);
            label_IDPMuon.Text = "";
            label_NgayMuon.Text = "";
            textBox_IDDocGia.Text = "";
            label_IDNVien.Text = "";
            label_TenNhanVien.Text = "";
            label_TenDocGia.Text = "";
            isSelectedDocGia = false;
            isSelectedMonDo = false;
        }

        /// <summary>
        /// Cập nhật trạng thái thiết bị theo loại mã (MD, MT, MC)
        /// </summary>
        private bool CapNhatTrangThaiThietBi(string maThietBi)
        {
            if (maThietBi.StartsWith("MD"))
                return sachdetailBUS.CapNhatTrangThaiSachDetail(maThietBi, 0);

            if (maThietBi.StartsWith("MT"))
                return maytinhBUS.GiamSoLgMayTinh(maThietBi);

            if (maThietBi.StartsWith("MC"))
                return maychieuBUS.GiamSoLgMayChieu(maThietBi);

            return false; // Không đúng định dạng mã
        }

        // Xóa phiếu mượn
        private void button_deletePhieu_Click(object sender, EventArgs e)
        {
            if (dataGridView_PMuon.SelectedRows.Count > 0)
            {
                int maPhieuMuon = int.Parse(dataGridView_PMuon.SelectedRows[0].Cells[0].Value.ToString());

                if (phieuMuonBUS.XoaPhieuMuon(maPhieuMuon))
                {
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần xóa!");
            }
        }
        // Tìm kiếm phiếu mượn
        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            string keyword = textBox_TimKiem.Text.ToLower();
            dataGridView_PMuon.Rows.Clear(); // Xóa kết quả cũ

            ArrayList listPhieuMuon = phieuMuonBUS.GetListPhieuMuon();
            bool found = false;

            foreach (PhieuMuon pm in listPhieuMuon)
            {
                // Kiểm tra nếu từ khóa xuất hiện trong bất kỳ trường nào
                if (pm.idPhieuMuon.ToString().ToLower().Contains(keyword) ||
                    pm.tgianMuon.ToString("dd/MM/yyyy").ToLower().Contains(keyword) ||
                    pm.solg.ToString().ToLower().Contains(keyword) ||
                    pm.ngMuon.ToString().ToLower().Contains(keyword) ||
                    pm.idNhanVien.ToString().ToLower().Contains(keyword))
                {
                    // Nếu khớp, thì thêm vào DataGridView
                    dataGridView_PMuon.Rows.Add(
                        pm.idPhieuMuon,
                        pm.tgianMuon.ToString("dd/MM/yyyy"),
                        pm.solg,
                        pm.ngMuon,
                        pm.idNhanVien
                    );
                    found = true;
                }
            }

            // Nếu không tìm thấy bản ghi nào
            if (!found)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Hiển thị chi tiết phiếu mượn
        private void dataGridView_PMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView_PMuon.Rows[e.RowIndex];
                    label_IDPMuon.Text = row.Cells[0].Value.ToString();
                    label_NgayMuon.Text = row.Cells[1].Value.ToString();
                    textBox_IDDocGia.Text = row.Cells[3].Value.ToString();
                    label_IDNVien.Text = row.Cells[4].Value.ToString();
                    int userId = Convert.ToInt32(row.Cells[4].Value);
                    var user = userBUS.getUserById(userId);
                    if (user != null)
                    {
                        label_TenNhanVien.Text = user.fullName;
                    }
                    else
                    {
                        label_TenNhanVien.Text = "Không tìm thấy";
                    }
                    int id_docgia=Convert.ToInt32(row.Cells[3].Value);
                    var dg=userBUS.getUserById(id_docgia);
                    if (dg != null)
                    {
                        label_TenDocGia.Text = dg.fullName;
                    }
                    else
                    {
                        label_TenDocGia.Text = "Không tìm thấy";
                    }
                    

                    // Hiển thị chi tiết phiếu mượn
                    int maPhieuMuon = int.Parse(row.Cells[0].Value.ToString());
                    MessageBox.Show($"Đang tìm chi tiết phiếu mượn có mã: {maPhieuMuon}");

                    dataGridView_CTPM.Rows.Clear();
                    ArrayList chiTietPhieuMuon = phieuMuonBUS.GetChiTietPhieuMuon(maPhieuMuon);

                    MessageBox.Show($"Số lượng chi tiết tìm được: {chiTietPhieuMuon.Count}");

                    foreach (var chiTiet in chiTietPhieuMuon)
                    {
                        try
                        {
                            var ct = (dynamic)chiTiet;
                            dataGridView_CTPM.Rows.Add(
                                ct.MaPhieuMuon,
                                ct.MaMonDo
                            );
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi thêm dòng: {ex.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}\nChi tiết: {ex.StackTrace}");
                }
            }
        }
        // Xuất Excel
        private void button_Export_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Lưu file Excel";
                saveFileDialog.FileName = "DanhSachPhieuMuon_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    phieuMuonBUS.ExportToExcel(saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message);
            }
        }
        // Xuất PDF
        private void button_Print_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                saveFileDialog.Title = "Lưu file PDF";
                saveFileDialog.FileName = "DanhSachPhieuMuon_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    phieuMuonBUS.ExportToPDF(saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất PDF: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_deleteCTPM_Click(object sender, EventArgs e)
        {
            if (dataGridView_CTPM.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dataGridView_CTPM.Rows.Remove(dataGridView_CTPM.CurrentRow);
                }
            }
        }
    }
}
