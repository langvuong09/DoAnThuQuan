using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DoAnThuQuan.QuanLyThuQuan.BUS;
using DoAnThuQuan.QuanLyThuQuan.DTO;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Component_PhanSach : UserControl
    {
        private SachDetailBUS sachDetailBUS = new SachDetailBUS();

        public event Action<SachDetail> OnPhanSachSelected;

        private List<Tuple<SachDetail, string>> currentData; // Lưu lại danh sách hiện tại

        public Component_PhanSach()
        {
            InitializeComponent();
            LoadDataPhanSach();
            button_Chon.Click += button_Chon_Click;
            dataGridView_DSPSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_DSPSach.MultiSelect = false;
        }

        private void LoadDataPhanSach()
        {
            dataGridView_DSPSach.Rows.Clear();
            dataGridView_DSPSach.Columns.Clear();
            dataGridView_DSPSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView_DSPSach.Columns.Add("id_serisach", "Mã Seri Sách");
            dataGridView_DSPSach.Columns.Add("id_sach", "Mã Sách");
            dataGridView_DSPSach.Columns.Add("ten_sach", "Tên Sách");
            dataGridView_DSPSach.Columns.Add("status", "Trạng Thái");

            currentData = sachDetailBUS.GetListSachDetailWithTenSach();
            if (currentData != null)
            {
                foreach (var item in currentData)
                {
                    SachDetail detail = item.Item1;
                    string tenSach = item.Item2;

                    string trangthai;
                    if (detail.trangThai == 1)
                        trangthai = "Chưa có ai mượn";
                    else if (detail.trangThai == 0)
                        trangthai = "Đã có người mượn";
                    else
                        trangthai = "Sách bị hư không thể mượn";

                    dataGridView_DSPSach.Rows.Add(detail.maDauSach.ToString(), detail.maSach, tenSach, trangthai);
                }
            }
            else
            {
                MessageBox.Show("Không lấy được dữ liệu sách.");
            }
        }

        private void button_Chon_Click(object sender, EventArgs e)
        {
            if (dataGridView_DSPSach.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView_DSPSach.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < currentData.Count)
                {
                    var item = currentData[selectedIndex];
                    SachDetail detail = item.Item1;
                    string tenSach = item.Item2;

                    // Kiểm tra trạng thái sách
                    if (detail.trangThai == 0)
                    {
                        MessageBox.Show("Sách này đã có người mượn. Vui lòng chọn sách khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (detail.trangThai == 2)
                    {
                        MessageBox.Show("Sách này bị hư và không thể mượn. Vui lòng chọn sách khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Nếu hợp lệ thì thực hiện chọn
                    OnPhanSachSelected?.Invoke(detail);

                    Form parentForm = this.FindForm();
                    parentForm?.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng.");
            }
        }

    }
}
