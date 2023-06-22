using System;
namespace zad5
{
    public class zad3
    {
        public zad3()
        {
            Console.WriteLine("Program rysujący trójkąt złożony ze znaków +");
            Console.Write("Podaj wysokość trójkąta: ");
            int wysokosc = int.Parse(Console.ReadLine());

            RysujTrojkat(wysokosc);
        }


        static void RysujTrojkat(int wysokosc)
        {
            int srodek = wysokosc - 1; // Indeks środka trójkąta
            int szerokosc = 1; // Szerokość wiersza (ilość znaków +)

            for (int i = 0; i < wysokosc; i++)
            {
                int poczatek = srodek - (szerokosc / 2); // Indeks początku wiersza

                for (int j = 0; j < poczatek; j++)
                {
                    Console.Write(" "); // Wypełnienie miejsc przed początkiem wiersza spacjami
                }

                for (int j = 0; j < szerokosc; j++)
                {
                    Console.Write("+"); // Rysowanie znaku "+" w wierszu
                }

                Console.WriteLine(); // Zakończenie wiersza

                szerokosc += 2; // Zwiększenie szerokości wiersza o 2
            }
        }
    }
}

