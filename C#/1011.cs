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

            const int c = 100000;
            double p, q;
            var s = Console.ReadLine().Split();
            int n = (int)(double.Parse(s[0]) * 1000);
            int m = (int)(double.Parse(s[1]) * 1000);
            long x = 0;
            while (n * x / c == m * x / c || (n * x / c) * c == n * x || (m * x / c) * c == m * x)
                x++;
            Console.WriteLine(x);

        }
    }
}
