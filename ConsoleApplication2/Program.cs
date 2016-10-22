using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string izborKoridoras;
            ZracniKoridor[] brojKoridora = new ZracniKoridor[3];

            ZracniKoridor iz = new ZracniKoridor();
            ZracniKoridor sj = new ZracniKoridor();
            ZracniKoridor oc = new ZracniKoridor();
            brojKoridora[0] = iz;
            brojKoridora[1] = sj;
            brojKoridora[2] = oc;

            do
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Zracni koridor broj 1: Istok-Zapad");
                Console.WriteLine("Zracni koridor broj 2" + " Sjever-Jug");
                Console.WriteLine("Zracni koridor broj 3" + " Prekooceanski");
                Console.WriteLine("Unesi broj koridora");
                Console.WriteLine("------------------------------------------");


                izborKoridoras = Console.ReadLine();

                int izbor = int.Parse(izborKoridoras) - 1;

                brojKoridora[izbor].ispisiListuZrakoplova();


            } while (true);
        }
    }
}
