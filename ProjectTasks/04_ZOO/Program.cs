using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04_ZOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo.LifeInZoo();


        }
    }

    static class Zoo
    {
        static int hungryLion = 0;
        static int hungryMonkey = 0;
        static int hungryParrot = 0;
        static int feedTime = 0;

        public static void LifeInZoo()
        {
            while (true)
            {
                Thread.Sleep(5000);
                hungryLion++;
                hungryMonkey++;
                hungryParrot++;
                feedTime++;

                if (hungryLion >= 20)
                {
                    Console.WriteLine("Lew jest glodny");
                }
                else
                {
                    Console.WriteLine("Lew nie jest glodny");
                }
                if (hungryMonkey >= 10)
                {
                    Console.WriteLine("Malpa jest glodna");
                }
                else
                {
                    Console.WriteLine("Malopa nie jest glodna");
                }
                if (hungryParrot >= 4)
                {
                    Console.WriteLine("Papuga jest glodna");
                }
                else
                {
                    Console.WriteLine("Papuga nie jest glodna");
                }

                Console.WriteLine();

                if (feedTime >= 10)
                {
                    Console.WriteLine("Ktore zwierze chcesz nakarmic:");
                    Console.WriteLine("1. Lew");
                    Console.WriteLine("2. Malpa");
                    Console.WriteLine("3. Papuga");
                    Console.WriteLine();

                    int odpowiedz = int.Parse(Console.ReadLine());
                    if (odpowiedz == 1)
                    {
                        hungryLion = 0;
                        feedTime = 0;
                        Console.WriteLine("Lew zostal nakarmiony \n");
                    }
                    else if (odpowiedz == 2)
                    {
                        hungryMonkey = 0;
                        feedTime = 0;
                        Console.WriteLine("Malpa zostala nakarmiona \n");
                    }
                    else if (odpowiedz == 3)
                    {
                        hungryParrot = 0;
                        feedTime = 0;
                        Console.WriteLine("Papuga zostala nakarmiona \n");
                    }
                }
            }
        }
    }
}

