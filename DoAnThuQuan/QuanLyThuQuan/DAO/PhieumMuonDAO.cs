using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using DoAnThuQuan.QuanLyThuQuan.DTO;

using MySql.Data.MySqlClient;
using System.Collections;
using System.Windows.Forms;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace DoAnThuQuan.QuanLyThuQuan.DAO
{
    internal class PhieuMuonDAO
    {
        // Khởi tạo kết nối cơ sở dữ liệu
        private MyConnect db = new MyConnect();
       



        public int GetMaxIdPhieuMuon()
        {
            int maxId = 0;

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT MAX(id_phieumuon) FROM phieu_muon";
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

        //Lấy phiếu mượn bằng mã phiếu mượn
        public PhieuMuon GetPhieuMuonById(int idPhieuMuon)
        {
            PhieuMuon pm = null;
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM phieu_muon WHERE id_phieumuon = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idPhieuMuon);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pm = new PhieuMuon
                            {
                                idPhieuMuon = reader.GetInt32("id_phieumuon"),
                                tgianMuon = reader.GetDateTime("tgian_muon"),
                                solg = reader.GetInt32("solg"),
                                ngMuon = reader.GetInt32("ngmuon"),
                                idNhanVien = reader.GetInt32("nvien")
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi nếu cần, hoặc throw lại nếu cần debug
                return null;
            }
            return pm;
        }



        //Lấy dánh sách phiếu mượn theo ngày
        public ArrayList GetListPhieuMuonHomNay()
        {
            ArrayList dspm = new ArrayList();
            using (MySqlConnection con = db.GetConnection())
            {
                con.Open();

                string sql = @"
            SELECT pm.* 
            FROM phieu_muon pm
            LEFT JOIN phieu_tra pt ON pm.id_phieumuon = pt.id_phieumuon
            WHERE pm.tgian_muon BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 1 DAY)
            AND pt.id_phieumuon IS NULL";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PhieuMuon pm = new PhieuMuon
                        {
                            idPhieuMuon = reader.GetInt32("id_phieumuon"),
                            tgianMuon = reader.GetDateTime("tgian_muon"),
                            solg = reader.GetInt32("solg"),
                            ngMuon = reader.GetInt32("ngmuon"),
                            idNhanVien = reader.GetInt32("nvien")
                        };
                        dspm.Add(pm);
                    }
                }
            }
            return dspm;
        }



        // Lấy phiếu mượn đầu tiên từ cơ sở dữ liệu
        public PhieuMuon GetPhieuMuonDauTien()
        {
            try
            {
                ArrayList list = GetListPhieuMuon();
                return list.Count > 0 ? (PhieuMuon)list[0] : null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
                return null;
            }
        }
        


        // Sửa
        public bool SuaPhieuMuon(int maPhieuMuon, DateTime tgianMuon, int soLuong, int ngMuon, int maNhanVien)
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE phieu_muon SET tgian_muon = @tgianMuon, solg = @soLuong, ngmuon = @ngMuon, nvien = @maNhanVien WHERE id_phieumuon = @maPhieuMuon";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    
                    cmd.Parameters.AddWithValue("@tgianMuon", tgianMuon);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@ngMuon", ngMuon);
                    cmd.Parameters.AddWithValue("@maNhanVien", maNhanVien);
                    cmd.Parameters.AddWithValue("@maPhieuMuon", maPhieuMuon);
                    
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật phiếu mượn: {ex.Message}");
                return false;
            }
        }

        // Xóa
        public bool XoaPhieuMuon(string maPhieuMuon)
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM phieu_muon WHERE id_phieumuon = @maPhieuMuon";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maPhieuMuon", maPhieuMuon);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa phiếu mượn: {ex.Message}");
                return false;
            }
        }

        // Xuất danh sách phiếu mượn ra file Excel
        public void ExportToExcel(string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("PhieuMuon");
                    
                    // Thêm header
                    worksheet.Cell(1, 1).Value = "Mã Phiếu Mượn";
                    worksheet.Cell(1, 2).Value = "Thời Gian Mượn";
                    worksheet.Cell(1, 3).Value = "Số Lượng";
                    worksheet.Cell(1, 4).Value = "Mã Người Mượn";
                    worksheet.Cell(1, 5).Value = "Mã Nhân Viên";

                    // Style cho header
                    var headerRange = worksheet.Range(1, 1, 1, 5);
                    headerRange.Style.Font.Bold = true;
                    headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
                    headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Lấy dữ liệu và thêm vào Excel
                    ArrayList listPhieuMuon = GetListPhieuMuon();
                    int row = 2;
                    foreach (PhieuMuon pm in listPhieuMuon)
                    {
                        worksheet.Cell(row, 1).Value = pm.idPhieuMuon;
                        worksheet.Cell(row, 2).Value = pm.tgianMuon.ToString("dd/MM/yyyy HH:mm:ss");
                        worksheet.Cell(row, 3).Value = pm.solg;
                        worksheet.Cell(row, 4).Value = pm.ngMuon;
                        worksheet.Cell(row, 5).Value = pm.idNhanVien;
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

        public void ExportToPDF(string filePath)
        {
            try
            {
                Document document = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Thêm tiêu đề
                Font titleFont = new Font(Font.FontFamily.HELVETICA, 16, Font.BOLD);
                Paragraph title = new Paragraph("DANH SÁCH PHIẾU MƯỢN", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f;
                document.Add(title);

                // Tạo bảng
                PdfPTable table = new PdfPTable(5);
                table.WidthPercentage = 100;

                // Thêm header
                string[] headers = { "Mã Phiếu Mượn", "Thời Gian Mượn", "Số Lượng", "Mã Người Mượn", "Mã Nhân Viên" };
                foreach (string header in headers)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(header));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.Padding = 5f;
                    table.AddCell(cell);
                }

                // Thêm dữ liệu
                ArrayList listPhieuMuon = GetListPhieuMuon();
                foreach (PhieuMuon pm in listPhieuMuon)
                {
                    table.AddCell(pm.idPhieuMuon.ToString());
                    table.AddCell(pm.tgianMuon.ToString("dd/MM/yyyy HH:mm:ss"));
                    table.AddCell(pm.solg.ToString());
                    table.AddCell(pm.ngMuon.ToString());
                    table.AddCell(pm.idNhanVien.ToString());
                }

                document.Add(table);
                document.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xuất PDF: " + ex.Message);
            }
        }

        // Lấy danh sách phiếu mượn 
        public ArrayList GetListPhieuMuon()
        {
            ArrayList dspm = new ArrayList();
            using (MySqlConnection con = db.GetConnection())
            {
                con.Open();
                string sql = "SELECT * FROM phieu_muon";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PhieuMuon pm = new PhieuMuon
                        {
                            idPhieuMuon = reader.GetInt32("id_phieumuon"),
                            tgianMuon = reader.GetDateTime("tgian_muon"),
                            solg = reader.GetInt32("solg"),
                            ngMuon = reader.GetInt32("ngmuon"),
                            idNhanVien = reader.GetInt32("nvien")
                        };
                        dspm.Add(pm);
                    }
                }
            }
            return dspm;
        }

        // Thêm phiếu mượn mới vào cơ sở dữ liệu
        public bool ThemPhieuMuon(int maPhieuMuon, DateTime tgianMuon, int soLuong, int ngMuon, int maNhanVien)
        {
            try
            {
                string sql = "INSERT INTO phieu_muon(id_phieumuon,tgian_muon,solg,ngmuon,nvien)" +
                    "VALUES (@maPhieuMuon,@tgianMuon,@soLuong,@ngMuon,@maNhanVien)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maPhieuMuon", maPhieuMuon);
                    cmd.Parameters.AddWithValue("@tgianMuon", tgianMuon);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@ngMuon", ngMuon);
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

        // Lấy danh sách chi tiết phiếu mượn từ cơ sở dữ liệu
        public ArrayList GetChiTietPhieuMuon(int maPhieuMuon)
        {
            ArrayList dsChiTiet = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = @"SELECT id_phieumuon, id_mondo 
                                  FROM chitiet_phieumuon 
                                  WHERE id_phieumuon = @maPhieuMuon";
                    
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@maPhieuMuon", maPhieuMuon);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dsChiTiet.Add(new
                            {
                                MaPhieuMuon = reader.GetInt32("id_phieumuon"),
                                MaMonDo = reader.GetString("id_mondo")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lấy chi tiết phiếu mượn: {ex.Message}");
            }
            return dsChiTiet;
        }

        // Lấy danh sách tất cả chi tiết phiếu mượn từ cơ sở dữ liệu
        public ArrayList GetAllChiTietPhieuMuon()
        {
            ArrayList dsChiTiet = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = @"SELECT c.id_phieumuon, c.id_mondo, p.tgian_muon, p.ngmuon, p.nvien
                                  FROM chitiet_phieumuon c
                                  JOIN phieu_muon p ON c.id_phieumuon = p.id_phieumuon
                                  ORDER BY c.id_phieumuon";
                    
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dsChiTiet.Add(new
                            {
                                MaPhieuMuon = reader.GetInt32("id_phieumuon"),
                                MaMonDo = reader.GetString("id_mondo"),
                                ThoiGianMuon = reader.GetDateTime("tgian_muon"),
                                NguoiMuon = reader.GetInt32("ngmuon"),
                                NhanVien = reader.GetInt32("nvien")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lấy danh sách chi tiết phiếu mượn: {ex.Message}");
            }
            return dsChiTiet;
        }

        // Lấy danh sách phân sách từ cơ sở dữ liệu
        public ArrayList GetListPhanSach()
        {
            ArrayList dsPhanSach = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT id_serisach, id_sach, status FROM sach_detail";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dsPhanSach.Add(new
                            {
                                IdSeriSach = reader.GetString("id_serisach"),
                                IdSach = reader.GetInt32("id_sach"),
                                Status = reader.GetInt32("status")
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lấy danh sách phân sách: {ex.Message}");
            }
            return dsPhanSach;
        }
    }
}
