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
    internal class PhieuTraDAO
    {
        private MyConnect db = new MyConnect();

    public ArrayList GetListPhieuTraHomNay()
        {
            ArrayList dspt = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = @"
           SELECT pt.*
            FROM phieu_tra pt
            LEFT JOIN phieuphat_hudo pp ON pt.id_phieutra = pp.id_phieutra
            WHERE DATE(pt.tgian_tra) = CURDATE()
            AND pp.id_phieutra IS NULL;";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PhieuTra pt = new PhieuTra
                            {
                                maPhieuTra = reader.GetInt32(0),
                                thoiGianTra = reader.GetDateTime(1),
                                maPhieuMuon = reader.GetInt32(2),
                                moTa = reader.GetString(3),
                                maNhanVien = reader.GetInt32(4),
                            };
                            dspt.Add(pt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                // Hoặc ghi log vào file
            }
            return dspt;
        }




        public ArrayList GetPhieuTraByDateRange(DateTime startDate, DateTime endDate)
        {
            ArrayList dspt = new ArrayList();
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM phieu_tra WHERE DATE(tgian_tra) BETWEEN @startDate AND @endDate";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@startDate", startDate.Date);
                    cmd.Parameters.AddWithValue("@endDate", endDate.Date);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        PhieuTra pt = new PhieuTra
                        {
                            maPhieuTra = reader.GetInt32(0),
                            thoiGianTra = reader.GetDateTime(1),
                            maPhieuMuon = reader.GetInt32(2),
                            moTa = reader.GetString(3),
                            maNhanVien = reader.GetInt32(4),
                        };
                        dspt.Add(pt);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dspt;
        }


        public int GetMaxIdPhieuTra()
        {
            int maxId = 0; 

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT MAX(id_phieutra) FROM phieu_tra";
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

        public ArrayList GetListPhieuTra()
        {
            ArrayList dspt = new ArrayList();
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM phieu_tra";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        PhieuTra pt = new PhieuTra
                        {
                            maPhieuTra = reader.GetInt32(0),
                            thoiGianTra = reader.GetDateTime(1),
                            maPhieuMuon = reader.GetInt32(2),
                            moTa = reader.GetString(3),
                            maNhanVien = reader.GetInt32(4),
                        };
                        dspt.Add(pt);
                    }
                }
            }catch (Exception ex)
            {
                return null;
            }
            return dspt;
        }

        //Lấy phiếu trả bằng mã phiếu trả
        public PhieuTra GetPhieuTraById(int idPhieuTra)
        {
            PhieuTra pt = null;
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM phieu_tra WHERE id_phieutra = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idPhieuTra);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        pt = new PhieuTra
                        {
                            maPhieuTra = reader.GetInt32(0),
                            thoiGianTra = reader.GetDateTime(1),
                            maPhieuMuon = reader.GetInt32(2),
                            moTa = reader.GetString(3),
                            maNhanVien = reader.GetInt32(4),
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi nếu cần
                return null;
            }
            return pt;
        }


        public bool ThemPhieuTra(int maPT, DateTime tgianTra, int maPM, string mota, int maNhanVien)
        {
            try
            {
                string sql = "INSERT INTO phieu_tra(id_phieutra,tgian_tra,id_phieumuon,mota,nvien)" +
                    "VALUES (@maPT,@tgianTra,@maPM,@moTa,@maNhanVien)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maPT", maPT);
                    cmd.Parameters.AddWithValue("@tgianTra", tgianTra);
                    cmd.Parameters.AddWithValue("@maPM", maPM);
                    cmd.Parameters.AddWithValue("@moTa", mota);
                    cmd.Parameters.AddWithValue("@maNhanVien", maNhanVien);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaPhieuTra(int maPT)
        {
            try
            {
                string sql = "DELETE FROM phieu_tra WHERE id_phieutra = @maPT";

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

        public bool SuaPhieuTra(int maPT, DateTime tgianTra, int maPM, string mota, int maNhanVien)
        {
            try
            {
                string sql = "UPDATE phieu_tra SET tgian_tra = @tgianTra, id_phieumuon = @maPM, mota = @moTa, nvien = @maNhanVien WHERE id_phieutra = @maPT";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    
                    cmd.Parameters.AddWithValue("@tgianTra", tgianTra);
                    cmd.Parameters.AddWithValue("@maPM", maPM);
                    cmd.Parameters.AddWithValue("@moTa", mota);
                    cmd.Parameters.AddWithValue("@maNhanVien", maNhanVien);
                    cmd.Parameters.AddWithValue("@maPT", maPT);

                    int rs = cmd.ExecuteNonQuery();

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
