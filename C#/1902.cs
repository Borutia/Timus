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
            string test = Console.ReadLine();
            string[] splitString = test.Split(' ');
            int n;
            int.TryParse(splitString[0], out n);
            double t;
            double.TryParse(splitString[1], out t);
            double s;
            double.TryParse(splitString[2], out s);
            double y, x;
            test = Console.ReadLine();
            string[] splitString2 = test.Split(' ');

            for (int i = 0; i < n; i++)
            {
                double.TryParse(splitString2[i], out x);
                y = (t + s + x) / 2;
                Console.WriteLine("{0:f6}\n", y);
            }
        }
    }
}
