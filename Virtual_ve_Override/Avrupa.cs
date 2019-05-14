using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_ve_Override
{
    class Avrupa:insan
    {
        public string Refah_Seviyesi { get; set; }
        public int Milli_Gelir { get; set; }

        public override string Mesajver()
        {
            return "Gezer, harcama yapar";
        }
    }
}
