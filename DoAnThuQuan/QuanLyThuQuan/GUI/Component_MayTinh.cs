using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DoAnThuQuan.QuanLyThuQuan.BUS;
using DoAnThuQuan.QuanLyThuQuan.DTO;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Component_MayTinh : UserControl
    {
        private MayTinhBUS maytinhBUS = new MayTinhBUS();
        public event Action<MayTinh> OnMayTinhSelected;

        private ArrayList currentData;


        public Component_MayTinh()
        {
            InitializeComponent();
            CustomizeDataGridView(dataGridView_DSMTinh);
            LoadDataMayTinh();
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
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.AutoGenerateColumns = false;
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add("id_seri", "Mã Máy Tính");
            dgv.Columns.Add("so_lg", "Số Lượng");

            dgv.Columns["id_seri"].Width = 200;
            dgv.Columns["so_lg"].Width = 200;
        }

        private void LoadDataMayTinh()
        {
            try
            {
                currentData = maytinhBUS.GetListMayTinh();
                dataGridView_DSMTinh.Rows.Clear();

                if (currentData != null && currentData.Count > 0)
                {
                    foreach (var item in currentData)
                    {
                        MayTinh mt = item as MayTinh;
                        if (mt != null)
                        {
                            dataGridView_DSMTinh.Rows.Add(mt.idSeriMaytinh, mt.soLuong);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Danh sách máy tính trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu máy tính: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Chon_Click(object sender, EventArgs e)
        {
            if (dataGridView_DSMTinh.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = dataGridView_DSMTinh.SelectedRows[0].Index;

            if (selectedIndex >= 0 && selectedIndex < currentData.Count)
            {
                MayTinh selectedMayTinh = currentData[selectedIndex] as MayTinh;
                if (selectedMayTinh == null)
                {
                    MessageBox.Show("Dữ liệu không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (selectedMayTinh.soLuong <= 0)
                {
                    MessageBox.Show("Máy tính này đã hết hàng. Vui lòng chọn máy khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                OnMayTinhSelected?.Invoke(selectedMayTinh);

                Form parentForm = this.FindForm();
                if (parentForm != null)
                    parentForm.Close();
            }
        }

    }
}
