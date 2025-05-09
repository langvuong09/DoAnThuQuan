using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.BUS;
using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.DTO;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    public partial class Login : Form
    {
        private UserBUS userBUS = new UserBUS();
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void XuLyDangNhap()
        {
            string taikhoan = txt_User.Text.Trim();
            string password = txt_Pass.Text.Trim();
            DoAnThuQuan.QuanLyThuQuan.DTO.User user = userBUS.GetUser(taikhoan, password);

            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(taikhoan) || string.IsNullOrEmpty(password))
            {
                new MyDialog("Vui lòng nhập đầy đủ các thông tin cần thiết!", MyDialog.ERROR_DIALOG).ShowDialog();
                return;
            }

            if (user == null)
            {
                new MyDialog("Đăng nhập không thành công!", MyDialog.ERROR_DIALOG).ShowDialog();
                return;
            }
            else
            {
                UserSession.UserId = user.userId;
                new MyDialog("Đăng nhập thành công!", MyDialog.SUCCESS_DIALOG).ShowDialog();
                TrangChuGUI trangChuGUI = new TrangChuGUI();
                trangChuGUI.Show();
                this.Hide();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            XuLyDangNhap();
        }
    }
}
