using System;

using MySql.Data.MySqlClient;

namespace DoAnThuQuan.QuanLyThuQuan.DAO
{
    internal class MyConnect
    {
        private string server = "localhost";
        private string database = "quanlythuquan";
        private string username = "root";
        private string password = "";

        public MySqlConnection GetConnection()
        {
            string connString = $"Server={server};Database={database};User ID={username};Password={password};";
            return new MySqlConnection(connString);
        }
    }
}
