using System;
using System.Collections;

using DoAnThuQuan.QuanLyThuQuan.DTO;

using MySql.Data.MySqlClient;

namespace DoAnThuQuan.QuanLyThuQuan.DAO
{
    internal class UserDAO
    {
        private MyConnect db = new MyConnect();
        public ArrayList GetListTaiKhoan()
        {
            ArrayList dstk = new ArrayList();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM user";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        User user = new User
                        {
                            userId = reader.GetInt32(0),
                            userName = reader.GetString(1),
                            password = reader.GetString(2),
                            fullName = reader.GetString(3),
                            email = reader.GetString(4),
                            soDienThoai = reader.GetString(5),
                            diaChi = reader.GetString(6),
                            quyen = reader.GetInt32(7),
                            trangThai = reader.GetInt32(8)
                        };
                        dstk.Add(user);
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }

            return dstk;
        }

        public ArrayList GetListUser()
        {
            ArrayList dstk = new ArrayList();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM user WHERE quyen = 1";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        User user = new User
                        {
                            userId = reader.GetInt32(0),
                            userName = reader.GetString(1),
                            password = reader.GetString(2),
                            fullName = reader.GetString(3),
                            email = reader.GetString(4),
                            soDienThoai = reader.GetString(5),
                            diaChi = reader.GetString(6),
                            quyen = reader.GetInt32(7),
                            trangThai = reader.GetInt32(8)
                        };
                        dstk.Add(user);
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }

            return dstk;
        }

        public ArrayList GetListStaff()
        {
            ArrayList dstk = new ArrayList();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM user WHERE quyen = 0";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        User user = new User
                        {
                            userId = reader.GetInt32(0),
                            userName = reader.GetString(1),
                            password = reader.GetString(2),
                            fullName = reader.GetString(3),
                            email = reader.GetString(4),
                            soDienThoai = reader.GetString(5),
                            diaChi = reader.GetString(6),
                            quyen = reader.GetInt32(7),
                            trangThai = reader.GetInt32(8)
                        };
                        dstk.Add(user);
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }

            return dstk;
        }

        public User GetUser(string username, string password)
        {
            User user = null;
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM user WHERE user_name = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        user = new User()
                        {
                            userId = reader.GetInt32(0),
                            userName = reader.GetString(1),
                            password = reader.GetString(2),
                            fullName = reader.GetString(3),
                            email = reader.GetString(4),
                            soDienThoai = reader.GetString(5),
                            diaChi = reader.GetString(6),
                            quyen = reader.GetInt32(7),
                            trangThai = reader.GetInt32(8)
                        };
                    }
                }
            }
            catch (Exception e)
            {
                return null;
            }

            return user;
        }

        public int MaxMaUser()
        {
            try
            {
                string sql = "SELECT MAX(user_id) FROM user";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    return Convert.ToInt32(cmd.ExecuteScalar()) + 1; ;
                }
            }catch (Exception e)
            {
                return -1;
            }
        }

        public bool ThemUser(int userId, string username, string password, string fullName, string email, string soDienThoai, string diaChi)
        {
            try
            {
                string sql = "INSERT INTO user(user_id,user_name,password,full_name,email,sodienthoai,diachi,quyen,status) " +
                    "VALUES (@userId,@username, @password, @fullName, @email, @soDienThoai, @diaChi, 1, 0)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@soDienThoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@diaChi", diaChi);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SuaUser(int maUser, string fullName, string email, string soDienThoai, string diaChi, int quyen)
        {
            try
            {
                string sql = "UPDATE user SET full_name = @fullName, email = @email, sodienthoai = @soDienThoai, diachi = @diaChi, quyen = @quyen WHERE user_id = @maUser";
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@soDienThoai", soDienThoai);
                    cmd.Parameters.AddWithValue("@diaChi", diaChi);
                    cmd.Parameters.AddWithValue("@quyen", quyen);
                    cmd.Parameters.AddWithValue("@maUser", maUser);

                    int rs = cmd.ExecuteNonQuery();

                    return rs > 0;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SuaPassUser(int maUser, string password)
        {
            try
            {
                string sql = "UPDATE user SET password = @password WHERE user_id = @maUser";
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@maUser", maUser);

                    int rs = cmd.ExecuteNonQuery();

                    return rs > 0;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool XoaUser(int maUser)
        {
            try
            {
                string sql = "DELETE FROM user WHERE user_id = @maUser";
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@maUser", maUser);
                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }catch (Exception e)
            {
                return false;
            }
        }

        //Lấy danh sách tài khoản theo quyền
        public ArrayList GetListTaiKhoanByQuyen(int quyen)
        {
            ArrayList dstk = new ArrayList();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM user WHERE quyen = @quyen";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@quyen", quyen);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        User user = new User
                        {
                            userId = reader.GetInt32(0),
                            userName = reader.GetString(1),
                            password = reader.GetString(2),
                            fullName = reader.GetString(3),
                            email = reader.GetString(4),
                            soDienThoai = reader.GetString(5),
                            diaChi = reader.GetString(6),
                            quyen = reader.GetInt32(7),
                            trangThai = reader.GetInt32(8)
                        };
                        dstk.Add(user);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Đã xảy ra lỗi khi lấy danh sách User theo quyền: " + e.Message);
                return null;
            }

            return dstk;
        }


        //Lấy user bằng id
        public User GetUserById(int userId)
        {
            User user = null;
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM user WHERE user_id = @userId";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        user = new User()
                        {
                            userId = reader.GetInt32(0),
                            userName = reader.GetString(1),
                            password = reader.GetString(2),
                            fullName = reader.GetString(3),
                            email = reader.GetString(4),
                            soDienThoai = reader.GetString(5),
                            diaChi = reader.GetString(6),
                            quyen = reader.GetInt32(7),
                            trangThai = reader.GetInt32(8)
                        };
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Đã xảy ra lỗi khi lấy User theo ID: " + e.Message);
                return null;
            }

            return user;
        }
    }
}
