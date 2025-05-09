using DoAnThuQuan.QuanLyThuQuan.DTO;
using MySql.Data.MySqlClient;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Thuvien.DTO;

namespace DoAnThuQuan.QuanLyThuQuan.DAO
{
    internal class CheckInOutDAO
    {
        private MyConnect db = new MyConnect();

        public ArrayList GetCheckInOutByDate(DateTime date)
        {
            ArrayList dscin = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM check_in_out WHERE DATE(time_in) = @date";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Check_in_out check_In_Out = new Check_in_out
                        {
                            user_id = reader.GetInt32("user_id"),
                            time_in = reader.GetDateTime("time_in"),
                            time_out = reader.GetDateTime("time_out"),
                        };
                        dscin.Add(check_In_Out);
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log nếu cần: Console.WriteLine(ex.Message);
                return null;
            }
            return dscin;
        }


        public ArrayList GetListCheckInOut()
        {
            ArrayList dscin = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM check_in_out";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Check_in_out check_In_Out = new Check_in_out
                        {
                            user_id = reader.GetInt32(0),
                            time_in = reader.GetDateTime(1),
                            time_out = reader.GetDateTime(2),
                        };
                        dscin.Add(check_In_Out);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dscin;
        }

        // Thêm
        public bool ThemCheckInOut(int userId, DateTime timeIn, DateTime timeOut)
        {
            try
            {
                string sql = "INSERT INTO check_in_out(user_id,time_in,time_out)" +
                    "VALUES (@userId, @timeIn, @timeOut)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@timeIn", timeIn);
                    cmd.Parameters.AddWithValue("@timeOut", timeOut);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Sửa
        public bool SuaCheckInOut(int userId, DateTime timeIn, DateTime timeOut)
        {
            try
            {
                string sql = "UPDATE check_in_out SET time_in = @timeIn, time_out = @timeOut WHERE user_id = @userId";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    
                    cmd.Parameters.AddWithValue("@timeIn", timeIn);
                    cmd.Parameters.AddWithValue("@timeOut", timeOut);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    int rs = cmd.ExecuteNonQuery();

                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Xóa
        public bool XoaCheckInOut(int userId)
        {
            try
            {
                string sql = "DELETE FROM check_in_out WHERE user_id = @userId";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
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
