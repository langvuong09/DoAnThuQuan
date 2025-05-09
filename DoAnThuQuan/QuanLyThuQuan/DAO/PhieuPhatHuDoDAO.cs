using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

using DoAnThuQuan.QuanLyThuQuan.DTO;

using MySql.Data.MySqlClient;

namespace DoAnThuQuan.QuanLyThuQuan.DAO
{
    public class PhieuPhatHuDoDAO
    {
        private MyConnect db = new MyConnect();

        public int GetMaxIdPhieuPhat()
        {
            int maxId = 0;

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT MAX(id_phieuphatHuDo) FROM phieuphat_hudo";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        maxId = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {

                maxId = 0;
            }

            return maxId;
        }

        public PhieuPhatHuDo TimPhieuPhatTheoId(int maPhieuPhat)
        {
            PhieuPhatHuDo phieuPhat = null;
            try
            {
                string sql = "SELECT * FROM phieuphat_hudo WHERE id_phieuphatHuDo = @maPhieuPhat";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maPhieuPhat", maPhieuPhat);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            phieuPhat = new PhieuPhatHuDo
                            {
                                idPhieuPhatHuDo = reader.GetInt32("id_phieuphatHuDo"),
                                idPhieuTra = reader.GetInt32("id_phieutra"),
                                solg = reader.GetInt32("solg"),
                                tongTien = reader.GetInt32("tongtien")
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tìm phiếu phạt theo ID: " + ex.Message);
            }
            return phieuPhat;
        }




        public ArrayList GetListPhieuPhatHuDo()
        {
            ArrayList dsPhieuPhat = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM phieuphat_hudo";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        PhieuPhatHuDo phieuPhat = new PhieuPhatHuDo
                        {
                            idPhieuPhatHuDo = reader.GetInt32(0),
                            idPhieuTra = reader.GetInt32(1),
                            solg = reader.GetInt32(2),
                            tongTien = reader.GetInt32(3)
                        };
                        dsPhieuPhat.Add(phieuPhat);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách phiếu phạt: " + ex.Message);
                return null;
            }
            return dsPhieuPhat;
        }

        public bool ThemPhieuPhat(int maPhieuPhat, int maPhieuTra, int soLuong, int tongTien)
        {
            try
            {
                // Kiểm tra xem mã phiếu phạt đã tồn tại chưa
                if (KiemTraTonTai(maPhieuPhat))
                {
                    return false;
                }

                string sql = "INSERT INTO phieuphat_hudo(id_phieuphatHuDo, id_phieutra, solg, tongtien) " +
                    "VALUES (@maPhieuPhat, @maPhieuTra, @soLuong, @tongTien)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maPhieuPhat", maPhieuPhat);
                    cmd.Parameters.AddWithValue("@maPhieuTra", maPhieuTra);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@tongTien", tongTien);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm phiếu phạt: " + ex.Message);
                return false;
            }
        }

        public bool SuaPhieuPhat(int maPhieuPhat, int maPhieuTra, int soLuong, int tongTien)
        {
            try
            {
                // Kiểm tra xem mã phiếu phạt có tồn tại không
                if (!KiemTraTonTai(maPhieuPhat))
                {
                    return false;
                }

                string sql = "UPDATE phieuphat_hudo SET id_phieutra = @maPhieuTra, solg = @soLuong, tongtien = @tongTien " +
                    "WHERE id_phieuphatHuDo = @maPhieuPhat";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maPhieuPhat", maPhieuPhat);
                    cmd.Parameters.AddWithValue("@maPhieuTra", maPhieuTra);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@tongTien", tongTien);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi sửa phiếu phạt: " + ex.Message);
                return false;
            }
        }

        public bool XoaPhieuPhat(int maPhieuPhat)
        {
            try
            {
                string sql = "DELETE FROM phieuphat_hudo WHERE id_phieuphatHuDo = @maPhieuPhat";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maPhieuPhat", maPhieuPhat);
                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa phiếu phạt: " + ex.Message);
                return false;
            }
        }

        private bool KiemTraTonTai(int maPhieuPhat)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM phieuphat_hudo WHERE id_phieuphatHuDo = @maPhieuPhat";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maPhieuPhat", maPhieuPhat);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi kiểm tra tồn tại: " + ex.Message);
                return false;
            }
        }
    }
}
