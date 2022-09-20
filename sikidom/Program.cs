using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sikidom
{
    class Program
    {
        static void Main(string[] args)
        {
            Teglalap teglalap = new Teglalap();
            try
            {
                Console.Write($"A oldal: ");
                teglalap.AOldal = int.Parse(Console.ReadLine());
                Console.Write($"B oldal: ");
                teglalap.BOldal = int.Parse(Console.ReadLine());
            }
            catch(ArgumentOutOfRangeException ts)
            {
                Console.WriteLine(ts.Message);
            }

            Console.WriteLine($"Kerület:  {teglalap.Kerulet():N2}");
            Console.WriteLine($"Terület:  {teglalap.Terulet():N2}");
            Console.WriteLine();

            Kor asd = new Kor(6);
            Console.Write("Sugár: ");
            //asd.Sugar = int.Parse(Console.ReadLine());
            Console.Write("Átmérő: ");
            //asd.Atmero = 6;
            try
            {
                asd.Sugar = -3;
                Console.WriteLine($"\nKerület:  {asd.Kerulet():N2}");
                Console.WriteLine($"Terület:  {asd.Terulet():N2}");
                Console.WriteLine($"Átmérő: {asd.Atmero:N2}");
            }  
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
