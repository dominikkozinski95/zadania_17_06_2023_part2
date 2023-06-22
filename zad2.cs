using System;
namespace zad5
{
	public class zad2
	{
		public zad2()
		{
            Console.WriteLine("Program wypisujący n liczb parzystych z przedziału [-8, 8]");
            Console.Write("Podaj wartość n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Wersja 1 - Sprawdzanie poprawności losowania po losowaniu:");
            WypiszLiczbyParzyste_Wersja1(n);

            Console.WriteLine("\nWersja 2 - Losowanie liczby parzystej od razu:");
            WypiszLiczbyParzyste_Wersja2(n);
        }

        static void WypiszLiczbyParzyste_Wersja1(int n)
        {
            Random random = new Random();
            int licznik = 0;

            for (int i = 0; i < n; i++)
            {
                int liczba = random.Next(-8, 9);

                if (liczba % 2 == 0)
                {
                    Console.Write(liczba);

                    licznik++;
                    if (licznik < n && liczba != 8) // Dodawanie przecinka i spacji, o ile nie jest to ostatnia liczba
                    {
                        Console.Write(", ");
                    }
                }
                else
                {
                    i--; // Ponowne losowanie, gdy liczba nieparzysta
                }
            }

            Console.WriteLine("\nIlość rzeczywistych losowań: " + licznik);
        }

        static void WypiszLiczbyParzyste_Wersja2(int n)
        {
            Random random = new Random();
            int licznik = 0;

            for (int i = 0; i < n; i++)
            {
                int liczba = random.Next(-4, 5) * 2;

                Console.Write(liczba);

                licznik++;
                if (licznik < n && liczba != 8) // Dodawanie przecinka i spacji, o ile nie jest to ostatnia liczba
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("\nIlość rzeczywistych losowań: " + licznik);
        }
    }
}

