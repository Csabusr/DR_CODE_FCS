using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alapok
{
    class Program
    {
        static void Main(string[] args)
        {
            //első programrészlet
            Console.WriteLine("Hellow world! uwu");
            //Console.Write("Üdv mi a neved: ");
            //string nev = Console.ReadLine();
            string nev = "Andris";
            Console.WriteLine("Hello kedves " + nev);
            //első programrészlet vége

            Console.WriteLine("_________________________________");
            Console.WriteLine();

            int a = 12;
            int b = 666;
            int c = a + b;

            Console.WriteLine(a + "+" + b + "=" + c + "\n");
            Console.Write("Kérem az első számot: "); a = int.Parse(Console.ReadLine());
            Console.Write("Kérem a második számot: "); b = int.Parse(Console.ReadLine());
            c = a + b;
            Console.Write("Eredmény: "+ c); 




            Console.ReadLine();
        }
    }
}
