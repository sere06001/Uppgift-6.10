using System;
namespace uppgift6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening som innehåller tal så kommer programmet räkna antalet tal du skrev");
            string svar = Console.ReadLine();
            int antalTal = AntalTalIText(svar);
            Console.WriteLine();
            Console.WriteLine($"Det finns {antalTal} tal i texten.");
            Console.ReadKey();
        }
        static int AntalTalIText(string mening)
        {
            int antal = 0;
            string[] ord = mening.Split();
            for (int i = 0; i < ord.Length; i++)
            {
                bool checka = double.TryParse(ord[i], out double tal);
                if (checka)
                {
                    antal++;
                }
            }
            return antal;
        }
    }
}