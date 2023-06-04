using System;

namespace classesfr
{
    class Osoba
    { 
        string jmeno;
        string prijmeni;
        string rodneCislo;

        // Toto je konstruktor - nemá návratovou hodnotu a jmenuje se jako 
        // jeho třída
        public Osoba(string name, string surname, string bornID)
        {
            jmeno = name;
            prijmeni = surname;
            rodneCislo = bornID;
        }

        public string CoJsem()
        {
            return $"Jméno: {jmeno}\tPříjmení: {prijmeni}\tRodné číslo: {rodneCislo}";
        }

        public void ZmenJmeno(string namen, string lastenNamen)
        {
            jmeno = namen;
            prijmeni = lastenNamen;
        }

        public void ZmenRodne(string rodneCislicko)
        {
            if (rodneCislicko.Length == 11)
            {
                for (int i = 0; i < rodneCislicko.Length; i++)
                {
                    if (i == 6 && rodneCislicko[i] == '/')
                    {
                        continue;
                    }
                    else if (i == 6)
                    {
                        rodneCislicko = rodneCislo;
                        break;
                    }

                    if (!Char.IsDigit(rodneCislicko[i]))
                    {
                        rodneCislicko = rodneCislo;
                        Console.Write("spatne rodne cislo");
                        break;
                    }
                }

                rodneCislo = rodneCislicko;
            }
        }
    }

    class Programator : Osoba
    {
        public string prgJazyk;
		
        // Toto je konstruktor - nemá návratovou hodnotu a jmenuje se jako 
        // jeho třída. 
        public Programator(string name, string surname, string bornID, string prgLanguage) : base(name, surname, bornID)
        {
            if (prgLanguage == "java" || prgLanguage == "rust" || prgLanguage == "python" ||
                prgLanguage == "javascript" || prgLanguage == "gay")
            {
                prgJazyk = prgLanguage;
            }
            else
            {
                prgJazyk = "ostatni";
            }
        }

        public string CoJsem()
        {
            return base.CoJsem() + '\t' + "Programovací jazyk: " + prgJazyk;
        }

        public static void Main()
        {
            Osoba osoba = new Osoba("Vlastimil", "Borovec", "880611/0220");
            Programator programator = new Programator("Vlastimil", "Borovec", "880611/0220", "Python");
			
            Console.WriteLine(osoba.CoJsem());
            Console.WriteLine(programator.CoJsem());

            Osoba osoba2 = new Osoba("jarda", "gay", "666666/6666");
            Console.WriteLine(osoba2.CoJsem());
            osoba2.ZmenRodne("777777/7777");
            Console.WriteLine(osoba2.CoJsem());
            osoba2.ZmenJmeno("gaylord", "jebal");
            Console.WriteLine(osoba2.CoJsem());
        }
    }
}