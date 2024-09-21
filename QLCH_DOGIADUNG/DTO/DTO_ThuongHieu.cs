using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ThuongHieu
    {
        public string MATH { get; set; }
        public string TENTH { get; set; }
   


        public DTO_ThuongHieu(string ma, string ten)
        {
            this.MATH = ma;

            this.TENTH = ten;
           
        }

    }
}
