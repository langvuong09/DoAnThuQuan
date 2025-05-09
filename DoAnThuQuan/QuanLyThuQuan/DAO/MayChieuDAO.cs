using System;
using System.Collections;

using DoAnThuQuan.QuanLyThuQuan.DTO;

using MySql.Data.MySqlClient;

namespace DoAnThuQuan.QuanLyThuQuan.DAO
{
    internal class MayChieuDAO
    {
        private MyConnect db = new MyConnect();

        public ArrayList GetListMayChieu()
        {
            ArrayList dsmc = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM maychieu";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        MayChieu mc = new MayChieu
                        {
                            idSeriMaychieu = reader.GetString(0),
                            trangThai = reader.GetInt32(1),
                            soLuong = reader.GetInt32(2),
                            link = reader.GetString(3),
                            giaTien = reader.GetInt32(4),
                        };
                        dsmc.Add(mc);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dsmc;
        }

        // Thêm máy chiếu mới
        public bool ThemMayChieu(string maMayChieu, int trangThai, int soLuong, string link, int giaTien)
        {
            try
            {
                string sql = "INSERT INTO maychieu(id_seri_maychieu,status,so_luong,link,gia_tien)" +
                    "VALUES (@maMayChieu,@trangThai,@soLuong,@link,@giaTien)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maMayChieu", maMayChieu);
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@link", link);
                    cmd.Parameters.AddWithValue("@giaTien", giaTien);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Sửa máy chiếu
        public bool SuaMayChieu(string maMayChieu, int trangThai, int soLuong, string link, int giaTien)
        {
            try
            {
                string sql = "UPDATE maychieu SET status = @trangThai, so_luong = @soLuong, link = @link, gia_tien = @giaTien WHERE id_seri_maychieu = @maMayChieu";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@link", link);
                    cmd.Parameters.AddWithValue("@giaTien", giaTien);
                    cmd.Parameters.AddWithValue("@maMayChieu", maMayChieu);

                    int rs = cmd.ExecuteNonQuery();

                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ThemSLMayChieu(string maMayChieu, int soLuong)
        {
            try
            {
                string sql = "UPDATE maychieu SET so_luong = so_luong + @soLuong WHERE id_seri_maychieu = @maMayChieu";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@maMayChieu", maMayChieu);

                    int rs = cmd.ExecuteNonQuery();

                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Xóa máy chiếu
        public bool XoaMayChieu(string maMayChieu)
        {
            try
            {
                string sql = "DELETE FROM maychieu WHERE id_seri_maychieu = @maMayChieu";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maMayChieu", maMayChieu);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Tăng số lượng lên khi trả
        public bool TangSoLgMayChieu(string maMayChieu)
        {
            try
            {
                string sql = "UPDATE maychieu SET so_luong = so_luong + 1 WHERE id_seri_maychieu = @maMayChieu";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maMayChieu", maMayChieu);

                    int rs = cmd.ExecuteNonQuery();

                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                // Gợi ý: log lỗi nếu cần
                return false;
            }
        }

        //Giảm số lượng khi mượn
        public bool GiamSoLgMayChieu(string maMayChieu)
        {
            try
            {
                string sql = "UPDATE maychieu SET so_luong = so_luong - 1 WHERE id_seri_maychieu = @maMayChieu";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maMayChieu", maMayChieu);

                    int rs = cmd.ExecuteNonQuery();

                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                // Gợi ý: log lỗi nếu cần
                return false;
            }
        }

        public MayChieu GetMayChieuById(string maMayChieu)
        {
            MayChieu mc = null;
            try
            {
                string sql = "SELECT * FROM maychieu WHERE id_seri_maychieu = @maMayChieu";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maMayChieu", maMayChieu);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        mc = new MayChieu
                        {
                            idSeriMaychieu = reader.GetString(0),
                            trangThai = reader.GetInt32(1),
                            soLuong = reader.GetInt32(2),
                            link = reader.GetString(3),
                            giaTien = reader.GetInt32(4),
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                // Gợi ý: log lỗi nếu cần
                return null;
            }
            return mc;
        }
    }
}
