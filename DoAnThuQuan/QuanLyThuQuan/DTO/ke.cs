using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuvien.DTO
{
    internal class ke
    {
        public int id_ke { get; set; }
        public int id_khuvuc { get; set; }
        public ke() { }
        public ke(int id_ke, int id_khuvuc)
        {
            this.id_ke = id_ke;
            this.id_khuvuc = id_khuvuc;
        }
    }
}
