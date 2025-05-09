using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    public class User
    {
        public int userId {  get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public string soDienThoai { get; set; }
        public string diaChi { get; set; }
        public int quyen {  get; set; }
        public int trangThai {  get; set; }

        public User() { }
        public User(int userId, string userName, string password, string fullName, string email, string soDienThoai, string diaChi, int quyen, int trangThai)
        {
            this.userId = userId;
            this.userName = userName;
            this.password = password;
            this.fullName = fullName;
            this.email = email;
            this.soDienThoai = soDienThoai;
            this.diaChi = diaChi;
            this.quyen = quyen;
            this.trangThai = trangThai;
        }
    }
}
