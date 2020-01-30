using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15
{
    public class Knjiga
    {
        public string ISBN { set; get; }
        public string Naziv { set; get; }
        public string Autor { set; get; }
        public string Godina { set; get; }
        public string Izdavanje { set; get; }


        public Knjiga()
        {

        }

        public Knjiga(string isb, string n, string a, string g, string i)
        {
            ISBN = isb;
            Naziv = n;
            Autor = a;
            Godina = g;
            Izdavanje = i;
        }
    }
}
