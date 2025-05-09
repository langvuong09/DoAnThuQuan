using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuvien.DTO
{
    internal class Check_in_out
    {
        public int user_id {  get; set; }  
        public DateTime time_in { get; set; }
        public DateTime time_out { get; set; }
        public Check_in_out() { }
        public Check_in_out(int user_id, DateTime time_in, DateTime time_out)
        {
            this.user_id = user_id;
            this.time_in = time_in;
            this.time_out = time_out;
        }
    }
}
