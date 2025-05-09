using System;
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
    public partial class Component_PhieuTra : UserControl
    {
        private PhieuTraBUS phieuTraBUS = new PhieuTraBUS();

        // Sự kiện để gửi dữ liệu ra ngoài (về UserControl chính)
        public event Action<PhieuTra> OnRowSelected;

        private List<(PhieuTra, User)> currentData;

        public Component_PhieuTra()
        {
            InitializeComponent();
            CustomizeDataGridView(dataGridView_DSPTra);
            LoadDataToDataGridView(dataGridView_DSPTra);
        }

        private void CustomizeDataGridView(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("idPhieuTra", "ID Phiếu Trả");
                dgv.Columns.Add("tgianTra", "Thời Gian Trả");
                dgv.Columns.Add("mota", "Mô Tả");
                dgv.Columns.Add("idPhieuMuon", "ID Phiếu Mượn");
                dgv.Columns.Add("nvien", "Mã Nhân Viên");
                dgv.Columns.Add("tenNhanVien", "Tên Nhân Viên");

                dgv.Columns["idPhieuTra"].Width = 200;
                dgv.Columns["tgianTra"].Width = 200;
                dgv.Columns["mota"].Width = 300;
                dgv.Columns["idPhieuMuon"].Width = 200;
                dgv.Columns["nvien"].Width = 200;
                dgv.Columns["tenNhanVien"].Width = 200;
            }
        }

        public void LoadDataToDataGridView(DataGridView dgv)
        {
            try
            {
                currentData = phieuTraBUS.GetListPhieuTraHomNayWithNhanVien();
                if (currentData == null || currentData.Count == 0)
                {
                    MessageBox.Show("Không có phiếu trả nào cả");
                    return;
                }

                dgv.Rows.Clear();

                foreach (var item in currentData)
                {
                    if (item.Item1 != null && item.Item2 != null)
                    {
                        dgv.Rows.Add(
                            item.Item1.maPhieuTra,
                            item.Item1.thoiGianTra.ToString("dd/MM/yyyy"),
                            item.Item1.moTa,
                            item.Item1.maPhieuMuon,
                            item.Item1.maNhanVien,
                            item.Item2.fullName ?? "Chưa có tên"
                        );
                        Console.WriteLine("Đã thêm dòng: " + item.Item1.maPhieuTra); // Debug output
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }

        private void button_Chon_Click(object sender, EventArgs e)
        {
            if (dataGridView_DSPTra.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView_DSPTra.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < currentData.Count)
                {
                    var selectedPhieuMuon = currentData[selectedIndex].Item1;

                    // Gửi dữ liệu ra ngoài qua sự kiện
                    OnRowSelected?.Invoke(selectedPhieuMuon);

                    // Nếu bạn hiển thị UserControl này trong một Form, có thể đóng ở đây luôn
                    ((Form)this.TopLevelControl)?.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng.");
            }
        }

    }
}
