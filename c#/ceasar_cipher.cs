using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numeroSkip = false;
            bool decencSkip = false;
            char[] charArray = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] charARRAY = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int numero = 0;
            char encdec = 'e';
            string stringz1 = "enc";
            while (0 == 0) {
                if (numeroSkip == false)
                {
                    Console.Write("Number you wanna work with: ");
                    string stringz = Console.ReadLine();
                    bool trash = int.TryParse(stringz, out numero);
                    if (numero >= 26 || trash == false)
                    {
                        Console.WriteLine("Looks like number is too big or not a number. Try smaller one or message us at \"/dev/null\".");
                        continue;
                    }
                    numeroSkip = true;
                }

                if (decencSkip == false)
                {
                    Console.Write("Wanna decrypt or encrypt? ('d' or 'e'): ");
                    stringz1 = Console.ReadLine();
                    bool trash = char.TryParse(stringz1, out encdec);
                    if (encdec == 'd')
                    {
                        numero = 26 - numero;
                    }
                    else if (encdec != 'e')
                    {
                        Console.WriteLine("Looks like input is not 'dec' or 'enc'. Try again or message us at \"/dev/null\"");
                        continue;
                    }
                }

                Console.Write("Text you wanna work with: ");
                string stringz2 = Console.ReadLine();
                char[] charOfInput = stringz2.ToCharArray();

                foreach (char ch in charOfInput)
                {
                    char output = ' ';
                    foreach (char cha in charArray) 
                    {
                        int indexor = Array.IndexOf(charArray, ch);
                        if (ch == cha && indexor + numero < 26)
                        {
                            output = charArray[indexor + numero];
                        }
                        else if (ch == cha && indexor + numero >= 26)
                        { 
                            int indexator = numero - (26 - indexor);
                            output = charArray[indexator];
                        }
                    }

                    if (output == ' ')
                    {
                        foreach (char cha in charARRAY) 
                        {
                            int indexor = Array.IndexOf(charARRAY, ch);
                            if (ch == cha && indexor + numero < 26)
                            {
                                output = charARRAY[indexor + numero];
                            }
                            else if (ch == cha && indexor + numero >= 26)
                            { 
                                int indexator = numero - (26 - indexor);
                                output = charARRAY[indexator];
                            }
                        }
                    }

                    if (output == ' ')
                    {
                        Console.Write(ch);
                    }
                    else
                    {
                        Console.Write(output);
                    }
                }
                Console.WriteLine("\n");

                numeroSkip = false;
            }
        }
    }
}