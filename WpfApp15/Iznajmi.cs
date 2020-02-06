using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15
{
    public class Iznajmi
    {
        public int ID { set; get; }
        public Clanovi Iznajmio { set; get; }
        public Knjiga Knjiga { set; get; }
        public DateTime Vreme_iznajmljivanja { set; get; }
        public DateTime? Vreme_povratka { set; get; } = null;

        public Iznajmi() { }

        public Iznajmi(Clanovi i, Knjiga k, DateTime V_i)
        {
            Iznajmio = i;
            Knjiga = k;
            Vreme_iznajmljivanja = V_i;
            Vreme_povratka = null;
        }
    }


  
}
