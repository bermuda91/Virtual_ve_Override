using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_ve_Override
{
    class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public List<Ders> Dersler { get; set; }

        public Ogrenci()
        {
            Dersler = new List<Ders>();
        }

    }

    struct Ders
    {
        public string Adi { get; set; }
        public decimal Vize { get; set; }
        public decimal Final { get; set; }
    }
}
