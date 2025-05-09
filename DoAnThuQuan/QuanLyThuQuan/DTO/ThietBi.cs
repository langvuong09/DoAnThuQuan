using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    internal class ThietBi
    {
        public int maThietbi { get; set; }
        public string tenThietBi { get; set; }
        public int soLuong {  get; set; }
        public int trangThai { get; set; }

        public ThietBi() { 
        }

        public ThietBi(int maThietbi, string tenThietBi, int soLuong, int trangThai)
        {
            this.maThietbi = maThietbi;
            this.tenThietBi = tenThietBi;
            this.soLuong = soLuong;
            this.trangThai = trangThai;
        }
    }
}
