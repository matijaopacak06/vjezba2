using System;

namespace PronalazakNajcescegZnaka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite niz znakova: ");
            string nizZnakova = Console.ReadLine();

            char najcesciZnak = PronadjiNajcesciZnak(nizZnakova);
            int brojPonavljanja = BrojPonavljanjaZnaka(nizZnakova, najcesciZnak);

            Console.WriteLine($"Najcesci znak je: {najcesciZnak}, pojavljuje se {brojPonavljanja} puta.");
        }

        static char PronadjiNajcesciZnak(string nizZnakova)
        {
            int[] brojac = new int[200]; 

            foreach (char znak in nizZnakova)
            {
                brojac[znak]++;
            }

            char najcesciZnak = ' ';
            int najcescePonavljanje = 0;

            for (int i = 0; i < 256; i++)
            {
                if (brojac[i] > najcescePonavljanje)
                {
                    najcescePonavljanje = brojac[i];
                    najcesciZnak = (char)i;
                }
            }

            return najcesciZnak;
        }

        static int BrojPonavljanjaZnaka(string nizZnakova, char znak)
        {
            int brojPonavljanja = 0;

            foreach (char c in nizZnakova)
            {
                if (c == znak)
                {
                    brojPonavljanja++;
                }
            }

            return brojPonavljanja;
        }
    }
}
