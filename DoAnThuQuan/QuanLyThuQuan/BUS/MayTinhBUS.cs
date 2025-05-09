using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using System.Collections;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class MayTinhBUS
    {
        private MayTinhDAO mayTinhDAO = new MayTinhDAO();
        private ArrayList listMayTinh;

        // Khởi tạo và đọc danh sách máy tính ngay khi khởi tạo
        public MayTinhBUS()
        {
            DocListMayTinh();
        }

        public MayTinh GetMayTinhById(string maMayTinh)
        {
            return mayTinhDAO.GetMayTinhById(maMayTinh);
        }
        public bool TangSoLgMayTinh(string maMayTinh)
        {
            return mayTinhDAO.TangSoLgMayTinh(maMayTinh);
        }
        public bool GiamSoLgMayTinh(string maMayTinh)
        {
            return mayTinhDAO.GiamSoLgMayTinh(maMayTinh);
        }

        // Đọc danh sách máy tính từ cơ sở dữ liệu
        public void DocListMayTinh()
        {
            this.listMayTinh = mayTinhDAO.GetListMayChieu();
        }

        // Trả về danh sách máy tính
        public ArrayList GetListMayTinh()
        {
            if (this.listMayTinh == null)
            {
                DocListMayTinh();
            }
            return listMayTinh;
        }

        // Thêm mới một máy tính vào cơ sở dữ liệu
        public bool ThemMayTinh(string maMayTinh, int trangThai, int soLuong, string link, int giaTien)
        {
            if (string.IsNullOrEmpty(maMayTinh))
            {
                MyDialog dlg = new MyDialog("Mã máy tính không được để trống!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (trangThai < 0)
            {
                MyDialog dlg = new MyDialog("Trạng thái không hợp lệ!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (soLuong <= 0)
            {
                MyDialog dlg = new MyDialog("Số lượng phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(link))
            {
                MyDialog dlg = new MyDialog("Link không được để trống!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (giaTien <= 0)
            {
                MyDialog dlg = new MyDialog("Giá tiền phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            bool flag = mayTinhDAO.ThemMayTinh(maMayTinh, trangThai, soLuong, link, giaTien);
            if (flag)
            {
                MyDialog dlg = new MyDialog("Thêm máy tính thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Thêm máy tính thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        // Cập nhật thông tin một máy tính trong cơ sở dữ liệu
        public bool SuaMayTinh(string maMayTinh, int trangThai, int soLuong, string link, int giaTien)
        {
            if (string.IsNullOrEmpty(maMayTinh))
            {
                MyDialog dlg = new MyDialog("Mã máy tính không được để trống!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (trangThai < 0)
            {
                MyDialog dlg = new MyDialog("Trạng thái không hợp lệ!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (soLuong <= 0)
            {
                MyDialog dlg = new MyDialog("Số lượng phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(link))
            {
                MyDialog dlg = new MyDialog("Link không được để trống!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (giaTien <= 0)
            {
                MyDialog dlg = new MyDialog("Giá tiền phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            bool flag = mayTinhDAO.SuaMayTinh(maMayTinh, trangThai, soLuong, link, giaTien);
            if (flag)
            {
                MyDialog dlg = new MyDialog("Sửa máy tính thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;    
            }
            else
            {
                MyDialog dlg = new MyDialog("Sửa máy tính thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public bool ThemSLMayTinh(string maMayTinh, string sl)
        {
            int soLuong = Convert.ToInt32(sl);
            return mayTinhDAO.ThemSLMayTinh(maMayTinh, soLuong);
        }

        // Xóa một máy tính khỏi cơ sở dữ liệu
        public bool XoaMayTinh(string maMayTinh)
        {
            if (string.IsNullOrEmpty(maMayTinh))
            {
                MyDialog dlg = new MyDialog("Mã máy tính không được để trống!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            bool flag = mayTinhDAO.XoaMayTinh(maMayTinh);
            if (flag)
            {
                MyDialog dlg = new MyDialog("Xóa máy tính thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Xóa máy tính thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }
    }
} 