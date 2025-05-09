using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    internal class Sach
    {
        public int maSach {  get; set; }
        public string tenSach { get; set; }
        public string moTa {  get; set; }
        public int theLoai { get; set; }
        public string tacGia {  get; set; }
        public int trangThai {  get; set; }
        public int maKe {  get; set; }
        public int thanhTien {  get; set; }

        public Sach() { }

        public Sach(int maSach, string tenSach, int theLoai, string tacGia, int maKe, string moTa, int thanhTien, int trangThai)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.theLoai = theLoai;
            this.tacGia = tacGia;
            this.maKe = maKe;
            this.moTa = moTa;
            this.thanhTien = thanhTien;
            this.trangThai = trangThai;
        }
    }
}
