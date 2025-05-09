using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.BUS;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using DoAnThuQuan.QuanLyThuQuan.GUI;

using System;
using System.Collections;

using Thuvien.DTO;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Panel_Sach : UserControl
    {
        private SachBUS sachBUS = new SachBUS();
        private SachDetailBUS sachDatailBUS = new SachDetailBUS();
        private TheLoaiSachBUS tlsBUS = new TheLoaiSachBUS();
        private KeBUS keBUS = new KeBUS();
        private ExcelHandler excelHandler = new ExcelHandler();
        public Panel_Sach()
        {
            AddControls();
            AddEvents();
        }

        private void AddEvents()
        {
            LoadDataLenTableSach();
            LoadDataLoai();
            LoadDataMaKe();
            dgvSach.CellClick += new DataGridViewCellEventHandler(dgvSach_CellClick);
            cboTheLoai.SelectedIndexChanged += XuLyThemLoai;
            btnCapNhat.Click += XuLyBtnReset;
            btnThem.Click += XuLyThemSach;
            btnSua.Click += XuLySuaSach;
            btnXoa.Click += XuLyXoaSach;
            btnTimKiem.Click += XuLyTimSach;
            btnXuat.Click += XuLyXuatFileExcel;
            btnNhap.Click += XuLyNhapFileExcel;
            button_DSPSach.Click += HienDanhSachSachDetail;
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo không phải click vào header
            if (e.RowIndex >= 0)
            {
                XuLyClickTblSach();
            }
        }

        private void HienDanhSachSachDetail(object sender, EventArgs e)
        {
            DlgSachDetail sachDetail = new DlgSachDetail();
            sachDetail.ShowDialog();
        }

        private void button_chonke_Click(object sender, EventArgs e)
        {
            Form newFormDialog = new Form
            {
                Text = "DANH SÁCH KỆ",
                Size = new Size(1009,500),
                StartPosition = FormStartPosition.CenterParent
            };

            Component_Ke panel = new Component_Ke();


            newFormDialog.Controls.Add(panel);
            newFormDialog.ShowDialog();
        }

        private void XuLyThemLoai(object sender, EventArgs e)
        {
            int x = cboTheLoai.SelectedIndex;
            if (x == cboTheLoai.Items.Count - 1)
            {
                DlgLoai loaiGUI = new DlgLoai();
                if (loaiGUI.ShowDialog() == DialogResult.OK)
                {
                    LoadDataLoai();
                }
            }
        }

        private void LoadDataLoai()
        {
            cboTheLoai.Items.Clear();
            TheLoaiSachBUS tlsBUS1 = new TheLoaiSachBUS();

            ArrayList dsLoai = tlsBUS1.GetListTheLoaiSach();

            foreach(TheLoaiSach loai in dsLoai)
            {
                cboTheLoai.Items.Add($"{loai.maTheLoai} - {loai.tenTheLoai}");
            }
            cboTheLoai.Items.Add("Khác...");
        }

        private void LoadDataMaKe()
        {
            cboMaKe.Items.Clear();
            ArrayList dsMaKe = keBUS.GetListKe();
            foreach(ke k in dsMaKe)
            {
                cboMaKe.Items.Add($"{k.id_ke}");
            }
        }

        private void LoadDataLenTableSach()
        {
            sachBUS.DocListSach();
            dgvSach.Rows.Clear();

            ArrayList dss = sachBUS.GetListSach();
            foreach(Sach s in dss)
            {
                string trangThai = (s.trangThai == 1) ? "Còn" : "Không";
                string tenTheLoai = tlsBUS.GetTheLoaiSach(s.theLoai).tenTheLoai;
                dgvSach.Rows.Add(
                    s.maSach,
                    s.tenSach,
                    tenTheLoai,
                    s.tacGia,
                    s.maKe,
                    s.moTa,
                    s.thanhTien,
                    trangThai
                    );
            }
        }

        private void XuLyClickTblSach()
        {
            int row = dgvSach.CurrentCell.RowIndex;
            if (row >= 0)
            {
                string maSach = dgvSach.Rows[row].Cells[0].Value?.ToString();
                string tenSach = dgvSach.Rows[row].Cells[1].Value?.ToString();
                string loai = dgvSach.Rows[row].Cells[2].Value?.ToString();
                string tacGia = dgvSach.Rows[row].Cells[3].Value?.ToString();
                string maKe = dgvSach.Rows[row].Cells[4].Value?.ToString();
                string moTa = dgvSach.Rows[row].Cells[5].Value?.ToString();
                string gia = dgvSach.Rows[row].Cells[6].Value?.ToString();

                txtMaSach.Text = maSach;
                txtDocGia.Text = tacGia;
                txtTenSach.Text = tenSach;
                txtMoTa.Text = moTa;
                txtThanhTien.Text = gia;

                for (int i = 0; i < cboTheLoai.Items.Count; i++)
                {
                    string item = cboTheLoai.Items[i].ToString();
                    int index = item.IndexOf('-');
                    if (index != -1 && index + 1 < item.Length)
                    {
                        string tenLoai = item.Substring(index + 1).Trim();
                        if (tenLoai.Equals(loai, StringComparison.OrdinalIgnoreCase))
                        {
                            cboTheLoai.SelectedIndex = i;
                            break;
                        }
                    }
                }
                for (int i = 0; i < cboMaKe.Items.Count; i++)
                {
                    string item = cboMaKe.Items[i].ToString().Trim();
                    if (item.Equals(maKe, StringComparison.OrdinalIgnoreCase))
                    {
                        cboMaKe.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void XuLyBtnReset(object sender, EventArgs e)
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            cboTheLoai.Text = "";
            txtDocGia.Text = "";
            cboMaKe.Text = "";
            txtMoTa.Text = "";
            txtThanhTien.Text = "";
            txtTimKiem.Text = "";
            LoadDataLenTableSach();
            LoadDataLoai();
            LoadDataMaKe();
        }

        private void XuLyThemSach(object sender, EventArgs e)
        {
            string item = cboTheLoai.Text;
            int index = item.IndexOf('-');

            if (index == -1)
            {
                MyDialog dlg = new MyDialog("Giá trị thể loại không hợp lệ", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return;
            }
            foreach (DataGridViewRow row in dgvSach.Rows)
            {
                if (row.IsNewRow) continue;

                string maSach = row.Cells[0].Value?.ToString();
                if (maSach == txtMaSach.Text)
                {
                    MyDialog dlg = new MyDialog("Sách đã tồn tại!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return;
                }
            }

            string maLoai = item.Substring(0, index).Trim();

            sachBUS.ThemSach(txtTenSach.Text, maLoai, txtDocGia.Text, cboMaKe.Text, txtMoTa.Text, txtThanhTien.Text);
            LoadDataLenTableSach();
            XuLyBtnReset(sender,e);
        }


        private void XuLySuaSach(object sender, EventArgs e)
        {
            string item = cboTheLoai.Text;
            int index = item.IndexOf('-');
            string maLoai = item.Substring(0, index).Trim();
            sachBUS.SuaSach(txtMaSach.Text, txtTenSach.Text, maLoai, txtDocGia.Text, cboMaKe.Text, txtMoTa.Text, txtThanhTien.Text);
            LoadDataLenTableSach();
            XuLyBtnReset(sender, e);
        }

        private void XuLyXoaSach(object sender, EventArgs e)
        {
            sachBUS.XoaSach(txtMaSach.Text);
            sachDatailBUS.XoaSachDetail(txtMaSach.Text);
            LoadDataLenTableSach();
            XuLyBtnReset(sender, e);
        }

        private void XuLyTimSach(object sender, EventArgs e)
        {
            dgvSach.Rows.Clear();

            Sach s = sachBUS.GetSach(txtTimKiem.Text);
            string trangThai = (s.trangThai == 1) ? "Còn" : "Không";
            string tenTheLoai = tlsBUS.GetTheLoaiSach(s.theLoai).tenTheLoai;
            dgvSach.Rows.Add(
                s.maSach,
                s.tenSach,
                tenTheLoai,
                s.tacGia,
                s.maKe,
                s.moTa,
                s.thanhTien,
                trangThai
                );
        }

        private void XuLyXuatFileExcel(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Lưu file Excel";
                saveFileDialog.FileName = "DanhSachSach_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    sachBUS.XuatFileExcel(saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MyDialog dlg = new MyDialog("Lỗi khi xuất Excel: " + ex.Message, MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
            }
        }

        private void XuLyNhapFileExcel(object sender, EventArgs e)
        {
            excelHandler.NhapExcel(dgvSach);

            foreach (DataGridViewRow row in dgvSach.Rows)
            {
                if (row.IsNewRow) continue;

                string tenSach = row.Cells[1].Value?.ToString() ?? "";
                string loai = row.Cells[2].Value?.ToString() ?? "";
                string tacGia = row.Cells[3].Value?.ToString() ?? "";
                string maKe = row.Cells[4].Value?.ToString() ?? "";
                string moTa = row.Cells[5].Value?.ToString() ?? "";
                string gia = row.Cells[6].Value?.ToString() ?? "";
                string trangThaiText = row.Cells[7].Value?.ToString()?.Trim() ?? "";
                string trangThai = (trangThaiText == "Còn") ? "1" :
                       (trangThaiText == "Không") ? "0" : "0";

                sachBUS.NhapSachExcel(tenSach,loai,tacGia,maKe,moTa,gia,trangThai);
            }
        }
    }
}
