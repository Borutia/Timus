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
            int ans = 0;
            int now = 0;
            int ch;
            while ((ch = Console.Read()) != -1)
            {
                if (now == 0)
                {
                    if ('a' <= Convert.ToChar(ch) && Convert.ToChar(ch) <= 'z') ++ans;
                    if (('a' <= Convert.ToChar(ch) && Convert.ToChar(ch) <= 'z') || ('A' <= Convert.ToChar(ch) && Convert.ToChar(ch) <= 'Z')) now = 1;
                }
                else
                if (now == 1)
                {
                    if ('A' <= Convert.ToChar(ch) && Convert.ToChar(ch) <= 'Z') ++ans;
                    if (!(('a' <= Convert.ToChar(ch) && Convert.ToChar(ch) <= 'z') || ('A' <= Convert.ToChar(ch) && Convert.ToChar(ch) <= 'Z')))
                    {
                        if (Convert.ToChar(ch) == '?' || Convert.ToChar(ch) == '.' || Convert.ToChar(ch) == '!') now = 0;
                        else now = 2;
                    }
                }
                else if (now == 2)
                {
                    if (('a' <= Convert.ToChar(ch) && Convert.ToChar(ch) <= 'z') || ('A' <= Convert.ToChar(ch) && Convert.ToChar(ch) <= 'Z')) now = 1;
                    if (Convert.ToChar(ch) == '?' || Convert.ToChar(ch) == '.' || Convert.ToChar(ch) == '!') now = 0;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
