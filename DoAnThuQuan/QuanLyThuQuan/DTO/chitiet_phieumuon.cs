using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuvien.DTO
{
    internal class chitiet_phieumuon
    {
        public int id_phieumuon {  get; set; }
        public string id_mondo { get; set; }
        public chitiet_phieumuon() { }
        public chitiet_phieumuon(int id_phieumuon, string id_mondo)
        {
            this.id_phieumuon = id_phieumuon;
            this.id_mondo = id_mondo;
        }
    }
}
