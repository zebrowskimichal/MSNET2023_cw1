using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj szerokość: ");
            string xs = Console.ReadLine();
            Console.WriteLine("Podaj wysokość: ");
            string ys = Console.ReadLine();

            int x = int.Parse(xs);
            int y = int.Parse(ys);

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    class program2
    {
        static void Main1(string[] args)
        {
            Random rnd = new Random();
            int los = rnd.Next(1, 11);

            int mojaliczba;
            int ileRazy = 0;

            Console.WriteLine("Zgadnij liczbę z zakresu 1-10");
            do
            {

                Console.Write("Podaj liczbę: ");
                mojaliczba = int.Parse(Console.ReadLine());
                if (mojaliczba > 10 || mojaliczba < 1)
                {
                    Console.WriteLine("Liczba z poza zakresu");
                }
                else
                {
                    ileRazy++;
                    if (mojaliczba > los)
                    {
                        Console.WriteLine("Podałeś zbyt dużą liczbę ");
                    }
                    else if (mojaliczba < los)
                    {
                        Console.WriteLine("Podałeś zbyt małą liczbę ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Brawo odgadłeś moją liczbę! Za {0} razem", ileRazy);
                    }
                }
            } while (los != mojaliczba);
             Console.ReadKey();
            }
        }
    }

