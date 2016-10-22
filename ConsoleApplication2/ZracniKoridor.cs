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
                if (zrakoplovi[i]!=null && zrakoplovi[i].visina == zrakoplov.visina)
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
                    return true;
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
            return false;
        }
        public void ispisiListuZrakoplova()
        {
            for (int i = 0; i < zrakoplovi.Length; i++)
            {
                if (zrakoplovi[i] != null)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Zrakoplov broj " + (i + 1));
                    Console.WriteLine("Registracija: " + zrakoplovi[i].registracija);
                    Console.WriteLine("Destinacija: " + zrakoplovi[i].destinacija);
                    Console.WriteLine("Visina: " + zrakoplovi[i].visina);
                    Console.WriteLine("------------------------------------------");
                }
            }
        }

        public Zrakoplov UnesiSvojstva()
        {
            Console.WriteLine("Unesi registraciju zrakoplova");
            string reg = Console.ReadLine();
            Console.WriteLine("Unesi destinaciju zrakoplova");
            string dest = Console.ReadLine();
            Console.WriteLine("Unesi visinu zrakoplova");
            int vis = int.Parse(Console.ReadLine());
            Zrakoplov zrakoplov = new Zrakoplov(reg, dest, vis);
            return zrakoplov;
        }

        public void Menu()
        {
            
            do
            {
                ispisiListuZrakoplova();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Za unos zrakoplova upisite 1");
                Console.WriteLine("Za brisanje zrakoplova upisite 2");
                Console.WriteLine("Za izlazak u glavni menu upisite 3");
                Console.WriteLine("------------------------------------------");

                string unos = Console.ReadLine();

                if(unos == "1")
                {
                    Zrakoplov uneseniZrakoplov = UnesiSvojstva();
                    bool uspjesno = DodajZrakoplov(uneseniZrakoplov);
                    if (!uspjesno)
                    {
                        Console.WriteLine("Unos nije moguc");
                    }
                    else
                    {
                        Console.WriteLine("Zrakoplov dodan");
                    }
                }
                if (unos == "2") 
                {
                    Console.WriteLine("Unesite registraciju");
                    string registracija = Console.ReadLine();
                    bool uspjesno = UkloniZrakoplov(registracija);
                    if (!uspjesno)
                    {
                        Console.WriteLine("Uklonjanje nije uspjesno");
                    }
                    else
                    {
                        Console.WriteLine("Uklanjanje uspjesno");
                    }
                }
                if (unos == "3") break;

            } while (true);
        }
        
    }
}
