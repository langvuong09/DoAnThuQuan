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
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Component_MayChieu : UserControl
    {
        private MayChieuBUS maychieuBUS = new MayChieuBUS();

        public event Action<MayChieu> OnMayChieuSelected;

        private System.Collections.ArrayList currentData;
        public Component_MayChieu()
        {
            InitializeComponent();
            CustomizeDataGridView(dataGridView_DSMChieu);
            LoadDataMayChieu();
        }
        private void CustomizeDataGridView(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Aquamarine;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("id_seri", "Mã Máy Chiếu");
                dgv.Columns.Add("so_lg", "Số Lượng");

                dgv.Columns["id_seri"].Width = 200;
                dgv.Columns["so_lg"].Width = 200;
            }
        }


        private void LoadDataMayChieu()
        {
            currentData = maychieuBUS.GetListMayChieu();
            dataGridView_DSMChieu.Rows.Clear();

            if (currentData != null)
            {
                foreach (MayChieu mc in currentData)
                {
                    dataGridView_DSMChieu.Rows.Add(
                        mc.idSeriMaychieu,
                        mc.soLuong
                    );
                }
            }
            else
            {
                MessageBox.Show("Không lấy được danh sách.");
            }

        }

        private void button_Chon_Click(object sender, EventArgs e)
        {
            if (dataGridView_DSMChieu.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView_DSMChieu.SelectedRows[0].Index;

                if (selectedIndex >= 0 && selectedIndex < currentData.Count)
                {
                    MayChieu selectedMayChieu = currentData[selectedIndex] as MayChieu;

                    if (selectedMayChieu != null)
                    {
                        if (selectedMayChieu.soLuong == 0)
                        {
                            MessageBox.Show("Máy chiếu này đã hết hàng. Vui lòng chọn máy khác.");
                            return;
                        }

                        OnMayChieuSelected?.Invoke(selectedMayChieu);

                        Form parentForm = this.FindForm();
                        parentForm?.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng.");
            }
        }

    }
}
