using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_ve_Override
{
    class personel
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime Dogum_Tarihi { get; set; }

        public override string ToString()
        {
            return string.Format("Bilgiler: {0}-{1}-{2}", Adi, Soyadi, Dogum_Tarihi);
        }
    }
}
