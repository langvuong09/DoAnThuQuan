using MySql.Data.MySqlClient;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnThuQuan.QuanLyThuQuan.DTO;

namespace DoAnThuQuan.QuanLyThuQuan.DAO
{
    internal class ThietBiDAO
    {
        private MyConnect db = new MyConnect();
        public ArrayList GetListThietBi()
        {
            ArrayList dstb = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM user";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while ( reader.Read())
                    {
                        ThietBi thietBi = new ThietBi
                        {
                            maThietbi = reader.GetInt32(0),
                            tenThietBi = reader.GetString(1),
                            soLuong = reader.GetInt32(2),
                            trangThai = reader.GetInt32(3),
                        };
                        dstb.Add(thietBi);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dstb;
        }

        public bool ThemThietBi(string tenThietBi, int soLuong, int trangThai)
        {
            try
            {
                string sql = "INSERT INTO thietbi(ten_thietbi, so_lg, status)" +
                    "VALUES (@tenThietBi,@soLuong,@trangThai)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@tenThietBi", tenThietBi);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaThietBi(int maThietBi)
        {
            try
            {
                string sql = "DELETE FROM thietbi WHERE id_thietbi = @maThietBi";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maThietBi", maThietBi);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SuaThietBi(int maThietBi, string tenThietBi, int soLuong, int trangThai)
        {
            try
            {
                string sql = "UPDATE thietbi SET ten_thietbi = @tenThietBi, so_lg = @soLuong, status = @trangThai WHERE id_thietbi = @maThietBi";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@tenThietBi", tenThietBi);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);
                    cmd.Parameters.AddWithValue("@maThietBi", maThietBi);

                    int rs= cmd.ExecuteNonQuery();

                    return rs > 0;  
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
