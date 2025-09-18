using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHJ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy egész számot");
            int szam = int.Parse(Console.ReadLine());
            if (szam %2 ==0 )
            {
                Console.WriteLine("Ez a szám páros");
            }
            else
            {
                Console.WriteLine("Ez a szám páratlan");
            }
            Console.WriteLine("Adjon meg egy egész számot");
            int szam2 = int.Parse(Console.ReadLine());
            if (szam2 < 0)
            {
                Console.WriteLine("Ez a szám negatív");
            }
            else if (szam2 > 0)
            {
                Console.WriteLine("Ez a szám pozitív");
            }
            else { Console.WriteLine("A szám nulla"); }


            Console.WriteLine("Kérem adja meg a hónap számát (1-12):");
            int honap = int.Parse(Console.ReadLine());
            string evszak;
            if (honap >= 1 && honap <= 12)
            {
                if (honap == 12 || honap == 1 || honap == 2)
                    evszak = "Tél";
                else if (honap >= 3 && honap <= 5)
                    evszak = "Tavasz";
                else if (honap >= 6 && honap <= 8)
                    evszak = "Nyár";
                else
                    evszak = "Ősz";

                Console.WriteLine($"A {honap}. hónap az {evszak} évszakhoz tartozik.");
            }
            else
            {
                Console.WriteLine("Hibás hónapszámot adott meg. Kérem, 1 és 12 között válasszon.");
            }

            Console.WriteLine("Adja meg, hány éves");
            int szam4 = int.Parse(Console.ReadLine());
            if (szam4 > 18)
            { Console.WriteLine("Szavazhatsz!"); }
            else { Console.WriteLine("nem szavazhatsz még!"); }

            int jegy;

            do
            {
                Console.WriteLine("Adjon meg egy jegyet(1-5)");
                jegy = int.Parse(Console.ReadLine());

                if(jegy < 1 || jegy > 5)
                {
                    Console.WriteLine("Nem létező jegyet  adott meg. Kérem, 1 és 5 között válasszon.");
                }


               
            } while (jegy<1 || jegy>5);

            if (jegy >= 1 && jegy <= 5)
            {
                if (jegy >= 1 && jegy <= 2)
                    Console.WriteLine("elégtelen");
                else if (jegy == 3)
                    Console.WriteLine("közepes");
                else
                    Console.WriteLine("Jeles");
            }


            int tárolt = 15;
            int tipp;

                Console.WriteLine("Próbáld meg kitalálni a számom");
            while (true)
            {
                Console.Write("Add meg a tipped: ");
                if (!int.TryParse(Console.ReadLine(), out tipp))
                {
                    Console.WriteLine("Számot adj meg");
                    continue;
                }

                if (tipp < tárolt)
                    Console.WriteLine("A titkos szám nagyobb.");
                else if (tipp > tárolt)
                    Console.WriteLine("A titkos szám kisebb.");
                else
                {
                    Console.WriteLine("Gratulálok, eltaláltad!");
                    break;
                }
            }
                Console.WriteLine("Adjon meg egy egész számot");
                int szam6 = int.Parse(Console.ReadLine());
                if (szam6 % 2 == 0 && szam6 > 0) { Console.WriteLine("ez egy pozitív páros szám"); }
                else { Console.WriteLine("A szám nem pozitív páros"); }

            Console.WriteLine("Adjon meg egy betűt vagy számot");
            var valami =Console.ReadLine();
            if (char.IsNumber(valami[0]))
            {
                Console.WriteLine("Ez egy szám");
            }
            else if (char.IsLetter(valami[0]))
            {
                Console.WriteLine("Ez egy betű");
            }
            else
            {
                Console.WriteLine("Külenleges karaktert adott meg");
            }
            string Jelszo = "titok123";
            string felJelszo;
            while (true)
            {
                Console.Write("Add meg a jelszót: ");
                felJelszo = Console.ReadLine();

                if (felJelszo == Jelszo)
                {
                    Console.WriteLine("Hozzáférés engedélyezve!");
                    break;
                }
                else
                {
                    Console.WriteLine("Próbáld újra.");
                }
            }
        }
    }
}
