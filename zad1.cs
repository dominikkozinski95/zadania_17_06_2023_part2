using System;
namespace zad5
{
	public class zad1
	{
		public zad1()
		{
            Console.WriteLine("Program wypisujący n liczb pierwszych");
            Console.Write("Podaj wartość n: ");
            int n = int.Parse(Console.ReadLine());

            int liczba = 2; // Początkowa liczba do sprawdzenia
            int licznik = 0; // Licznik znalezionych liczb pierwszych

            while (licznik < n)
            {
                if (CzyLiczbaPierwsza(liczba))
                {
                    Console.WriteLine(liczba);
                    licznik++;
                }
                liczba++;
            }
        }

        static bool CzyLiczbaPierwsza(int liczba)
        {
            if (liczba < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(liczba); i++)
            {
                if (liczba % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

