using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.DTO;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class SachBUS
    {
        private SachDAO sachDAO = new SachDAO();
        private ArrayList ListSach;

        public SachBUS()
        {
            DocListSach();
        }

        public void DocListSach()
        {
            this.ListSach = sachDAO.GetListSach();
        }
        public ArrayList GetListSach()
        {
            if(this.ListSach == null)
            {
                DocListSach();
            }
            return ListSach;
        }

        public Sach GetSach(string tenSach)
        {
            DocListSach();
            foreach(Sach s in ListSach)
            {
                if (s.tenSach.Contains(tenSach.Trim())){
                    return s;
                }
            }
            return null;
        }

        public Sach GetSach(int maSach)
        {
            DocListSach();
            foreach (Sach s in ListSach)
            {
                if (s.maSach == maSach)
                {
                    return s;
                }
            }
            return null;
        }

        public string GetTenSach(int maSach)
        {
            DocListSach();
            foreach (Sach s in ListSach)
            {
                if (s.maSach == maSach)
                {
                    return s.tenSach;
                }
            }
            return "";
        }

        public bool NhapSachExcel(string tenSach, string idTheLoai, string tacGia, string idKe, string moTa, string thanhTien, string trangThai)
        {
            try
            {
                int maLoai = Convert.ToInt32(idTheLoai);
                int maKe = Convert.ToInt32(idKe);
                int tien = Convert.ToInt32(thanhTien);
                int status = Convert.ToInt32(trangThai);
                Sach s = new Sach();
                s.tenSach = tenSach;
                s.theLoai = maLoai;
                s.tacGia = tacGia;
                s.maKe = maKe;
                s.moTa = moTa;
                s.thanhTien = tien;
                s.trangThai = status;

                sachDAO.NhapSachTuExcel(s);
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public void XuatFileExcel(string filePath)
        {
            try
            {
                sachDAO.XuatFileExcel(filePath);
                MyDialog dlg = new MyDialog("Xuất Excel thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
            }
            catch (Exception ex)
            {
                MyDialog dlg = new MyDialog("Lỗi khi xuất Excel: " + ex.Message, MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
            }
        }

        public bool ThemSach(string tenSach, string idTheLoai, string tacGia, string idKe, string moTa, string thanhTien)
        {
            if(tenSach.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống tên sách!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if(idTheLoai.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống thể loại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if(tacGia.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống tác giả!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if(idKe.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống mã kệ!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if(moTa.Trim() == "")
            {
                moTa = "Không";
            }
            if(thanhTien.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống giá sách!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            int maSach = sachDAO.MaxMaSach() + 1;
            int maTheLoai = Convert.ToInt32(idTheLoai);
            int maKe = Convert.ToInt32(idKe);
            int tien = Convert.ToInt32(thanhTien);
            if(tien <= 0)
            {
                MyDialog dlg = new MyDialog("Giá tiền không hợp lệ!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if (sachDAO.ThemSach(maSach,tenSach, maTheLoai, tacGia, maKe, moTa, tien, 1))
            {
                MyDialog dlg = new MyDialog("Thêm sách thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Thêm sách thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public bool SuaSach(string idSach, string tenSach, string idTheLoai, string tacGia, string idKe, string moTa, string thanhTien)
        {
            if (idSach.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn sách để sửa!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if (tenSach.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống tên sách!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if (idTheLoai.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống thể loại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if (tacGia.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống tác giả!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if (idKe.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống mã kệ!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if (moTa.Trim() == "")
            {
                moTa = "Không";
            }
            if (thanhTien.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống giá sách!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            int maSach = Convert.ToInt32(idSach);
            int maTheLoai = Convert.ToInt32(idTheLoai);
            int maKe = Convert.ToInt32(idKe);
            int tien = Convert.ToInt32(thanhTien);
            if (sachDAO.SuaSach(maSach, tenSach, maTheLoai, tacGia, maKe, moTa, tien))
            {
                MyDialog dlg = new MyDialog("Sửa sách thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Sửa sách thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public bool XoaSach(string idSach)
        {
            if (idSach.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn sách để xóa!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            int maSach = Convert.ToInt32(idSach);
            if(sachDAO.XoaSach(maSach))
            {
                MyDialog dlg = new MyDialog("Xóa sách thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Xóa sách thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }
    }
}
