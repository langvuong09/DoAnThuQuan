using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using System.Collections;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class CTPhatHuDoBUS
    {
        private CTPhatHuDoDAO ctPhatHuDoDAO = new CTPhatHuDoDAO();
        private ArrayList listCTPhat;

        public CTPhatHuDoBUS()
        {
            DocListCTPhat();
        }
        public ArrayList GetCTPhatByMaPhieuPhatHuDo(int maPP)
        {
            return ctPhatHuDoDAO.GetCTPhatByMaPhieuPhatHuDo(maPP);
        }

        public void DocListCTPhat()
        {
            this.listCTPhat = ctPhatHuDoDAO.GetListCTPhat();
        }

        public ArrayList GetListCTPhat()
        {
            if (this.listCTPhat == null)
            {
                DocListCTPhat();
            }
            return listCTPhat;
        }
        public bool ThemCTPhat(int maPP, String maThietBi, string mota, int tien)
        {
            return ctPhatHuDoDAO.ThemCTPhat( maPP, maThietBi,  mota, tien);
        }
    }
} 