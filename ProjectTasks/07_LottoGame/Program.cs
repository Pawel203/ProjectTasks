using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _07_LottoGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] coupon = new int[8, 6];
            Random generator = new Random();
            int[] corectNumbers = new int[6];
            int[] corect = new int[8];
            int numberOfCoupons = 0;
            int choice;
            string path = @"C:\Users\Paweł\Desktop\plik.txt";
            StreamWriter sw;
            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
                Console.WriteLine("Witaj w grze LOTTO");
                Console.ReadKey();
                Console.Clear();
                sw.Close();
            }
            else
            {
                sw = new StreamWriter(path, true);
                Console.WriteLine("Witaj ponownie w grze LOTTO");
                Console.ReadKey();
                Console.Clear();
                sw.Close();
            }
            StreamReader sr = File.OpenText(path);
            int day = int.Parse(sr.ReadLine());
            int money = int.Parse(sr.ReadLine());
            sr.Close();
            do
            {
                Console.WriteLine($"Ilosc wykonanych losowan: {day}");
                Console.WriteLine($"Ilosc pieniedzy: {money}\n");
                Console.WriteLine($"1. Dodaj kupon [{numberOfCoupons}/8] [KOSZT: 5]");
                Console.WriteLine($"2. Losuj");
                Console.WriteLine($"3. Zakoncz");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        money -= 5;
                        Console.Clear();
                        if (numberOfCoupons < 8)
                        {
                            Console.WriteLine("Podaj swoje liczby: ");
                            for (int i = 0; i < 6; i++)
                            {
                                int yourNumber = int.Parse(Console.ReadLine());
                                if (yourNumber > 0 && yourNumber <= 49)
                                {
                                    bool repeatNumber = false;
                                    for (int j = 0; j < coupon.GetLength(1); j++)
                                    {
                                        if (coupon[numberOfCoupons, j] == yourNumber)
                                        {
                                            repeatNumber = true;
                                            Console.WriteLine("Powtorzyles liczbe!");
                                            break;
                                        }
                                    }
                                    if (!(repeatNumber))
                                    {
                                        coupon[numberOfCoupons, i] = yourNumber;
                                    }
                                    else
                                    {
                                        i--;
                                    }
                                }
                                else
                                {
                                    i--;
                                }
                            }
                            numberOfCoupons++;
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Postawiles juz wszystkie mozliwe kupony");
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Zwycieskie liczby: ");
                        for (int i = 0; i < 6; i++)
                        {
                            int randomNumber = generator.Next(1, 50);
                            bool ifExists = corectNumbers.Contains(randomNumber);
                            if (!(ifExists))
                            {
                                corectNumbers[i] = randomNumber;
                                Console.Write($"{corectNumbers[i]} ");
                            }
                            else
                            {
                                i--;
                            }
                        }
                        Console.WriteLine();
                        for (int i = 0; i < numberOfCoupons; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                for (int k = 0; k < 6; k++)
                                {
                                    if (coupon[i, j] == corectNumbers[k])
                                    {
                                        corect[i]++;
                                    }
                                }
                            }
                        }
                        for (int i = 0; i < numberOfCoupons; i++)
                        {
                            switch (corect[i])
                            {
                                case 3:
                                    Console.WriteLine("Gratulacje wygrales 100zl");
                                    money += 100;
                                    break;
                                case 4:
                                    Console.WriteLine("Gratulacje wygrales 2000zl");
                                    money += 2000;
                                    break;
                                case 5:
                                    Console.WriteLine("Gratulacje wygrales 100000zl");
                                    money += 100000;
                                    break;
                                case 6:
                                    Console.WriteLine("Gratulacje wygrales 25000000zl");
                                    money += 25000000;
                                    break;
                            }
                        }
                        day++;
                        numberOfCoupons = 0;
                        Console.ReadKey();
                        Console.Clear();
                        coupon = new int[8, 6];
                        corect = new int[8];
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Dziekuje za gre!");
                        sw = new StreamWriter(path, false);
                        sw.WriteLine(day);
                        sw.WriteLine(money);
                        sw.Close();
                        break;
                }
            }
            while (choice == 1 || choice == 2);
            Console.ReadKey();
        }
    }
}

