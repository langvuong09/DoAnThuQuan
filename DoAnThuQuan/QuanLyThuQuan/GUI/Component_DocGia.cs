using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

using DoAnThuQuan.QuanLyThuQuan.BUS;
using DoAnThuQuan.QuanLyThuQuan.DTO;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Component_DocGia : UserControl
    {
        private UserBUS userBUS = new UserBUS();
        private ArrayList currentData;
        public event Action<User> OnRowSelected; // Sửa kiểu từ PhieuMuon sang User

        public Component_DocGia()
        {
            InitializeComponent();
            CustomizeDataGridView(dataGridView_DSDGia);
            LoadDataToDataGridView(dataGridView_DSDGia);
        }

        private void CustomizeDataGridView(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Aquamarine;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("idDocGia", "ID Mã Đọc Giả");
                dgv.Columns.Add("tenDocGia", "Tên Đọc Giả");

                dgv.Columns["idDocGia"].Width = 200;
                dgv.Columns["tenDocGia"].Width = 200;
            }
        }

        public void LoadDataToDataGridView(DataGridView dgv)
        {
            currentData = userBUS.GetListTaiKhoanByQuyen(1);
            dgv.Rows.Clear();

            if (currentData != null)
            {
                foreach (User user in currentData)
                {
                    dgv.Rows.Add(
                        user.userId,
                        user.fullName
                    );
                }
            }
            else
            {
                MessageBox.Show("Không lấy được danh sách người dùng.");
            }
        }

        private void button_Chon_Click(object sender, EventArgs e)
        {
            if (dataGridView_DSDGia.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView_DSDGia.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < currentData.Count)
                {
                    User selectedUser = currentData[selectedIndex] as User;
                    OnRowSelected?.Invoke(selectedUser);

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
