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
    internal class CTPhatHuDoDAO
    {
        private MyConnect db = new MyConnect();
        // Lấy chi tiết phiếu phạt hư đồ theo mã phiếu
        public ArrayList GetCTPhatByMaPhieuPhatHuDo(int maPP)
        {
            ArrayList dsctphd = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM chitiet_phathudo WHERE id_phieuphatHuDo = @maPP";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@maPP", maPP);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Chitiet_phathudo ctphd = new Chitiet_phathudo
                        {
                            id_phieuphatHuDo = reader.GetInt32(0),
                            id_mondo = reader.GetString(1),
                            mota = reader.GetString(2),
                            tien = reader.GetInt32(3),
                        };
                        dsctphd.Add(ctphd);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dsctphd;
        }

        public ArrayList GetListCTPhat()
        {
            ArrayList dsctphd = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM chitiet_phathudo";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Chitiet_phathudo ctphd = new Chitiet_phathudo
                        {
                            id_phieuphatHuDo = reader.GetInt32(0),
                            id_mondo = reader.GetString(1),
                            mota = reader.GetString(2),
                            tien = reader.GetInt32(3),
                        };
                        dsctphd.Add(ctphd);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dsctphd;
        }

        // Thêm
        public bool ThemCTPhat(int maPP,String maThietBi, string mota, int tien)
        {
            try
            {
                string sql = "INSERT INTO chitiet_phathudo(id_phieuphatHuDo, id_mondo,mota,tien)" +
                    "VALUES (@maPP,@maThietBi,@moTa,@tien)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maPP", maPP);
                    cmd.Parameters.AddWithValue("@maThietBi", maThietBi);
                    cmd.Parameters.AddWithValue("@moTa", mota);
                    cmd.Parameters.AddWithValue("@tien", tien);

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
        public bool XoaCTPhat(int maPP)
        {
            try
            {
                string sql = "DELETE FROM chitiet_phathudo WHERE id_phieuphatHuDo = @maPP";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maPP", maPP);
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
