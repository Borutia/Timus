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
            char[,] arr = new char[1003,1003];
            int i, j;
            int n = Convert.ToInt32(Console.ReadLine());

            int w = 0, b = 0;
            for (i = 0; i < n; i++)
            {
                string ch = Console.ReadLine();
                for (j = 0; j < n; j++)
                {
                    arr[i, j] = Convert.ToChar(ch[j]);
                    if (arr[i, j] == '0') w++;
                    else b++;
                }
            }
            int ww;

            ww = 0;
            for (i = 0; i < n; i++)
            {
                if (arr[i,0] == '0')
                    for (j = 0; j < n; j++)
                    {
                        if (arr[i,j] == '0') ww++;
                        else break;
                    }
            }
            if (ww == w)
            {
                Console.WriteLine("Yes");
                Environment.Exit(0);
            }

            ww = 0;
            for (i = 0; i < n; i++)
            {
                if (arr[i,n - 1] == '0')
                    for (j = n - 1; j >= 0; j--)
                    {
                        if (arr[i,j] == '0') ww++;
                        else break;
                    }
            }
            if (ww == w)
            {
                Console.WriteLine("Yes");
                Environment.Exit(0);
            }

            ww = 0;
            for (j = 0; j < n; j++)
            {
                if (arr[0,j] == '0')
                    for (i = 0; i < n; i++)
                    {
                        if (arr[i,j] == '0') ww++;
                        else break;
                    }
            }
            if (ww == w)
            {
                Console.WriteLine("Yes");
                Environment.Exit(0);
            }

            ww = 0;
            for (j = 0; j < n; j++)
            {
                if (arr[n - 1,j] == '0')
                    for (i = n - 1; i >= 0; i--)
                    {
                        if (arr[i,j] == '0') ww++;
                        else break;
                    }
            }
            if (ww == w)
            {
                Console.WriteLine("Yes");
                Environment.Exit(0);
            }

            Console.WriteLine("No");
        }
    }
}
