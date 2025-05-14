using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DisplaySquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj wielskosc kwadratu liczba");
            int rozmiarKwadratu = int.Parse(Console.ReadLine());

            TopBottomSquere(rozmiarKwadratu);

            for (int i = 0; i < rozmiarKwadratu - 2; i++)
            {
                Console.Write(" *");
                for (int j = 0; j < rozmiarKwadratu - 2; j++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine(" *");
            }

            TopBottomSquere(rozmiarKwadratu);

        }
        static void TopBottomSquere(int dlugosc) 
        {
            for (int i = 0; i < dlugosc; i++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
}
