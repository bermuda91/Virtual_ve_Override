using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_ve_Override
{
    class insan
    {
        public string Adı { get; set; }
        public string Kimlik { get; set; }
        public Ten_Rengi Ten { get; set; }

        public virtual string Mesajver()
        {
            return "Beslenir,Giyinir,Yaşar";
        }

    }

    enum Ten_Rengi
    {
        Sarışın,
        Kumral,
        Esmer,
        Zenci
    }
}
