using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ZracniKoridor
    {
        string ime;
        int brojZrakoplova;
        Zrakoplov[] zrakoplovi = new Zrakoplov[20];
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
            }
        }
        public int BrojZrakoplova
        {
            get
            {
                return brojZrakoplova;
            }
            set
            {
                brojZrakoplova = value;
            }
        }
        public Zrakoplov[] listZrakoplova
        {
            get
            {
                return zrakoplovi;
            }
            set
            {
                zrakoplovi = value;
            }
        }
        public bool DodajZrakoplov(Zrakoplov zrakoplov)
        {
            if(brojZrakoplova >= 20)
            {
                return false;
            }
            for(int i = 0; i<zrakoplovi.Length; i++)
            {
                if (zrakoplovi[i].visina == zrakoplov.visina && zrakoplovi[i] != null)
                {
                    return false;
                }
            }
            for(int i = 0; i < zrakoplovi.Length; i++)
            {
                if(zrakoplovi[i] == null)
                {
                    zrakoplovi[i] = zrakoplov;
                    brojZrakoplova++;
                }
            }

            return true;
        }
        public bool UkloniZrakoplov(string reg)
        {
            for(int i = 0; i < zrakoplovi.Length; i++)
            {
                if(zrakoplovi[i].registracija == reg)
                { 
                    zrakoplovi[i] = null;
                    brojZrakoplova--;
                    return true;
                }
                
            }
            return true;
        }
        public void ispisiListuZrakoplova()
        {
            for (int i = 0; i < zrakoplovi.Length; i++)
            {
                Console.WriteLine("Zrakoplov broj " + i);
                Console.WriteLine("Registracija: " + zrakoplovi[i].registracija);
                Console.WriteLine("Destinacija: " + zrakoplovi[i].destinacija);
                Console.WriteLine("Visina: " + zrakoplovi[i].visina);
            }
        }

    }
}
