using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static char[] str = {'a','b','a','b','b','a'};

        public static StringBuilder repeat(int p, int n)
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < n;)
            {
                for (int j = 0; j < p && i < n; i++, j++)
                    s.Append('a');
                for (int j = 0; j < 6 && i < n; i++, j++)
                    s.Append(str[j]);
            }
            return s;
        }

        public static string print(int n, int k)
        {
            if (n == 8 && k == 7)
                return "aababbaa";
            if (n != k && k < 8)
                return "NO";
            if (k <= (n - 6) / 2 + 6)
                return "a" + repeat(k - 8, n - 1);
            return repeat(k - 6, n).ToString();
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int k = 1; k <= n; k++)
                Console.WriteLine(k + " : " + print(n,k));
        }
    }
}
