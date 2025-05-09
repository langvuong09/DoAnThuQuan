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
    internal class CTPhieuTraDAO
    {
        private MyConnect db = new MyConnect();

        public List<CTPhieuTra> GetListCTPMByIdPhieuTra(int idPhieuTra)
        {
            List<CTPhieuTra> dsctpt = new List<CTPhieuTra>();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM chitiet_phieutra WHERE id_phieutra = @idPhieuTra";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idPhieuTra", idPhieuTra);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CTPhieuTra ctpt = new CTPhieuTra
                            {
                                idPhieuTra = reader.GetInt32("id_phieutra"),
                                idMonDo = reader.GetString("id_mondo")
                            };
                            dsctpt.Add(ctpt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
            }
            return dsctpt;
        }


        public ArrayList GetListCTPT()
        {
            ArrayList dsctpt = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM chitiet_phieutra";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CTPhieuTra ctpt = new CTPhieuTra
                        {
                            idPhieuTra = reader.GetInt32(0),
                            idMonDo = reader.GetString(1),
                        };
                        dsctpt.Add(ctpt);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dsctpt;
        }

        // Thêm
        public bool ThemCTPT(int maPT, string maThietBi)
        {
            try
            {
                string sql = "INSERT INTO chitiet_phieutra(id_phieutra, id_mondo)" +
                    "VALUES (@maPT, @maThietBi)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maPT", maPT);
                    cmd.Parameters.AddWithValue("@maThietBi", maThietBi);

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
        public bool XoaCTPT(int maPT)
        {
            try
            {
                string sql = "DELETE FROM chitiet_phieutra WHERE id_phieutra = @maPT";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maPT", maPT);
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
