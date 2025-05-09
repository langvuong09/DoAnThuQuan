using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThuQuan.QuanLyThuQuan.DTO
{
    internal class CTPhieuTra
    {
        public int idPhieuTra {  get; set; }
        public string idMonDo { get; set; }

        public CTPhieuTra() { }

        public CTPhieuTra(int idPhieuTra, string idMonDo)
        {
            this.idPhieuTra = idPhieuTra;
            this.idMonDo = idMonDo;
        }
    }
}
