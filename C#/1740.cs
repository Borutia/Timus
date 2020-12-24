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
            int ans = 0;
            string test = Console.ReadLine();
            string[] splitString = test.Split(' ');
            int l;
            int.TryParse(splitString[0], out l);
            int k;
            int.TryParse(splitString[1], out k);
            int h;
            int.TryParse(splitString[2], out h);
            while (l >= k)
            {
                l -= k;
                ans += h;
            }
            Console.WriteLine("{0:f8} {1:f8}", Convert.ToDouble(ans), l > 0 ? Convert.ToDouble(ans + h) : Convert.ToDouble(ans));
        }
    }
}
