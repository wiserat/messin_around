using System;
using System.Text;

namespace classes
{
    internal class Program
    {
        public struct Bod
        {
            public double x;
            public double y;
        }
        
        public struct Usecka
        {
            public Bod zacatek;
            public Bod konec;
        }
        
        public static void Main(string[] args)
        {
            Bod b1;
            b1.x = 8.2;
            b1.y = 9.2;
            
            Bod b2;
            b2.x = 3.4;
            b2.y = 9.4;
            
            Bod b3;
            b3.x = 5.3;
            b3.y = 7.1;
            
            Bod b4;
            b4.x = 6.9;
            b4.y = 2.4;

            Usecka u1;
            u1.zacatek = b1;
            u1.konec = b4;
            
            Usecka u2;
            u2.zacatek = b2;
            u2.konec = b3;

            Usecka[] usecky = { u1, u2 };

            foreach (var u in usecky)
            {
                Console.WriteLine($"{u.zacatek.x} a {u.zacatek.y}");
                Console.WriteLine($"{u.konec.x} a {u.konec.y}");
            }
        }
    }
}