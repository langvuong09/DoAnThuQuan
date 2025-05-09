using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using System.Collections;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class PhieuMuonBUS
    {
        private PhieuMuonDAO phieuMuonDAO = new PhieuMuonDAO();
        private UserDAO userDAO = new UserDAO();
        private ArrayList listPhieuMuon = new ArrayList();

        // Khởi tạo và đọc danh sách phiếu mượn ngay khi khởi tạo
        public PhieuMuonBUS()
        {
            DocListPhieuMuon();
        }
       

        //Tạo mã phiếu mượn
        public int createeNewPhieuMuon()
        {
            return phieuMuonDAO.GetMaxIdPhieuMuon() + 1;
        }

        //Lấy danh sách phiếu mượn ngày hôm nay
        public List<(PhieuMuon, User)> GetListPhieuMuonHomNayWithNhanVien()
        {

            List<(PhieuMuon, User)> result = new List<(PhieuMuon, User)>();

            // Gọi hàm lấy danh sách phiếu mượn hôm nay chưa có phiếu trả
            ArrayList dspm = phieuMuonDAO.GetListPhieuMuonHomNay();

            foreach (PhieuMuon pm in dspm)
            {
                // Gọi hàm cũ lấy User theo nhân viên mượn
                User user = userDAO.GetUserById(pm.idNhanVien);
                result.Add((pm, user));
            }

            return result;
        }




        // Đọc danh sách phiếu mượn từ cơ sở dữ liệu
        public void DocListPhieuMuon()
        {
            this.listPhieuMuon = phieuMuonDAO.GetListPhieuMuon();
        }

        // Trả về danh sách phiếu mượn
        public ArrayList GetListPhieuMuon()
        {
            try
            {
                return phieuMuonDAO.GetListPhieuMuon();
            }
            catch (Exception ex)
            {
                MyDialog dlg = new MyDialog("Lỗi khi đọc danh sách phiếu mượn: " + ex.Message, MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return new ArrayList();
            }
        }

        // Thêm mới một phiếu mượn vào cơ sở dữ liệu
        public bool ThemPhieuMuon(int maPhieuMuon, DateTime tgianMuon, int soLuong, int ngMuon, int maNhanVien)
        {
            try
            {
                if (maPhieuMuon <= 0)
                {
                    MyDialog dlg = new MyDialog("Mã phiếu mượn phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (soLuong <= 0)
                {
                    MyDialog dlg = new MyDialog("Số lượng phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (ngMuon <= 0)
                {
                    MyDialog dlg = new MyDialog("Mã người mượn phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (maNhanVien <= 0)
                {
                    MyDialog dlg = new MyDialog("Mã nhân viên phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                bool flag = phieuMuonDAO.ThemPhieuMuon(maPhieuMuon, tgianMuon, soLuong, ngMuon, maNhanVien);
                if (flag)
                {
                    MyDialog dlg = new MyDialog("Thêm phiếu mượn thành công!", MyDialog.SUCCESS_DIALOG);
                    dlg.ShowDialog();
                    return true;
                }
                else
                {
                    MyDialog dlg = new MyDialog("Thêm phiếu mượn thất bại!", MyDialog.ERROR_DIALOG);
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

        // Cập nhật thông tin một phiếu mượn trong cơ sở dữ liệu
        public bool SuaPhieuMuon(int maPhieuMuon, DateTime tgianMuon, int soLuong, int ngMuon, int maNhanVien)
        {
            if (maPhieuMuon <= 0)
            {
                MyDialog dlg = new MyDialog("Mã phiếu mượn phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (soLuong <= 0)
            {
                MyDialog dlg = new MyDialog("Số lượng phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (ngMuon <= 0)
            {
                MyDialog dlg = new MyDialog("Mã người mượn phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (maNhanVien <= 0)
            {
                MyDialog dlg = new MyDialog("Mã nhân viên phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            bool flag = phieuMuonDAO.SuaPhieuMuon(maPhieuMuon, tgianMuon, soLuong, ngMuon, maNhanVien);
            if (flag)
            {
                MyDialog dlg = new MyDialog("Sửa phiếu mượn thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Sửa phiếu mượn thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        // Xóa một phiếu mượn khỏi cơ sở dữ liệu
        public bool XoaPhieuMuon(int maPhieuMuon)
        {
            if (maPhieuMuon <= 0)
            {
                MyDialog dlg = new MyDialog("Mã phiếu mượn phải lớn hơn 0!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            bool flag = phieuMuonDAO.XoaPhieuMuon(maPhieuMuon.ToString());
            if (flag)
            {
                MyDialog dlg = new MyDialog("Xóa phiếu mượn thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Xóa phiếu mượn thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }
        // Xuất danh sách phiếu mượn ra file Excel
        public void ExportToExcel(string filePath)
        {
            try
            {
                phieuMuonDAO.ExportToExcel(filePath);
                MyDialog dlg = new MyDialog("Xuất Excel thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
            }
            catch (Exception ex)
            {
                MyDialog dlg = new MyDialog("Lỗi khi xuất Excel: " + ex.Message, MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
            }
        }

        // Xuất danh sách phiếu mượn ra file PDF
        public void ExportToPDF(string filePath)
        {
            try
            {
                phieuMuonDAO.ExportToPDF(filePath);
                MyDialog dlg = new MyDialog("Xuất PDF thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
            }
            catch (Exception ex)
            {
                MyDialog dlg = new MyDialog("Lỗi khi xuất PDF: " + ex.Message, MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
            }
        }

        // Trả về danh sách chi tiết phiếu mượn
        public ArrayList GetChiTietPhieuMuon(int maPhieuMuon)
        {
            try
            {
                return phieuMuonDAO.GetChiTietPhieuMuon(maPhieuMuon);
            }
            catch (Exception ex)
            {
                MyDialog dlg = new MyDialog("Lỗi khi đọc chi tiết phiếu mượn: " + ex.Message, MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return new ArrayList();
            }
        }

        // Trả về danh sách tất cả chi tiết phiếu mượn
        public ArrayList GetAllChiTietPhieuMuon()
        {
            try
            {
                return phieuMuonDAO.GetAllChiTietPhieuMuon();
            }
            catch (Exception ex)
            {
                MyDialog dlg = new MyDialog("Lỗi khi đọc danh sách chi tiết phiếu mượn: " + ex.Message, MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return new ArrayList();
            }
        }
        // Trả về danh sách phân sách
        public ArrayList GetListPhanSach()
        {
            return phieuMuonDAO.GetListPhanSach();
        }
    }
} 