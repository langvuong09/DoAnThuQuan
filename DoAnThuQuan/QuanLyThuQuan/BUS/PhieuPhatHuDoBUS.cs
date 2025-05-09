using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using System.Collections;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class PhieuPhatHuDoBUS
    {
        private PhieuPhatHuDoDAO phieuPhatHuDoDAO = new PhieuPhatHuDoDAO();
        private ArrayList listPhieuPhatHuDo;
        public PhieuPhatHuDo TimPhieuPhatTheoId(int maPhieuPhat)
        {
            return phieuPhatHuDoDAO.TimPhieuPhatTheoId(maPhieuPhat);
        }
     
        // Khởi tạo và đọc danh sách phiếu phạt hư hỏng ngay khi khởi tạo
        public PhieuPhatHuDoBUS()
        {
            DocListPhieuPhatHuDo();
        }

        public int createPhieuPhatMoi()
        {
            return phieuPhatHuDoDAO.GetMaxIdPhieuPhat() + 1;
        }

        // Đọc danh sách phiếu phạt hư hỏng từ cơ sở dữ liệu
        public void DocListPhieuPhatHuDo()
        {
            this.listPhieuPhatHuDo = phieuPhatHuDoDAO.GetListPhieuPhatHuDo();
        }

        // Trả về danh sách phiếu phạt hư hỏng
        public ArrayList GetListPhieuPhatHuDo()
        {
            if (this.listPhieuPhatHuDo == null)
            {
                DocListPhieuPhatHuDo();
            }
            return listPhieuPhatHuDo;
        }

        // Thêm mới một phiếu phạt hư hỏng vào cơ sở dữ liệu
        public bool ThemPhieuPhatHuDo(int maPhieuPhat, int maPhieuTra, int soLuong, int tongTien)
        {
            try
            {
                if (maPhieuPhat <= 0)
                {
                    MyDialog dlg = new MyDialog("Mã phiếu phạt phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (maPhieuTra <= 0)
                {
                    MyDialog dlg = new MyDialog("Mã phiếu trả phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (soLuong <= 0)
                {
                    MyDialog dlg = new MyDialog("Số lượng phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (tongTien <= 0)
                {
                    MyDialog dlg = new MyDialog("Tổng tiền phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                bool flag = phieuPhatHuDoDAO.ThemPhieuPhat(maPhieuPhat, maPhieuTra, soLuong, tongTien);
                if (flag)
                {
                    MyDialog dlg = new MyDialog("Thêm phiếu phạt hư hỏng thành công!", MyDialog.SUCCESS_DIALOG);
                    dlg.ShowDialog();
                    DocListPhieuPhatHuDo(); // Cập nhật lại danh sách
                    return true;
                }
                else
                {
                    MyDialog dlg = new MyDialog("Mã phiếu phạt đã tồn tại hoặc có lỗi xảy ra!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MyDialog dlg = new MyDialog("Có lỗi xảy ra: " + ex.Message, MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        // Cập nhật thông tin một phiếu phạt hư hỏng trong cơ sở dữ liệu
        public bool SuaPhieuPhatHuDo(int maPhieuPhat, int maPhieuTra, int soLuong, int tongTien)
        {
            try
            {
                if (maPhieuPhat <= 0)
                {
                    MyDialog dlg = new MyDialog("Mã phiếu phạt phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (maPhieuTra <= 0)
                {
                    MyDialog dlg = new MyDialog("Mã phiếu trả phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (soLuong <= 0)
                {
                    MyDialog dlg = new MyDialog("Số lượng phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (tongTien <= 0)
                {
                    MyDialog dlg = new MyDialog("Tổng tiền phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                bool flag = phieuPhatHuDoDAO.SuaPhieuPhat(maPhieuPhat, maPhieuTra, soLuong, tongTien);
                if (flag)
                {
                    MyDialog dlg = new MyDialog("Sửa phiếu phạt hư hỏng thành công!", MyDialog.SUCCESS_DIALOG);
                    dlg.ShowDialog();
                    DocListPhieuPhatHuDo(); // Cập nhật lại danh sách
                    return true;
                }
                else
                {
                    MyDialog dlg = new MyDialog("Không tìm thấy phiếu phạt hoặc có lỗi xảy ra!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MyDialog dlg = new MyDialog("Có lỗi xảy ra: " + ex.Message, MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        // Xóa một phiếu phạt hư hỏng khỏi cơ sở dữ liệu
        public bool XoaPhieuPhatHuDo(int maPhieuPhat)
        {
            try
            {
                if (maPhieuPhat <= 0)
                {
                    MyDialog dlg = new MyDialog("Mã phiếu phạt phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                bool flag = phieuPhatHuDoDAO.XoaPhieuPhat(maPhieuPhat);
                if (flag)
                {
                    MyDialog dlg = new MyDialog("Xóa phiếu phạt hư hỏng thành công!", MyDialog.SUCCESS_DIALOG);
                    dlg.ShowDialog();
                    DocListPhieuPhatHuDo(); // Cập nhật lại danh sách
                    return true;
                }
                else
                {
                    MyDialog dlg = new MyDialog("Không tìm thấy phiếu phạt hoặc có lỗi xảy ra!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MyDialog dlg = new MyDialog("Có lỗi xảy ra: " + ex.Message, MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }
    }
} 