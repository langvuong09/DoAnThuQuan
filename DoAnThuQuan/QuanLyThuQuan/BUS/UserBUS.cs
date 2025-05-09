using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.DTO;

using System;
using System.Collections;
using System.Text.RegularExpressions;


namespace DoAnThuQuan.QuanLyThuQuan.BUS
{
    internal class UserBUS
    {
        private UserDAO userDAO = new UserDAO();
        private ArrayList listUser;
        private ArrayList listNguoiDung;
        private ArrayList listNVien;

        public UserBUS()
        {
            DocListUser();
        }
        public void DocListUser()
        {
            this.listUser = userDAO.GetListTaiKhoan();
        }

        public ArrayList GetListTaiKhoanByQuyen(int quyen)
        {
            return userDAO.GetListTaiKhoanByQuyen(quyen);
        }

        public void DocListNguoiDung()
        {
            this.listNguoiDung = userDAO.GetListUser();
        }

        public User getUserById(int user_id)
        {
            return userDAO.GetUserById(user_id);
        }

        public void DocListNVien()
        {
            this.listNVien = userDAO.GetListStaff();
        }


        public ArrayList GetListUser()
        {
            if(this.listUser == null)
            {
                DocListUser();
            }
            return listUser;
        }

        public ArrayList GetListNguoiDung()
        {
            if (this.listNguoiDung == null)
            {
                DocListNguoiDung();
            }
            return listNguoiDung;
        }
        public ArrayList GetListNVien()
        {
            if (this.listNVien == null)
            {
                DocListNVien();
            }
            return listNVien;
        }

        public User GetUser(string username, string password)
        {
            return userDAO.GetUser(username, password);
        }

        public bool ThemUser(string username, string password, string checkPassword, string fullName, string email, string soDienThoai, string diaChi)
        {
            if (username.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống tên đăng nhập!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            else
            {
                if(!CheckUsername(username))
                {
                    MyDialog dlg = new MyDialog("Sai định dạng tên đăng nhập!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }
            }

            if (password.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống mật khẩu!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            else
            {
                if (!CheckPassword(password))
                {
                    MyDialog dlg = new MyDialog("Sai định dạng mật khẩu!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }
            }

            if (fullName.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống họ và tên!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (email.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống email!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            else
            {
                if (!CheckEmail(email))
                {
                    MyDialog dlg = new MyDialog("Sai định dạng email!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }
            }

            if (soDienThoai.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống số điện thoại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            else
            {
                if (!CheckPhone(soDienThoai))
                {
                    MyDialog dlg = new MyDialog("Sai định dạng số điện thoại!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }
            }

            if(diaChi.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống địa chỉ!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (password != checkPassword)
            {
                MyDialog dlg = new MyDialog("Mật khẩu nhập lại không khớp!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            bool flag = userDAO.ThemUser(userDAO.MaxMaUser() + 1, username, password,fullName,email,soDienThoai,diaChi);
            if (flag)
            {
                MyDialog dlg = new MyDialog("Tạo tài khoản thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Tạo tài khoản thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public bool SuaUser(string maUser, string fullName, string email, string soDienThoai, string diaChi,string quyen)
        {
            if(maUser.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn đối tượng để sửa!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (fullName.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống họ và tên!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            if (email.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống email!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            else
            {
                if (!CheckEmail(email))
                {
                    MyDialog dlg = new MyDialog("Sai định dạng email!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }
            }

            if (soDienThoai.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống số điện thoại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            else
            {
                if (!CheckPhone(soDienThoai))
                {
                    MyDialog dlg = new MyDialog("Sai định dạng số điện thoại!", MyDialog.ERROR_DIALOG);
                    dlg.ShowDialog();
                    return false;
                }
            }

            if (diaChi.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Không được để trống địa chỉ!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }

            int ma = Convert.ToInt32(maUser);
            int q = Convert.ToInt32(quyen);
            bool flag = userDAO.SuaUser(ma, fullName, email, soDienThoai, diaChi, q);
            if (flag)
            {
                MyDialog dlg = new MyDialog("Sửa thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Sửa thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public bool XoaUser(string maUser)
        {
            if(maUser.Trim() == "")
            {
                MyDialog dlg = new MyDialog("Chưa chọn đối tượng để xóa!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
            int ma = Convert.ToInt32(maUser);
            if (userDAO.XoaUser(ma))
            {
                MyDialog dlg = new MyDialog("Xóa thành công!", MyDialog.SUCCESS_DIALOG);
                dlg.ShowDialog();
                return true;
            }
            else
            {
                MyDialog dlg = new MyDialog("Xóa thất bại!", MyDialog.ERROR_DIALOG);
                dlg.ShowDialog();
                return false;
            }
        }

        public ArrayList GetNVien(string tenUser)
        {
            DocListNVien();
            ArrayList dsu = new ArrayList();
            foreach(User u in listNVien)
            {
                if (u.fullName.Contains(tenUser.Trim())){
                    dsu.Add(u);
                }
            }
            return dsu;
        }

        public ArrayList GetNguoiDung(string tenUser)
        {
            DocListNguoiDung();
            ArrayList dsu = new ArrayList();
            foreach (User u in listNguoiDung)
            {
                if (u.fullName.Contains(tenUser.Trim()))
                {
                    dsu.Add(u);
                }
            }
            return dsu;
        }

        public string GetTenNhanVien(int maNV)
        {
            DocListNVien();
            foreach(User u in listNVien)
            {
                if(u.userId == maNV)
                {
                    return u.fullName;
                }
            }
            return "";
        }

        private bool CheckUsername(string username)
        {
            string pattern = @"^\S{6,}$";
            return Regex.IsMatch(username, pattern);
        }

        private bool CheckPassword(string password)
        {
            string pattern = @"^\S{6,}$";
            return Regex.IsMatch(password, pattern);
        }

        private bool CheckEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private bool CheckPhone(string phone)
        {
            string pattern = @"^(0\d{9,10})$";
            return Regex.IsMatch(phone, pattern);
        }
    }
}
