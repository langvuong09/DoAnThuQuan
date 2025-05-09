using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using System.Collections;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class PhieuDatChoBUS
    {
        private PhieuDatChoDAO phieuDatChoDAO = new PhieuDatChoDAO();
        private ArrayList listPhieuDatCho;

        // Khởi tạo và đọc danh sách phiếu đặt chỗ ngay khi khởi tạo
        public PhieuDatChoBUS()
        {
            DocListPhieuDatCho();
        }
        public PhieuDatCho GetPhieuDatChoById(int idPhieuDatCho)
        {
            return phieuDatChoDAO.GetPhieuDatChoById(idPhieuDatCho);
        }

        // Đọc danh sách phiếu đặt chỗ từ cơ sở dữ liệu
        public void DocListPhieuDatCho()
        {
            this.listPhieuDatCho = phieuDatChoDAO.GetListPhieuDatCho();
        }
        // Trả về danh sách phiếu đặt chỗ
        public ArrayList GetListPhieuDatCho()
        {
            if (this.listPhieuDatCho == null)
            {
                DocListPhieuDatCho();
            }
            return listPhieuDatCho;
        }
        // Thêm mới một phiếu đặt chỗ vào cơ sở dữ liệu
        public bool ThemPhieuDatCho(int maPhieu, int ngDatCho, int maChoNgoi, DateTime createAt, DateTime tgian, int trangThai, int soTien)
        {
            if (maPhieu <= 0)
            {
                MyDialog dlg = new MyDialog("Mã phiếu đặt chỗ phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (ngDatCho <= 0)
            {
                MyDialog dlg = new MyDialog("Mã người đặt chỗ phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (maChoNgoi <= 0)
            {
                MyDialog dlg = new MyDialog("Mã chỗ ngồi phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (trangThai < 0)
            {
                MyDialog dlg = new MyDialog("Trạng thái không hợp lệ!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (soTien < 0)
            {
                MyDialog dlg = new MyDialog("Số tiền không hợp lệ!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            bool flag = phieuDatChoDAO.ThemPhieuDatCho(maPhieu, ngDatCho, maChoNgoi, createAt, tgian, trangThai, soTien);
            if (flag)
            {
                MyDialog dlg = new MyDialog("Thêm phiếu đặt chỗ thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Thêm phiếu đặt chỗ thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }
        // Cập nhật thông tin một phiếu đặt chỗ trong cơ sở dữ liệu
        public bool SuaPhieuDatCho(int maPhieu, int ngDatCho, int maChoNgoi, DateTime createAt, DateTime tgian, int trangThai, int soTien)
        {
            if (maPhieu <= 0)
            {
                MyDialog dlg = new MyDialog("Mã phiếu đặt chỗ phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (ngDatCho <= 0)
            {
                MyDialog dlg = new MyDialog("Mã người đặt chỗ phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (maChoNgoi <= 0)
            {
                MyDialog dlg = new MyDialog("Mã chỗ ngồi phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (trangThai < 0)
            {
                MyDialog dlg = new MyDialog("Trạng thái không hợp lệ!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (soTien < 0)
            {
                MyDialog dlg = new MyDialog("Số tiền không hợp lệ!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            bool flag = phieuDatChoDAO.SuaPhieuDatCho(maPhieu, ngDatCho, maChoNgoi, createAt, tgian, trangThai, soTien);
            if (flag)
            {
                MyDialog dlg = new MyDialog("Sửa phiếu đặt chỗ thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Sửa phiếu đặt chỗ thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }
        // Xóa một phiếu đặt chỗ khỏi cơ sở dữ liệu
        public bool XoaPhieuDatCho(int maPhieu)
        {
            if (maPhieu <= 0)
            {
                MyDialog dlg = new MyDialog("Mã phiếu đặt chỗ phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            bool flag = phieuDatChoDAO.XoaPhieuDatCho(maPhieu.ToString());
            if (flag)
            {
                MyDialog dlg = new MyDialog("Xóa phiếu đặt chỗ thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Xóa phiếu đặt chỗ thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }
        // Trả về danh sách chi tiết phiếu đặt chỗ
        public ArrayList GetChiTietPhieuDatCho(int idPhieuDatCho)
        {
            return phieuDatChoDAO.GetChiTietPhieuDatCho(idPhieuDatCho);
        }

        public bool CapNhatTrangThaiPhieuDatCho(int idPhieuDatCho, int trangThai)
        {
            return phieuDatChoDAO.CapNhatTrangThaiPhieuDatCho(idPhieuDatCho, trangThai);
        }
    }
} 