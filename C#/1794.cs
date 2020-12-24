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
            int best = 0, position = 0;
            int[] student_order = new int[100001];
            int[] present_order = new int[100001];
            int N = Convert.ToInt32(Console.ReadLine());

            int[] numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

            for (int i = 0; i < N; i++)
                student_order[i] = numbers[i];

            for (int i = 0; i < N; i++)
                present_order[((i - student_order[i] + 1) % N + N) % N]++;

            for (int i = 0; i < N; i++)
                if (present_order[i] > best)
                {
                    best = present_order[i];
                    position = i;
                }

            Console.WriteLine(position+1);
        }
    }
}
