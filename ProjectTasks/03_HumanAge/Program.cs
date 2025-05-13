using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_HumanAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wiek");
            int wiek = int.Parse(Console.ReadLine());

            if (wiek <= 0)
            {
                Console.WriteLine("Wiek jest nieprawdziwy");
            }
            else
            {
                if (wiek == 1)
                {
                    Console.WriteLine("Bobas");
                }
                else if (wiek > 1 && wiek < 18)
                {
                    Console.WriteLine("Dziecko");
                }
                else if (wiek >= 18 && wiek < 65)
                {
                    Console.WriteLine("Dorosly");
                }
                else if (wiek >= 65)
                {
                    Console.WriteLine("Starzec");
                }
            }
        }
    }
}
