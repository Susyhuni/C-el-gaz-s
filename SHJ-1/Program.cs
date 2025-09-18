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
            
            

        }
    }
}
