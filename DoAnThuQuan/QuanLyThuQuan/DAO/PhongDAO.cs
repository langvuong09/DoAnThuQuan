using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnThuQuan.QuanLyThuQuan.DTO;

using MySql.Data.MySqlClient;

namespace DoAnThuQuan.QuanLyThuQuan.DAO
{
    internal class PhongDAO
    {
        private MyConnect db = new MyConnect();
        public ArrayList GetLisPhong()
        {
            ArrayList dsp = new ArrayList();
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM phong";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Phong phong = new Phong
                        {
                            maPhong = reader.GetInt32(0),
                            soLgChoNgoi = reader.GetInt32(1),
                            trangThai = reader.GetInt32(2),
                        };
                        dsp.Add(phong);
                    }
                }
            }catch (Exception ex)
            {
                return null;
            }
            return dsp;
        }

        public bool ThemPhong(int maPhong, int soLgChoNgoi, int trangThai)
        {
            try
            {
                string sql = "INSERT INTO phong(id_phong, solgchongoi,status)" +
                    "VALUES (@maPhong, @soLuong, @trangThai)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maPhong", maPhong);
                    cmd.Parameters.AddWithValue("@soLuong", soLgChoNgoi);
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }catch(Exception ex) { return false; }
        }

        public bool XoaPhong(int maPhong)
        {
            try
            {
                string sql = "DELETE FROM phong WHERE id_phong = @maPhong";

                using(MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maPhong", maPhong);
                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch(Exception ex) { return false; }
        }

        public bool SuaPhong(int maPhong, int soLuong, int trangThai)
        {
            try
            {
                string sql = "UPDATE phong SET solgchongoi = @soLuong, status = @trangThai WHERE id_phong = @maPhong";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);
                    cmd.Parameters.AddWithValue("@maPhong", maPhong);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }catch(Exception ex) { return false; }
        }
    }
}
