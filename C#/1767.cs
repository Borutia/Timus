using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        struct Point {
            public long x, y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public static long intersectLine(long s1, long  s2, long  t1, long t2)
        {
            return s1 > t1 ? intersectLine(t1, t2, s1, s2) : Math.Min( s2 - t1, Math.Min(t2 - t1, s2 - s1) );
        }

        static Point[] input = new Point[4];

        public static long calc(bool opposite)
        {
            Point min_1;
            min_1.x = Math.Min(input[0].x, input[1].x);
            min_1.y = Math.Min(input[0].y, input[1].y);
            Point min_2;
            min_2.x = Math.Min(input[2].x, input[3].x);
            min_2.y = Math.Min(input[2].y, input[3].y);
            Point max_1;
            max_1.x = Math.Max(input[0].x, input[1].x);
            max_1.y = Math.Max(input[0].y, input[1].y);
            Point max_2;
            max_2.x = Math.Max(input[2].x, input[3].x);
            max_2.y = Math.Max(input[2].y, input[3].y);
            long l1 = intersectLine(min_1.x, max_1.x, min_2.x, max_2.x);
            long l2 = intersectLine(min_1.y, max_1.y, min_2.y, max_2.y);
            if (l1 < 0 || l2 < 0)
                return 0;
            return opposite ? Math.Max(l1, l2) : l1 + l2;
        }

        static void Main(string[] args)
        {
           
            for (int i = 0; i < 4; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                input[i].x = numbers[0];
                input[i].y = numbers[1];
            }
            long dys = (input[3].y - input[2].y)*(input[1].y - input[0].y);
	        long dxs = (input[3].x - input[2].x)*(input[1].x - input[0].x);

            Console.WriteLine(calc(dxs< 0 ? (dys > 0) : dys< 0));
        }
    }
}
