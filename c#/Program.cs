using System;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Xml;

namespace proccsharp
{
    public class Trida
    {
        public string jmeno { get; set; }
        public int pocetZaku { get; set; }
        public double pvaPrumer { get; set; }

        public Trida(string name, int numberOfStudents, double pvaAverage)
        {
            jmeno = name;
            pocetZaku = numberOfStudents;
            pvaPrumer = pvaAverage;
        }

        public string Obsah()
        {
            return $"jmeno = {jmeno}, pocet zaku = {pocetZaku}, prumer z pva = {pvaPrumer}";
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Trida trida1 = new Trida("1.k", 35, 1.0);
            Trida trida2 = new Trida("1.g", 12, 4.7); 
            Trida trida3 = new Trida("1.c", 33, 1.7);
            Trida trida4 = new Trida("1.b", 27, 2.0);

            Trida[] poleTrid = { trida1, trida2, trida3, trida4 };

            for (int i = 0; i < poleTrid.Length; i++)
            {
                if (poleTrid[i].pvaPrumer < 2.5)
                {
                    Console.WriteLine(poleTrid[i].Obsah());
                }
            }
        }
    }
}