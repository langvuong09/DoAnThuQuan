using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using iTextSharp.text;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class PhieuTraBUS
    {
        private PhieuTraDAO phieuTraDAO = new PhieuTraDAO();
        private UserDAO userDAO = new UserDAO();
      
        private ArrayList listPhieuTra;

        public PhieuTraBUS()
        {
            DocListPhieuTra();
        }

        public List<(PhieuTra, User)> GetListPhieuTraHomNayWithNhanVien()
        {

            List<(PhieuTra, User)> result = new List<(PhieuTra, User)>();

            // Gọi hàm lấy danh sách phiếu mượn hôm nay chưa có phiếu trả
            ArrayList dspm = phieuTraDAO.GetListPhieuTraHomNay();

            foreach (PhieuTra pm in dspm)
            {
                // Gọi hàm cũ lấy User theo nhân viên mượn
                User user = userDAO.GetUserById(pm.maNhanVien);
                result.Add((pm, user));
            }

            return result;
        }

        //Lọc theo khoảng thời gian
        public List<(PhieuTra, User)> FilterByTime(DateTime startDate, DateTime endDate)
        {
            List<(PhieuTra, User)> result = new List<(PhieuTra, User)>();
            ArrayList dspt = phieuTraDAO.GetPhieuTraByDateRange(startDate, endDate);

            foreach (PhieuTra pt in dspt)
            {

                User user = userDAO.GetUserById(pt.maNhanVien);
                result.Add((pt, user));
            }
            return result;
        }

        //Tạo mã phiếu trả mới
        public int createNewPhieuTra()
        {
            return phieuTraDAO.GetMaxIdPhieuTra() + 1;
        }

        //Lấy danh sách phiếu trả ngày hôm nay
        public List<(PhieuTra, User)> GetListPhieuTraWithNhanVien()
        {

            List<(PhieuTra, User)> result = new List<(PhieuTra, User)>();

       
            ArrayList dspt = phieuTraDAO.GetListPhieuTra();

            foreach (PhieuTra pt in dspt)
            {
              
                User user = userDAO.GetUserById(pt.maNhanVien);
                result.Add((pt, user));
            }

            return result;
        }

        //Lấy phiếu trả bằng mã phiếu trả
        public PhieuTra GetPhieuTraById(int idPhieuTra)
        {
            return phieuTraDAO.GetPhieuTraById(idPhieuTra);
        }

        public void DocListPhieuTra()
        {
            this.listPhieuTra = phieuTraDAO.GetListPhieuTra();
        }
        public ArrayList GetListPhieuTra()
        {
            if(this.listPhieuTra == null)
            {
                DocListPhieuTra();
            }
            return listPhieuTra;
        }

        public bool ThemPhieuTra(int maPT, DateTime tgianTra, int maPM, string mota, int maNhanVien)
        {

            if (phieuTraDAO.ThemPhieuTra(maPT, tgianTra, maPM, mota, maNhanVien))
            {
                MyDialog dlg = new MyDialog("Thêm phiếu trả thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Thêm trả thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public bool SuaPhieuTra(string maPhieuTra, string tgianTra, string idPhieuMuon, string moTa, string nVien)
        {
            if(maPhieuTra.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn phiếu trả!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if (tgianTra.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống thời gian trả!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if (idPhieuMuon.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn phiếu mượn!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if (moTa.Trim() == "")
            {
                moTa = "Không";
            }
            if (nVien.Trim() == "")
            {
                nVien = "1";
            }
            DateTime tgTra = Convert.ToDateTime(tgianTra);
            int maPM = Convert.ToInt32(idPhieuMuon);
            int maNV = Convert.ToInt32(nVien);
            int maPT = Convert.ToInt32(maPhieuTra);
            if (phieuTraDAO.SuaPhieuTra(maPT, tgTra, maPM, moTa, maNV))
            {
                MyDialog dlg = new MyDialog("Sửa phiếu trả thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Sửa phiếu trả thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public bool XoaPhieuTra(string idPhieuTra)
        {
            if(idPhieuTra.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn phiếu trả để xóa!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            int maPT = Convert.ToInt32(idPhieuTra);
            if(phieuTraDAO.XoaPhieuTra(maPT))
            {
                MyDialog dlg = new MyDialog("Xóa phiếu trả thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Xóa phiếu trả thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }
    }
}
