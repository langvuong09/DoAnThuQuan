using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

using DoAnThuQuan.QuanLyThuQuan.DTO;

using MySql.Data.MySqlClient;

namespace DoAnThuQuan.QuanLyThuQuan.DAO
{
    // Khởi tạo kết nối cơ sở dữ liệu
    public class PhieuDatChoDAO
    {
        private MyConnect db = new MyConnect();
        // Lấy thông tin phiếu đặt chỗ theo ID
        public PhieuDatCho GetPhieuDatChoById(int idPhieuDatCho)
        {
            PhieuDatCho phieu = null;
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM phieu_datcho WHERE id_phieudatcho = @idPhieuDatCho";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@idPhieuDatCho", idPhieuDatCho);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            phieu = new PhieuDatCho
                            {
                                idPhieudatcho = reader.GetInt32("id_phieudatcho"),
                                ngdatcho = reader.GetInt32("ngdatcho"),
                                idChongoi = reader.GetInt32("id_chongoi"),
                                createAt = reader.GetDateTime("create_at"),
                                tgian = reader.GetDateTime("tgian"),
                                trangThai = reader.GetInt32("status"),
                                soTien = reader.GetInt32("so_tien")
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lấy phiếu đặt chỗ theo ID: {ex.Message}");
            }
            return phieu;
        }

        // Trả về danh sách phiếu đặt chỗ
        public ArrayList GetListPhieuDatCho()
        {
            ArrayList dspdc = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM phieu_datcho";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dspdc.Add(new PhieuDatCho
                            {
                                idPhieudatcho = reader.GetInt32(0),
                                ngdatcho = reader.GetInt32(1),
                                idChongoi = reader.GetInt32(2),
                                createAt = reader.GetDateTime(3),
                                tgian = reader.GetDateTime(4),
                                trangThai = reader.GetInt32(5),
                                soTien = reader.GetInt32(6)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lấy danh sách phiếu đặt chỗ: {ex.Message}");
            }
            return dspdc;
        }
        // Thêm mới một phiếu đặt chỗ vào cơ sở dữ liệu
        public bool ThemPhieuDatCho(int maPhieu, int ngDatCho, int maChoNgoi, DateTime createAt, DateTime tgian, int trangThai, int soTien)
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "INSERT INTO phieu_datcho(id_phieudatcho,ngdatcho,id_chongoi,create_at,tgian,status,so_tien) " +
                                "VALUES (@maPhieu,@ngDatCho,@maChoNgoi,@createAt,@tgian,@trangThai,@soTien)";
                    
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maPhieu", maPhieu);
                    cmd.Parameters.AddWithValue("@ngDatCho", ngDatCho);
                    cmd.Parameters.AddWithValue("@maChoNgoi", maChoNgoi);
                    cmd.Parameters.AddWithValue("@createAt", createAt);
                    cmd.Parameters.AddWithValue("@tgian", tgian);
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);
                    cmd.Parameters.AddWithValue("@soTien", soTien);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm phiếu đặt chỗ: {ex.Message}");
                return false;
            }
        }
        // Sửa thông tin một phiếu đặt chỗ trong cơ sở dữ liệu
        public bool SuaPhieuDatCho(int maPhieu, int ngDatCho, int maChoNgoi, DateTime createAt, DateTime tgian, int trangThai, int soTien)
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE phieu_datcho SET ngdatcho = @ngDatCho, id_chongoi = @maChoNgoi, " +
                                "create_at = @createAt, tgian = @tgian, status = @trangThai, so_tien = @soTien " +
                                "WHERE id_phieudatcho = @maPhieu";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ngDatCho", ngDatCho);
                    cmd.Parameters.AddWithValue("@maChoNgoi", maChoNgoi);
                    cmd.Parameters.AddWithValue("@createAt", createAt);
                    cmd.Parameters.AddWithValue("@tgian", tgian);
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);
                    cmd.Parameters.AddWithValue("@soTien", soTien);
                    cmd.Parameters.AddWithValue("@maPhieu", maPhieu);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật phiếu đặt chỗ: {ex.Message}");
                return false;
            }
        }
        // Xóa một phiếu đặt chỗ khỏi cơ sở dữ liệu
        public bool XoaPhieuDatCho(string maPhieu)
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM phieu_datcho WHERE id_phieudatcho = @maPhieu";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maPhieu", maPhieu);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa phiếu đặt chỗ: {ex.Message}");
                return false;
            }
        }
        // Trả về danh sách chi tiết phiếu đặt chỗ
        public ArrayList GetChiTietPhieuDatCho(int idPhieuDatCho)
        {
            ArrayList list = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT id_chitiet_phieudatcho, id_thietbi, gia_tien, id_phieudatcho " +
                                "FROM chitiet_phieudatcho WHERE id_phieudatcho = @idPhieuDatCho";
                    
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idPhieuDatCho", idPhieuDatCho);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ChiTietPhieuDatCho(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetInt32(2),
                                reader.GetInt32(3)
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lấy chi tiết phiếu đặt chỗ: {ex.Message}");
            }
            return list;
        }

        public bool CapNhatTrangThaiPhieuDatCho(int idPhieuDatCho, int trangThai)
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE phieu_datcho SET status = @trangThai WHERE id_phieudatcho = @idPhieuDatCho";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);
                    cmd.Parameters.AddWithValue("@idPhieuDatCho", idPhieuDatCho);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật trạng thái phiếu đặt chỗ: {ex.Message}");
                return false;
            }
        }
    }
}