using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using System;
using System.Collections;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class ChoNgoi_BUS
    {
        private static ChoNgoiDAO choNgoiDAO = new ChoNgoiDAO();

        // Lấy danh sách tất cả chỗ ngồi
        public static ArrayList GetAllChoNgoi()
        {
            return choNgoiDAO.GetListChoNgoi();
        }

        // Thêm chỗ ngồi
        public static bool ThemChoNgoi(int maChoNgoi, int maPhong, int trangThai, int viTri, int soLuong)
        {
            return choNgoiDAO.ThemChoNgoi(maChoNgoi, maPhong, trangThai, viTri, soLuong);
        }

        // Xóa chỗ ngồi
        public static bool XoaChoNgoi(int maChoNgoi)
        {
            return choNgoiDAO.XoaChoNgoi(maChoNgoi);
        }

        // Sửa thông tin chỗ ngồi
        public static bool SuaChoNgoi(int maChoNgoi, int maPhong, int trangThai, int viTri, int soLuong)
        {
            return choNgoiDAO.SuaChoNgoi(maChoNgoi, maPhong, trangThai, viTri, soLuong);
        }
    }
}
