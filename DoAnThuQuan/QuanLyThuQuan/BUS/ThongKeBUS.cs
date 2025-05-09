using DoAnThuQuan.QuanLyThuQuan.DAO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class ThongKeBUS
    {
        private ThongKeDAO dao = new ThongKeDAO();
        public int TongSach()
        {
            return dao.TongSach();
        }

        public int TongMayTinh()
        {
            return dao.TongMayTinh();
        }

        public int TongMayChieu()
        {
            return dao.TongMayChieu();
        }

        public int TongThanhVien()
        {
            return dao.TongThanhVien();
        }

        public int TongPhieuMuon()
        {
            return dao.TongPhieuMuon();
        }

        public int TongPhieuTra()
        {
            return dao.TongPhieuTra();
        }

        public int TongPhieuPhat()
        {
            return dao.TongPhieuPhat();
        }

        public int TongPhieuDatCho()
        {
            return dao.TongPhieuDatCho();
        }
    }
}
