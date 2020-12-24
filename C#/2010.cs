using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static int king(int N, int row, int col)
        {
            int answer = 0;

            for (int dr = -1; dr <= 1; dr++)
                for (int dc = -1; dc <= 1; dc++)
                    if (!(dr == 0 && dc == 0))
                        if (row + dr > 0 && row + dr <= N && col + dc > 0 && col + dc <= N)
                            answer++;

            return answer;
        }

        public static int knight(int N, int row, int col)
        {
            int answer = 0;

            for (int dr = -1; dr <= 1; dr += 2)
                for (int dc = -1; dc <= 1; dc += 2)
                {
                    if (row + dr * 2 > 0 && row + dr * 2 <= N && col + dc > 0 && col + dc <= N)
                        answer++;
                    if (row + dr > 0 && row + dr <= N && col + dc * 2 > 0 && col + dc * 2 <= N)
                        answer++;
                }

            return answer;
        }

        public static int bishop(int N, int row, int col)
        {
            int answer = 0;

            answer += Math.Min(N - row, col - 1);
            answer += Math.Min(N - col, row - 1);
            answer += Math.Min(N - col, N - row);
            answer += Math.Min(col - 1, row - 1);

            return answer;
        }

        public static int rook(int N, int row, int col)
        {
            return 2 * (N - 1);
        }

        public static int queen(int N, int row, int col)
        {
            return bishop(N, row, col) + rook(N, row, col);
        }

        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            var s = Console.ReadLine().Split();
            int row = (int)(double.Parse(s[0]));
            int col = (int)(double.Parse(s[1]));
            Console.WriteLine("King: " + king(N, row, col));
            Console.WriteLine("Knight: " + knight(N, row, col));
            Console.WriteLine("Bishop: " + bishop(N, row, col));
            Console.WriteLine("Rook: " + rook(N, row, col));
            Console.WriteLine("Queen: " + queen(N, row, col));
        }
    }
}
