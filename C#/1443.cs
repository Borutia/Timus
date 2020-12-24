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
            int N = Convert.ToInt32(Console.ReadLine());
            double s = Convert.ToDouble(Console.ReadLine()); ;
            double l = Convert.ToDouble(Console.ReadLine());

            int S = Convert.ToInt32((s + 1e-8) * 10000);
            int L = Convert.ToInt32((l + 1e-8) * 10000);

            if(S % L != 0)
            {
                if(N % (L / (S % L)) != 0)
                    Console.WriteLine(S / L * N + N / (L / (S % L)) + 1);
                else
                    Console.WriteLine(S / L * N + N / (L / (S % L)));
            }
            else
            {
                Console.WriteLine(S / L * N);
            }
        }
    }
}
