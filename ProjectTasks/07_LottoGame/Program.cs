using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_LottoGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = 0;
            int money = 100;
            int[] coupon = new int[6]; //liczby podane przez uzytkownika
            Random generator = new Random();
            int[] corectNumbers = new int[6];
            int corect = 0;


            Console.WriteLine($"Ilosc wykonanych losowan: {day}");
            Console.WriteLine($"Ilosc pieniedzy: {money}");

            Console.WriteLine("Podaj swoje liczby: ");
            for (int i = 0; i < 6; i++)
            {
                int yourNumber = int.Parse(Console.ReadLine());
                if (yourNumber > 0 && yourNumber <= 49)
                {
                    bool repeatNumber = coupon.Contains(yourNumber);
                    if(!(repeatNumber))
                    {
                        coupon[i] = yourNumber;
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

                Console.WriteLine(coupon[i]);
            }


            for (int i = 0; i < 6; i++)
            {
                int randomNumber = generator.Next(1, 10);
                bool ifExists = corectNumbers.Contains(randomNumber);
                if (!(ifExists))
                {
                    corectNumbers[i] = randomNumber;
                    Console.WriteLine($"{i}. {corectNumbers[i]}");
                }
                else
                {
                    i--;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (coupon[i] == corectNumbers[j])
                    {
                        corect++;
                    }
    }
            }
            Console.WriteLine(corect);

            Console.ReadKey();
        }
    }
}
