using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.BUS;
using DoAnThuQuan.QuanLyThuQuan.DTO;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class PhieuNhapGUI : UserControl
    {
        private PhieuNhapBUS phieuNhapBUS = new PhieuNhapBUS();
        private CTPhieuNhapBUS cTPhieuNhapBUS = new CTPhieuNhapBUS();
        private SachBUS sachBUS = new SachBUS();
        private SachDetailBUS sachDetailBUS = new SachDetailBUS();
        private MayTinhBUS tinhBUS = new MayTinhBUS();
        private MayChieuBUS chieuBUS = new MayChieuBUS();
        private UserBUS userBUS = new UserBUS();
        public PhieuNhapGUI()
        {
            InitializeComponent();
            AddEvents();
        }

        private void AddEvents()
        {
            LoadDaTaLenTablePhieuNhap();
            LoadDataLenTableCTPhieuNhap();
            cboLoaiSanPham.SelectedIndexChanged += cboLoaiSanPham_Click;
            dgvSanPham.CellClick += new DataGridViewCellEventHandler(dgvSanPham_CellClick);
            btnThem.Click += XuLyThemVaoGioHang;
            btnXoa.Click += XuLyXoaKhoiGioHang;
            btnNhapHang.Click += XuLyNhapHang;
        }

        private void cboLoaiSanPham_Click(object sender, EventArgs e)
        {
            string loaiSP = cboLoaiSanPham.Text.Trim();
            if (loaiSP == "Sách")
            {
                LoadDataLenTableSanPhamlaSach();
            }
            else if (loaiSP == "Máy tính")
            {
                LoadDataLenTableSanPhamLaMayTinh();
            }
            else if (loaiSP == "Máy chiếu")
            {
                LoadDataLenTableSanPhamLaMayChieu();
            }
        }

        private void LoadDaTaLenTablePhieuNhap()
        {
            phieuNhapBUS.DocListPhieuNhap();
            dgvPhieuNhap.Rows.Clear();

            ArrayList dspn = phieuNhapBUS.GetListPhieuNhap();
            foreach (PhieuNhap pn in dspn)
            {
                string ten = userBUS.GetTenNhanVien(pn.idNhanVien);
                dgvPhieuNhap.Rows.Add(
                    pn.idPhieuNhap,
                    pn.ngayNhap,
                    ten,
                    pn.slSach,
                    pn.slMayTinh,
                    pn.slMayChieu,
                    pn.tongTien
                    );
            }
        }

        private void LoadDataLenTableCTPhieuNhap()
        {
            cTPhieuNhapBUS.DocListCTPhieuNhap();
            dgvCTPhieuNhap.Rows.Clear();

            ArrayList dsctpn = cTPhieuNhapBUS.GetListCTPhieuNhap();
            foreach (CTPhieuNhap ctpn in dsctpn)
            {
                dgvCTPhieuNhap.Rows.Add(
                    ctpn.idPhieuNhap,
                    ctpn.idSanPham,
                    ctpn.loaiSanPham,
                    ctpn.thanhTien
                    );
            }
        }

        private void LoadDataLenTableSanPhamlaSach()
        {
            sachBUS.DocListSach();
            dgvSanPham.Rows.Clear();

            ArrayList dss = sachBUS.GetListSach();
            foreach (Sach sach in dss)
            {
                int soLuong = sachDetailBUS.GetCountSachDetail(sach.maSach);
                dgvSanPham.Rows.Add(
                    sach.maSach,
                    sach.tenSach,
                    soLuong,
                    sach.thanhTien
                    );
            }
        }

        private void LoadDataLenTableSanPhamLaMayTinh()
        {
            tinhBUS.DocListMayTinh();
            dgvSanPham.Rows.Clear();

            ArrayList dsmt = tinhBUS.GetListMayTinh();
            foreach (MayTinh mt in dsmt)
            {
                dgvSanPham.Rows.Add(
                    mt.idSeriMaytinh,
                    mt.link,
                    mt.soLuong,
                    mt.giaTien * 100
                    );
            }
        }

        private void LoadDataLenTableSanPhamLaMayChieu()
        {
            chieuBUS.DocListMayChieu();
            dgvSanPham.Rows.Clear();

            ArrayList dsmc = chieuBUS.GetListMayChieu();
            foreach (MayChieu mc in dsmc)
            {
                dgvSanPham.Rows.Add(
                    mc.idSeriMaychieu,
                    mc.link,
                    mc.soLuong,
                    mc.giaTien * 100
                    );
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                XuLyClickTblSanPham();
            }
        }

        private void XuLyClickTblSanPham()
        {
            int row = dgvSanPham.CurrentCell.RowIndex;
            if(row >= 0)
            {
                string ma = dgvSanPham.Rows[row].Cells[0].Value?.ToString();
                txtMaSanPham.Text = ma;
                txtSoLuong.Text = "1";
            }
        }

        private void XuLyThemVaoGioHang(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow != null)
            {
                int row = dgvSanPham.CurrentRow.Index;

                string ma = dgvSanPham.Rows[row].Cells[0].Value?.ToString();
                string ten = dgvSanPham.Rows[row].Cells[1].Value?.ToString();
                string giaStr = dgvSanPham.Rows[row].Cells[3].Value?.ToString();
                string slStr = txtSoLuong.Text.Trim();
                string loai = cboLoaiSanPham.Text.Trim();

                if (string.IsNullOrEmpty(slStr) || !int.TryParse(slStr, out int soLuong) || soLuong <= 0)
                {
                    MyDialog dlg = new MyDialog("Vui lòng nhập số lượng hợp lệ!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return;
                }

                if (!int.TryParse(giaStr, out int gia))
                {
                    MyDialog dlg =  new MyDialog("Giá sản phẩm không hợp lệ!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return;
                }

                int tong = soLuong * gia;

                dgvGioHang.Rows.Add(ma, ten, loai, soLuong, tong);
            }
            else
            {
                MyDialog dlg = new MyDialog("Chưa chọn sản phẩm để nhập!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return;
            }
        }

        private void XuLyXoaKhoiGioHang(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow != null)
            {
                int rowIndex = dgvGioHang.CurrentRow.Index;
                if (rowIndex >= 0 && rowIndex < dgvGioHang.Rows.Count)
                {
                    dgvGioHang.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    MyDialog dlg = new MyDialog("Chưa chọn sản phẩm để xóa!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return;
                }
            }
        }

        private void XuLyNhapHang(object sender, EventArgs e)
        {
            int countSach=0, countMT=0, countMC=0;
            int tong=0;
            for(int i =0; i < dgvGioHang.Rows.Count; i++)
            {
                string ma = dgvGioHang.Rows[i].Cells[0].Value?.ToString();
                string loai = dgvGioHang.Rows[i].Cells[2].Value?.ToString();
                string sl = dgvGioHang.Rows[i].Cells[3].Value?.ToString();
                string tien = dgvGioHang.Rows[i].Cells[4].Value?.ToString();
                int thanhTien = Convert.ToInt32(tien);
                tong = tong + thanhTien;

                if(loai == "Sách")
                {
                    countSach++;
                    int soLuong = Convert.ToInt32(sl);
                    for (int j = 0; j < soLuong; j++)
                    {
                        sachDetailBUS.ThemSachDetail(ma);
                    }
                }else if(loai == "Máy tính")
                {
                    countMT++;
                    tinhBUS.ThemSLMayTinh(ma, sl);
                }else if(loai == "Máy chiếu")
                {
                    countMC++;
                    chieuBUS.ThemSLMayChieu(ma, sl);
                }
            }
            string maNV = Convert.ToString(UserSession.UserId);
            string ngay = Convert.ToString(DateTime.Now);
            string cSach = Convert.ToString(countSach);
            string cMT = Convert.ToString(countMT);
            string cMC = Convert.ToString(countMC);
            bool flag = phieuNhapBUS.ThemPhieuNhap(ngay, maNV, cSach, cMT, cMC, tong);
            if (flag)
            {
                string maPN = Convert.ToString(phieuNhapBUS.GetListPhieuNhap().Count+1);
                for (int i = 0; i < dgvGioHang.Rows.Count; i++)
                {
                    string ma = dgvGioHang.Rows[i].Cells[0].Value?.ToString();
                    string loai = dgvGioHang.Rows[i].Cells[2].Value?.ToString();
                    string sl = dgvGioHang.Rows[i].Cells[3].Value?.ToString();
                    string tien = dgvGioHang.Rows[i].Cells[4].Value?.ToString();
                    if (loai == "Sách")
                    {
                        cTPhieuNhapBUS.themCTPhieuNhap(maPN,ma,loai,tien);
                    }
                    else if (loai == "Máy tính")
                    {
                        int soLuong = Convert.ToInt32(sl);
                        for(int j = 0; j < soLuong; j++)
                        {
                            cTPhieuNhapBUS.themCTPhieuNhap(maPN,ma,loai,tien);
                        }
                    }
                    else if (loai == "Máy chiếu")
                    {
                        int soLuong = Convert.ToInt32(sl);
                        for (int j = 0; j < soLuong; j++)
                        {
                            cTPhieuNhapBUS.themCTPhieuNhap(maPN, ma, loai, tien);
                        }
                    }
                }
            }
            dgvGioHang.Rows.Clear();
            LoadDataLenTableSanPhamlaSach();
            LoadDataLenTableSanPhamLaMayTinh();
            LoadDataLenTableSanPhamLaMayChieu();
            LoadDaTaLenTablePhieuNhap();
            LoadDataLenTableCTPhieuNhap();
        }
    }
}
