using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_ve_Override
{
    class Amerika:insan
    {
        public int Para_Kazanma_Seviyesi { get; set; }
        public override string Mesajver()
        {
            return "dünyanın en güçlü ülkesinde güvende yaşar";
        }
    }
}
