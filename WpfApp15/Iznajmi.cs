using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15
{
    public class Iznajmi
    {
        public int ID_iznajmio { set; get; }
        public Clanovi Iznajmio { set; get; }
        public Knjiga Knjiga { set; get; }
        public DateTime Vreme_iznajmljivanja { set; get; }
        public DateTime? Vreme_povratka { set; get; } = null;

        public Iznajmi() { }

        public Iznajmi(Clanovi i, Knjiga k, DateTime v_i)
        {
            Iznajmio = i;
            Knjiga = k;
            Vreme_iznajmljivanja = v_i;

            TimeSpan vrati = new TimeSpan(7, 0, 0, 0);
            Vreme_povratka = Vreme_iznajmljivanja + vrati;


        }
    }


  
}
