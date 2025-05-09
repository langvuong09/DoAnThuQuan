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

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{


    public partial class Panel_PDatCho : UserControl
    {


        private PhieuDatChoBUS phieuDatChoBUS = new PhieuDatChoBUS();
        private ArrayList listPhieuDatCho;
        private UserBUS userBus = new UserBUS();
        private SachDetailBUS sachdetailBUS = new SachDetailBUS();
        private MayChieuBUS maychieuBUS = new MayChieuBUS();
        private MayTinhBUS maytinhBUS = new MayTinhBUS();
        public Panel_PDatCho()
        {
            InitializeComponent();
            CustomizeDataGridView_DSPDC(dataGridView_DSPDCho);
            CustomizeDataGridView_CTMD(dataGridView_CTTBi);
            LoadData();
            SetupEvents();
        }

        private void Panel_PDatCho_Load(object sender, EventArgs e)
        {

        }

        private void CustomizeDataGridView_DSPDC(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Aquamarine;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("idPhieudatcho", "Mã Phiếu Đặt Chỗ");
                dgv.Columns.Add("ngdatcho", "Mã Người Đặt");
                dgv.Columns.Add("idChongoi", "Mã Chỗ Ngồi");
                dgv.Columns.Add("createAt", "Thời Gian Đặt");
                dgv.Columns.Add("tgianNhan", "Thời Gian Nhận");
                dgv.Columns.Add("trangThai", "Trạng Thái");
                dgv.Columns.Add("soTien", "Số Tiền");

                // Định dạng các cột
                dgv.Columns["idPhieudatcho"].Width = 200;
                dgv.Columns["ngdatcho"].Width = 200;
                dgv.Columns["idChongoi"].Width = 200;
                dgv.Columns["createAt"].Width = 200;
                dgv.Columns["tgianNhan"].Width = 200;
                dgv.Columns["trangThai"].Width = 200;
                dgv.Columns["soTien"].Width = 200;
            }
        }

        private void CustomizeDataGridView_CTMD(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Aquamarine;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("idChiTiet", "Mã Chi Tiết");
                dgv.Columns.Add("idPhieuDatCho", "Mã Phiếu Đặt Chỗ");
                dgv.Columns.Add("idThietBi", "Mã Thiết Bị");
                dgv.Columns.Add("giaTien", "Giá Tiền");


                // Định dạng các cột
                dgv.Columns["idChiTiet"].Width = 200;
                dgv.Columns["idPhieuDatCho"].Width = 200;
                dgv.Columns["idThietBi"].Width = 200;
                dgv.Columns["giaTien"].Width = 200;

            }
        }

        private void LoadData()
        {
            textBox_MaPhieuDatCho.Text = "";
            textBox_MaNgDatCho.Text = "";
            textBox_MaChoNgoi.Text = "";
            textBox_TenNguoiDatCho.Text = "";
            textBox_createat.Text = "" ;
            textBox_tgiannhancho.Text = ""; ;
            dataGridView_CTTBi.Rows.Clear();
            dataGridView_DSPDCho.Rows.Clear();
            ArrayList listChiTiet = phieuDatChoBUS.GetListPhieuDatCho();
            foreach (PhieuDatCho ct in listChiTiet)
            {
                dataGridView_DSPDCho.Rows.Add(
                ct.idPhieudatcho,
                ct.ngdatcho,
                ct.idChongoi,
                ct.createAt.ToString("dd/MM/yyyy HH:mm"),
                ct.tgian.ToString("dd/MM/yyyy HH:mm"),
                ct.trangThai,
                ct.soTien
            );
            }

        }







        private void SetupEvents()
        {
            dataGridView_DSPDCho.SelectionChanged += DataGridView_DSPDCho_SelectionChanged;
            button_Reload.Click += Button_Reload_Click;
            button_TimKiem.Click += Button_TimKiem_Click;

            button_NhanCho.Click += Button_NhanCho_Click;
            button_TraCho.Click += Button_TraCho_Click;
        }

        private void DataGridView_DSPDCho_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_DSPDCho.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView_DSPDCho.SelectedRows[0];
                int idPhieuDatCho = Convert.ToInt32(row.Cells[0].Value);
                textBox_MaPhieuDatCho.Text = row.Cells[0].Value.ToString();
                textBox_MaNgDatCho.Text = row.Cells[1].Value.ToString();
                textBox_MaChoNgoi.Text = row.Cells[2].Value.ToString();
                int maNguoiDat = int.Parse(row.Cells[1].Value.ToString());
                textBox_TenNguoiDatCho.Text = userBus.getUserById(maNguoiDat).fullName;
                textBox_createat.Text= row.Cells[3].Value.ToString(); ;
                textBox_tgiannhancho.Text= row.Cells[4].Value.ToString(); ;
                dataGridView_CTTBi.Rows.Clear();

                var listChiTiet = phieuDatChoBUS.GetChiTietPhieuDatCho(idPhieuDatCho);
                foreach (ChiTietPhieuDatCho ct in listChiTiet)
                {
                    dataGridView_CTTBi.Rows.Add(ct.idChiTietPhieuDatCho, ct.idPhieuDatCho,ct.idThietBi, ct.giaTien);
                }
            }
        }

        private void Button_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Button_TimKiem_Click(object sender, EventArgs e)
        {
            string searchText = textBox_TimKiem.Text.Trim().ToLower();
            dataGridView_DSPDCho.Rows.Clear();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(searchText, out int keyword))
            {
                MessageBox.Show("Từ khóa tìm kiếm phải là một số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PhieuDatCho pdc = phieuDatChoBUS.GetPhieuDatChoById(int.Parse(searchText));
            if (pdc != null)
            {
                dataGridView_DSPDCho.Rows.Clear();
                dataGridView_DSPDCho.Rows.Add(
                pdc.idPhieudatcho,
                pdc.ngdatcho,
                pdc.idChongoi,
                pdc.createAt.ToString("dd/MM/yyyy HH:mm"),
                pdc.tgian.ToString("dd/MM/yyyy HH:mm"),
                pdc.trangThai,
                pdc.soTien
                );
            }
        }



        private void Button_NhanCho_Click(object sender, EventArgs e)
        {
            if (dataGridView_DSPDCho.SelectedRows.Count > 0)
            {
                int idPhieu = Convert.ToInt32(dataGridView_DSPDCho.SelectedRows[0].Cells[0].Value);
                PhieuDatCho pdc = phieuDatChoBUS.GetPhieuDatChoById(idPhieu);

                if (pdc == null)
                {
                    MessageBox.Show("Không tìm thấy phiếu đặt chỗ!");
                    return;
                }

                if (pdc.trangThai == -1)
                {
                    MessageBox.Show("Phiếu này đã bị vô hiệu hóa!");
                    return;
                }

                if (pdc.trangThai == 0)
                {
                    MessageBox.Show("Phiếu này đã có người nhận chỗ rồi!");
                    return;
                }

                DateTime now = DateTime.Now;
                if ((now - pdc.tgian).TotalHours > 1)
                {
                    MessageBox.Show("Bạn đến nhận chỗ không đúng giờ. Phiếu này đã bị vô hiệu hóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    phieuDatChoBUS.CapNhatTrangThaiPhieuDatCho(idPhieu, -1); // Vô hiệu hóa phiếu
                    foreach (DataGridViewRow row in dataGridView_CTTBi.Rows)
                    {
                        if (row.IsNewRow) continue;
                        string maThietBi = row.Cells[2].Value.ToString();
                        bool capNhatThanhCong = CapNhatTrangThaiThietBi(maThietBi);
                        if (!capNhatThanhCong)
                        {
                            MessageBox.Show("Đã có vấn đề xảy ra khi cập nhật thiết bị!");
                            break;
                        }

                    }
                    LoadData();
                    return;
                }

                if (phieuDatChoBUS.CapNhatTrangThaiPhieuDatCho(idPhieu, 0)) // 0 = đã nhận
                {
                    MessageBox.Show("Nhận chỗ thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Nhận chỗ thất bại!");
                }
            }
        }


        private void Button_TraCho_Click(object sender, EventArgs e)
        {
            if (dataGridView_DSPDCho.SelectedRows.Count > 0)
            {
                int idPhieu = Convert.ToInt32(dataGridView_DSPDCho.SelectedRows[0].Cells[0].Value);
                PhieuDatCho pdc = phieuDatChoBUS.GetPhieuDatChoById(idPhieu);

                if (pdc == null)
                {
                    MessageBox.Show("Không tìm thấy phiếu đặt chỗ!");
                    return;
                }

                if (pdc.trangThai == 0) // đã nhận
                {
                    if (phieuDatChoBUS.CapNhatTrangThaiPhieuDatCho(idPhieu, 1)) // 1 = chờ nhận
                    {
                        foreach (DataGridViewRow row in dataGridView_CTTBi.Rows)
                        {
                            if (row.IsNewRow) continue;
                            string maThietBi = row.Cells[2].Value.ToString();
                            bool capNhatThanhCong = CapNhatTrangThaiThietBi(maThietBi);
                            if (!capNhatThanhCong)
                            {
                                MessageBox.Show("Đã có vấn đề xảy ra khi cập nhật thiết bị!");
                                break;
                            }

                        }
                            MessageBox.Show("Trả chỗ thành công!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Trả chỗ thất bại!");
                    }
                }
                else if (pdc.trangThai == 1)
                {
                    MessageBox.Show("Phiếu này chưa có ai nhận chỗ, không thể trả chỗ!");
                }
                else
                {
                    MessageBox.Show("Phiếu không hợp lệ để trả chỗ!");
                }
            }
        }
        private bool CapNhatTrangThaiThietBi(string maThietBi)
        {
          

            if (maThietBi.StartsWith("MT"))
                return maytinhBUS.TangSoLgMayTinh(maThietBi);

            if (maThietBi.StartsWith("MC"))
                return maychieuBUS.TangSoLgMayChieu(maThietBi);

            return false; // Không đúng định dạng mã
        }


    }
}
