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
    internal class CTPhieuMuonDAO
    {
        private MyConnect db = new MyConnect();

        public ArrayList GetListCTPMByIdPhieuMuon(int idPhieuMuon)
        {
            ArrayList dsctpm = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM chitiet_phieumuon WHERE id_phieumuon = @idPhieuMuon";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idPhieuMuon", idPhieuMuon);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        chitiet_phieumuon ctpm = new chitiet_phieumuon
                        {
                            id_phieumuon = reader.GetInt32(0),
                            id_mondo = reader.GetString(1),
                        };
                        dsctpm.Add(ctpm);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dsctpm;
        }


        public ArrayList GetListCTPM()
        {
            ArrayList dsctpm = new ArrayList();
            try
            {
                using (MySqlConnection con = db.GetConnection())
                {
                    con.Open();
                    string sql = "SELECT * FROM chitiet_phieumuon";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        chitiet_phieumuon ctpm = new chitiet_phieumuon
                        {
                            id_phieumuon = reader.GetInt32(0),
                            id_mondo = reader.GetString(1),
                        };
                        dsctpm.Add(ctpm);
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dsctpm;
        }

        // Thêm
        public bool ThemCTPM(int maPM, string maThietBi)
        {
            try
            {
                string sql = "INSERT INTO chitiet_phieumuon(id_phieumuon, id_mondo)" +
                    "VALUES (@maPM, @maThietBi)";
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@maPM", maPM);
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
        public bool XoaCTPM(int maPM)
        {
            try
            {
                string sql = "DELETE FROM chitiet_phieumuon WHERE id_phieumuon = @maPM";

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maPM", maPM);
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
