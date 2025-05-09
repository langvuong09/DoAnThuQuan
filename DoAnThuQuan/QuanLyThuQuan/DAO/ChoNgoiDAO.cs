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
    internal class ChoNgoiDAO
    {
        private MyConnect db = new MyConnect();
        public ArrayList GetListChoNgoi()
        {
            ArrayList dscn = new ArrayList();
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM cho_ngoi";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ChoNgoi choNgoi = new ChoNgoi
                        {
                            idChoNgoi = reader.GetInt32(0),
                            idPhong = reader.GetInt32(1),
                            status = reader.GetInt32(2),
                            viTri = reader.GetInt32(3),
                            soLuong = reader.GetInt32(4)
                        };
                        dscn.Add(choNgoi);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dscn;
        }

        public bool ThemChoNgoi(int idChoNgoi, int idPhong, int status, int viTri, int soLuong)
        {
            try
            {
                string sql = "INSERT INTO cho_ngoi(id_chongoi, id_phong, status, vi_tri, so_luong)" +
                    "VALUES (@idChoNgoi, @idPhong, @status, @viTri, @soLuong)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@idChoNgoi", idChoNgoi);
                    cmd.Parameters.AddWithValue("@idPhong", idPhong);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@viTri", viTri);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch (Exception ex) { return false; }
        }

        public bool SuaChoNgoi(int idChoNgoi, int idPhong, int status, int viTri, int soLuong)
        {
            try
            {
                string sql = "UPDATE cho_ngoi SET id_phong = @idPhong, status = @status, vi_tri = @viTri, so_luong = @soLuong WHERE id_chongoi = @idChoNgoi";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@idPhong", idPhong);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@viTri", viTri);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@idChoNgoi", idChoNgoi);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch (Exception ex) { return false; }
        }

        public bool XoaChoNgoi(int idChoNgoi)
        {
            try
            {
                string sql = "DELETE FROM cho_ngoi WHERE id_chongoi = @idChoNgoi";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@idChoNgoi", idChoNgoi);
                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch (Exception ex) { return false; }
        }
    }
}
