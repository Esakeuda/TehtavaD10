using System;

namespace KertotauluOhjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Syötä kokonaisluku välillä 1 - 10: ");
                int luku = int.Parse(Console.ReadLine());

                // Tarkistetaan, että syöte on sallitulla välillä
                if (luku >= 1 && luku <= 10)
                {
                    // Tulostetaan kertotaulu käyttäen for-silmukkaa
                    for (int i = 1; i <= 10; i++)
                    {
                        int tulos = luku * i;
                        Console.WriteLine($"{luku} x {i} = {tulos}");
                    }
                }
                else
                {
                    Console.WriteLine("Syöte ei ole sallitulla välillä.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Virheellinen syöte. Syötä kokonaisluku.");
            }
        }
    }
}

