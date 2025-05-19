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
            Console.WriteLine("podaj wielskosc kwadratu");
            int rozmiarKwadratu = int.Parse(Console.ReadLine());

            TopBottomSquere(rozmiarKwadratu);
            Checked_2(rozmiarKwadratu);
            TopBottomSquere(rozmiarKwadratu);
        }

        static void TopBottomSquere(int dlugosc)
        {
            for (int i = 0; i < dlugosc+2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        public static void Checked_2(int rozmiar) 
        {
            for (int i = 0; i < rozmiar; i++)
            {
                Console.Write("*");
                for (int j = 0; j < rozmiar; j++)
                {
                    if (j == i || j == rozmiar - 1 - i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("*");
            }
        }

        public static void Checked(int rozmiar)
        {
            int space = rozmiar - 4;
            int space2 = 0;

            for (int i = 0; i < rozmiar - 2; i += 2)
            {
                if (rozmiar % 2 == 1)
                {
                    Console.Write($"*-");
                }
                else
                {
                    Console.Write($"*--");
                }

                for (int j = 0; j < space2; j++)
                {
                    Console.Write("-");
                }

                if (space >= 0)
                {
                    Console.Write("*");
                }

                for (int j = 0; j < space; j++)
                {
                    Console.Write("--");
                }
                if (space % 2 == 1)
                {
                    Console.Write("-");
                }

                Console.Write("*");

                for (int j = 0; j < space2; j++)
                {
                    Console.Write("-");
                }

                if (space >= 0)
                {
                    if (rozmiar % 2 == 1)
                    {
                        Console.WriteLine($"-* {space}, {space2}");
                        space -= 2;
                        space2 += 2;
                    }
                    else
                    {
                        Console.WriteLine($"--* {space}, {space2}");
                        space -= 2;
                        space2 += 2;
                    }
                }
                else
                {
                    Console.WriteLine($"-* {space}, {space2}");
                }
            }

            space += 2;
            space2 -= 2;

            for (int i = 0; i < rozmiar - 2; i += 2)
            {
                if (space2 < 0)
                {
                    break;
                }
                else
                {
                    if (rozmiar % 2 == 1)
                    {
                        Console.Write($"*-");
                    }
                    else
                    {
                        Console.Write($"*--");
                    }

                    for (int j = 0; j < space2; j++)
                    {
                        Console.Write("-");
                    }

                    if (space >= 0)
                    {
                        Console.Write("*");
                    }

                    for (int j = 0; j < space; j++)
                    {
                        Console.Write("--");
                    }

                    if (space % 2 == 1)
                    {
                        Console.Write("-");
                    }

                    Console.Write("*");

                    for (int j = 0; j < space2; j++)
                    {
                        Console.Write("-");
                    }

                    if (rozmiar % 2 == 1)
                    {
                        Console.WriteLine($"-* {space}, {space2}");
                        space += 2;
                        space2 -= 2;
                    }
                    else
                    {
                        Console.WriteLine($"--* {space}, {space2}");
                        space += 2;
                        space2 -= 2;
                    }
                }
            }
        }
    }
}

