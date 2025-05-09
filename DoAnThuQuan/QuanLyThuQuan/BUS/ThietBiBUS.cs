using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.DAO;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class ThietBiBUS
    {
        private ThietBiDAO thietBiDAO = new ThietBiDAO();
        private ArrayList listThietBi;

        public ThietBiBUS()
        {
            DocListThietBi();
        }

        public void DocListThietBi()
        {
            this.listThietBi = thietBiDAO.GetListThietBi();
        }
        public ArrayList GetListThietBi()
        {
            if(this.listThietBi == null)
            {
                DocListThietBi();
            }
            return listThietBi;
        }

        public bool ThemThietBi(string tenThietBi, string soLuong)
        {
            if(tenThietBi.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống tên thiết bị!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if (soLuong.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống số lượng!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            int sl = Convert.ToInt32(soLuong);
            if (thietBiDAO.ThemThietBi(tenThietBi, sl, 1))
            {
                MyDialog dlg = new MyDialog("Thêm thiết bị thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Thêm thiết bị thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public bool SuaThietBi(string maThietBi, string tenThietBi, string soLuong, string trangThai)
        {
            if (maThietBi.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn thiết bị để sửa!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if (tenThietBi.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống tên thiết bị!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if (soLuong.Trim().Equals(""))
            {
                MyDialog dlg = new MyDialog("Không được để trống số lượng!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            if (trangThai.Trim().Equals(""))
            {
                MyDialog dlg = new MyDialog("Không được để trống trạng thái!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            int sl = Convert.ToInt32(soLuong);
            int maTB = Convert.ToInt32(maThietBi);
            int status = Convert.ToInt32(trangThai);
            if (thietBiDAO.SuaThietBi(maTB,tenThietBi,sl,status))
            {
                MyDialog dlg = new MyDialog("Sửa thiết bị thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Sửa thiết bị thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public bool XoaThietBi(string maThietBi)
        {
            if(maThietBi.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn thiết bị để xóa!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            int maTB = Convert.ToInt32(maThietBi);
            if (thietBiDAO.XoaThietBi(maTB))
            {
                MyDialog dlg = new MyDialog("Xóa thiết bị thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Xóa thiết bị thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }
    }
}
