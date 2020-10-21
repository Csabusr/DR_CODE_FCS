using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            char operatorr;
            int sum;
            double osztas;
            
            Console.WriteLine("-------------------SZÁMOLÓGÉP-------------------");
            Console.Write("Kérem az első számot: "); a = int.Parse(Console.ReadLine());
            Console.Write("Milyen operátort használjunk: "); operatorr = char.Parse(Console.ReadLine());
            Console.Write("Kérem az második számot: "); b = int.Parse(Console.ReadLine());

            if (operatorr == '+') { sum = a + b; Console.WriteLine("Eredmény: " + sum); }
            if (operatorr == '-') { sum = a - b; Console.WriteLine("Eredmény: " + sum); }
            if (operatorr == '*') { sum = a * b; Console.WriteLine("Eredmény: " + sum); }
            if (operatorr == '%') { sum = a % b; Console.WriteLine("Eredmény: " + sum); }
            if (operatorr == '/') { osztas = (float)a / (float)b; Console.WriteLine("Eredmény: " + osztas); }

            Console.ReadLine();
        }
    }
}
