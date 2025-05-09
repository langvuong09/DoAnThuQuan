using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    internal class CTPhieuNhap
    {
        public int idPhieuNhap {  get; set; }
        public int idSanPham { get; set; }
        public string loaiSanPham { get; set; }
        public int thanhTien {  get; set; }

        public CTPhieuNhap() { }

        public CTPhieuNhap(int idPhieuNhap, int idSanPham, string loaiSanPham, int thanhTien)
        {
            this.idPhieuNhap = idPhieuNhap;
            this.idSanPham = idSanPham;
            this.loaiSanPham = loaiSanPham;
            this.thanhTien = thanhTien;
        }
    }
}
