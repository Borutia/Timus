using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        const int MAX = 129;
        public static long[,,] ufos = new long[MAX,MAX,MAX];
        public static int m;
        public static void update(int x, int y, int z, long v)
        {
            x++; y++; z++;
            for (int xi = x; xi <= m; xi += xi & -xi)
                for (int yi = y; yi <= m; yi += yi & -yi)
                    for (int zi = z; zi <= m; zi += zi & -zi)
                        ufos[xi,yi,zi] += v;
        }

        public static long query(int x, int y, int z)
        {
            long sum = 0;
            for (int xi = x; xi > 0; xi -= xi & -xi)
                for (int yi = y; yi > 0; yi -= yi & -yi)
                    for (int zi = z; zi > 0; zi -= zi & -zi)
                        sum += ufos[xi,yi,zi];
            return sum;
        }

        public static long query(int xmin, int xmax, int ymin, int ymax, int zmin, int zmax)
        {
            xmax++; ymax++; zmax++;
            return query(xmax, ymax, zmax)
                 - query(xmin, ymax, zmax)
                 - query(xmax, ymin, zmax)
                 + query(xmin, ymin, zmax)
                 - query(xmax, ymax, zmin)
                 + query(xmin, ymax, zmin)
                 + query(xmax, ymin, zmin)
                 - query(xmin, ymin, zmin);
        }

        static void Main(string[] args)
        {
            m = Convert.ToInt32(Console.ReadLine());
            int t, xmin, xmax, ymin, ymax, zmin, zmax;
            long v;
            for(;;)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                t = numbers[0];
                if (t == 3)
                    break;
                if (t == 2)
                {
                    xmin = numbers[1];
                    ymin = numbers[2];
                    zmin = numbers[3];
                    xmax = numbers[4];
                    ymax = numbers[5];
                    zmax = numbers[6];
                    Console.WriteLine(query(xmin, xmax, ymin, ymax, zmin, zmax));
                }
                else
                {
                    xmin = numbers[1];
                    ymin = numbers[2];
                    zmin = numbers[3];
                    v = numbers[4];
                    update(xmin, ymin, zmin, v);
                }
            }
        }
    }
}
