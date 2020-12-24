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
            int n = Convert.ToInt32(Console.ReadLine());
            double ans = Math.Log10(2) * (n - 1);
            if (n % 2 == 0)
            {
                ans += Math.Log10(2);
            }
            Console.WriteLine(Math.Floor(ans));
        }
    }
}
