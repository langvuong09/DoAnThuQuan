using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.DTO;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class SachDetailBUS
    {
        private SachBUS sachBUS = new SachBUS();
        private SachDetailDAO sachDetailDAO = new SachDetailDAO();
        private ArrayList listSachDetail;

        public SachDetailBUS()
        {
            DocListSachDetail();
        }

        public void DocListSachDetail()
        {
            this.listSachDetail = sachDetailDAO.GetListSachDetail();
        }

        public Tuple<string, int> GetSachDetailAndThanhTienByIdSeriSach(string idSeriSach)
        {
            return sachDetailDAO.GetSachDetailAndThanhTienByIdSeriSach(idSeriSach);
        }
        public bool CapNhatTrangThaiSachDetail(string maSachDetail, int trangThai)
        {
            return sachDetailDAO.CapNhatTrangThaiSachDetail(maSachDetail, trangThai);
        }

        public List<Tuple<SachDetail, string>> GetListSachDetailWithTenSach()
        {
            return sachDetailDAO.GetListSachDetailWithTenSach();
        }

        public ArrayList GetListSachDetail()
        {
            if(this.listSachDetail == null)
            {
                DocListSachDetail();
            }
            return listSachDetail;
        }

        public int GetCountSachDetail(int maSach)
        {
            return sachDetailDAO.GetCountSachDetail(maSach);
        }

        public bool ThemSachDetail(string idSach)
        {
            if(idSach.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn sách để thêm!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            int count = GetListSachDetail().Count + 1;
            string maSachDetail = "MD" + count.ToString("D3");
            int maSach = Convert.ToInt32(idSach);
            if (sachDetailDAO.ThemSachDetail(maSachDetail, maSach,1))
            {
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Thêm sách detail thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public bool SuaSachDetail(string maSachDetail, string idSach, string trangThai)
        {
            if (maSachDetail.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn sách detail để sửa!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if (idSach.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn sách để thêm!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            int maSach = Convert.ToInt32(idSach);
            int status = Convert.ToInt32(trangThai);
            if (sachDetailDAO.SuaSachDetail(maSachDetail, maSach, status))
            {
                MyDialog dlg = new MyDialog("Sửa sách detail thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Sửa sách detail thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public bool XoaSachDetail(string maSachDetail)
        {
            if (maSachDetail.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn sách detail để xóa!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            int maSach = Convert.ToInt32(maSachDetail);
            if (sachDetailDAO.XoaSachDetail(maSach))
            {
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Xóa sách detail thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public ArrayList TimKiemTheoTenSach(string tenSach)
        {
            DocListSachDetail();
            ArrayList dssd = new ArrayList();
            foreach (SachDetail sd in listSachDetail)
            {
                if(sachBUS.GetSach(tenSach).maSach == sd.maSach)
                {
                    dssd.Add(sd);
                }
            }
            return dssd;
        }
    }
}
