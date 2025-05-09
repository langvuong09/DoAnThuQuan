using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    public class SachDetail
    {
        public string maDauSach {  get; set; }
        public int maSach { get; set; }
        public int trangThai {  get; set; }

        public SachDetail() { }

        public SachDetail(string maDauSach, int maSach, int trangThai)
        {
            this.maDauSach = maDauSach;
            this.maSach = maSach;
            this.trangThai = trangThai;
        }
    }
}
