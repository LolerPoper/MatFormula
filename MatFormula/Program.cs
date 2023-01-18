using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatFormula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 23.5, b = 12.8, c = 67, d = 10.543;
            double x = (2 * a + 2 * b + 2 * c + 2 * d) / (2 * (a + b) + 2 * (c + d));

            Console.WriteLine(x);
            
            Console.ReadKey();
        }
    }
}
