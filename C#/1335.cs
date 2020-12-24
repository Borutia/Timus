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
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine((n * n).ToString() + " " + (n * n + n + 1).ToString() + " " + (n * n + 1).ToString());
        }
    }
}
