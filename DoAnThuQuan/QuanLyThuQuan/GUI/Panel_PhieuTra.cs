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
using DocumentFormat.OpenXml.Wordprocessing;
using Thuvien.DTO;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Panel_PhieuTra : UserControl
    {
        private CTPhieuMuon_BUS ctpmBUS = new CTPhieuMuon_BUS();
        private PhieuTraBUS phieuTraBUS = new PhieuTraBUS();
        private CTPhieuTra_BUS ctptBUS = new CTPhieuTra_BUS();
        private UserBUS userBUS = new UserBUS();
        private SachDetailBUS sachdetailBUS = new SachDetailBUS();
        private MayChieuBUS maychieuBUS = new MayChieuBUS();
        private MayTinhBUS maytinhBUS = new MayTinhBUS();
        private bool isTra = false;
        private bool isSelectedPMuon = false;

        public Panel_PhieuTra()
        {
            InitializeComponent();
            // Cấu hình DataGridView
            CustomizeDataGridView_DSPT(dataGridView_DSPT);
            CustomizeDataGridView_CTPT(dataGridView_CTPT);
            // Load dữ liệu vào DataGridView
            LoadDataToDataGridView_DSPT(dataGridView_DSPT);
            button_TraTBi.Click += UpdateTrangThai_CTPT;
            button_Reload.Click += ReloadTrang;
            button_LocTheoNgay.Click += FilterByTime;
            button_TimKiem.Click += TimKiemByID;


        }

        private void Panel_PhieuTra_Load(object sender, EventArgs e)
        {

        }

        private void button_PMuon_Click(object sender, EventArgs e)
        {
            Form newFormDialog = new Form
            {
                Text = "Danh Sách Các Phiếu Mượn",
                Size = new Size(1005, 500),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Component_PhieuMuon panel = new Component_PhieuMuon
            {
                Dock = DockStyle.Fill
            };

            // Gán sự kiện khi chọn một phiếu mượn
            panel.OnRowSelected += (phieuMuon) =>
            {
                MessageBox.Show($"Đã chọn phiếu mượn có ID: {phieuMuon.idPhieuMuon}");

                textBox_PhieuMuon.Text = phieuMuon.idPhieuMuon.ToString();
                textBox_NgTra.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                User nvien = userBUS.getUserById(UserSession.UserId);
                if (nvien != null)
                    textBox_TenNhanVien.Text = nvien.fullName;

                int maPhieuTra = phieuTraBUS.createNewPhieuTra();


                label_MaPhieuTra.Text = maPhieuTra.ToString();

                dataGridView_CTPT.Rows.Clear();
                ArrayList ds = ctpmBUS.GetListCTPMByIdPhieuMuon(phieuMuon.idPhieuMuon);
                foreach (chitiet_phieumuon ct in ds)
                {
                    dataGridView_CTPT.Rows.Add(
                        maPhieuTra.ToString(),
                        ct.id_mondo,
                        "Chưa Trả"
                        );
                }
                isSelectedPMuon = true;


                newFormDialog.Close();
            };

            newFormDialog.Controls.Add(panel);
            newFormDialog.ShowDialog();
        }




        // Cấu hình DataGridView
        private void CustomizeDataGridView_DSPT(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Aquamarine;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("idPhieuTra", "ID Phiếu Trả");
                dgv.Columns.Add("idPhieuMuon", "ID Phiếu Mượn");
                dgv.Columns.Add("tgianTra", "Thời Gian Trả");
                dgv.Columns.Add("moTa", "Mô Tả");
                dgv.Columns.Add("nvien", "Mã Nhân Viên");
                dgv.Columns.Add("tenNhanVien", "Tên Nhân Viên");

                dgv.Columns["idPhieuTra"].Width = 200;
                dgv.Columns["idPhieuMuon"].Width = 200;
                dgv.Columns["tgianTra"].Width = 200;
                dgv.Columns["moTa"].Width = 350;
                dgv.Columns["nvien"].Width = 200;
                dgv.Columns["tenNhanVien"].Width = 200;
            }
        }

        private void CustomizeDataGridView_CTPT(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Aquamarine;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("idPhieuTra", "ID Phiếu Trả");
                dgv.Columns.Add("idMonDo", "ID Món Đồ");
                dgv.Columns.Add("tinhTrang", "Tình Trạng");


                dgv.Columns["idPhieuTra"].Width = 200;
                dgv.Columns["idMonDo"].Width = 200;
                dgv.Columns["tinhTrang"].Width = 200;

            }
        }

        // Load dữ liệu phiếu trả hôm nay vào DataGridView
        public void LoadDataToDataGridView_DSPT(DataGridView dgv)
        {
            List<(PhieuTra, User)> data = phieuTraBUS.GetListPhieuTraWithNhanVien();

            // Xóa dữ liệu cũ
            dgv.Rows.Clear();

            foreach (var dataItem in data)
            {
                if (dataItem.Item1 != null && dataItem.Item2 != null)
                {
                    PhieuTra pt = dataItem.Item1;
                    User user = dataItem.Item2;

                    string fullName = user.fullName ?? "Chưa có tên";

                    dgv.Rows.Add(
                        pt.maPhieuTra,
                        pt.maPhieuMuon,
                        pt.thoiGianTra,
                        pt.moTa,
                        pt.maNhanVien,
                        fullName
                    );
                }
                else
                {
                    Console.WriteLine("Có phần tử null trong dataItem");
                }
            }
        }

        private void UpdateTrangThai_CTPT(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_CTPT.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells["tinhTrang"].Value = "Đã Trả";
                }
            }
            isTra = true;
        }

        private void ReloadTrang(object sender, EventArgs e)
        {
            dataGridView_CTPT.Rows.Clear();
            LoadDataToDataGridView_DSPT(dataGridView_DSPT);
            textBox_PhieuMuon.Text = "";
            textBox_NgTra.Text = "";
            textBox_TenNhanVien.Text = "";
            label_MaPhieuTra.Text = "";
            textBox_note.Text = "";
            textBox_TimKiem.Text = "";
        }

        private void FilterByTime(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dateTimePicker_NgBatDau.Value.Date;
            DateTime ngayKetThuc = dateTimePicker_NgKetThuc.Value.Date;

            // Kiểm tra nếu người dùng chưa chọn thời gian
            if (ngayBatDau == DateTime.MinValue || ngayKetThuc == DateTime.MinValue)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thời gian bắt đầu và kết thúc!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nếu ngày bắt đầu > ngày kết thúc
            if (ngayBatDau > ngayKetThuc)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi thời gian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<(PhieuTra, User)> data = phieuTraBUS.FilterByTime(ngayBatDau, ngayKetThuc);

            dataGridView_DSPT.Rows.Clear();

            if (data == null || data.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả trong khoảng thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var dataItem in data)
            {
                if (dataItem.Item1 != null && dataItem.Item2 != null)
                {
                    PhieuTra pt = dataItem.Item1;
                    User user = dataItem.Item2;

                    string fullName = user.fullName ?? "Chưa có tên";

                    dataGridView_DSPT.Rows.Add(
                        pt.maPhieuTra,
                        pt.maPhieuMuon,
                        pt.thoiGianTra,
                        pt.moTa,
                        pt.maNhanVien,
                        fullName
                    );
                }
            }
        }

        private void TimKiemByID(object sender, EventArgs e)
        {
            string id = textBox_TimKiem.Text.Trim(); // Loại bỏ khoảng trắng

            // Kiểm tra xem id có rỗng hoặc null không
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu trả khi tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra xem id có phải là số nguyên không
            if (!int.TryParse(id, out int result))
            {
                MessageBox.Show("Mã phiếu trả phải là một số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tìm kiếm PhieuTra theo mã
            PhieuTra pt = phieuTraBUS.GetPhieuTraById(result);
            if (pt == null)
            {
                MessageBox.Show("Không tìm thấy phiếu trả với mã này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy thông tin nhân viên
            User nv = userBUS.getUserById(pt.maNhanVien);
            if (nv == null)
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Xóa dữ liệu cũ và thêm dòng mới vào DataGridView
            dataGridView_DSPT.Rows.Clear();
            dataGridView_DSPT.Rows.Add(
                pt.maPhieuTra,
                pt.maPhieuMuon,
                pt.thoiGianTra,
                pt.moTa,
                pt.maNhanVien,
                nv.fullName
            );
            textBox_TimKiem.Text = "";
        }


        private void label_titleNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CTPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async void dataGridView_DSPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView_DSPT.Rows[e.RowIndex];
                    label_MaPhieuTra.Text = row.Cells[0].Value.ToString();
                    textBox_PhieuMuon.Text = row.Cells[1].Value.ToString();
                    textBox_NgTra.Text = row.Cells[2].Value.ToString();
                    textBox_TenNhanVien.Text = row.Cells[5].Value.ToString();
                    textBox_note.Text = row.Cells[3].Value.ToString();

                    int maPhieuTra = int.Parse(row.Cells[0].Value.ToString());

                    dataGridView_CTPT.SuspendLayout();
                    dataGridView_CTPT.Rows.Clear();

                    // Gọi hàm lấy dữ liệu từ BUS không làm chặn UI
                    List<CTPhieuTra> chiTietPhieuTra = await Task.Run(() => ctptBUS.GetListCTPMByIdPhieuTra(maPhieuTra));

                    foreach (var ct in chiTietPhieuTra)
                    {
                        dataGridView_CTPT.Rows.Add(ct.idPhieuTra, ct.idMonDo, "Đã Trả");
                    }

                    dataGridView_CTPT.ResumeLayout();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}\nChi tiết: {ex.StackTrace}");
                }
            }
        }



        private void label_MaPhieuTra_Click(object sender, EventArgs e)
        {

        }

        private void button_ThemPhieu_Click(object sender, EventArgs e)
        {
            if (isTra == false)
            {
                MessageBox.Show("Phải chọn phiếu mượn và nhấn nút trả");
            }
            int maPhieuTra = int.Parse(label_MaPhieuTra.Text.ToString());
            int maPhieuMuon = int.Parse(textBox_PhieuMuon.Text.ToString());
            int id_nv = UserSession.UserId;
            DateTime ngayTra = DateTime.Now;
            string note = textBox_note.Text;
            if (string.IsNullOrWhiteSpace(note))
            {
                note = "Không có gì cần nhắn lại về phiếu trả này";
            }

            bool daThemPhieu = phieuTraBUS.ThemPhieuTra(maPhieuTra, ngayTra, maPhieuMuon, note, id_nv);
            if (!daThemPhieu)
            {
                MessageBox.Show("Xảy ra vấn đề khi thêm phiếu!");

                return;
            }
            foreach (DataGridViewRow row in dataGridView_CTPT.Rows)
            {
                if (row.IsNewRow) continue;

                string maThietBi = row.Cells[1].Value?.ToString();
               

                if (string.IsNullOrEmpty(maThietBi)) continue;

                // Thêm chi tiết phiếu mượn
                bool daThemCTPT = ctptBUS.ThemCTPT(maPhieuTra,maThietBi);
                if (!daThemCTPT)
                {
                    MessageBox.Show("Đã có vấn đề xảy ra với hệ thống khi thêm chi tiết phiếu trả!");
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

            textBox_PhieuMuon.Text = "";
            textBox_NgTra.Text = "";
            textBox_TenNhanVien.Text = "";
            label_MaPhieuTra.Text = "";
            textBox_note.Text = "";
            dataGridView_DSPT.Rows.Add(maPhieuTra,maPhieuMuon,ngayTra.ToString("dd/MM/yyyy HH:mm:ss"),note,id_nv.ToString(), textBox_TenNhanVien.Text);
            dataGridView_CTPT.Rows.Clear();

        }

        private bool CapNhatTrangThaiThietBi(string maThietBi)
        {
            if (maThietBi.StartsWith("MD"))
                return sachdetailBUS.CapNhatTrangThaiSachDetail(maThietBi, 1);

            if (maThietBi.StartsWith("MT"))
                return maytinhBUS.TangSoLgMayTinh(maThietBi);

            if (maThietBi.StartsWith("MC"))
                return maychieuBUS.TangSoLgMayChieu(maThietBi);

            return false; // Không đúng định dạng mã
        }
    }
}
