using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.DTO;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    public class PhongBUS
    {
        private static PhongBUS instance;
        public static PhongBUS Instance 
        {
            get
            {
                if (instance == null)
                    instance = new PhongBUS();
                return instance;
            }
            private set => instance = value;
        }

        private PhongBUS() { }

        private PhongDAO phongDAO = new PhongDAO();
        private ArrayList listPhong;

        public void DocListPhong()
        {
            this.listPhong = phongDAO.GetLisPhong();
        }
        public ArrayList GetListPhong()
        {
            if(this.listPhong == null)
            {
                DocListPhong();
            }
            return listPhong;
        }

        public bool ThemPhong(string soLuong)
        {
            try 
            {
                if(soLuong.Trim() == "")
                {
                    MyDialog dlg = new MyDialog("Vui lòng nhập số lượng chỗ ngồi!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (!int.TryParse(soLuong, out int sl) || sl <= 0)
                {
                    MyDialog dlg = new MyDialog("Số lượng chỗ ngồi phải là số nguyên dương!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                // Tìm mã phòng lớn nhất và tăng thêm 1
                int maxMaPhong = 0;
                ArrayList listPhong = GetListPhong();
                if (listPhong != null)
                {
                    foreach(Phong p in listPhong)
                    {
                        if(p.maPhong > maxMaPhong)
                        {
                            maxMaPhong = p.maPhong;
                        }
                    }
                }
                int maPhong = maxMaPhong + 1;

                if (phongDAO.ThemPhong(maPhong, sl, 1))
                {
                    DocListPhong(); // Cập nhật lại danh sách phòng
                    MyDialog dlg = new MyDialog("Thêm phòng thành công!", MyDialog.SUCCESS_DIALOG);
                    dlg.ShowDialog();
                    return true;
                }
                else
                {
                    MyDialog dlg = new MyDialog("Thêm phòng thất bại!", MyDialog.ERROR_DIALOG);
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

        public bool SuaPhong(string idPhong, string soLuong, string trangThai)
        {
            try
            {
                if (idPhong.Trim() == "")
                {
                    MyDialog dlg = new MyDialog("Chưa chọn phòng để sửa!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (!int.TryParse(idPhong, out int maPhong))
                {
                    MyDialog dlg = new MyDialog("Mã phòng không hợp lệ!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (!KiemTraPhongTonTai(idPhong))
                {
                    MyDialog dlg = new MyDialog("Phòng không tồn tại!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (soLuong.Trim() == "")
                {
                    MyDialog dlg = new MyDialog("Vui lòng nhập số lượng chỗ ngồi!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (!int.TryParse(soLuong, out int sl) || sl <= 0)
                {
                    MyDialog dlg = new MyDialog("Số lượng chỗ ngồi phải là số nguyên dương!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (!int.TryParse(trangThai, out int status) || (status != 0 && status != 1))
                {
                    MyDialog dlg = new MyDialog("Trạng thái không hợp lệ!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (phongDAO.SuaPhong(maPhong, sl, status))
                {
                    DocListPhong(); // Cập nhật lại danh sách phòng
                    MyDialog dlg = new MyDialog("Sửa phòng thành công!", MyDialog.SUCCESS_DIALOG);
                    dlg.ShowDialog();
                    return true;
                }
                else
                {
                    MyDialog dlg = new MyDialog("Sửa phòng thất bại!", MyDialog.ERROR_DIALOG);
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

        public bool XoaPhong(string idPhong)
        {
            if(idPhong.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn phòng để xóa!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            int maPhong = Convert.ToInt32(idPhong);
            if (phongDAO.XoaPhong(maPhong))
            {
                MyDialog dlg = new MyDialog("Xóa phòng thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Xóa phòng thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public bool KiemTraPhongTonTai(string maPhong)
        {
            try
            {
                if (!int.TryParse(maPhong, out int maPhongInt))
                {
                    return false;
                }

                ArrayList listPhong = GetListPhong();
                foreach (Phong p in listPhong)
                {
                    if (p.maPhong == maPhongInt)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi kiểm tra phòng: " + ex.Message);
                return false;
            }
        }

        public Phong GetPhongById(string idPhong)
        {
            try
            {
                if (!int.TryParse(idPhong, out int maPhong))
                {
                    return null;
                }

                ArrayList listPhong = GetListPhong();
                foreach (Phong p in listPhong)
                {
                    if (p.maPhong == maPhong)
                    {
                        return p;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy thông tin phòng: " + ex.Message);
                return null;
            }
        }

        public List<Phong> LayDanhSachPhong()
        {
            List<Phong> danhSach = new List<Phong>();
            ArrayList listPhong = GetListPhong();
            foreach (Phong p in listPhong)
            {
                Phong phong = new Phong
                {
                    MaPhong = p.maPhong.ToString(),
                    SoChoNgoi = p.soLgChoNgoi,
                    TinhTrang = p.trangThai == 1 ? "Hoạt động" : "Không hoạt động"
                };
                danhSach.Add(phong);
            }
            return danhSach;
        }

        public bool ThemPhong(Phong phong)
        {
            return ThemPhong(phong.SoChoNgoi.ToString());
        }

        public bool SuaPhong(Phong phong)
        {
            return SuaPhong(
                phong.MaPhong,
                phong.SoChoNgoi.ToString(),
                phong.TinhTrang == "Hoạt động" ? "1" : "0"
            );
        }
    }
}
