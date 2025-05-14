using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AddSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dowolny ciag znakow");
            string ciagZnakow = Console.ReadLine();

            for (int i = 0; i < ciagZnakow.Length; i++)
            {
                Console.Write($"{ciagZnakow[i]} ");
            }
        }
    }
}
