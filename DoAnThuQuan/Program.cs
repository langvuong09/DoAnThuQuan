using System;

using DoAnThuQuan.QuanLyThuQuan.DAO;
using DoAnThuQuan.QuanLyThuQuan.GUI;


class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        // Khởi tạo kết nối CSDL nếu cần
        MyConnect myConnect = new MyConnect();

        // Bật giao diện hệ thống (tương đương với Java Look and Feel)
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Hiển thị form đăng nhập
        Login login = new Login();
        Application.Run(login);
    }
}
