using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuvien.DTO
{
    internal class Chitiet_phathudo
    {
        public int id_phieuphatHuDo { get; set; }
        public int tien { get; set; }
        public string id_mondo { get; set; }
        public string mota { get; set; }
        public Chitiet_phathudo() { }
        public Chitiet_phathudo(int id_phieuphatHuDo, int tien, string id_mondo, string mota)           
        {
            this.id_phieuphatHuDo = id_phieuphatHuDo;
            this.tien = tien;
            this.id_mondo = id_mondo;
            this.mota = mota;
        }
    }
}
