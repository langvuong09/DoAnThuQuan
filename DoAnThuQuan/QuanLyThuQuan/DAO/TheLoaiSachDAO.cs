using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnThuQuan.QuanLyThuQuan.DTO;
using System.Threading.Tasks;
using System.Collections;
using MySql.Data.MySqlClient;

namespace DoAnThuQuan.QuanLyThuQuan.DAO
{
    internal class TheLoaiSachDAO
    {
        private MyConnect db = new MyConnect();
        public ArrayList GetListTheLoaiSach()
        {
            ArrayList dstls = new ArrayList();
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM theloai_sach";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        TheLoaiSach theLoaiSach = new TheLoaiSach
                        {
                            maTheLoai = reader.GetInt32(0),
                            tenTheLoai = reader.GetString(1),
                        };
                        dstls.Add(theLoaiSach);
                    }
                }
            }catch (Exception ex)
            {
                return null;
            }
            return dstls;
        }

        public TheLoaiSach GetTheLoaiSach(int id)
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM theloai_sach WHERE id_theloaisach = @maTheLoai";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maTheLoai", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TheLoaiSach theLoaiSach = new TheLoaiSach
                        {
                            maTheLoai = reader.GetInt32(0),
                            tenTheLoai = reader.GetString(1),
                        };
                        return theLoaiSach;
                    }
                }
            } catch (Exception ex)
            {

            }
            return null;
        }

        public bool ThemTheLoai(int maTheLoai, string tenTheLoai)
        {
            try
            {
                string sql = "INSERT INTO theloai_sach(id_theloaisach, ten_theloai)" +
                    "VALUES (@maTheLoai, @tenTheLoai)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maTheloai", maTheLoai);
                    cmd.Parameters.AddWithValue("@tenTheloai", tenTheLoai);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }catch(Exception ex) 
            { 
                return false; 
            }
        }

        public bool XoaTheLoai(int maTheloai)
        {
            try
            {
                string sql = "DELETE FROM theloai_sach WHERE id_theloaisach = @maTheLoai";

                using ( MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maTheLoai", maTheloai);
                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }catch (Exception ex)
            {
                return false;
            }
        }
    }
}
