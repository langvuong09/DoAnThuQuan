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
using System.Collections;
using ClosedXML.Excel;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Panel_MayChieu : UserControl
    {
        
        private MayChieuBUS mayChieuBUS = new MayChieuBUS();
        private List<MayChieu> listMayChieu = new List<MayChieu>();
       
        public Panel_MayChieu()
        {
            InitializeComponent();
            SetupDataGridView();
            SetupComboBoxes();
            AddEventHandlers();
            LoadData();
        }
        
        private void SetupDataGridView()
        {
            // Thiết lập cột
            dataGridView_DSMChieu.Columns.Clear();
            dataGridView_DSMChieu.Columns.Add("MaMayChieu", "Mã Máy Chiếu");
            dataGridView_DSMChieu.Columns.Add("TrangThai", "Trạng Thái");
            dataGridView_DSMChieu.Columns.Add("SoLuong", "Số Lượng");
            dataGridView_DSMChieu.Columns.Add("Link", "Link");
            dataGridView_DSMChieu.Columns.Add("GiaTien", "Giá Tiền");

            // Thiết lập thuộc tính
            dataGridView_DSMChieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_DSMChieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_DSMChieu.MultiSelect = false;
        }

        private void SetupComboBoxes()
        {
            // Thiết lập ComboBox trạng thái
            comboBox_TinhTrang.Items.Clear();
            comboBox_TinhTrang.Items.Add("Hoạt động");
            comboBox_TinhTrang.Items.Add("Không hoạt động");
            comboBox_TinhTrang.SelectedIndex = 0;

            // Thiết lập ComboBox lọc
            comboBox_LocTinhTrang.Items.Clear();
            comboBox_LocTinhTrang.Items.Add("Tất cả");
            comboBox_LocTinhTrang.Items.Add("Hoạt động");
            comboBox_LocTinhTrang.Items.Add("Không hoạt động");
            comboBox_LocTinhTrang.SelectedIndex = 0;
        }

        private void AddEventHandlers()
        {
            button_Sua.Click += Button_Sua_Click;
            button_Reload.Click += Button_Reload_Click;
            button_TimKiem.Click += Button_TimKiem_Click;
            button_LocTinhTrang.Click += Button_LocTinhTrang_Click;
            button_XuatExcel.Click += Button_XuatExcel_Click;
            dataGridView_DSMChieu.SelectionChanged += DataGridView_DSMChieu_SelectionChanged;
        }
       
        private void LoadData()
        {
            dataGridView_DSMChieu.Rows.Clear();
            ArrayList arr = mayChieuBUS.GetListMayChieu();
            if (arr != null)
            {
                foreach (MayChieu mc in arr)
                {
                    AddRowToDataGridView(mc);
                }
            }
        }

        private void AddRowToDataGridView(MayChieu mc)
        {
            dataGridView_DSMChieu.Rows.Add(
                mc.idSeriMaychieu,
                mc.trangThai == 1 ? "Hoạt động" : "Không hoạt động",
                mc.soLuong,
                mc.link,
                mc.giaTien
            );
        }

        private void ClearInputs()
        {
            textBox_MaMChieu.Clear();
            textBox_SoLuong.Clear();
            textBox_GiaTien.Clear();
            textBox_Link.Clear();
            comboBox_TinhTrang.SelectedIndex = 0;
            comboBox_LocTinhTrang.SelectedIndex = 0;
            textBox_TimKiem.Clear();
        }
       
        private void Panel_MayChieu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DataGridView_DSMChieu_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_DSMChieu.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView_DSMChieu.SelectedRows[0];
                    textBox_MaMChieu.Text = row.Cells["MaMayChieu"].Value.ToString();
                    string trangThaiStr = row.Cells["TrangThai"].Value.ToString();
                    comboBox_TinhTrang.SelectedIndex = (trangThaiStr == "Hoạt động") ? 0 : 1;
                    textBox_SoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                    textBox_GiaTien.Text = row.Cells["GiaTien"].Value.ToString();
                    textBox_Link.Text = row.Cells["Link"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void Button_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_DSMChieu.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView_DSMChieu.SelectedRows[0];
                    string maMayChieu = row.Cells["MaMayChieu"].Value.ToString();
                    int trangThai = comboBox_TinhTrang.SelectedIndex;
                    int soLuong = int.Parse(textBox_SoLuong.Text);
                    string link = textBox_Link.Text;
                    int giaTien = int.Parse(textBox_GiaTien.Text);

                    if (mayChieuBUS.SuaMayChieu(maMayChieu, trangThai, soLuong, link, giaTien))
                    {
                        LoadData();
                        ClearInputs();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn máy chiếu cần sửa!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void Button_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearInputs();
        }

        private void Button_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = textBox_TimKiem.Text.Trim().ToLower();
                if (string.IsNullOrEmpty(searchText))
                {
                    LoadData();
                    return;
                }

                ArrayList arr = mayChieuBUS.GetListMayChieu();
                var filtered = arr.Cast<MayChieu>().Where(mc =>
                    mc.idSeriMaychieu.ToLower().Contains(searchText) ||
                    mc.link.ToLower().Contains(searchText) ||
                    mc.giaTien.ToString().Contains(searchText) ||
                    mc.soLuong.ToString().Contains(searchText)
                ).ToList();

                dataGridView_DSMChieu.Rows.Clear();
                foreach (MayChieu mc in filtered)
                {
                    AddRowToDataGridView(mc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void Button_LocTinhTrang_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = comboBox_LocTinhTrang.SelectedIndex;
                ArrayList arr = mayChieuBUS.GetListMayChieu();
                List<MayChieu> filteredList;

                switch (selectedIndex)
                {
                    case 0: // Tất cả
                        filteredList = arr.Cast<MayChieu>().ToList();
                        break;
                    case 1: // Hoạt động
                        filteredList = arr.Cast<MayChieu>().Where(mc => mc.trangThai == 1).ToList();
                        break;
                    case 2: // Không hoạt động
                        filteredList = arr.Cast<MayChieu>().Where(mc => mc.trangThai == 0).ToList();
                        break;
                    default:
                        filteredList = arr.Cast<MayChieu>().ToList();
                        break;
                }

                dataGridView_DSMChieu.Rows.Clear();
                foreach (MayChieu mc in filteredList)
                {
                    AddRowToDataGridView(mc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void Button_XuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Lưu file Excel",
                    FileName = "DanhSachMayChieu_" + DateTime.Now.ToString("yyyyMMdd_HHmmss")
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("MayChieu");
                        
                        // Thêm header
                        worksheet.Cell(1, 1).Value = "Mã Máy Chiếu";
                        worksheet.Cell(1, 2).Value = "Trạng Thái";
                        worksheet.Cell(1, 3).Value = "Số Lượng";
                        worksheet.Cell(1, 4).Value = "Link";
                        worksheet.Cell(1, 5).Value = "Giá Tiền";

                        // Thêm dữ liệu
                        int row = 2;
                        ArrayList arr = mayChieuBUS.GetListMayChieu();
                        foreach (MayChieu mc in arr)
                        {
                            worksheet.Cell(row, 1).Value = mc.idSeriMaychieu;
                            worksheet.Cell(row, 2).Value = mc.trangThai == 1 ? "Hoạt động" : "Không hoạt động";
                            worksheet.Cell(row, 3).Value = mc.soLuong;
                            worksheet.Cell(row, 4).Value = mc.link;
                            worksheet.Cell(row, 5).Value = mc.giaTien;
                            row++;
                        }
                        workbook.SaveAs(saveFileDialog.FileName);
                    }
                    MessageBox.Show("Xuất Excel thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message);
            }
        }
       
    }
}
