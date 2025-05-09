using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using System.Collections;
using MySql.Data.MySqlClient;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class KeBUS
    {
        private KeDAO keDAO = new KeDAO();
        private ArrayList listKe;

        // Khởi tạo và đọc danh sách kệ ngay khi khởi tạo
        public KeBUS()
        {
            DocListKe();
        }

        // Đọc danh sách kệ từ cơ sở dữ liệu
        public void DocListKe()
        {
            this.listKe = keDAO.GetListKe();
        }

        // Trả về danh sách kệ
        public ArrayList GetListKe()
        {
            return keDAO.GetListKe();
        }

        // Thêm mới một kệ vào cơ sở dữ liệu
        public bool ThemKe(int maKe, int maKhuVuc)
        {
            if (maKe <= 0)
            {
                MyDialog dlg = new MyDialog("Mã kệ phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (maKhuVuc <= 0)
            {
                MyDialog dlg = new MyDialog("Mã khu vực phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            bool flag = keDAO.ThemKe(maKe, maKhuVuc);
            if (flag)
            {
                MyDialog dlg = new MyDialog("Thêm kệ thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Thêm kệ thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        // Xóa một kệ khỏi cơ sở dữ liệu
        public bool XoaKe(int maKe)
        {
            if (maKe <= 0)
            {
                MyDialog dlg = new MyDialog("Mã kệ phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            bool flag = keDAO.XoaKe(maKe);
            if (flag)
            {
                MyDialog dlg = new MyDialog("Xóa kệ thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Xóa kệ thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }
    }
} 