using DoAnThuQuan.QuanLyThuQuan.BUS;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Component_PhieuMuon : UserControl
    {
        private PhieuMuonBUS phieuMuonBUS=new PhieuMuonBUS();

        // Sự kiện để gửi dữ liệu ra ngoài (về UserControl chính)
        public event Action<PhieuMuon> OnRowSelected;

        private List<(PhieuMuon, User)> currentData; 

        public Component_PhieuMuon()
        {
            InitializeComponent();
           

            CustomizeDataGridView(dataGridView_DSPMuon);
            LoadDataToDataGridView(dataGridView_DSPMuon);

            button_Chon.Click += Btn_Chon_Click;
        }

        private void Btn_Chon_Click(object sender, EventArgs e)
        {
            if (dataGridView_DSPMuon.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView_DSPMuon.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < currentData.Count)
                {
                    var selectedPhieuMuon = currentData[selectedIndex].Item1;

                    // Gửi dữ liệu ra ngoài qua sự kiện
                    OnRowSelected?.Invoke(selectedPhieuMuon);

                    //Nếu bạn hiển thị UserControl này trong một Form, có thể đóng ở đây luôn
                    ((Form)this.TopLevelControl)?.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng.");
            }
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
                dgv.Columns.Add("idPhieuMuon", "ID Phiếu Mượn");
                dgv.Columns.Add("tgianMuon", "Thời Gian Mượn");
                dgv.Columns.Add("solg", "Số Lượng");
                dgv.Columns.Add("ngMuon", "Mã Độc Giả");
                dgv.Columns.Add("nvien", "Mã Nhân Viên");
                dgv.Columns.Add("tenNhanVien", "Tên Nhân Viên");

                dgv.Columns["idPhieuMuon"].Width = 200;
                dgv.Columns["tgianMuon"].Width = 200;
                dgv.Columns["solg"].Width = 200;
                dgv.Columns["ngMuon"].Width = 200;
                dgv.Columns["nvien"].Width = 200;
                dgv.Columns["tenNhanVien"].Width = 200;
            }
        }

        public void LoadDataToDataGridView(DataGridView dgv)
        {
            currentData = phieuMuonBUS.GetListPhieuMuonHomNayWithNhanVien();
            dgv.Rows.Clear();

            foreach (var item in currentData)
            {
                if (item.Item1 != null && item.Item2 != null)
                {
                    dgv.Rows.Add(
                        item.Item1.idPhieuMuon,
                        item.Item1.tgianMuon.ToString("dd/MM/yyyy"),
                        item.Item1.solg,
                        item.Item1.ngMuon,
                        item.Item1.idNhanVien,
                        item.Item2.fullName ?? "Chưa có tên"
                    );
                }
            }
        }
    }
}
