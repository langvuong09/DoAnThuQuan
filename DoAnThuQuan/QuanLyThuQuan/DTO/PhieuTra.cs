using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    public class PhieuTra
    {
        public int maPhieuTra {  get; set; }
        public DateTime thoiGianTra { get; set; }
        public int maPhieuMuon {  get; set; }
        public string moTa {  get; set; }
        public int maNhanVien {  get; set; }

        public PhieuTra() { 
        }

        public PhieuTra(int maPhieuTra, DateTime thoiGianTra, int maPhieuMuon, string moTa, int maNhanVien)
        {
            this.maPhieuTra = maPhieuTra;
            this.thoiGianTra = thoiGianTra;
            this.maPhieuMuon = maPhieuMuon;
            this.moTa = moTa;
            this.maNhanVien = maNhanVien;
        }
    }
}
