using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClosedXML.Excel;

using DoAnThuQuan.QuanLyThuQuan.DTO;

using DocumentFormat.OpenXml.EMMA;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnThuQuan.QuanLyThuQuan.DAO
{
    internal class SachDAO
    {
        private MyConnect db = new MyConnect();
        public ArrayList GetListSach()
        {
            ArrayList dss = new ArrayList();
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM sach";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Sach sach = new Sach
                        {
                            maSach = reader.GetInt32(0),
                            tenSach = reader.GetString(1),
                            theLoai = reader.GetInt32(2),
                            tacGia = reader.GetString(3),
                            maKe = reader.GetInt32(4),
                            moTa = reader.GetString(5),
                            thanhTien = reader.GetInt32(6),
                            trangThai = reader.GetInt32(7),
                        };
                        dss.Add(sach);
                    }
                }
            }catch (Exception ex)
            {
                return dss;
            }
            return dss;
        }

        public Sach GetSach(string tenSach)
        {
            Sach sach = null;
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM sach WHERE tenSach = @tenSach LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@tenSach", tenSach);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sach = new Sach
                            {
                                maSach = reader.GetInt32(0),
                                tenSach = reader.GetString(1),
                                theLoai = reader.GetInt32(2),
                                tacGia = reader.GetString(3),
                                maKe = reader.GetInt32(4),
                                moTa = reader.GetString(5),
                                thanhTien = reader.GetInt32(6),
                                trangThai = reader.GetInt32(7),
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return sach;
        }

        public int MaxMaSach()
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT MAX(id_sach) FROM sach";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public bool NhapSachTuExcel(Sach s)
        {
            try
            {
                string sql = "DELETE * FROM sach; " +
                "INSERT INTO sach(id_sach, ten_sach, id_theloaisach, tacgia, id_ke, mota, thanh_tien, status)" +
                    "VALUES (@maSach, @tenSach, @theLoai, @tacGia, @maKe, @moTa, @thanhTien, @trangThai)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maSach", s.maSach);
                    cmd.Parameters.AddWithValue("@tenSach", s.tenSach);
                    cmd.Parameters.AddWithValue("@theLoai", s.theLoai);
                    cmd.Parameters.AddWithValue("@tacGia", s.tacGia);
                    cmd.Parameters.AddWithValue("@maKe", s.maKe);
                    cmd.Parameters.AddWithValue("@moTa", s.moTa);
                    cmd.Parameters.AddWithValue("@thanhTien", s.thanhTien);
                    cmd.Parameters.AddWithValue("@trangThai", s.trangThai);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ThemSach(int maSach, string tenSach, int theLoai, string tacGia, int maKe, string moTa, int thanhTien, int trangThai)
        {
            try
            {
                string sql = "INSERT INTO sach(id_sach,ten_sach, id_theloaisach, tacgia, id_ke, mota, thanh_tien, status)" +
                    "VALUES (@maSach, @tenSach, @theLoai, @tacGia, @maKe, @moTa, @thanhTien, @trangThai)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maSach",maSach);
                    cmd.Parameters.AddWithValue("@tenSach", tenSach);
                    cmd.Parameters.AddWithValue("@theLoai", theLoai);
                    cmd.Parameters.AddWithValue("@tacGia", tacGia);
                    cmd.Parameters.AddWithValue("@maKe", maKe);
                    cmd.Parameters.AddWithValue("@moTa", moTa);
                    cmd.Parameters.AddWithValue("@thanhTien", thanhTien);
                    cmd.Parameters.AddWithValue("@trangThai", trangThai);

                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool XoaSach(int maSach)
        {
            try
            {
                string sql = "DELETE FROM sach WHERE id_sach = @maSach";
                using ( MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maSach", maSach);
                    int rs = cmd.ExecuteNonQuery();
                    return rs > 0;
                }
            }catch (Exception ex)
            {
                return false;
            }
        }

        public bool SuaSach(int maSach, string tenSach, int theLoai, string tacGia, int maKe, string moTa, int thanhTien)
        {
            try
            {
                string sql = "UPDATE sach SET ten_sach = @tenSach, id_theloaisach = @theLoai, tacgia = @tacGia, id_ke = @maKe, mota = @moTa, thanh_tien = @thanhTien WHERE id_sach = @maSach";

                using(MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@tenSach", tenSach);
                    cmd.Parameters.AddWithValue("@theLoai", theLoai);
                    cmd.Parameters.AddWithValue("@tacGia", tacGia);
                    cmd.Parameters.AddWithValue("@maKe", maKe);
                    cmd.Parameters.AddWithValue("@moTa", moTa);
                    cmd.Parameters.AddWithValue("@thanhTien", thanhTien);
                    cmd.Parameters.AddWithValue("@maSach", maSach);

                    int rs = cmd.ExecuteNonQuery();

                    return rs > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void XuatFileExcel(string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Sach");

                    // Thêm header
                    worksheet.Cell(1, 1).Value = "Mã sách";
                    worksheet.Cell(1, 2).Value = "tên sách";
                    worksheet.Cell(1, 3).Value = "Thể loại";
                    worksheet.Cell(1, 4).Value = "Tác giả";
                    worksheet.Cell(1, 5).Value = "Mã kệ";
                    worksheet.Cell(1, 6).Value = "Mô tả";
                    worksheet.Cell(1, 7).Value = "Giá";
                    worksheet.Cell(1, 8).Value = "Trạng thái";

                    // Style cho header
                    var headerRange = worksheet.Range(1, 1, 1, 8);
                    headerRange.Style.Font.Bold = true;
                    headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
                    headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Lấy dữ liệu và thêm vào Excel
                    ArrayList listSach = GetListSach();
                    int row = 2;
                    foreach (Sach s in listSach)
                    {
                        worksheet.Cell(row, 1).Value = s.maSach;
                        worksheet.Cell(row, 2).Value = s.tenSach;
                        worksheet.Cell(row, 3).Value = s.theLoai;
                        worksheet.Cell(row, 4).Value = s.tacGia;
                        worksheet.Cell(row, 5).Value = s.maKe;
                        worksheet.Cell(row, 5).Value = s.moTa;
                        worksheet.Cell(row, 5).Value = s.thanhTien;
                        worksheet.Cell(row, 5).Value = s.trangThai;
                        row++;
                    }

                    // Tự động điều chỉnh độ rộng cột
                    worksheet.Columns().AdjustToContents();

                    // Lưu file
                    workbook.SaveAs(filePath);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xuất Excel: " + ex.Message);
            }
        }
    }
}
