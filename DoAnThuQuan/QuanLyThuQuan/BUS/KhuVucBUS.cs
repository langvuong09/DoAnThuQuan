using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using System.Collections;
using System.Windows.Forms;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class KhuVucBUS
    {
        // Khởi tạo và đọc danh sách khu vực ngay khi khởi tạo
        private KhuVucDAO khuVucDAO = new KhuVucDAO();
        private ArrayList listKhuVuc = new ArrayList();

        public KhuVucBUS()
        {
            DocListKhuVuc();
        }

        // Đọc danh sách khu vực từ cơ sở dữ liệu
        public void DocListKhuVuc()
        {
            try
            {
                this.listKhuVuc = khuVucDAO.GetListKhuVuc();
            }
            catch (Exception ex)
            {
                MyDialog dlg = new MyDialog("Lỗi khi đọc danh sách khu vực: " + ex.Message, MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
            }
        }

    /// Trả về danh sách khu vực
        public ArrayList GetListKhuVuc()
        {
            if (this.listKhuVuc == null || this.listKhuVuc.Count == 0)
            {
                DocListKhuVuc();
            }
            return listKhuVuc;
        }
        // Kiểm tra thông tin khu vực
        private bool ValidateKhuVuc(int maKhuVuc, string tenKhuVuc)
        {
            if (maKhuVuc <= 0)
            {
                MyDialog dlg = new MyDialog("Mã khu vực phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tenKhuVuc))
            {
                MyDialog dlg = new MyDialog("Không được để trống tên khu vực!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            return true;
        }

        // Thêm mới một khu vực vào cơ sở dữ liệu
        public bool ThemKhuVuc(int maKhuVuc, string tenKhuVuc)
        {
            try
            {
                if (!ValidateKhuVuc(maKhuVuc, tenKhuVuc))
                    return false;

                bool flag = khuVucDAO.ThemKhuVuc(maKhuVuc, tenKhuVuc);
                if (flag)
                {
                    MyDialog dlg = new MyDialog("Thêm khu vực thành công!", MyDialog.SUCCESS_DIALOG);
                    dlg.ShowDialog();
                    DocListKhuVuc(); // Cập nhật lại danh sách
                    return true;
                }
                else
                {
                    MyDialog dlg = new MyDialog("Thêm khu vực thất bại!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MyDialog dlg = new MyDialog("Lỗi: " + ex.Message, MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        // Sửa thông tin một khu vực trong cơ sở dữ liệu
        public bool SuaKhuVuc(int maKhuVuc, string tenKhuVuc)
        {
            try
            {
                if (!ValidateKhuVuc(maKhuVuc, tenKhuVuc))
                    return false;

                bool flag = khuVucDAO.SuaKhuVuc(maKhuVuc, tenKhuVuc);
                if (flag)
                {
                    MyDialog dlg = new MyDialog("Chỉnh sửa khu vực thành công!", MyDialog.SUCCESS_DIALOG);
                    dlg.ShowDialog();
                    DocListKhuVuc(); // Cập nhật lại danh sách
                    return true;
                }
                else
                {
                    MyDialog dlg = new MyDialog("Chỉnh sửa khu vực thất bại!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MyDialog dlg = new MyDialog("Lỗi: " + ex.Message, MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }
        // Xóa một khu vực khỏi cơ sở dữ liệu
        public bool XoaKhuVuc(int maKhuVuc)
        {
            try
            {
                if (maKhuVuc <= 0)
                {
                    MyDialog dlg = new MyDialog("Mã khu vực phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                bool flag = khuVucDAO.XoaKhuVuc(maKhuVuc);
                if (flag)
                {
                    MyDialog dlg = new MyDialog("Xóa khu vực thành công!", MyDialog.SUCCESS_DIALOG);
                    dlg.ShowDialog();
                    DocListKhuVuc(); // Cập nhật lại danh sách
                    return true;
                }
                else
                {
                    MyDialog dlg = new MyDialog("Xóa khu vực thất bại!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MyDialog dlg = new MyDialog("Lỗi: " + ex.Message, MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }
    }
} 