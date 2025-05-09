using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuvien.DTO
{
    internal class cho_ngoi
    {
        public int id_chongoi {  get; set; } 
        public int id_phong { get; set; }
        public int status {  get; set; }  
        public int vi_tri {  get; set; }
        public int so_luong { get; set; }

        public cho_ngoi() { }
        public cho_ngoi(int id_chongoi, int id_phong, int status, int vi_tri, int so_luong)
        {
            this.id_chongoi = id_chongoi;
            this.id_phong = id_phong;
            this.status = status;
            this.vi_tri = vi_tri;
            this.so_luong = so_luong;
        }
    }
}
