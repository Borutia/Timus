using System;

class Program
{
    struct coord
    {
        public double x, y;
    };

    static void Main(string[] args)
    {
        coord A, B, C;
        var s = Console.ReadLine().Split();
        A.x = double.Parse(s[0]);
        A.y = double.Parse(s[1]);
        s = Console.ReadLine().Split();
        B.x = double.Parse(s[0]);
        B.y = double.Parse(s[1]);
        s = Console.ReadLine().Split();
        C.x = double.Parse(s[0]);
        C.y = double.Parse(s[1]);
        
        coord Ha, Hb, Hc;
        Hc.x = (A.x + B.x) / 2.0;
        Hc.y = (A.y + B.y) / 2.0;
        Hb.x = (A.x + C.x) / 2.0;
        Hb.y = (A.y + C.y) / 2.0;
        Ha.x = (B.x + C.x) / 2.0;
        Ha.y = (B.y + C.y) / 2.0;
        
        coord Ain, Bin, Cin;
        Cin.x = Hc.x + (C.x - Hc.x) / 6.0;
        Cin.y = Hc.y + (C.y - Hc.y) / 6.0;
        Bin.x = Hb.x + (B.x - Hb.x) / 6.0;
        Bin.y = Hb.y + (B.y - Hb.y) / 6.0;
        Ain.x = Ha.x + (A.x - Ha.x) / 6.0;
        Ain.y = Ha.y + (A.y - Ha.y) / 6.0;
        
        coord vHC, vHB, vHA;
        vHC.x = C.x - Hc.x;
        vHC.y = C.y - Hc.y;
        vHB.x = B.x - Hb.x;
        vHB.y = B.y - Hb.y;
        vHA.x = A.x - Ha.x;
        vHA.y = A.y - Ha.y;
        
        coord Aex, Bex, Cex;
        Cex.x = Bin.x - vHC.x * 5.0 / 6.0;
        Cex.y = Bin.y - vHC.y * 5.0 / 6.0;
        Bex.x = Ain.x - vHB.x * 5.0 / 6.0;
        Bex.y = Ain.y - vHB.y * 5.0 / 6.0;
        Aex.x = Cin.x - vHA.x * 5.0 / 6.0;
        Aex.y = Cin.y - vHA.y * 5.0 / 6.0;
        
        Console.WriteLine("{0} {1}", Ain.x, Ain.y);
        Console.WriteLine("{0} {1}", Bin.x, Bin.y);
        Console.WriteLine("{0} {1}", Cin.x, Cin.y);
        Console.WriteLine("{0} {1}", Aex.x, Aex.y);
        Console.WriteLine("{0} {1}", Bex.x, Bex.y);
        Console.WriteLine("{0} {1}", Cex.x, Cex.y);
    }
}