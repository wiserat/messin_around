using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i <= 1000; i++)
            {
                numeros.Add(i);
            }

            bool isNumerable = true;
            foreach (int n in numeros)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i == 1 || i == n)
                    {
                        continue;
                    } 
                    else if (n % i == 0)
                    {
                        isNumerable = false;
                        break;
                    }
                }

                if (isNumerable == true)
                {
                    Console.WriteLine(n);
                }
                else
                {
                    isNumerable = true;
                }
            }
        }
    }
}