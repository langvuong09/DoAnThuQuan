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
    public class ChoNgoiBUS
    {
        private static ChoNgoiBUS instance;
        public static ChoNgoiBUS Instance 
        {
            get
            {
                if (instance == null)
                    instance = new ChoNgoiBUS();
                return instance;
            }
            private set => instance = value;
        }

        private ChoNgoiBUS() { }

        private ChoNgoiDAO choNgoiDAO = new ChoNgoiDAO();
        private ArrayList listChoNgoi;

        public void DocListChoNgoi()
        {
            this.listChoNgoi = choNgoiDAO.GetListChoNgoi();
        }

        public ArrayList GetListChoNgoi()
        {
            if (this.listChoNgoi == null)
            {
                DocListChoNgoi();
            }
            return listChoNgoi;
        }

        public bool ThemChoNgoi(string idPhong, string status, string viTri, string soLuong)
        {
            try
            {
                if (idPhong.Trim() == "")
                {
                    MyDialog dlg = new MyDialog("Vui lòng nhập mã phòng!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (!int.TryParse(idPhong, out int maPhong))
                {
                    MyDialog dlg = new MyDialog("Mã phòng không hợp lệ!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                // Kiểm tra phòng có tồn tại không
                PhongBUS phongBUS = PhongBUS.Instance;
                phongBUS.DocListPhong(); // Cập nhật lại danh sách phòng trước khi kiểm tra
                if (!phongBUS.KiemTraPhongTonTai(idPhong))
                {
                    MyDialog dlg = new MyDialog("Phòng không tồn tại!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (!int.TryParse(status, out int trangThai) || (trangThai != 0 && trangThai != 1))
                {
                    MyDialog dlg = new MyDialog("Trạng thái không hợp lệ!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (viTri.Trim() == "")
                {
                    MyDialog dlg = new MyDialog("Vui lòng nhập vị trí!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (!int.TryParse(viTri, out int vt) || vt <= 0)
                {
                    MyDialog dlg = new MyDialog("Vị trí phải là số nguyên dương!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (soLuong.Trim() == "")
                {
                    MyDialog dlg = new MyDialog("Vui lòng nhập số lượng!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (!int.TryParse(soLuong, out int sl) || sl <= 0)
                {
                    MyDialog dlg = new MyDialog("Số lượng phải là số nguyên dương!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                // Kiểm tra vị trí đã tồn tại trong phòng chưa
                ArrayList listChoNgoi = GetListChoNgoi();
                if (listChoNgoi != null)
                {
                    foreach (ChoNgoi cn in listChoNgoi)
                    {
                        if (cn.idPhong == maPhong && cn.viTri == vt)
                        {
                            MyDialog dlg = new MyDialog("Vị trí này đã tồn tại trong phòng!", MyDialog.ERROR_DIALOG);
                            dlg.ShowDialog();
                            return false;
                        }
                    }
                }

                // Kiểm tra số lượng chỗ ngồi không vượt quá số lượng của phòng
                Phong phong = phongBUS.GetPhongById(idPhong);
                if (phong != null)
                {
                    int tongSoLuong = 0;
                    foreach(ChoNgoi cn in listChoNgoi)
                    {
                        if(cn.idPhong == phong.maPhong)
                        {
                            tongSoLuong += cn.soLuong;
                        }
                    }
                    if(tongSoLuong + sl > phong.soLgChoNgoi)
                    {
                        MyDialog dlg = new MyDialog("Tổng số lượng chỗ ngồi vượt quá số lượng cho phép của phòng!", MyDialog.ERROR_DIALOG);
                        dlg.ShowDialog();
                        return false;
                    }
                }

                // Tìm mã chỗ ngồi lớn nhất và tăng thêm 1
                int maxMaChoNgoi = 0;
                if (listChoNgoi != null)
                {
                    foreach(ChoNgoi cn in listChoNgoi)
                    {
                        if(cn.idChoNgoi > maxMaChoNgoi)
                        {
                            maxMaChoNgoi = cn.idChoNgoi;
                        }
                    }
                }
                int maChoNgoi = maxMaChoNgoi + 1;

                if (choNgoiDAO.ThemChoNgoi(maChoNgoi, maPhong, trangThai, vt, sl))
                {
                    DocListChoNgoi(); // Cập nhật lại danh sách chỗ ngồi
                    MyDialog dlg = new MyDialog("Thêm chỗ ngồi thành công!", MyDialog.SUCCESS_DIALOG);
                    dlg.ShowDialog();
                    return true;
                }
                else
                {
                    MyDialog dlg = new MyDialog("Thêm chỗ ngồi thất bại!", MyDialog.ERROR_DIALOG);
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

        public bool SuaChoNgoi(string idChoNgoi, string idPhong, string status, string viTri, string soLuong)
        {
            try
            {
                if (idChoNgoi.Trim() == "")
                {
                    MyDialog dlg = new MyDialog("Chưa chọn chỗ ngồi để sửa!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (!int.TryParse(idChoNgoi, out int maChoNgoi))
                {
                    MyDialog dlg = new MyDialog("Mã chỗ ngồi không hợp lệ!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (idPhong.Trim() == "")
                {
                    MyDialog dlg = new MyDialog("Vui lòng nhập mã phòng!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (!int.TryParse(idPhong, out int maPhong))
                {
                    MyDialog dlg = new MyDialog("Mã phòng không hợp lệ!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                // Kiểm tra phòng có tồn tại không
                PhongBUS phongBUS = PhongBUS.Instance;
                phongBUS.DocListPhong(); // Cập nhật lại danh sách phòng trước khi kiểm tra
                if (!phongBUS.KiemTraPhongTonTai(idPhong))
                {
                    MyDialog dlg = new MyDialog("Phòng không tồn tại!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (!int.TryParse(status, out int trangThai) || (trangThai != 0 && trangThai != 1))
                {
                    MyDialog dlg = new MyDialog("Trạng thái không hợp lệ!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (viTri.Trim() == "")
                {
                    MyDialog dlg = new MyDialog("Vui lòng nhập vị trí!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (!int.TryParse(viTri, out int vt) || vt <= 0)
                {
                    MyDialog dlg = new MyDialog("Vị trí phải là số nguyên dương!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (soLuong.Trim() == "")
                {
                    MyDialog dlg = new MyDialog("Vui lòng nhập số lượng!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                if (!int.TryParse(soLuong, out int sl) || sl <= 0)
                {
                    MyDialog dlg = new MyDialog("Số lượng phải là số nguyên dương!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }

                // Kiểm tra vị trí đã tồn tại trong phòng chưa (trừ chỗ ngồi hiện tại)
                ArrayList listChoNgoi = GetListChoNgoi();
                if (listChoNgoi != null)
                {
                    foreach (ChoNgoi cn in listChoNgoi)
                    {
                        if (cn.idChoNgoi != maChoNgoi && cn.idPhong == maPhong && cn.viTri == vt)
                        {
                            MyDialog dlg = new MyDialog("Vị trí này đã tồn tại trong phòng!", MyDialog.ERROR_DIALOG);
                            dlg.ShowDialog();
                            return false;
                        }
                    }
                }

                if (choNgoiDAO.SuaChoNgoi(maChoNgoi, maPhong, trangThai, vt, sl))
                {
                    DocListChoNgoi(); // Cập nhật lại danh sách chỗ ngồi
                    MyDialog dlg = new MyDialog("Sửa chỗ ngồi thành công!", MyDialog.SUCCESS_DIALOG);
                    dlg.ShowDialog();
                    return true;
                }
                else
                {
                    MyDialog dlg = new MyDialog("Sửa chỗ ngồi thất bại!", MyDialog.ERROR_DIALOG);
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

        public bool XoaChoNgoi(string idChoNgoi)
        {
            if (idChoNgoi.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn chỗ ngồi để xóa!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            int maChoNgoi = Convert.ToInt32(idChoNgoi);
            if (choNgoiDAO.XoaChoNgoi(maChoNgoi))
            {
                MyDialog dlg = new MyDialog("Xóa chỗ ngồi thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Xóa chỗ ngồi thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public List<ChoNgoi> LayDanhSachChoNgoi()
        {
            List<ChoNgoi> danhSach = new List<ChoNgoi>();
            ArrayList listChoNgoi = GetListChoNgoi();
            foreach (ChoNgoi cn in listChoNgoi)
            {
                ChoNgoi choNgoi = new ChoNgoi
                {
                    MaChoNgoi = cn.idChoNgoi.ToString(),
                    MaPhong = cn.idPhong.ToString(),
                    ViTri = cn.viTri.ToString(),
                    SoLuong = cn.soLuong,
                    TrangThai = cn.status == 1 ? "Hoạt động" : "Không hoạt động"
                };
                danhSach.Add(choNgoi);
            }
            return danhSach;
        }

        public bool ThemChoNgoi(ChoNgoi choNgoi)
        {
            return ThemChoNgoi(
                choNgoi.MaPhong,
                choNgoi.TrangThai == "Hoạt động" ? "1" : "0",
                choNgoi.ViTri,
                choNgoi.SoLuong.ToString()
            );
        }

        public bool SuaChoNgoi(ChoNgoi choNgoi)
        {
            return SuaChoNgoi(
                choNgoi.MaChoNgoi,
                choNgoi.MaPhong,
                choNgoi.TrangThai == "Hoạt động" ? "1" : "0",
                choNgoi.ViTri,
                choNgoi.SoLuong.ToString()
            );
        }
    }
} 