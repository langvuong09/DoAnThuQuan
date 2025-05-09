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
    internal class KeDAO
    {
        private MyConnect db = new MyConnect();

        public ArrayList GetListKe()
        {
            ArrayList dsk = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM ke";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ke k = new ke
                        {
                            id_ke = reader.GetInt32(0),
                            id_khuvuc = reader.GetInt32(1),
                        };
                        dsk.Add(k);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dsk;
        }

        // Thêm
        public bool ThemKe(int maKe, int maKhu)
        {
            try
            {
                string sql = "INSERT INTO ke(id_ke, id_khuvuc)" +
                    "VALUES (@maKe, @maKhu)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maKe", maKe);
                    cmd.Parameters.AddWithValue("@maKhu", maKhu);

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
        public bool XoaKe(int maKe)
        {
            try
            {
                string sql = "DELETE FROM ke WHERE id_ke = @maKe";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maKe", maKe);
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
