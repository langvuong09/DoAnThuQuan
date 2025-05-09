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
    internal class CTPhieuNhapDAO
    {
        private MyConnect db = new MyConnect();

        public ArrayList GetListCTPN()
        {
            ArrayList dsctpn = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM chitiet_phieunhap";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CTPhieuNhap ctpn = new CTPhieuNhap
                        {
                            idPhieuNhap = reader.GetInt32(0),
                            idSanPham = reader.GetInt32(1),
                            loaiSanPham = reader.GetString(2),
                            thanhTien = reader.GetInt32(3),

                        };
                        dsctpn.Add(ctpn);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dsctpn;
        }

        // Thêm
        public bool ThemCTPN(int maPN, string maSP, string loaiSP, int thanhTien)
        {
            try
            {
                string sql = "INSERT INTO chitiet_phieunhap(id_phieunhap, id_sanpham, loai_sanpham, thanh_tien)" +
                    "VALUES (@maPN, @maSP, @loaiSP, @thanhTien)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maPN", maPN);
                    cmd.Parameters.AddWithValue("@maSP", maSP);
                    cmd.Parameters.AddWithValue("@loaiSP", loaiSP);
                    cmd.Parameters.AddWithValue("@thanhTien", thanhTien);

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
        public bool XoaCTPN(int maPN)
        {
            try
            {
                string sql = "DELETE FROM chitiet_phieunhap WHERE id_phieunhap = @maPN";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maPN", maPN);
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
