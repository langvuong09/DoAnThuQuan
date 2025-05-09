using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    internal class TheLoaiSach
    {
        public int maTheLoai {  get; set; }
        public string tenTheLoai { get; set; }

        public TheLoaiSach() { }

        public TheLoaiSach(int maTheLoai, string tenTheLoai)
        {
            this.maTheLoai = maTheLoai;
            this.tenTheLoai = tenTheLoai;
        }
    }
}
