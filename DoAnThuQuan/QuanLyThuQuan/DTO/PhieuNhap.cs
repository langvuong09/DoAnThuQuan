using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    internal class PhieuNhap
    {
        public int idPhieuNhap {  get; set; }
        public DateTime ngayNhap { get; set; }
        public int idNhanVien { get; set; }
        public int slSach {  get; set; }
        public int slMayTinh { get; set; }
        public int slMayChieu { get; set; }
        public int tongTien {  get; set; }

        public PhieuNhap() { }

        public PhieuNhap (int idPhieuNhap, DateTime ngayNhap, int idNhanVien, int slSach, int slMayTinh, int slMayChieu, int tongTien)
        {
            this.idPhieuNhap = idPhieuNhap;
            this.ngayNhap = ngayNhap;
            this.idNhanVien = idNhanVien;
            this.slSach = slSach;
            this.slMayTinh = slMayTinh;
            this.slMayChieu = slMayChieu;
            this.tongTien = tongTien;
        }
    }
}
