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
            int maxn = 122;
            int r = -128;
            int[,] a = new int[maxn, maxn];
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; ++i)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                for (int j = 1; j <= n; ++j)
                {
                    a[i, j] = numbers[j-1];
                    if (a[i, j] <= 0 && r < a[i, j])
                        r = a[i, j];
                    a[i, j] += a[i, j - 1];
                }
            }

            for (int i = 1; i <= n; ++i)
                for (int j = 1; j <= n; ++j)
                    a[i, j] += a[i - 1, j];

            int tmp, ans = 0;
            for (int lef = 1; lef <= n; ++lef)
                for (int rig = lef; rig <= n; ++rig)
                    for (int up = 1; up <= n; ++up)
                        for (int dow = up; dow <= n; ++dow)
                        {
                            tmp = a[dow, rig] - a[dow, lef - 1] - a[up - 1, rig] + a[up - 1, lef - 1];
                            if (ans < tmp)
                                ans = tmp;
                        }

            if (ans == 0) ans = r;
            Console.WriteLine(ans);
        }
    }
}
