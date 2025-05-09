using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.DTO;



namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class CTPhieuTra_BUS
    {
        private static CTPhieuTraDAO ctptDAO = new CTPhieuTraDAO();
        public List<CTPhieuTra> GetListCTPMByIdPhieuTra(int idPhieuTra)
        {
            return ctptDAO.GetListCTPMByIdPhieuTra(idPhieuTra);
        }
        // Lấy danh sách chi tiết phiếu trả
        public ArrayList GetAllCTPT()
        {
            return ctptDAO.GetListCTPT();
        }

        // Thêm chi tiết phiếu trả
        public  bool ThemCTPT(int maPT, string maThietBi)
        {
            return ctptDAO.ThemCTPT(maPT, maThietBi);
        }

        // Xóa chi tiết phiếu trả
        public  bool XoaCTPT(int maPT)
        {
            return ctptDAO.XoaCTPT(maPT);
        }
    }
}
