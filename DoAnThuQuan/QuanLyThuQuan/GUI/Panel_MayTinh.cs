using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ClosedXML.Excel;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnThuQuan.QuanLyThuQuan.BUS;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using DoAnThuQuan.MyCustom;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Panel_MayTinh : UserControl
    {
        private MayTinhBUS mayTinhBUS;
        private List<MayTinh> listMayTinh;
        private bool isEditing = false;

        public Panel_MayTinh()
        {
            InitializeComponent();
            mayTinhBUS = new MayTinhBUS();
            SetupDataGridView();
            LoadData();
            AddEventHandlers();
            SetupComboBoxes();
        }

        private void SetupDataGridView()
        {
            dataGridView_DSMTinh.Columns.Clear();
            dataGridView_DSMTinh.Columns.Add("MaMayTinh", "Mã Máy Tính");
            dataGridView_DSMTinh.Columns.Add("TrangThai", "Trạng Thái");
            dataGridView_DSMTinh.Columns.Add("SoLuong", "Số Lượng");
            dataGridView_DSMTinh.Columns.Add("Link", "Link");
            dataGridView_DSMTinh.Columns.Add("GiaTien", "Giá Tiền");

            dataGridView_DSMTinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_DSMTinh.MultiSelect = false;
            dataGridView_DSMTinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetupComboBoxes()
        {
            // Thiết lập ComboBox Tình Trạng
            comboBox_TinhTrang.Items.Clear();
            comboBox_TinhTrang.Items.Add("Hoạt động");
            comboBox_TinhTrang.Items.Add("Không hoạt động");
            comboBox_TinhTrang.SelectedIndex = 0;

            // Thiết lập ComboBox Lọc Tình Trạng
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
            dataGridView_DSMTinh.SelectionChanged += DataGridView_DSMTinh_SelectionChanged;
            button_XuatExcel.Click += Button_XuatExcel_Click;
        }

        private void Button_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_DSMTinh.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView_DSMTinh.SelectedRows[0];
                    string maMayTinh = row.Cells["MaMayTinh"].Value.ToString();
                    int trangThai = comboBox_TinhTrang.SelectedIndex;
                    int soLuong = int.Parse(textBox_TenMTinh.Text);
                    string link = textBox_Link.Text;
                    int giaTien = int.Parse(textBox_GiaTien.Text);

                    if (mayTinhBUS.SuaMayTinh(maMayTinh, trangThai, soLuong, link, giaTien))
                    {
                        LoadData();
                        ClearInputs();
                    }
                }
                else
                {
                    new MyDialog("Vui lòng chọn máy tính cần sửa!", MyDialog.ERROR_DIALOG);
                }
            }
            catch (FormatException)
            {
                new MyDialog("Vui lòng nhập đúng định dạng số!", MyDialog.ERROR_DIALOG);
            }
            catch (Exception ex)
            {
                new MyDialog("Có lỗi xảy ra: " + ex.Message, MyDialog.ERROR_DIALOG);
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

                var filteredList = listMayTinh.Where(mt => 
                    mt.idSeriMaytinh.ToLower().Contains(searchText) ||
                    mt.link.ToLower().Contains(searchText)).ToList();

                DisplayData(filteredList);
            }
            catch (Exception ex)
            {
                new MyDialog("Có lỗi xảy ra: " + ex.Message, MyDialog.ERROR_DIALOG);
            }
        }

        private void Button_LocTinhTrang_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = comboBox_LocTinhTrang.SelectedIndex;
                List<MayTinh> filteredList;

                switch (selectedIndex)
                {
                    case 0: // Tất cả
                        filteredList = listMayTinh;
                        break;
                    case 1: // Hoạt động
                        filteredList = listMayTinh.Where(mt => mt.trangThai == 1).ToList();
                        break;
                    case 2: // Không hoạt động
                        filteredList = listMayTinh.Where(mt => mt.trangThai == 0).ToList();
                        break;
                    default:
                        filteredList = listMayTinh;
                        break;
                }

                DisplayData(filteredList);
            }
            catch (Exception ex)
            {
                new MyDialog("Có lỗi xảy ra: " + ex.Message, MyDialog.ERROR_DIALOG);
            }
        }

        private void DataGridView_DSMTinh_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_DSMTinh.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridView_DSMTinh.SelectedRows[0];
                    textBox_MaMTinh.Text = row.Cells["MaMayTinh"].Value.ToString();
                    string trangThaiStr = row.Cells["TrangThai"].Value.ToString();
                    comboBox_TinhTrang.SelectedIndex = (trangThaiStr == "Hoạt động") ? 0 : 1;
                    textBox_TenMTinh.Text = row.Cells["SoLuong"].Value.ToString();
                    textBox_GiaTien.Text = row.Cells["GiaTien"].Value.ToString();
                    textBox_Link.Text = row.Cells["Link"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                new MyDialog("Có lỗi xảy ra: " + ex.Message, MyDialog.ERROR_DIALOG);
            }
        }

        private void ClearInputs()
        {
            textBox_MaMTinh.Clear();
            textBox_TenMTinh.Clear();
            textBox_GiaTien.Clear();
            textBox_Link.Clear();
            textBox_TimKiem.Clear();
            comboBox_TinhTrang.SelectedIndex = 0;
            comboBox_LocTinhTrang.SelectedIndex = 0;
        }

        private void LoadData()
        {
            try
            {
                listMayTinh = mayTinhBUS.GetListMayTinh().Cast<MayTinh>().ToList();
                DisplayData(listMayTinh);
            }
            catch (Exception ex)
            {
                new MyDialog("Có lỗi xảy ra khi tải dữ liệu: " + ex.Message, MyDialog.ERROR_DIALOG);
            }
        }

        private void DisplayData(List<MayTinh> data)
        {
            dataGridView_DSMTinh.Rows.Clear();
            foreach (MayTinh mt in data)
            {
                dataGridView_DSMTinh.Rows.Add(
                    mt.idSeriMaytinh,
                    mt.trangThai == 1 ? "Hoạt động" : "Không hoạt động",
                    mt.soLuong,
                    mt.link,
                    mt.giaTien
                );
            }
        }

        private void Button_XuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Lưu file Excel";
                saveFileDialog.FileName = "DanhSachMayTinh_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("MayTinh");
                        // Header
                        worksheet.Cell(1, 1).Value = "Mã Máy Tính";
                        worksheet.Cell(1, 2).Value = "Trạng Thái";
                        worksheet.Cell(1, 3).Value = "Số Lượng";
                        worksheet.Cell(1, 4).Value = "Link";
                        worksheet.Cell(1, 5).Value = "Giá Tiền";

                        // Data
                        int row = 2;
                        foreach (MayTinh mt in listMayTinh)
                        {
                            worksheet.Cell(row, 1).Value = mt.idSeriMaytinh;
                            worksheet.Cell(row, 2).Value = mt.trangThai == 1 ? "Hoạt động" : "Không hoạt động";
                            worksheet.Cell(row, 3).Value = mt.soLuong;
                            worksheet.Cell(row, 4).Value = mt.link;
                            worksheet.Cell(row, 5).Value = mt.giaTien;
                            row++;
                        }

                        workbook.SaveAs(saveFileDialog.FileName);
                    }
                    new MyDialog("Xuất Excel thành công!", MyDialog.SUCCESS_DIALOG);
                }
            }
            catch (Exception ex)
            {
                new MyDialog("Lỗi khi xuất Excel: " + ex.Message, MyDialog.ERROR_DIALOG);
            }
        }
    }
}
