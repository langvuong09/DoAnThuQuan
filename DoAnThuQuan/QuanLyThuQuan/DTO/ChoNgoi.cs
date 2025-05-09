using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    public class ChoNgoi
    {
        public string MaChoNgoi { get; set; }
        public string MaPhong { get; set; }
        public string ViTri { get; set; }
        public int SoLuong { get; set; }
        public string TrangThai { get; set; }
        public int idChoNgoi { get; set; }
        public int idPhong { get; set; }
        public int viTri { get; set; }
        public int soLuong { get; set; }
        public int status { get; set; }

        public ChoNgoi() { }

        public ChoNgoi(int idChoNgoi, int idPhong, int status, int viTri, int soLuong)
        {
            this.idChoNgoi = idChoNgoi;
            this.idPhong = idPhong;
            this.status = status;
            this.viTri = viTri;
            this.soLuong = soLuong;
        }
    }
} 