using DoAnThuQuan.MyCustom;
using DoAnThuQuan.QuanLyThuQuan.BUS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.GUI
{
    internal class SignUpGUI : Form
    {
        private Button btnSignUp, btnLogin;
        private TextBox txtUserName, txtPassword, txtCheckPassword, txtFullName, txtEmail, txtSoDienThoai, txtDiaChi;
        private UserBUS userBUS = new UserBUS();

        public SignUpGUI()
        {
            AddControls();
            AddEvents();
        }

        private void AddControls()
        {
            //-----------------Thiết lập Form------------
            this.Text = "Quản lý thư quán";
            this.Size = new Size(500, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            //------------------Tiêu đề------------------
            Label titleLabel = new Label
            {
                Text = "ĐĂNG KÝ",
                ForeColor = Color.Black,
                Font = new Font("Arial", 28, FontStyle.Bold),
                AutoSize = true
            };

            Panel pnTitle = new Panel { Dock = DockStyle.Top, Height = 60 };
            titleLabel.Location = new Point(150, 15);
            pnTitle.Controls.Add(titleLabel);

            //--------------Panel thông tin đăng ký------------
            Panel pnThongTinDangKy = new Panel { Location = new Point(30, 60), Size = new Size(420, 500) };
            Font font = new Font("Tahoma", 12);

            Label lblUserName = new Label { Text = "Tài khoản:", Font = font, Location = new Point(0,15) };
            txtUserName = new TextBox { Font = font, Location = new Point(150, 10), Width = 270 };

            Label lblPassword = new Label { Text = "Mật khẩu:", Font = font, Location = new Point(0, 55) };
            txtPassword = new TextBox { Font = font, Location = new Point(150, 50), Width = 270, UseSystemPasswordChar = true };

            Label lblCheckPassword = new Label { Text = "Nhập lại mật khẩu:", Font = font, Location = new Point(0, 95), Width = 150 };
            txtCheckPassword = new TextBox { Font = font, Location = new Point(150, 90), Width = 270, UseSystemPasswordChar = true };

            Label lblFullName = new Label { Text = "Họ và tên:", Font = font, Location = new Point(0, 135) };
            txtFullName = new TextBox { Font = font, Location = new Point(150, 130), Width = 270 };

            Label lblEmail = new Label { Text = "Email:", Font = font, Location = new Point(0, 175) };
            txtEmail = new TextBox { Font = font, Location = new Point(150, 170), Width = 270 };

            Label lblSoDienThoai = new Label { Text = "Số điện thoại:", Font = font, Location = new Point(0, 215), Width = 150 };
            txtSoDienThoai = new TextBox { Font = font, Location = new Point(150, 210), Width = 270 };

            Label lblDiaChi = new Label { Text = "Địa chỉ:", Font = font, Location = new Point(0, 255) };
            txtDiaChi = new TextBox { Font = font, Location = new Point(150, 250), Width = 270 };

            Label lblCoTK = new Label { Text = "Đã có tài khoản?", Font = font, Location = new Point(40, 410), Size = new Size(150, 35) };

            //Button
            btnLogin = new Button { Text = "Đăng nhập ngay", Font = font, Location = new Point(200, 400), Size = new Size(200, 35) };
            btnSignUp = new Button { Text = "Đăng ký", Font = new Font("Tahoma", 15), Location = new Point(110, 310), Size = new Size(200, 45) };

            // Thêm vào panel
            pnThongTinDangKy.Controls.Add(lblUserName);
            pnThongTinDangKy.Controls.Add(txtUserName);
            pnThongTinDangKy.Controls.Add(lblPassword);
            pnThongTinDangKy.Controls.Add(txtPassword);
            pnThongTinDangKy.Controls.Add(lblCheckPassword);
            pnThongTinDangKy.Controls.Add(txtCheckPassword);
            pnThongTinDangKy.Controls.Add(lblFullName);
            pnThongTinDangKy.Controls.Add(txtFullName);
            pnThongTinDangKy.Controls.Add(lblEmail);
            pnThongTinDangKy.Controls.Add(txtEmail);
            pnThongTinDangKy.Controls.Add(lblSoDienThoai);
            pnThongTinDangKy.Controls.Add(txtSoDienThoai);
            pnThongTinDangKy.Controls.Add(lblDiaChi);
            pnThongTinDangKy.Controls.Add(txtDiaChi);
            pnThongTinDangKy.Controls.Add(lblCoTK);
            pnThongTinDangKy.Controls.Add(btnLogin);
            pnThongTinDangKy.Controls.Add(btnSignUp);

            //Thêm vào form
            this.Controls.Add(pnTitle);
            this.Controls.Add(pnThongTinDangKy);
        }

        private void AddEvents()
        {
            btnLogin.Click += (s, e) =>
            {
                XuLyDangNhap();
            };
            btnSignUp.Click += (s, e) =>
            {
                XuLyDangKy();
            };
        }

        private void XuLyDangNhap()
        {
            Login loginGUI = new Login();
            loginGUI.Show();
            this.Hide();
        }

        private bool XuLyDangKy()
        {
            bool flag = userBUS.ThemUser(txtUserName.Text, txtPassword.Text, txtCheckPassword.Text, txtFullName.Text, txtEmail.Text, txtSoDienThoai.Text, txtDiaChi.Text);
            return flag;
        }
    }
}
