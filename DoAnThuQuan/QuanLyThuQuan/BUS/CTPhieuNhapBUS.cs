using DoAnThuQuan.QuanLyThuQuan.DAO;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class CTPhieuNhapBUS
    {
        private CTPhieuNhapDAO ctpnDAO = new CTPhieuNhapDAO();
        private ArrayList listCTPhieuNhap;

        public CTPhieuNhapBUS()
        {
            DocListCTPhieuNhap();
        }

        public void DocListCTPhieuNhap()
        {
            this.listCTPhieuNhap = ctpnDAO.GetListCTPN();
        }
        public ArrayList GetListCTPhieuNhap()
        {
            if(listCTPhieuNhap == null)
            {
                DocListCTPhieuNhap();
            }
            return listCTPhieuNhap;
        }

        public bool themCTPhieuNhap(string maPhieuNhap, string maSP, string loaiSP, string thanhTien)
        {
            int maPN = Convert.ToInt32(maPhieuNhap);
            int tien = Convert.ToInt32(thanhTien);
            if (ctpnDAO.ThemCTPN(maPN, maSP, loaiSP, tien))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool XoaCTPhieuNhap(string maPhieuNhap)
        {
            int maPN = Convert.ToInt32(maPhieuNhap);
            if(ctpnDAO.XoaCTPN(maPN))
            {
                return true;
            }else { return false; }
        }
    }
}
