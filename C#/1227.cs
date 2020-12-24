using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static int num_of_cities;
        public static int path_length;
        public static int[,] graph = new int[100,100];
        public static bool[] visited = new bool[100];

        public static void dfs(int vertex, int length)
        {
            if (visited[vertex] || length >= path_length)
            {
                Console.WriteLine("YES");
                Environment.Exit(0);
            }

            visited[vertex] = true;
            for (int i = 0; i < num_of_cities; ++i)
            {
                int value = graph[vertex,i];
                if (value != 0)
                {
                    graph[i,vertex] = 0;
                    dfs(i, length + value);
                    graph[i,vertex] = value;
                }
            }
        }

        public static void solve()
        {
            for (int i = 0; i < num_of_cities; ++i)
            {
                for (int j = 0; j < num_of_cities; ++j)
                    visited[j] = false;
                dfs(i, 0);
            }
        }

        static void Main(string[] args)
        {
            int n;
            int[] numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            num_of_cities = numbers[0];
            n = numbers[1];
            path_length = numbers[2];

            for (int i = 0; i < num_of_cities; ++i)
            {
                for (int j = 0; j < num_of_cities; ++j)
                {
                    graph[i,j] = 0;
                }
            }

            for (int i = 0; i < n; ++i)
            {
                int p, q, r;
                numbers = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
                p = numbers[0];
                q = numbers[1];
                r = numbers[2];
                --p;
                --q;
                if (graph[p,q] != 0 || graph[q,p] != 0)
                {
                    Console.WriteLine("YES");
                    Environment.Exit(0);
                }
                graph[p,q] = r;
                graph[q,p] = r;
            }

            solve();
            Console.WriteLine("NO");

           
        }
    }
}
