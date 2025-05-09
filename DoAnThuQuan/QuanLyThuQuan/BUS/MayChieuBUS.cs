using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using System.Collections;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class MayChieuBUS
    {
        private MayChieuDAO mayChieuDAO = new MayChieuDAO();
        private ArrayList listMayChieu;

        // Khởi tạo và đọc danh sách máy chiếu ngay khi khởi tạo
        public MayChieuBUS()
        {
            DocListMayChieu();
        }

        public MayChieu GetMayChieuById(string maMayChieu)
        {
            return mayChieuDAO.GetMayChieuById(maMayChieu);
        }
        public bool TangSoLgMayChieu(string maMayChieu)
        {
            return mayChieuDAO.TangSoLgMayChieu(maMayChieu);
        }
        public bool GiamSoLgMayChieu(string maMayChieu)
        {
            return mayChieuDAO.GiamSoLgMayChieu(maMayChieu);
        }

        // Đọc danh sách máy chiếu từ cơ sở dữ liệu
        public void DocListMayChieu()
        {
            this.listMayChieu = mayChieuDAO.GetListMayChieu();
        }

        public ArrayList GetListMayChieu()
        {
            if (this.listMayChieu == null)
            {
                DocListMayChieu();
            }
            return listMayChieu;
        }

        // Thêm mới một máy chiếu vào cơ sở dữ liệu
        public bool ThemMayChieu(string maMayChieu, int trangThai, int soLuong, string link, int giaTien)
        {
            if (maMayChieu.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống mã máy chiếu!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (soLuong <= 0)
            {
                MyDialog dlg = new MyDialog("Số lượng phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (giaTien <= 0)
            {
                MyDialog dlg = new MyDialog("Giá tiền phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (link.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống link!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            bool flag = mayChieuDAO.ThemMayChieu(maMayChieu, trangThai, soLuong, link, giaTien);
            if (flag)
            {
                MyDialog dlg = new MyDialog("Thêm máy chiếu thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Thêm máy chiếu thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }
        // Cập nhật thông tin một máy chiếu trong cơ sở dữ liệu
        public bool SuaMayChieu(string maMayChieu, int trangThai, int soLuong, string link, int giaTien)
        {
            if (maMayChieu.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống mã máy chiếu!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (soLuong <= 0)
            {
                MyDialog dlg = new MyDialog("Số lượng phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (giaTien <= 0)
            {
                MyDialog dlg = new MyDialog("Giá tiền phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (link.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống link!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            bool flag = mayChieuDAO.SuaMayChieu(maMayChieu, trangThai, soLuong, link, giaTien);
            if (flag)
            {
                MyDialog dlg = new MyDialog("Sửa máy chiếu thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Sửa máy chiếu thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public bool ThemSLMayChieu(string maMayChieu, string sl)
        {
            int soLuong = Convert.ToInt32(sl);
            return mayChieuDAO.ThemSLMayChieu(maMayChieu, soLuong);
        }

        // Xóa một máy chiếu khỏi cơ sở dữ liệu
        public bool XoaMayChieu(string maMayChieu)
        {
            if (maMayChieu.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống mã máy chiếu!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            bool flag = mayChieuDAO.XoaMayChieu(maMayChieu);
            if (flag)
            {
                MyDialog dlg = new MyDialog("Xóa máy chiếu thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Xóa máy chiếu thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }
    }
} 