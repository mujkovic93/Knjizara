using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15
{
    public class Clanovi
    {

        public int ID { set; get; }
        public string Ime { set; get; }
        public string Prezime { set; get; }
        public string Mail { set; get; }
        public string Adresa_stanovanja { set; get; }

        public Clanovi() { }

        public Clanovi(string i, string p, string m, string a_s)
        {
            Ime = i;
            Prezime = p;
            Mail = m;
            Adresa_stanovanja = a_s;
        }

    }
}
