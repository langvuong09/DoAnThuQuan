using DoAnThuQuan.QuanLyThuQuan.DTO;
using MySql.Data.MySqlClient;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.DAO
{
    internal class SachDetailDAO
    {
        private MyConnect db = new MyConnect();
        public ArrayList GetListSachDetail()
        {
            ArrayList dssd = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM sach_detail";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        SachDetail sachDetail = new SachDetail
                        {
                            maDauSach = reader.GetString(0),
                            maSach = reader.GetInt32(1),
                            trangThai = reader.GetInt32(2),
                        };
                        dssd.Add(sachDetail);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dssd;
        }

        public int GetCountSachDetail(int maSach)
        {
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT COUNT(*) FROM sach_detail WHERE id_sach = @maSach";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@maSach", maSach);

                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public bool ThemSachDetail(string maSachDetail, int maSach, int trangThai)
        {
            try
            {
                string sql = "INSERT INTO sach_detail(id_serisach,id_sach,status)" +
                    "VALUES (@maSachDetail,@maSach,@trangThai)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maSachDetail", maSachDetail);
                    cmd.Parameters.AddWithValue("@maSach", maSach);
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaSachDetail(int maSach)
        {
            try
            {
                string sql = "DELETE FROM sach_detail WHERE id_sach = @maSach";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maSach", maSach);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SuaSachDetail(string maSachDetail, int maSach, int trangThai)
        {
            try
            {
                string sql = "UPDATE sach_detail SET id_sach = @maSach, status = @trangThai WHERE id_serisach = @maSachDetail";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    
                    cmd.Parameters.AddWithValue("@maSach", maSach);
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);
                    cmd.Parameters.AddWithValue("@maSachDetail", maSachDetail);

                    int rs = cmd.ExecuteNonQuery();

                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Cập nhật trạng thái
        public Tuple<string, int> GetSachDetailAndThanhTienByIdSeriSach(string idSeriSach)
        {
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = @"
            SELECT sd.id_serisach, s.thanh_tien
            FROM sach_detail sd
            JOIN sach s ON sd.id_sach = s.id_sach
            WHERE sd.id_serisach = @idSeriSach";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idSeriSach", idSeriSach); // Thêm tham số để lọc theo id_serisach

                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Kiểm tra nếu có dữ liệu
                    if (reader.Read())
                    {
                        string idSeriSachResult = reader.GetString("id_serisach");
                        int thanhTien = reader.GetInt32("thanh_tien");

                        return Tuple.Create(idSeriSachResult, thanhTien);
                    }
                    else
                    {
                        // Nếu không có kết quả, trả về null hoặc Tuple rỗng
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy dữ liệu: " + ex.Message);
                return null;
            }
        }


        public bool CapNhatTrangThaiSachDetail(string maSachDetail, int trangThai)
        {
            try
            {
                string sql = "UPDATE sach_detail SET status = @trangThai WHERE id_serisach = @maSachDetail";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@trangThai", trangThai);
                    cmd.Parameters.AddWithValue("@maSachDetail", maSachDetail);

                    int rs = cmd.ExecuteNonQuery();

                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //Lấy chi tiết sách với tên sách
        public List<Tuple<SachDetail, string>> GetListSachDetailWithTenSach()
        {
            List<Tuple<SachDetail, string>> list = new List<Tuple<SachDetail, string>>();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = @"
                SELECT sd.id_serisach, sd.id_sach, sd.status, s.ten_sach
                FROM sach_detail sd
                JOIN sach s ON sd.id_sach = s.id_sach";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        SachDetail sachDetail = new SachDetail
                        {
                            maDauSach = reader.GetString("id_serisach"),
                            maSach = reader.GetInt32("id_sach"),
                            trangThai = reader.GetInt32("status")
                        };

                        string tenSach = reader.GetString("ten_sach");

                        list.Add(Tuple.Create(sachDetail, tenSach));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy dữ liệu SachDetail: " + ex.Message);
                return null;
            }

            return list;
        }
    }
}
