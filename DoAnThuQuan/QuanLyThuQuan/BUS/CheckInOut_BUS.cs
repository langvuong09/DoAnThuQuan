using DoAnThuQuan.QuanLyThuQuan.DAO;
using Thuvien.DTO;
using System;
using System.Collections;

namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class CheckInOut_BUS
    {
        private static CheckInOutDAO checkInOutDAO = new CheckInOutDAO();
        public ArrayList GetCheckInOutByDate(DateTime date)
        {
            return checkInOutDAO.GetCheckInOutByDate(date);
        }

        // Lấy toàn bộ danh sách CheckInOut
        public  ArrayList GetAllCheckInOut()
        {
            return checkInOutDAO.GetListCheckInOut();
        }

        // Thêm một bản ghi CheckInOut
        public  bool ThemCheckInOut(int userId, DateTime timeIn, DateTime timeOut)
        {
            return checkInOutDAO.ThemCheckInOut(userId, timeIn, timeOut);
        }

        // Sửa một bản ghi CheckInOut
        public  bool SuaCheckInOut(int userId, DateTime timeIn, DateTime timeOut)
        {
            return checkInOutDAO.SuaCheckInOut(userId, timeIn, timeOut);
        }

        // Xóa một bản ghi CheckInOut
        public  bool XoaCheckInOut(int userId)
        {
            return checkInOutDAO.XoaCheckInOut(userId);
        }
    }
}
