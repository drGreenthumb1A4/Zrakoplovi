using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Zrakoplov
    {
        public string registracija;
        public string destinacija;
        public int visina;
        public Zrakoplov(string reg, string dest, int vis)
        {
            registracija = reg;
            destinacija = dest;
            visina = vis;
        }
    }
}
