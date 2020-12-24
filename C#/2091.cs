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
            const int maxn = 100, maxm = 100;

            bool[,] A = new bool[maxn,maxm];

            int n, m, min = 101;
            int[] numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            n = numbers[0];
            m = numbers[1];

            for (int i = 0; i < n; i++)
            {
                numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                for (int j = 0; j < m; j++)
                    A[i,j] = Convert.ToBoolean(numbers[j]);
            }
               

            int max_i = 0, max_j = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    int[] g = { 0, 0, 0, 0 };
                    for (int k = 0; k < n; k++)
                    {
                        g[0] += Convert.ToInt32(A[k,i] && A[k,j]);
                        g[1] += Convert.ToInt32(A[k,i] && !A[k,j]);
                        g[2] += Convert.ToInt32(!A[k,i] && A[k,j]);
                        g[3] += Convert.ToInt32(!A[k,i] && !A[k,j]);
                    }
                    if (g.Max<int>() < min)
                    {
                        min = g.Max<int>();
                        max_i = i;
                        max_j = j;
                    }
                }
            }
            Console.WriteLine(min + "\n" + (max_i + 1) + " " + (max_j + 1));
        }
    }
}
