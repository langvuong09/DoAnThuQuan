using System;
using System.Collections;

using DoAnThuQuan.QuanLyThuQuan.DTO;

using MySql.Data.MySqlClient;

namespace DoAnThuQuan.QuanLyThuQuan.DAO
{
    internal class KhuVucDAO
    {
        // Khởi tạo kết nối cơ sở dữ liệu
        private MyConnect db = new MyConnect();

        // Trả về danh sách khu vực
        public ArrayList GetListKhuVuc()
        {
            ArrayList dskv = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM khu_vuc";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        KhuVuc kv = new KhuVuc
                        {
                            idKhuVuc = reader.GetInt32(0),
                            tenKhuVuc = reader.GetString(1),
                        };
                        dskv.Add(kv);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dskv;
        }

        // Thêm mới một khu vực vào cơ sở dữ liệu
        public bool ThemKhuVuc(int maKhuVuc, string tenKhuVuc)
        {
            try
            {
                string sql = "INSERT INTO khu_vuc(id_khuvuc, ten_khuvuc)" +
                    "VALUES (@maKhuVuc,@tenKhuVuc)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maKhuVuc", maKhuVuc);
                    cmd.Parameters.AddWithValue("@tenKhuVuc", tenKhuVuc);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        // Sửa thông tin một khu vực trong cơ sở dữ liệu
        public bool SuaKhuVuc(int maKhuVuc, string tenKhuVuc)
        {
            try
            {
                string sql = "UPDATE khu_vuc SET ten_khuvuc = @tenKhuVuc WHERE id_khuvuc = @maKhuVuc";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maKhuVuc", maKhuVuc);
                    cmd.Parameters.AddWithValue("@tenKhuVuc", tenKhuVuc);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        // Xóa một khu vực khỏi cơ sở dữ liệu
        public bool XoaKhuVuc(int maKhuVuc)
        {
            try
            {
                string sql = "DELETE FROM khu_vuc WHERE id_khuvuc = @maKhuVuc";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maKhuVuc", maKhuVuc);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}