using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    public class Phong
    {
        public string MaPhong { get; set; }
        public int SoChoNgoi { get; set; }
        public string TinhTrang { get; set; }
        public int maPhong { get; set; }
        public int soLgChoNgoi { get; set; }
        public int trangThai { get; set; }

        public Phong() { }

        public Phong(int maPhong, int soLgChoNgoi, int trangThai)
        {
            this.maPhong = maPhong;
            this.soLgChoNgoi = soLgChoNgoi;
            this.trangThai = trangThai;
        }
    }
}
