using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.DAO;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class PhieuNhapBUS
    {
        private PhieuNhapDAO PhieuNhapDAO = new PhieuNhapDAO();
        private ArrayList listPhieuNhap;

        public PhieuNhapBUS()
        {
            DocListPhieuNhap();
        }

        public void DocListPhieuNhap()
        {
            this.listPhieuNhap = PhieuNhapDAO.GetListPhieuNhap();
        }
        public ArrayList GetListPhieuNhap()
        {
            if(listPhieuNhap == null)
            {
                DocListPhieuNhap();
            }
            return listPhieuNhap;
        }

        public bool ThemPhieuNhap(string ngayNhap, string maNV, string slSach, string slMayTinh, string slMayChieu, int thanhTien)
        {
            int sach = Convert.ToInt32(slSach);
            int mayTinh = Convert.ToInt32(slMayTinh);
            int mayChieu = Convert.ToInt32(slMayChieu);
            int maNhanVien = Convert.ToInt32(maNV);
            int maPN = GetListPhieuNhap().Count + 1;
            DateTime ngay = Convert.ToDateTime(ngayNhap);
            if(sach == 0 && mayTinh == 0 && mayChieu == 0)
            {
                MyDialog dlg = new MyDialog("Chưa ghi số lượng nhập!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if (PhieuNhapDAO.ThemPhieuNhap(maPN, ngay, maNhanVien, sach, mayTinh, mayChieu, thanhTien))
            {
                MyDialog dlg = new MyDialog("Thêm phiếu nhập thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Thêm phiếu nhập thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public bool SuaPhieuNhap(string ma, string ngayNhap, string maNV, string slSach, string slMayTinh, string slMayChieu, string thanhTien)
        {
            if(ma.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn phiếu nhập để sửa!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            int sach = Convert.ToInt32(slSach);
            int mayTinh = Convert.ToInt32(slMayTinh);
            int mayChieu = Convert.ToInt32(slMayChieu);
            int tien = Convert.ToInt32(thanhTien);
            int maNhanVien = Convert.ToInt32(maNV);
            int maPN = Convert.ToInt32(ma);
            DateTime ngay = Convert.ToDateTime(ngayNhap);
            if (sach == 0 && mayTinh == 0 && mayChieu == 0)
            {
                MyDialog dlg = new MyDialog("Chưa ghi số lượng nhập!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if (PhieuNhapDAO.SuaPhieuNhap(maPN, ngay, maNhanVien, sach, mayTinh, mayChieu, tien))
            {
                MyDialog dlg = new MyDialog("Sửa phiếu nhập thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Sửa phiếu nhập thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public bool XoaPhieuNhap(string maPhieuNhap)
        {
            if (maPhieuNhap.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn phiếu nhập để xóa!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            int maPN = Convert.ToInt32(maPhieuNhap);
            if (PhieuNhapDAO.XoaPhieuNhap(maPN))
            {
                MyDialog dlg = new MyDialog("Xóa phiếu nhập thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Xóa phiếu nhập thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }
    }
}
