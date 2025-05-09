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
    internal class TheLoaiSachBUS
    {
        private TheLoaiSachDAO theLoaiSachDAO = new TheLoaiSachDAO();
        private ArrayList listTheLoaiSach;

        public TheLoaiSachBUS()
        {
            DocListTheLoaiSach();
        }

        private void DocListTheLoaiSach()
        {
            this.listTheLoaiSach = theLoaiSachDAO.GetListTheLoaiSach();
        }
        public ArrayList GetListTheLoaiSach()
        {
            if(this.listTheLoaiSach == null)
            {
                DocListTheLoaiSach();
            }
            return listTheLoaiSach;
        }

        public TheLoaiSach GetTheLoaiSach(int id)
        {
            return theLoaiSachDAO.GetTheLoaiSach(id);
        }

        public bool ThemTheLoaiSach(string tenTheLoai)
        {
            if (tenTheLoai.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống tên thể loại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            int maTheLoai = GetListTheLoaiSach().Count + 1;
            if (theLoaiSachDAO.ThemTheLoai(maTheLoai, tenTheLoai))
            {
                MyDialog dlg = new MyDialog("Thêm thể loại thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Thêm thể loại thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public bool XoaTheLoaiSach(string maTheLoai)
        {
            if (maTheLoai.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn thể loại để xóa!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            int maTL = Convert.ToInt32(maTheLoai);
            if (theLoaiSachDAO.XoaTheLoai(maTL))
            {
                MyDialog dlg = new MyDialog("Xóa thể loại thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Xóa thể loại thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }
    }
}
