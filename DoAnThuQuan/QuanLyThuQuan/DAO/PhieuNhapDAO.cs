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
    internal class PhieuNhapDAO
    {
        private MyConnect db = new MyConnect();
        public ArrayList GetListPhieuNhap()
        {
            ArrayList dspn = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM phieu_nhaphang";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        PhieuNhap pn = new PhieuNhap
                        {
                            idPhieuNhap = reader.GetInt32(0),
                            ngayNhap = reader.GetDateTime(1),
                            idNhanVien = reader.GetInt32(2),
                            slSach = reader.GetInt32(3),
                            slMayTinh = reader.GetInt32(4),
                            slMayChieu = reader.GetInt32(5),
                            tongTien = reader.GetInt32(6),
                        };
                        dspn.Add(pn);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dspn;
        }

        public bool ThemPhieuNhap(int maPN, DateTime ngayNhap, int maNhanVien, int slSach, int slMayTinh, int slMayChieu, int tongTien)
        {
            try
            {
                string sql = "INSERT INTO phieu_nhaphang(id_phieunhap, ngay_nhap, id_nhanvien,solg_sach,solg_maytinh,solg_maychieu,tong_tien)" +
                    "VALUES (@maPN,@ngayNhap,@maNhanVien,@slSach,@slMayTinh,@slMayChieu,@tongTien)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maPN", maPN);
                    cmd.Parameters.AddWithValue("@ngayNhap", ngayNhap);
                    cmd.Parameters.AddWithValue("@maNhanVien", maNhanVien);
                    cmd.Parameters.AddWithValue("@slSach", slSach);
                    cmd.Parameters.AddWithValue("@slMayTinh", slMayTinh);
                    cmd.Parameters.AddWithValue("@slMayChieu", slMayChieu);
                    cmd.Parameters.AddWithValue("@tongTien", tongTien);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaPhieuNhap(int maPN)
        {
            try
            {
                string sql = "DELETE FROM phieu_nhaphang WHERE id_phieunhap = @maPhieuNhap";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maPhieuNhap", maPN);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SuaPhieuNhap(int maPN, DateTime ngayNhap, int maNhanVien, int slSach, int slMayTinh, int slMayChieu, int tongTien)
        {
            try
            {
                string sql = "UPDATE phieu_nhaphang SET ngay_nhap = @ngayNhap, id_nhanvien = @maNhanVien, solg_sach = @slSach,solg_maytinh = @slMayTinh,solg_maychieu = @slMayChieu,tong_tien = @tongTien WHERE id_phieunhap = @maPN";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    
                    cmd.Parameters.AddWithValue("@ngayNhap", ngayNhap);
                    cmd.Parameters.AddWithValue("@maNhanVien", maNhanVien);
                    cmd.Parameters.AddWithValue("@slSach", slSach);
                    cmd.Parameters.AddWithValue("@slMayTinh", slMayTinh);
                    cmd.Parameters.AddWithValue("@slMayChieu", slMayChieu);
                    cmd.Parameters.AddWithValue("@tongTien", tongTien);
                    cmd.Parameters.AddWithValue("@maPN", maPN);

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
