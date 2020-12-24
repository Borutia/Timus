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
            double Pa, Pb, Total, Max;
            long A, B, Opta, Optb;

            double[] numbers = Console.ReadLine().Split(' ').Select(s => double.Parse(s)).ToArray();
            Pa = numbers[0];
            Pb = numbers[1];
            int K = Convert.ToInt32(Console.ReadLine());

            Opta = 0;
            Optb = 0;
            Max = 0;

            for (A = 0; A <= K; A++)
                for (B = 0; B <= K - A; B++)
                {
                    Total = A * Pa + B * Pb - A * A - B * B;
                    if (Total > Max)
                    {
                        Max = Total;
                        Opta = A;
                        Optb = B;
                    }
                       
                }
            Console.WriteLine(String.Format("{0:0.00}", Max));
            Console.WriteLine(Opta + " " + Optb);
        }
    }
}
