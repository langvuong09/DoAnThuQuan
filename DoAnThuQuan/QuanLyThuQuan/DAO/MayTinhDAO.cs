using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

using DoAnThuQuan.QuanLyThuQuan.DTO;

using MySql.Data.MySqlClient;

namespace DoAnThuQuan.QuanLyThuQuan.DAO
{
    internal class MayTinhDAO
    {
        private MyConnect db = new MyConnect();

        public ArrayList GetListMayChieu()
        {
            ArrayList dsmt = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM maytinh";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        MayTinh mt = new MayTinh
                        {
                            idSeriMaytinh = reader.GetString(0),
                            trangThai = reader.GetInt32(1),
                            soLuong = reader.GetInt32(2),
                            link = reader.GetString(3),
                            giaTien = reader.GetInt32(4),
                        };
                        dsmt.Add(mt);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dsmt;
        }

        // Thêm máy tính mới
        public bool ThemMayTinh(string maMayTinh, int trangThai, int soLuong, string link, int giaTien)
        {
            try
            {
                string sql = "INSERT INTO maytinh(id_seri_maytinh,status,so_luong,link,gia_tien)" +
                    "VALUES (@maMayTinh,@trangThai,@soLuong,@link,@giaTien)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maMayTinh", maMayTinh);
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

        // Sửa máy tính
        public bool SuaMayTinh(string maMayTinh, int trangThai, int soLuong, string link, int giaTien)
        {
            try
            {
                string sql = "UPDATE maytinh SET status = @trangThai, so_luong = @soLuong, link = @link, gia_tien = @giaTien WHERE id_seri_maytinh = @maMayTinh";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@link", link);
                    cmd.Parameters.AddWithValue("@giaTien", giaTien);
                    cmd.Parameters.AddWithValue("@maMayTinh", maMayTinh);

                    int rs = cmd.ExecuteNonQuery();

                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ThemSLMayTinh(string maMayTinh,int soLuong)
        {
            try
            {
                string sql = "UPDATE maytinh SET so_luong = so_luong + @soLuong WHERE id_seri_maytinh = @maMayTinh";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@maMayTinh", maMayTinh);

                    int rs = cmd.ExecuteNonQuery();

                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Xóa máy tính
        public bool XoaMayTinh(string maMayTinh)
        {
            try
            {
                string sql = "DELETE FROM maytinh WHERE id_seri_maytinh = @maMayTinh";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maMayTinh", maMayTinh);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Lấy máy tính theo id_seri_maytinh
        public MayTinh GetMayTinhById(string maMayTinh)
        {
            try
            {
                string sql = "SELECT * FROM maytinh WHERE id_seri_maytinh = @maMayTinh";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maMayTinh", maMayTinh);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        MayTinh mt = new MayTinh
                        {
                            idSeriMaytinh = reader.GetString(0),
                            trangThai = reader.GetInt32(1),
                            soLuong = reader.GetInt32(2),
                            link = reader.GetString(3),
                            giaTien = reader.GetInt32(4),
                        };
                        return mt;
                    }
                    else
                    {
                        return null;  // Nếu không tìm thấy máy tính
                    }
                }
            }
            catch (Exception ex)
            {
                // Gợi ý: log lỗi nếu cần
                return null;
            }
        }


        // Tăng số lượng lên khi trả
        public bool TangSoLgMayTinh(string maMayTinh)
        {
            try
            {
                string sql = "UPDATE maytinh SET so_luong = so_luong + 1 WHERE id_seri_maytinh = @maMayTinh";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maMayTinh", maMayTinh);

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
        public bool GiamSoLgMayTinh(string maMayTinh)
        {
            try
            {
                string sql = "UPDATE maytinh SET so_luong = so_luong - 1 WHERE id_seri_maytinh = @maMayTinh";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maMayTinh", maMayTinh);

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
    }
}
