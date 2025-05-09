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
using DoAnThuQuan.MyCustom;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Collections;
using Thuvien.DTO;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Panel_ComponentPPhat : UserControl
    {
        private PhieuPhatHuDoBUS phieuPhatHuDoBUS = new PhieuPhatHuDoBUS();
        private CTPhieuTra_BUS ctptBUS = new CTPhieuTra_BUS();
        private PhieuPhatHuDo pphat = new PhieuPhatHuDo();
        private SachDetailBUS sachDetailBUS = new SachDetailBUS();
        private MayChieuBUS maychieuBUS = new MayChieuBUS();
        private MayTinhBUS mayTinhBUS = new MayTinhBUS();
        private CTPhatHuDoBUS ctppBUS = new CTPhatHuDoBUS();
        private int tongtien = 0;
        private bool isSelectedPhieuTra = false;
        private bool isSelectedMonDo = false;

        public Panel_ComponentPPhat()
        {
            InitializeComponent();
            string[] items = { "Có thể sửa chữa được", "Không sửa lại được" };
            comboBox_SuaChua.Items.AddRange(items);
            CustomizeDataGridView_CTPP(dataGridView_CTPP);
        }
        private void CustomizeDataGridView_CTPP(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Aquamarine;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            if (dgv.Columns.Count == 0)
            {
                dgv.Columns.Add("idPhieuPhat", "ID Phiếu Phạt");
                dgv.Columns.Add("idMonDo", "ID Món Đồ");
                dgv.Columns.Add("moTa", "Mô Tả");
                dgv.Columns.Add("ttien", "Thành Tiền");


                dgv.Columns["idPhieuPhat"].Width = 200;
                dgv.Columns["idMonDo"].Width = 200;
                dgv.Columns["moTa"].Width = 350;
                dgv.Columns["ttien"].Width = 200;

            }
        }

        private void Button_Chon_Click(object sender, EventArgs e)
        {

        }



        private void Button_TaoPhieu_Click(object sender, EventArgs e)
        {

        }



        private void Button_SuaCTPP_Click(object sender, EventArgs e)
        {

        }

        private void Button_XoaCTPP_Click(object sender, EventArgs e)
        {
          
        }





        private void button_PTra_Click(object sender, EventArgs e)
        {

            Form newFormDialog = new Form
            {
                Text = "Danh Sách Các Phiếu Trả",
                Size = new Size(1005, 500),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Component_PhieuTra panel = new Component_PhieuTra
            {
                Dock = DockStyle.Fill
            };


            // Gán sự kiện khi chọn một phiếu mượn
            panel.OnRowSelected += (phieuTra) =>
            {
                MessageBox.Show($"Đã chọn phiếu mượn có ID: {phieuTra.maPhieuTra}");
                pphat.idPhieuPhatHuDo = phieuPhatHuDoBUS.createPhieuPhatMoi();
                pphat.idPhieuTra = phieuTra.maPhieuTra;
                textBox_MaPPhat.Text = pphat.idPhieuPhatHuDo.ToString();
                textBox_MaPTra.Text = phieuTra.maPhieuTra.ToString();
                List<CTPhieuTra> list = ctptBUS.GetListCTPMByIdPhieuTra(phieuTra.maPhieuTra);
                comboBox_MaTBi.Items.Clear();

                foreach (CTPhieuTra ct in list)
                {
                    comboBox_MaTBi.Items.Add(ct.idMonDo);
                }
                dataGridView_CTPP.Rows.Clear();
                newFormDialog.Close();
            };

            newFormDialog.Controls.Add(panel);
            newFormDialog.ShowDialog();
            isSelectedPhieuTra = true;
            dataGridView_CTPP.Rows.Clear();
            comboBox_MaTBi.SelectedIndex = -1;
            comboBox_MaTBi.Text = "";
            comboBox_SuaChua.SelectedIndex = -1;
            comboBox_SuaChua.Text = "";

        }

        private void DataGridView_CTPP_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void label_titleNote_Click(object sender, EventArgs e)
        {

        }

        private void label_titleLyDo_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Chon_Click_1(object sender, EventArgs e)
        {
            if (isSelectedPhieuTra == false)
            {
                MessageBox.Show("Vui lòng chọn phiếu trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox_MaTBi.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn mã thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maThietBi = comboBox_MaTBi.SelectedItem.ToString();
            string lyDoPhat = textBox_LyDo.Text.Trim();
            if (string.IsNullOrEmpty(lyDoPhat))
            {
                MessageBox.Show("Vui lòng nhập lý do phạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string suaChua = comboBox_SuaChua.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(suaChua))
            {
                MessageBox.Show("Vui lòng chọn trạng thái sửa chữa để có thể qui thành tiền phạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra thiết bị đã được chọn chưa
            foreach (DataGridViewRow row in dataGridView_CTPP.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == maThietBi)
                {
                    MessageBox.Show("Thiết bị này đã được chọn rồi, không thể chọn lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int tienPhat = 0;
            // Tính tiền phạt dựa trên loại thiết bị
            if (maThietBi.StartsWith("MD"))
            {
                var sach = sachDetailBUS.GetSachDetailAndThanhTienByIdSeriSach(maThietBi);
                tienPhat = CalculateTienPhat(sach.Item2, suaChua);
            }
            else if (maThietBi.StartsWith("MT"))
            {
                var mt = mayTinhBUS.GetMayTinhById(maThietBi);
                tienPhat = CalculateTienPhat(mt.giaTien, suaChua);
            }
            else if (maThietBi.StartsWith("MC"))
            {
                var mc = maychieuBUS.GetMayChieuById(maThietBi);
                tienPhat = CalculateTienPhat(mc.giaTien, suaChua);
            }

            // Thêm dữ liệu vào DataGridView
            if (tienPhat > 0)
            {
                dataGridView_CTPP.Rows.Add(pphat.idPhieuPhatHuDo, maThietBi, lyDoPhat, tienPhat);
                textBox_LyDo.Text = "";
                isSelectedMonDo = true;
                tongtien = tongtien + tienPhat;
            }
        }

        private int CalculateTienPhat(int? giaTienNullable, string suaChua)
        {
            if (!giaTienNullable.HasValue)
                return 0;

            int giaTien = giaTienNullable.Value;
            int tienPhat = 0;

            if (suaChua == "Có thể sửa chữa được")
            {
                tienPhat = giaTien * 50 / 100; // 50% tiền phạt
            }
            else if (suaChua == "Không sửa lại được")
            {
                tienPhat = giaTien; // 100% tiền phạt
            }

            return tienPhat;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_TaoPhieu_Click_1(object sender, EventArgs e)
        {
            if (isSelectedMonDo == false)
            {
                MessageBox.Show("Vui lòng chọn phiếu trả và lựa chọn món đồ bị phạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int soLuongMuon = dataGridView_CTPP.AllowUserToAddRows
               ? dataGridView_CTPP.Rows.Count - 1
               : dataGridView_CTPP.Rows.Count;
            pphat.solg = soLuongMuon;
            pphat.tongTien = tongtien;
            bool daThemPhieu = phieuPhatHuDoBUS.ThemPhieuPhatHuDo(pphat.idPhieuPhatHuDo, pphat.idPhieuTra, pphat.solg, pphat.tongTien);

            if (!daThemPhieu)
            {
                MessageBox.Show("Xảy ra vấn đề khi thêm phiếu!");

                return;
            }

            foreach (DataGridViewRow row in dataGridView_CTPP.Rows)
            {
                if (row.IsNewRow) continue;

                string maThietBi = row.Cells[1].Value?.ToString();
                int maPhieuPhat = pphat.idPhieuPhatHuDo;
                String mota = row.Cells[2].Value?.ToString();
                int thanhtien = int.Parse(row.Cells[3].Value?.ToString());
                if (string.IsNullOrEmpty(maThietBi)) continue;

                // Thêm chi tiết phiếu mượn
                bool daThemCTPM = ctppBUS.ThemCTPhat(maPhieuPhat, maThietBi, mota, thanhtien);
                if (!daThemCTPM)
                {
                    MessageBox.Show("Đã có vấn đề xảy ra với hệ thống khi thêm chi tiết phiếu phạt!");
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
            isSelectedMonDo = false;
            isSelectedPhieuTra = false;

        }
        private bool CapNhatTrangThaiThietBi(string maThietBi)
        {
            if (maThietBi.StartsWith("MD"))
                return sachDetailBUS.CapNhatTrangThaiSachDetail(maThietBi, -1);

            if (maThietBi.StartsWith("MT"))
                return mayTinhBUS.GiamSoLgMayTinh(maThietBi);

            if (maThietBi.StartsWith("MC"))
                return maychieuBUS.GiamSoLgMayChieu(maThietBi);

            return false; // Không đúng định dạng mã
        }

        private void button_XoaCTPP_Click_1(object sender, EventArgs e)
        {
            if (dataGridView_CTPP.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Lấy giá trị tiền phạt từ cột thứ 4 (index = 3)
                    int tienPhat = 0;
                    if (dataGridView_CTPP.CurrentRow.Cells[3].Value != null)
                    {
                        int.TryParse(dataGridView_CTPP.CurrentRow.Cells[3].Value.ToString(), out tienPhat);
                    }

                    tongtien -= tienPhat;
                    dataGridView_CTPP.Rows.Remove(dataGridView_CTPP.CurrentRow);
                }
            }
        }
    }
}
