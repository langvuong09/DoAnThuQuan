using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using System;
using System.Collections;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class CTPhieuMuon_BUS
    {
        private static CTPhieuMuonDAO ctpmDAO = new CTPhieuMuonDAO();
        //Lấy phiếu mượn theo mã phiếu mượn
        public ArrayList GetListCTPMByIdPhieuMuon(int idPhieuMuon)
        {
            return ctpmDAO.GetListCTPMByIdPhieuMuon(idPhieuMuon);
        }

        // Lấy danh sách chi tiết phiếu mượn
        public ArrayList GetAllCTPM()
        {
            return ctpmDAO.GetListCTPM();
        }

        // Thêm chi tiết phiếu mượn
        public  bool ThemCTPM(int maPM, string maThietBi)
        {
            return ctpmDAO.ThemCTPM(maPM, maThietBi);
        }

        // Xóa chi tiết phiếu mượn
        public bool XoaCTPM(int maPM)
        {
            return ctpmDAO.XoaCTPM(maPM);
        }
    }
}
