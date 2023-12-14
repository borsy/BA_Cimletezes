using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Kérem, adjon meg egy összeget:");

        // Felhasználótól bekérjük az összeget
        int osszeg = Convert.ToInt32(Console.ReadLine());

        // Fizetőeszközök
        int[] fizetoeszkozok = { 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

        Console.WriteLine($"Az alábbi fizetőeszközökkel teljesíthető az összeg {osszeg}:");

        // Fizetőeszközök kiírása
        foreach (int fizetoeszkoz in fizetoeszkozok)
        {
            int darab = osszeg / fizetoeszkoz;
            if (darab > 0)
            {
                Console.WriteLine($"{darab} db {fizetoeszkoz}");
                osszeg %= fizetoeszkoz;
            }
        }

        Console.ReadLine();
    }
}