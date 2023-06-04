using System;

namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // zalozeni novych kruznic
            Kruznice kruznice1 = new Kruznice(5, -8.8, -2);
            Kruznice kruznice2 = new Kruznice(1.5, -3.0, -3);
            
            // zkouska
            Console.WriteLine(kruznice1.Plocha());
            Console.WriteLine(kruznice2.Obvod());
            Console.WriteLine(kruznice1.Protnuti(kruznice2));
        }
    }
    
    // souradnice teziste
    public class GeometrickyObjekt
    {
        public double Y { get; set; } 
        public double X { get; set; } 
        
        public GeometrickyObjekt(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    // trida Kruznice postavena na predesle tride GeometrickYObjekt
    public class Kruznice : GeometrickyObjekt
    {
        private double _r;
        public double Polomer       // kontrola jestli polomer neni zaporny nebo 0                                                     
        {                                                                                  
            get { return _r; }                                                              
            set                                                                            
            {                                                                              
                if (value > 0)                                                             
                {                                                                          
                    _r = value;                                                             
                }                                                                          
                else                                                                       
                {                                                                          
                    throw new Exception("Poloměr musí být kladný");                        
                }                                                                          
            }                                                                              
        }                                                                                  
        
        public Kruznice(double polomer, double x, double y) : base(x, y)
        {
            Polomer = polomer;
        }
        

        // metody...
        public double Obvod()
        {
            return 2 * Math.PI * _r;
        }
        public double Plocha()
        {
            return _r * _r * Math.PI;
        }
        public bool Protnuti(Kruznice jinaKruznice)
        {
            double vzdalenost = Math.Sqrt(Math.Pow(X - jinaKruznice.X, 2) + Math.Pow(Y - jinaKruznice.Y, 2));
            return vzdalenost <= _r + jinaKruznice._r;
        }
    }
}